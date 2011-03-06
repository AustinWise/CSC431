	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmpB1C7.tmp"
	.text
	.align	4
	.type	recursiveFibonacci,@function
recursiveFibonacci:                     ! @recursiveFibonacci
! BB#0:
	save %sp, -96, %sp
	subcc %i0, 1, %l0
	bg .LBB0_2
	nop
! BB#1:                                 ! %L7212
	restore %g0, %g0, %g0
	retl
	nop
.LBB0_2:                                ! %L7218
	add %i0, -1, %o0
	call recursiveFibonacci
	nop
	or %g0, %o0, %l0
	add %i0, -2, %o0
	call recursiveFibonacci
	nop
	add %o0, %l0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp0:
	.size	recursiveFibonacci, .Ltmp0-recursiveFibonacci

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
	subcc %l0, 2, %l1
	bl .LBB1_9
	nop
! BB#1:                                 ! %bb.nph
	rd %y, %l1
	sra %l1, 6, %l2
	srl %l1, 31, %l1
	add %l2, %l1, %o0
	add %o0, -1, %l1
	add %o0, -2, %l2
	smul %l1, %l2, %l3
	umul %l1, %l2, %l2
	rd %y, %l2
	smul %l1, %l1, %l1
	srl %l3, 1, %l3
	sll %l2, 31, %l2
	rd %y, %l4
	add %l1, %o0, %l1
	or %l3, %l2, %l2
	sra %l4, 1, %l3
	srl %l4, 31, %l4
	sub %l1, %l2, %l1
	add %l3, %l4, %l2
	movcs %icc, 0, %l1
	or %g0, 1, %l3
	call recursiveFibonacci
	nop
	or %g0, %o0, %l4
.LBB1_2:                                ! %L7260
                                        ! =>This Loop Header: Depth=1
                                        !     Child Loop BB1_7 Depth 2
                                        !     Child Loop BB1_3 Depth 2
	sethi %hi(.LC1), %l5
	or %g0, 226, %o1
	add %l5, %lo(.LC1), %l5
	or %g0, %l5, %o0
	call printf
	nop
	sethi 956489, %l6
	or %l6, 775, %o1
	or %g0, %l5, %o0
	call printf
	nop
	or %g0, 38, %o1
	or %g0, %l5, %o0
	call printf
	nop
	sethi 48833, %l6
	or %l6, 8, %o1
	or %g0, %l5, %o0
	call printf
	nop
	sethi 4194256, %l6
	or %l6, 356, %o1
	or %g0, %l5, %o0
	call printf
	nop
	or %g0, 2, %o1
	or %g0, %l5, %o0
	call printf
	nop
	or %g0, 50, %o1
	or %g0, %l5, %o0
	call printf
	nop
	or %g0, 736, %o1
	or %g0, %l5, %o0
	call printf
	nop
	or %g0, 10, %o1
	or %g0, %l5, %o0
	call printf
	nop
	or %g0, %l5, %o0
	or %g0, %l1, %o1
	call printf
	nop
	sethi 976, %l6
	sethi 0, %l7
	or %l6, 576, %o1
	or %g0, %l5, %o0
	call printf
	nop
	or %g0, %l7, %l6
.LBB1_3:                                ! %L7013.i
                                        !   Parent Loop BB1_2 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	sll %l6, 1, %l6
	sra %l6, 1, %l6
	smul %l6, 3, %l6
	rd %y, %i0
	add %i0, %l6, %l6
	srl %l6, 1, %i0
	srl %l6, 31, %l6
	add %i0, %l6, %l6
	sll %l6, 2, %l6
	sra %l6, 2, %l6
	add %l7, 19, %l7
	add %l6, 1, %l6
	subcc %l6, %l0, %i0
	bl .LBB1_3
	nop
! BB#4:                                 ! %randomCalculation.exit
                                        !   in Loop: Header=BB1_2 Depth=1
	or %g0, %l5, %o0
	or %g0, %l7, %o1
	call printf
	nop
	subcc %l0, 4, %l6
	bg .LBB1_6
	nop
! BB#5:                                 ! %randomCalculation.exit.iterativeFibonacci.exit_crit_edge
                                        !   in Loop: Header=BB1_2 Depth=1
	or %g0, 1, %o1
	ba .LBB1_8
	nop
.LBB1_6:                                ! %randomCalculation.exit.L7150.i_crit_edge
                                        !   in Loop: Header=BB1_2 Depth=1
	or %g0, 1, %o1
	or %g0, -1, %l6
	or %g0, %l2, %l7
.LBB1_7:                                ! %L7150.i
                                        !   Parent Loop BB1_2 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	or %g0, %o1, %i0
	add %l6, %i0, %o1
	add %l7, -1, %l7
	subcc %l7, 0, %l6
	or %g0, %i0, %l6
	bne .LBB1_7
	nop
.LBB1_8:                                ! %iterativeFibonacci.exit
                                        !   in Loop: Header=BB1_2 Depth=1
	or %g0, %l5, %o0
	call printf
	nop
	add %l3, 1, %l3
	or %g0, %l5, %o0
	or %g0, %l4, %o1
	call printf
	nop
	subcc %l0, %l3, %l5
	bne .LBB1_2
	nop
.LBB1_9:                                ! %L7412
	sethi %hi(.LC1), %l0
	sethi 9, %l1
	add %l0, %lo(.LC1), %o0
	or %l1, 783, %o1
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


