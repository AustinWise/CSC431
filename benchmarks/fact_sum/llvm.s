@.LC0 = internal constant [4 x i8] c"%d \00"
@.LC1 = internal constant [4 x i8] c"%d\0A\00"
@.LC2 = internal constant [3 x i8] c"%d\00"
declare i32 @printf(i8*, ...)
declare i32 @scanf(i8*, ...)
define i32 @sum(i32 %a, i32 %b) {
%stack_a = alloca i32
%stack_b = alloca i32
%evil_scanf = alloca i32
store i32 %a, i32* %stack_a
store i32 %b, i32* %stack_b
%r1381 = load i32* %stack_a
%r1383 = load i32* %stack_b
%r1379 = add i32 %r1381, %r1383
ret i32 %r1379
}
define i32 @fact(i32 %n) {
%stack_n = alloca i32
%stack_t = alloca i32
%evil_scanf = alloca i32
store i32 %n, i32* %stack_n
%r1389 = load i32* %stack_n
%r1391 = add i32 1, 0
%r1469 = icmp eq i32 %r1389, %r1391
%r1387 = select i1 %r1469, i32 1, i32 0
%r1394 = load i32* %stack_n
%r1396 = add i32 0, 0
%r1470 = icmp eq i32 %r1394, %r1396
%r1392 = select i1 %r1470, i32 1, i32 0
%r1386 = or i32 %r1387, %r1392
%r1471 = icmp eq i32 %r1386, 1
br i1 %r1471, label %L2367, label %L2372
L2367:
%r1398 = add i32 1, 0
ret i32 %r1398
br label %L2377
L2372:
br label %L2377
br label %L2377
L2377:
%r1402 = load i32* %stack_n
%r1404 = add i32 1, 0
%r1472 = icmp sle i32 %r1402, %r1404
%r1400 = select i1 %r1472, i32 1, i32 0
%r1477 = icmp eq i32 %r1400, 1
br i1 %r1477, label %L2383, label %L2395
L2383:
%r1410 = add i32 1, 0
%r1411 = add i32 0, 0
%r1408 = sub i32 %r1411, %r1410
%r1413 = load i32* %stack_n
%r1407 = mul i32 %r1408, %r1413
%r1406 = call i32 @fact(i32 %r1407)
ret i32 %r1406
br label %L2400
L2395:
br label %L2400
br label %L2400
L2400:
%r1417 = load i32* %stack_n
%r1422 = load i32* %stack_n
%r1424 = add i32 1, 0
%r1420 = sub i32 %r1422, %r1424
%r1419 = call i32 @fact(i32 %r1420)
%r1415 = mul i32 %r1417, %r1419
store i32 %r1415, i32* %stack_t
%r1426 = load i32* %stack_t
ret i32 %r1426
}
define i32 @main() {
%stack_num1 = alloca i32
%stack_num2 = alloca i32
%stack_flag = alloca i32
%evil_scanf = alloca i32
%r1429 = add i32 0, 0
store i32 %r1429, i32* %stack_flag
br label %L2428
L2428:
%r1432 = load i32* %stack_flag
%r1435 = add i32 1, 0
%r1436 = add i32 0, 0
%r1433 = sub i32 %r1436, %r1435
%r1480 = icmp ne i32 %r1432, %r1433
%r1430 = select i1 %r1480, i32 1, i32 0
%r1483 = icmp eq i32 %r1430, 1
br i1 %r1483, label %L2435, label %L2475
L2435:
%cast1 = getelementptr [3 x i8]* @.LC2, i64 0, i64 0
call i32 (i8*, ...)* @scanf(i8* %cast1, i32* %evil_scanf)
%r1438 = load i32* %evil_scanf
store i32 %r1438, i32* %stack_num1
%cast2 = getelementptr [3 x i8]* @.LC2, i64 0, i64 0
call i32 (i8*, ...)* @scanf(i8* %cast2, i32* %evil_scanf)
%r1440 = load i32* %evil_scanf
store i32 %r1440, i32* %stack_num2
%r1444 = load i32* %stack_num1
%r1442 = call i32 @fact(i32 %r1444)
store i32 %r1442, i32* %stack_num1
%r1448 = load i32* %stack_num2
%r1446 = call i32 @fact(i32 %r1448)
store i32 %r1446, i32* %stack_num2
%r1452 = load i32* %stack_num1
%r1454 = load i32* %stack_num2
%r1450 = call i32 @sum(i32 %r1452, i32 %r1454)
%cast3 = getelementptr [4 x i8]* @.LC1, i64 0, i64 0
call i32 (i8*, ...)* @printf(i8* %cast3, i32 %r1450)
%cast4 = getelementptr [3 x i8]* @.LC2, i64 0, i64 0
call i32 (i8*, ...)* @scanf(i8* %cast4, i32* %evil_scanf)
%r1456 = load i32* %evil_scanf
store i32 %r1456, i32* %stack_flag
br label %L2428
br label %L2428
L2475:
%r1466 = add i32 0, 0
ret i32 %r1466
}
	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmpED8.tmp"
	.text
	.globl	sum
	.align	4
	.type	sum,@function
sum:                                    ! @sum
! BB#0:
	save %sp, -96, %sp
	add %i1, %i0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp0:
	.size	sum, .Ltmp0-sum

	.globl	fact
	.align	4
	.type	fact,@function
fact:                                   ! @fact
! BB#0:
	save %sp, -96, %sp
	or %g0, 1, %l0
.LBB1_1:                                ! %tailrecurse
                                        ! =>This Inner Loop Header: Depth=1
	subcc %i0, 1, %l1
	bgu .LBB1_3
	nop
! BB#2:                                 ! %L2367
	or %g0, %l0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.LBB1_3:                                ! %L2377
                                        !   in Loop: Header=BB1_1 Depth=1
	subcc %i0, 1, %l1
	bg .LBB1_5
	nop
! BB#4:                                 ! %L2383
                                        !   in Loop: Header=BB1_1 Depth=1
	sethi 0, %l1
	sub %l1, %i0, %i0
	ba .LBB1_1
	nop
.LBB1_5:                                ! %L2400
                                        !   in Loop: Header=BB1_1 Depth=1
	add %i0, -1, %l1
	smul %i0, %l0, %l0
	or %g0, %l1, %i0
	ba .LBB1_1
	nop
.Ltmp1:
	.size	fact, .Ltmp1-fact

	.globl	main
	.align	4
	.type	main,@function
main:                                   ! @main
! BB#0:
	save %sp, -104, %sp
.LBB2_1:                                ! %L2435
                                        ! =>This Loop Header: Depth=1
                                        !     Child Loop BB2_7 Depth 2
                                        !     Child Loop BB2_2 Depth 2
	sethi %hi(.LC2), %l0
	add %l0, %lo(.LC2), %l0
	add %fp, -4, %l1
	or %g0, %l0, %o0
	or %g0, %l1, %o1
	call scanf
	nop
	ld [%fp+-4], %l2
	or %g0, %l0, %o0
	or %g0, %l1, %o1
	call scanf
	nop
	ld [%fp+-4], %l1
	or %g0, 1, %l3
.LBB2_2:                                ! %tailrecurse.i
                                        !   Parent Loop BB2_1 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	subcc %l2, 1, %l4
	bgu .LBB2_4
	nop
! BB#3:                                 ! %tailrecurse.i.tailrecurse.outer.i3_crit_edge
                                        !   in Loop: Header=BB2_1 Depth=1
	or %g0, 1, %l2
	ba .LBB2_7
	nop
.LBB2_4:                                ! %L2377.i
                                        !   in Loop: Header=BB2_2 Depth=2
	subcc %l2, 1, %l4
	bg .LBB2_6
	nop
! BB#5:                                 ! %L2383.i
                                        !   in Loop: Header=BB2_2 Depth=2
	sethi 0, %l4
	sub %l4, %l2, %l2
	ba .LBB2_2
	nop
.LBB2_6:                                ! %L2400.i
                                        !   in Loop: Header=BB2_2 Depth=2
	add %l2, -1, %l4
	smul %l2, %l3, %l3
	or %g0, %l4, %l2
	ba .LBB2_2
	nop
.LBB2_7:                                ! %tailrecurse.i5
                                        !   Parent Loop BB2_1 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	subcc %l1, 2, %l4
	bcs .LBB2_11
	nop
! BB#8:                                 ! %L2377.i7
                                        !   in Loop: Header=BB2_7 Depth=2
	subcc %l1, 1, %l4
	bg .LBB2_10
	nop
! BB#9:                                 ! %L2383.i9
                                        !   in Loop: Header=BB2_7 Depth=2
	sethi 0, %l4
	sub %l4, %l1, %l1
	ba .LBB2_7
	nop
.LBB2_10:                               ! %L2400.i12
                                        !   in Loop: Header=BB2_7 Depth=2
	add %l1, -1, %l4
	smul %l1, %l2, %l2
	or %g0, %l4, %l1
	ba .LBB2_7
	nop
.LBB2_11:                               ! %fact.exit13
                                        !   in Loop: Header=BB2_1 Depth=1
	sethi %hi(.LC1), %l1
	add %l1, %lo(.LC1), %o0
	add %l2, %l3, %o1
	call printf
	nop
	add %fp, -4, %o1
	or %g0, %l0, %o0
	call scanf
	nop
	ld [%fp+-4], %l0
	subcc %l0, -1, %l0
	bne .LBB2_1
	nop
! BB#12:                                ! %L2475
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


