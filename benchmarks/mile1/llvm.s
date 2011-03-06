	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmp6EBA.tmp"
	.text
	.globl	main
	.align	4
	.type	main,@function
main:                                   ! @main
! BB#0:
	save %sp, -104, %sp
	or %g0, 2, %o0
	or %g0, 4, %o1
	call calloc
	nop
	or %g0, %o0, %l0
	sethi %hi(.LC2), %l1
	add %l1, %lo(.LC2), %l1
	add %fp, -4, %l2
	or %g0, %l1, %o0
	or %g0, %l2, %o1
	call scanf
	nop
	ld [%fp+-4], %l3
	st %l3, [%l0]
	or %g0, %l1, %o0
	or %g0, %l2, %o1
	call scanf
	nop
	ld [%fp+-4], %l1
	subcc %l1, -1, %l2
	bg .LBB0_2
	nop
! BB#1:                                 ! %L4723
	or %g0, -1, %i0
	restore %g0, %g0, %g0
	retl
	nop
.LBB0_2:                                ! %bb.nph
	st %l1, [%l0+4]
	subcc %l1, 0, %l2
	bg .LBB0_4
	nop
! BB#3:                                 ! %bb.nph.L4780_crit_edge
	or %g0, 1, %o1
	ba .LBB0_8
	nop
.LBB0_4:                                ! %bb.nph.L4666.i.preheader.us_crit_edge
	ld [%l0], %l0
	sethi 976, %l2
	or %l2, 576, %l2
	ba .LBB0_6
	nop
.LBB0_5:                                ! %L4666.i.us
                                        !   Parent Loop BB0_6 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	smul %o1, %l0, %o1
	add %l3, -1, %l3
	subcc %l3, 0, %l4
	be .LBB0_7
	nop
	ba .LBB0_5
	nop
.LBB0_6:                                ! %L4666.i.preheader.us
                                        ! =>This Loop Header: Depth=1
                                        !     Child Loop BB0_5 Depth 2
	or %g0, 1, %o1
	or %g0, %l1, %l3
	ba .LBB0_5
	nop
.LBB0_7:                                ! %L4744.backedge.us
                                        !   in Loop: Header=BB0_6 Depth=1
	add %l2, -1, %l2
	subcc %l2, 0, %l3
	bne .LBB0_6
	nop
.LBB0_8:                                ! %L4780
	sethi %hi(.LC1), %l0
	add %l0, %lo(.LC1), %o0
	call printf
	nop
	or %g0, 1, %i0
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


