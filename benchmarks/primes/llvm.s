@.LC0 = internal constant [4 x i8] c"%d \00"
@.LC1 = internal constant [4 x i8] c"%d\0A\00"
@.LC2 = internal constant [3 x i8] c"%d\00"
declare i32 @printf(i8*, ...)
declare i32 @scanf(i8*, ...)
define i32 @isqrt(i32 %a) {
%stack_a = alloca i32
%stack_square = alloca i32
%stack_delta = alloca i32
%evil_scanf = alloca i32
store i32 %a, i32* %stack_a
%r2456 = add i32 1, 0
store i32 %r2456, i32* %stack_square
%r2458 = add i32 3, 0
store i32 %r2458, i32* %stack_delta
br label %L4177
L4177:
%r2461 = load i32* %stack_square
%r2463 = load i32* %stack_a
%r2572 = icmp sle i32 %r2461, %r2463
%r2459 = select i1 %r2572, i32 1, i32 0
%r2573 = icmp eq i32 %r2459, 1
br i1 %r2573, label %L4184, label %L4212
L4184:
%r2466 = load i32* %stack_square
%r2468 = load i32* %stack_delta
%r2464 = add i32 %r2466, %r2468
store i32 %r2464, i32* %stack_square
%r2471 = load i32* %stack_delta
%r2473 = add i32 2, 0
%r2469 = add i32 %r2471, %r2473
store i32 %r2469, i32* %stack_delta
br label %L4177
br label %L4177
L4212:
%r2483 = load i32* %stack_delta
%r2485 = add i32 2, 0
%r2481 = sdiv i32 %r2483, %r2485
%r2487 = add i32 1, 0
%r2480 = sub i32 %r2481, %r2487
ret i32 %r2480
}
define i32 @prime(i32 %a) {
%stack_a = alloca i32
%stack_max = alloca i32
%stack_divisor = alloca i32
%stack_remainder = alloca i32
%evil_scanf = alloca i32
store i32 %a, i32* %stack_a
%r2492 = load i32* %stack_a
%r2494 = add i32 2, 0
%r2574 = icmp slt i32 %r2492, %r2494
%r2490 = select i1 %r2574, i32 1, i32 0
%r3890 = icmp eq i32 %r2490, 1
br i1 %r3890, label %L4234, label %L4239
L4234:
%r2496 = add i32 0, 0
ret i32 %r2496
br label %L4317
L4239:
%r2500 = load i32* %stack_a
%r2498 = call i32 @isqrt(i32 %r2500)
store i32 %r2498, i32* %stack_max
%r2502 = add i32 2, 0
store i32 %r2502, i32* %stack_divisor
br label %L4252
L4252:
%r2505 = load i32* %stack_divisor
%r2507 = load i32* %stack_max
%r3891 = icmp sle i32 %r2505, %r2507
%r2503 = select i1 %r3891, i32 1, i32 0
%r3892 = icmp eq i32 %r2503, 1
br i1 %r3892, label %L4259, label %L4311
L4259:
%r2510 = load i32* %stack_a
%r2514 = load i32* %stack_a
%r2516 = load i32* %stack_divisor
%r2512 = sdiv i32 %r2514, %r2516
%r2518 = load i32* %stack_divisor
%r2511 = mul i32 %r2512, %r2518
%r2508 = sub i32 %r2510, %r2511
store i32 %r2508, i32* %stack_remainder
%r2521 = load i32* %stack_remainder
%r2523 = add i32 0, 0
%r3893 = icmp eq i32 %r2521, %r2523
%r2519 = select i1 %r3893, i32 1, i32 0
%r3894 = icmp eq i32 %r2519, 1
br i1 %r3894, label %L4284, label %L4289
L4284:
%r2525 = add i32 0, 0
ret i32 %r2525
br label %L4294
L4289:
br label %L4294
br label %L4294
L4294:
%r2529 = load i32* %stack_divisor
%r2531 = add i32 1, 0
%r2527 = add i32 %r2529, %r2531
store i32 %r2527, i32* %stack_divisor
br label %L4252
br label %L4252
L4311:
%r2539 = add i32 1, 0
ret i32 %r2539
br label %L4317
L4317:
%r2541 = add i32 0, 0
ret i32 %r2541
}
define i32 @main() {
%stack_limit = alloca i32
%stack_a = alloca i32
%evil_scanf = alloca i32
%cast1 = getelementptr [3 x i8]* @.LC2, i64 0, i64 0
call i32 (i8*, ...)* @scanf(i8* %cast1, i32* %evil_scanf)
%r2543 = load i32* %evil_scanf
store i32 %r2543, i32* %stack_limit
%r2545 = add i32 0, 0
store i32 %r2545, i32* %stack_a
br label %L4329
L4329:
%r2548 = load i32* %stack_a
%r2550 = load i32* %stack_limit
%r3895 = icmp sle i32 %r2548, %r2550
%r2546 = select i1 %r3895, i32 1, i32 0
%r3896 = icmp eq i32 %r2546, 1
br i1 %r3896, label %L4336, label %L4371
L4336:
%r2554 = load i32* %stack_a
%r2552 = call i32 @prime(i32 %r2554)
%r3897 = icmp eq i32 %r2552, 1
br i1 %r3897, label %L4343, label %L4349
L4343:
%r2556 = load i32* %stack_a
%cast2 = getelementptr [4 x i8]* @.LC1, i64 0, i64 0
call i32 (i8*, ...)* @printf(i8* %cast2, i32 %r2556)
br label %L4354
br label %L4354
L4349:
br label %L4354
br label %L4354
L4354:
%r2560 = load i32* %stack_a
%r2562 = add i32 1, 0
%r2558 = add i32 %r2560, %r2562
store i32 %r2558, i32* %stack_a
br label %L4329
br label %L4329
L4371:
%r2570 = add i32 0, 0
ret i32 %r2570
}
	.file	"C:\\Users\\AustinWise\\AppData\\Local\\Temp\\tmpFD5.tmp"
	.text
	.globl	isqrt
	.align	4
	.type	isqrt,@function
isqrt:                                  ! @isqrt
! BB#0:
	save %sp, -96, %sp
	subcc %i0, 1, %l0
	bl .LBB0_4
	nop
! BB#1:                                 ! %.L4184_crit_edge
	or %g0, 3, %l0
	or %g0, 1, %l1
.LBB0_2:                                ! %L4184
                                        ! =>This Inner Loop Header: Depth=1
	add %l0, 2, %l2
	add %l0, %l1, %l1
	subcc %l1, %i0, %l0
	or %g0, %l2, %l0
	ble .LBB0_2
	nop
! BB#3:                                 ! %L4177.L4212_crit_edge
	srl %l2, 31, %l0
	add %l2, %l0, %l0
	sra %l0, 1, %l0
	add %l0, -1, %i0
	restore %g0, %g0, %g0
	retl
	nop
.LBB0_4:                                ! %L4212
	sethi 0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp0:
	.size	isqrt, .Ltmp0-isqrt

	.globl	prime
	.align	4
	.type	prime,@function
prime:                                  ! @prime
! BB#0:
	save %sp, -96, %sp
	subcc %i0, 2, %l0
	bl .LBB1_2
	nop
! BB#1:                                 ! %.L4184.i_crit_edge
	sethi 0, %l0
	or %g0, 1, %l1
	ba .LBB1_3
	nop
.LBB1_2:                                ! %L4234
	sethi 0, %i0
	restore %g0, %g0, %g0
	retl
	nop
.LBB1_3:                                ! %L4184.i
                                        ! =>This Inner Loop Header: Depth=1
	add %l1, %l0, %l1
	add %l0, 2, %l0
	add %l1, 3, %l1
	subcc %l1, %i0, %l2
	ble .LBB1_3
	nop
! BB#4:                                 ! %isqrt.exit
	add %l0, 3, %l0
	srl %l0, 31, %l1
	add %l0, %l1, %l0
	sra %l0, 1, %l0
	add %l0, -1, %l0
	or %g0, 2, %l1
.LBB1_5:                                ! %L4252
                                        ! =>This Inner Loop Header: Depth=1
	subcc %l1, %l0, %l2
	bg .LBB1_8
	nop
! BB#6:                                 ! %L4259
                                        !   in Loop: Header=BB1_5 Depth=1
	sra %i0, 31, %l2
	wr %l2, %g0, %y
	sdiv %i0, %l1, %l2
	smul %l2, %l1, %l2
	sub %i0, %l2, %l2
	subcc %l2, 0, %l2
	be .LBB1_2
	nop
! BB#7:                                 ! %L4294
                                        !   in Loop: Header=BB1_5 Depth=1
	add %l1, 1, %l1
	ba .LBB1_5
	nop
.LBB1_8:                                ! %L4311
	or %g0, 1, %i0
	restore %g0, %g0, %g0
	retl
	nop
.Ltmp1:
	.size	prime, .Ltmp1-prime

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
	bl .LBB2_11
	nop
! BB#1:                                 ! %.L4336_crit_edge
	sethi 0, %l1
.LBB2_2:                                ! %L4336
                                        ! =>This Loop Header: Depth=1
                                        !     Child Loop BB2_6 Depth 2
                                        !     Child Loop BB2_4 Depth 2
	subcc %l1, 2, %l2
	bl .LBB2_10
	nop
! BB#3:                                 ! %L4336.L4184.i.i_crit_edge
                                        !   in Loop: Header=BB2_2 Depth=1
	or %g0, 3, %l2
	or %g0, 1, %l3
.LBB2_4:                                ! %L4184.i.i
                                        !   Parent Loop BB2_2 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	add %l2, 2, %l4
	add %l2, %l3, %l3
	subcc %l3, %l1, %l2
	or %g0, %l4, %l2
	ble .LBB2_4
	nop
! BB#5:                                 ! %isqrt.exit.i
                                        !   in Loop: Header=BB2_2 Depth=1
	srl %l4, 31, %l2
	add %l4, %l2, %l2
	sra %l2, 1, %l2
	add %l2, -1, %l2
	or %g0, 2, %l3
.LBB2_6:                                ! %L4252.i
                                        !   Parent Loop BB2_2 Depth=1
                                        ! =>  This Inner Loop Header: Depth=2
	subcc %l3, %l2, %l4
	bg .LBB2_9
	nop
! BB#7:                                 ! %L4259.i
                                        !   in Loop: Header=BB2_6 Depth=2
	sra %l1, 31, %l4
	wr %l4, %g0, %y
	sdiv %l1, %l3, %l4
	smul %l4, %l3, %l4
	sub %l1, %l4, %l4
	subcc %l4, 0, %l4
	be .LBB2_10
	nop
! BB#8:                                 ! %L4294.i
                                        !   in Loop: Header=BB2_6 Depth=2
	add %l3, 1, %l3
	ba .LBB2_6
	nop
.LBB2_9:                                ! %L4343
                                        !   in Loop: Header=BB2_2 Depth=1
	sethi %hi(.LC1), %l2
	add %l2, %lo(.LC1), %o0
	or %g0, %l1, %o1
	call printf
	nop
.LBB2_10:                               ! %L4354
                                        !   in Loop: Header=BB2_2 Depth=1
	add %l1, 1, %l1
	subcc %l1, %l0, %l2
	ble .LBB2_2
	nop
.LBB2_11:                               ! %L4371
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


