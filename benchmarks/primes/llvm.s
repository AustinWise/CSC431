	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmp6EFA.tmp"
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
	bl .LBB0_11
	nop
! BB#1:                                 ! %.L7594_crit_edge
	sethi 0, %l1
.LBB0_2:                                ! %L7594
                                        ! =>This Loop Header: Depth=1
                                        !     Child Loop BB0_6 Depth 2
                                        !     Child Loop BB0_4 Depth 2
	subcc %l1, 2, %l2
	bl .LBB0_10
	nop
! BB#3:                                 ! %L7594.L7441.i.i_crit_edge
                                        !   in Loop: Header=BB0_2 Depth=1
	or %g0, 3, %l2
	or %g0, 1, %l3
.LBB0_4:                                ! %L7441.i.i
                                        !   Parent Loop BB0_2 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	add %l2, 2, %l4
	add %l2, %l3, %l3
	subcc %l3, %l1, %l2
	or %g0, %l4, %l2
	ble .LBB0_4
	nop
! BB#5:                                 ! %isqrt.exit.i
                                        !   in Loop: Header=BB0_2 Depth=1
	srl %l4, 31, %l2
	add %l4, %l2, %l2
	sra %l2, 1, %l2
	add %l2, -1, %l2
	or %g0, 2, %l3
.LBB0_6:                                ! %L7510.i
                                        !   Parent Loop BB0_2 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	subcc %l3, %l2, %l4
	bg .LBB0_9
	nop
! BB#7:                                 ! %L7517.i
                                        !   in Loop: Header=BB0_6 Depth=2
	sra %l1, 31, %l4
	wr %l4, %g0, %y
	sdiv %l1, %l3, %l4
	smul %l4, %l3, %l4
	sub %l1, %l4, %l4
	subcc %l4, 0, %l4
	be .LBB0_10
	nop
! BB#8:                                 ! %L7552.i
                                        !   in Loop: Header=BB0_6 Depth=2
	add %l3, 1, %l3
	ba .LBB0_6
	nop
.LBB0_9:                                ! %L7601
                                        !   in Loop: Header=BB0_2 Depth=1
	sethi %hi(.LC1), %l2
	add %l2, %lo(.LC1), %o0
	or %g0, %l1, %o1
	call printf
	nop
.LBB0_10:                               ! %L7612
                                        !   in Loop: Header=BB0_2 Depth=1
	add %l1, 1, %l1
	subcc %l1, %l0, %l2
	ble .LBB0_2
	nop
.LBB0_11:                               ! %L7629
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


