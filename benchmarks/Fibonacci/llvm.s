@.LC0 = internal constant [4 x i8] c"%d \00"
@.LC1 = internal constant [4 x i8] c"%d\0A\00"
@.LC2 = internal constant [3 x i8] c"%d\00"
declare i32 @printf(i8*, ...)
declare i32 @scanf(i8*, ...)
define i32 @computeFib(i32 %input) {
%stack_input = alloca i32
%evil_scanf = alloca i32
store i32 %input, i32* %stack_input
%r1487 = load i32* %stack_input
%r1489 = add i32 0, 0
%r1526 = icmp eq i32 %r1487, %r1489
%r1485 = select i1 %r1526, i32 1, i32 0
%r1527 = icmp eq i32 %r1485, 1
br i1 %r1527, label %L2491, label %L2496
L2491:
%r1491 = add i32 0, 0
ret i32 %r1491
br label %L2535
L2496:
%r1494 = load i32* %stack_input
%r1496 = add i32 2, 0
%r1528 = icmp sle i32 %r1494, %r1496
%r1492 = select i1 %r1528, i32 1, i32 0
%r1529 = icmp eq i32 %r1492, 1
br i1 %r1529, label %L2504, label %L2509
L2504:
%r1498 = add i32 1, 0
ret i32 %r1498
br label %L2533
L2509:
%r1504 = load i32* %stack_input
%r1506 = add i32 1, 0
%r1502 = sub i32 %r1504, %r1506
%r1501 = call i32 @computeFib(i32 %r1502)
%r1511 = load i32* %stack_input
%r1513 = add i32 2, 0
%r1509 = sub i32 %r1511, %r1513
%r1508 = call i32 @computeFib(i32 %r1509)
%r1499 = add i32 %r1501, %r1508
ret i32 %r1499
br label %L2533
L2533:
br label %L2535
br label %L2535
L2535:
%r1516 = add i32 0, 0
ret i32 %r1516
}
define i32 @main() {
%stack_input = alloca i32
%evil_scanf = alloca i32
%cast1 = getelementptr [3 x i8]* @.LC2, i64 0, i64 0
call i32 (i8*, ...)* @scanf(i8* %cast1, i32* %evil_scanf)
%r1518 = load i32* %evil_scanf
store i32 %r1518, i32* %stack_input
%r1522 = load i32* %stack_input
%r1520 = call i32 @computeFib(i32 %r1522)
%cast2 = getelementptr [4 x i8]* @.LC1, i64 0, i64 0
call i32 (i8*, ...)* @printf(i8* %cast2, i32 %r1520)
%r1524 = add i32 0, 0
ret i32 %r1524
}
	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmpF95.tmp"
	.text
	.globl	computeFib
	.align	4
	.type	computeFib,@function
computeFib:                             ! @computeFib
! BB#0:
	save %sp, -96, %sp
	subcc %i0, 0, %l0
	bne .LBB0_2
	nop
! BB#1:                                 ! %L2491
	sethi 0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.LBB0_2:                                ! %L2496
	subcc %i0, 2, %l0
	bg .LBB0_4
	nop
! BB#3:                                 ! %L2504
	or %g0, 1, %i0
	restore %g0, %g0, %g0
	retl
	nop
.LBB0_4:                                ! %L2509
	add %i0, -1, %o0
	call computeFib
	nop
	or %g0, %o0, %l0
	add %i0, -2, %o0
	call computeFib
	nop
	add %o0, %l0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp0:
	.size	computeFib, .Ltmp0-computeFib

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
	ld [%fp+-4], %o0
	sethi %hi(.LC1), %l0
	call computeFib
	nop
	or %g0, %o0, %o1
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


