#!/usr/bin/env python

####+BEGIN: b:prog:file/particulars :authors ("./inserts/authors-mb.org")
""" #+begin_org
* *[[elisp:(org-cycle)][| Particulars |]]* :: Authors, version
** This File: /bisos/git/bxRepos/bisos-pip/graphviz-cs/py3/examples/exmpl-graphviz.cs
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

from bisos.graphviz import graphvizSeed
ng = graphvizSeed.namedGraph


####+BEGIN: b:py3:cs:func/typing :funcName "hello" :funcType "Typed" :deco "track"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  F-T-Typed  [[elisp:(outline-show-subtree+toggle)][||]] /hello/  deco=track  [[elisp:(org-cycle)][| ]]
#+end_org """
@cs.track(fnLoc=True, fnEntry=True, fnExit=True)
def hello(
####+END:
) -> graphviz.Digraph:
    """ #+begin_org
** [[elisp:(org-cycle)][| *DocStr | ]
    #+end_org """

    g = graphviz.Digraph('G',)

    g.edge('Hello', 'World')

    return g


####+BEGIN: b:py3:cs:func/typing :funcName "graphvizLayers" :funcType "Typed" :deco "track"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  F-T-Typed  [[elisp:(outline-show-subtree+toggle)][||]] /graphvizLayers/  deco=track  [[elisp:(org-cycle)][| ]]
#+end_org """
@cs.track(fnLoc=True, fnEntry=True, fnExit=True)
def graphvizLayers(
####+END:
) -> graphviz.Digraph:
    """ #+begin_org
** [[elisp:(org-cycle)][| *DocStr | ]
    #+end_org """

    d = graphviz.Digraph()

    with d.subgraph() as s:
        s.attr(rank='same')
        s.node('seededCsSpec1', 'Graphviz-Spec\n 1\n', shape='rectangle', style='filled', fillcolor='green')
        s.node('seededCsSpecDots', 'Graphviz-Spec\n ...', shape='rectangle', style='filled', fillcolor='green')
        s.node('seededCsSpecN', 'Graphviz-Spec\n N', shape='rectangle', style='filled', fillcolor='green')

    with d.subgraph() as s:
        s.attr(rank='same')
        s.node('graphvizSeed', 'Graphviz\n Seeded-PyCS\nhttps://github.com/bisos-pip/graphviz-cs', style='filled', fillcolor='darkseagreen3')
        s.node('pycs', 'Python\nCommand Services\n (PyCS)\nhttps://github.com/bisos-pip/pycs', style='filled', fillcolor='darkseagreen3')

    with d.subgraph() as s:
        s.attr(rank='same')
        s.node('pyGraphviz', 'Python Graphviz\nhttps://github.com/xflr6/graphviz', style='filled', fillcolor='deepskyblue')

    with d.subgraph() as s:
        s.attr(rank='same')
        s.node('graphviz', 'Graphviz.org', style='filled', fillcolor='deepskyblue')

    with d.subgraph() as s:
        s.attr(rank='same')
        s.node('pdf', 'pdf', shape='cylinder', style='filled', fillcolor='darksalmon')
        s.node('svg', 'svg', shape='cylinder', style='filled', fillcolor='darksalmon')
        s.node('etcOutput', '...', shape='cylinder', style='filled', fillcolor='darksalmon')
        s.node('png', 'png', shape='cylinder', style='filled', fillcolor='darksalmon')
        s.node('jpeg', 'jpeg', shape='cylinder', style='filled', fillcolor='darksalmon')

    d.edge('seededCsSpec1', 'graphvizSeed')
    d.edge('seededCsSpecDots', 'graphvizSeed')
    d.edge('seededCsSpecN', 'graphvizSeed')

    d.edge('graphvizSeed', 'pycs')
    d.edge('graphvizSeed', 'pyGraphviz')

    d.edge('pyGraphviz', 'graphviz')

    d.edge('graphviz', 'pdf')
    d.edge('graphviz', 'svg')
    d.edge('graphviz', 'png')
    d.edge('graphviz', 'jpeg')
    d.edge('graphviz', 'etcOutput')

    return d



####+BEGIN: b:py3:cs:func/typing :funcName "colors" :funcType "Typed" :deco "track"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  F-T-Typed  [[elisp:(outline-show-subtree+toggle)][||]] /colors/  deco=track  [[elisp:(org-cycle)][| ]]
#+end_org """
@cs.track(fnLoc=True, fnEntry=True, fnExit=True)
def colors(
####+END:
) -> graphviz.Digraph:
    """ #+begin_org
** [[elisp:(org-cycle)][| *DocStr | ]
    #+end_org """

    g = graphviz.Graph()

    red, green, blue = 64, 224, 208
    assert f'#{red:x}{green:x}{blue:x}' == '#40e0d0'

    g.node('RGB: #40e0d0', style='filled', fillcolor='#40e0d0')

    g.node('RGBA: #ff000042', style='filled', fillcolor='#ff000042')

    g.node('HSV: 0.051 0.718 0.627', style='filled', fillcolor='0.051 0.718 0.627')

    g.node('name: deeppink', style='filled', fillcolor='deeppink')

    return g

####+BEGIN: b:py3:cs:func/typing :funcName "fsm" :funcType "Typed" :deco "track"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  F-T-Typed  [[elisp:(outline-show-subtree+toggle)][||]] /fsm/  deco=track  [[elisp:(org-cycle)][| ]]
#+end_org """
@cs.track(fnLoc=True, fnEntry=True, fnExit=True)
def fsm(
####+END:
) -> graphviz.Digraph:
    """ #+begin_org
** [[elisp:(org-cycle)][| *DocStr | ] https://graphviz.org/Gallery/directed/fsm.html
    #+end_org """

    f = graphviz.Digraph('finite_state_machine')
    f.attr(rankdir='LR', size='8,5')

    f.attr('node', shape='doublecircle')
    f.node('LR_0')
    f.node('LR_3')
    f.node('LR_4')
    f.node('LR_8')

    f.attr('node', shape='circle')
    f.edge('LR_0', 'LR_2', label='SS(B)')
    f.edge('LR_0', 'LR_1', label='SS(S)')
    f.edge('LR_1', 'LR_3', label='S($end)')
    f.edge('LR_2', 'LR_6', label='SS(b)')
    f.edge('LR_2', 'LR_5', label='SS(a)')
    f.edge('LR_2', 'LR_4', label='S(A)')
    f.edge('LR_5', 'LR_7', label='S(b)')
    f.edge('LR_5', 'LR_5', label='S(a)')
    f.edge('LR_6', 'LR_6', label='S(b)')
    f.edge('LR_6', 'LR_5', label='S(a)')
    f.edge('LR_7', 'LR_8', label='S(b)')
    f.edge('LR_7', 'LR_5', label='S(a)')
    f.edge('LR_8', 'LR_6', label='S(b)')
    f.edge('LR_8', 'LR_5', label='S(a)')

    return f


####+BEGIN: b:py3:cs:func/typing :funcName "g_c_n" :funcType "Typed" :deco "track"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  F-T-Typed  [[elisp:(outline-show-subtree+toggle)][||]] /g_c_n/  deco=track  [[elisp:(org-cycle)][| ]]
#+end_org """
@cs.track(fnLoc=True, fnEntry=True, fnExit=True)
def g_c_n(
####+END:
) -> graphviz.Digraph:
    """ #+begin_org
** [[elisp:(org-cycle)][| *DocStr | ] https://www.graphviz.org/Gallery/gradient/g_c_n.html
    #+end_org """

    g = graphviz.Graph('G')
    g.attr(bgcolor='purple:pink', label='agraph', fontcolor='white')

    with g.subgraph(name='cluster1') as c:
        c.attr(fillcolor='blue:cyan', label='acluster', fontcolor='white',
               style='filled', gradientangle='270')
        c.attr('node', shape='box', fillcolor='red:yellow',
               style='filled', gradientangle='90')
        c.node('anode')

    return g


####+BEGIN: b:py3:cs:func/typing :funcName "structs" :funcType "Typed" :deco "track"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  F-T-Typed  [[elisp:(outline-show-subtree+toggle)][||]] /structs/  deco=track  [[elisp:(org-cycle)][| ]]
#+end_org """
@cs.track(fnLoc=True, fnEntry=True, fnExit=True)
def structs(
####+END:
) -> graphviz.Digraph:
    """ #+begin_org
** [[elisp:(org-cycle)][| *DocStr | ] https://www.graphviz.org/doc/info/shapes.html#html
    #+end_org """

    s = graphviz.Digraph('structs',
                         node_attr={'shape': 'plaintext'})

    s.node('struct1', '''<
    <TABLE BORDER="0" CELLBORDER="1" CELLSPACING="0">
      <TR>
        <TD>left</TD>
        <TD PORT="f1">middle</TD>
        <TD PORT="f2">right</TD>
      </TR>
    </TABLE>>''')
    s.node('struct2', '''<
    <TABLE BORDER="0" CELLBORDER="1" CELLSPACING="0">
      <TR>
        <TD PORT="f0">one</TD>
        <TD>two</TD>
      </TR>
    </TABLE>>''')
    s.node('struct3', '''<
    <TABLE BORDER="0" CELLBORDER="1" CELLSPACING="0" CELLPADDING="4">
      <TR>
        <TD ROWSPAN="3">hello<BR/>world</TD>
        <TD COLSPAN="3">b</TD>
        <TD ROWSPAN="3">g</TD>
        <TD ROWSPAN="3">h</TD>
      </TR>
      <TR>
        <TD>c</TD>
        <TD PORT="here">d</TD>
        <TD>e</TD>
      </TR>
      <TR>
        <TD COLSPAN="3">f</TD>
      </TR>
    </TABLE>>''')

    s.edges([('struct1:f1', 'struct2:f0'), ('struct1:f2', 'struct3:here')])

    return s

####+BEGIN: b:py3:cs:orgItem/basic :type "=Seed Setup= " :title "*Common Facilities*" :comment "General"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  =Seed Setup=  [[elisp:(outline-show-subtree+toggle)][||]] *Common Facilities* General  [[elisp:(org-cycle)][| ]]
#+end_org """
####+END:

namedGraphsList = [
    ng("hello", func=hello),   #
    ng("graphvizLayers", func=graphvizLayers),   #
    ng("colors", func=colors),   #
    ng("fsm", func=fsm),   #
    ng("g_c_n", func=g_c_n),   #
    ng("structs", func=structs),   #
]

graphvizSeed.setup(
    seedType="common",
    namedGraphsList=namedGraphsList,
    # examplesHook=qmail_binsPrep.examples_csu,
)

####+BEGIN: b:py3:cs:seed/withWhich :seedName "seedGraphviz.cs"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  seed       [[elisp:(outline-show-subtree+toggle)][||]] <<seedGraphviz.cs>>   [[elisp:(org-cycle)][| ]]
#+end_org """
import shutil
import os

seedName = 'seedGraphviz.cs'
seedFullPath = os.path.abspath(shutil.which(seedName))

__file__ = seedFullPath
with open(__file__) as f:
    exec(compile(f.read(), __file__, 'exec'))

####+END:
