@.LC0 = internal constant [4 x i8] c"%d \00"
@.LC1 = internal constant [4 x i8] c"%d\0A\00"
@.LC2 = internal constant [3 x i8] c"%d\00"
declare i32 @printf(i8*, ...)
declare i32 @scanf(i8*, ...)
define i32 @wait(i32 %waitTime) {
%stack_waitTime = alloca i32
%evil_scanf = alloca i32
store i32 %waitTime, i32* %stack_waitTime
br label %L1684
L1684:
%r1001 = load i32* %stack_waitTime
%r1003 = add i32 0, 0
%r1152 = icmp sgt i32 %r1001, %r1003
%r999 = select i1 %r1152, i32 1, i32 0
%r1468 = icmp eq i32 %r999, 1
br i1 %r1468, label %L1690, label %L1708
L1690:
%r1006 = load i32* %stack_waitTime
%r1008 = add i32 1, 0
%r1004 = sub i32 %r1006, %r1008
store i32 %r1004, i32* %stack_waitTime
br label %L1684
br label %L1684
L1708:
%r1016 = add i32 0, 0
ret i32 %r1016
}
define i32 @power(i32 %base, i32 %exponent) {
%stack_base = alloca i32
%stack_exponent = alloca i32
%stack_product = alloca i32
%evil_scanf = alloca i32
store i32 %base, i32* %stack_base
store i32 %exponent, i32* %stack_exponent
%r1021 = add i32 1, 0
store i32 %r1021, i32* %stack_product
br label %L1721
L1721:
%r1024 = load i32* %stack_exponent
%r1026 = add i32 0, 0
%r1473 = icmp sgt i32 %r1024, %r1026
%r1022 = select i1 %r1473, i32 1, i32 0
%r1474 = icmp eq i32 %r1022, 1
br i1 %r1474, label %L1727, label %L1754
L1727:
%r1029 = load i32* %stack_product
%r1031 = load i32* %stack_base
%r1027 = mul i32 %r1029, %r1031
store i32 %r1027, i32* %stack_product
%r1034 = load i32* %stack_exponent
%r1036 = add i32 1, 0
%r1032 = sub i32 %r1034, %r1036
store i32 %r1032, i32* %stack_exponent
br label %L1721
br label %L1721
L1754:
%r1044 = load i32* %stack_product
ret i32 %r1044
}
define i32 @recursiveDecimalSum(i32 %binaryNum, i32 %decimalSum, i32 %recursiveDepth) {
%stack_binaryNum = alloca i32
%stack_decimalSum = alloca i32
%stack_recursiveDepth = alloca i32
%stack_tempNum = alloca i32
%stack_base = alloca i32
%stack_remainder = alloca i32
%evil_scanf = alloca i32
store i32 %binaryNum, i32* %stack_binaryNum
store i32 %decimalSum, i32* %stack_decimalSum
store i32 %recursiveDepth, i32* %stack_recursiveDepth
%r1051 = load i32* %stack_binaryNum
%r1053 = add i32 0, 0
%r1475 = icmp sgt i32 %r1051, %r1053
%r1049 = select i1 %r1475, i32 1, i32 0
%r1476 = icmp eq i32 %r1049, 1
br i1 %r1476, label %L1770, label %L1846
L1770:
%r1055 = add i32 2, 0
store i32 %r1055, i32* %stack_base
%r1058 = load i32* %stack_binaryNum
%r1060 = add i32 10, 0
%r1056 = sdiv i32 %r1058, %r1060
store i32 %r1056, i32* %stack_tempNum
%r1063 = load i32* %stack_tempNum
%r1065 = add i32 10, 0
%r1061 = mul i32 %r1063, %r1065
store i32 %r1061, i32* %stack_tempNum
%r1068 = load i32* %stack_binaryNum
%r1070 = load i32* %stack_tempNum
%r1066 = sub i32 %r1068, %r1070
store i32 %r1066, i32* %stack_tempNum
%r1073 = load i32* %stack_tempNum
%r1075 = add i32 1, 0
%r1478 = icmp eq i32 %r1073, %r1075
%r1071 = select i1 %r1478, i32 1, i32 0
%r1479 = icmp eq i32 %r1071, 1
br i1 %r1479, label %L1807, label %L1823
L1807:
%r1078 = load i32* %stack_decimalSum
%r1082 = load i32* %stack_base
%r1084 = load i32* %stack_recursiveDepth
%r1080 = call i32 @power(i32 %r1082, i32 %r1084)
%r1076 = add i32 %r1078, %r1080
store i32 %r1076, i32* %stack_decimalSum
br label %L1828
br label %L1828
L1823:
br label %L1828
br label %L1828
L1828:
%r1090 = load i32* %stack_binaryNum
%r1092 = add i32 10, 0
%r1088 = sdiv i32 %r1090, %r1092
%r1094 = load i32* %stack_decimalSum
%r1097 = load i32* %stack_recursiveDepth
%r1099 = add i32 1, 0
%r1095 = add i32 %r1097, %r1099
%r1087 = call i32 @recursiveDecimalSum(i32 %r1088, i32 %r1094, i32 %r1095)
ret i32 %r1087
br label %L1851
L1846:
br label %L1851
br label %L1851
L1851:
%r1102 = load i32* %stack_decimalSum
ret i32 %r1102
}
define i32 @convertToDecimal(i32 %binaryNum) {
%stack_binaryNum = alloca i32
%stack_recursiveDepth = alloca i32
%stack_decimalSum = alloca i32
%evil_scanf = alloca i32
store i32 %binaryNum, i32* %stack_binaryNum
%r1106 = add i32 0, 0
store i32 %r1106, i32* %stack_recursiveDepth
%r1108 = add i32 0, 0
store i32 %r1108, i32* %stack_decimalSum
%r1112 = load i32* %stack_binaryNum
%r1114 = load i32* %stack_decimalSum
%r1116 = load i32* %stack_recursiveDepth
%r1110 = call i32 @recursiveDecimalSum(i32 %r1112, i32 %r1114, i32 %r1116)
ret i32 %r1110
}
define i32 @main() {
%stack_number = alloca i32
%stack_waitTime = alloca i32
%evil_scanf = alloca i32
%cast1 = getelementptr [3 x i8]* @.LC2, i64 0, i64 0
call i32 (i8*, ...)* @scanf(i8* %cast1, i32* %evil_scanf)
%r1119 = load i32* %evil_scanf
store i32 %r1119, i32* %stack_number
%r1123 = load i32* %stack_number
%r1121 = call i32 @convertToDecimal(i32 %r1123)
store i32 %r1121, i32* %stack_number
%r1126 = load i32* %stack_number
%r1128 = load i32* %stack_number
%r1124 = mul i32 %r1126, %r1128
store i32 %r1124, i32* %stack_waitTime
br label %L1905
L1905:
%r1131 = load i32* %stack_waitTime
%r1133 = add i32 0, 0
%r1481 = icmp sgt i32 %r1131, %r1133
%r1129 = select i1 %r1481, i32 1, i32 0
%r1482 = icmp eq i32 %r1129, 1
br i1 %r1482, label %L1911, label %L1933
L1911:
%r1135 = load i32* %stack_waitTime
call i32 @wait(i32 %r1135)
%r1138 = load i32* %stack_waitTime
%r1140 = add i32 1, 0
%r1136 = sub i32 %r1138, %r1140
store i32 %r1136, i32* %stack_waitTime
br label %L1905
br label %L1905
L1933:
%r1148 = load i32* %stack_number
%cast2 = getelementptr [4 x i8]* @.LC1, i64 0, i64 0
call i32 (i8*, ...)* @printf(i8* %cast2, i32 %r1148)
%r1150 = add i32 0, 0
ret i32 %r1150
}
	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmpED9.tmp"
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
! BB#1:                                 ! %.L1754_crit_edge
	or %g0, 1, %l0
	ba .LBB1_4
	nop
.LBB1_2:                                ! %.L1727_crit_edge
	or %g0, 1, %l0
.LBB1_3:                                ! %L1727
                                        ! =>This Inner Loop Header: Depth=1
	smul %l0, %i0, %l0
	add %i1, -1, %i1
	subcc %i1, 0, %l1
	bne .LBB1_3
	nop
.LBB1_4:                                ! %L1754
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
! BB#1:                                 ! %.L1851_crit_edge
	ba .LBB2_10
	nop
.LBB2_2:                                ! %L1770
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
! BB#3:                                 ! %L1770.L1828_crit_edge
                                        !   in Loop: Header=BB2_2 Depth=1
	ba .LBB2_9
	nop
.LBB2_4:                                ! %L1807
                                        !   in Loop: Header=BB2_2 Depth=1
	subcc %i2, 0, %l0
	bg .LBB2_6
	nop
! BB#5:                                 ! %L1807.power.exit_crit_edge
                                        !   in Loop: Header=BB2_2 Depth=1
	or %g0, 1, %l0
	ba .LBB2_8
	nop
.LBB2_6:                                ! %L1807.L1727.i_crit_edge
                                        !   in Loop: Header=BB2_2 Depth=1
	or %g0, 1, %l0
	or %g0, %i2, %l1
.LBB2_7:                                ! %L1727.i
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
.LBB2_9:                                ! %L1828
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
.LBB2_10:                               ! %L1851
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
.LBB3_2:                                ! %.L1770.i_crit_edge
	sethi 0, %l1
	or %g0, %l1, %l0
.LBB3_3:                                ! %L1770.i
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
! BB#4:                                 ! %L1770.i.L1828.i_crit_edge
                                        !   in Loop: Header=BB3_3 Depth=1
	ba .LBB3_10
	nop
.LBB3_5:                                ! %L1807.i
                                        !   in Loop: Header=BB3_3 Depth=1
	subcc %l1, 0, %l2
	bg .LBB3_7
	nop
! BB#6:                                 ! %L1807.i.power.exit.i_crit_edge
                                        !   in Loop: Header=BB3_3 Depth=1
	or %g0, 1, %l2
	ba .LBB3_9
	nop
.LBB3_7:                                ! %L1807.i.L1727.i.i_crit_edge
                                        !   in Loop: Header=BB3_3 Depth=1
	or %g0, 1, %l2
	or %g0, %l1, %l3
.LBB3_8:                                ! %L1727.i.i
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
.LBB3_10:                               ! %L1828.i
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
.LBB4_2:                                ! %.L1770.i.i_crit_edge
	sethi 0, %l1
	or %g0, %l1, %o1
.LBB4_3:                                ! %L1770.i.i
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
! BB#4:                                 ! %L1770.i.i.L1828.i.i_crit_edge
                                        !   in Loop: Header=BB4_3 Depth=1
	ba .LBB4_10
	nop
.LBB4_5:                                ! %L1807.i.i
                                        !   in Loop: Header=BB4_3 Depth=1
	subcc %l1, 0, %l2
	bg .LBB4_7
	nop
! BB#6:                                 ! %L1807.i.i.power.exit.i.i_crit_edge
                                        !   in Loop: Header=BB4_3 Depth=1
	or %g0, 1, %l2
	ba .LBB4_9
	nop
.LBB4_7:                                ! %L1807.i.i.L1727.i.i.i_crit_edge
                                        !   in Loop: Header=BB4_3 Depth=1
	or %g0, 1, %l2
	or %g0, %l1, %l3
.LBB4_8:                                ! %L1727.i.i.i
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
.LBB4_10:                               ! %L1828.i.i
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


