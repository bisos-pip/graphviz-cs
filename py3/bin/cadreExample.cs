#!/usr/bin/env python

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

from bisos import b
from bisos.b import cs

import graphviz
import sys
import os

from bisos.graphviz import graphvizSeed
from bisos.graphviz import graphvizCadre

ng = graphvizSeed.namedGraph


####+BEGIN: b:py3:cs:func/typing :funcName "cadreHelloWorld" :funcType "Typed" :deco "track"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  F-T-Typed  [[elisp:(outline-show-subtree+toggle)][||]] /cadreHelloWorld/  deco=track  [[elisp:(org-cycle)][| ]]
#+end_org """
@cs.track(fnLoc=True, fnEntry=True, fnExit=True)
def cadreHelloWorld(
####+END:
) -> graphviz.Digraph:
    """ #+begin_org
** [[elisp:(org-cycle)][| *DocStr | ]
    #+end_org """

    dot = graphviz.Digraph('HelloWorld', comment='Simple Hello World with Cadre')
    graphvizCadre.cadreDiagram(dot, 'Hello World with Cadre', 'LR')

    with dot.subgraph(name='cluster_cadre') as cadre:
        pads = graphvizCadre.cadreApply(cadre, 'hw')
        with cadre.subgraph(name='cluster_content_hw') as content:
            graphvizCadre.cadreInnerContentBand(content)

            with content.subgraph(name='cluster_main') as main:
                graphvizCadre.cadreCluster(main, 'Greeting', '#1f77b4')
                main.node('hello', 'Hello', fillcolor='#dbeeff', shape='ellipse')
                main.node('world', 'World', fillcolor='#dbeeff', shape='ellipse')
                main.edge('hello', 'world')

    graphvizCadre.cadreSpacerConstraints(
        dot,
        'LR',
        pads,
        top_anchors=['hello'],
        bottom_anchors=['world'],
        left_anchors=['hello'],
        right_anchors=['world'],
        weight='20',
        minlen='1',
    )

    return dot



####+BEGIN: b:py3:cs:orgItem/basic :type "=Seed Setup= " :title "*Common Facilities*" :comment "General"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  =Seed Setup=  [[elisp:(outline-show-subtree+toggle)][||]] *Common Facilities* General  [[elisp:(org-cycle)][| ]]
#+end_org """
####+END:


namedGraphsList = [
    ng("cadreHelloWorld", func=cadreHelloWorld),   #
]


graphvizSeed.setup(
    seedType="common",
    namedGraphsList=namedGraphsList,
    # examplesHook=qmail_binsPrep.examples_csu,
)
