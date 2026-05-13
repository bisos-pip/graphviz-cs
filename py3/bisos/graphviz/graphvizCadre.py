

####+BEGIN: b:prog:file/particulars :authors ("./inserts/authors-mb.org")
""" #+begin_org
* *[[elisp:(org-cycle)][| Particulars |]]* :: Authors, version
** This File: /bisos/git/auth/bxRepos/bisos-pip/binsprep/py3/bin/exmpl-func-binsPrep.cs
** Authors: Mohsen BANAN, http://mohsen.banan.1.byname.net/contact
#+end_org """
####+END:

""" #+begin_org
* Panel::  [[file:/bisos/panels/bisos-apps/lcnt/lcntScreencasting/subTitles/_nodeBase_/fullUsagePanel-en.org]]
* Overview and Relevant Pointers
#+end_org """

import graphviz

def cadreDiagram(
    dot: graphviz.Digraph,
    title: str,
    rankdir: str,
) -> None:
    """Apply a consistent diagram-wide frame and default node/edge style."""

    dot.attr(
        rankdir=rankdir,
        size='16,9!',
        ratio='fill',
        dpi='192',
        pad='0.30',
        margin='0.12',
        nodesep='0.65',
        ranksep='0.95',
        fontname='Arial',
        fontsize='18',
        labelloc='t',
        splines='polyline',
    )
    dot.attr(label=title)
    dot.attr('node', shape='box', style='filled,rounded', fontname='Arial', fontsize='14', margin='0.14,0.10')
    dot.attr('edge', fontname='Arial', fontsize='12', penwidth='1.4')


def cadreCluster(
    cluster: graphviz.Digraph,
    label: str,
    color: str,
    penwidth: str = '2.2',
    style: str = 'rounded',
    fontsize: str = '16',
    margin: str = None,
) -> None:
    """Apply consistent cluster framing across all diagrams."""

    attrs = dict(
        label=label,
        style=style,
        color=color,
        penwidth=penwidth,
        fontsize=fontsize,
    )
    if margin is not None:
        attrs['margin'] = margin
    cluster.attr(**attrs)


def cadreApply(
    cadre: graphviz.Digraph,
    suffix: str,
) -> tuple[str, str, str, str]:
    """Apply visible outer border and return 4 spacer pad node names."""

    top_pad = f'cadre_top_pad_{suffix}'
    bottom_pad = f'cadre_bottom_pad_{suffix}'
    left_pad = f'cadre_left_pad_{suffix}'
    right_pad = f'cadre_right_pad_{suffix}'

    cadre.attr(label='', style='rounded', color='#8b0000', penwidth='6')
    cadre.node(top_pad, '', shape='box', style='invis', width='0.01', height='0.01', fixedsize='true')
    cadre.node(bottom_pad, '', shape='box', style='invis', width='0.01', height='0.01', fixedsize='true')
    cadre.node(left_pad, '', shape='box', style='invis', width='0.01', height='0.01', fixedsize='true')
    cadre.node(right_pad, '', shape='box', style='invis', width='0.01', height='0.01', fixedsize='true')

    with cadre.subgraph(name=f'cluster_cadre_left_pad_{suffix}') as left_rank:
        left_rank.attr(rank='min')
        left_rank.node(left_pad)
    with cadre.subgraph(name=f'cluster_cadre_right_pad_{suffix}') as right_rank:
        right_rank.attr(rank='max')
        right_rank.node(right_pad)

    return top_pad, bottom_pad, left_pad, right_pad


def cadreInnerContentBand(
    content: graphviz.Digraph,
    margin: str = '0.80,0.45',
) -> None:
    """Create inner content area to enforce white band inside the cadre."""

    content.attr(label='', style='invis', margin=margin)


def cadreSpacerConstraints(
    dot: graphviz.Digraph,
    rankdir: str,
    pads: tuple[str, str, str, str],
    top_anchors: list[str],
    bottom_anchors: list[str],
    left_anchors: list[str],
    right_anchors: list[str],
    weight: str = '25',
    minlen: str = '2',
) -> None:
    """Apply common invisible constraints to keep graph content off all cadre edges."""

    top_pad, bottom_pad, left_pad, right_pad = pads

    if rankdir == 'TB':
        for anchor in top_anchors:
            dot.edge(top_pad, anchor, style='invis', weight=weight, minlen=minlen)
        for anchor in bottom_anchors:
            dot.edge(anchor, bottom_pad, style='invis', weight=weight, minlen=minlen)
    else:
        for anchor in top_anchors:
            dot.edge(anchor, top_pad, style='invis', weight=weight, minlen=minlen)
        for anchor in bottom_anchors:
            dot.edge(bottom_pad, anchor, style='invis', weight=weight, minlen=minlen)

    if rankdir == 'LR':
        for anchor in left_anchors:
            dot.edge(left_pad, anchor, style='invis', weight=weight, minlen=minlen)
        for anchor in right_anchors:
            dot.edge(anchor, right_pad, style='invis', weight=weight, minlen=minlen)
    else:
        for anchor in left_anchors:
            dot.edge(anchor, left_pad, style='invis', weight=weight, minlen=minlen)
        for anchor in right_anchors:
            dot.edge(right_pad, anchor, style='invis', weight=weight, minlen=minlen)

