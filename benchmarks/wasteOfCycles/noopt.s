	.section        ".text"
	.align 4
	.global function
.type    function, #function
function:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movle %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L24233
nop
ba %icc, .L24238
nop
.L24233:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L24243
nop
.L24238:
ba %icc, .L24243
nop
.L24243:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l0
.L24247:
or %l0, 0, %l3
mov %i0, %l2
mov %i0, %l1
mulx %l2, %l1, %l1
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l3, %l1
movl %icc, 1, %l2
sethi %hi(1), %l1
or %l1, %lo(1), %l1
cmp %l2, %l1
be %icc, .L24258
nop
ba %icc, .L24294
nop
.L24258:
or %l0, 0, %l2
mov %i0, %l1
add %l2, %l1, %l1
or %l1, 0, %l1
or %l1, 0, %l1
sethi %hi(.ConstantString0), %o0
or %o0, %lo(.ConstantString0), %o0
mov %l1, %o1
call printf
nop
or %l0, 0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
or %l0, 0, %l0
ba %icc, .L24247
nop
.L24294:
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l0, %o0
call function
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
	.size    function, .-function
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
call function
nop
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
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

