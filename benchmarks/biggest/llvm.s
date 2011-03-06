	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmpAFD7.tmp"
	.text
	.align	4
	.type	getIntList,@function
getIntList:                             ! @getIntList
! BB#0:
	save %sp, -104, %sp
	or %g0, 2, %o0
	or %g0, 4, %o1
	call calloc
	nop
	or %g0, %o0, %i0
	sethi %hi(.LC2), %l0
	add %l0, %lo(.LC2), %o0
	add %fp, -4, %o1
	call scanf
	nop
	ld [%fp+-4], %l0
	subcc %l0, -1, %l1
	bne .LBB0_2
	nop
! BB#1:                                 ! %L1975
	restore %g0, %g0, %g0
	retl
	nop
.LBB0_2:                                ! %L1981
	st %l0, [%i0]
	call getIntList
	nop
	st %o0, [%i0+4]
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp0:
	.size	getIntList, .Ltmp0-getIntList

	.globl	main
	.align	4
	.type	main,@function
main:                                   ! @main
! BB#0:
	save %sp, -96, %sp
	call getIntList
	nop
	ld [%o0], %o1
	ld [%o0+4], %l0
	subcc %l0, 0, %l1
	bne .LBB1_2
	nop
.LBB1_1:                                ! %.biggestInList.exit_crit_edge
	ba .LBB1_5
	nop
.LBB1_2:                                ! %L2051.i.preheader
	ld [%l0+4], %l1
	subcc %l1, 0, %l2
	be .LBB1_1
	nop
.LBB1_3:                                ! %L2051.L2051_crit_edge.i
                                        ! =>This Inner Loop Header: Depth=1
	or %g0, %l1, %l2
	ld [%l0], %l3
	movg %icc, %o1, %l3
	ld [%l2+4], %l1
	subcc %l1, 0, %l0
	or %g0, %l3, %o1
	or %g0, %l2, %l0
	bne .LBB1_3
	nop
! BB#4:                                 ! %L2051.L2051_crit_edge.i.biggestInList.exit_crit_edge
	or %g0, %l3, %o1
.LBB1_5:                                ! %biggestInList.exit
	sethi %hi(.LC1), %l0
	add %l0, %lo(.LC1), %o0
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


