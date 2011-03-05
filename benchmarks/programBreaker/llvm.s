	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmpE50F.tmp"
	.text
	.globl	fun2
	.align	4
	.type	fun2,@function
fun2:                                   ! @fun2
! BB#0:
	save %sp, -96, %sp
	or %g0, %i1, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp0:
	.size	fun2, .Ltmp0-fun2

	.globl	fun1
	.align	4
	.type	fun1,@function
fun1:                                   ! @fun1
! BB#0:                                 ! %L6616
	save %sp, -96, %sp
	or %g0, 4, %l0
	sra %l0, 31, %l1
	wr %l1, %g0, %y
	sdiv %l0, %i1, %l0
	movg %icc, %i0, %i1
	or %g0, %i1, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp1:
	.size	fun1, .Ltmp1-fun1

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
	bg .LBB2_2
	nop
.LBB2_1:                                ! %L6683
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
	bne .LBB2_1
	nop
.LBB2_2:                                ! %L6711
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


