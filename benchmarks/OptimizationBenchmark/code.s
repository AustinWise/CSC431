	.section        ".text"
	.align 4
	.global constantFolding
.type    constantFolding, #function
constantFolding:
save %sp, -96, %sp
sethi %hi(226), %l0
or %l0, %lo(226), %l0
or %l0, 0, %i0
ret
restore
	.size    constantFolding, .-constantFolding
	.align 4
	.global constantPropagation
.type    constantPropagation, #function
constantPropagation:
save %sp, -96, %sp
sethi %hi(979445511), %l0
or %l0, %lo(979445511), %l0
or %l0, 0, %i0
ret
restore
	.size    constantPropagation, .-constantPropagation
	.align 4
	.global deadCodeElimination
.type    deadCodeElimination, #function
deadCodeElimination:
save %sp, -96, %sp
sethi %hi(11), %l1
or %l1, %lo(11), %l1
sethi %hi(global1), %l0
or %l0, %lo(global1), %l0
stw %l1, [%l0 + 0]
sethi %hi(5), %l1
or %l1, %lo(5), %l1
sethi %hi(global1), %l0
or %l0, %lo(global1), %l0
stw %l1, [%l0 + 0]
sethi %hi(9), %l1
or %l1, %lo(9), %l1
sethi %hi(global1), %l0
or %l0, %lo(global1), %l0
stw %l1, [%l0 + 0]
sethi %hi(38), %l0
or %l0, %lo(38), %l0
or %l0, 0, %i0
ret
restore
	.size    deadCodeElimination, .-deadCodeElimination
	.align 4
	.global sum
.type    sum, #function
sum:
save %sp, -96, %sp
sethi %hi(0), %l3
or %l3, %lo(0), %l3
.L7842:
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movg %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7848
nop
ba %icc, .L7875
nop
.L7848:
or %l3, 0, %l1
mov %i0, %l0
add %l1, %l0, %l0
or %l0, 0, %l3
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l0, %i0
ba %icc, .L7842
nop
.L7875:
or %l3, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    sum, .-sum
	.align 4
	.global doesntModifyGlobals
.type    doesntModifyGlobals, #function
doesntModifyGlobals:
save %sp, -96, %sp
sethi %hi(3), %l0
or %l0, %lo(3), %l0
or %l0, 0, %i0
ret
restore
	.size    doesntModifyGlobals, .-doesntModifyGlobals
	.align 4
	.global interProceduralOptimization
.type    interProceduralOptimization, #function
interProceduralOptimization:
save %sp, -96, %sp
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sethi %hi(global1), %l0
or %l0, %lo(global1), %l0
stw %l1, [%l0 + 0]
sethi %hi(0), %l1
or %l1, %lo(0), %l1
sethi %hi(global2), %l0
or %l0, %lo(global2), %l0
stw %l1, [%l0 + 0]
sethi %hi(0), %l1
or %l1, %lo(0), %l1
sethi %hi(global3), %l0
or %l0, %lo(global3), %l0
stw %l1, [%l0 + 0]
sethi %hi(100), %l0
or %l0, %lo(100), %l0
mov %l0, %o0
call sum
nop
mov %o0, %l0
or %l0, 0, %l3
sethi %hi(global1), %l0
or %l0, %lo(global1), %l0
ldsw [%l0 + 0], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7931
nop
ba %icc, .L7939
nop
.L7931:
sethi %hi(10000), %l0
or %l0, %lo(10000), %l0
mov %l0, %o0
call sum
nop
mov %o0, %l0
or %l0, 0, %l3
ba %icc, .L7982
nop
.L7939:
sethi %hi(global2), %l0
or %l0, %lo(global2), %l0
ldsw [%l0 + 0], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7947
nop
ba %icc, .L7955
nop
.L7947:
sethi %hi(20000), %l0
or %l0, %lo(20000), %l0
mov %l0, %o0
call sum
nop
mov %o0, %l0
or %l0, 0, %l3
ba %icc, .L7960
nop
.L7955:
ba %icc, .L7960
nop
.L7960:
sethi %hi(global3), %l0
or %l0, %lo(global3), %l0
ldsw [%l0 + 0], %l1
sethi %hi(3), %l0
or %l0, %lo(3), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7966
nop
ba %icc, .L7974
nop
.L7966:
sethi %hi(30000), %l0
or %l0, %lo(30000), %l0
mov %l0, %o0
call sum
nop
mov %o0, %l0
or %l0, 0, %l3
ba %icc, .L7980
nop
.L7974:
ba %icc, .L7980
nop
.L7980:
ba %icc, .L7982
nop
.L7982:
or %l3, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    interProceduralOptimization, .-interProceduralOptimization
	.align 4
	.global commonSubexpressionElimination
.type    commonSubexpressionElimination, #function
commonSubexpressionElimination:
save %sp, -96, %sp
sethi %hi(-48796), %l0
or %l0, %lo(-48796), %l0
or %l0, 0, %i0
ret
restore
	.size    commonSubexpressionElimination, .-commonSubexpressionElimination
	.align 4
	.global hoisting
.type    hoisting, #function
hoisting:
save %sp, -96, %sp
sethi %hi(2), %l4
or %l4, %lo(2), %l4
sethi %hi(0), %l3
or %l3, %lo(0), %l3
.L8641:
or %l3, 0, %l1
sethi %hi(1000000), %l0
or %l0, %lo(1000000), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L8647
nop
ba %icc, .L8695
nop
.L8647:
or %l3, 0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
or %l0, 0, %l3
ba %icc, .L8641
nop
.L8695:
or %l4, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    hoisting, .-hoisting
	.align 4
	.global doubleIf
.type    doubleIf, #function
doubleIf:
save %sp, -96, %sp
sethi %hi(1), %l4
or %l4, %lo(1), %l4
or %l4, 0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L8723
nop
ba %icc, .L8766
nop
.L8723:
or %l4, 0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L8735
nop
ba %icc, .L8745
nop
.L8735:
ba %icc, .L8762
nop
.L8745:
ba %icc, .L8762
nop
.L8762:
sethi %hi(50), %l3
or %l3, %lo(50), %l3
ba %icc, .L8771
nop
.L8766:
ba %icc, .L8771
nop
.L8771:
or %l3, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    doubleIf, .-doubleIf
	.align 4
	.global integerDivide
.type    integerDivide, #function
integerDivide:
save %sp, -96, %sp
sethi %hi(736), %l0
or %l0, %lo(736), %l0
or %l0, 0, %i0
ret
restore
	.size    integerDivide, .-integerDivide
	.align 4
	.global association
.type    association, #function
association:
save %sp, -96, %sp
sethi %hi(10), %l0
or %l0, %lo(10), %l0
or %l0, 0, %i0
ret
restore
	.size    association, .-association
	.align 4
	.global tailRecursionHelper
.type    tailRecursionHelper, #function
tailRecursionHelper:
save %sp, -104, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L8959
nop
ba %icc, .L8965
nop
.L8959:
mov %i1, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L8986
nop
.L8965:
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l2
mov %i1, %l1
mov %i0, %l0
add %l1, %l0, %l0
mov %l2, %o0
mov %l0, %o1
call tailRecursionHelper
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L8986
nop
.L8986:
	.size    tailRecursionHelper, .-tailRecursionHelper
	.align 4
	.global tailRecursion
.type    tailRecursion, #function
tailRecursion:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
mov %l1, %o0
mov %l0, %o1
call tailRecursionHelper
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
	.size    tailRecursion, .-tailRecursion
	.align 4
	.global unswitching
.type    unswitching, #function
unswitching:
save %sp, -96, %sp
sethi %hi(1), %l4
or %l4, %lo(1), %l4
sethi %hi(2), %l3
or %l3, %lo(2), %l3
.L9014:
or %l4, 0, %l1
sethi %hi(1000000), %l0
or %l0, %lo(1000000), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L9020
nop
ba %icc, .L9059
nop
.L9020:
or %l3, 0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L9028
nop
ba %icc, .L9038
nop
.L9028:
or %l4, 0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
or %l0, 0, %l4
ba %icc, .L9057
nop
.L9038:
or %l4, 0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
add %l1, %l0, %l0
or %l0, 0, %l4
ba %icc, .L9057
nop
.L9057:
ba %icc, .L9014
nop
.L9059:
or %l4, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    unswitching, .-unswitching
	.align 4
	.global randomCalculation
.type    randomCalculation, #function
randomCalculation:
save %sp, -96, %sp
sethi %hi(0), %l4
or %l4, %lo(0), %l4
sethi %hi(0), %l0
or %l0, %lo(0), %l0
.L9077:
or %l4, 0, %l2
mov %i0, %l1
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l2, %l1
movl %icc, 1, %l3
sethi %hi(1), %l1
or %l1, %lo(1), %l1
cmp %l3, %l1
be %icc, .L9084
nop
ba %icc, .L9190
nop
.L9084:
or %l0, 0, %l1
sethi %hi(19), %l0
or %l0, %lo(19), %l0
add %l1, %l0, %l0
or %l0, 0, %l0
or %l4, 0, %l2
sethi %hi(2), %l1
or %l1, %lo(2), %l1
mulx %l2, %l1, %l1
or %l1, 0, %l4
or %l4, 0, %l2
sethi %hi(2), %l1
or %l1, %lo(2), %l1
sdivx %l2, %l1, %l1
or %l1, 0, %l4
sethi %hi(3), %l2
or %l2, %lo(3), %l2
or %l4, 0, %l1
mulx %l2, %l1, %l1
or %l1, 0, %l4
or %l4, 0, %l2
sethi %hi(3), %l1
or %l1, %lo(3), %l1
sdivx %l2, %l1, %l1
or %l1, 0, %l4
or %l4, 0, %l2
sethi %hi(4), %l1
or %l1, %lo(4), %l1
mulx %l2, %l1, %l1
or %l1, 0, %l4
or %l4, 0, %l2
sethi %hi(4), %l1
or %l1, %lo(4), %l1
sdivx %l2, %l1, %l1
or %l1, 0, %l4
or %l4, 0, %l2
sethi %hi(1), %l1
or %l1, %lo(1), %l1
add %l2, %l1, %l1
or %l1, 0, %l4
ba %icc, .L9077
nop
.L9190:
or %l0, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    randomCalculation, .-randomCalculation
	.align 4
	.global iterativeFibonacci
.type    iterativeFibonacci, #function
iterativeFibonacci:
save %sp, -96, %sp
sethi %hi(-1), %l5
or %l5, %lo(-1), %l5
sethi %hi(1), %l4
or %l4, %lo(1), %l4
sethi %hi(0), %l3
or %l3, %lo(0), %l3
.L9213:
or %l3, 0, %l1
mov %i0, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L9220
nop
ba %icc, .L9258
nop
.L9220:
or %l4, 0, %l1
or %l5, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %l1
or %l4, 0, %l0
or %l0, 0, %l5
or %l1, 0, %l0
or %l0, 0, %l4
or %l3, 0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
or %l0, 0, %l3
ba %icc, .L9213
nop
.L9258:
or %l4, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    iterativeFibonacci, .-iterativeFibonacci
	.align 4
	.global recursiveFibonacci
.type    recursiveFibonacci, #function
recursiveFibonacci:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l1, %l0
movle %icc, 1, %l3
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
or %l3, %l2, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l1, %l0
be %icc, .L9281
nop
ba %icc, .L9287
nop
.L9281:
mov %i0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L9310
nop
.L9287:
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l0, %o0
call recursiveFibonacci
nop
mov %o0, %l0
mov %i0, %l2
sethi %hi(2), %l1
or %l1, %lo(2), %l1
sub %l2, %l1, %l1
mov %l1, %o0
call recursiveFibonacci
nop
mov %o0, %l1
add %l0, %l1, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L9310
nop
.L9310:
	.size    recursiveFibonacci, .-recursiveFibonacci
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
sethi %hi(1), %l0
or %l0, %lo(1), %l0
.L9322:
or %l0, 0, %l3
or %l1, 0, %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
movl %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L9329
nop
ba %icc, .L9481
nop
.L9329:
call constantFolding
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
call constantPropagation
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
call deadCodeElimination
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
call interProceduralOptimization
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
call commonSubexpressionElimination
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
call hoisting
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
call doubleIf
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
call integerDivide
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
call association
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
or %l1, 0, %l3
sethi %hi(1000), %l2
or %l2, %lo(1000), %l2
sdivx %l3, %l2, %l2
mov %l2, %o0
call tailRecursion
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
call unswitching
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
or %l1, 0, %l2
mov %l2, %o0
call randomCalculation
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
or %l1, 0, %l3
sethi %hi(5), %l2
or %l2, %lo(5), %l2
sdivx %l3, %l2, %l2
mov %l2, %o0
call iterativeFibonacci
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
or %l1, 0, %l3
sethi %hi(1000), %l2
or %l2, %lo(1000), %l2
sdivx %l3, %l2, %l2
mov %l2, %o0
call recursiveFibonacci
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
or %l0, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
or %l0, 0, %l0
ba %icc, .L9322
nop
.L9481:
sethi %hi(9999), %l0
or %l0, %lo(9999), %l0
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
	.common global1,4,4
	.common global2,4,4
	.common global3,4,4
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

