	.section        ".text"
	.align 4
	.global getIntList
.type    getIntList, #function
getIntList:
save %sp, -104, %sp
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
stw %l0, [%sp + 92]
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 100, %o1
call scanf
nop
ldsw [%sp + 100], %l0
stw %l0, [%sp + 96]
ldsw [%sp + 96], %l2
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l1, %l0
sethi %hi(0), %l1
or %l1, %lo(0), %l1
cmp %l2, %l0
move %icc, 1, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l1, %l0
be %icc, .L76
nop
ba %icc, .L86
nop
.L76:
ldsw [%sp + 92], %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L146
nop
.L86:
ldsw [%sp + 92], %l1
ldsw [%sp + 96], %l0
stw %l0, [%l1 + 0]
ldsw [%sp + 92], %l0
call getIntList
nop
mov %o0, %l1
stw %l1, [%l0 + 4]
ldsw [%sp + 92], %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L146
nop
.L146:
	.size    getIntList, .-getIntList
	.align 4
	.global biggest
.type    biggest, #function
biggest:
save %sp, -104, %sp
mov %i0, %l1
mov %i1, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movg %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L163
nop
ba %icc, .L169
nop
.L163:
mov %i0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L181
nop
.L169:
mov %i1, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L181
nop
.L181:
	.size    biggest, .-biggest
	.align 4
	.global biggestInList
.type    biggestInList, #function
biggestInList:
save %sp, -104, %sp
mov %i0, %l0
ldsw [%l0 + 0], %l0
stw %l0, [%sp + 96]
.L199:
mov %i0, %l0
ldsw [%l0 + 4], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L210
nop
ba %icc, .L262
nop
.L210:
ldsw [%sp + 96], %l1
mov %i0, %l0
ldsw [%l0 + 0], %l0
mov %l1, %o0
mov %l0, %o1
call biggest
nop
mov %o0, %l0
stw %l0, [%sp + 96]
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %i0
ba %icc, .L199
nop
.L262:
ldsw [%sp + 96], %l0
or %l0, 0, %i0
ret
restore
	.size    biggestInList, .-biggestInList
	.align 4
	.global main
.type    main, #function
main:
save %sp, -96, %sp
call getIntList
nop
mov %o0, %l0
stw %l0, [%sp + 92]
ldsw [%sp + 92], %l0
mov %l0, %o0
call biggestInList
nop
mov %o0, %l0
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

