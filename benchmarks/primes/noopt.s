	.section        ".text"
	.align 4
	.global isqrt
.type    isqrt, #function
isqrt:
save %sp, -96, %sp
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %l4
sethi %hi(3), %l0
or %l0, %lo(3), %l0
or %l0, 0, %l3
.L21510:
or %l4, 0, %l1
mov %i0, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movle %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L21517
nop
ba %icc, .L21545
nop
.L21517:
or %l4, 0, %l1
or %l3, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %l4
or %l3, 0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
add %l1, %l0, %l0
or %l0, 0, %l3
ba %icc, .L21510
nop
.L21545:
or %l3, 0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sdivx %l1, %l0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
or %l0, 0, %i0
ret
restore
	.size    isqrt, .-isqrt
	.align 4
	.global prime
.type    prime, #function
prime:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L21568
nop
ba %icc, .L21573
nop
.L21568:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L21651
nop
.L21573:
mov %i0, %l0
mov %l0, %o0
call isqrt
nop
mov %o0, %l0
or %l0, 0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
or %l0, 0, %l0
.L21586:
or %l0, 0, %l3
or %l1, 0, %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
movle %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L21593
nop
ba %icc, .L21645
nop
.L21593:
mov %i0, %l4
mov %i0, %l3
or %l0, 0, %l2
sdivx %l3, %l2, %l3
or %l0, 0, %l2
mulx %l3, %l2, %l2
sub %l4, %l2, %l2
or %l2, 0, %l2
or %l2, 0, %l3
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
move %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L21618
nop
ba %icc, .L21623
nop
.L21618:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L21628
nop
.L21623:
ba %icc, .L21628
nop
.L21628:
or %l0, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
or %l0, 0, %l0
ba %icc, .L21586
nop
.L21645:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L21651
nop
.L21651:
	.size    prime, .-prime
	.align 4
	.global main
.type    main, #function
main:
save %sp, -96, %sp
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l0
.L21663:
or %l0, 0, %l3
or %l1, 0, %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
movle %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L21670
nop
ba %icc, .L21705
nop
.L21670:
or %l0, 0, %l2
mov %l2, %o0
call prime
nop
mov %o0, %l3
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l3, %l2
be %icc, .L21677
nop
ba %icc, .L21683
nop
.L21677:
or %l0, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
ba %icc, .L21688
nop
.L21683:
ba %icc, .L21688
nop
.L21688:
or %l0, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
or %l0, 0, %l0
ba %icc, .L21663
nop
.L21705:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
	.size    main, .-main
	.section        ".rodata"
	.align 8
.ConstantString0:
	.asciz  "%d "
	.align 8
.ConstantString1:
	.asciz  "%d\n"
	.align 8
.ConstantString2:
	.asciz  "%d"

