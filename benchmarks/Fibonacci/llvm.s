	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmp6E19.tmp"
	.text
	.align	4
	.type	computeFib,@function
computeFib:                             ! @computeFib
! BB#0:
	save %sp, -96, %sp
	subcc %i0, 0, %l0
	bne .LBB0_2
	nop
! BB#1:                                 ! %L3152
	sethi 0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.LBB0_2:                                ! %L3157
	subcc %i0, 2, %l0
	bg .LBB0_4
	nop
! BB#3:                                 ! %L3165
	or %g0, 1, %i0
	restore %g0, %g0, %g0
	retl
	nop
.LBB0_4:                                ! %L3170
	add %i0, -1, %o0
	call computeFib
	nop
	or %g0, %o0, %l0
	add %i0, -2, %o0
	call computeFib
	nop
	add %o0, %l0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp0:
	.size	computeFib, .Ltmp0-computeFib

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
	ld [%fp+-4], %o0
	sethi %hi(.LC1), %l0
	call computeFib
	nop
	or %g0, %o0, %o1
	add %l0, %lo(.LC1), %o0
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


