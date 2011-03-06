	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmp6E39.tmp"
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
.LBB0_1:                                ! %L3278.i
                                        ! =>This Inner Loop Header: Depth=1
	srl %l0, 31, %l1
	sethi %hi(.LC0), %l2
	add %l0, %l1, %l1
	and %l1, -2, %l3
	add %l2, %lo(.LC0), %o0
	or %g0, %l0, %o1
	call printf
	nop
	sub %l0, %l3, %l2
	subcc %l2, 1, %l2
	bne .LBB0_3
	nop
! BB#2:                                 ! %L3294.i
                                        !   in Loop: Header=BB0_1 Depth=1
	smul %l0, 3, %l0
	add %l0, 1, %l0
	ba .LBB0_4
	nop
.LBB0_3:                                ! %L3307.i
                                        !   in Loop: Header=BB0_1 Depth=1
	sra %l1, 1, %l0
.LBB0_4:                                ! %L3320.i
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l0, 1, %l1
	bg .LBB0_1
	nop
! BB#5:                                 ! %hailstone.exit
	sethi %hi(.LC1), %l1
	add %l1, %lo(.LC1), %o0
	or %g0, %l0, %o1
	call printf
	nop
	sethi 0, %i0
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


