	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmpE46F.tmp"
	.text
	.globl	wait
	.align	4
	.type	wait,@function
wait:                                   ! @wait
! BB#0:
	save %sp, -96, %sp
	sethi 0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp0:
	.size	wait, .Ltmp0-wait

	.globl	power
	.align	4
	.type	power,@function
power:                                  ! @power
! BB#0:
	save %sp, -96, %sp
	subcc %i1, 0, %l0
	bg .LBB1_2
	nop
! BB#1:                                 ! %.L1629_crit_edge
	or %g0, 1, %l0
	ba .LBB1_4
	nop
.LBB1_2:                                ! %.L1602_crit_edge
	or %g0, 1, %l0
.LBB1_3:                                ! %L1602
                                        ! =>This Inner Loop Header: Depth=1
	smul %l0, %i0, %l0
	add %i1, -1, %i1
	subcc %i1, 0, %l1
	bne .LBB1_3
	nop
.LBB1_4:                                ! %L1629
	or %g0, %l0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp1:
	.size	power, .Ltmp1-power

	.globl	recursiveDecimalSum
	.align	4
	.type	recursiveDecimalSum,@function
recursiveDecimalSum:                    ! @recursiveDecimalSum
! BB#0:
	save %sp, -96, %sp
	subcc %i0, 0, %l0
	bg .LBB2_2
	nop
! BB#1:                                 ! %.L1726_crit_edge
	ba .LBB2_10
	nop
.LBB2_2:                                ! %L1645
                                        ! =>This Loop Header: Depth=1
                                        !     Child Loop BB2_7 Depth 2
	rd %y, %l0
	sra %l0, 2, %l1
	srl %l0, 31, %l0
	add %l1, %l0, %l0
	smul %l0, 10, %l0
	sub %i0, %l0, %l0
	subcc %l0, 1, %l0
	be .LBB2_4
	nop
! BB#3:                                 ! %L1645.L1703_crit_edge
                                        !   in Loop: Header=BB2_2 Depth=1
	ba .LBB2_9
	nop
.LBB2_4:                                ! %L1682
                                        !   in Loop: Header=BB2_2 Depth=1
	subcc %i2, 0, %l0
	bg .LBB2_6
	nop
! BB#5:                                 ! %L1682.power.exit_crit_edge
                                        !   in Loop: Header=BB2_2 Depth=1
	or %g0, 1, %l0
	ba .LBB2_8
	nop
.LBB2_6:                                ! %L1682.L1602.i_crit_edge
                                        !   in Loop: Header=BB2_2 Depth=1
	or %g0, 1, %l0
	or %g0, %i2, %l1
.LBB2_7:                                ! %L1602.i
                                        !   Parent Loop BB2_2 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	sll %l0, 1, %l0
	add %l1, -1, %l1
	subcc %l1, 0, %l2
	bne .LBB2_7
	nop
.LBB2_8:                                ! %power.exit
                                        !   in Loop: Header=BB2_2 Depth=1
	add %l0, %i1, %i1
.LBB2_9:                                ! %L1703
                                        !   in Loop: Header=BB2_2 Depth=1
	rd %y, %l0
	sra %l0, 2, %l1
	srl %l0, 31, %l0
	add %l1, %l0, %l0
	add %i2, 1, %i2
	subcc %i0, 9, %l1
	or %g0, %l0, %i0
	bg .LBB2_2
	nop
.LBB2_10:                               ! %L1726
	or %g0, %i1, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp2:
	.size	recursiveDecimalSum, .Ltmp2-recursiveDecimalSum

	.globl	convertToDecimal
	.align	4
	.type	convertToDecimal,@function
convertToDecimal:                       ! @convertToDecimal
! BB#0:
	save %sp, -96, %sp
	subcc %i0, 0, %l0
	bg .LBB3_2
	nop
! BB#1:                                 ! %.recursiveDecimalSum.exit_crit_edge
	sethi 0, %l0
	ba .LBB3_11
	nop
.LBB3_2:                                ! %.L1645.i_crit_edge
	sethi 0, %l1
	or %g0, %l1, %l0
.LBB3_3:                                ! %L1645.i
                                        ! =>This Loop Header: Depth=1
                                        !     Child Loop BB3_8 Depth 2
	rd %y, %l2
	sra %l2, 2, %l3
	srl %l2, 31, %l2
	add %l3, %l2, %l2
	smul %l2, 10, %l2
	sub %i0, %l2, %l2
	subcc %l2, 1, %l2
	be .LBB3_5
	nop
! BB#4:                                 ! %L1645.i.L1703.i_crit_edge
                                        !   in Loop: Header=BB3_3 Depth=1
	ba .LBB3_10
	nop
.LBB3_5:                                ! %L1682.i
                                        !   in Loop: Header=BB3_3 Depth=1
	subcc %l1, 0, %l2
	bg .LBB3_7
	nop
! BB#6:                                 ! %L1682.i.power.exit.i_crit_edge
                                        !   in Loop: Header=BB3_3 Depth=1
	or %g0, 1, %l2
	ba .LBB3_9
	nop
.LBB3_7:                                ! %L1682.i.L1602.i.i_crit_edge
                                        !   in Loop: Header=BB3_3 Depth=1
	or %g0, 1, %l2
	or %g0, %l1, %l3
.LBB3_8:                                ! %L1602.i.i
                                        !   Parent Loop BB3_3 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	sll %l2, 1, %l2
	add %l3, -1, %l3
	subcc %l3, 0, %l4
	bne .LBB3_8
	nop
.LBB3_9:                                ! %power.exit.i
                                        !   in Loop: Header=BB3_3 Depth=1
	add %l2, %l0, %l0
.LBB3_10:                               ! %L1703.i
                                        !   in Loop: Header=BB3_3 Depth=1
	rd %y, %l2
	sra %l2, 2, %l3
	srl %l2, 31, %l2
	add %l3, %l2, %l2
	add %l1, 1, %l1
	subcc %i0, 9, %l3
	or %g0, %l2, %i0
	bg .LBB3_3
	nop
.LBB3_11:                               ! %recursiveDecimalSum.exit
	or %g0, %l0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp3:
	.size	convertToDecimal, .Ltmp3-convertToDecimal

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
	bg .LBB4_2
	nop
! BB#1:                                 ! %.convertToDecimal.exit_crit_edge
	sethi 0, %o1
	ba .LBB4_11
	nop
.LBB4_2:                                ! %.L1645.i.i_crit_edge
	sethi 0, %l1
	or %g0, %l1, %o1
.LBB4_3:                                ! %L1645.i.i
                                        ! =>This Loop Header: Depth=1
                                        !     Child Loop BB4_8 Depth 2
	rd %y, %l2
	sra %l2, 2, %l3
	srl %l2, 31, %l2
	add %l3, %l2, %l2
	smul %l2, 10, %l2
	sub %l0, %l2, %l2
	subcc %l2, 1, %l2
	be .LBB4_5
	nop
! BB#4:                                 ! %L1645.i.i.L1703.i.i_crit_edge
                                        !   in Loop: Header=BB4_3 Depth=1
	ba .LBB4_10
	nop
.LBB4_5:                                ! %L1682.i.i
                                        !   in Loop: Header=BB4_3 Depth=1
	subcc %l1, 0, %l2
	bg .LBB4_7
	nop
! BB#6:                                 ! %L1682.i.i.power.exit.i.i_crit_edge
                                        !   in Loop: Header=BB4_3 Depth=1
	or %g0, 1, %l2
	ba .LBB4_9
	nop
.LBB4_7:                                ! %L1682.i.i.L1602.i.i.i_crit_edge
                                        !   in Loop: Header=BB4_3 Depth=1
	or %g0, 1, %l2
	or %g0, %l1, %l3
.LBB4_8:                                ! %L1602.i.i.i
                                        !   Parent Loop BB4_3 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	sll %l2, 1, %l2
	add %l3, -1, %l3
	subcc %l3, 0, %l4
	bne .LBB4_8
	nop
.LBB4_9:                                ! %power.exit.i.i
                                        !   in Loop: Header=BB4_3 Depth=1
	add %l2, %o1, %o1
.LBB4_10:                               ! %L1703.i.i
                                        !   in Loop: Header=BB4_3 Depth=1
	rd %y, %l2
	sra %l2, 2, %l3
	srl %l2, 31, %l2
	add %l3, %l2, %l2
	add %l1, 1, %l1
	subcc %l0, 9, %l0
	or %g0, %l2, %l0
	bg .LBB4_3
	nop
.LBB4_11:                               ! %convertToDecimal.exit
	sethi %hi(.LC1), %l0
	add %l0, %lo(.LC1), %o0
	call printf
	nop
	sethi 0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp4:
	.size	main, .Ltmp4-main

	.type	.LC1,@object            ! @.LC1
	.section	.rodata.str1.1,"aMS",@progbits,1
.LC1:
	.asciz	 "%d\n"
	.size	.LC1, 4

	.type	.LC2,@object            ! @.LC2
.LC2:
	.asciz	 "%d"
	.size	.LC2, 3


