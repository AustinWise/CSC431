	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmpAF88.tmp"
	.text
	.align	4
	.type	treeprint,@function
treeprint:                              ! @treeprint
! BB#0:
	save %sp, -96, %sp
	subcc %i0, 0, %l0
	be .LBB0_2
	nop
.LBB0_1:                                ! %L464
                                        ! =>This Inner Loop Header: Depth=1
	ld [%i0+4], %o0
	call treeprint
	nop
	sethi %hi(.LC1), %l0
	ld [%i0], %o1
	add %l0, %lo(.LC1), %o0
	call printf
	nop
	ld [%i0+8], %i0
	subcc %i0, 0, %l0
	bne .LBB0_1
	nop
.LBB0_2:                                ! %L486
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp0:
	.size	treeprint, .Ltmp0-treeprint

	.align	4
	.type	freeList,@function
freeList:                               ! @freeList
! BB#0:
	save %sp, -96, %sp
	subcc %i0, 0, %l0
	be .LBB1_2
	nop
! BB#1:                                 ! %L499
	ld [%i0+4], %o0
	call freeList
	nop
	or %g0, %i0, %o0
	call free
	nop
.LBB1_2:                                ! %L515
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp1:
	.size	freeList, .Ltmp1-freeList

	.align	4
	.type	freeTree,@function
freeTree:                               ! @freeTree
! BB#0:
	save %sp, -96, %sp
	subcc %i0, 0, %l0
	be .LBB2_2
	nop
! BB#1:                                 ! %L529
	ld [%i0+4], %o0
	call freeTree
	nop
	ld [%i0+8], %o0
	call freeTree
	nop
	or %g0, %i0, %o0
	call free
	nop
.LBB2_2:                                ! %L550
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp2:
	.size	freeTree, .Ltmp2-freeTree

	.align	4
	.type	postOrder,@function
postOrder:                              ! @postOrder
! BB#0:
	save %sp, -96, %sp
	subcc %i0, 0, %l0
	be .LBB3_17
	nop
! BB#1:                                 ! %L563
	or %g0, 2, %o0
	or %g0, 4, %o1
	call calloc
	nop
	or %g0, %o0, %l0
	ld [%i0], %l1
	sethi 0, %l2
	st %l1, [%l0]
	st %l2, [%l0+4]
	ld [%i0+4], %o0
	call postOrder
	nop
	or %g0, %o0, %l1
	ld [%i0+8], %o0
	call postOrder
	nop
	subcc %l1, 0, %l2
	bne .LBB3_3
	nop
! BB#2:                                 ! %L563.concatLists.exit15_crit_edge
	or %g0, %o0, %l1
	ba .LBB3_9
	nop
.LBB3_3:                                ! %L77.preheader.i6
	ld [%l1+4], %l2
	subcc %l2, 0, %l3
	be .LBB3_5
	nop
! BB#4:                                 ! %L77.preheader.i6.L84.i12_crit_edge
	ba .LBB3_6
	nop
.LBB3_5:                                ! %L77.preheader.i6.L101.i14_crit_edge
	add %l1, 4, %l2
	ba .LBB3_8
	nop
.LBB3_6:                                ! %L84.i12
                                        ! =>This Inner Loop Header: Depth=1
	or %g0, %l2, %l3
	ld [%l3+4], %l2
	subcc %l2, 0, %l4
	bne .LBB3_6
	nop
! BB#7:                                 ! %L84.i12.L101.i14_crit_edge
	add %l3, 4, %l2
.LBB3_8:                                ! %L101.i14
	st %o0, [%l2]
.LBB3_9:                                ! %concatLists.exit15
	subcc %l1, 0, %l2
	be .LBB3_16
	nop
! BB#10:                                ! %L77.preheader.i
	ld [%l1+4], %l2
	subcc %l2, 0, %l3
	be .LBB3_12
	nop
! BB#11:                                ! %L77.preheader.i.L84.i_crit_edge
	ba .LBB3_13
	nop
.LBB3_12:                               ! %L77.preheader.i.L101.i_crit_edge
	add %l1, 4, %l2
	ba .LBB3_15
	nop
.LBB3_13:                               ! %L84.i
                                        ! =>This Inner Loop Header: Depth=1
	or %g0, %l2, %l3
	ld [%l3+4], %l2
	subcc %l2, 0, %l4
	bne .LBB3_13
	nop
! BB#14:                                ! %L84.i.L101.i_crit_edge
	add %l3, 4, %l2
.LBB3_15:                               ! %L101.i
	st %l0, [%l2]
	or %g0, %l1, %i0
	restore %g0, %g0, %g0
	retl
	nop
.LBB3_16:                               ! %concatLists.exit
	or %g0, %l0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.LBB3_17:                               ! %L606
	sethi 0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp3:
	.size	postOrder, .Ltmp3-postOrder

	.align	4
	.type	treeadd,@function
treeadd:                                ! @treeadd
! BB#0:
	save %sp, -96, %sp
	subcc %i0, 0, %l0
	bne .LBB4_2
	nop
! BB#1:                                 ! %L623
	or %g0, 3, %o0
	or %g0, 4, %o1
	call calloc
	nop
	sethi 0, %l0
	st %i1, [%o0]
	st %l0, [%o0+4]
	st %l0, [%o0+8]
	or %g0, %o0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.LBB4_2:                                ! %L654
	ld [%i0], %l0
	subcc %l0, %i1, %l0
	ble .LBB4_4
	nop
! BB#3:                                 ! %L662
	ld [%i0+4], %o0
	or %g0, %i1, %o1
	call treeadd
	nop
	st %o0, [%i0+4]
	restore %g0, %g0, %g0
	retl
	nop
.LBB4_4:                                ! %L676
	ld [%i0+8], %o0
	or %g0, %i1, %o1
	call treeadd
	nop
	st %o0, [%i0+8]
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp4:
	.size	treeadd, .Ltmp4-treeadd

	.align	4
	.type	treesearch,@function
treesearch:                             ! @treesearch
! BB#0:
	save %sp, -96, %sp
	sethi %hi(.LC1), %l0
	add %l0, %lo(.LC1), %o0
	or %g0, -1, %o1
	call printf
	nop
	subcc %i0, 0, %l0
	be .LBB5_5
	nop
! BB#1:                                 ! %L915
	ld [%i0], %l0
	subcc %l0, %i1, %l0
	bne .LBB5_3
	nop
.LBB5_2:                                ! %L925
	or %g0, 1, %i0
	restore %g0, %g0, %g0
	retl
	nop
.LBB5_3:                                ! %L935
	ld [%i0+4], %o0
	or %g0, %i1, %o1
	call treesearch
	nop
	subcc %o0, 1, %l0
	be .LBB5_2
	nop
! BB#4:                                 ! %L957
	ld [%i0+8], %o0
	or %g0, %i1, %o1
	call treesearch
	nop
	sethi 0, %i0
	move %icc, 1, %i0
	restore %g0, %g0, %g0
	retl
	nop
.LBB5_5:                                ! %L987
	sethi 0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp5:
	.size	treesearch, .Ltmp5-treesearch

	.align	4
	.type	inOrder,@function
inOrder:                                ! @inOrder
! BB#0:
	save %sp, -96, %sp
	subcc %i0, 0, %l0
	be .LBB6_17
	nop
! BB#1:                                 ! %L1003
	or %g0, 2, %o0
	or %g0, 4, %o1
	call calloc
	nop
	or %g0, %o0, %l0
	ld [%i0], %l1
	sethi 0, %l2
	st %l1, [%l0]
	st %l2, [%l0+4]
	ld [%i0+4], %o0
	call inOrder
	nop
	or %g0, %o0, %l1
	ld [%i0+8], %o0
	call inOrder
	nop
	subcc %l0, 0, %l2
	bne .LBB6_3
	nop
! BB#2:                                 ! %L1003.concatLists.exit15_crit_edge
	or %g0, %o0, %l0
	ba .LBB6_9
	nop
.LBB6_3:                                ! %L77.preheader.i6
	add %l0, 4, %l2
	ld [%l2], %l3
	subcc %l3, 0, %l4
	be .LBB6_5
	nop
! BB#4:                                 ! %L77.preheader.i6.L84.i12_crit_edge
	ba .LBB6_6
	nop
.LBB6_5:                                ! %L77.preheader.i6.L101.i14_crit_edge
	ba .LBB6_8
	nop
.LBB6_6:                                ! %L84.i12
                                        ! =>This Inner Loop Header: Depth=1
	or %g0, %l3, %l2
	ld [%l2+4], %l3
	subcc %l3, 0, %l4
	bne .LBB6_6
	nop
! BB#7:                                 ! %L84.i12.L101.i14_crit_edge
	add %l2, 4, %l2
.LBB6_8:                                ! %L101.i14
	st %o0, [%l2]
.LBB6_9:                                ! %concatLists.exit15
	subcc %l1, 0, %l2
	be .LBB6_16
	nop
! BB#10:                                ! %L77.preheader.i
	ld [%l1+4], %l2
	subcc %l2, 0, %l3
	be .LBB6_12
	nop
! BB#11:                                ! %L77.preheader.i.L84.i_crit_edge
	ba .LBB6_13
	nop
.LBB6_12:                               ! %L77.preheader.i.L101.i_crit_edge
	add %l1, 4, %l2
	ba .LBB6_15
	nop
.LBB6_13:                               ! %L84.i
                                        ! =>This Inner Loop Header: Depth=1
	or %g0, %l2, %l3
	ld [%l3+4], %l2
	subcc %l2, 0, %l4
	bne .LBB6_13
	nop
! BB#14:                                ! %L84.i.L101.i_crit_edge
	add %l3, 4, %l2
.LBB6_15:                               ! %L101.i
	st %l0, [%l2]
	or %g0, %l1, %i0
	restore %g0, %g0, %g0
	retl
	nop
.LBB6_16:                               ! %concatLists.exit
	or %g0, %l0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.LBB6_17:                               ! %L1041
	sethi 0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp6:
	.size	inOrder, .Ltmp6-inOrder

	.align	4
	.type	myCopy,@function
myCopy:                                 ! @myCopy
! BB#0:
	save %sp, -96, %sp
	subcc %i0, 0, %l0
	bne .LBB7_2
	nop
! BB#1:                                 ! %L1441
	sethi 0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.LBB7_2:                                ! %L1451
	ld [%i0], %l0
	or %g0, 2, %o0
	or %g0, 4, %o1
	call calloc
	nop
	or %g0, %o0, %l1
	sethi 0, %l2
	st %l0, [%l1]
	st %l2, [%l1+4]
	ld [%i0+4], %o0
	call myCopy
	nop
	subcc %l1, 0, %l0
	be .LBB7_4
	nop
! BB#3:                                 ! %L101.i
	or %g0, %l1, %i0
	st %o0, [%i0+4]
	restore %g0, %g0, %g0
	retl
	nop
.LBB7_4:                                ! %concatLists.exit
	or %g0, %o0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp7:
	.size	myCopy, .Ltmp7-myCopy

	.globl	main
	.align	4
	.type	main,@function
main:                                   ! @main
! BB#0:                                 ! %bb.nph
	save %sp, -104, %sp
	or %g0, 10, %l0
	sethi 0, %l1
.LBB8_1:                                ! %L1488
                                        ! =>This Loop Header: Depth=1
                                        !     Child Loop BB8_82 Depth 2
                                        !     Child Loop BB8_73 Depth 2
                                        !     Child Loop BB8_64 Depth 2
                                        !     Child Loop BB8_55 Depth 2
                                        !     Child Loop BB8_46 Depth 2
                                        !     Child Loop BB8_37 Depth 2
                                        !     Child Loop BB8_28 Depth 2
                                        !     Child Loop BB8_26 Depth 2
                                        !     Child Loop BB8_23 Depth 2
                                        !     Child Loop BB8_12 Depth 2
                                        !       Child Loop BB8_13 Depth 3
                                        !       Child Loop BB8_19 Depth 3
                                        !     Child Loop BB8_8 Depth 2
                                        !     Child Loop BB8_5 Depth 2
                                        !     Child Loop BB8_3 Depth 2
	sethi %hi(.LC2), %l2
	add %l2, %lo(.LC2), %o0
	add %fp, -4, %o1
	call scanf
	nop
	ld [%fp+-4], %l2
	or %g0, 2, %o0
	or %g0, 4, %o1
	call calloc
	nop
	or %g0, %o0, %l3
	st %l2, [%l3]
	st %l1, [%l3+4]
	call myCopy
	nop
	or %g0, %o0, %l2
	or %g0, %l3, %o0
	call myCopy
	nop
	or %g0, %o0, %l4
	subcc %l2, 0, %l1
	be .LBB8_6
	nop
! BB#2:                                 ! %L1488.L380.i.i_crit_edge
                                        !   in Loop: Header=BB8_1 Depth=1
	or %g0, %l2, %l1
.LBB8_3:                                ! %L380.i.i
                                        !   Parent Loop BB8_1 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	sethi %hi(.LC1), %l5
	ld [%l1], %o1
	add %l5, %lo(.LC1), %l5
	or %g0, %l5, %o0
	call printf
	nop
	ld [%l1+4], %l1
	subcc %l1, 0, %l6
	bne .LBB8_3
	nop
! BB#4:                                 ! %L380.i8.preheader.i
                                        !   in Loop: Header=BB8_1 Depth=1
	or %g0, -999, %o1
	or %g0, %l5, %o0
	call printf
	nop
	or %g0, %l2, %l1
.LBB8_5:                                ! %L380.i8.i
                                        !   Parent Loop BB8_1 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	ld [%l1], %o1
	or %g0, %l5, %o0
	call printf
	nop
	ld [%l1+4], %l1
	subcc %l1, 0, %l6
	be .LBB8_7
	nop
	ba .LBB8_5
	nop
.LBB8_6:                                ! %printList.exit9.thread.i
                                        !   in Loop: Header=BB8_1 Depth=1
	sethi %hi(.LC1), %l1
	add %l1, %lo(.LC1), %l1
	or %g0, -999, %l5
	or %g0, %l1, %o0
	or %g0, %l5, %o1
	call printf
	nop
	or %g0, %l1, %o0
	or %g0, %l5, %o1
	call printf
	nop
	ba .LBB8_9
	nop
.LBB8_7:                                ! %L380.i17.preheader.i
                                        !   in Loop: Header=BB8_1 Depth=1
	or %g0, -999, %o1
	or %g0, %l5, %o0
	call printf
	nop
	or %g0, %l2, %l1
.LBB8_8:                                ! %L380.i17.i
                                        !   Parent Loop BB8_1 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	ld [%l1], %o1
	or %g0, %l5, %o0
	call printf
	nop
	ld [%l1+4], %l1
	subcc %l1, 0, %l6
	bne .LBB8_8
	nop
.LBB8_9:                                ! %quickSortMain.exit
                                        !   in Loop: Header=BB8_1 Depth=1
	sethi %hi(.LC1), %l1
	add %l1, %lo(.LC1), %l1
	or %g0, -999, %o1
	or %g0, %l1, %o0
	call printf
	nop
	or %g0, %l2, %o0
	call freeList
	nop
	subcc %l4, 0, %l5
	be .LBB8_11
	nop
! BB#10:                                ! %quickSortMain.exit.L301.i.preheader.i.i_crit_edge
                                        !   in Loop: Header=BB8_1 Depth=1
	sethi 0, %l5
	or %g0, %l5, %l6
	or %g0, %l5, %o0
	ba .LBB8_12
	nop
.LBB8_11:                               ! %quickSortMain.exit.buildTree.exit.i_crit_edge
                                        !   in Loop: Header=BB8_1 Depth=1
	sethi 0, %l5
	ba .LBB8_21
	nop
.LBB8_12:                               ! %L301.i.preheader.i.i
                                        !   Parent Loop BB8_1 Depth=1
                                        ! =>  This Loop Header: Depth=2
                                        !       Child Loop BB8_13 Depth 3
                                        !       Child Loop BB8_19 Depth 3
	or %g0, %l4, %l7
	or %g0, %l5, %i0
.LBB8_13:                               ! %L301.i.i.i
                                        !   Parent Loop BB8_1 Depth=1
                                        !     Parent Loop BB8_12 Depth=2
                                        ! =>    This Inner Loop Header: Depth=3
	add %i0, 1, %i0
	ld [%l7+4], %l7
	subcc %l7, 0, %i1
	bne .LBB8_13
	nop
! BB#14:                                ! %size.exit.i.i
                                        !   in Loop: Header=BB8_12 Depth=2
	subcc %l6, %i0, %l7
	bl .LBB8_16
	nop
! BB#15:                                ! %size.exit.i.i.buildTree.exit.i_crit_edge
                                        !   in Loop: Header=BB8_1 Depth=1
	or %g0, %o0, %l5
	ba .LBB8_21
	nop
.LBB8_16:                               ! %L1154.i.i
                                        !   in Loop: Header=BB8_12 Depth=2
	subcc %l6, 0, %l7
	be .LBB8_18
	nop
! BB#17:                                ! %L1154.i.i.L337.i.i.i_crit_edge
                                        !   in Loop: Header=BB8_12 Depth=2
	or %g0, %l6, %l7
	or %g0, %l4, %i0
	ba .LBB8_19
	nop
.LBB8_18:                               ! %L1154.i.i.get.exit.i.i_crit_edge
                                        !   in Loop: Header=BB8_12 Depth=2
	or %g0, %l4, %i0
	ba .LBB8_20
	nop
.LBB8_19:                               ! %L337.i.i.i
                                        !   Parent Loop BB8_1 Depth=1
                                        !     Parent Loop BB8_12 Depth=2
                                        ! =>    This Inner Loop Header: Depth=3
	ld [%i0+4], %i0
	add %l7, -1, %l7
	subcc %l7, 0, %i1
	bne .LBB8_19
	nop
.LBB8_20:                               ! %get.exit.i.i
                                        !   in Loop: Header=BB8_12 Depth=2
	ld [%i0], %o1
	add %l6, 1, %l6
	call treeadd
	nop
	ba .LBB8_12
	nop
.LBB8_21:                               ! %buildTree.exit.i
                                        !   in Loop: Header=BB8_1 Depth=1
	or %g0, %l5, %o0
	call treeprint
	nop
	or %g0, -999, %o1
	or %g0, %l1, %o0
	call printf
	nop
	or %g0, %l5, %o0
	call inOrder
	nop
	or %g0, %o0, %l6
	subcc %o0, 0, %l7
	be .LBB8_24
	nop
! BB#22:                                ! %buildTree.exit.i.L380.i.i13_crit_edge
                                        !   in Loop: Header=BB8_1 Depth=1
	or %g0, %l6, %l7
.LBB8_23:                               ! %L380.i.i13
                                        !   Parent Loop BB8_1 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	ld [%l7], %o1
	or %g0, %l1, %o0
	call printf
	nop
	ld [%l7+4], %l7
	subcc %l7, 0, %i0
	bne .LBB8_23
	nop
.LBB8_24:                               ! %printList.exit.i
                                        !   in Loop: Header=BB8_1 Depth=1
	or %g0, -999, %o1
	or %g0, %l1, %o0
	call printf
	nop
	or %g0, %l6, %o0
	call freeList
	nop
	or %g0, %l5, %o0
	call postOrder
	nop
	or %g0, %o0, %l6
	subcc %o0, 0, %l7
	be .LBB8_27
	nop
! BB#25:                                ! %printList.exit.i.L380.i8.i20_crit_edge
                                        !   in Loop: Header=BB8_1 Depth=1
	or %g0, %l6, %l7
.LBB8_26:                               ! %L380.i8.i20
                                        !   Parent Loop BB8_1 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	ld [%l7], %o1
	or %g0, %l1, %o0
	call printf
	nop
	ld [%l7+4], %l7
	subcc %l7, 0, %i0
	bne .LBB8_26
	nop
.LBB8_27:                               ! %printList.exit9.i
                                        !   in Loop: Header=BB8_1 Depth=1
	or %g0, -999, %l7
	or %g0, %l1, %o0
	or %g0, %l7, %o1
	call printf
	nop
	or %g0, %l6, %o0
	call freeList
	nop
	sethi 0, %l6
	or %g0, %l5, %o0
	or %g0, %l6, %o1
	call treesearch
	nop
	or %g0, %o0, %o1
	or %g0, %l1, %o0
	call printf
	nop
	or %g0, %l1, %o0
	or %g0, %l7, %o1
	call printf
	nop
	or %g0, 10, %o1
	or %g0, %l5, %o0
	call treesearch
	nop
	or %g0, %o0, %o1
	or %g0, %l1, %o0
	call printf
	nop
	or %g0, %l1, %o0
	or %g0, %l7, %o1
	call printf
	nop
	or %g0, -2, %o1
	or %g0, %l5, %o0
	call treesearch
	nop
	or %g0, %o0, %o1
	or %g0, %l1, %o0
	call printf
	nop
	or %g0, %l1, %o0
	or %g0, %l7, %o1
	call printf
	nop
	or %g0, 2, %o1
	or %g0, %l5, %o0
	call treesearch
	nop
	or %g0, %o0, %o1
	or %g0, %l1, %o0
	call printf
	nop
	or %g0, %l1, %o0
	or %g0, %l7, %o1
	call printf
	nop
	or %g0, 3, %o1
	or %g0, %l5, %o0
	call treesearch
	nop
	or %g0, %o0, %o1
	or %g0, %l1, %o0
	call printf
	nop
	or %g0, %l1, %o0
	or %g0, %l7, %o1
	call printf
	nop
	or %g0, 9, %o1
	or %g0, %l5, %o0
	call treesearch
	nop
	or %g0, %o0, %o1
	or %g0, %l1, %o0
	call printf
	nop
	or %g0, %l1, %o0
	or %g0, %l7, %o1
	call printf
	nop
	or %g0, 1, %o1
	or %g0, %l5, %o0
	call treesearch
	nop
	or %g0, %o0, %o1
	or %g0, %l1, %o0
	call printf
	nop
	or %g0, %l1, %o0
	or %g0, %l7, %o1
	call printf
	nop
	or %g0, %l5, %l7
.LBB8_28:                               ! %tailrecurse.i.i
                                        !   Parent Loop BB8_1 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	or %g0, -1, %o1
	or %g0, %l1, %o0
	call printf
	nop
	subcc %l7, 0, %i0
	bne .LBB8_30
	nop
! BB#29:                                ! %tailrecurse.i.i.bintreesearch.exit.i_crit_edge
                                        !   in Loop: Header=BB8_1 Depth=1
	sethi 0, %o1
	ba .LBB8_36
	nop
.LBB8_30:                               ! %L1067.i.i
                                        !   in Loop: Header=BB8_28 Depth=2
	ld [%l7], %i0
	subcc %i0, 0, %i1
	bne .LBB8_32
	nop
! BB#31:                                ! %L1067.i.i.bintreesearch.exit.i_crit_edge
                                        !   in Loop: Header=BB8_1 Depth=1
	or %g0, 1, %o1
	ba .LBB8_36
	nop
.LBB8_32:                               ! %L1087.i.i
                                        !   in Loop: Header=BB8_28 Depth=2
	subcc %i0, 1, %i0
	bl .LBB8_35
	nop
! BB#33:                                ! %L1095.i.i
                                        !   in Loop: Header=BB8_28 Depth=2
	add %l7, 4, %l7
.LBB8_34:                               ! %tailrecurse.backedge.i.i
                                        !   in Loop: Header=BB8_28 Depth=2
	ld [%l7], %l7
	ba .LBB8_28
	nop
.LBB8_35:                               ! %L1107.i.i
                                        !   in Loop: Header=BB8_28 Depth=2
	add %l7, 8, %l7
	ba .LBB8_34
	nop
.LBB8_36:                               ! %bintreesearch.exit.i
                                        !   in Loop: Header=BB8_1 Depth=1
	or %g0, %l1, %o0
	call printf
	nop
	or %g0, -999, %o1
	or %g0, %l1, %o0
	call printf
	nop
	or %g0, %l5, %l7
.LBB8_37:                               ! %tailrecurse.i13.i
                                        !   Parent Loop BB8_1 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	or %g0, -1, %o1
	or %g0, %l1, %o0
	call printf
	nop
	subcc %l7, 0, %i0
	bne .LBB8_39
	nop
! BB#38:                                ! %tailrecurse.i13.i.bintreesearch.exit29.i_crit_edge
                                        !   in Loop: Header=BB8_1 Depth=1
	sethi 0, %o1
	ba .LBB8_45
	nop
.LBB8_39:                               ! %L1067.i17.i
                                        !   in Loop: Header=BB8_37 Depth=2
	ld [%l7], %i0
	subcc %i0, 10, %i1
	bne .LBB8_41
	nop
! BB#40:                                ! %L1067.i17.i.bintreesearch.exit29.i_crit_edge
                                        !   in Loop: Header=BB8_1 Depth=1
	or %g0, 1, %o1
	ba .LBB8_45
	nop
.LBB8_41:                               ! %L1087.i20.i
                                        !   in Loop: Header=BB8_37 Depth=2
	subcc %i0, 11, %i0
	bl .LBB8_44
	nop
! BB#42:                                ! %L1095.i22.i
                                        !   in Loop: Header=BB8_37 Depth=2
	add %l7, 4, %l7
.LBB8_43:                               ! %tailrecurse.backedge.i25.i
                                        !   in Loop: Header=BB8_37 Depth=2
	ld [%l7], %l7
	ba .LBB8_37
	nop
.LBB8_44:                               ! %L1107.i27.i
                                        !   in Loop: Header=BB8_37 Depth=2
	add %l7, 8, %l7
	ba .LBB8_43
	nop
.LBB8_45:                               ! %bintreesearch.exit29.i
                                        !   in Loop: Header=BB8_1 Depth=1
	or %g0, %l1, %o0
	call printf
	nop
	or %g0, -999, %o1
	or %g0, %l1, %o0
	call printf
	nop
	or %g0, %l5, %l7
.LBB8_46:                               ! %tailrecurse.i33.i
                                        !   Parent Loop BB8_1 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	or %g0, -1, %o1
	or %g0, %l1, %o0
	call printf
	nop
	subcc %l7, 0, %i0
	bne .LBB8_48
	nop
! BB#47:                                ! %tailrecurse.i33.i.bintreesearch.exit49.i_crit_edge
                                        !   in Loop: Header=BB8_1 Depth=1
	sethi 0, %o1
	ba .LBB8_54
	nop
.LBB8_48:                               ! %L1067.i37.i
                                        !   in Loop: Header=BB8_46 Depth=2
	ld [%l7], %i0
	subcc %i0, -2, %i1
	bne .LBB8_50
	nop
! BB#49:                                ! %L1067.i37.i.bintreesearch.exit49.i_crit_edge
                                        !   in Loop: Header=BB8_1 Depth=1
	or %g0, 1, %o1
	ba .LBB8_54
	nop
.LBB8_50:                               ! %L1087.i40.i
                                        !   in Loop: Header=BB8_46 Depth=2
	subcc %i0, -1, %i0
	bl .LBB8_53
	nop
! BB#51:                                ! %L1095.i42.i
                                        !   in Loop: Header=BB8_46 Depth=2
	add %l7, 4, %l7
.LBB8_52:                               ! %tailrecurse.backedge.i45.i
                                        !   in Loop: Header=BB8_46 Depth=2
	ld [%l7], %l7
	ba .LBB8_46
	nop
.LBB8_53:                               ! %L1107.i47.i
                                        !   in Loop: Header=BB8_46 Depth=2
	add %l7, 8, %l7
	ba .LBB8_52
	nop
.LBB8_54:                               ! %bintreesearch.exit49.i
                                        !   in Loop: Header=BB8_1 Depth=1
	or %g0, %l1, %o0
	call printf
	nop
	or %g0, -999, %o1
	or %g0, %l1, %o0
	call printf
	nop
	or %g0, %l5, %l7
.LBB8_55:                               ! %tailrecurse.i53.i
                                        !   Parent Loop BB8_1 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	or %g0, -1, %o1
	or %g0, %l1, %o0
	call printf
	nop
	subcc %l7, 0, %i0
	bne .LBB8_57
	nop
! BB#56:                                ! %tailrecurse.i53.i.bintreesearch.exit69.i_crit_edge
                                        !   in Loop: Header=BB8_1 Depth=1
	sethi 0, %o1
	ba .LBB8_63
	nop
.LBB8_57:                               ! %L1067.i57.i
                                        !   in Loop: Header=BB8_55 Depth=2
	ld [%l7], %i0
	subcc %i0, 2, %i1
	bne .LBB8_59
	nop
! BB#58:                                ! %L1067.i57.i.bintreesearch.exit69.i_crit_edge
                                        !   in Loop: Header=BB8_1 Depth=1
	or %g0, 1, %o1
	ba .LBB8_63
	nop
.LBB8_59:                               ! %L1087.i60.i
                                        !   in Loop: Header=BB8_55 Depth=2
	subcc %i0, 3, %i0
	bl .LBB8_62
	nop
! BB#60:                                ! %L1095.i62.i
                                        !   in Loop: Header=BB8_55 Depth=2
	add %l7, 4, %l7
.LBB8_61:                               ! %tailrecurse.backedge.i65.i
                                        !   in Loop: Header=BB8_55 Depth=2
	ld [%l7], %l7
	ba .LBB8_55
	nop
.LBB8_62:                               ! %L1107.i67.i
                                        !   in Loop: Header=BB8_55 Depth=2
	add %l7, 8, %l7
	ba .LBB8_61
	nop
.LBB8_63:                               ! %bintreesearch.exit69.i
                                        !   in Loop: Header=BB8_1 Depth=1
	or %g0, %l1, %o0
	call printf
	nop
	or %g0, -999, %o1
	or %g0, %l1, %o0
	call printf
	nop
	or %g0, %l5, %l7
.LBB8_64:                               ! %tailrecurse.i73.i
                                        !   Parent Loop BB8_1 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	or %g0, -1, %o1
	or %g0, %l1, %o0
	call printf
	nop
	subcc %l7, 0, %i0
	bne .LBB8_66
	nop
! BB#65:                                ! %tailrecurse.i73.i.bintreesearch.exit89.i_crit_edge
                                        !   in Loop: Header=BB8_1 Depth=1
	sethi 0, %o1
	ba .LBB8_72
	nop
.LBB8_66:                               ! %L1067.i77.i
                                        !   in Loop: Header=BB8_64 Depth=2
	ld [%l7], %i0
	subcc %i0, 3, %i1
	bne .LBB8_68
	nop
! BB#67:                                ! %L1067.i77.i.bintreesearch.exit89.i_crit_edge
                                        !   in Loop: Header=BB8_1 Depth=1
	or %g0, 1, %o1
	ba .LBB8_72
	nop
.LBB8_68:                               ! %L1087.i80.i
                                        !   in Loop: Header=BB8_64 Depth=2
	subcc %i0, 4, %i0
	bl .LBB8_71
	nop
! BB#69:                                ! %L1095.i82.i
                                        !   in Loop: Header=BB8_64 Depth=2
	add %l7, 4, %l7
.LBB8_70:                               ! %tailrecurse.backedge.i85.i
                                        !   in Loop: Header=BB8_64 Depth=2
	ld [%l7], %l7
	ba .LBB8_64
	nop
.LBB8_71:                               ! %L1107.i87.i
                                        !   in Loop: Header=BB8_64 Depth=2
	add %l7, 8, %l7
	ba .LBB8_70
	nop
.LBB8_72:                               ! %bintreesearch.exit89.i
                                        !   in Loop: Header=BB8_1 Depth=1
	or %g0, %l1, %o0
	call printf
	nop
	or %g0, -999, %o1
	or %g0, %l1, %o0
	call printf
	nop
	or %g0, %l5, %l7
.LBB8_73:                               ! %tailrecurse.i93.i
                                        !   Parent Loop BB8_1 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	or %g0, -1, %o1
	or %g0, %l1, %o0
	call printf
	nop
	subcc %l7, 0, %i0
	bne .LBB8_75
	nop
! BB#74:                                ! %tailrecurse.i93.i.bintreesearch.exit109.i_crit_edge
                                        !   in Loop: Header=BB8_1 Depth=1
	sethi 0, %o1
	ba .LBB8_81
	nop
.LBB8_75:                               ! %L1067.i97.i
                                        !   in Loop: Header=BB8_73 Depth=2
	ld [%l7], %i0
	subcc %i0, 9, %i1
	bne .LBB8_77
	nop
! BB#76:                                ! %L1067.i97.i.bintreesearch.exit109.i_crit_edge
                                        !   in Loop: Header=BB8_1 Depth=1
	or %g0, 1, %o1
	ba .LBB8_81
	nop
.LBB8_77:                               ! %L1087.i100.i
                                        !   in Loop: Header=BB8_73 Depth=2
	subcc %i0, 10, %i0
	bl .LBB8_80
	nop
! BB#78:                                ! %L1095.i102.i
                                        !   in Loop: Header=BB8_73 Depth=2
	add %l7, 4, %l7
.LBB8_79:                               ! %tailrecurse.backedge.i105.i
                                        !   in Loop: Header=BB8_73 Depth=2
	ld [%l7], %l7
	ba .LBB8_73
	nop
.LBB8_80:                               ! %L1107.i107.i
                                        !   in Loop: Header=BB8_73 Depth=2
	add %l7, 8, %l7
	ba .LBB8_79
	nop
.LBB8_81:                               ! %bintreesearch.exit109.i
                                        !   in Loop: Header=BB8_1 Depth=1
	or %g0, %l1, %o0
	call printf
	nop
	or %g0, -999, %o1
	or %g0, %l1, %o0
	call printf
	nop
	or %g0, %l5, %l7
.LBB8_82:                               ! %tailrecurse.i113.i
                                        !   Parent Loop BB8_1 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	or %g0, -1, %o1
	or %g0, %l1, %o0
	call printf
	nop
	subcc %l7, 0, %i0
	bne .LBB8_84
	nop
! BB#83:                                ! %tailrecurse.i113.i.treeMain.exit_crit_edge
                                        !   in Loop: Header=BB8_1 Depth=1
	or %g0, %l6, %o1
	ba .LBB8_90
	nop
.LBB8_84:                               ! %L1067.i117.i
                                        !   in Loop: Header=BB8_82 Depth=2
	ld [%l7], %i0
	subcc %i0, 1, %i1
	bne .LBB8_86
	nop
! BB#85:                                ! %L1067.i117.i.treeMain.exit_crit_edge
                                        !   in Loop: Header=BB8_1 Depth=1
	or %g0, 1, %o1
	ba .LBB8_90
	nop
.LBB8_86:                               ! %L1087.i120.i
                                        !   in Loop: Header=BB8_82 Depth=2
	subcc %i0, 2, %i0
	bl .LBB8_89
	nop
! BB#87:                                ! %L1095.i122.i
                                        !   in Loop: Header=BB8_82 Depth=2
	add %l7, 4, %l7
.LBB8_88:                               ! %tailrecurse.backedge.i125.i
                                        !   in Loop: Header=BB8_82 Depth=2
	ld [%l7], %l7
	ba .LBB8_82
	nop
.LBB8_89:                               ! %L1107.i127.i
                                        !   in Loop: Header=BB8_82 Depth=2
	add %l7, 8, %l7
	ba .LBB8_88
	nop
.LBB8_90:                               ! %treeMain.exit
                                        !   in Loop: Header=BB8_1 Depth=1
	or %g0, %l1, %o0
	call printf
	nop
	or %g0, -999, %o1
	or %g0, %l1, %o0
	call printf
	nop
	add %l0, -1, %l0
	or %g0, %l5, %o0
	call freeTree
	nop
	subcc %l0, 0, %l1
	or %g0, %l3, %l1
	bne .LBB8_1
	nop
! BB#91:                                ! %L1547
	or %g0, %l3, %o0
	call freeList
	nop
	or %g0, %l2, %o0
	call freeList
	nop
	or %g0, %l4, %o0
	call freeList
	nop
	sethi 0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp8:
	.size	main, .Ltmp8-main

	.type	.LC1,@object            ! @.LC1
	.section	.rodata.str1.1,"aMS",@progbits,1
.LC1:
	.asciz	 "%d\n"
	.size	.LC1, 4

	.type	.LC2,@object            ! @.LC2
.LC2:
	.asciz	 "%d"
	.size	.LC2, 3


