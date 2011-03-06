	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmpB207.tmp"
	.text
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
	ld [%fp+-4], %l0
	or %g0, 2, %o0
	or %g0, 4, %o1
	call calloc
	nop
	smul %l2, %l2, %l1
	sethi 0, %l3
	st %l1, [%o0]
	st %l3, [%o0+4]
	add %l0, -1, %l0
	subcc %l0, 0, %l4
	bg .LBB0_2
	nop
! BB#1:                                 ! %calcMean.exit.thread7
	sethi %hi(.LC1), %l0
	add %l0, %lo(.LC1), %o0
	sethi 0, %o1
	call printf
	nop
	ba .LBB0_13
	nop
.LBB0_2:                                ! %bb.nph.i
	srl %l2, 31, %l4
	add %l2, %l4, %l4
	sra %l4, 1, %l4
.LBB0_3:                                ! %L8193.i
                                        ! =>This Inner Loop Header: Depth=1
	or %g0, %o0, %l5
	smul %l1, %l1, %l1
	sra %l1, 31, %l6
	wr %l6, %g0, %y
	sdiv %l1, %l2, %l1
	smul %l1, %l4, %l1
	or %g0, 2, %o0
	or %g0, 4, %o1
	call calloc
	nop
	add %l1, 1, %l1
	add %l0, -1, %l0
	st %l1, [%o0]
	st %l5, [%o0+4]
	subcc %l0, 0, %l6
	bne .LBB0_3
	nop
! BB#4:                                 ! %getRands.exit
	subcc %o0, 0, %l0
	be .LBB0_6
	nop
! BB#5:                                 ! %getRands.exit.L8289.i_crit_edge
	sethi 0, %l0
	or %g0, 1, %l1
	or %g0, %o0, %l2
	ba .LBB0_7
	nop
.LBB0_6:                                ! %calcMean.exit.thread
	sethi %hi(.LC1), %l0
	sethi 0, %l1
	add %l0, %lo(.LC1), %l0
	or %g0, %o0, %l2
	or %g0, %l0, %o0
	or %g0, %l1, %o1
	call printf
	nop
	or %g0, %l1, %o1
	ba .LBB0_23
	nop
.LBB0_7:                                ! %L8289.i
                                        ! =>This Inner Loop Header: Depth=1
	or %g0, %l5, %l4
	ld [%l2], %l2
	add %l2, %l0, %l0
	subcc %l4, 0, %l2
	be .LBB0_9
	nop
! BB#8:                                 ! %L8289.i.L8289.i_crit_edge
                                        !   in Loop: Header=BB0_7 Depth=1
	ld [%l4+4], %l5
	add %l1, 1, %l1
	or %g0, %l4, %l2
	ba .LBB0_7
	nop
.LBB0_9:                                ! %L8323.i
	subcc %l1, 0, %l2
	bne .LBB0_11
	nop
! BB#10:                                ! %L8323.i.calcMean.exit_crit_edge
	sethi 0, %o1
	ba .LBB0_12
	nop
.LBB0_11:                               ! %L8329.i
	sra %l0, 31, %l2
	wr %l2, %g0, %y
	sdiv %l0, %l1, %o1
.LBB0_12:                               ! %calcMean.exit
	sethi %hi(.LC1), %l1
	add %l1, %lo(.LC1), %l1
	or %g0, %o0, %l2
	or %g0, %l1, %o0
	call printf
	nop
.LBB0_13:                               ! %L8474.i.preheader
	or %g0, 1, %l0
	or %g0, %l2, %l4
	or %g0, %l3, %l1
.LBB0_14:                               ! %L8474.i
                                        ! =>This Inner Loop Header: Depth=1
	ld [%l4], %l5
	subcc %l0, 1, %l6
	bne .LBB0_16
	nop
! BB#15:                                ! %L8474.i.L8544.i_crit_edge
                                        !   in Loop: Header=BB0_14 Depth=1
	sethi 0, %l0
	or %g0, %l5, %l1
	or %g0, %l5, %l3
	ba .LBB0_21
	nop
.LBB0_16:                               ! %L8497.i
                                        !   in Loop: Header=BB0_14 Depth=1
	subcc %l5, %l3, %l6
	bge .LBB0_18
	nop
! BB#17:                                ! %L8497.i.L8544.i_crit_edge
                                        !   in Loop: Header=BB0_14 Depth=1
	or %g0, %l5, %l3
	ba .LBB0_21
	nop
.LBB0_18:                               ! %L8515.i
                                        !   in Loop: Header=BB0_14 Depth=1
	subcc %l5, %l1, %l6
	bg .LBB0_20
	nop
! BB#19:                                ! %L8515.i.L8544.i_crit_edge
                                        !   in Loop: Header=BB0_14 Depth=1
	ba .LBB0_21
	nop
.LBB0_20:                               ! %L8525.i
                                        !   in Loop: Header=BB0_14 Depth=1
	or %g0, %l5, %l1
.LBB0_21:                               ! %L8544.i
                                        !   in Loop: Header=BB0_14 Depth=1
	ld [%l4+4], %l4
	subcc %l4, 0, %l5
	bne .LBB0_14
	nop
! BB#22:                                ! %L8544.i.range.exit_crit_edge
	or %g0, %l3, %o1
.LBB0_23:                               ! %range.exit
	sethi %hi(.LC1), %l0
	add %l0, %lo(.LC1), %l0
	or %g0, %l0, %o0
	call printf
	nop
	or %g0, %l0, %o0
	or %g0, %l1, %o1
	call printf
	nop
	subcc %l2, 0, %l1
	be .LBB0_29
	nop
.LBB0_24:                               ! %L8426.i
                                        ! =>This Loop Header: Depth=1
                                        !     Child Loop BB0_27 Depth 2
	ld [%l2], %l1
	subcc %l1, 0, %l3
	bg .LBB0_26
	nop
! BB#25:                                ! %L8426.i.approxSqrt.exit.i_crit_edge
                                        !   in Loop: Header=BB0_24 Depth=1
	or %g0, 1, %o1
	ba .LBB0_28
	nop
.LBB0_26:                               ! %L8426.i.L8376.i.i_crit_edge
                                        !   in Loop: Header=BB0_24 Depth=1
	sethi 0, %o1
.LBB0_27:                               ! %L8376.i.i
                                        !   Parent Loop BB0_24 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	add %o1, 1, %o1
	smul %o1, %o1, %l3
	subcc %l3, %l1, %l3
	bl .LBB0_27
	nop
.LBB0_28:                               ! %approxSqrt.exit.i
                                        !   in Loop: Header=BB0_24 Depth=1
	or %g0, %l0, %o0
	call printf
	nop
	ld [%l2+4], %l2
	subcc %l2, 0, %l1
	bne .LBB0_24
	nop
.LBB0_29:                               ! %approxSqrtAll.exit
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


