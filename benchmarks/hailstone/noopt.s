	.section        ".text"
	.align 4
	.global mod
.type    mod, #function
mod:
save %sp, -96, %sp
mov %i0, %l2
mov %i0, %l1
mov %i1, %l0
sdivx %l1, %l0, %l1
mov %i1, %l0
mulx %l1, %l0, %l0
sub %l2, %l0, %l0
or %l0, 0, %i0
ret
restore
	.size    mod, .-mod
	.align 4
	.global hailstone
.type    hailstone, #function
hailstone:
save %sp, -96, %sp
.L18450:
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l1, %l0
be %icc, .L18451
nop
ba %icc, .L18515
nop
.L18451:
mov %i0, %l0
sethi %hi(.ConstantString0), %o0
or %o0, %lo(.ConstantString0), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
mov %l1, %o0
mov %l0, %o1
call mod
nop
mov %o0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L18467
nop
ba %icc, .L18480
nop
.L18467:
sethi %hi(3), %l1
or %l1, %lo(3), %l1
mov %i0, %l0
mulx %l1, %l0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
mov %l0, %i0
ba %icc, .L18493
nop
.L18480:
mov %i0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sdivx %l1, %l0, %l0
mov %l0, %i0
ba %icc, .L18493
nop
.L18493:
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movle %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L18499
nop
ba %icc, .L18506
nop
.L18499:
mov %i0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
ret
restore
ba %icc, .L18513
nop
.L18506:
ba %icc, .L18513
nop
.L18513:
ba %icc, .L18450
nop
.L18515:
ret
restore
	.size    hailstone, .-hailstone
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
or %l0, 0, %l0
or %l0, 0, %l0
mov %l0, %o0
call hailstone
nop
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

