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
be %icc, .L15161
nop
ba %icc, .L15166
nop
.L15161:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L15171
nop
.L15166:
ba %icc, .L15171
nop
.L15171:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
.L15175:
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
be %icc, .L15186
nop
ba %icc, .L15222
nop
.L15186:
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
ba %icc, .L15175
nop
.L15222:
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

