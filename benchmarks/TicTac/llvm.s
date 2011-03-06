	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmpB43B.tmp"
	.text
	.globl	main
	.align	4
	.type	main,@function
main:                                   ! @main
! BB#0:                                 ! %bb.nph
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
	ld [%o0], %o1
	or %g0, 7, %l1
	or %g0, %o0, %l2
.LBB0_1:                                ! %L9507
                                        ! =>This Inner Loop Header: Depth=1
	sethi %hi(.LC0), %l3
	add %l3, %lo(.LC0), %l3
	or %g0, %l3, %o0
	call printf
	nop
	ld [%l2+4], %o1
	or %g0, %l3, %o0
	call printf
	nop
	ld [%l2+8], %o1
	sethi %hi(.LC1), %l4
	add %l4, %lo(.LC1), %l4
	or %g0, %l4, %o0
	call printf
	nop
	ld [%l2+12], %o1
	or %g0, %l3, %o0
	call printf
	nop
	ld [%l2+16], %o1
	or %g0, %l3, %o0
	call printf
	nop
	ld [%l2+20], %o1
	or %g0, %l4, %o0
	call printf
	nop
	ld [%l2+24], %o1
	or %g0, %l3, %o0
	call printf
	nop
	ld [%l2+28], %o1
	or %g0, %l3, %o0
	call printf
	nop
	ld [%l2+32], %o1
	or %g0, %l4, %o0
	call printf
	nop
	subcc %l0, 0, %l3
	bne .LBB0_24
	nop
! BB#2:                                 ! %L9519
                                        !   in Loop: Header=BB0_1 Depth=1
	sethi %hi(.LC2), %l0
	add %l0, %lo(.LC2), %o0
	add %fp, -4, %o1
	call scanf
	nop
	ld [%fp+-4], %l0
	subcc %l0, 4, %l3
	bg .LBB0_8
	nop
! BB#3:                                 ! %L9519
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l0, 2, %l3
	bg .LBB0_6
	nop
! BB#4:                                 ! %L9519
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l0, 1, %l3
	be .LBB0_15
	nop
! BB#5:                                 ! %L9519
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l0, 2, %l0
	be .LBB0_16
	nop
	ba .LBB0_14
	nop
.LBB0_6:                                ! %L9519
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l0, 3, %l3
	be .LBB0_17
	nop
! BB#7:                                 ! %L9519
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l0, 4, %l0
	be .LBB0_18
	nop
	ba .LBB0_14
	nop
.LBB0_8:                                ! %L9519
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l0, 6, %l3
	bg .LBB0_11
	nop
! BB#9:                                 ! %L9519
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l0, 5, %l3
	be .LBB0_19
	nop
! BB#10:                                ! %L9519
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l0, 6, %l0
	be .LBB0_20
	nop
	ba .LBB0_14
	nop
.LBB0_11:                               ! %L9519
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l0, 7, %l3
	be .LBB0_21
	nop
! BB#12:                                ! %L9519
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l0, 8, %l3
	be .LBB0_22
	nop
! BB#13:                                ! %L9519
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l0, 9, %l0
	be .LBB0_23
	nop
.LBB0_14:                               ! %L9519.L9564_crit_edge
                                        !   in Loop: Header=BB0_1 Depth=1
	or %g0, 1, %l0
	ba .LBB0_46
	nop
.LBB0_15:                               ! %L9564.thread
                                        !   in Loop: Header=BB0_1 Depth=1
	or %g0, 1, %o1
	st %o1, [%l2]
	or %g0, %o1, %l3
	or %g0, %o1, %l0
	ba .LBB0_47
	nop
.LBB0_16:                               ! %L8759.i
                                        !   in Loop: Header=BB0_1 Depth=1
	or %g0, 1, %l0
	st %l0, [%l2+4]
	ba .LBB0_46
	nop
.LBB0_17:                               ! %L8775.i
                                        !   in Loop: Header=BB0_1 Depth=1
	or %g0, 1, %l0
	st %l0, [%l2+8]
	ba .LBB0_46
	nop
.LBB0_18:                               ! %L8791.i
                                        !   in Loop: Header=BB0_1 Depth=1
	or %g0, 1, %l0
	st %l0, [%l2+12]
	ba .LBB0_46
	nop
.LBB0_19:                               ! %L8807.i
                                        !   in Loop: Header=BB0_1 Depth=1
	or %g0, 1, %l0
	st %l0, [%l2+16]
	ba .LBB0_46
	nop
.LBB0_20:                               ! %L8823.i
                                        !   in Loop: Header=BB0_1 Depth=1
	or %g0, 1, %l0
	st %l0, [%l2+20]
	ba .LBB0_46
	nop
.LBB0_21:                               ! %L8839.i
                                        !   in Loop: Header=BB0_1 Depth=1
	or %g0, 1, %l0
	st %l0, [%l2+24]
	ba .LBB0_46
	nop
.LBB0_22:                               ! %L8855.i
                                        !   in Loop: Header=BB0_1 Depth=1
	or %g0, 1, %l0
	st %l0, [%l2+28]
	ba .LBB0_46
	nop
.LBB0_23:                               ! %L8871.i
                                        !   in Loop: Header=BB0_1 Depth=1
	or %g0, 1, %l0
	st %l0, [%l2+32]
	ba .LBB0_46
	nop
.LBB0_24:                               ! %L9540
                                        !   in Loop: Header=BB0_1 Depth=1
	sethi %hi(.LC2), %l3
	add %l3, %lo(.LC2), %o0
	add %fp, -4, %o1
	call scanf
	nop
	add %l0, -1, %l0
	ld [%fp+-4], %l3
	subcc %l3, 4, %l5
	bg .LBB0_30
	nop
! BB#25:                                ! %L9540
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l3, 2, %l5
	bg .LBB0_28
	nop
! BB#26:                                ! %L9540
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l3, 1, %l5
	be .LBB0_37
	nop
! BB#27:                                ! %L9540
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l3, 2, %l3
	be .LBB0_38
	nop
	ba .LBB0_36
	nop
.LBB0_28:                               ! %L9540
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l3, 3, %l5
	be .LBB0_39
	nop
! BB#29:                                ! %L9540
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l3, 4, %l3
	be .LBB0_40
	nop
	ba .LBB0_36
	nop
.LBB0_30:                               ! %L9540
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l3, 6, %l5
	bg .LBB0_33
	nop
! BB#31:                                ! %L9540
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l3, 5, %l5
	be .LBB0_41
	nop
! BB#32:                                ! %L9540
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l3, 6, %l3
	be .LBB0_42
	nop
	ba .LBB0_36
	nop
.LBB0_33:                               ! %L9540
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l3, 7, %l5
	be .LBB0_43
	nop
! BB#34:                                ! %L9540
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l3, 8, %l5
	be .LBB0_44
	nop
! BB#35:                                ! %L9540
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l3, 9, %l3
	be .LBB0_45
	nop
.LBB0_36:                               ! %L9540.L9564_crit_edge
                                        !   in Loop: Header=BB0_1 Depth=1
	ba .LBB0_46
	nop
.LBB0_37:                               ! %L8960.i.thread
                                        !   in Loop: Header=BB0_1 Depth=1
	sethi 0, %l3
	or %g0, 2, %o1
	st %o1, [%l2]
	ba .LBB0_53
	nop
.LBB0_38:                               ! %L8759.i4
                                        !   in Loop: Header=BB0_1 Depth=1
	or %g0, 2, %l3
	st %l3, [%l2+4]
	ba .LBB0_46
	nop
.LBB0_39:                               ! %L8775.i6
                                        !   in Loop: Header=BB0_1 Depth=1
	or %g0, 2, %l3
	st %l3, [%l2+8]
	ba .LBB0_46
	nop
.LBB0_40:                               ! %L8791.i8
                                        !   in Loop: Header=BB0_1 Depth=1
	or %g0, 2, %l3
	st %l3, [%l2+12]
	ba .LBB0_46
	nop
.LBB0_41:                               ! %L8807.i10
                                        !   in Loop: Header=BB0_1 Depth=1
	or %g0, 2, %l3
	st %l3, [%l2+16]
	ba .LBB0_46
	nop
.LBB0_42:                               ! %L8823.i12
                                        !   in Loop: Header=BB0_1 Depth=1
	or %g0, 2, %l3
	st %l3, [%l2+20]
	ba .LBB0_46
	nop
.LBB0_43:                               ! %L8839.i14
                                        !   in Loop: Header=BB0_1 Depth=1
	or %g0, 2, %l3
	st %l3, [%l2+24]
	ba .LBB0_46
	nop
.LBB0_44:                               ! %L8855.i16
                                        !   in Loop: Header=BB0_1 Depth=1
	or %g0, 2, %l3
	st %l3, [%l2+28]
	ba .LBB0_46
	nop
.LBB0_45:                               ! %L8871.i18
                                        !   in Loop: Header=BB0_1 Depth=1
	or %g0, 2, %l3
	st %l3, [%l2+32]
.LBB0_46:                               ! %L9564
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l2], %o1
	sethi 0, %l3
	move %icc, 1, %l3
	subcc %o1, 1, %l5
	bne .LBB0_51
	nop
.LBB0_47:                               ! %L8922.i
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l2+4], %l5
	subcc %l5, 1, %l5
	be .LBB0_49
	nop
.LBB0_48:                               ! %L8922.i.L9005.i_crit_edge
                                        !   in Loop: Header=BB0_1 Depth=1
	or %g0, 1, %l5
	ba .LBB0_57
	nop
.LBB0_49:                               ! %L8931.i
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l2+8], %l5
	subcc %l5, 1, %l5
	bne .LBB0_48
	nop
! BB#50:                                ! %L8931.i.checkWinner.exit_crit_edge
                                        !   in Loop: Header=BB0_1 Depth=1
	sethi 0, %l3
	ba .LBB0_90
	nop
.LBB0_51:                               ! %L8960.i
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %o1, 2, %l5
	be .LBB0_53
	nop
! BB#52:                                ! %L8960.i.L9005.i_crit_edge
                                        !   in Loop: Header=BB0_1 Depth=1
	or %g0, 1, %l5
	ba .LBB0_57
	nop
.LBB0_53:                               ! %L8967.i
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l2+4], %l5
	subcc %l5, 2, %l5
	be .LBB0_55
	nop
.LBB0_54:                               ! %L8967.i.L9005.i_crit_edge
                                        !   in Loop: Header=BB0_1 Depth=1
	sethi 0, %l5
	ba .LBB0_57
	nop
.LBB0_55:                               ! %L8976.i
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l2+8], %l5
	subcc %l5, 2, %l5
	bne .LBB0_54
	nop
! BB#56:                                ! %L8976.i.checkWinner.exit_crit_edge
                                        !   in Loop: Header=BB0_1 Depth=1
	or %g0, 1, %l3
	ba .LBB0_90
	nop
.LBB0_57:                               ! %L9005.i
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l2+12], %l6
	subcc %l6, 1, %l7
	bne .LBB0_62
	nop
! BB#58:                                ! %L9012.i
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l2+16], %l6
	subcc %l6, 1, %l6
	be .LBB0_60
	nop
.LBB0_59:                               ! %L9012.i.L9095.i_crit_edge
                                        !   in Loop: Header=BB0_1 Depth=1
	or %g0, 1, %l6
	ba .LBB0_67
	nop
.LBB0_60:                               ! %L9021.i
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l2+20], %l6
	subcc %l6, 1, %l6
	bne .LBB0_59
	nop
.LBB0_61:                               ! %L9021.i.checkWinner.exit_crit_edge
                                        !   in Loop: Header=BB0_1 Depth=1
	sethi 0, %l3
	ba .LBB0_90
	nop
.LBB0_62:                               ! %L9050.i
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l6, 2, %l6
	bne .LBB0_59
	nop
! BB#63:                                ! %L9057.i
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l2+16], %l6
	subcc %l6, 2, %l6
	be .LBB0_65
	nop
.LBB0_64:                               ! %L9057.i.L9095.i_crit_edge
                                        !   in Loop: Header=BB0_1 Depth=1
	sethi 0, %l6
	ba .LBB0_67
	nop
.LBB0_65:                               ! %L9066.i
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l2+20], %l6
	subcc %l6, 2, %l6
	bne .LBB0_64
	nop
.LBB0_66:                               ! %L9066.i.checkWinner.exit_crit_edge
                                        !   in Loop: Header=BB0_1 Depth=1
	or %g0, 1, %l3
	ba .LBB0_90
	nop
.LBB0_67:                               ! %L9095.i
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l2+24], %l7
	subcc %l7, 1, %i0
	bne .LBB0_70
	nop
! BB#68:                                ! %L9102.i
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l2+28], %l5
	subcc %l5, 1, %l5
	bne .LBB0_74
	nop
! BB#69:                                ! %L9111.i
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l2+32], %l5
	subcc %l5, 1, %l5
	be .LBB0_61
	nop
	ba .LBB0_74
	nop
.LBB0_70:                               ! %L9140.i
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l7, 2, %l3
	bne .LBB0_77
	nop
! BB#71:                                ! %L9147.i
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l2+28], %l3
	subcc %l3, 2, %l3
	bne .LBB0_76
	nop
! BB#72:                                ! %L9156.i
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l2+32], %l3
	subcc %l3, 2, %l3
	be .LBB0_66
	nop
! BB#73:                                ! %L9156.i
                                        !   in Loop: Header=BB0_1 Depth=1
	or %l5, %l6, %l3
	subcc %l3, 0, %l3
	bne .LBB0_77
	nop
	ba .LBB0_66
	nop
.LBB0_74:                               ! %L9185.i
                                        !   in Loop: Header=BB0_1 Depth=1
	sethi 0, %l5
	move %icc, 1, %l5
	and %l3, %l5, %l3
	subcc %l3, 0, %l3
	be .LBB0_77
	nop
! BB#75:                                ! %L9185.i
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l7, 1, %l3
	be .LBB0_61
	nop
	ba .LBB0_77
	nop
.LBB0_76:                               ! %L9230.i
                                        !   in Loop: Header=BB0_1 Depth=1
	or %l5, %l6, %l3
	and %l3, 1, %l3
	subcc %l3, 0, %l3
	be .LBB0_66
	nop
.LBB0_77:                               ! %L9275.i
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l2+4], %l3
	subcc %l3, 2, %l5
	be .LBB0_81
	nop
! BB#78:                                ! %L9275.i
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l3, 1, %l3
	bne .LBB0_83
	nop
! BB#79:                                ! %L9282.i
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l2+16], %l3
	subcc %l3, 1, %l3
	bne .LBB0_83
	nop
! BB#80:                                ! %L9291.i
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l2+28], %l3
	subcc %l3, 1, %l3
	be .LBB0_61
	nop
	ba .LBB0_83
	nop
.LBB0_81:                               ! %L9327.i
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l2+16], %l3
	subcc %l3, 2, %l3
	bne .LBB0_83
	nop
! BB#82:                                ! %L9336.i
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l2+28], %l3
	subcc %l3, 2, %l3
	be .LBB0_66
	nop
.LBB0_83:                               ! %L9365.i
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l2+8], %l3
	subcc %l3, 1, %l5
	be .LBB0_86
	nop
! BB#84:                                ! %L9365.i
                                        !   in Loop: Header=BB0_1 Depth=1
	subcc %l3, 2, %l3
	be .LBB0_88
	nop
.LBB0_85:                               ! %L9365.i.checkWinner.exit_crit_edge
                                        !   in Loop: Header=BB0_1 Depth=1
	or %g0, -1, %l3
	ba .LBB0_90
	nop
.LBB0_86:                               ! %L9372.i
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l2+20], %l3
	subcc %l3, 1, %l3
	bne .LBB0_85
	nop
! BB#87:                                ! %L9381.i
                                        !   in Loop: Header=BB0_1 Depth=1
	sethi 0, %l3
	movne %icc, -1, %l3
	ba .LBB0_90
	nop
.LBB0_88:                               ! %L9417.i
                                        !   in Loop: Header=BB0_1 Depth=1
	ld [%l2+20], %l3
	subcc %l3, 2, %l3
	bne .LBB0_85
	nop
! BB#89:                                ! %L9426.i
                                        !   in Loop: Header=BB0_1 Depth=1
	or %g0, -1, %l3
	move %icc, 1, %l3
.LBB0_90:                               ! %checkWinner.exit
                                        !   in Loop: Header=BB0_1 Depth=1
	sethi 0, %l5
	add %l1, -1, %l1
	movne %icc, 1, %l5
	srl %l3, 31, %l6
	and %l5, %l6, %l5
	subcc %l5, 1, %l5
	be .LBB0_1
	nop
! BB#91:                                ! %L9594
	add %l3, 1, %o1
	or %g0, %l4, %o0
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


