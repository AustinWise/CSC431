	.section        ".text"
	.align 4
	.global isqrt
.type    isqrt, #function
isqrt:
save %sp, -104, %sp
sethi %hi(1), %l0
or %l0, %lo(1), %l0
stw %l0, [%sp + 96]
sethi %hi(3), %l0
or %l0, %lo(3), %l0
stw %l0, [%sp + 100]
.L4177:
ldsw [%sp + 96], %l1
mov %i0, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movle %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L4184
nop
ba %icc, .L4212
nop
.L4184:
ldsw [%sp + 96], %l1
ldsw [%sp + 100], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 96]
ldsw [%sp + 100], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
add %l1, %l0, %l0
stw %l0, [%sp + 100]
ba %icc, .L4177
nop
.L4212:
ldsw [%sp + 100], %l1
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
save %sp, -112, %sp
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
be %icc, .L4234
nop
ba %icc, .L4239
nop
.L4234:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L4317
nop
.L4239:
mov %i0, %l0
mov %l0, %o0
call isqrt
nop
mov %o0, %l0
stw %l0, [%sp + 96]
sethi %hi(2), %l0
or %l0, %lo(2), %l0
stw %l0, [%sp + 100]
.L4252:
ldsw [%sp + 100], %l1
ldsw [%sp + 96], %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movle %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L4259
nop
ba %icc, .L4311
nop
.L4259:
mov %i0, %l2
mov %i0, %l1
ldsw [%sp + 100], %l0
sdivx %l1, %l0, %l1
ldsw [%sp + 100], %l0
mulx %l1, %l0, %l0
sub %l2, %l0, %l0
stw %l0, [%sp + 104]
ldsw [%sp + 104], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L4284
nop
ba %icc, .L4289
nop
.L4284:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L4294
nop
.L4289:
ba %icc, .L4294
nop
.L4294:
ldsw [%sp + 100], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%sp + 100]
ba %icc, .L4252
nop
.L4311:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L4317
nop
.L4317:
	.size    prime, .-prime
	.align 4
	.global main
.type    main, #function
main:
save %sp, -104, %sp
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 100, %o1
call scanf
nop
ldsw [%sp + 100], %l0
stw %l0, [%sp + 92]
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 96]
.L4329:
ldsw [%sp + 96], %l1
ldsw [%sp + 92], %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movle %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L4336
nop
ba %icc, .L4371
nop
.L4336:
ldsw [%sp + 96], %l0
mov %l0, %o0
call prime
nop
mov %o0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l1, %l0
be %icc, .L4343
nop
ba %icc, .L4349
nop
.L4343:
ldsw [%sp + 96], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
ba %icc, .L4354
nop
.L4349:
ba %icc, .L4354
nop
.L4354:
ldsw [%sp + 96], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%sp + 96]
ba %icc, .L4329
nop
.L4371:
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

