	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmpB138.tmp"
	.text
	.align	4
	.type	ackermann,@function
ackermann:                              ! @ackermann
! BB#0:
	save %sp, -96, %sp
	subcc %i0, 0, %l0
	be .LBB0_2
	nop
! BB#1:                                 ! %.L5072_crit_edge
	or %g0, %i1, %o0
	ba .LBB0_3
	nop
.LBB0_2:                                ! %L5058
	add %i1, 1, %i0
	restore %g0, %g0, %g0
	retl
	nop
.LBB0_3:                                ! %L5072
                                        ! =>This Inner Loop Header: Depth=1
	subcc %o0, 0, %l0
	bne .LBB0_5
	nop
! BB#4:                                 ! %L5072.tailrecurse.backedge_crit_edge
                                        !   in Loop: Header=BB0_3 Depth=1
	or %g0, 1, %o0
	ba .LBB0_6
	nop
.LBB0_5:                                ! %L5091
                                        !   in Loop: Header=BB0_3 Depth=1
	add %o0, -1, %o1
	or %g0, %i0, %o0
	call ackermann
	nop
.LBB0_6:                                ! %tailrecurse.backedge
                                        !   in Loop: Header=BB0_3 Depth=1
	add %i0, -1, %i0
	subcc %i0, 0, %l0
	bne .LBB0_3
	nop
! BB#7:                                 ! %tailrecurse.backedge.L5058_crit_edge
	or %g0, %o0, %i1
	ba .LBB0_2
	nop
.Ltmp0:
	.size	ackermann, .Ltmp0-ackermann

	.globl	main
	.align	4
	.type	main,@function
main:                                   ! @main
! BB#0:
	save %sp, -104, %sp
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
	ld [%fp+-4], %l3
	or %g0, %l0, %o0
	or %g0, %l1, %o1
	call scanf
	nop
	ld [%fp+-4], %l4
	or %g0, %l0, %o0
	or %g0, %l1, %o1
	call scanf
	nop
	ld [%fp+-4], %l5
	or %g0, %l0, %o0
	or %g0, %l1, %o1
	call scanf
	nop
	ld [%fp+-4], %l0
	subcc %l2, 1, %l1
	bl .LBB1_3
	nop
! BB#1:                                 ! %.L4843.i_crit_edge
	or %g0, %l2, %l1
.LBB1_2:                                ! %L4843.i
                                        ! =>This Inner Loop Header: Depth=1
	add %l1, -1, %l1
	or %g0, 3, %o0
	or %g0, 4, %o1
	call calloc
	nop
	subcc %l1, 0, %l6
	bne .LBB1_2
	nop
.LBB1_3:                                ! %tailrecursive.exit
	sethi %hi(.LC1), %l1
	add %l1, %lo(.LC1), %l1
	or %g0, %l1, %o0
	or %g0, %l2, %o1
	call printf
	nop
	or %g0, 3, %l2
	or %g0, 4, %l6
	or %g0, %l2, %o0
	or %g0, %l6, %o1
	call calloc
	nop
	or %g0, %o0, %l7
	or %g0, 1, %i0
	or %g0, %i0, %o0
	or %g0, %l6, %o1
	call calloc
	nop
	st %o0, [%l7+8]
	or %g0, %l2, %o0
	or %g0, %l6, %o1
	call calloc
	nop
	or %g0, %o0, %i1
	or %g0, %i0, %o0
	or %g0, %l6, %o1
	call calloc
	nop
	st %o0, [%i1+8]
	st %l3, [%l7]
	st %l2, [%i1]
	ld [%l7+8], %l6
	st %l3, [%l6]
	ld [%i1+8], %l6
	st %l2, [%l6]
	or %g0, %l7, %o0
	call free
	nop
	or %g0, %i1, %o0
	call free
	nop
	or %g0, %l1, %o0
	or %g0, %l3, %o1
	call printf
	nop
	subcc %l4, 1, %l2
	bl .LBB1_6
	nop
! BB#4:                                 ! %tailrecursive.exit.L5018.i_crit_edge
	or %g0, %l4, %l2
.LBB1_5:                                ! %L5018.i
                                        ! =>This Inner Loop Header: Depth=1
	or %g0, 3, %o0
	or %g0, 4, %o1
	call calloc
	nop
	add %l2, -1, %l2
	call free
	nop
	subcc %l2, 0, %l3
	bne .LBB1_5
	nop
.LBB1_6:                                ! %objinstantiation.exit
	or %g0, %l1, %o0
	or %g0, %l4, %o1
	call printf
	nop
	or %g0, %l5, %o0
	or %g0, %l0, %o1
	call ackermann
	nop
	or %g0, %o0, %o1
	or %g0, %l1, %o0
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


