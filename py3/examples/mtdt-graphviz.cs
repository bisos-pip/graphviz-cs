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

from bisos.graphviz import graphvizSeed
ng = graphvizSeed.namedGraph

def ghAptSource():
    outcome =  b.subProc.WOpW(invedBy=None, log=1).bash(
        f"""
(type -p wget >/dev/null || (sudo apt update && sudo apt-get install wget -y)) \
	&& sudo mkdir -p -m 755 /etc/apt/keyrings \
	&& wget -qO- https://cli.github.com/packages/githubcli-archive-keyring.gpg | sudo tee /etc/apt/keyrings/githubcli-archive-keyring.gpg > /dev/null \
	&& sudo chmod go+r /etc/apt/keyrings/githubcli-archive-keyring.gpg \
	&& echo "deb [arch=$(dpkg --print-architecture) signed-by=/etc/apt/keyrings/githubcli-archive-keyring.gpg] https://cli.github.com/packages stable main" | sudo tee /etc/apt/sources.list.d/github-cli.list > /dev/null \
	&& sudo apt update \
	&& sudo apt install gh -y
""")



####+BEGIN: b:py3:cs:func/typing :funcName "mtdtConceptsGraph" :funcType "Typed" :deco "track"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  F-T-Typed  [[elisp:(outline-show-subtree+toggle)][||]] /mtdtConceptsGraph/  deco=track  [[elisp:(org-cycle)][| ]]
#+end_org """
@cs.track(fnLoc=True, fnEntry=True, fnExit=True)
def mtdtConceptsGraph(
####+END:
) -> graphviz.Digraph:
    """ #+begin_org
** [[elisp:(org-cycle)][| *DocStr | ]
    #+end_org """

    dot = graphviz.Digraph(
        comment='MTDT Concepts',
        graph_attr={'rankdir':'LR'},
    )

    # 1- Gnu-Emacs
    dot.node('MTDT', 'MTDT\nConcepts', shape='circle', style='filled', fillcolor='darkseagreen3')

    # 1.1  1.2 1.3 - Redist Types
    dot.node('SelectedCompositionFwrk', 'Selected Composition Framework', shape='cylinder', style='filled', fillcolor='green')
    dot.node('MailingFile', 'MailingFile', shape='cylinder', style='filled', fillcolor='darksalmon')
    dot.node('Interactive', 'Interactive Invokations', shape='cylinder', style='filled', fillcolor='darksalmon')
    dot.node('SendExtent', 'Send Extent', shape='cylinder', style='filled', fillcolor='darksalmon')
    dot.node('OorR', 'Orig Or Recipients', shape='cylinder', style='filled', fillcolor='darksalmon')
    dot.node('AddressBook', 'Address Book', shape='cylinder', style='filled', fillcolor='darksalmon')
    dot.node('Names', 'Names', shape='cylinder', style='filled', fillcolor='darksalmon')
    dot.node('Distributions', 'Distributions', shape='cylinder', style='filled', fillcolor='darksalmon')
    dot.node('Tracking', 'Tracking', shape='cylinder', style='filled', fillcolor='darksalmon')

    # 1.1.1
    dot.node('PlainText', 'PlainText', style='filled', fillcolor='green')
    dot.node('OrgMsg', 'OrgMsg', style='filled', fillcolor='green')
    dot.node('LaTeX', 'LaTeX', style='filled', fillcolor='green')
    dot.node('Html', 'Html', style='filled', fillcolor='green')
    dot.node('WithSelMailing', 'With Sel Mailing', style='filled', fillcolor='green')

    # 1.2.1
    dot.node('TemplateFile', 'TemplateFile', style='filled', fillcolor='green')
    dot.node('MailingCmnd', 'Mailing Command', style='filled', fillcolor='green')
    dot.node('SelectedMailing', 'Selected Mailing', style='filled', fillcolor='green')

    # 1.3.1  1.3.2
    dot.node('Gnus', 'Gnus', style='filled', fillcolor='green')
    dot.node('MtdtMenu', 'MTDT Menu', style='filled', fillcolor='green')
    dot.node('MailingMenu', 'Mailing Menu', style='filled', fillcolor='green')
    dot.node('DistMenu', 'Distribution Menu', style='filled', fillcolor='green')

    #
    dot.node('CompositionModel', 'Composition Model', style='filled', fillcolor='green')
    dot.node('NativeComposition', 'Native Composition', style='filled', fillcolor='green')
    dot.node('ExternalComposition', 'External Composition', style='filled', fillcolor='green')

    dot.node('ContentCustomization', 'Content Customization', style='filled', fillcolor='green')

    # 1.2.1.1
    dot.node('SendExtent', 'Send Extent', style='filled', fillcolor='green')
    dot.node('doSend', 'doSend', style='filled', fillcolor='green')
    dot.node('unsentBuf', 'unsentBuffer', style='filled', fillcolor='green')

    # 1.3.1.1  1.3.2.1
    dot.node('Recipients', 'Recipients', style='filled', fillcolor='darksalmon')
    dot.node('RecipientsList', 'Recipients List', style='filled', fillcolor='darksalmon')
    dot.node('RecipientsListForm', 'Recipients List Form',  style='filled', fillcolor='darksalmon')
    dot.node('RecipientsListFormFile', 'Recipients List Form File',  style='filled', fillcolor='darksalmon')

    # dot.node('bbdb2', 'bbdb2', style='filled', fillcolor='darksalmon')
    dot.node('bbdb3', 'bbdb3', style='filled', fillcolor='darksalmon')

    dot.node('NamesFile', 'namesFile', style='filled', fillcolor='darksalmon')

    dot.node('DistNamesFile', 'distNamesFile', style='filled', fillcolor='darksalmon')

    dot.node('LogFile', 'logFile', style='filled', fillcolor='darksalmon')

    dot.node('sendWithExtent', 'sendWithExtent', style='filled', fillcolor='darksalmon')
    dot.node('unsentBuffer', 'unsentBuffer', style='filled', fillcolor='darksalmon')
    dot.node('sent', 'sent', style='filled', fillcolor='darksalmon')

    dot.node('Reply', 'Reply', style='filled', fillcolor='darksalmon')
    dot.node('Forward', 'Forward', style='filled', fillcolor='darksalmon')
    dot.node('GnusCompose', 'GnusCompose', style='filled', fillcolor='darksalmon')



    #####  Adding edges to define hierarchy
    #####
    # 1.1  -- 1.2 -- 1.3
    dot.edge('MTDT', 'SelectedCompositionFwrk', label='Abstraction')
    dot.edge('MTDT', 'MailingFile', label='Abstraction')
    dot.edge('MTDT', 'Interactive', label='Abstraction')
    dot.edge('MTDT', 'SendExtent', label='Abstraction')
    dot.edge('MTDT', 'OorR', label='Abstraction')
    dot.edge('MTDT', 'AddressBook', label='Abstraction')
    dot.edge('MTDT', 'Names', label='Abstraction')
    dot.edge('MTDT', 'Distributions', label='Abstraction')
    dot.edge('MTDT', 'Tracking', label='Abstraction')
    dot.edge('MTDT', 'CompositionModel', label='Abstraction')
    dot.edge('MTDT', 'ContentCustomization', label='Abstraction')


    dot.edge('SelectedCompositionFwrk', 'PlainText', label='Enum')
    dot.edge('SelectedCompositionFwrk', 'OrgMsg', label='Enum')
    dot.edge('SelectedCompositionFwrk', 'LaTeX', label='Enum')
    dot.edge('SelectedCompositionFwrk', 'Html', label='Enum')
    dot.edge('SelectedCompositionFwrk', 'WithSelMailing', label='Enum')

    dot.edge('CompositionModel', 'NativeComposition', label='Enum')
    dot.edge('CompositionModel', 'ExternalComposition', label='Enum')

    #
    dot.edge('MailingFile', 'TemplateFile')
    dot.edge('MailingFile', 'MailingCmnd')
    dot.edge('TemplateFile', 'MailingCmnd')
    dot.edge('MailingCmnd', 'SelectedMailing')

    dot.edge('SelectedMailing', 'MailingMenu')
    dot.edge('SelectedMailing', 'DistMenu')

    dot.edge('RecipientsList', 'MailingMenu')

    dot.edge('Interactive', 'Gnus')
    dot.edge('Interactive', 'MtdtMenu')
    dot.edge('MtdtMenu', 'DistMenu')
    dot.edge('MtdtMenu', 'MailingMenu')

    dot.edge('Gnus', 'Reply')
    dot.edge('Gnus', 'Forward')
    dot.edge('Gnus', 'GnusCompose')

    dot.edge('Reply', 'unsentBuffer')
    dot.edge('Forward', 'unsentBuffer')
    dot.edge('GnusCompose', 'unsentBuffer')

    dot.edge('SelectedCompositionFwrk', 'Reply')
    dot.edge('SelectedCompositionFwrk', 'Forward')

    dot.edge('SendExtent', 'doSend')
    dot.edge('SendExtent', 'unsentBuf')

    dot.edge('OorR', 'Recipients')
    dot.edge('Recipients', 'RecipientsList')
    dot.edge('RecipientsList', 'RecipientsListForm')
    dot.edge('RecipientsListForm', 'RecipientsListFormFile')


    # dot.edge('AddressBook', 'bbdb2')
    dot.edge('AddressBook', 'bbdb3')

    dot.edge('Names', 'NamesFile')

    dot.edge('NamesFile', 'bbdb3')
    dot.edge('bbdb3', 'RecipientsListFormFile')

    dot.edge('RecipientsListFormFile', 'DistMenu')

    dot.edge('Distributions', 'DistNamesFile')

    dot.edge('DistNamesFile', 'RecipientsListFormFile')

    dot.edge('Tracking', 'LogFile')


    dot.edge('MailingMenu', 'sendWithExtent')
    dot.edge('DistMenu', 'sendWithExtent')

    dot.edge('sendWithExtent', 'unsentBuffer')
    dot.edge('sendWithExtent', 'sent')

    dot.edge('SendExtent', 'sendWithExtent')

    dot.edge('CompositionModel', 'sendWithExtent')
    dot.edge('ContentCustomization', 'sendWithExtent')


    return dot


####+BEGIN: b:py3:cs:func/typing :funcName "mtdtConceptsGraph_l0" :funcType "Typed" :deco "track"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  F-T-Typed  [[elisp:(outline-show-subtree+toggle)][||]] /mtdtConceptsGraph_l0/  deco=track  [[elisp:(org-cycle)][| ]]
#+end_org """
@cs.track(fnLoc=True, fnEntry=True, fnExit=True)
def mtdtConceptsGraph_l0(
####+END:
) -> graphviz.Digraph:
    """ #+begin_org
** [[elisp:(org-cycle)][| *DocStr | ]
    #+end_org """

    dot = graphviz.Digraph(
        comment='Mailing File Creation',
        # graph_attr={'rankdir':'LR'},
    )

    #  LCNT
    dot.node('LCNT', 'LCNT:\nLibre\nContent', shape='circle', style='filled', fillcolor='darkseagreen3')
    dot.node('LcntMasFile', 'articleLtr.mastex\narticleRtl.mastex', shape='parallelogram', style='filled', fillcolor='khaki1')
    dot.node('LcntProcMailing', '\nlcntProc.sh\nMailing\n ',  shape='rarrow', style='filled', fillcolor='salmon3')

    #####
    dot.edge('LCNT', 'LcntMasFile', label='Specification')
    dot.edge('LCNT', 'LcntProcMailing', label='Usage')
    dot.edge('LcntMasFile', 'LcntProcMailing', label='Usage')


    # Layer 0
    dot.node('Start-Mailing', 'LAYER 1:\nCreate\nMailing\nFile', shape='circle', style='filled', fillcolor='darkseagreen3')

    # 1.1  1.2 1.3 - Redist Types

    # dot.node('StartMailingFile', 'Common Mailing\nFile', shape='parallelogram', style='filled', fillcolor='khaki1')

    dot.edge('LcntMasFile', 'MailingFile',  label='Content')
    dot.edge('LcntMasFile', 'TemplateFile',  label='Content')
    dot.edge('LcntMasFile', 'MuaStencil',  label='Content')
    dot.edge('LcntProcMailing', 'LcntMasFile',  dir='back', label='Processing')

    dot.edge('LcntProcMailing', 'MailingFileUsage', label='Usage')


    # Header

    #
    dot.node('PlainText', 'PlainText', shape='rect', style='filled', fillcolor='azure3')
    dot.node('OrgMsg', 'OrgMsg', shape='rect', style='filled', fillcolor='azure3')
    dot.node('LaTeX', 'LaTeX', shape='rect', style='filled', fillcolor='azure3')
    dot.node('Html', 'Html', shape='rect', style='filled', fillcolor='azure3')
    # dot.node('WithSelMailing', 'With\nSelected\nMailing', shape='rect', style='filled', fillcolor='azure3')


    #


    #####  Adding edges to define hierarchy
    #####
    dot.edge('Start-Mailing', 'MailingFile', label='Specification')
    dot.edge('Start-Mailing', 'TemplateFile', label='Specification')
    dot.edge('Start-Mailing', 'MuaStencil', label='Specification')

    dot.node('TemplateFile', 'Template\nFile',  shape='parallelogram', style='filled', fillcolor='khaki1')

    dot.node('MailingFile', 'Mailing\nFile',  shape='parallelogram', style='filled', fillcolor='khaki1')

    dot.node('MuaStencil', 'Mua\nStencil',  shape='parallelogram', style='filled', fillcolor='khaki1')

    dot.node('SelectedCompositionFwrk', 'X-ComposeFwrk', shape='cylinder', style='filled', fillcolor='green')

    dot.edge('SelectedCompositionFwrk', 'PlainText', dir='back', label='Enum')
    dot.edge('SelectedCompositionFwrk', 'OrgMsg',  dir='back', label='Enum')
    dot.edge('SelectedCompositionFwrk', 'LaTeX',  dir='back', label='Enum')
    dot.edge('SelectedCompositionFwrk', 'Html',  dir='back', label='Enum')
    # dot.edge('SelectedCompositionFwrk', 'WithSelMailing',  dir='back', label='Enum')

    dot.edge('MailingFile', 'SelectedCompositionFwrk', dir='back', label='Header')
    dot.edge('TemplateFile', 'SelectedCompositionFwrk', dir='back', label='Header')
    dot.edge('MuaStencil', 'SelectedCompositionFwrk', dir='back', label='Header')

    dot.node('Purpose', 'X-Mailing-Purpose', shape='cylinder', style='filled', fillcolor='green')

    dot.node('PurposeMailing', 'Mailing', shape='rect', style='filled', fillcolor='azure3')
    dot.node('PurposeTemplate', 'Template', shape='rect', style='filled', fillcolor='azure3')
    dot.node('PurposeMua', 'Mua', shape='rect', style='filled', fillcolor='azure3')
    # dot.node('PurposeAny', 'Any', shape='rect', style='filled', fillcolor='azure3')

    dot.edge('Purpose', 'PurposeMailing', dir='back', label='Enum')
    dot.edge('Purpose', 'PurposeTemplate',  dir='back', label='Enum')
    dot.edge('Purpose', 'PurposeMua',  dir='back', label='Enum')
    # dot.edge('Purpose', 'PurposeAny',  dir='back', label='Enum')

    dot.edge('MailingFile', 'Purpose', dir='back', label='Header')
    dot.edge('TemplateFile', 'Purpose', dir='back', label='Header')
    dot.edge('MuaStencil', 'Purpose', dir='back', label='Header')

    dot.node('SelectedCompositionModel', 'X-MailingParams\n:type ext\n(Composition Model)', shape='cylinder', style='filled', fillcolor='green')

    dot.node('ComposeNatModel', 'Native\nCompose\nModel\n', shape='rect', style='filled', fillcolor='azure3')
    dot.node('ComposeExtModel', 'External\nCompose\nModel\n', shape='rect', style='filled', fillcolor='azure3')

    dot.edge('SelectedCompositionModel', 'ComposeNatModel', dir='back', label='Enum')
    dot.edge('SelectedCompositionModel', 'ComposeExtModel', dir='back', label='Enum')

    dot.node('MailingName', 'X-MailingName', shape='cylinder', style='filled', fillcolor='green')

    dot.node('Customize', 'X-MTDT-Customize\n(file path)', shape='cylinder', style='filled', fillcolor='green')


    dot.edge('MailingFile', 'SelectedCompositionModel', dir='back', label='Header')
    dot.edge('TemplateFile', 'SelectedCompositionModel', dir='back', label='Header')
    dot.edge('MuaStencil', 'SelectedCompositionModel', dir='back', label='Header')

    dot.edge('MailingFile', 'MailingName', dir='back', label='Header')
    dot.edge('TemplateFile', 'MailingName', dir='back', label='Header')
    dot.edge('MuaStencil', 'MailingName', dir='back', label='Header')

    dot.edge('MailingFile', 'MailingName', dir='back', label='Header')
    dot.edge('TemplateFile', 'MailingName', dir='back', label='Header')
    dot.edge('MuaStencil', 'MailingName', dir='back', label='Header')

    dot.edge('MailingFile', 'Customize', dir='back', label='Header')
    dot.edge('TemplateFile', 'Customize', dir='back', label='Header')
    dot.edge('MuaStencil', 'Customize', dir='back', label='Header')

    # dot.node('MailingCmnd', 'Mailing\nCommand', shape='oval', style='filled', fillcolor='khaki1')

    dot.node('MailingFileUsage', '\nMailing\nFile\nUsage\n ',  shape='rarrow', style='filled', fillcolor='lightsalmon1')

    dot.edge('MailingFile', 'MailingFileUsage', label='Derive')
    dot.edge('TemplateFile', 'MailingFileUsage', label='Derive')
    dot.edge('MuaStencil', 'MailingFileUsage', label='Derive')

    return dot


####+BEGIN: b:py3:cs:func/typing :funcName "mtdtConceptsGraph_l1" :funcType "Typed" :deco "track"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  F-T-Typed  [[elisp:(outline-show-subtree+toggle)][||]] /mtdtConceptsGraph_l1/  deco=track  [[elisp:(org-cycle)][| ]]
#+end_org """
@cs.track(fnLoc=True, fnEntry=True, fnExit=True)
def mtdtConceptsGraph_l1(
####+END:
) -> graphviz.Digraph:
    """ #+begin_org
** [[elisp:(org-cycle)][| *DocStr | ]
    #+end_org """

    dot = graphviz.Digraph(
        comment='MTDT-Mailing Concepts',
        # graph_attr={'rankdir':'LR'},
    )

    # 1- Gnu-Emacs
    dot.node('MTDT-Mailing', 'LAYER 1:\nMTDT\nMailing\nConcepts', shape='circle', style='filled', fillcolor='darkseagreen3')

    # 1.1  1.2 1.3 - Redist Types
    dot.node('SelectedCompositionFwrk', 'Selected\nCompositionn\nFramework', shape='cylinder', style='filled', fillcolor='green')
    dot.node('SelectedCompositionModel', 'Selected\nComposition\nModel', shape='cylinder', style='filled', fillcolor='green')
    dot.node('Interactive', 'Interactive\nUsage', shape='circle', style='filled', fillcolor='darksalmon')

    dot.node('X-MailingName', 'X-Mailing\nName', shape='parallelogram', style='filled', fillcolor='khaki1')

    dot.node('MailingFile', 'Mailing\nFile', shape='parallelogram', style='filled', fillcolor='khaki1')
    dot.node('CommencingFile', 'Commencing\nFile', shape='parallelogram', style='filled', fillcolor='khaki1')
    dot.node('TemplateFile', 'Template\nFile',  shape='parallelogram', style='filled', fillcolor='khaki1')
    dot.node('MuaStencil', 'Mua\nStencil',  shape='parallelogram', style='filled', fillcolor='khaki1')
    dot.node('CustomizeFile', 'Customize.el\nFile', shape='parallelogram', style='filled', fillcolor='khaki1')

    dot.node('PlainText', 'PlainText', shape='rect', style='filled', fillcolor='azure3')
    dot.node('OrgMsg', 'OrgMsg', shape='rect', style='filled', fillcolor='azure3')
    dot.node('LaTeX', 'LaTeX', shape='rect', style='filled', fillcolor='azure3')
    dot.node('Html', 'Html', shape='rect', style='filled', fillcolor='azure3')
    dot.node('WithSelMailing', 'With\nSelected\nMailing', shape='rect', style='filled', fillcolor='azure3')

    # dot.node('Purpose', 'Purpose', shape='cylinder', style='filled', fillcolor='green')

    # dot.node('PurposeMailing', 'Mailing', shape='rect', style='filled', fillcolor='azure3')
    # dot.node('PurposeTemplate', 'Template', shape='rect', style='filled', fillcolor='azure3')
    # dot.node('PurposeMua', 'Mua', shape='rect', style='filled', fillcolor='azure3')
    # dot.node('PurposeAny', 'Any', shape='rect', style='filled', fillcolor='azure3')

    dot.node('MailingCmnd', 'Mailing\nCommand', shape='oval', style='filled', fillcolor='khaki1')
    dot.node('ListOfMailingCmnds', 'List of\nMailing\nCommand',  shape='oval', style='filled', fillcolor='khaki1')
    dot.node('SelectedMailings', 'Selected\nList of\nMailings ', style='filled', fillcolor='green')
    dot.node('SelectedGnusMailing', 'Selected\nGnus\nMailing', style='filled', fillcolor='green')

    # 1.3.1  1.3.2
    dot.node('Gnus', '\nBlee\nGnus\n ', shape='rarrow', style='filled', fillcolor='orange')
    dot.node('Forward', '\nGnus\nForward\n ', shape='rarrow', style='filled', fillcolor='orange')
    dot.node('GnusCompose', '\nGnus\nCompose\n ', shape='rarrow', style='filled', fillcolor='orange')
    dot.node('Reply', '\nGnus\nReply\n ', shape='rarrow', style='filled', fillcolor='orange')

    dot.node('MtdtMailingMenu', '\nMTDT-Mailing\nMenu\n ', shape='rarrow', style='filled', fillcolor='salmon')

    dot.node('MailingOrgInitiator', '\nMailing\nOrg\nInitiator\n ',  shape='rarrow', style='filled', fillcolor='salmon2')
    dot.node('MailingOrgDblock', '\nMailing\nOrg\nDblocks\n ',  shape='rarrow', style='filled', fillcolor='salmon2')

    dot.node('lcntProcMailing', '\nlcntProc.sh\nMailing\n ',  shape='rarrow', style='filled', fillcolor='salmon3')

    dot.node('MailingFileUsage', '\nMailing\nFile\nUsage\n ',  shape='rarrow', style='filled', fillcolor='lightsalmon1')

    dot.node('MailingCompose', '\nMailing\nNative\nCompose\n ',  shape='rarrow', style='filled', fillcolor='magenta')
    dot.node('MailingExtCompose', '\nMailing\nExternal\nCompose\n ',  shape='rarrow', style='filled', fillcolor='magenta')

    dot.node('ComposeNatModel', 'Native\nCompose\nModel\n', shape='rect', style='filled', fillcolor='azure3')
    dot.node('ComposeExtModel', 'External\nCompose\nModel\n', shape='rect', style='filled', fillcolor='azure3')

    dot.node('unsentBuffer', 'Unsent\nMail\nBuffer',  shape='invtrapezium', style='filled', fillcolor='deepskyblue')

    dot.node('ResidentMTA', '\nResident\nMTA\n(MARMEE)\n ',  shape='cds', style='filled', fillcolor='cyan')

    dot.node('MailSnippets', '\nMail\nYasnippets',  shape='polygon', style='filled', fillcolor='gray83')


    #####  Adding edges to define hierarchy
    #####
    #####
    dot.edge('MTDT-Mailing', 'Interactive', label='Usage')
    dot.edge('MTDT-Mailing', 'SelectedCompositionFwrk', label='Configuration')
    dot.edge('MTDT-Mailing', 'SelectedCompositionModel', label='Configuration')
    dot.edge('MTDT-Mailing', 'X-MailingName', label='Specification')
    dot.edge('MTDT-Mailing', 'CustomizeFile', label='Specification')

    dot.edge('X-MailingName', 'CommencingFile', label='Specification')
    dot.edge('X-MailingName', 'MailingFile', label='Specification')
    dot.edge('X-MailingName', 'TemplateFile', label='Specification')
    dot.edge('X-MailingName', 'MuaStencil', label='Specification')

    dot.edge('SelectedCompositionFwrk', 'PlainText', dir='back', label='Enum')
    dot.edge('SelectedCompositionFwrk', 'OrgMsg',  dir='back', label='Enum')
    dot.edge('SelectedCompositionFwrk', 'LaTeX',  dir='back', label='Enum')
    dot.edge('SelectedCompositionFwrk', 'Html',  dir='back', label='Enum')
    dot.edge('SelectedCompositionFwrk', 'WithSelMailing',  dir='back', label='Enum')

    # dot.edge('MailingFile', 'Purpose', dir='back', label='Header')

    # dot.edge('Purpose', 'PurposeMailing', dir='back', label='Enum')
    # dot.edge('Purpose', 'PurposeTemplate',  dir='back', label='Enum')
    # dot.edge('Purpose', 'PurposeMua',  dir='back', label='Enum')
    # dot.edge('Purpose', 'PurposeAny',  dir='back', label='Enum')

    dot.edge('SelectedCompositionFwrk', 'Gnus', label='Inform')
    dot.edge('SelectedCompositionFwrk', 'MtdtMailingMenu', label='Inform')

    dot.edge('unsentBuffer', 'CustomizeFile', dir='back', label='Execute')
    dot.edge('MailingFile', 'MailingCmnd', label='Derive')
    dot.edge('TemplateFile', 'MailingCmnd', label='Derive')
    dot.edge('CommencingFile', 'MailingCmnd', label='Derive')
    dot.edge('MuaStencil', 'MailingCmnd', label='Derive')
    dot.edge('MailingCmnd', 'SelectedGnusMailing')
    dot.edge('MailingCmnd', 'ListOfMailingCmnds')
    dot.edge('ListOfMailingCmnds', 'SelectedMailings')

    dot.edge('SelectedMailings', 'MtdtMailingMenu', label='Inform')
    dot.edge('SelectedGnusMailing', 'Gnus', label='Inform')

    dot.edge('MtdtMailingMenu', 'MailingExtCompose')
    dot.edge('MtdtMailingMenu', 'MailingCompose')

    dot.edge('MailingExtCompose', 'unsentBuffer')
    dot.edge('MailingCompose', 'unsentBuffer')

    dot.edge('Interactive', 'Gnus')
    dot.edge('Interactive', 'MtdtMailingMenu')
    dot.edge('Interactive', 'MailingOrgInitiator')
    dot.edge('Interactive', 'lcntProcMailing')
    dot.edge('Interactive', 'MailingFileUsage')

    dot.edge('MailingOrgInitiator', 'MailingOrgDblock')

    dot.edge('MailingOrgDblock', 'MailingExtCompose')
    dot.edge('MailingOrgDblock', 'MailingCompose')
    dot.edge('MailingOrgDblock', 'SelectedMailings', dir='back', label='Select')

    dot.edge('lcntProcMailing', 'MailingExtCompose')
    dot.edge('lcntProcMailing', 'MailingCompose')
    dot.edge('lcntProcMailing', 'SelectedMailings', label='Select')

    dot.edge('MailingFileUsage', 'MailingExtCompose')
    dot.edge('MailingFileUsage', 'MailingCompose')
    dot.edge('MailingFileUsage', 'SelectedMailings', label='Select')

    dot.edge('Gnus', 'Reply')
    dot.edge('Gnus', 'Forward')
    dot.edge('Gnus', 'GnusCompose')

    dot.edge('Reply', 'unsentBuffer')
    dot.edge('Forward', 'unsentBuffer')
    dot.edge('GnusCompose', 'unsentBuffer')

    dot.edge('unsentBuffer', 'ResidentMTA', label='Inject')

    dot.edge('MailSnippets', 'unsentBuffer')

    dot.edge('SelectedCompositionModel', 'ComposeNatModel', dir='back', label='Enum')
    dot.edge('SelectedCompositionModel', 'ComposeExtModel', dir='back', label='Enum')

    dot.edge('SelectedCompositionModel', 'Gnus')

    return dot


####+BEGIN: b:py3:cs:func/typing :funcName "mtdtConceptsGraph_l2" :funcType "Typed" :deco "track"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  F-T-Typed  [[elisp:(outline-show-subtree+toggle)][||]] /mtdtConceptsGraph_l2/  deco=track  [[elisp:(org-cycle)][| ]]
#+end_org """
@cs.track(fnLoc=True, fnEntry=True, fnExit=True)
def mtdtConceptsGraph_l2(
####+END:
) -> graphviz.Digraph:
    """ #+begin_org
** [[elisp:(org-cycle)][| *DocStr | ]
    #+end_org """

    dot = graphviz.Digraph(
        comment='MTDT-Distribution Concepts',
        # graph_attr={'rankdir':'LR'},
    )

    #  LAYER-1  Summary
    dot.node('MTDT-Mailing', 'MTDT\nMailing\nConcepts\nLAYER 1', shape='circle', style='filled', fillcolor='darkseagreen3')
    dot.node('MailingFile', 'Mailing\nFile', shape='parallelogram', style='filled', fillcolor='khaki1')
    dot.node('TemplateFile', 'Template\nFile',  shape='parallelogram', style='filled', fillcolor='khaki1')
    dot.node('MailingCmnd', 'Mailing\nCommand', shape='oval', style='filled', fillcolor='khaki1')
    dot.node('ListOfMailingCmnds', 'List of\nMailing\nCommand',  shape='oval', style='filled', fillcolor='khaki1')
    dot.node('SelectedMailings', 'Selected\nList of\nMailings ', style='filled', fillcolor='green')

    # LAYER-2  FULL
    #
    dot.node('MTDT-Distribution', 'MTDT\nDistribution\nConcepts\nLAYER 2', shape='circle', style='filled', fillcolor='darkseagreen3')

    dot.node('Interactive', 'Interactive\nUsage', shape='circle', style='filled', fillcolor='darksalmon')
    dot.node('SendExtent', 'Selected\nSend\nExtent', shape='cylinder', style='filled', fillcolor='darksalmon')
    dot.node('OorR', 'Orig Or Recipients', shape='cylinder', style='filled', fillcolor='khaki1')
    dot.node('AddressBook', 'Address Book', shape='cylinder', style='filled', fillcolor='khaki1')
    dot.node('Names', 'Names', shape='cylinder', style='filled', fillcolor='khaki1')
    dot.node('Distributions', 'Distributions', shape='cylinder', style='filled', fillcolor='khaki1')
    dot.node('Tracking', 'Tracking', shape='cylinder', style='filled', fillcolor='khaki1')

    #dot.node('MtdtMenu', 'MTDT Menu', style='filled', fillcolor='green')
    dot.node('MtdtMenu', '\nMTDT-Distribution\nMenu\n ', shape='rarrow', style='filled', fillcolor='salmon')
    #dot.node('DistMenu', 'Distribution Menu', style='filled', fillcolor='green')

    dot.node('lcntProcMailing', '\nlcntProc.sh\nMailing\n ',  shape='rarrow', style='filled', fillcolor='salmon3')

    # 1.2.1.1
    dot.node('SendExtent', 'Selected\nSend\nExtent', style='filled', fillcolor='green')
    dot.node('doSend', 'doSend',  shape='rect', style='filled', fillcolor='azure3')
    dot.node('unsentBuf', 'unsentBuffer',  shape='rect', style='filled', fillcolor='azure3')

    # 1.3.1.1  1.3.2.1
    dot.node('Recipients', 'Recipients', style='filled', fillcolor='khaki1')
    dot.node('RecipientsList', 'Recipients List', style='filled', fillcolor='khaki1')
    dot.node('RecipientsListForm', 'Recipients List Form',  style='filled', fillcolor='khaki1')
    dot.node('RecipientsListFormFile', 'Selected\nRecipients\nList\nForm\n File',  style='filled', fillcolor='green')

    dot.node('bbdb2', 'bbdb2', style='filled', fillcolor='khaki1')
    dot.node('bbdb3', 'bbdb3', style='filled', fillcolor='khaki1')

    dot.node('NamesFile', 'namesFile', style='filled', fillcolor='khaki1')

    dot.node('DistNamesFile', 'distNamesFile', style='filled', fillcolor='khaki1')

    dot.node('LogFile', 'logFile', style='filled', fillcolor='khaki1')

    dot.node('sendWithExtent', 'sendWithExtent', style='filled', fillcolor='darksalmon')
    dot.node('unsentBuffer', 'Unsent\nMail\nBuffer',  shape='invtrapezium', style='filled', fillcolor='deepskyblue')
    dot.node('sent', '\nResident\nMTA\n(MARMEE)\n ',  shape='cds', style='filled', fillcolor='cyan')

    #####  Adding edges to define hierarchy
    #####
    # 1.1  -- 1.2 -- 1.3
    dot.edge('MTDT-Mailing', 'MailingFile', label='Specification')

    #
    dot.edge('MailingFile', 'TemplateFile')
    dot.edge('MailingFile', 'MailingCmnd', label='Derive')
    dot.edge('TemplateFile', 'MailingCmnd', label='Derive')
    dot.edge('MailingCmnd', 'ListOfMailingCmnds')
    dot.edge('ListOfMailingCmnds', 'SelectedMailings')

    #####  Adding edges to define hierarchy
    #####
    # 1.1  -- 1.2 -- 1.3
    dot.edge('MTDT-Distribution', 'Interactive', label='Execution')
    dot.edge('MTDT-Distribution', 'SendExtent', label='Configuration')
    dot.edge('MTDT-Distribution', 'OorR', label='Machinary')
    dot.edge('MTDT-Distribution', 'AddressBook', label='Specification')
    dot.edge('MTDT-Distribution', 'Names', label='Specification')
    dot.edge('MTDT-Distribution', 'Distributions', label='Specification')
    dot.edge('MTDT-Distribution', 'Tracking', label='Machinary')

    #

    # dot.edge('SelectedMailings', 'MailingMenu')
    dot.edge('SelectedMailings', 'MtdtMenu')

    # dot.edge('RecipientsList', 'MailingMenu')

    dot.edge('Interactive', 'MtdtMenu')
    dot.edge('Interactive', 'lcntProcMailing')
    # dot.edge('MtdtMenu', 'DistMenu')

    # dot.edge('MailingMenu', 'sendWithExtent')
    dot.edge('MtdtMenu', 'sendWithExtent')
    dot.edge('lcntProcMailing', 'sendWithExtent')

    dot.edge('sendWithExtent', 'unsentBuffer')
    dot.edge('sendWithExtent', 'sent')
    dot.edge('unsentBuffer', 'sent')


    dot.edge('SendExtent', 'doSend', dir='back', label='Enum')
    dot.edge('SendExtent', 'unsentBuf', dir='back', label='Enum')
    dot.edge('SendExtent', 'sendWithExtent', label='inform')


    dot.edge('OorR', 'Recipients')
    dot.edge('Recipients', 'RecipientsList')
    dot.edge('RecipientsList', 'RecipientsListForm')
    dot.edge('RecipientsListForm', 'RecipientsListFormFile')

    dot.edge('AddressBook', 'bbdb2')
    dot.edge('AddressBook', 'bbdb3')

    dot.edge('Names', 'NamesFile')
    dot.edge('NamesFile', 'bbdb2')
    dot.edge('bbdb2', 'RecipientsListFormFile')
    dot.edge('NamesFile', 'bbdb3')
    dot.edge('bbdb3', 'RecipientsListFormFile')

    dot.edge('RecipientsListFormFile', 'MtdtMenu')

    dot.edge('Distributions', 'DistNamesFile')

    dot.edge('DistNamesFile', 'RecipientsListFormFile')

    dot.edge('Tracking', 'LogFile')
    dot.edge('LogFile', 'Distributions')

    return dot


####+BEGIN: b:py3:cs:func/typing :funcName "mtdtConceptsGraph_l3" :funcType "Typed" :deco "track"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  F-T-Typed  [[elisp:(outline-show-subtree+toggle)][||]] /mtdtConceptsGraph_l3/  deco=track  [[elisp:(org-cycle)][| ]]
#+end_org """
@cs.track(fnLoc=True, fnEntry=True, fnExit=True)
def mtdtConceptsGraph_l3(
####+END:
) -> graphviz.Digraph:
    """ #+begin_org
** [[elisp:(org-cycle)][| *DocStr | ]
    #+end_org """

    dot = graphviz.Digraph(
        comment='MTDT-Distribution Concepts',
        # graph_attr={'rankdir':'LR'},
    )

    #  LAYER-1  Summary
    dot.node('MTDT-Mailing', 'MTDT\nMailing\nConcepts\nLAYER 1', shape='circle', style='filled', fillcolor='darkseagreen3')
    dot.node('MailingFile', 'Mailing\nFile', shape='parallelogram', style='filled', fillcolor='khaki1')
    dot.node('TemplateFile', 'Template\nFile',  shape='parallelogram', style='filled', fillcolor='khaki1')
    dot.node('MailingCmnd', 'Mailing\nCommand', shape='oval', style='filled', fillcolor='khaki1')
    dot.node('ListOfMailingCmnds', 'List of\nMailing\nCommand',  shape='oval', style='filled', fillcolor='khaki1')
    dot.node('SelectedMailings', 'Selected\nList of\nMailings ', style='filled', fillcolor='green')


    # LAYER-2  Summary
    #
    dot.node('MTDT-Distribution', 'MTDT\nDistribution\nConcepts\nLAYER 2', shape='circle', style='filled', fillcolor='darkseagreen3')

    dot.node('OorR', 'Orig Or Recipients', shape='cylinder', style='filled', fillcolor='khaki1')

    dot.node('SendExtent', 'Selected\nSend\nExtent', style='filled', fillcolor='green')
    dot.node('doSend', 'doSend',  shape='rect', style='filled', fillcolor='azure3')
    dot.node('unsentBuf', 'unsentBuffer',  shape='rect', style='filled', fillcolor='azure3')

    # 1.3.1.1  1.3.2.1
    dot.node('Recipients', 'Recipients', style='filled', fillcolor='khaki1')
    dot.node('RecipientsList', 'Recipients List', style='filled', fillcolor='khaki1')
    dot.node('RecipientsListForm', 'Recipients List Form',  style='filled', fillcolor='khaki1')
    dot.node('RecipientsListFormFile', 'Selected\nRecipients\nList\nForm\n File',  style='filled', fillcolor='green')

    dot.node('sendWithExtent', 'sendWithExtent', style='filled', fillcolor='darksalmon')
    dot.node('unsentBuffer', 'Unsent\nMail\nBuffer',  shape='invtrapezium', style='filled', fillcolor='deepskyblue')
    dot.node('sent', '\nResident\nMTA\n(MARMEE)\n ',  shape='cds', style='filled', fillcolor='cyan')

    #####  Adding edges to define hierarchy
    #####
    # 1.1  -- 1.2 -- 1.3
    dot.edge('MTDT-Mailing', 'MailingFile', label='Specification')

    #
    dot.edge('MailingFile', 'TemplateFile')
    dot.edge('MailingFile', 'MailingCmnd', label='Derive')
    dot.edge('TemplateFile', 'MailingCmnd', label='Derive')
    dot.edge('MailingCmnd', 'ListOfMailingCmnds')
    dot.edge('ListOfMailingCmnds', 'SelectedMailings')

    #####  Adding edges to define hierarchy
    #####
    # 1.1  -- 1.2 -- 1.3
    dot.edge('MTDT-Distribution', 'SendExtent', label='Configuration')
    dot.edge('MTDT-Distribution', 'OorR', label='Machinary')


    dot.edge('sendWithExtent', 'unsentBuffer')
    dot.edge('sendWithExtent', 'sent')
    dot.edge('unsentBuffer', 'sent')

    dot.edge('SendExtent', 'doSend', dir='back', label='Enum')
    dot.edge('SendExtent', 'unsentBuf', dir='back', label='Enum')
    dot.edge('SendExtent', 'sendWithExtent', label='inform')

    dot.edge('OorR', 'Recipients')
    dot.edge('Recipients', 'RecipientsList')
    dot.edge('RecipientsList', 'RecipientsListForm')
    dot.edge('RecipientsListForm', 'RecipientsListFormFile')


    # LAYER-3  FULL
    #
    dot.node('MTDT-Share', 'MTDT\nShare\nConcepts\nLAYER 3', shape='circle', style='filled', fillcolor='darkseagreen3')
    dot.node('Interactive', 'Interactive\nUsage', shape='circle', style='filled', fillcolor='darksalmon')

    dot.node('BrowserShare', '\nBrowser\nShare\n ', shape='rarrow', style='filled', fillcolor='salmon')
    dot.node('DiredShare', '\nDired\nShare\n ',  shape='rarrow', style='filled', fillcolor='salmon3')

    #####  Adding edges to define hierarchy

    dot.edge('MTDT-Share', 'Interactive', label='Execution')

    dot.edge('SelectedMailings', 'BrowserShare')
    dot.edge('SelectedMailings', 'DiredShare')

    dot.edge('RecipientsListFormFile', 'BrowserShare')
    dot.edge('RecipientsListFormFile', 'DiredShare')

    dot.edge('Interactive', 'BrowserShare')
    dot.edge('Interactive', 'DiredShare')

    dot.edge('BrowserShare', 'sendWithExtent')
    dot.edge('DiredShare', 'sendWithExtent')

    return dot

####+BEGIN: b:py3:cs:orgItem/basic :type "=Seed Setup= " :title "*Common Facilities*" :comment "General"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  =Seed Setup=  [[elisp:(outline-show-subtree+toggle)][||]] *Common Facilities* General  [[elisp:(org-cycle)][| ]]
#+end_org """
####+END:


namedGraphsList = [
    ng("mtdtConceptsGraph", func=mtdtConceptsGraph),   #
    ng("mtdtConceptsGraph_l0", func=mtdtConceptsGraph_l0),   #
    ng("mtdtConceptsGraph_l1", func=mtdtConceptsGraph_l1),   #
    ng("mtdtConceptsGraph_l2", func=mtdtConceptsGraph_l2),   #
    ng("mtdtConceptsGraph_l3", func=mtdtConceptsGraph_l3),   #
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
