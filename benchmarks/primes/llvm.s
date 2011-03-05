	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmpE4EE.tmp"
	.text
	.globl	isqrt
	.align	4
	.type	isqrt,@function
isqrt:                                  ! @isqrt
! BB#0:
	save %sp, -96, %sp
	subcc %i0, 1, %l0
	bl .LBB0_4
	nop
! BB#1:                                 ! %.L6352_crit_edge
	or %g0, 3, %l0
	or %g0, 1, %l1
.LBB0_2:                                ! %L6352
                                        ! =>This Inner Loop Header: Depth=1
	add %l0, 2, %l2
	add %l0, %l1, %l1
	subcc %l1, %i0, %l0
	or %g0, %l2, %l0
	ble .LBB0_2
	nop
! BB#3:                                 ! %L6345.L6380_crit_edge
	srl %l2, 31, %l0
	add %l2, %l0, %l0
	sra %l0, 1, %l0
	add %l0, -1, %i0
	restore %g0, %g0, %g0
	retl
	nop
.LBB0_4:                                ! %L6380
	sethi 0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp0:
	.size	isqrt, .Ltmp0-isqrt

	.globl	prime
	.align	4
	.type	prime,@function
prime:                                  ! @prime
! BB#0:
	save %sp, -96, %sp
	subcc %i0, 2, %l0
	bl .LBB1_2
	nop
! BB#1:                                 ! %.L6352.i_crit_edge
	sethi 0, %l0
	or %g0, 1, %l1
	ba .LBB1_3
	nop
.LBB1_2:                                ! %L6402
	sethi 0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.LBB1_3:                                ! %L6352.i
                                        ! =>This Inner Loop Header: Depth=1
	add %l1, %l0, %l1
	add %l0, 2, %l0
	add %l1, 3, %l1
	subcc %l1, %i0, %l2
	ble .LBB1_3
	nop
! BB#4:                                 ! %isqrt.exit
	add %l0, 3, %l0
	srl %l0, 31, %l1
	add %l0, %l1, %l0
	sra %l0, 1, %l0
	add %l0, -1, %l0
	or %g0, 2, %l1
.LBB1_5:                                ! %L6420
                                        ! =>This Inner Loop Header: Depth=1
	subcc %l1, %l0, %l2
	bg .LBB1_8
	nop
! BB#6:                                 ! %L6427
                                        !   in Loop: Header=BB1_5 Depth=1
	sra %i0, 31, %l2
	wr %l2, %g0, %y
	sdiv %i0, %l1, %l2
	smul %l2, %l1, %l2
	sub %i0, %l2, %l2
	subcc %l2, 0, %l2
	be .LBB1_2
	nop
! BB#7:                                 ! %L6462
                                        !   in Loop: Header=BB1_5 Depth=1
	add %l1, 1, %l1
	ba .LBB1_5
	nop
.LBB1_8:                                ! %L6479
	or %g0, 1, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp1:
	.size	prime, .Ltmp1-prime

	.globl	main
	.align	4
	.type	main,@function
main:                                   ! @main
! BB#0:
	save %sp, -104, %sp
	sethi %hi(.LC2), %l0
	add %l0, %lo(.LC2), %o0
	add %fp, -4, %o1
	call scanf
	nop
	ld [%fp+-4], %l0
	subcc %l0, 0, %l1
	bl .LBB2_11
	nop
! BB#1:                                 ! %.L6504_crit_edge
	sethi 0, %l1
.LBB2_2:                                ! %L6504
                                        ! =>This Loop Header: Depth=1
                                        !     Child Loop BB2_6 Depth 2
                                        !     Child Loop BB2_4 Depth 2
	subcc %l1, 2, %l2
	bl .LBB2_10
	nop
! BB#3:                                 ! %L6504.L6352.i.i_crit_edge
                                        !   in Loop: Header=BB2_2 Depth=1
	or %g0, 3, %l2
	or %g0, 1, %l3
.LBB2_4:                                ! %L6352.i.i
                                        !   Parent Loop BB2_2 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	add %l2, 2, %l4
	add %l2, %l3, %l3
	subcc %l3, %l1, %l2
	or %g0, %l4, %l2
	ble .LBB2_4
	nop
! BB#5:                                 ! %isqrt.exit.i
                                        !   in Loop: Header=BB2_2 Depth=1
	srl %l4, 31, %l2
	add %l4, %l2, %l2
	sra %l2, 1, %l2
	add %l2, -1, %l2
	or %g0, 2, %l3
.LBB2_6:                                ! %L6420.i
                                        !   Parent Loop BB2_2 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	subcc %l3, %l2, %l4
	bg .LBB2_9
	nop
! BB#7:                                 ! %L6427.i
                                        !   in Loop: Header=BB2_6 Depth=2
	sra %l1, 31, %l4
	wr %l4, %g0, %y
	sdiv %l1, %l3, %l4
	smul %l4, %l3, %l4
	sub %l1, %l4, %l4
	subcc %l4, 0, %l4
	be .LBB2_10
	nop
! BB#8:                                 ! %L6462.i
                                        !   in Loop: Header=BB2_6 Depth=2
	add %l3, 1, %l3
	ba .LBB2_6
	nop
.LBB2_9:                                ! %L6511
                                        !   in Loop: Header=BB2_2 Depth=1
	sethi %hi(.LC1), %l2
	add %l2, %lo(.LC1), %o0
	or %g0, %l1, %o1
	call printf
	nop
.LBB2_10:                               ! %L6522
                                        !   in Loop: Header=BB2_2 Depth=1
	add %l1, 1, %l1
	subcc %l1, %l0, %l2
	ble .LBB2_2
	nop
.LBB2_11:                               ! %L6539
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


