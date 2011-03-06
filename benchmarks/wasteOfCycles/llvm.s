	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmp6FD8.tmp"
	.text
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
	subcc %l0, 1, %l1
	bl .LBB0_6
	nop
! BB#1:                                 ! %bb.nph6.i
	or %g0, 1, %l1
	sll %l0, 1, %l2
	sethi 0, %l3
	smul %l0, %l0, %l4
	sub %l1, %l2, %l1
	or %g0, %l0, %l2
	or %g0, %l3, %l5
	or %g0, %l3, %l6
.LBB0_2:                                ! %L10359.preheader.i
                                        ! =>This Loop Header: Depth=1
                                        !     Child Loop BB0_4 Depth 2
	smul %l2, %l2, %l7
	subcc %l7, 1, %l7
	bl .LBB0_5
	nop
! BB#3:                                 ! %bb.nph.i
                                        !   in Loop: Header=BB0_2 Depth=1
	add %l6, -1, %l7
	smul %l7, %l6, %l7
	and %l7, -2, %l7
	add %l4, %l7, %l7
	or %g0, %l2, %o1
.LBB0_4:                                ! %L10370.i
                                        !   Parent Loop BB0_2 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	sethi %hi(.LC0), %i0
	add %o1, 1, %i1
	add %l7, -1, %l7
	add %i0, %lo(.LC0), %o0
	call printf
	nop
	subcc %l7, 0, %i0
	or %g0, %i1, %o1
	bne .LBB0_4
	nop
.LBB0_5:                                ! %L10406.i
                                        !   in Loop: Header=BB0_2 Depth=1
	addcc %l6, 1, %l6
	addx %l5, 0, %l5
	add %l4, %l1, %l4
	add %l2, -1, %l2
	xor %l3, %l5, %l7
	xor %l0, %l6, %i0
	and %l7, 1, %l7
	or %i0, %l7, %l7
	subcc %l7, 0, %l7
	bne .LBB0_2
	nop
.LBB0_6:                                ! %function.exit
	sethi %hi(.LC1), %l0
	add %l0, %lo(.LC1), %o0
	sethi 0, %i0
	or %g0, %i0, %o1
	call printf
	nop
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp0:
	.size	main, .Ltmp0-main

	.type	.LC0,@object            ! @.LC0
	.section	.rodata.str1.1,"aMS",@progbits,1
.LC0:
	.asciz	 "%d "
	.size	.LC0, 4

	.type	.LC1,@object            ! @.LC1
.LC1:
	.asciz	 "%d\n"
	.size	.LC1, 4

	.type	.LC2,@object            ! @.LC2
.LC2:
	.asciz	 "%d"
	.size	.LC2, 3


