	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmpAF77.tmp"
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
	subcc %l0, 0, %l1
	bg .LBB0_2
	nop
! BB#1:                                 ! %.length.exit_crit_edge
	sethi 0, %o1
	or %g0, %o1, %l1
	ba .LBB0_12
	nop
.LBB0_2:                                ! %.L207_crit_edge
	or %g0, 1, %l2
	sethi 0, %l3
	sethi 0, %l4
.LBB0_3:                                ! %L207
                                        ! =>This Inner Loop Header: Depth=1
	or %g0, 2, %o0
	or %g0, 4, %o1
	call calloc
	nop
	or %g0, %o0, %l1
	st %l0, [%o0]
	and %l2, 1, %l2
	subcc %l2, 0, %l2
	be .LBB0_5
	nop
! BB#4:                                 ! %L207.addToFront.exit_crit_edge
                                        !   in Loop: Header=BB0_3 Depth=1
	or %g0, %l0, %o1
	ba .LBB0_6
	nop
.LBB0_5:                                ! %L123.i
                                        !   in Loop: Header=BB0_3 Depth=1
	st %l3, [%l1+4]
	ld [%l1], %o1
.LBB0_6:                                ! %addToFront.exit
                                        !   in Loop: Header=BB0_3 Depth=1
	sethi %hi(.LC0), %l3
	or %g0, %l4, %l2
	move %icc, 1, %l2
	add %l0, -1, %l0
	add %l3, %lo(.LC0), %o0
	call printf
	nop
	subcc %l0, 0, %l3
	or %g0, %l1, %l3
	bne .LBB0_3
	nop
! BB#7:                                 ! %L240
	subcc %l1, 0, %l0
	be .LBB0_9
	nop
! BB#8:                                 ! %L240.L21.i_crit_edge
	or %g0, %l1, %l0
	ba .LBB0_10
	nop
.LBB0_9:                                ! %L240.length.exit_crit_edge
	sethi 0, %o1
	ba .LBB0_12
	nop
.LBB0_10:                               ! %L21.i
                                        ! =>This Inner Loop Header: Depth=1
	add %l4, 1, %l4
	ld [%l0+4], %l0
	subcc %l0, 0, %l2
	bne .LBB0_10
	nop
! BB#11:                                ! %L21.i.length.exit_crit_edge
	or %g0, %l4, %o1
.LBB0_12:                               ! %length.exit
	sethi %hi(.LC0), %l0
	sethi 0, %l2
	add %l0, %lo(.LC0), %l0
	or %g0, %l0, %o0
	call printf
	nop
.LBB0_13:                               ! %L387
                                        ! =>This Loop Header: Depth=1
                                        !     Child Loop BB0_18 Depth 2
                                        !     Child Loop BB0_15 Depth 2
	subcc %l1, 0, %l3
	be .LBB0_20
	nop
! BB#14:                                ! %L387.L21.i10_crit_edge
                                        !   in Loop: Header=BB0_13 Depth=1
	sethi 0, %l3
	or %g0, %l1, %l4
.LBB0_15:                               ! %L21.i10
                                        !   Parent Loop BB0_13 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	add %l3, 1, %l3
	ld [%l4+4], %l4
	subcc %l4, 0, %l5
	bne .LBB0_15
	nop
! BB#16:                                ! %length.exit11
                                        !   in Loop: Header=BB0_13 Depth=1
	subcc %l3, 1, %l3
	bl .LBB0_20
	nop
! BB#17:                                ! %L21.i19.preheader
                                        !   in Loop: Header=BB0_13 Depth=1
	ld [%l1], %l3
	add %l3, %l2, %l2
	sethi 0, %o1
	or %g0, %l1, %l3
.LBB0_18:                               ! %L21.i19
                                        !   Parent Loop BB0_13 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	add %o1, 1, %o1
	ld [%l3+4], %l3
	subcc %l3, 0, %l4
	bne .LBB0_18
	nop
! BB#19:                                ! %L387.backedge
                                        !   in Loop: Header=BB0_13 Depth=1
	or %g0, %l0, %o0
	call printf
	nop
	ld [%l1+4], %l3
	or %g0, %l1, %o0
	call free
	nop
	or %g0, %l3, %l1
	ba .LBB0_13
	nop
.LBB0_20:                               ! %L430
	sethi %hi(.LC1), %l0
	add %l0, %lo(.LC1), %o0
	or %g0, %l2, %o1
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


