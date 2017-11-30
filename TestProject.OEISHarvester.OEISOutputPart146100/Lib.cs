using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A175405
{
public static readonly long[] Value={ 1L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,24L,26L,27L,28L,30L,33L,35L,36L,37L,38L,39L,40L,42L,43L,44L,45L,46L,47L,48L,49L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175405Inst : IEnumerable<long>
{
public static readonly long[] Value=A175405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175405.Bytes);
public long this[int i]=>Value[i];

public static A175405Inst Instance=new A175405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175406
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,4L,5L,5L,6L,7L,7L,8L,9L,10L,10L,11L,12L,12L,13L,14L,14L,15L,16L,16L,17L,18L,19L,19L,20L,21L,21L,22L,23L,23L,24L,25L,25L,26L,27L,28L,28L,29L,30L,30L,31L,32L,32L,33L,34L,35L,35L,36L,37L,37L,38L,39L,39L,40L,41L,41L,42L,43L,44L,44L,45L,46L,46L,47L,48L,48L,49L,50L,50L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175406Inst : IEnumerable<long>
{
public static readonly long[] Value=A175406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175406.Bytes);
public long this[int i]=>Value[i];

public static A175406Inst Instance=new A175406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175407
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175407Inst : IEnumerable<long>
{
public static readonly long[] Value=A175407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175407.Bytes);
public long this[int i]=>Value[i];

public static A175407Inst Instance=new A175407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175408
{
public static readonly long[] Value={ 1L,7L,2L,6L,3L,5L,4L,4L,5L,3L,1L,7L,2L,6L,3L,5L,4L,4L,5L,3L,1L,7L,2L,6L,3L,5L,4L,4L,5L,3L,1L,7L,2L,6L,3L,5L,4L,4L,5L,3L,1L,7L,2L,6L,3L,5L,4L,4L,5L,3L,1L,7L,2L,6L,3L,5L,4L,4L,5L,3L,1L,7L,2L,6L,3L,5L,4L,4L,5L,3L,1L,7L,2L,6L,3L,5L,4L,4L,5L,3L,1L,7L,2L,6L,3L,5L,4L,4L,5L,3L,1L,7L,2L,6L,3L,5L,4L,4L,5L,3L,1L,7L,2L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175408Inst : IEnumerable<long>
{
public static readonly long[] Value=A175408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175408.Bytes);
public long this[int i]=>Value[i];

public static A175408Inst Instance=new A175408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175409
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175409Inst : IEnumerable<long>
{
public static readonly long[] Value=A175409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175409.Bytes);
public long this[int i]=>Value[i];

public static A175409Inst Instance=new A175409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175410
{
public static readonly BigInteger[] Value={ 132L,27060L,5269320L,1022496552L,198362899020L,38481433358940L,7465200453136272L,1448210416843244880L,BigInteger.Parse("280945355811546307860"),BigInteger.Parse("54501950819034511436292"),BigInteger.Parse("10573097513564898455783640") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175410Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175410.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175410Inst Instance=new A175410Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175411
{
public static readonly long[] Value={ 1L,8L,864L,4037074L,1401598598400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175411Inst : IEnumerable<long>
{
public static readonly long[] Value=A175411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175411.Bytes);
public long this[int i]=>Value[i];

public static A175411Inst Instance=new A175411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175412
{
public static readonly long[] Value={ 7L,11L,13L,17L,23L,29L,31L,37L,53L,59L,67L,71L,79L,89L,97L,101L,139L,173L,179L,193L,199L,227L,251L,271L,277L,313L,331L,347L,359L,397L,401L,419L,449L,457L,479L,491L,557L,607L,613L,619L,653L,659L,673L,683L,727L,739L,751L,757L,761L,809L,811L,821L,863L,877L,1093L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175412Inst : IEnumerable<long>
{
public static readonly long[] Value=A175412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175412.Bytes);
public long this[int i]=>Value[i];

public static A175412Inst Instance=new A175412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175413
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,11L,12L,13L,14L,15L,16L,19L,23L,24L,25L,28L,29L,30L,31L,32L,35L,38L,39L,44L,47L,48L,49L,50L,52L,55L,56L,57L,59L,60L,61L,62L,63L,64L,67L,70L,71L,78L,79L,88L,92L,95L,96L,97L,98L,103L,104L,111L,112L,113L,114L,115L,116L,120L,121L,123L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175413Inst : IEnumerable<long>
{
public static readonly long[] Value=A175413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175413.Bytes);
public long this[int i]=>Value[i];

public static A175413Inst Instance=new A175413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175414
{
public static readonly long[] Value={ 2L,11L,12L,13L,19L,23L,25L,29L,38L,44L,47L,50L,52L,56L,61L,70L,71L,78L,88L,92L,95L,98L,103L,104L,113L,114L,115L,116L,125L,134L,140L,142L,152L,158L,176L,184L,188L,191L,194L,196L,199L,200L,206L,207L,208L,220L,226L,227L,230L,232L,236L,240L,242L,243L,244L,253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175414Inst : IEnumerable<long>
{
public static readonly long[] Value=A175414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175414.Bytes);
public long this[int i]=>Value[i];

public static A175414Inst Instance=new A175414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175415
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,9L,10L,11L,12L,13L,15L,21L,31L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,63L,85L,127L,132L,133L,134L,144L,146L,147L,148L,149L,150L,153L,154L,155L,158L,161L,164L,165L,166L,169L,170L,171L,172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175415Inst : IEnumerable<long>
{
public static readonly long[] Value=A175415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175415.Bytes);
public long this[int i]=>Value[i];

public static A175415Inst Instance=new A175415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175416
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,8L,10L,14L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,32L,42L,62L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175416Inst : IEnumerable<long>
{
public static readonly long[] Value=A175416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175416.Bytes);
public long this[int i]=>Value[i];

public static A175416Inst Instance=new A175416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175417
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,1L,1L,0L,3L,1L,1L,0L,1L,0L,0L,-2L,2L,1L,0L,-1L,0L,-2L,-2L,-3L,-1L,-3L,-3L,-6L,-5L,-6L,-7L,-8L,-3L,-5L,-5L,-7L,-7L,-8L,-8L,-10L,-8L,-9L,-10L,-11L,-10L,-13L,-13L,-14L,-11L,-13L,-14L,-16L,-15L,-16L,-18L,-20L,-18L,-20L,-20L,-21L,-21L,-22L,-22L,-25L,-19L,-21L,-22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175417Inst : IEnumerable<long>
{
public static readonly long[] Value=A175417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175417.Bytes);
public long this[int i]=>Value[i];

public static A175417Inst Instance=new A175417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175418
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,8L,9L,11L,13L,15L,16L,17L,19L,20L,21L,23L,25L,27L,29L,31L,32L,33L,35L,37L,39L,41L,42L,43L,44L,45L,47L,49L,50L,51L,53L,55L,57L,59L,60L,61L,63L,64L,65L,67L,68L,69L,71L,73L,76L,77L,78L,79L,81L,83L,84L,85L,87L,89L,91L,92L,93L,95L,97L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175418Inst : IEnumerable<long>
{
public static readonly long[] Value=A175418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175418.Bytes);
public long this[int i]=>Value[i];

public static A175418Inst Instance=new A175418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175419
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,4L,9L,6L,-1L,-1L,1L,1L,1L,0L,1L,8L,1L,1L,-1L,-1L,1L,8L,1L,0L,1L,6L,1L,1L,1L,1L,1L,1L,1L,0L,1L,8L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,8L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175419Inst : IEnumerable<long>
{
public static readonly long[] Value=A175419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175419.Bytes);
public long this[int i]=>Value[i];

public static A175419Inst Instance=new A175419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175420
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,4L,9L,16L,25L,36L,49L,64L,81L,0L,1L,8L,27L,64L,125L,216L,343L,512L,729L,0L,1L,16L,81L,256L,625L,1296L,2401L,4096L,6561L,0L,1L,32L,243L,1024L,3125L,7776L,16807L,32768L,59049L,0L,1L,64L,729L,4096L,15625L,46656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175420Inst : IEnumerable<long>
{
public static readonly long[] Value=A175420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175420.Bytes);
public long this[int i]=>Value[i];

public static A175420Inst Instance=new A175420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175421
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,4L,9L,6L,25L,216L,6561L,4096L,1L,0L,1L,8L,49L,4096L,25L,36L,531441L,32L,22876792454961L,0L,1L,6L,1L,60466176L,244140625L,101559956668416L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175421Inst : IEnumerable<long>
{
public static readonly long[] Value=A175421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175421.Bytes);
public long this[int i]=>Value[i];

public static A175421Inst Instance=new A175421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175422
{
public static readonly BigInteger[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,4L,9L,6L,25L,36L,1L,1L,1L,0L,1L,8L,6561L,1L,25L,216L,1L,8L,1L,0L,1L,6L,1L,1L,1L,1L,1L,1L,1L,0L,1L,8L,1L,1L,BigInteger.Parse("867361737988403547205962240695953369140625"),1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175422Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175422.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175422Inst Instance=new A175422Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175423
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,4L,9L,6L,25L,216L,1L,1L,1L,0L,1L,8L,1L,1L,25L,36L,1L,8L,1L,0L,1L,6L,1L,1L,1L,1L,1L,1L,1L,0L,1L,8L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,8L,1L,1L,1L,1L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175423Inst : IEnumerable<long>
{
public static readonly long[] Value=A175423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175423.Bytes);
public long this[int i]=>Value[i];

public static A175423Inst Instance=new A175423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175424
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,-1L,-1L,3L,3L,2L,1L,1L,1L,4L,3L,-1L,-1L,3L,3L,3L,1L,1L,2L,2L,3L,3L,3L,2L,2L,2L,1L,1L,2L,3L,2L,4L,3L,2L,3L,2L,1L,1L,3L,3L,2L,3L,3L,3L,3L,2L,1L,1L,4L,3L,3L,3L,3L,3L,2L,3L,1L,1L,3L,2L,3L,2L,3L,2L,2L,2L,1L,1L,3L,3L,3L,3L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175424Inst : IEnumerable<long>
{
public static readonly long[] Value=A175424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175424.Bytes);
public long this[int i]=>Value[i];

public static A175424Inst Instance=new A175424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175425
{
public static readonly long[] Value={ 0L,10L,24L,27L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175425Inst : IEnumerable<long>
{
public static readonly long[] Value=A175425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175425.Bytes);
public long this[int i]=>Value[i];

public static A175425Inst Instance=new A175425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175426
{
public static readonly long[] Value={ 25L,26L,35L,36L,125L,126L,135L,136L,215L,216L,315L,316L,1125L,1126L,1135L,1136L,1215L,1216L,1315L,1316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175426Inst : IEnumerable<long>
{
public static readonly long[] Value=A175426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175426.Bytes);
public long this[int i]=>Value[i];

public static A175426Inst Instance=new A175426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175427
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,27L,28L,29L,30L,31L,32L,33L,34L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175427Inst : IEnumerable<long>
{
public static readonly long[] Value=A175427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175427.Bytes);
public long this[int i]=>Value[i];

public static A175427Inst Instance=new A175427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175428
{
public static readonly long[] Value={ 1L,7L,20L,44L,81L,135L,208L,8L,19L,45L,80L,136L,207L,9L,18L,46L,79L,137L,206L,10L,17L,47L,78L,138L,205L,11L,16L,48L,77L,139L,204L,12L,15L,49L,76L,140L,203L,13L,14L,50L,75L,141L,202L,310L,33L,31L,94L,122L,3L,5L,22L,42L,83L,133L,210L,6L,2L,25L,39L,86L,130L,213L,299L,430L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175428Inst : IEnumerable<long>
{
public static readonly long[] Value=A175428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175428.Bytes);
public long this[int i]=>Value[i];

public static A175428Inst Instance=new A175428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175429
{
public static readonly long[] Value={ 1L,1L,1L,8L,20L,112L,608L,4436L,34843L,0L,4785242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175429Inst : IEnumerable<long>
{
public static readonly long[] Value=A175429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175429.Bytes);
public long this[int i]=>Value[i];

public static A175429Inst Instance=new A175429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175430
{
public static readonly BigInteger[] Value={ 2L,6L,48L,720L,17280L,604800L,29030400L,1828915200L,146313216000L,14485008384000L,1738201006080000L,248562743869440000L,BigInteger.Parse("41758540970065920000"),BigInteger.Parse("8142915489162854400000"),BigInteger.Parse("1824013069572479385600000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175430Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175430.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175430Inst Instance=new A175430Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175431
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,23L,24L,25L,26L,27L,28L,29L,30L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,67L,68L,69L,71L,72L,73L,74L,75L,76L,77L,78L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175431Inst : IEnumerable<long>
{
public static readonly long[] Value=A175431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175431.Bytes);
public long this[int i]=>Value[i];

public static A175431Inst Instance=new A175431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175432
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,2L,1L,1L,1L,1L,1L,1L,1L,1L,5L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,7L,2L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175432Inst : IEnumerable<long>
{
public static readonly long[] Value=A175432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175432.Bytes);
public long this[int i]=>Value[i];

public static A175432Inst Instance=new A175432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175433
{
public static readonly long[] Value={ 1L,3L,2L,7L,6L,12L,2L,15L,13L,18L,12L,28L,14L,24L,24L,31L,18L,39L,20L,42L,2L,6L,24L,60L,31L,42L,40L,56L,30L,72L,2L,63L,48L,54L,48L,91L,38L,60L,56L,90L,42L,96L,44L,84L,78L,72L,48L,124L,57L,93L,72L,98L,54L,120L,72L,120L,80L,90L,60L,168L,62L,96L,104L,127L,84L,12L,68L,126L,96L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175433Inst : IEnumerable<long>
{
public static readonly long[] Value=A175433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175433.Bytes);
public long this[int i]=>Value[i];

public static A175433Inst Instance=new A175433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175434
{
public static readonly long[] Value={ 0L,0L,2L,3L,0L,4L,4L,5L,8L,7L,3L,7L,7L,8L,11L,9L,14L,1L,10L,11L,5L,3L,18L,13L,4L,14L,8L,15L,12L,7L,16L,26L,29L,27L,24L,28L,19L,29L,32L,21L,9L,4L,13L,14L,17L,24L,21L,25L,16L,26L,29L,27L,24L,28L,37L,29L,23L,12L,18L,22L,13L,23L,26L,24L,21L,43L,43L,35L,20L,0L,15L,37L,37L,56L,50L,30L,27L,22L,31L,32L,26L,42L,39L,34L,43L,26L,20L,27L,24L,28L,55L,47L,32L,57L,45L,31L,40L,14L,8L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175434Inst : IEnumerable<long>
{
public static readonly long[] Value=A175434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175434.Bytes);
public long this[int i]=>Value[i];

public static A175434Inst Instance=new A175434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175435
{
public static readonly long[] Value={ 0L,1L,0L,1L,4L,0L,4L,2L,0L,7L,5L,6L,1L,3L,6L,11L,10L,9L,17L,5L,6L,1L,8L,6L,13L,11L,0L,16L,14L,3L,19L,31L,6L,31L,11L,9L,16L,14L,3L,10L,17L,6L,22L,2L,9L,16L,32L,21L,10L,44L,15L,13L,29L,0L,35L,34L,51L,10L,58L,39L,13L,29L,27L,16L,5L,51L,28L,17L,15L,4L,38L,18L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175435Inst : IEnumerable<long>
{
public static readonly long[] Value=A175435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175435.Bytes);
public long this[int i]=>Value[i];

public static A175435Inst Instance=new A175435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175436
{
public static readonly long[] Value={ 1L,4L,10L,12L,24L,44L,50L,80L,96L,120L,144L,160L,192L,200L,240L,280L,320L,336L,352L,400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175436Inst : IEnumerable<long>
{
public static readonly long[] Value=A175436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175436.Bytes);
public long this[int i]=>Value[i];

public static A175436Inst Instance=new A175436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175437
{
public static readonly long[] Value={ 1L,2L,6L,10L,11L,26L,46L,71L,86L,131L,191L,206L,311L,371L,446L,506L,731L,866L,926L,971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175437Inst : IEnumerable<long>
{
public static readonly long[] Value=A175437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175437.Bytes);
public long this[int i]=>Value[i];

public static A175437Inst Instance=new A175437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175438
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,19L,23L,29L,37L,41L,43L,47L,59L,61L,67L,79L,83L,89L,103L,107L,109L,127L,137L,139L,149L,157L,163L,167L,179L,239L,241L,257L,263L,269L,281L,283L,307L,347L,349L,359L,367L,379L,389L,419L,439L,457L,461L,463L,467L,479L,487L,509L,547L,569L,587L,613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175438Inst : IEnumerable<long>
{
public static readonly long[] Value=A175438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175438.Bytes);
public long this[int i]=>Value[i];

public static A175438Inst Instance=new A175438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175439
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,10L,12L,13L,14L,15L,17L,18L,19L,22L,23L,24L,27L,28L,29L,31L,33L,34L,35L,37L,38L,39L,41L,52L,53L,55L,56L,57L,60L,61L,63L,69L,70L,72L,73L,75L,77L,81L,85L,88L,89L,90L,91L,92L,93L,97L,101L,104L,107L,112L,113L,114L,120L,124L,127L,136L,146L,148L,149L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175439Inst : IEnumerable<long>
{
public static readonly long[] Value=A175439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175439.Bytes);
public long this[int i]=>Value[i];

public static A175439Inst Instance=new A175439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175440
{
public static readonly long[] Value={ 9L,33L,48L,66L,87L,99L,117L,216L,273L,288L,297L,333L,484L,513L,528L,666L,783L,819L,999L,1323L,1331L,1452L,1474L,1602L,2178L,2622L,3333L,4884L,4961L,6666L,7161L,7575L,9999L,10989L,11979L,12969L,14652L,14733L,15972L,20402L,21021L,21534L,21648L,23331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175440Inst : IEnumerable<long>
{
public static readonly long[] Value=A175440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175440.Bytes);
public long this[int i]=>Value[i];

public static A175440Inst Instance=new A175440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175441
{
public static readonly long[] Value={ 1L,3L,11L,25L,137L,49L,363L,761L,7129L,7381L,83711L,86021L,1145993L,1171733L,1195757L,2436559L,42142223L,14274301L,275295799L,11167027L,18858053L,19093197L,444316699L,1347822955L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175441Inst : IEnumerable<long>
{
public static readonly long[] Value=A175441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175441.Bytes);
public long this[int i]=>Value[i];

public static A175441Inst Instance=new A175441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175442
{
public static readonly long[] Value={ 2L,7L,11L,13L,17L,19L,23L,31L,41L,43L,47L,61L,71L,73L,83L,97L,101L,103L,107L,109L,113L,127L,131L,139L,149L,151L,167L,181L,191L,193L,197L,199L,227L,229L,233L,241L,251L,271L,281L,283L,293L,307L,311L,313L,317L,331L,347L,349L,353L,367L,383L,397L,401L,409L,419L,421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175442Inst : IEnumerable<long>
{
public static readonly long[] Value=A175442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175442.Bytes);
public long this[int i]=>Value[i];

public static A175442Inst Instance=new A175442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175443
{
public static readonly long[] Value={ 2L,3L,7L,13L,17L,23L,37L,43L,47L,53L,67L,73L,97L,103L,107L,113L,127L,163L,167L,173L,197L,223L,227L,233L,257L,263L,277L,283L,307L,313L,317L,353L,367L,373L,397L,433L,457L,463L,467L,503L,547L,563L,577L,593L,607L,613L,617L,643L,647L,653L,677L,683L,727L,733L,757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175443Inst : IEnumerable<long>
{
public static readonly long[] Value=A175443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175443.Bytes);
public long this[int i]=>Value[i];

public static A175443Inst Instance=new A175443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175444
{
public static readonly long[] Value={ 2L,5L,23L,47L,79L,89L,107L,131L,149L,173L,191L,229L,233L,257L,317L,383L,401L,439L,443L,467L,499L,509L,541L,593L,653L,677L,709L,719L,751L,761L,821L,859L,863L,887L,919L,929L,947L,971L,1031L,1069L,1087L,1097L,1129L,1153L,1171L,1181L,1213L,1223L,1283L,1307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175444Inst : IEnumerable<long>
{
public static readonly long[] Value=A175444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175444.Bytes);
public long this[int i]=>Value[i];

public static A175444Inst Instance=new A175444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175445
{
public static readonly long[] Value={ 2L,7L,11L,43L,47L,61L,83L,97L,101L,151L,173L,223L,227L,241L,263L,277L,281L,313L,317L,331L,353L,367L,389L,421L,443L,457L,461L,547L,569L,601L,641L,673L,677L,691L,821L,853L,857L,907L,911L,997L,1019L,1033L,1091L,1123L,1163L,1213L,1217L,1231L,1289L,1303L,1307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175445Inst : IEnumerable<long>
{
public static readonly long[] Value=A175445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175445.Bytes);
public long this[int i]=>Value[i];

public static A175445Inst Instance=new A175445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175446
{
public static readonly long[] Value={ 2L,31L,79L,97L,101L,163L,167L,229L,233L,251L,277L,317L,409L,449L,541L,647L,673L,691L,739L,757L,761L,823L,827L,911L,937L,977L,1069L,1087L,1091L,1109L,1201L,1307L,1399L,1439L,1487L,1549L,1553L,1571L,1597L,1637L,1663L,1747L,1861L,1879L,1949L,2011L,2081L,2099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175446Inst : IEnumerable<long>
{
public static readonly long[] Value=A175446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175446.Bytes);
public long this[int i]=>Value[i];

public static A175446Inst Instance=new A175446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175447
{
public static readonly long[] Value={ 2L,11L,41L,89L,197L,271L,353L,401L,431L,479L,509L,557L,587L,661L,691L,739L,743L,947L,977L,1051L,1237L,1259L,1289L,1493L,1523L,1571L,1601L,1753L,1783L,1831L,1861L,1987L,2017L,2039L,2069L,2143L,2251L,2273L,2381L,2663L,2693L,2741L,2797L,2819L,2927L,3001L,3083L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175447Inst : IEnumerable<long>
{
public static readonly long[] Value=A175447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175447.Bytes);
public long this[int i]=>Value[i];

public static A175447Inst Instance=new A175447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175448
{
public static readonly long[] Value={ 2L,13L,17L,43L,47L,73L,107L,163L,167L,193L,197L,223L,227L,283L,317L,373L,467L,523L,557L,613L,617L,643L,647L,673L,677L,733L,797L,823L,827L,853L,857L,883L,887L,1033L,1097L,1123L,1187L,1213L,1217L,1303L,1307L,1423L,1427L,1453L,1487L,1543L,1607L,1663L,1667L,1693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175448Inst : IEnumerable<long>
{
public static readonly long[] Value=A175448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175448.Bytes);
public long this[int i]=>Value[i];

public static A175448Inst Instance=new A175448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175449
{
public static readonly long[] Value={ 2L,83L,223L,389L,461L,491L,563L,593L,631L,661L,733L,797L,937L,967L,971L,1069L,1277L,1307L,1447L,1511L,1549L,1579L,1583L,1613L,1753L,1783L,1787L,1987L,2161L,2293L,2297L,2531L,2671L,2803L,2909L,2939L,3011L,3041L,3079L,3109L,3181L,3313L,3623L,3823L,3929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175449Inst : IEnumerable<long>
{
public static readonly long[] Value=A175449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175449.Bytes);
public long this[int i]=>Value[i];

public static A175449Inst Instance=new A175449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175450
{
public static readonly long[] Value={ 2L,17L,59L,131L,173L,283L,401L,587L,743L,853L,857L,929L,971L,1423L,1427L,1499L,1579L,1613L,1693L,1879L,1997L,2069L,2111L,2221L,2339L,2411L,2719L,2753L,2833L,3019L,3023L,3209L,3251L,3323L,3517L,3779L,3821L,3931L,4049L,4159L,4201L,4273L,4391L,4463L,4657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175450Inst : IEnumerable<long>
{
public static readonly long[] Value=A175450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175450.Bytes);
public long this[int i]=>Value[i];

public static A175450Inst Instance=new A175450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175451
{
public static readonly long[] Value={ 2L,19L,23L,61L,107L,229L,233L,271L,317L,397L,401L,439L,443L,523L,569L,607L,653L,691L,821L,859L,863L,1069L,1283L,1321L,1367L,1447L,1451L,1489L,1493L,1531L,1619L,1657L,1787L,1867L,1871L,1951L,1997L,2161L,2207L,2287L,2333L,2371L,2417L,2539L,2543L,2707L,2711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175451Inst : IEnumerable<long>
{
public static readonly long[] Value=A175451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175451.Bytes);
public long this[int i]=>Value[i];

public static A175451Inst Instance=new A175451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175452
{
public static readonly long[] Value={ 7L,3L,5L,7L,31L,11L,13L,83L,17L,19L,67L,23L,79L,317L,29L,31L,103L,109L,37L,367L,41L,43L,139L,47L,151L,157L,53L,283L,293L,59L,61L,193L,199L,67L,211L,71L,73L,229L,709L,79L,911L,83L,433L,443L,89L,277L,283L,677L,97L,503L,101L,103L,2459L,107L,109L,337L,113L,349L,593L,1087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175452Inst : IEnumerable<long>
{
public static readonly long[] Value=A175452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175452.Bytes);
public long this[int i]=>Value[i];

public static A175452Inst Instance=new A175452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175453
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,3L,2L,3L,4L,4L,4L,4L,4L,3L,3L,4L,4L,5L,5L,5L,5L,5L,4L,4L,5L,5L,5L,4L,4L,4L,3L,4L,5L,5L,5L,6L,6L,6L,5L,5L,6L,6L,6L,6L,6L,5L,5L,5L,5L,6L,6L,6L,6L,6L,5L,4L,5L,5L,5L,5L,5L,4L,3L,4L,5L,6L,6L,6L,6L,6L,5L,6L,7L,7L,7L,7L,7L,6L,6L,6L,6L,7L,7L,7L,7L,7L,6L,6L,7L,7L,7L,6L,6L,6L,5L,5L,6L,6L,6L,7L,7L,7L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175453Inst : IEnumerable<long>
{
public static readonly long[] Value=A175453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175453.Bytes);
public long this[int i]=>Value[i];

public static A175453Inst Instance=new A175453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175454
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,3L,6L,6L,3L,5L,5L,3L,9L,12L,4L,5L,5L,5L,15L,9L,3L,7L,14L,6L,9L,15L,5L,7L,7L,5L,15L,9L,9L,24L,8L,3L,9L,21L,7L,7L,7L,5L,25L,15L,3L,9L,18L,10L,15L,15L,5L,7L,21L,21L,21L,9L,3L,11L,11L,3L,15L,30L,18L,21L,7L,5L,15L,21L,7L,11L,11L,3L,15L,25L,15L,21L,7L,9L,36L,12L,3L,11L,33L,9L,9L,21L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175454Inst : IEnumerable<long>
{
public static readonly long[] Value=A175454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175454.Bytes);
public long this[int i]=>Value[i];

public static A175454Inst Instance=new A175454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175455
{
public static readonly long[] Value={ 1L,6L,66L,300L,8220L,8820L,457380L,1917720L,17965080L,18600120L,2320468920L,2384502120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175455Inst : IEnumerable<long>
{
public static readonly long[] Value=A175455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175455.Bytes);
public long this[int i]=>Value[i];

public static A175455Inst Instance=new A175455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175456
{
public static readonly long[] Value={ 0L,1L,2L,1L,1L,1L,2L,1L,8L,0L,5L,4L,10L,6L,14L,10L,5L,10L,2L,1L,20L,1L,5L,10L,2L,1L,8L,1L,25L,1L,11L,10L,23L,1L,22L,1L,30L,10L,17L,10L,14L,19L,20L,19L,26L,20L,34L,1L,11L,1L,50L,26L,13L,19L,2L,28L,44L,37L,14L,19L,11L,1L,44L,38L,34L,49L,51L,60L,59L,53L,58L,1L,2L,19L,44L,19L,14L,70L,63L,10L,71L,1L,41L,28L,2L,10L,17L,10L,5L,46L,38L,10L,17L,37L,32L,37L,2L,72L,71L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175456Inst : IEnumerable<long>
{
public static readonly long[] Value=A175456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175456.Bytes);
public long this[int i]=>Value[i];

public static A175456Inst Instance=new A175456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175457
{
public static readonly long[] Value={ 0L,1L,0L,2L,2L,3L,1L,4L,0L,6L,1L,9L,10L,12L,3L,6L,4L,0L,6L,12L,18L,19L,3L,18L,15L,21L,18L,6L,19L,27L,6L,30L,27L,33L,30L,18L,24L,21L,6L,11L,3L,27L,24L,21L,27L,42L,21L,9L,15L,21L,12L,15L,4L,9L,52L,50L,27L,55L,48L,3L,24L,39L,36L,60L,10L,27L,33L,3L,36L,42L,66L,54L,33L,57L,63L,51L,75L,36L,51L,39L,45L,60L,1L,27L,15L,21L,27L,15L,48L,0L,69L,84L,27L,51L,39L,54L,94L,66L,45L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175457Inst : IEnumerable<long>
{
public static readonly long[] Value=A175457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175457.Bytes);
public long this[int i]=>Value[i];

public static A175457Inst Instance=new A175457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175458
{
public static readonly long[] Value={ 0L,1L,3L,6L,2L,7L,13L,20L,28L,19L,29L,40L,52L,65L,79L,94L,110L,127L,109L,128L,148L,127L,149L,172L,196L,221L,247L,274L,302L,331L,361L,392L,424L,457L,491L,526L,562L,599L,637L,676L,716L,757L,799L,842L,886L,931L,977L,1024L,1072L,1121L,1171L,1222L,1274L,1327L,1381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175458Inst : IEnumerable<long>
{
public static readonly long[] Value=A175458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175458.Bytes);
public long this[int i]=>Value[i];

public static A175458Inst Instance=new A175458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175459
{
public static readonly long[] Value={ 4L,6L,9L,36L,180L,186L,1302L,1310L,11790L,11800L,11811L,11823L,11836L,11850L,11865L,11881L,11898L,11916L,11935L,11955L,11976L,11998L,12021L,12045L,12070L,12096L,12123L,12151L,12180L,12210L,378510L,378542L,378575L,378609L,378644L,378680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175459Inst : IEnumerable<long>
{
public static readonly long[] Value=A175459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175459.Bytes);
public long this[int i]=>Value[i];

public static A175459Inst Instance=new A175459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175460
{
public static readonly long[] Value={ 24L,37L,123L,136L,144L,153L,154L,166L,167L,179L,192L,205L,218L,228L,231L,241L,243L,244L,254L,266L,267L,279L,287L,296L,297L,309L,322L,335L,348L,361L,371L,373L,374L,383L,384L,386L,387L,397L,409L,422L,439L,452L,465L,478L,491L,503L,504L,513L,514L,516L,517L,526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175460Inst : IEnumerable<long>
{
public static readonly long[] Value=A175460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175460.Bytes);
public long this[int i]=>Value[i];

public static A175460Inst Instance=new A175460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175461
{
public static readonly long[] Value={ 21L,69L,77L,85L,93L,133L,141L,205L,213L,221L,237L,253L,301L,309L,341L,365L,381L,413L,437L,445L,453L,469L,485L,493L,501L,517L,533L,565L,573L,581L,589L,597L,629L,669L,685L,717L,749L,781L,789L,813L,869L,893L,901L,917L,933L,949L,965L,973L,989L,1037L,1077L,1101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175461Inst : IEnumerable<long>
{
public static readonly long[] Value=A175461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175461.Bytes);
public long this[int i]=>Value[i];

public static A175461Inst Instance=new A175461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175462
{
public static readonly long[] Value={ 2L,2L,4L,2L,2L,6L,2L,2L,4L,4L,4L,4L,2L,2L,6L,4L,4L,4L,2L,2L,8L,2L,2L,8L,2L,4L,4L,4L,2L,4L,6L,4L,6L,2L,2L,8L,2L,4L,4L,2L,6L,6L,4L,2L,8L,4L,2L,4L,2L,2L,10L,4L,2L,8L,4L,4L,4L,2L,4L,6L,4L,4L,4L,2L,4L,12L,4L,2L,6L,2L,4L,4L,4L,4L,4L,6L,2L,8L,4L,6L,8L,2L,2L,4L,2L,4L,12L,2L,2L,4L,6L,2L,8L,4L,2L,12L,2L,4L,4L,2L,8L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175462Inst : IEnumerable<long>
{
public static readonly long[] Value=A175462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175462.Bytes);
public long this[int i]=>Value[i];

public static A175462Inst Instance=new A175462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175463
{
public static readonly long[] Value={ 2L,8L,9L,10L,11L,16L,17L,25L,26L,27L,29L,31L,37L,38L,42L,45L,47L,51L,54L,55L,56L,58L,60L,61L,62L,64L,66L,70L,71L,72L,73L,74L,78L,83L,85L,89L,93L,97L,98L,101L,108L,111L,112L,114L,116L,118L,120L,121L,123L,129L,134L,137L,141L,142L,143L,144L,145L,148L,150L,156L,157L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175463Inst : IEnumerable<long>
{
public static readonly long[] Value=A175463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175463.Bytes);
public long this[int i]=>Value[i];

public static A175463Inst Instance=new A175463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175464
{
public static readonly long[] Value={ 1111L,3513L,3514L,9013L,11109L,11110L,11111L,11112L,11113L,14357L,14572L,20524L,22635L,30205L,33518L,35129L,35130L,35131L,35132L,35133L,35134L,35135L,35136L,35137L,35138L,35139L,35140L,35141L,35142L,39003L,39549L,40154L,42616L,46081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175464Inst : IEnumerable<long>
{
public static readonly long[] Value=A175464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175464.Bytes);
public long this[int i]=>Value[i];

public static A175464Inst Instance=new A175464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175465
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,1L,1L,1L,2L,4L,2L,2L,2L,1L,1L,1L,2L,3L,2L,3L,5L,3L,2L,1L,2L,3L,2L,1L,2L,1L,1L,1L,2L,3L,1L,2L,4L,2L,1L,3L,4L,6L,4L,2L,4L,3L,2L,1L,1L,2L,3L,2L,4L,2L,1L,2L,1L,3L,1L,1L,2L,1L,1L,1L,2L,3L,1L,2L,4L,2L,2L,2L,3L,5L,3L,3L,3L,2L,1L,3L,4L,5L,3L,5L,7L,5L,4L,2L,3L,5L,3L,2L,4L,3L,2L,1L,1L,2L,2L,3L,3L,3L,2L,2L,3L,5L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175465Inst : IEnumerable<long>
{
public static readonly long[] Value=A175465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175465.Bytes);
public long this[int i]=>Value[i];

public static A175465Inst Instance=new A175465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175466
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,3L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,4L,1L,2L,1L,1L,1L,3L,2L,2L,3L,1L,1L,1L,2L,3L,2L,5L,2L,3L,2L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175466Inst : IEnumerable<long>
{
public static readonly long[] Value=A175466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175466.Bytes);
public long this[int i]=>Value[i];

public static A175466Inst Instance=new A175466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175467
{
public static readonly long[] Value={ 1L,2L,5L,10L,5L,10L,21L,42L,21L,10L,21L,42L,21L,42L,85L,170L,85L,42L,85L,42L,21L,42L,85L,170L,85L,42L,85L,170L,85L,170L,341L,682L,341L,170L,341L,170L,85L,170L,341L,170L,85L,42L,85L,170L,85L,170L,341L,682L,341L,170L,341L,170L,85L,170L,341L,682L,341L,170L,341L,682L,341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175467Inst : IEnumerable<long>
{
public static readonly long[] Value=A175467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175467.Bytes);
public long this[int i]=>Value[i];

public static A175467Inst Instance=new A175467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175468
{
public static readonly long[] Value={ 3L,5L,9L,10L,15L,17L,18L,27L,33L,34L,36L,45L,51L,54L,63L,65L,66L,68L,85L,99L,102L,119L,129L,130L,132L,136L,153L,165L,170L,187L,195L,198L,204L,221L,231L,238L,255L,257L,258L,260L,264L,297L,325L,330L,363L,387L,390L,396L,429L,455L,462L,495L,513L,514L,516L,520L,528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175468Inst : IEnumerable<long>
{
public static readonly long[] Value=A175468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175468.Bytes);
public long this[int i]=>Value[i];

public static A175468Inst Instance=new A175468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175469
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,2L,3L,1L,2L,4L,5L,3L,6L,7L,1L,2L,4L,5L,3L,6L,7L,1L,2L,4L,8L,9L,5L,10L,11L,3L,6L,12L,13L,7L,14L,15L,1L,2L,4L,8L,9L,5L,10L,11L,3L,6L,12L,13L,7L,14L,15L,1L,2L,4L,8L,16L,17L,9L,18L,19L,5L,10L,20L,21L,11L,22L,23L,3L,6L,12L,24L,25L,13L,26L,27L,7L,14L,28L,29L,15L,30L,31L,1L,2L,4L,8L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175469Inst : IEnumerable<long>
{
public static readonly long[] Value=A175469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175469.Bytes);
public long this[int i]=>Value[i];

public static A175469Inst Instance=new A175469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175470
{
public static readonly long[] Value={ 1L,2L,3L,2L,2L,4L,3L,3L,5L,4L,3L,3L,4L,3L,3L,6L,5L,4L,4L,5L,4L,4L,7L,6L,5L,4L,4L,5L,4L,4L,6L,5L,4L,4L,5L,4L,4L,8L,7L,6L,5L,5L,6L,5L,5L,7L,6L,5L,5L,6L,5L,5L,9L,8L,7L,6L,5L,5L,6L,5L,5L,7L,6L,5L,5L,6L,5L,5L,8L,7L,6L,5L,5L,6L,5L,5L,7L,6L,5L,5L,6L,5L,5L,10L,9L,8L,7L,6L,6L,7L,6L,6L,8L,7L,6L,6L,7L,6L,6L,9L,8L,7L,6L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175470Inst : IEnumerable<long>
{
public static readonly long[] Value=A175470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175470.Bytes);
public long this[int i]=>Value[i];

public static A175470Inst Instance=new A175470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175471
{
public static readonly long[] Value={ 3L,24L,26L,76L,83L,87L,236L,264L,313L,314L,316L,766L,816L,824L,834L,836L,883L,887L,937L,2366L,2383L,2387L,2424L,2563L,2626L,2976L,3114L,7613L,7666L,8117L,8167L,8184L,8234L,8286L,8366L,8716L,8813L,8814L,8887L,8937L,9266L,9316L,9363L,9417L,9474L,9786L,9833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175471Inst : IEnumerable<long>
{
public static readonly long[] Value=A175471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175471.Bytes);
public long this[int i]=>Value[i];

public static A175471Inst Instance=new A175471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175472
{
public static readonly long[] Value={ 5L,0L,4L,0L,8L,3L,0L,0L,8L,2L,6L,4L,4L,5L,5L,4L,0L,9L,2L,5L,8L,2L,6L,9L,3L,0L,4L,5L,3L,3L,3L,0L,2L,4L,9L,8L,9L,5L,5L,3L,8L,5L,1L,8L,2L,3L,6L,8L,5L,7L,9L,8L,4L,5L,1L,7L,7L,2L,6L,9L,5L,8L,4L,5L,0L,9L,5L,9L,3L,8L,3L,3L,7L,1L,3L,4L,7L,8L,8L,6L,4L,6L,2L,5L,6L,4L,4L,7L,9L,3L,8L,1L,5L,1L,3L,6L,5L,2L,5L,4L,6L,8L,0L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175472Inst : IEnumerable<long>
{
public static readonly long[] Value=A175472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175472.Bytes);
public long this[int i]=>Value[i];

public static A175472Inst Instance=new A175472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175473
{
public static readonly long[] Value={ 1L,5L,7L,3L,4L,9L,8L,4L,7L,3L,1L,6L,2L,3L,9L,0L,4L,5L,8L,7L,7L,8L,2L,8L,6L,0L,4L,3L,6L,9L,0L,4L,3L,4L,6L,1L,2L,6L,5L,5L,0L,4L,0L,8L,5L,9L,1L,1L,6L,8L,4L,6L,1L,4L,9L,9L,3L,0L,1L,4L,2L,5L,6L,8L,7L,9L,7L,0L,2L,0L,3L,4L,4L,3L,9L,6L,5L,1L,4L,0L,4L,8L,1L,0L,4L,7L,3L,2L,3L,9L,8L,2L,5L,1L,8L,8L,5L,6L,2L,8L,1L,8L,7L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175473Inst : IEnumerable<long>
{
public static readonly long[] Value=A175473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175473.Bytes);
public long this[int i]=>Value[i];

public static A175473Inst Instance=new A175473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175474
{
public static readonly long[] Value={ 2L,6L,1L,0L,7L,2L,0L,8L,6L,8L,4L,4L,4L,1L,4L,4L,6L,5L,0L,0L,0L,1L,5L,3L,7L,7L,1L,5L,7L,1L,8L,7L,2L,4L,2L,0L,7L,9L,5L,1L,0L,7L,4L,0L,1L,0L,8L,7L,3L,4L,8L,0L,2L,4L,4L,1L,9L,0L,6L,5L,0L,8L,7L,5L,6L,0L,3L,7L,5L,7L,4L,7L,3L,3L,1L,3L,8L,3L,8L,6L,3L,7L,5L,6L,5L,3L,6L,1L,5L,4L,9L,6L,2L,5L,2L,7L,0L,7L,1L,1L,9L,5L,9L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175474Inst : IEnumerable<long>
{
public static readonly long[] Value=A175474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175474.Bytes);
public long this[int i]=>Value[i];

public static A175474Inst Instance=new A175474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175475
{
public static readonly long[] Value={ 0L,4L,8L,6L,0L,8L,3L,8L,8L,2L,9L,1L,1L,3L,1L,5L,6L,6L,9L,0L,7L,1L,8L,3L,0L,3L,9L,3L,4L,3L,4L,0L,7L,4L,2L,1L,3L,5L,4L,3L,2L,9L,5L,8L,0L,4L,7L,8L,1L,4L,0L,5L,4L,2L,3L,1L,6L,8L,0L,5L,2L,8L,5L,0L,5L,1L,4L,8L,8L,2L,3L,5L,7L,3L,5L,9L,3L,2L,4L,7L,2L,0L,0L,4L,0L,9L,1L,2L,9L,3L,3L,7L,1L,1L,6L,7L,7L,0L,7L,9L,6L,8L,0L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175475Inst : IEnumerable<long>
{
public static readonly long[] Value=A175475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175475.Bytes);
public long this[int i]=>Value[i];

public static A175475Inst Instance=new A175475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175476
{
public static readonly long[] Value={ 5L,5L,6L,8L,3L,2L,7L,9L,9L,6L,8L,3L,1L,7L,0L,7L,8L,4L,5L,2L,8L,4L,8L,1L,7L,9L,8L,2L,1L,1L,8L,8L,3L,5L,7L,0L,2L,0L,1L,3L,6L,2L,4L,3L,9L,0L,2L,8L,3L,2L,4L,3L,9L,1L,0L,7L,5L,3L,6L,7L,5L,8L,1L,8L,8L,2L,9L,7L,4L,5L,5L,3L,3L,6L,4L,7L,7L,9L,5L,7L,0L,2L,2L,1L,2L,1L,7L,7L,6L,8L,7L,3L,8L,4L,7L,0L,8L,4L,9L,4L,0L,9L,7L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175476Inst : IEnumerable<long>
{
public static readonly long[] Value=A175476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175476.Bytes);
public long this[int i]=>Value[i];

public static A175476Inst Instance=new A175476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175477
{
public static readonly long[] Value={ 1L,2L,7L,6L,4L,0L,5L,2L,9L,3L,5L,0L,3L,2L,6L,8L,1L,2L,7L,1L,2L,6L,3L,2L,8L,0L,9L,5L,0L,7L,6L,8L,5L,7L,4L,7L,6L,1L,9L,9L,8L,4L,0L,4L,7L,3L,2L,5L,6L,1L,4L,3L,7L,0L,6L,0L,5L,8L,7L,5L,7L,2L,0L,7L,4L,1L,3L,0L,0L,9L,6L,0L,2L,7L,2L,5L,6L,1L,9L,6L,2L,2L,0L,8L,2L,7L,1L,0L,6L,4L,7L,8L,3L,6L,4L,9L,0L,5L,4L,6L,6L,9L,5L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175477Inst : IEnumerable<long>
{
public static readonly long[] Value=A175477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175477.Bytes);
public long this[int i]=>Value[i];

public static A175477Inst Instance=new A175477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175478
{
public static readonly long[] Value={ 1L,2L,0L,6L,9L,4L,8L,9L,6L,0L,8L,1L,2L,5L,8L,1L,9L,7L,7L,8L,4L,3L,7L,7L,9L,1L,2L,3L,8L,4L,9L,3L,6L,5L,9L,1L,3L,6L,1L,8L,4L,6L,3L,3L,4L,6L,6L,2L,9L,2L,2L,1L,9L,8L,4L,8L,1L,6L,7L,2L,6L,8L,4L,0L,0L,5L,8L,2L,1L,5L,5L,1L,4L,8L,0L,7L,9L,8L,5L,2L,5L,4L,4L,5L,8L,5L,4L,4L,3L,0L,1L,7L,7L,1L,4L,0L,9L,3L,3L,3L,4L,2L,2L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175478Inst : IEnumerable<long>
{
public static readonly long[] Value=A175478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175478.Bytes);
public long this[int i]=>Value[i];

public static A175478Inst Instance=new A175478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175479
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175479Inst : IEnumerable<long>
{
public static readonly long[] Value=A175479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175479.Bytes);
public long this[int i]=>Value[i];

public static A175479Inst Instance=new A175479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175480
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175480Inst : IEnumerable<long>
{
public static readonly long[] Value=A175480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175480.Bytes);
public long this[int i]=>Value[i];

public static A175480Inst Instance=new A175480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175481
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,10L,11L,11L,13L,15L,36L,49L,42L,56L,54L,47L,42L,53L,52L,57L,112L,129L,131L,136L,163L,137L,183L,196L,198L,192L,162L,109L,218L,172L,275L,273L,151L,213L,196L,181L,343L,285L,367L,395L,437L,549L,389L,403L,524L,645L,409L,418L,568L,632L,608L,587L,719L,576L,570L,599L,565L,533L,393L,255L,595L,569L,565L,494L,984L,819L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175481Inst : IEnumerable<long>
{
public static readonly long[] Value=A175481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175481.Bytes);
public long this[int i]=>Value[i];

public static A175481Inst Instance=new A175481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175482
{
public static readonly long[] Value={ 3L,3L,7L,5L,3L,7L,3L,5L,3L,13L,3L,11L,7L,3L,11L,5L,3L,7L,19L,5L,3L,7L,5L,17L,3L,11L,13L,5L,3L,7L,19L,3L,17L,3L,5L,3L,7L,11L,3L,3L,11L,19L,17L,7L,3L,13L,5L,7L,23L,17L,3L,3L,11L,7L,3L,13L,5L,29L,5L,7L,13L,5L,3L,3L,31L,19L,23L,3L,11L,5L,3L,3L,13L,7L,19L,3L,37L,23L,5L,7L,11L,5L,17L,7L,5L,13L,3L,3L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175482Inst : IEnumerable<long>
{
public static readonly long[] Value=A175482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175482.Bytes);
public long this[int i]=>Value[i];

public static A175482Inst Instance=new A175482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175483
{
public static readonly long[] Value={ 7L,23L,11L,17L,31L,19L,47L,41L,71L,17L,79L,23L,43L,103L,31L,73L,127L,59L,23L,89L,151L,67L,97L,29L,167L,47L,41L,113L,191L,83L,31L,199L,37L,223L,137L,239L,107L,71L,263L,271L,79L,47L,53L,131L,311L,73L,193L,139L,43L,61L,359L,367L,103L,163L,383L,89L,233L,41L,241L,179L,97L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175483Inst : IEnumerable<long>
{
public static readonly long[] Value=A175483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175483.Bytes);
public long this[int i]=>Value[i];

public static A175483Inst Instance=new A175483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175484
{
public static readonly long[] Value={ 5L,13L,9L,11L,17L,13L,25L,23L,37L,15L,41L,17L,25L,53L,21L,39L,65L,33L,21L,47L,77L,37L,51L,23L,85L,29L,27L,59L,97L,45L,25L,101L,27L,113L,71L,121L,57L,41L,133L,137L,45L,33L,35L,69L,157L,43L,99L,73L,33L,39L,181L,185L,57L,85L,193L,51L,119L,35L,123L,93L,55L,131L,217L,221L,37L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175484Inst : IEnumerable<long>
{
public static readonly long[] Value=A175484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175484.Bytes);
public long this[int i]=>Value[i];

public static A175484Inst Instance=new A175484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175485
{
public static readonly long[] Value={ 1L,5L,14L,15L,11L,91L,20L,51L,95L,77L,46L,325L,63L,145L,248L,187L,105L,703L,130L,287L,473L,345L,188L,1225L,221L,477L,770L,551L,295L,1891L,336L,715L,1139L,805L,426L,2701L,475L,1001L,1580L,1107L,581L,3655L,638L,1335L,2093L,1457L,760L,4753L,825L,1717L,2678L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175485Inst : IEnumerable<long>
{
public static readonly long[] Value=A175485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175485.Bytes);
public long this[int i]=>Value[i];

public static A175485Inst Instance=new A175485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175486
{
public static readonly long[] Value={ 125L,325L,725L,845L,925L,1325L,1525L,1885L,2197L,2405L,2525L,2725L,3125L,3445L,3725L,3925L,3965L,4205L,4325L,4525L,4901L,4925L,5365L,5725L,6253L,6565L,6725L,6845L,6925L,7085L,7325L,7685L,7925L,8125L,8725L,8845L,8957L,9325L,9685L,9725L,9805L,9925L,10205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175486Inst : IEnumerable<long>
{
public static readonly long[] Value=A175486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175486.Bytes);
public long this[int i]=>Value[i];

public static A175486Inst Instance=new A175486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175487
{
public static readonly ulong[] Value={ 2L,7L,37L,127L,397L,3613L,18089L,162881L,1791787L,41211197L,370900973L,4821712733L,43395414737L,477349562419L,4296146062051L,227695741289567L,9335525392876531L,326743388750679161L,16663912826284638251UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175487Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A175487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175487.Bytes);
public ulong this[int i]=>Value[i];

public static A175487Inst Instance=new A175487Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175488
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,3L,1L,2L,1L,4L,1L,2L,1L,2L,5L,1L,2L,3L,2L,2L,6L,1L,1L,3L,1L,1L,3L,7L,1L,2L,1L,4L,2L,2L,1L,8L,1L,2L,1L,4L,2L,2L,1L,4L,9L,1L,2L,1L,2L,5L,2L,1L,2L,2L,10L,1L,2L,3L,2L,5L,3L,3L,2L,2L,5L,11L,1L,2L,3L,4L,2L,6L,3L,4L,4L,2L,3L,12L,1L,2L,3L,2L,5L,6L,3L,2L,2L,5L,5L,6L,13L,1L,2L,3L,2L,2L,6L,7L,2L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175488Inst : IEnumerable<long>
{
public static readonly long[] Value=A175488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175488.Bytes);
public long this[int i]=>Value[i];

public static A175488Inst Instance=new A175488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175489
{
public static readonly long[] Value={ 1L,3L,5L,8L,11L,16L,17L,21L,26L,28L,39L,46L,55L,58L,51L,54L,63L,65L,85L,87L,82L,104L,118L,128L,144L,147L,163L,176L,193L,181L,141L,137L,154L,156L,192L,162L,212L,231L,252L,247L,275L,202L,267L,307L,306L,333L,336L,345L,373L,381L,410L,412L,419L,423L,475L,497L,532L,539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175489Inst : IEnumerable<long>
{
public static readonly long[] Value=A175489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175489.Bytes);
public long this[int i]=>Value[i];

public static A175489Inst Instance=new A175489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175490
{
public static readonly long[] Value={ 1L,2L,3L,8L,20L,144L,63L,256L,1152L,1600L,118800L,995328L,8424000L,12192768L,178605L,1048576L,8912896L,21233664L,27572576256L,13107200000L,537600000L,2032335360000L,30928035600000L,760840571584512L,13541327555788800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175490Inst : IEnumerable<long>
{
public static readonly long[] Value=A175490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175490.Bytes);
public long this[int i]=>Value[i];

public static A175490Inst Instance=new A175490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175491
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,11L,17L,25L,35L,49L,64L,89L,122L,174L,235L,286L,334L,407L,473L,581L,690L,824L,976L,1206L,1449L,1811L,2183L,2718L,3306L,4173L,5070L,5659L,6071L,6769L,7279L,8137L,8716L,9765L,10587L,11907L,12940L,14631L,15649L,17600L,19231L,21729L,24004L,27228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175491Inst : IEnumerable<long>
{
public static readonly long[] Value=A175491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175491.Bytes);
public long this[int i]=>Value[i];

public static A175491Inst Instance=new A175491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175492
{
public static readonly long[] Value={ 7L,10L,24L,26L,65L,13777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175492Inst : IEnumerable<long>
{
public static readonly long[] Value=A175492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175492.Bytes);
public long this[int i]=>Value[i];

public static A175492Inst Instance=new A175492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175493
{
public static readonly BigInteger[] Value={ 1L,4L,36L,2304L,57600L,74649600L,3657830400L,14982473318400L,10922223049113600L,BigInteger.Parse("109222230491136000000"),BigInteger.Parse("13215889889427456000000"),BigInteger.Parse("39462435755592152776704000000"),BigInteger.Parse("6669151642695073819262976000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175493Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175493.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175493Inst Instance=new A175493Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175494
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,3L,1L,3L,1L,1L,1L,4L,1L,4L,1L,2L,2L,4L,1L,2L,2L,2L,1L,5L,1L,5L,1L,2L,2L,2L,1L,6L,2L,2L,1L,6L,1L,6L,1L,1L,2L,6L,1L,3L,1L,2L,1L,7L,1L,2L,1L,2L,2L,7L,1L,7L,2L,1L,1L,2L,1L,8L,2L,2L,1L,8L,1L,8L,2L,2L,2L,2L,1L,8L,1L,2L,3L,9L,1L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175494Inst : IEnumerable<long>
{
public static readonly long[] Value=A175494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175494.Bytes);
public long this[int i]=>Value[i];

public static A175494Inst Instance=new A175494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175495
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,10L,12L,14L,15L,16L,18L,20L,24L,28L,30L,32L,36L,40L,42L,44L,45L,48L,50L,52L,54L,56L,60L,63L,64L,66L,70L,72L,78L,80L,84L,88L,90L,96L,100L,102L,104L,105L,108L,110L,112L,114L,120L,126L,128L,130L,132L,135L,136L,138L,140L,144L,150L,152L,154L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175495Inst : IEnumerable<long>
{
public static readonly long[] Value=A175495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175495.Bytes);
public long this[int i]=>Value[i];

public static A175495Inst Instance=new A175495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175496
{
public static readonly long[] Value={ 8L,24L,27L,40L,54L,56L,88L,104L,120L,125L,128L,135L,136L,152L,168L,184L,189L,216L,232L,248L,250L,264L,270L,280L,296L,297L,312L,328L,343L,344L,351L,375L,376L,378L,384L,408L,424L,440L,456L,459L,472L,488L,513L,520L,536L,552L,568L,584L,594L,616L,621L,632L,640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175496Inst : IEnumerable<long>
{
public static readonly long[] Value=A175496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175496.Bytes);
public long this[int i]=>Value[i];

public static A175496Inst Instance=new A175496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175497
{
public static readonly long[] Value={ 0L,6L,30L,35L,84L,180L,204L,210L,297L,330L,546L,840L,1170L,1189L,1224L,1710L,2310L,2940L,2970L,3036L,3230L,3900L,4914L,6090L,6930L,7134L,7140L,7245L,7440L,8976L,10710L,12654L,14175L,14820L,16296L,16380L,17220L,19866L,22770L,25172L,25944L,29103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175497Inst : IEnumerable<long>
{
public static readonly long[] Value=A175497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175497.Bytes);
public long this[int i]=>Value[i];

public static A175497Inst Instance=new A175497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175498
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,10L,5L,11L,7L,12L,9L,16L,8L,17L,15L,23L,13L,24L,18L,28L,14L,26L,19L,32L,20L,34L,21L,36L,25L,41L,22L,39L,30L,48L,27L,46L,29L,49L,31L,52L,37L,59L,33L,56L,40L,64L,35L,60L,38L,65L,42L,68L,43L,71L,44L,73L,45L,75L,51L,82L,47L,79L,112L,50L,84L,53L,88L,54L,90L,57L,94L,55L,93L,61L,100L,58L,98L,62L,103L,63L,105L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175498Inst : IEnumerable<long>
{
public static readonly long[] Value=A175498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175498.Bytes);
public long this[int i]=>Value[i];

public static A175498Inst Instance=new A175498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175499
{
public static readonly long[] Value={ 1L,2L,-1L,3L,4L,-5L,6L,-4L,5L,-3L,7L,-8L,9L,-2L,8L,-10L,11L,-6L,10L,-14L,12L,-7L,13L,-12L,14L,-13L,15L,-11L,16L,-19L,17L,-9L,18L,-21L,19L,-17L,20L,-18L,21L,-15L,22L,-26L,23L,-16L,24L,-29L,25L,-22L,27L,-23L,26L,-25L,28L,-27L,29L,-28L,30L,-24L,31L,-35L,32L,33L,-62L,34L,-31L,35L,-34L,36L,-33L,37L,-39L,38L,-32L,39L,-42L,40L,-36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175499Inst : IEnumerable<long>
{
public static readonly long[] Value=A175499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175499.Bytes);
public long this[int i]=>Value[i];

public static A175499Inst Instance=new A175499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175500
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,12L,8L,9L,10L,14L,16L,11L,24L,13L,36L,15L,18L,17L,48L,19L,60L,20L,25L,28L,30L,21L,40L,32L,44L,64L,22L,72L,23L,81L,26L,80L,27L,100L,29L,120L,31L,144L,33L,168L,34L,180L,35L,192L,37L,240L,38L,324L,41L,252L,42L,49L,54L,56L,84L,39L,336L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175500Inst : IEnumerable<long>
{
public static readonly long[] Value=A175500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175500.Bytes);
public long this[int i]=>Value[i];

public static A175500Inst Instance=new A175500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175501
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,2L,6L,4L,3L,4L,4L,5L,2L,8L,2L,9L,4L,6L,2L,10L,2L,12L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175501Inst : IEnumerable<long>
{
public static readonly long[] Value=A175501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175501.Bytes);
public long this[int i]=>Value[i];

public static A175501Inst Instance=new A175501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175502
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,12L,8L,10L,16L,7L,24L,9L,18L,20L,30L,14L,36L,11L,48L,15L,60L,13L,64L,21L,120L,17L,144L,22L,180L,19L,192L,25L,49L,72L,28L,80L,40L,42L,81L,32L,100L,54L,84L,90L,112L,121L,168L,44L,240L,23L,360L,26L,320L,45L,252L,56L,210L,96L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175502Inst : IEnumerable<long>
{
public static readonly long[] Value=A175502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175502.Bytes);
public long this[int i]=>Value[i];

public static A175502Inst Instance=new A175502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175503
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,2L,6L,4L,4L,5L,2L,8L,3L,6L,6L,8L,4L,9L,2L,10L,4L,12L,2L,7L,4L,16L,2L,15L,4L,18L,2L,14L,3L,3L,12L,6L,10L,8L,8L,5L,6L,9L,8L,12L,12L,10L,3L,16L,6L,20L,2L,24L,4L,14L,6L,18L,8L,16L,12L,9L,10L,10L,16L,9L,3L,18L,12L,15L,6L,24L,8L,20L,4L,21L,2L,30L,4L,32L,2L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175503Inst : IEnumerable<long>
{
public static readonly long[] Value=A175503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175503.Bytes);
public long this[int i]=>Value[i];

public static A175503Inst Instance=new A175503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175504
{
public static readonly BigInteger[] Value={ 1L,1L,3L,4L,125L,6L,16807L,512L,59049L,1000L,2357947691L,1728L,1792160394037L,537824L,170859375L,268435456L,2862423051509815793L,1889568L,BigInteger.Parse("5480386857784802185939"),1280000000L,350277500542221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175504Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175504.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175504Inst Instance=new A175504Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}