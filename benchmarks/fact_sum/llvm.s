	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmpE47F.tmp"
	.text
	.globl	sum
	.align	4
	.type	sum,@function
sum:                                    ! @sum
! BB#0:
	save %sp, -96, %sp
	add %i1, %i0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp0:
	.size	sum, .Ltmp0-sum

	.globl	fact
	.align	4
	.type	fact,@function
fact:                                   ! @fact
! BB#0:
	save %sp, -96, %sp
	or %g0, 1, %l0
.LBB1_1:                                ! %tailrecurse
                                        ! =>This Inner Loop Header: Depth=1
	subcc %i0, 1, %l1
	bgu .LBB1_3
	nop
! BB#2:                                 ! %L2367
	or %g0, %l0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.LBB1_3:                                ! %L2377
                                        !   in Loop: Header=BB1_1 Depth=1
	subcc %i0, 1, %l1
	bg .LBB1_5
	nop
! BB#4:                                 ! %L2383
                                        !   in Loop: Header=BB1_1 Depth=1
	sethi 0, %l1
	sub %l1, %i0, %i0
	ba .LBB1_1
	nop
.LBB1_5:                                ! %L2400
                                        !   in Loop: Header=BB1_1 Depth=1
	add %i0, -1, %l1
	smul %i0, %l0, %l0
	or %g0, %l1, %i0
	ba .LBB1_1
	nop
.Ltmp1:
	.size	fact, .Ltmp1-fact

	.globl	main
	.align	4
	.type	main,@function
main:                                   ! @main
! BB#0:
	save %sp, -104, %sp
.LBB2_1:                                ! %L2435
                                        ! =>This Loop Header: Depth=1
                                        !     Child Loop BB2_7 Depth 2
                                        !     Child Loop BB2_2 Depth 2
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
.LBB2_2:                                ! %tailrecurse.i
                                        !   Parent Loop BB2_1 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	subcc %l2, 1, %l4
	bgu .LBB2_4
	nop
! BB#3:                                 ! %tailrecurse.i.tailrecurse.outer.i3_crit_edge
                                        !   in Loop: Header=BB2_1 Depth=1
	or %g0, 1, %l2
	ba .LBB2_7
	nop
.LBB2_4:                                ! %L2377.i
                                        !   in Loop: Header=BB2_2 Depth=2
	subcc %l2, 1, %l4
	bg .LBB2_6
	nop
! BB#5:                                 ! %L2383.i
                                        !   in Loop: Header=BB2_2 Depth=2
	sethi 0, %l4
	sub %l4, %l2, %l2
	ba .LBB2_2
	nop
.LBB2_6:                                ! %L2400.i
                                        !   in Loop: Header=BB2_2 Depth=2
	add %l2, -1, %l4
	smul %l2, %l3, %l3
	or %g0, %l4, %l2
	ba .LBB2_2
	nop
.LBB2_7:                                ! %tailrecurse.i5
                                        !   Parent Loop BB2_1 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	subcc %l1, 2, %l4
	bcs .LBB2_11
	nop
! BB#8:                                 ! %L2377.i7
                                        !   in Loop: Header=BB2_7 Depth=2
	subcc %l1, 1, %l4
	bg .LBB2_10
	nop
! BB#9:                                 ! %L2383.i9
                                        !   in Loop: Header=BB2_7 Depth=2
	sethi 0, %l4
	sub %l4, %l1, %l1
	ba .LBB2_7
	nop
.LBB2_10:                               ! %L2400.i12
                                        !   in Loop: Header=BB2_7 Depth=2
	add %l1, -1, %l4
	smul %l1, %l2, %l2
	or %g0, %l4, %l1
	ba .LBB2_7
	nop
.LBB2_11:                               ! %fact.exit13
                                        !   in Loop: Header=BB2_1 Depth=1
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
	bne .LBB2_1
	nop
! BB#12:                                ! %L2475
	sethi 0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp2:
	.size	main, .Ltmp2-main

	.type	.LC1,@object            ! @.LC1
	.section	.rodata.str1.1,"aMS",@progbits,1
.LC1:
	.asciz	 "%d\n"
	.size	.LC1, 4

	.type	.LC2,@object            ! @.LC2
.LC2:
	.asciz	 "%d"
	.size	.LC2, 3


