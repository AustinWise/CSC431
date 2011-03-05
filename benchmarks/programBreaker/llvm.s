@.LC0 = internal constant [4 x i8] c"%d \00"
@.LC1 = internal constant [4 x i8] c"%d\0A\00"
@.LC2 = internal constant [3 x i8] c"%d\00"
declare i32 @printf(i8*, ...)
declare i32 @scanf(i8*, ...)
define i32 @fun2(i32 %x, i32 %y) {
%stack_x = alloca i32
%stack_y = alloca i32
%evil_scanf = alloca i32
store i32 %x, i32* %stack_x
store i32 %y, i32* %stack_y
%r3902 = load i32* %stack_x
%r3904 = add i32 0, 0
%r4005 = icmp eq i32 %r3902, %r3904
%r3900 = select i1 %r4005, i32 1, i32 0
%r4006 = icmp eq i32 %r3900, 1
br i1 %r4006, label %L6555, label %L6561
L6555:
%r3906 = load i32* %stack_y
ret i32 %r3906
br label %L6578
L6561:
%r3911 = load i32* %stack_x
%r3913 = add i32 1, 0
%r3909 = sub i32 %r3911, %r3913
%r3915 = load i32* %stack_y
%r3908 = call i32 @fun2(i32 %r3909, i32 %r3915)
ret i32 %r3908
br label %L6578
L6578:
%r3917 = add i32 0, 0
ret i32 %r3917
}
define i32 @fun1(i32 %x, i32 %y, i32 %z) {
%stack_x = alloca i32
%stack_y = alloca i32
%stack_z = alloca i32
%stack_retVal = alloca i32
%evil_scanf = alloca i32
store i32 %x, i32* %stack_x
store i32 %y, i32* %stack_y
store i32 %z, i32* %stack_z
%r3926 = add i32 5, 0
%r3928 = add i32 6, 0
%r3924 = add i32 %r3926, %r3928
%r3931 = load i32* %stack_x
%r3933 = add i32 2, 0
%r3929 = mul i32 %r3931, %r3933
%r3923 = sub i32 %r3924, %r3929
%r3936 = add i32 4, 0
%r3938 = load i32* %stack_y
%r3934 = sdiv i32 %r3936, %r3938
%r3922 = add i32 %r3923, %r3934
%r3940 = load i32* %stack_z
%r3921 = add i32 %r3922, %r3940
store i32 %r3921, i32* %stack_retVal
%r3943 = load i32* %stack_retVal
%r3945 = load i32* %stack_y
%r4007 = icmp sgt i32 %r3943, %r3945
%r3941 = select i1 %r4007, i32 1, i32 0
%r4008 = icmp eq i32 %r3941, 1
br i1 %r4008, label %L6616, label %L6627
L6616:
%r3949 = load i32* %stack_retVal
%r3951 = load i32* %stack_x
%r3947 = call i32 @fun2(i32 %r3949, i32 %r3951)
ret i32 %r3947
br label %L6661
L6627:
%r3955 = add i32 5, 0
%r3957 = add i32 6, 0
%r4009 = icmp slt i32 %r3955, %r3957
%r3953 = select i1 %r4009, i32 1, i32 0
%r3960 = load i32* %stack_retVal
%r3962 = load i32* %stack_y
%r4010 = icmp sle i32 %r3960, %r3962
%r3958 = select i1 %r4010, i32 1, i32 0
%r3952 = and i32 %r3953, %r3958
%r4011 = icmp eq i32 %r3952, 1
br i1 %r4011, label %L6642, label %L6653
L6642:
%r3966 = load i32* %stack_retVal
%r3968 = load i32* %stack_y
%r3964 = call i32 @fun2(i32 %r3966, i32 %r3968)
ret i32 %r3964
br label %L6659
L6653:
br label %L6659
br label %L6659
L6659:
br label %L6661
br label %L6661
L6661:
%r3972 = load i32* %stack_retVal
ret i32 %r3972
}
define i32 @main() {
%stack_i = alloca i32
%evil_scanf = alloca i32
%r3975 = add i32 0, 0
store i32 %r3975, i32* %stack_i
%cast1 = getelementptr [3 x i8]* @.LC2, i64 0, i64 0
call i32 (i8*, ...)* @scanf(i8* %cast1, i32* %evil_scanf)
%r3977 = load i32* %evil_scanf
store i32 %r3977, i32* %stack_i
br label %L6677
L6677:
%r3980 = load i32* %stack_i
%r3982 = add i32 10000, 0
%r4012 = icmp slt i32 %r3980, %r3982
%r3978 = select i1 %r4012, i32 1, i32 0
%r4013 = icmp eq i32 %r3978, 1
br i1 %r4013, label %L6683, label %L6711
L6683:
%r3986 = add i32 3, 0
%r3988 = load i32* %stack_i
%r3990 = add i32 5, 0
%r3984 = call i32 @fun1(i32 %r3986, i32 %r3988, i32 %r3990)
%cast2 = getelementptr [4 x i8]* @.LC1, i64 0, i64 0
call i32 (i8*, ...)* @printf(i8* %cast2, i32 %r3984)
%r3993 = load i32* %stack_i
%r3995 = add i32 1, 0
%r3991 = add i32 %r3993, %r3995
store i32 %r3991, i32* %stack_i
br label %L6677
br label %L6677
L6711:
%r4003 = add i32 0, 0
ret i32 %r4003
}
	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmpFD6.tmp"
	.text
	.globl	fun2
	.align	4
	.type	fun2,@function
fun2:                                   ! @fun2
! BB#0:
	save %sp, -96, %sp
	or %g0, %i1, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp0:
	.size	fun2, .Ltmp0-fun2

	.globl	fun1
	.align	4
	.type	fun1,@function
fun1:                                   ! @fun1
! BB#0:                                 ! %L6616
	save %sp, -96, %sp
	or %g0, 4, %l0
	sra %l0, 31, %l1
	wr %l1, %g0, %y
	sdiv %l0, %i1, %l0
	movg %icc, %i0, %i1
	or %g0, %i1, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp1:
	.size	fun1, .Ltmp1-fun1

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
	ld [%fp+-4], %o1
	sethi 9, %l0
	or %l0, 783, %l1
	subcc %o1, %l1, %l1
	bg .LBB2_2
	nop
.LBB2_1:                                ! %L6683
                                        ! =>This Inner Loop Header: Depth=1
	or %g0, 4, %l1
	sra %l1, 31, %l2
	wr %l2, %g0, %y
	sdiv %l1, %o1, %l1
	sethi %hi(.LC1), %l1
	add %o1, 1, %l2
	add %l1, %lo(.LC1), %o0
	movg %icc, 3, %o1
	call printf
	nop
	or %l0, 784, %l1
	subcc %l2, %l1, %l1
	or %g0, %l2, %o1
	bne .LBB2_1
	nop
.LBB2_2:                                ! %L6711
	sethi 0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp2:
	.size	main, .Ltmp2-main

	.type	.LC1,@object            ! @.LC1
	.section	.rodata.str1.1,"aMS",@progbits,1
.LC1:
	.asciz	 "%d\n"
	.size	.LC1, 4

	.type	.LC2,@object            ! @.LC2
.LC2:
	.asciz	 "%d"
	.size	.LC2, 3


