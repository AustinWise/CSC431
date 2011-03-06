	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmpB0A7.tmp"
	.text
	.align	4
	.type	multBy4xTimes,@function
multBy4xTimes:                          ! @multBy4xTimes
! BB#0:
	save %sp, -96, %sp
	subcc %i1, 0, %l0
	bg .LBB0_2
	nop
! BB#1:                                 ! %L3259
	restore %g0, %g0, %g0
	retl
	nop
.LBB0_2:                                ! %L3271
	ld [%i0], %l0
	sll %l0, 2, %l0
	st %l0, [%i0]
	add %i1, -1, %o1
	or %g0, %i0, %o0
	call multBy4xTimes
	nop
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp0:
	.size	multBy4xTimes, .Ltmp0-multBy4xTimes

	.globl	main
	.align	4
	.type	main,@function
main:                                   ! @main
! BB#0:                                 ! %bb.nph6
	save %sp, -104, %sp
	or %g0, 1, %l0
	or %g0, 4, %o1
	or %g0, %l0, %o0
	call calloc
	nop
	or %g0, %o0, %l1
	sethi %hi(.LC2), %l2
	add %l2, %lo(.LC2), %l2
	add %fp, -4, %l3
	or %g0, %l2, %o0
	or %g0, %l3, %o1
	call scanf
	nop
	ld [%fp+-4], %l4
	or %g0, %l2, %o0
	or %g0, %l3, %o1
	call scanf
	nop
	ld [%fp+-4], %l2
	sethi %hi(.LC1), %l3
	add %l2, -1, %l5
	add %l3, %lo(.LC1), %l3
	movg %icc, %l5, %l0
	or %g0, %l3, %o0
	or %g0, %l4, %o1
	call printf
	nop
	add %l0, 1, %l0
	or %g0, 50, %l4
	or %g0, %l3, %o0
	or %g0, %l2, %o1
	call printf
	nop
.LBB1_1:                                ! %bb.nph
                                        ! =>This Loop Header: Depth=1
                                        !     Child Loop BB1_2 Depth 2
	sethi 0, %l2
.LBB1_2:                                ! %L3382
                                        !   Parent Loop BB1_1 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	add %l2, 1, %l5
	st %l5, [%l1]
	or %g0, 2, %o1
	or %g0, %l1, %o0
	call multBy4xTimes
	nop
	ld [%l1], %l5
	sra %l5, 31, %l6
	srl %l6, 29, %l6
	add %l5, %l6, %l5
	sra %l5, 3, %l5
	add %l2, %l0, %l2
	sethi 976, %l6
	st %l5, [%l1]
	or %l6, 577, %l5
	subcc %l2, %l5, %l5
	bl .LBB1_2
	nop
! BB#3:                                 ! %L3499
                                        !   in Loop: Header=BB1_1 Depth=1
	add %l4, -1, %l4
	subcc %l4, 0, %l5
	bne .LBB1_1
	nop
! BB#4:                                 ! %L3515
	or %g0, %l3, %o0
	or %g0, %l2, %o1
	call printf
	nop
	sethi 38981, %l0
	or %l0, 256, %o1
	or %g0, %l3, %o0
	call printf
	nop
	sethi 0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp1:
	.size	main, .Ltmp1-main

	.type	.LC1,@object            ! @.LC1
	.section	.rodata.str1.1,"aMS",@progbits,1
.LC1:
	.asciz	 "%d\n"
	.size	.LC1, 4

	.type	.LC2,@object            ! @.LC2
.LC2:
	.asciz	 "%d"
	.size	.LC2, 3


