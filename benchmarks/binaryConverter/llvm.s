	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmpB007.tmp"
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
! BB#1:                                 ! %.convertToDecimal.exit_crit_edge
	sethi 0, %o1
	ba .LBB0_11
	nop
.LBB0_2:                                ! %.L2250.i.i_crit_edge
	sethi 0, %l1
	or %g0, %l1, %o1
.LBB0_3:                                ! %L2250.i.i
                                        ! =>This Loop Header: Depth=1
                                        !     Child Loop BB0_8 Depth 2
	rd %y, %l2
	sra %l2, 2, %l3
	srl %l2, 31, %l2
	add %l3, %l2, %l2
	smul %l2, 10, %l2
	sub %l0, %l2, %l2
	subcc %l2, 1, %l2
	be .LBB0_5
	nop
! BB#4:                                 ! %L2250.i.i.L2308.i.i_crit_edge
                                        !   in Loop: Header=BB0_3 Depth=1
	ba .LBB0_10
	nop
.LBB0_5:                                ! %L2287.i.i
                                        !   in Loop: Header=BB0_3 Depth=1
	subcc %l1, 0, %l2
	bg .LBB0_7
	nop
! BB#6:                                 ! %L2287.i.i.power.exit.i.i_crit_edge
                                        !   in Loop: Header=BB0_3 Depth=1
	or %g0, 1, %l2
	ba .LBB0_9
	nop
.LBB0_7:                                ! %L2287.i.i.L2204.i.i.i_crit_edge
                                        !   in Loop: Header=BB0_3 Depth=1
	or %g0, 1, %l2
	or %g0, %l1, %l3
.LBB0_8:                                ! %L2204.i.i.i
                                        !   Parent Loop BB0_3 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	sll %l2, 1, %l2
	add %l3, -1, %l3
	subcc %l3, 0, %l4
	bne .LBB0_8
	nop
.LBB0_9:                                ! %power.exit.i.i
                                        !   in Loop: Header=BB0_3 Depth=1
	add %l2, %o1, %o1
.LBB0_10:                               ! %L2308.i.i
                                        !   in Loop: Header=BB0_3 Depth=1
	rd %y, %l2
	sra %l2, 2, %l3
	srl %l2, 31, %l2
	add %l3, %l2, %l2
	add %l1, 1, %l1
	subcc %l0, 9, %l0
	or %g0, %l2, %l0
	bg .LBB0_3
	nop
.LBB0_11:                               ! %convertToDecimal.exit
	sethi %hi(.LC1), %l0
	add %l0, %lo(.LC1), %o0
	call printf
	nop
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


