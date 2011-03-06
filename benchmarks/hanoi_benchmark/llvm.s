	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmpB0E7.tmp"
	.text
	.align	4
	.type	hanoi,@function
hanoi:                                  ! @hanoi
! BB#0:
	save %sp, -96, %sp
	subcc %i0, 1, %l0
	bne .LBB0_12
	nop
.LBB0_1:                                ! %L3881
	subcc %i1, 2, %l0
	be .LBB0_4
	nop
! BB#2:                                 ! %L3881
	subcc %i1, 1, %l0
	bne .LBB0_5
	nop
! BB#3:                                 ! %L3745.i
	sethi %hi(peg1), %l0
	ld [%l0+%lo(peg1)], %l1
	ld [%l1+4], %l2
	st %l2, [%l0+%lo(peg1)]
	ba .LBB0_6
	nop
.LBB0_4:                                ! %L3766.i
	sethi %hi(peg2), %l0
	ld [%l0+%lo(peg2)], %l1
	ld [%l1+4], %l2
	st %l2, [%l0+%lo(peg2)]
	ba .LBB0_6
	nop
.LBB0_5:                                ! %L3779.i
	sethi %hi(peg3), %l0
	ld [%l0+%lo(peg3)], %l1
	ld [%l1+4], %l2
	st %l2, [%l0+%lo(peg3)]
.LBB0_6:                                ! %L3798.i
	subcc %i2, 2, %l0
	be .LBB0_9
	nop
! BB#7:                                 ! %L3798.i
	subcc %i2, 1, %l0
	bne .LBB0_10
	nop
! BB#8:                                 ! %L3804.i
	sethi %hi(peg1), %l0
	ld [%l0+%lo(peg1)], %l2
	st %l2, [%l1+4]
	st %l1, [%l0+%lo(peg1)]
	ba .LBB0_11
	nop
.LBB0_9:                                ! %L3825.i
	sethi %hi(peg2), %l0
	ld [%l0+%lo(peg2)], %l2
	st %l2, [%l1+4]
	st %l1, [%l0+%lo(peg2)]
	ba .LBB0_11
	nop
.LBB0_10:                               ! %L3838.i
	sethi %hi(peg3), %l0
	ld [%l0+%lo(peg3)], %l2
	st %l2, [%l1+4]
	st %l1, [%l0+%lo(peg3)]
.LBB0_11:                               ! %move.exit
	sethi %hi(numMoves), %l0
	ld [%l0+%lo(numMoves)], %l1
	add %l1, 1, %l1
	st %l1, [%l0+%lo(numMoves)]
	restore %g0, %g0, %g0
	retl
	nop
.LBB0_12:                               ! %bb.nph
	add %i0, -1, %l0
.LBB0_13:                               ! %L3890
                                        ! =>This Inner Loop Header: Depth=1
	or %g0, %i3, %l1
	or %g0, %i1, %i3
	or %g0, %l0, %o0
	or %g0, %i3, %o1
	or %g0, %l1, %o2
	or %g0, %i2, %o3
	call hanoi
	nop
	subcc %i3, 2, %l2
	be .LBB0_16
	nop
! BB#14:                                ! %L3890
                                        !   in Loop: Header=BB0_13 Depth=1
	subcc %i3, 1, %l2
	bne .LBB0_17
	nop
! BB#15:                                ! %L3745.i4
                                        !   in Loop: Header=BB0_13 Depth=1
	sethi %hi(peg1), %l2
	ld [%l2+%lo(peg1)], %l3
	ld [%l3+4], %l4
	st %l4, [%l2+%lo(peg1)]
	ba .LBB0_18
	nop
.LBB0_16:                               ! %L3766.i8
                                        !   in Loop: Header=BB0_13 Depth=1
	sethi %hi(peg2), %l2
	ld [%l2+%lo(peg2)], %l3
	ld [%l3+4], %l4
	st %l4, [%l2+%lo(peg2)]
	ba .LBB0_18
	nop
.LBB0_17:                               ! %L3779.i12
                                        !   in Loop: Header=BB0_13 Depth=1
	sethi %hi(peg3), %l2
	ld [%l2+%lo(peg3)], %l3
	ld [%l3+4], %l4
	st %l4, [%l2+%lo(peg3)]
.LBB0_18:                               ! %L3798.i14
                                        !   in Loop: Header=BB0_13 Depth=1
	subcc %i2, 2, %l2
	be .LBB0_21
	nop
! BB#19:                                ! %L3798.i14
                                        !   in Loop: Header=BB0_13 Depth=1
	subcc %i2, 1, %l2
	bne .LBB0_22
	nop
! BB#20:                                ! %L3804.i17
                                        !   in Loop: Header=BB0_13 Depth=1
	sethi %hi(peg1), %l2
	ld [%l2+%lo(peg1)], %l4
	st %l4, [%l3+4]
	st %l3, [%l2+%lo(peg1)]
	ba .LBB0_23
	nop
.LBB0_21:                               ! %L3825.i20
                                        !   in Loop: Header=BB0_13 Depth=1
	sethi %hi(peg2), %l2
	ld [%l2+%lo(peg2)], %l4
	st %l4, [%l3+4]
	st %l3, [%l2+%lo(peg2)]
	ba .LBB0_23
	nop
.LBB0_22:                               ! %L3838.i23
                                        !   in Loop: Header=BB0_13 Depth=1
	sethi %hi(peg3), %l2
	ld [%l2+%lo(peg3)], %l4
	st %l4, [%l3+4]
	st %l3, [%l2+%lo(peg3)]
.LBB0_23:                               ! %move.exit26
                                        !   in Loop: Header=BB0_13 Depth=1
	sethi %hi(numMoves), %l2
	ld [%l2+%lo(numMoves)], %l3
	add %l3, 1, %l3
	add %l0, -1, %l0
	st %l3, [%l2+%lo(numMoves)]
	subcc %l0, 0, %l2
	or %g0, %l1, %i1
	bne .LBB0_13
	nop
! BB#24:                                ! %move.exit26.L3881_crit_edge
	or %g0, %l1, %i1
	ba .LBB0_1
	nop
.Ltmp0:
	.size	hanoi, .Ltmp0-hanoi

	.globl	main
	.align	4
	.type	main,@function
main:                                   ! @main
! BB#0:
	save %sp, -104, %sp
	sethi 0, %l0
	sethi %hi(peg1), %l1
	sethi %hi(peg2), %l2
	st %l0, [%l1+%lo(peg1)]
	sethi %hi(peg3), %l3
	st %l0, [%l2+%lo(peg2)]
	sethi %hi(numMoves), %l4
	st %l0, [%l3+%lo(peg3)]
	st %l0, [%l4+%lo(numMoves)]
	sethi %hi(.LC2), %l0
	add %l0, %lo(.LC2), %o0
	add %fp, -4, %o1
	call scanf
	nop
	ld [%fp+-4], %l0
	subcc %l0, 1, %l5
	bl .LBB1_17
	nop
! BB#1:                                 ! %.L4016_crit_edge
	or %g0, %l0, %l5
.LBB1_2:                                ! %L4016
                                        ! =>This Inner Loop Header: Depth=1
	or %g0, 2, %o0
	or %g0, 4, %o1
	call calloc
	nop
	st %l5, [%o0]
	ld [%l1+%lo(peg1)], %l6
	st %l6, [%o0+4]
	add %l5, -1, %l5
	st %o0, [%l1+%lo(peg1)]
	subcc %l5, 0, %l6
	bne .LBB1_2
	nop
! BB#3:                                 ! %L4055
	sethi %hi(.LC1), %l5
	add %l5, %lo(.LC1), %l5
	or %g0, 1, %o1
	or %g0, %l5, %o0
	call printf
	nop
	ld [%l1+%lo(peg1)], %l6
	subcc %l6, 0, %l7
	be .LBB1_5
	nop
.LBB1_4:                                ! %L3952.i
                                        ! =>This Inner Loop Header: Depth=1
	ld [%l6], %o1
	or %g0, %l5, %o0
	call printf
	nop
	ld [%l6+4], %l6
	subcc %l6, 0, %l7
	bne .LBB1_4
	nop
.LBB1_5:                                ! %printPeg.exit
	or %g0, 2, %o1
	or %g0, %l5, %o0
	call printf
	nop
	ld [%l2+%lo(peg2)], %l6
	subcc %l6, 0, %l7
	be .LBB1_7
	nop
.LBB1_6:                                ! %L3952.i8
                                        ! =>This Inner Loop Header: Depth=1
	ld [%l6], %o1
	or %g0, %l5, %o0
	call printf
	nop
	ld [%l6+4], %l6
	subcc %l6, 0, %l7
	bne .LBB1_6
	nop
.LBB1_7:                                ! %printPeg.exit9
	or %g0, 3, %o1
	or %g0, %l5, %o0
	call printf
	nop
	ld [%l3+%lo(peg3)], %l6
	subcc %l6, 0, %l7
	be .LBB1_9
	nop
.LBB1_8:                                ! %L3952.i17
                                        ! =>This Inner Loop Header: Depth=1
	ld [%l6], %o1
	or %g0, %l5, %o0
	call printf
	nop
	ld [%l6+4], %l6
	subcc %l6, 0, %l7
	bne .LBB1_8
	nop
.LBB1_9:                                ! %printPeg.exit18
	or %g0, 3, %o2
	or %g0, 2, %o3
	or %g0, 1, %l6
	or %g0, %l0, %o0
	or %g0, %l6, %o1
	call hanoi
	nop
	or %g0, %l5, %o0
	or %g0, %l6, %o1
	call printf
	nop
	ld [%l1+%lo(peg1)], %l0
	subcc %l0, 0, %l1
	be .LBB1_11
	nop
.LBB1_10:                               ! %L3952.i26
                                        ! =>This Inner Loop Header: Depth=1
	ld [%l0], %o1
	or %g0, %l5, %o0
	call printf
	nop
	ld [%l0+4], %l0
	subcc %l0, 0, %l1
	bne .LBB1_10
	nop
.LBB1_11:                               ! %printPeg.exit27
	or %g0, 2, %o1
	or %g0, %l5, %o0
	call printf
	nop
	ld [%l2+%lo(peg2)], %l0
	subcc %l0, 0, %l1
	be .LBB1_13
	nop
.LBB1_12:                               ! %L3952.i35
                                        ! =>This Inner Loop Header: Depth=1
	ld [%l0], %o1
	or %g0, %l5, %o0
	call printf
	nop
	ld [%l0+4], %l0
	subcc %l0, 0, %l1
	bne .LBB1_12
	nop
.LBB1_13:                               ! %printPeg.exit36
	or %g0, 3, %o1
	or %g0, %l5, %o0
	call printf
	nop
	ld [%l3+%lo(peg3)], %l0
	subcc %l0, 0, %l1
	be .LBB1_15
	nop
.LBB1_14:                               ! %L3952.i44
                                        ! =>This Inner Loop Header: Depth=1
	ld [%l0], %o1
	or %g0, %l5, %o0
	call printf
	nop
	ld [%l0+4], %l0
	subcc %l0, 0, %l1
	bne .LBB1_14
	nop
.LBB1_15:                               ! %printPeg.exit45
	ld [%l4+%lo(numMoves)], %o1
	or %g0, %l5, %o0
	call printf
	nop
	ld [%l3+%lo(peg3)], %o0
	subcc %o0, 0, %l0
	be .LBB1_17
	nop
.LBB1_16:                               ! %L4117
                                        ! =>This Inner Loop Header: Depth=1
	ld [%o0+4], %l0
	st %l0, [%l3+%lo(peg3)]
	call free
	nop
	ld [%l3+%lo(peg3)], %o0
	subcc %o0, 0, %l0
	bne .LBB1_16
	nop
.LBB1_17:                               ! %L4147
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

	.type	peg1,@object            ! @peg1
	.local	peg1                    ! @peg1
	.comm	peg1,4,4
	.type	peg2,@object            ! @peg2
	.local	peg2                    ! @peg2
	.comm	peg2,4,4
	.type	peg3,@object            ! @peg3
	.local	peg3                    ! @peg3
	.comm	peg3,4,4
	.type	numMoves,@object        ! @numMoves
	.local	numMoves                ! @numMoves
	.comm	numMoves,4,4

