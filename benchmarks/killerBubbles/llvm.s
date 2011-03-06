	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmpB0E8.tmp"
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
! BB#1:                                 ! %L4353
	sethi %hi(.LC1), %l0
	add %l0, %lo(.LC1), %o0
	or %g0, -1, %i0
	or %g0, %i0, %o1
	call printf
	nop
	restore %g0, %g0, %g0
	retl
	nop
.LBB0_2:                                ! %L4368
	or %g0, 3, %o0
	or %g0, 4, %o1
	call calloc
	nop
	smul %l0, 1000, %l0
	st %l0, [%o0]
	st %o0, [%o0+4]
	or %g0, %o0, %l1
	st %o0, [%o0+8]
	add %l0, -1, %l0
	subcc %l0, 1, %l2
	bl .LBB0_7
	nop
! BB#3:                                 ! %L4422.preheader
	or %g0, %l1, %l2
.LBB0_4:                                ! %L4422
                                        ! =>This Inner Loop Header: Depth=1
	or %g0, 3, %o0
	or %g0, 4, %o1
	call calloc
	nop
	st %l0, [%o0]
	st %l2, [%o0+4]
	st %l1, [%o0+8]
	add %l0, -1, %l0
	st %o0, [%l2+8]
	subcc %l0, 0, %l2
	or %g0, %o0, %l2
	be .LBB0_7
	nop
	ba .LBB0_4
	nop
.LBB0_5:                                ! %L4180.loopexit.i
                                        !   in Loop: Header=BB0_7 Depth=1
	subcc %l0, 1, %l0
	be .LBB0_7
	nop
! BB#6:                                 ! %L4180.loopexit.i.deathSort.exit_crit_edge
	ld [%l1+8], %l2
	ba .LBB0_14
	nop
.LBB0_7:                                ! %L4197.preheader.i
                                        ! =>This Loop Header: Depth=1
                                        !     Child Loop BB0_10 Depth 2
	ld [%l1+8], %l2
	subcc %l2, %l1, %l0
	be .LBB0_9
	nop
! BB#8:                                 ! %L4197.preheader.i.L4205.i_crit_edge
                                        !   in Loop: Header=BB0_7 Depth=1
	sethi 0, %l0
	or %g0, %l1, %l3
	ba .LBB0_10
	nop
.LBB0_9:                                ! %L4197.preheader.i.deathSort.exit_crit_edge
	ba .LBB0_14
	nop
.LBB0_10:                               ! %L4205.i
                                        !   Parent Loop BB0_7 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	ld [%l3], %l4
	ld [%l2], %l5
	sub %l4, %l5, %l6
	subcc %l6, 0, %l6
	bg .LBB0_12
	nop
! BB#11:                                ! %L4205.i.L4251.i_crit_edge
                                        !   in Loop: Header=BB0_10 Depth=2
	or %g0, %l2, %l3
	ba .LBB0_13
	nop
.LBB0_12:                               ! %L4219.i
                                        !   in Loop: Header=BB0_10 Depth=2
	st %l5, [%l3]
	ld [%l3+8], %l0
	st %l4, [%l0]
	ld [%l3+8], %l3
	or %g0, 1, %l0
.LBB0_13:                               ! %L4251.i
                                        !   in Loop: Header=BB0_10 Depth=2
	ld [%l3+8], %l2
	subcc %l2, %l1, %l4
	be .LBB0_5
	nop
	ba .LBB0_10
	nop
.LBB0_14:                               ! %deathSort.exit
	sethi %hi(.LC1), %l0
	ld [%l1], %o1
	add %l0, %lo(.LC1), %l0
	or %g0, %l0, %o0
	call printf
	nop
	or %g0, %l1, %o0
	call free
	nop
	subcc %l2, %l1, %l3
	be .LBB0_16
	nop
.LBB0_15:                               ! %L4304.i
                                        ! =>This Inner Loop Header: Depth=1
	ld [%l2], %o1
	or %g0, %l0, %o0
	call printf
	nop
	ld [%l2+8], %l3
	or %g0, %l2, %o0
	call free
	nop
	subcc %l3, %l1, %l2
	or %g0, %l3, %l2
	bne .LBB0_15
	nop
.LBB0_16:                               ! %printEVILList.exit
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


