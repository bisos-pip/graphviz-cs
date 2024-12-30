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
        s.node('seededCsSpec1', 'Graphviz-Specifications-1\n\nhttps://github.com/bisos-pip/graphviz-cs\npy3/examples', shape='rectangle', style='filled', fillcolor='green')
        s.node('seededCsSpecDots', 'Graphviz-Specifications-...\n\nhttps://github.com/bisos-pip/graphviz-cs\npy3/examples', shape='rectangle', style='filled', fillcolor='green')
        s.node('seededCsSpecN', 'Graphviz-Specifications-N\n\nhttps://github.com/bisos-pip/graphviz-cs\npy3/examples', shape='rectangle', style='filled', fillcolor='green')

    with d.subgraph() as s:
        s.attr(rank='same')
        s.node('graphvizSeed', 'Seeded-PyCS\nGraphviz\n\nhttps://github.com/bisos-pip/graphviz-cs', style='filled', fillcolor='darkseagreen3')
        s.node('pycs', 'Python\nCommand Services\n (PyCS)\nhttps://github.com/bisos-pip/pycs', style='filled', fillcolor='darkseagreen3')

    with d.subgraph() as s:
        s.attr(rank='same')
        s.node('pyGraphviz', 'Python Graphviz\n\nhttps://github.com/xflr6/graphviz', style='filled', fillcolor='deepskyblue')

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


####+BEGIN: b:py3:cs:orgItem/basic :type "=Seed Setup= " :title "*Common Facilities*" :comment "General"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  =Seed Setup=  [[elisp:(outline-show-subtree+toggle)][||]] *Common Facilities* General  [[elisp:(org-cycle)][| ]]
#+end_org """
####+END:

namedGraphsList = [
    ng("graphvizLayers", func=graphvizLayers),   #
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
