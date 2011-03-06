	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmpB017.tmp"
	.text
	.align	4
	.type	recurseList,@function
recurseList:                            ! @recurseList
! BB#0:
	save %sp, -96, %sp
	ld [%i0], %l0
	ld [%i0+4], %o0
	subcc %o0, 0, %l1
	bne .LBB0_2
	nop
! BB#1:                                 ! %L2742
	or %g0, %l0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.LBB0_2:                                ! %L2749
	call recurseList
	nop
	smul %o0, %l0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp0:
	.size	recurseList, .Ltmp0-recurseList

	.globl	main
	.align	4
	.type	main,@function
main:                                   ! @main
! BB#0:
	save %sp, -104, %sp
	or %g0, 2, %l0
	or %g0, 4, %l1
	or %g0, %l0, %o0
	or %g0, %l1, %o1
	call calloc
	nop
	or %g0, %o0, %l2
	or %g0, %l0, %o0
	or %g0, %l1, %o1
	call calloc
	nop
	or %g0, %o0, %l3
	or %g0, %l0, %o0
	or %g0, %l1, %o1
	call calloc
	nop
	or %g0, %o0, %l4
	or %g0, %l0, %o0
	or %g0, %l1, %o1
	call calloc
	nop
	or %g0, %o0, %l5
	or %g0, %l0, %o0
	or %g0, %l1, %o1
	call calloc
	nop
	or %g0, %o0, %l6
	or %g0, %l0, %o0
	or %g0, %l1, %o1
	call calloc
	nop
	or %g0, %o0, %l0
	sethi %hi(.LC2), %l1
	add %l1, %lo(.LC2), %l1
	add %fp, -4, %l7
	or %g0, %l1, %o0
	or %g0, %l7, %o1
	call scanf
	nop
	ld [%fp+-4], %i0
	st %i0, [%l2]
	or %g0, %l1, %o0
	or %g0, %l7, %o1
	call scanf
	nop
	ld [%fp+-4], %i0
	st %i0, [%l3]
	or %g0, %l1, %o0
	or %g0, %l7, %o1
	call scanf
	nop
	ld [%fp+-4], %i0
	st %i0, [%l4]
	or %g0, %l1, %o0
	or %g0, %l7, %o1
	call scanf
	nop
	ld [%fp+-4], %i0
	st %i0, [%l5]
	or %g0, %l1, %o0
	or %g0, %l7, %o1
	call scanf
	nop
	ld [%fp+-4], %i0
	st %i0, [%l6]
	or %g0, %l1, %o0
	or %g0, %l7, %o1
	call scanf
	nop
	ld [%fp+-4], %l1
	st %l1, [%l0]
	st %l3, [%l2+4]
	st %l4, [%l3+4]
	st %l5, [%l4+4]
	st %l6, [%l5+4]
	sethi 0, %l1
	st %l0, [%l6+4]
	st %l1, [%l0+4]
	ld [%l2], %l0
	or %g0, 5, %l1
	or %g0, %l0, %l5
	or %g0, %l3, %l6
.LBB1_1:                                ! %L2610.i
                                        ! =>This Inner Loop Header: Depth=1
	or %g0, %l4, %l7
	sethi %hi(.LC1), %l4
	ld [%l6], %l6
	smul %l6, %l5, %l5
	add %l1, -1, %l1
	add %l4, %lo(.LC1), %l4
	or %g0, %l4, %o0
	or %g0, %l5, %o1
	call printf
	nop
	subcc %l1, 0, %l6
	bne .LBB1_3
	nop
! BB#2:                                 ! %L2610.i.L2686.i_crit_edge
	or %g0, 5, %l1
	ba .LBB1_4
	nop
.LBB1_3:                                ! %L2610.i.L2610.i_crit_edge
                                        !   in Loop: Header=BB1_1 Depth=1
	ld [%l7+4], %l4
	or %g0, %l7, %l6
	ba .LBB1_1
	nop
.LBB1_4:                                ! %L2686.i
                                        ! =>This Inner Loop Header: Depth=1
	ld [%l3+4], %l6
	ld [%l3], %l3
	add %l3, %l0, %l0
	add %l1, -1, %l1
	or %g0, %l4, %o0
	or %g0, %l0, %o1
	call printf
	nop
	subcc %l1, 0, %l3
	or %g0, %l6, %l3
	bne .LBB1_4
	nop
! BB#5:                                 ! %L2845
	sethi 9, %l1
	or %g0, %l2, %o0
	call recurseList
	nop
	or %l1, 784, %l1
	srl %l0, 31, %l2
	add %l0, %l2, %l0
	smul %o0, %l1, %o1
	or %g0, %l4, %o0
	call printf
	nop
	sra %l0, 1, %l0
	sub %l5, %l0, %o1
	or %g0, %l4, %o0
	call printf
	nop
	sethi 0, %i0
	or %g0, %l4, %o0
	or %g0, %i0, %o1
	call printf
	nop
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


