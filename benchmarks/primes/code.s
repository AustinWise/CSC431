	.section        ".text"
	.align 4
	.global isqrt
.type    isqrt, #function
isqrt:
save %sp, -96, %sp
sethi %hi(1), %l4
or %l4, %lo(1), %l4
sethi %hi(3), %l3
or %l3, %lo(3), %l3
.L10186:
or %l4, 0, %l1
mov %i0, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movle %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L10193
nop
ba %icc, .L10221
nop
.L10193:
or %l4, 0, %l1
or %l3, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %l4
or %l3, 0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
add %l1, %l0, %l0
or %l0, 0, %l3
ba %icc, .L10186
nop
.L10221:
or %l3, 0, %l0
sra %l0, 1, %l1
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
be %icc, .L10243
nop
ba %icc, .L10248
nop
.L10243:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L10326
nop
.L10248:
mov %i0, %l0
mov %l0, %o0
call isqrt
nop
mov %o0, %l0
or %l0, 0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
.L10261:
or %l0, 0, %l3
or %l1, 0, %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
movle %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L10268
nop
ba %icc, .L10320
nop
.L10268:
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
be %icc, .L10293
nop
ba %icc, .L10298
nop
.L10293:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L10303
nop
.L10298:
ba %icc, .L10303
nop
.L10303:
or %l0, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
or %l0, 0, %l0
ba %icc, .L10261
nop
.L10320:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L10326
nop
.L10326:
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
.L10338:
or %l0, 0, %l3
or %l1, 0, %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
movle %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L10345
nop
ba %icc, .L10380
nop
.L10345:
or %l0, 0, %l2
mov %l2, %o0
call prime
nop
mov %o0, %l3
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l3, %l2
be %icc, .L10352
nop
ba %icc, .L10358
nop
.L10352:
or %l0, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
ba %icc, .L10363
nop
.L10358:
ba %icc, .L10363
nop
.L10363:
or %l0, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
or %l0, 0, %l0
ba %icc, .L10338
nop
.L10380:
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

