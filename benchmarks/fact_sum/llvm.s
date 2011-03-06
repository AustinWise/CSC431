	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmpB057.tmp"
	.text
	.globl	main
	.align	4
	.type	main,@function
main:                                   ! @main
! BB#0:
	save %sp, -104, %sp
.LBB0_1:                                ! %L3053
                                        ! =>This Loop Header: Depth=1
                                        !     Child Loop BB0_7 Depth 2
                                        !     Child Loop BB0_2 Depth 2
	sethi %hi(.LC2), %l0
	add %l0, %lo(.LC2), %l0
	add %fp, -4, %l1
	or %g0, %l0, %o0
	or %g0, %l1, %o1
	call scanf
	nop
	ld [%fp+-4], %l2
	or %g0, %l0, %o0
	or %g0, %l1, %o1
	call scanf
	nop
	ld [%fp+-4], %l1
	or %g0, 1, %l3
.LBB0_2:                                ! %tailrecurse.i
                                        !   Parent Loop BB0_1 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	subcc %l2, 1, %l4
	bgu .LBB0_4
	nop
! BB#3:                                 ! %tailrecurse.i.tailrecurse.outer.i3_crit_edge
                                        !   in Loop: Header=BB0_1 Depth=1
	or %g0, 1, %l2
	ba .LBB0_7
	nop
.LBB0_4:                                ! %L2995.i
                                        !   in Loop: Header=BB0_2 Depth=2
	subcc %l2, 1, %l4
	bg .LBB0_6
	nop
! BB#5:                                 ! %L3001.i
                                        !   in Loop: Header=BB0_2 Depth=2
	sethi 0, %l4
	sub %l4, %l2, %l2
	ba .LBB0_2
	nop
.LBB0_6:                                ! %L3018.i
                                        !   in Loop: Header=BB0_2 Depth=2
	add %l2, -1, %l4
	smul %l2, %l3, %l3
	or %g0, %l4, %l2
	ba .LBB0_2
	nop
.LBB0_7:                                ! %tailrecurse.i5
                                        !   Parent Loop BB0_1 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	subcc %l1, 2, %l4
	bcs .LBB0_11
	nop
! BB#8:                                 ! %L2995.i7
                                        !   in Loop: Header=BB0_7 Depth=2
	subcc %l1, 1, %l4
	bg .LBB0_10
	nop
! BB#9:                                 ! %L3001.i9
                                        !   in Loop: Header=BB0_7 Depth=2
	sethi 0, %l4
	sub %l4, %l1, %l1
	ba .LBB0_7
	nop
.LBB0_10:                               ! %L3018.i12
                                        !   in Loop: Header=BB0_7 Depth=2
	add %l1, -1, %l4
	smul %l1, %l2, %l2
	or %g0, %l4, %l1
	ba .LBB0_7
	nop
.LBB0_11:                               ! %fact.exit13
                                        !   in Loop: Header=BB0_1 Depth=1
	sethi %hi(.LC1), %l1
	add %l1, %lo(.LC1), %o0
	add %l2, %l3, %o1
	call printf
	nop
	add %fp, -4, %o1
	or %g0, %l0, %o0
	call scanf
	nop
	ld [%fp+-4], %l0
	subcc %l0, -1, %l0
	bne .LBB0_1
	nop
! BB#12:                                ! %L3093
	sethi 0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp0:
	.size	main, .Ltmp0-main

	.type	.LC1,@object            ! @.LC1
	.section	.rodata.str1.1,"aMS",@progbits,1
.LC1:
	.asciz	 "%d\n"
	.size	.LC1, 4

	.type	.LC2,@object            ! @.LC2
.LC2:
	.asciz	 "%d"
	.size	.LC2, 3


