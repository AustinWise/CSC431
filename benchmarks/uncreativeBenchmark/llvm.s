	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmp70B4.tmp"
	.text
	.globl	main
	.align	4
	.type	main,@function
main:                                   ! @main
! BB#0:
	save %sp, -104, %sp
	or %g0, 9, %o0
	or %g0, 4, %o1
	call calloc
	nop
	sethi 0, %l0
	st %l0, [%o0]
	st %l0, [%o0+4]
	st %l0, [%o0+8]
	st %l0, [%o0+12]
	st %l0, [%o0+16]
	st %l0, [%o0+20]
	st %l0, [%o0+24]
	st %l0, [%o0+28]
	st %l0, [%o0+32]
	sethi %hi(.LC2), %l0
	add %l0, %lo(.LC2), %l0
	add %fp, -4, %o1
	or %g0, %o0, %l1
	or %g0, %l0, %o0
	call scanf
	nop
.LBB0_1:                                ! %L10029
                                        ! =>This Inner Loop Header: Depth=1
	ld [%fp+-4], %l2
	subcc %l2, 3, %l3
	bg .LBB0_7
	nop
! BB#2:                                 ! %L10029
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l2, 1, %l3
	bg .LBB0_5
	nop
! BB#3:                                 ! %L10029
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l2, 0, %l3
	be .LBB0_23
	nop
! BB#4:                                 ! %L10029
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l2, 1, %l2
	be .LBB0_13
	nop
	ba .LBB0_21
	nop
.LBB0_5:                                ! %L10029
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l2, 2, %l3
	be .LBB0_14
	nop
! BB#6:                                 ! %L10029
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l2, 3, %l2
	be .LBB0_15
	nop
	ba .LBB0_21
	nop
.LBB0_7:                                ! %L10029
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l2, 5, %l3
	bg .LBB0_10
	nop
! BB#8:                                 ! %L10029
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l2, 4, %l3
	be .LBB0_16
	nop
! BB#9:                                 ! %L10029
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l2, 5, %l2
	be .LBB0_17
	nop
	ba .LBB0_21
	nop
.LBB0_10:                               ! %L10029
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l2, 6, %l3
	be .LBB0_18
	nop
! BB#11:                                ! %L10029
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l2, 7, %l3
	be .LBB0_19
	nop
! BB#12:                                ! %L10029
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l2, 8, %l2
	be .LBB0_20
	nop
	ba .LBB0_21
	nop
.LBB0_13:                               ! %L10043
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l1], %l2
	add %l2, 1, %l2
	st %l2, [%l1]
	ba .LBB0_22
	nop
.LBB0_14:                               ! %L10063
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l1+4], %l2
	add %l2, 1, %l2
	st %l2, [%l1+4]
	ba .LBB0_22
	nop
.LBB0_15:                               ! %L10083
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l1+8], %l2
	add %l2, 1, %l2
	st %l2, [%l1+8]
	ba .LBB0_22
	nop
.LBB0_16:                               ! %L10103
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l1+12], %l2
	add %l2, 1, %l2
	st %l2, [%l1+12]
	ba .LBB0_22
	nop
.LBB0_17:                               ! %L10123
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l1+16], %l2
	add %l2, 1, %l2
	st %l2, [%l1+16]
	ba .LBB0_22
	nop
.LBB0_18:                               ! %L10143
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l1+20], %l2
	add %l2, 1, %l2
	st %l2, [%l1+20]
	ba .LBB0_22
	nop
.LBB0_19:                               ! %L10163
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l1+24], %l2
	add %l2, 1, %l2
	st %l2, [%l1+24]
	ba .LBB0_22
	nop
.LBB0_20:                               ! %L10183
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l1+28], %l2
	add %l2, 1, %l2
	st %l2, [%l1+28]
	ba .LBB0_22
	nop
.LBB0_21:                               ! %L10195
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l1+32], %l2
	add %l2, 1, %l2
	st %l2, [%l1+32]
.LBB0_22:                               ! %L10231
                                        !   in Loop: Header=BB0_1 Depth=1
	add %fp, -4, %o1
	or %g0, %l0, %o0
	call scanf
	nop
	ba .LBB0_1
	nop
.LBB0_23:                               ! %L10241
	ld [%l1+4], %l0
	ld [%l1], %l2
	ld [%l1+8], %l3
	add %l0, %l2, %l4
	ld [%l1+12], %l5
	add %l4, %l3, %l4
	ld [%l1+16], %l6
	add %l4, %l5, %l4
	ld [%l1+20], %l7
	add %l4, %l6, %l4
	ld [%l1+24], %i0
	add %l4, %l7, %l4
	ld [%l1+28], %i1
	ld [%l1+32], %l1
	add %l4, %i0, %l4
	sethi %hi(.LC1), %i2
	add %l4, %i1, %l4
	add %i2, %lo(.LC1), %i2
	add %l4, %l1, %o1
	or %g0, %i2, %o0
	call printf
	nop
	subcc %l2, 0, %l4
	be .LBB0_25
	nop
.LBB0_24:                               ! %L9788.i11
                                        ! =>This Inner Loop Header: Depth=1
	add %l2, -1, %l2
	or %g0, 1, %o1
	or %g0, %i2, %o0
	call printf
	nop
	subcc %l2, 0, %l4
	bne .LBB0_24
	nop
.LBB0_25:                               ! %printRecursive.exit12
	subcc %l0, 0, %l2
	be .LBB0_27
	nop
.LBB0_26:                               ! %L9788.i23
                                        ! =>This Inner Loop Header: Depth=1
	add %l0, -1, %l0
	or %g0, 10, %o1
	or %g0, %i2, %o0
	call printf
	nop
	subcc %l0, 0, %l2
	bne .LBB0_26
	nop
.LBB0_27:                               ! %printRecursive.exit24
	subcc %l3, 0, %l0
	be .LBB0_29
	nop
.LBB0_28:                               ! %L9788.i35
                                        ! =>This Inner Loop Header: Depth=1
	add %l3, -1, %l3
	or %g0, 11, %o1
	or %g0, %i2, %o0
	call printf
	nop
	subcc %l3, 0, %l0
	bne .LBB0_28
	nop
.LBB0_29:                               ! %printRecursive.exit36
	subcc %l5, 0, %l0
	be .LBB0_31
	nop
.LBB0_30:                               ! %L9788.i47
                                        ! =>This Inner Loop Header: Depth=1
	add %l5, -1, %l5
	or %g0, 100, %o1
	or %g0, %i2, %o0
	call printf
	nop
	subcc %l5, 0, %l0
	bne .LBB0_30
	nop
.LBB0_31:                               ! %printRecursive.exit48
	subcc %l6, 0, %l0
	be .LBB0_33
	nop
.LBB0_32:                               ! %L9788.i41
                                        ! =>This Inner Loop Header: Depth=1
	add %l6, -1, %l6
	or %g0, 101, %o1
	or %g0, %i2, %o0
	call printf
	nop
	subcc %l6, 0, %l0
	bne .LBB0_32
	nop
.LBB0_33:                               ! %printRecursive.exit42
	subcc %l7, 0, %l0
	be .LBB0_35
	nop
.LBB0_34:                               ! %L9788.i29
                                        ! =>This Inner Loop Header: Depth=1
	add %l7, -1, %l7
	or %g0, 110, %o1
	or %g0, %i2, %o0
	call printf
	nop
	subcc %l7, 0, %l0
	bne .LBB0_34
	nop
.LBB0_35:                               ! %printRecursive.exit30
	subcc %i0, 0, %l0
	be .LBB0_37
	nop
.LBB0_36:                               ! %L9788.i17
                                        ! =>This Inner Loop Header: Depth=1
	add %i0, -1, %i0
	or %g0, 111, %o1
	or %g0, %i2, %o0
	call printf
	nop
	subcc %i0, 0, %l0
	bne .LBB0_36
	nop
.LBB0_37:                               ! %printRecursive.exit18
	subcc %i1, 0, %l0
	be .LBB0_39
	nop
.LBB0_38:                               ! %L9788.i5
                                        ! =>This Inner Loop Header: Depth=1
	add %i1, -1, %i1
	or %g0, 1000, %o1
	or %g0, %i2, %o0
	call printf
	nop
	subcc %i1, 0, %l0
	bne .LBB0_38
	nop
.LBB0_39:                               ! %printRecursive.exit6
	subcc %l1, 0, %l0
	be .LBB0_41
	nop
.LBB0_40:                               ! %L9788.i
                                        ! =>This Inner Loop Header: Depth=1
	add %l1, -1, %l1
	or %g0, 1001, %o1
	or %g0, %i2, %o0
	call printf
	nop
	subcc %l1, 0, %l0
	bne .LBB0_40
	nop
.LBB0_41:                               ! %printRecursive.exit
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


