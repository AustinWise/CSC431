	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmpFF35.tmp"
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
	ld [%fp+-4], %o1
	sethi 9, %l0
	or %l0, 783, %l1
	subcc %o1, %l1, %l1
	bg .LBB0_2
	nop
.LBB0_1:                                ! %L6683
                                        ! =>This Inner Loop Header: Depth=1
	or %g0, 4, %l1
	sra %l1, 31, %l2
	wr %l2, %g0, %y
	sdiv %l1, %o1, %l1
	sethi %hi(.LC1), %l1
	add %o1, 1, %l2
	add %l1, %lo(.LC1), %o0
	movg %icc, 3, %o1
	call printf
	nop
	or %l0, 784, %l1
	subcc %l2, %l1, %l1
	or %g0, %l2, %o1
	bne .LBB0_1
	nop
.LBB0_2:                                ! %L6711
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


