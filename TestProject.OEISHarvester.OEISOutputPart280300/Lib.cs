using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A094599
{
public static readonly long[] Value={ 1L,2L,4L,7L,8L,11L,12L,13L,15L,16L,17L,18L,19L,20L,23L,25L,26L,27L,28L,31L,32L,35L,39L,40L,44L,45L,47L,48L,49L,53L,54L,55L,56L,60L,61L,63L,64L,65L,67L,71L,72L,74L,76L,77L,79L,80L,81L,83L,87L,89L,92L,95L,96L,97L,99L,100L };
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
public class A094599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094599Inst : IEnumerable<long>
{
public static readonly long[] Value=A094599.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094599.Bytes);
public long this[int i]=>Value[i];

public static A094599Inst Instance=new A094599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094600
{
public static readonly long[] Value={ 1L,1L,2L,5L,9L,28L,48L,145L,250L,831L,1404L,4664L,7875L,26748L,44960L,154265L,258777L,896644L,1501060L,5239975L,8758640L,30760060L,51350784L,181258264L,302271736L,1071490551L,1785262500L,6351444132L,10574365725L,37738804488L,62788919872L };
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
public class A094600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094600Inst : IEnumerable<long>
{
public static readonly long[] Value=A094600.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094600.Bytes);
public long this[int i]=>Value[i];

public static A094600Inst Instance=new A094600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094601
{
public static readonly long[] Value={ 1L,1L,3L,12L,50L,234L,1125L,5620L,28753L,150106L,796240L,4279232L,23251672L,127518750L,704957715L,3924307492L,21978740682L,123758612644L,700204091361L,3978636187708L,22694470914700L,129904466979030L,745949776425002L };
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
public class A094601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094601Inst : IEnumerable<long>
{
public static readonly long[] Value=A094601.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094601.Bytes);
public long this[int i]=>Value[i];

public static A094601Inst Instance=new A094601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094602
{
public static readonly BigInteger[] Value={ 0L,1L,5L,25L,130L,951L,9552L,160220L,4756703L,264964172L,27746801125L,5419696866001L,1964101824992259L,1319988856541150115L,BigInteger.Parse("1648566523004692022634"),BigInteger.Parse("3838409698542815296758222") };
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
public class A094602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094602Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094602.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094602.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094602Inst Instance=new A094602Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094603
{
public static readonly long[] Value={ 1L,3L,1L,4L,1L,3L,1L,6L,1L,3L,1L,4L,1L,3L,1L,7L,1L,3L,1L,4L,1L,3L,1L,6L,1L,3L,1L,4L,1L,3L,1L,9L,1L,3L,1L,4L,1L,3L,1L,6L,1L,3L,1L,4L,1L,3L,1L,7L,1L,3L,1L,4L,1L,3L,1L,6L,1L,3L,1L,4L,1L,3L,1L,15L,1L,3L,1L,4L,1L,3L,1L,6L,1L,3L,1L,4L,1L,3L,1L,7L,1L,3L,1L,4L,1L,3L,1L,6L,1L,3L,1L,4L,1L,3L,1L,9L,1L,3L,1L,4L,1L,3L,1L,6L,1L };
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
public class A094603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094603Inst : IEnumerable<long>
{
public static readonly long[] Value=A094603.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094603.Bytes);
public long this[int i]=>Value[i];

public static A094603Inst Instance=new A094603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094604
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,9L,15L,16L,24L,25L,27L,29L,34L,36L,37L,39L,41L,43L,48L,49L,51L,54L,55L,58L,60L,63L,64L,66L,69L,70L,72L,74L,77L,79L,80L,82L,84L,86L,90L,91L,93L,100L,103L };
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
public class A094604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094604Inst : IEnumerable<long>
{
public static readonly long[] Value=A094604.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094604.Bytes);
public long this[int i]=>Value[i];

public static A094604Inst Instance=new A094604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094605
{
public static readonly long[] Value={ 1L,2L,2L,4L,8L,8L,16L,32L,32L,64L,64L,64L,64L,64L,64L,128L,256L,256L,256L,256L,256L,256L,256L,256L,512L,1024L,1024L,2048L,2048L,4096L,4096L,4096L,4096L,4096L,8192L,8192L,16384L,32768L,32768L,65536L,65536L,131072L,131072L,262144L,262144L,262144L,262144L };
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
public class A094605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094605Inst : IEnumerable<long>
{
public static readonly long[] Value=A094605.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094605.Bytes);
public long this[int i]=>Value[i];

public static A094605Inst Instance=new A094605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094606
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,3L,4L,5L,5L,6L,6L,6L,6L,6L,6L,7L,8L,8L,8L,8L,8L,8L,8L,8L,9L,10L,10L,11L,11L,12L,12L,12L,12L,12L,13L,13L,14L,15L,15L,16L,16L,17L,17L,18L,18L,18L,18L,18L,19L,20L,20L,21L,21L,21L,22L,23L,23L,23L,24L,24L,25L,25L,25L,26L,27L,27L,28L,28L,28L,29L };
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
public class A094606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094606Inst : IEnumerable<long>
{
public static readonly long[] Value=A094606.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094606.Bytes);
public long this[int i]=>Value[i];

public static A094606Inst Instance=new A094606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094607
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,7L,6L,11L,16L,12L,9L,13L,21L,24L,20L,10L,14L,26L,29L,37L,33L,15L,18L,27L,39L,42L,58L,54L,17L,19L,32L,40L,45L,66L,63L,88L,25L,22L,34L,47L,50L,76L,71L,97L,143L,28L,23L,35L,48L,60L,84L,79L,100L,105L,232L,41L,30L,43L,55L,61L,94L,92L,131L,113L,152L,376L,46L,31L,44L };
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
public class A094607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094607Inst : IEnumerable<long>
{
public static readonly long[] Value=A094607.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094607.Bytes);
public long this[int i]=>Value[i];

public static A094607Inst Instance=new A094607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094608
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,9L,5L,7L,12L,17L,8L,10L,14L,22L,25L,13L,11L,15L,27L,30L,38L,21L,16L,19L,28L,40L,43L,59L,34L,18L,20L,33L,41L,46L,67L,64L,55L,26L,23L,35L,48L,51L,77L,72L,98L,89L,29L,24L,36L,49L,61L,85L,80L,101L,106L,144L,42L,31L,44L,56L,62L,95L,93L,132L,114L,153L,233L,47L,32L,45L };
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
public class A094608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094608Inst : IEnumerable<long>
{
public static readonly long[] Value=A094608.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094608.Bytes);
public long this[int i]=>Value[i];

public static A094608Inst Instance=new A094608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094609
{
public static readonly long[] Value={ 4L,7L,49L,52L,295L,369L,415L,499L,502L,594L,652L,760L,2254L,4999L,5002L,8827L,10330L,14877L,49999L,50002L,490150L,499999L,500002L,509949L,3347109L,4999999L,5000002L,6983470L,24913494L,49999999L,50000002L };
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
public class A094609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094609Inst : IEnumerable<long>
{
public static readonly long[] Value=A094609.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094609.Bytes);
public long this[int i]=>Value[i];

public static A094609Inst Instance=new A094609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094610
{
public static readonly long[] Value={ 1L,1L,1L,3L,8L,32L,141L,749L,4304L,26492L,169263L,1115015L,7507211L,51466500L,358100288L,2523472751L,17978488711L,129325796854L,938234533024L,6858551493579L,50478955083341L };
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
public class A094610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094610Inst : IEnumerable<long>
{
public static readonly long[] Value=A094610.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094610.Bytes);
public long this[int i]=>Value[i];

public static A094610Inst Instance=new A094610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094611
{
public static readonly long[] Value={ 1L,1L,1L,3L,11L,56L,359L,2597L,20386L,167819L,1429815L,12500748L,111595289L,1013544057L,9340950309L,87176935700L,822559721606L,7836316493485L,75293711520236L,728968295958626L,7105984356424859L };
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
public class A094611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094611Inst : IEnumerable<long>
{
public static readonly long[] Value=A094611.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094611.Bytes);
public long this[int i]=>Value[i];

public static A094611Inst Instance=new A094611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094628
{
public static readonly long[] Value={ 4L,13L,40L,130L,400L,1300L,4000L,13000L,40000L,130000L,400000L,1300000L,4000000L,13000000L,40000000L,130000000L,400000000L,1300000000L,4000000000L,13000000000L,40000000000L,130000000000L,400000000000L,1300000000000L };
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
public class A094628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094628Inst : IEnumerable<long>
{
public static readonly long[] Value=A094628.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094628.Bytes);
public long this[int i]=>Value[i];

public static A094628Inst Instance=new A094628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094629
{
public static readonly long[] Value={ 2L,11L,20L,110L,200L,1100L,2000L,11000L,20000L,110000L,200000L,1100000L,2000000L,11000000L,20000000L,110000000L,200000000L,1100000000L,2000000000L,11000000000L,20000000000L,110000000000L,200000000000L,1100000000000L };
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
public class A094629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094629Inst : IEnumerable<long>
{
public static readonly long[] Value=A094629.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094629.Bytes);
public long this[int i]=>Value[i];

public static A094629Inst Instance=new A094629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094630
{
public static readonly BigInteger[] Value={ 1L,0L,0L,0L,5L,893L,1039947L,34351783511L,72057317345649377L,BigInteger.Parse("19342812465159881755696499"),BigInteger.Parse("1329227995591486918148744122456237749") };
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
public class A094630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094630Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094630.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094630.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094630Inst Instance=new A094630Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094631
{
public static readonly BigInteger[] Value={ 1L,0L,0L,184L,16936L,2711904L,675457000L,232383728378L,105676839790294L,61466235823794521L,BigInteger.Parse("44524673319233300950") };
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
public class A094631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094631Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094631.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094631.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094631Inst Instance=new A094631Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094632
{
public static readonly long[] Value={ 1L,0L,3L,4L,21L,55L,198L,609L,2021L,6460L,21033L,67859L,219926L,711165L,2302233L,7448804L,24107061L,78008495L,252446598L,816924969L,2643639901L,8554973900L,27684516753L,89588913979L,289915919446L,938187455205L,3036038652273L };
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
public class A094632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094632Inst : IEnumerable<long>
{
public static readonly long[] Value=A094632.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094632.Bytes);
public long this[int i]=>Value[i];

public static A094632Inst Instance=new A094632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094633
{
public static readonly long[] Value={ 2L,1L,9L,20L,77L,231L,774L,2465L,8037L,25916L,84009L,271635L,879382L,2845181L,9208089L,29796580L,96426037L,312037551L,1009780614L,3267709225L,10574544477L,34219920076L,110738027409L,358355719995L,1159663574102L,3752749988581L };
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
public class A094633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094633Inst : IEnumerable<long>
{
public static readonly long[] Value=A094633.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094633.Bytes);
public long this[int i]=>Value[i];

public static A094633Inst Instance=new A094633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094634
{
public static readonly long[] Value={ 1L,3L,4L,5L,4L,5L,5L,2L,6L,7L,5L,6L,6L,7L,7L,6L,7L,7L,7L,6L,7L,7L,7L,8L,8L,7L,8L,8L,8L,7L,8L,8L,8L,9L,9L,8L,9L,9L,8L,9L,9L,9L,10L,9L,8L,9L,9L,9L,10L,9L,10L,10L,9L,2L,10L,10L,9L,10L,10L,10L,11L,10L,11L,9L,10L,10L,10L,11L,10L,11L,11L,10L,11L,11L,10L,11L,11L,11L,11L,10L,11L,11L,11L,11L,12L,11L,10L };
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
public class A094634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094634Inst : IEnumerable<long>
{
public static readonly long[] Value=A094634.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094634.Bytes);
public long this[int i]=>Value[i];

public static A094634Inst Instance=new A094634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094635
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,1L,1L,10L,1L,1L,1L,1L,5L,1L,1L,1L,1L,10L,1L,1L,1L,1L,5L,1L,1L,1L,1L,10L,1L,1L,1L,1L,5L,1L,1L,1L,1L,10L,1L,1L,1L,1L,5L,1L,1L,1L,1L,50L,1L,1L,1L,1L,5L,1L,1L,1L,1L,10L,1L,1L,1L,1L,5L,1L,1L,1L,1L,10L,1L,1L,1L,1L,5L,1L,1L,1L,1L,10L,1L,1L,1L,1L,5L };
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
public class A094635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094635Inst : IEnumerable<long>
{
public static readonly long[] Value=A094635.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094635.Bytes);
public long this[int i]=>Value[i];

public static A094635Inst Instance=new A094635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094636
{
public static readonly long[] Value={ 1L,1L,1L,5L,5L,5L,5L,5L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L };
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
public class A094636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094636Inst : IEnumerable<long>
{
public static readonly long[] Value=A094636.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094636.Bytes);
public long this[int i]=>Value[i];

public static A094636Inst Instance=new A094636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094637
{
public static readonly long[] Value={ 1L,1L,1L,4L,16L,103L,799L,7286L,71094L,729974L,7743818L,84307887L,937002302L,10595117272L,121568251909L,1412555701804L,16594126114458L,196829590326284L,2354703777373055L,28385225424840078L,344524656398655124L };
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
public class A094637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094637Inst : IEnumerable<long>
{
public static readonly long[] Value=A094637.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094637.Bytes);
public long this[int i]=>Value[i];

public static A094637Inst Instance=new A094637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094638
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,6L,11L,6L,1L,10L,35L,50L,24L,1L,15L,85L,225L,274L,120L,1L,21L,175L,735L,1624L,1764L,720L,1L,28L,322L,1960L,6769L,13132L,13068L,5040L,1L,36L,546L,4536L,22449L,67284L,118124L,109584L,40320L,1L,45L,870L,9450L,63273L,269325L,723680L,1172700L,1026576L,362880L };
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
public class A094638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094638Inst : IEnumerable<long>
{
public static readonly long[] Value=A094638.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094638.Bytes);
public long this[int i]=>Value[i];

public static A094638Inst Instance=new A094638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094639
{
public static readonly long[] Value={ 1L,2L,6L,31L,227L,1991L,19415L,203456L,2248356L,25887400L,307993016L,3763786812L,47032778956L,598933188956L,7751562502556L,101741582076581L,1351906409905481L,18159677984049581L,246298405721739581L };
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
public class A094639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094639Inst : IEnumerable<long>
{
public static readonly long[] Value=A094639.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094639.Bytes);
public long this[int i]=>Value[i];

public static A094639Inst Instance=new A094639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094640
{
public static readonly long[] Value={ 2L,4L,1L,5L,6L,4L,4L,7L,5L,2L,7L,0L,4L,9L,0L,4L,4L,4L,6L,9L,1L,0L,3L,6L,8L,9L,1L,5L,6L,3L,2L,9L,4L,4L,2L,4L,5L,0L,3L,7L,0L,5L,4L,5L,5L,8L,0L,5L,1L,9L,8L,9L,3L,6L,7L,2L,7L,7L,3L,6L,9L,4L,7L,5L,1L,4L,6L,4L,9L,4L,7L,4L,0L,5L,4L,5L,6L,3L,3L,5L,1L,4L,2L,8L,1L,0L,3L,3L,8L,3L,7L,1L,7L,3L,4L,7L,6L,6L,7L,3L,8L,1L,9L,9L,3L };
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
public class A094640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094640Inst : IEnumerable<long>
{
public static readonly long[] Value=A094640.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094640.Bytes);
public long this[int i]=>Value[i];

public static A094640Inst Instance=new A094640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094641
{
public static readonly long[] Value={ 0L,4L,7L,6L,3L,1L,1L,9L,1L,1L,4L,26L,1L,2L,4L,1L,9L,1L,20L,3L,1L,12L,1L,2L,7L,1L,5L,2L,1L,5L,3L,1L,1L,1L,4L,1L,1L,57L,1L,2L,1L,8L,8L,1L,1L,1L,1L,1L,22L,1L,1L,6L,1L,6L,6L,1L,3L,1L,4L,2L,2L,2L,4L,1L,1L,2L,1L,19L,17L,348L,1L,1L,5L,16L,2L,2L,5L,1L,5L,2L,4L,2L,5L,1L,11L,1L,1L,11L,13L,2L,1L,1L,5L,2L,1L,2L,10L,1L,2L };
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
public class A094641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094641Inst : IEnumerable<long>
{
public static readonly long[] Value=A094641.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094641.Bytes);
public long this[int i]=>Value[i];

public static A094641Inst Instance=new A094641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094642
{
public static readonly long[] Value={ 4L,5L,1L,5L,8L,2L,7L,0L,5L,2L,8L,9L,4L,5L,4L,8L,6L,4L,7L,2L,6L,1L,9L,5L,2L,2L,9L,8L,9L,4L,8L,8L,2L,1L,4L,3L,5L,7L,1L,7L,9L,4L,6L,7L,8L,5L,5L,5L,0L,5L,6L,3L,1L,7L,3L,9L,2L,9L,4L,3L,0L,6L,1L,9L,7L,8L,7L,4L,4L,1L,4L,7L,9L,1L,5L,1L,3L,1L,3L,6L,4L,1L,7L,7L,7L,5L,9L,9L,4L,3L,2L,7L,9L,0L,7L,1L,0L,2L,0L,1L,6L,0L,0L,0L,8L };
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
public class A094642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094642Inst : IEnumerable<long>
{
public static readonly long[] Value=A094642.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094642.Bytes);
public long this[int i]=>Value[i];

public static A094642Inst Instance=new A094642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094643
{
public static readonly long[] Value={ 0L,2L,4L,1L,1L,1L,33L,1L,4L,2L,1L,2L,1L,17L,1L,1L,4L,4L,1L,2L,1L,3L,1L,3L,1L,17L,54L,1L,4L,1L,3L,38L,1L,2L,1L,1L,2L,3L,4L,3L,1L,4L,1L,8L,4L,2L,1L,4L,12L,1L,1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,1L,1L,2L,1L,1L,16L,3L,2L,4L,1L,5L,1L,12L,1L,2L,14L,1L,1L,1L,2L,3L,2L,16L,3L,4L,4L,1L,1L,10L,198L,2L,6L,2L,1L,2L,3L,1L,2L };
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
public class A094643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094643Inst : IEnumerable<long>
{
public static readonly long[] Value=A094643.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094643.Bytes);
public long this[int i]=>Value[i];

public static A094643Inst Instance=new A094643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094660
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,9L,12L,18L,24L,34L,44L,58L,72L,100L,128L,169L,210L,267L,324L,429L,534L,694L,854L,1064L,1274L,1657L,2040L,2571L,3102L,3780L,4458L,5801L,7144L,9067L,10990L,13472L,15954L,20356L,24758L,30607L,36456L,44280L };
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
public class A094660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094660Inst : IEnumerable<long>
{
public static readonly long[] Value=A094660.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094660.Bytes);
public long this[int i]=>Value[i];

public static A094660Inst Instance=new A094660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094661
{
public static readonly BigInteger[] Value={ 3L,19L,137L,1289L,16909L,259087L,4975049L,106267661L,2725447213L,85953848147L,2903947942067L,115669053951809L,5061522951820999L,231945249314081827L,11594813068340357459UL,BigInteger.Parse("650803589794759938517"),BigInteger.Parse("40385350464999429101033") };
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
public class A094661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094661Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094661.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094661.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094661Inst Instance=new A094661Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094662
{
public static readonly BigInteger[] Value={ 3L,19L,137L,1289L,4975049L,BigInteger.Parse("19374829215705183817985416854342477445596764166957007") };
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
public class A094662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094662Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094662.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094662.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094662Inst Instance=new A094662Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094663
{
public static readonly BigInteger[] Value={ 2L,19L,3023L,3469898586979325623L,BigInteger.Parse("2502544963063007045084611872632077") };
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
public class A094663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094663Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094663.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094663.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094663Inst Instance=new A094663Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094664
{
public static readonly BigInteger[] Value={ 1L,1L,2L,7L,38L,286L,2756L,32299L,444998L,7038898L,125620652L,2495811814L,54618201884L,1305184303996L,33812846036552L,943878836768947L,28242424937855558L,901709392642750186L,BigInteger.Parse("30597227032818965276"),BigInteger.Parse("1099566630423067201234"),BigInteger.Parse("41718229482624755005748") };
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
public class A094664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094664Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094664.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094664.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094664Inst Instance=new A094664Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094665
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,3L,0L,4L,15L,15L,0L,34L,147L,210L,105L,0L,496L,2370L,4095L,3150L,945L,0L,11056L,56958L,111705L,107415L,51975L,10395L,0L,349504L,1911000L,4114110L,4579575L,2837835L,945945L,135135L,0L,14873104L,85389132L,197722980L,244909665L };
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
public class A094665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094665Inst : IEnumerable<long>
{
public static readonly long[] Value=A094665.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094665.Bytes);
public long this[int i]=>Value[i];

public static A094665Inst Instance=new A094665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094666
{
public static readonly long[] Value={ 1393L,8119L,47321L,275807L,1607521L,54608393L,318281039L,1855077841L,10812186007L,367296043199L,2140758220993L,12477253282759L,72722761475561L,423859315570607L,2470433131948081L,14398739476117879L,83922003724759193L };
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
public class A094666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094666Inst : IEnumerable<long>
{
public static readonly long[] Value=A094666.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094666.Bytes);
public long this[int i]=>Value[i];

public static A094666Inst Instance=new A094666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094667
{
public static readonly long[] Value={ 1L,4L,14L,48L,165L,572L,2001L,7056L,25042L,89320L,319793L,1148184L,4131009L,14885468L,53697270L,193862592L,700312381L,2530902676L,9149426897L,33083393640L,119645675898L,432748165304L,1565346866889L,5662560013488L };
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
public class A094667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094667Inst : IEnumerable<long>
{
public static readonly long[] Value=A094667.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094667.Bytes);
public long this[int i]=>Value[i];

public static A094667Inst Instance=new A094667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094668
{
public static readonly long[] Value={ 2L,17L,23L,37L,47L,59L,71L,89L,107L,113L,131L,137L,149L,167L,173L,179L,191L,197L,227L,233L,239L,251L,257L,263L,269L,281L,311L,317L,331L,337L,359L,373L,383L,419L,431L,443L,449L,461L,467L,479L,491L,503L,509L,521L,557L,563L,569L,599L,613L,641L,647L,653L,659L };
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
public class A094668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094668Inst : IEnumerable<long>
{
public static readonly long[] Value=A094668.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094668.Bytes);
public long this[int i]=>Value[i];

public static A094668Inst Instance=new A094668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094669
{
public static readonly long[] Value={ 6L,25L,111L,29L,128L,152L,145L,107L,100L,124L,347L,146L,289L,194L,275L,255L,235L,303L,340L,470L,357L,324L,454L,266L,564L,433L,470L,331L,492L,467L,584L,515L,614L,550L,711L,497L,653L,1039L,577L,694L,749L,755L,779L,666L,752L,913L,769L,754L,724L,691L,883L,827L };
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
public class A094669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094669Inst : IEnumerable<long>
{
public static readonly long[] Value=A094669.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094669.Bytes);
public long this[int i]=>Value[i];

public static A094669Inst Instance=new A094669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094670
{
public static readonly long[] Value={ 1L,2L,4L,16L,7L,5L,3L,9L,33L,19L,81L,25L,353L,183L,39L,201L,103L,37L,205L,77L,681L,263L,3817L,429L,175L,1673L,539L,165L,671L,321L,5875L,477L,173L,2243L,265L,29017L,1011L,677L,9361L,659L,241L,3389L,1123L,163L,2057L,625L,15271L,4481L };
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
public class A094670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094670Inst : IEnumerable<long>
{
public static readonly long[] Value=A094670.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094670.Bytes);
public long this[int i]=>Value[i];

public static A094670Inst Instance=new A094670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094671
{
public static readonly long[] Value={ 2L,2L,0L,2L,4L,6L,8L,11L,14L,17L,20L,23L,26L,29L,32L,36L,39L,43L,46L,50L,53L,57L,61L,64L,68L,72L,76L,80L,84L,88L,92L,96L,100L,104L,108L,112L,117L,121L,125L,129L,134L,138L,142L,147L,151L,155L,160L,164L,169L,173L,178L,182L,187L,192L,196L,201L,205L,210L,215L,219L,224L,229L };
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
public class A094671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094671Inst : IEnumerable<long>
{
public static readonly long[] Value=A094671.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094671.Bytes);
public long this[int i]=>Value[i];

public static A094671Inst Instance=new A094671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094672
{
public static readonly long[] Value={ 7L,25L,52L,59L,86L,127L,132L,135L,162L,169L,193L,198L,201L,214L,215L,218L,251L,256L,259L,286L,293L,317L,322L,325L,338L,339L,342L,352L,356L,359L,386L,393L,417L,422L,425L,438L,469L,501L,506L,509L,536L,543L,567L,572L,575L,588L,589L,592L,625L,630L,633L,660L,667L };
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
public class A094672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094672Inst : IEnumerable<long>
{
public static readonly long[] Value=A094672.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094672.Bytes);
public long this[int i]=>Value[i];

public static A094672Inst Instance=new A094672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094673
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,4L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,4L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,2L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L };
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
public class A094673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094673Inst : IEnumerable<long>
{
public static readonly long[] Value=A094673.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094673.Bytes);
public long this[int i]=>Value[i];

public static A094673Inst Instance=new A094673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094674
{
public static readonly long[] Value={ 1L,-1L,1L,0L,3L,-6L,0L,-15L,1L,0L,45L,0L,105L,-15L,0L,-420L,0L,-945L,1L,0L,210L,0L,4725L,0L,10395L,-28L,0L,-3150L,0L,-62370L,0L,-135135L,1L,0L,630L,0L,51975L,0L,945945L,0L,2027025L,-45L,0L,-13860L,0L,-945945L,0L,-16216200L,0L,-34459425L,1L,0L,1485L,0L,315315L,0L,18918900L,0L };
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
public class A094674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094674Inst : IEnumerable<long>
{
public static readonly long[] Value=A094674.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094674.Bytes);
public long this[int i]=>Value[i];

public static A094674Inst Instance=new A094674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094675
{
public static readonly long[] Value={ 1L,0L,-3L,0L,1L,0L,15L,0L,-10L,0L,-105L,0L,1L,0L,105L,0L,945L,0L,-21L,0L,-1260L,0L,-10395L,0L,1L,0L,378L,0L,17325L,0L,135135L,0L,-36L,0L,-6930L,0L,-270270L,0L,-2027025L,0L,1L,0L,990L,0L,135135L,0L,4729725L,0L,34459425L,0L,-55L,0L,-25740L,0L,-2837835L,0L,-91891800L,0L };
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
public class A094675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094675Inst : IEnumerable<long>
{
public static readonly long[] Value=A094675.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094675.Bytes);
public long this[int i]=>Value[i];

public static A094675Inst Instance=new A094675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094692
{
public static readonly long[] Value={ 4L,7L,4L,9L,4L,9L,3L,7L,9L,9L,8L,7L,9L,2L,0L,6L,5L,0L,3L,3L,2L,5L,0L,4L,6L,3L,6L,3L,2L,7L,9L,8L,2L,9L,6L,8L,5L,5L,9L,5L,4L,9L,3L,7L,3L,2L,1L,7L,2L,0L,2L,9L,8L,2L,2L,8L,3L,3L,3L,1L,0L,2L,4L,8L,6L,4L,5L,5L,7L,9L,2L,9L,1L,7L,4L,8L,8L,3L,8L,6L,0L,2L,7L,4L,2L,7L,5L,6L,4L,1L,2L,5L,0L,5L,0L,2L,1L,4L,4L,4L,1L,8L,9L,0L,3L };
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
public class A094692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094692Inst : IEnumerable<long>
{
public static readonly long[] Value=A094692.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094692.Bytes);
public long this[int i]=>Value[i];

public static A094692Inst Instance=new A094692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094693
{
public static readonly long[] Value={ 0L,1L,5L,11L,19L,27L,36L,47L,58L,70L,83L,96L,110L,125L,140L,156L,173L,190L,207L,225L,244L,263L,282L,302L,322L,343L,364L,386L,408L,430L,453L,476L,500L,524L,548L,573L,598L,624L,650L,676L,702L,729L,756L,784L,811L,840L,868L,897L,926L,955L,985L,1015L,1045L,1076L,1107L,1138L,1169L };
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
public class A094693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094693Inst : IEnumerable<long>
{
public static readonly long[] Value=A094693.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094693.Bytes);
public long this[int i]=>Value[i];

public static A094693Inst Instance=new A094693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094694
{
public static readonly long[] Value={ 23L,46L,47L,92L,94L,95L,111L,184L,188L,190L,191L,222L,223L,367L,368L,376L,380L,382L,383L,415L,444L,446L,447L,479L,727L,734L,736L,752L,760L,764L,766L,767L,830L,831L,887L,888L,892L,894L,895L,958L,959L,1451L,1454L,1468L,1471L,1472L,1503L,1504L,1520L,1528L };
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
public class A094694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094694Inst : IEnumerable<long>
{
public static readonly long[] Value=A094694.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094694.Bytes);
public long this[int i]=>Value[i];

public static A094694Inst Instance=new A094694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094695
{
public static readonly long[] Value={ 5L,9L,10L,11L,13L,17L,18L,19L,20L,21L,22L,25L,26L,27L,29L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,49L,50L,51L,52L,53L,54L,55L,57L,58L,59L,61L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,93L,97L,98L,99L };
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
public class A094695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094695Inst : IEnumerable<long>
{
public static readonly long[] Value=A094695.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094695.Bytes);
public long this[int i]=>Value[i];

public static A094695Inst Instance=new A094695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094696
{
public static readonly long[] Value={ 0L,1L,6L,13L,19L,21L };
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
public class A094696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094696Inst : IEnumerable<long>
{
public static readonly long[] Value=A094696.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094696.Bytes);
public long this[int i]=>Value[i];

public static A094696Inst Instance=new A094696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094697
{
public static readonly long[] Value={ 1L,2L,3L,7L,25L,73L };
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
public class A094697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094697Inst : IEnumerable<long>
{
public static readonly long[] Value=A094697.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094697.Bytes);
public long this[int i]=>Value[i];

public static A094697Inst Instance=new A094697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094698
{
public static readonly long[] Value={ 0L,1L,6L,7L,9L,11L,17L,19L,43L,73L,75L,80L,88L,96L,107L,131L,166L,193L,201L,258L,263L,268L,271L,298L,335L,340L,443L,479L,484L };
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
public class A094698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094698Inst : IEnumerable<long>
{
public static readonly long[] Value=A094698.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094698.Bytes);
public long this[int i]=>Value[i];

public static A094698Inst Instance=new A094698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094699
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,4L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L };
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
public class A094699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094699Inst : IEnumerable<long>
{
public static readonly long[] Value=A094699.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094699.Bytes);
public long this[int i]=>Value[i];

public static A094699Inst Instance=new A094699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094700
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,5L,6L,4L,4L,6L,7L,13L,9L,8L,5L,7L,5L,6L,8L,5L,8L,17L,7L,10L,6L,7L,10L,10L,10L,10L,10L,13L,12L,11L,36L,14L,13L,5L,9L,8L,12L,12L,31L,26L,14L,17L,19L,18L,14L,15L,10L,21L,10L,19L,30L,17L,9L,9L,59L,7L,16L,36L,11L,37L,23L,67L,19L,47L,19L,25L,39L,70L,13L,10L,52L,77L,24L };
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
public class A094700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094700Inst : IEnumerable<long>
{
public static readonly long[] Value=A094700.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094700.Bytes);
public long this[int i]=>Value[i];

public static A094700Inst Instance=new A094700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094701
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,1L,2L,2L,3L,3L,2L,3L,2L,4L,5L,2L,2L,3L,2L,4L,7L,4L,2L,2L,5L,4L,3L,1L,2L,5L,2L,2L,9L,4L,18L,3L,2L,4L,9L,4L,2L,7L,2L,6L,3L,4L,2L,3L,7L,5L,9L,5L,2L,3L,7L,3L,9L,4L,2L,5L,2L,4L,7L,2L,11L,7L,2L,9L,9L,10L,2L,3L,2L,4L,12L,4L,10L,7L,2L,5L,3L,4L,2L,3L,13L,4L,9L,4L,2L,5L,9L,9L,9L,4L,19L,3L,2L,7L,5L,5L,2L,7L };
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
public class A094701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094701Inst : IEnumerable<long>
{
public static readonly long[] Value=A094701.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094701.Bytes);
public long this[int i]=>Value[i];

public static A094701Inst Instance=new A094701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094702
{
public static readonly long[] Value={ 2L,12L,42L,90L,110L,152L,171L,208L,231L,336L,408L,476L,506L,765L,783L,840L,1242L,1380L,1584L,1911L,2120L,2162L,2528L,2604L,2688L,2706L,2720L,2970L,3162L,3172L,3325L,3392L,3422L,3619L,3654L,3708L,3870L,4144L,4371L,4472L,4508L,4712L,4760L,4876L,5256L,5372L };
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
public class A094702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094702Inst : IEnumerable<long>
{
public static readonly long[] Value=A094702.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094702.Bytes);
public long this[int i]=>Value[i];

public static A094702Inst Instance=new A094702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094703
{
public static readonly ulong[] Value={ 1L,11L,109L,1103L,11113L,112067L,1129909L,11392679L,114869521L,1158202427L,11677879357L,117745285823L,1187197753081L,11970233026931L,120693017030149L,1216919029806743L,12269905596087073L,123714544394638187L,1247384372674934029L,12577080413686874159UL };
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
public class A094703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094703Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A094703.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094703.Bytes);
public ulong this[int i]=>Value[i];

public static A094703Inst Instance=new A094703Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094704
{
public static readonly long[] Value={ 0L,1L,11L,112L,1123L,11235L,112358L,1123593L,11235951L,112359544L,1123595495L,11235955039L,112359550534L,1123595505573L,11235955056107L,112359550561680L,1123595505617787L,11235955056179467L,112359550561797254L };
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
public class A094704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094704Inst : IEnumerable<long>
{
public static readonly long[] Value=A094704.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094704.Bytes);
public long this[int i]=>Value[i];

public static A094704Inst Instance=new A094704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094705
{
public static readonly long[] Value={ 0L,1L,4L,15L,50L,161L,504L,1555L,4750L,14421L,43604L,131495L,395850L,1190281L,3576304L,10739835L,32241350L,96767741L,290390604L,871346575L,2614389250L,7843866801L,23532998504L,70601791715L,211810967550L,635444087461L,1906354632004L,5719108635255L,17157415384250L };
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
public class A094705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094705Inst : IEnumerable<long>
{
public static readonly long[] Value=A094705.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094705.Bytes);
public long this[int i]=>Value[i];

public static A094705Inst Instance=new A094705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094706
{
public static readonly long[] Value={ 0L,1L,4L,13L,38L,105L,280L,729L,1866L,4717L,11812L,29365L,72590L,178641L,438064L,1071153L,2613138L,6362965L,15470140L,37565389L,91125206L,220864377L,534951112L,1294960905L,3133261530L,7578261181L,18323338324L,44292046693L,107041649438L };
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
public class A094706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094706Inst : IEnumerable<long>
{
public static readonly long[] Value=A094706.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094706.Bytes);
public long this[int i]=>Value[i];

public static A094706Inst Instance=new A094706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094707
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,4L,6L,8L,11L,14L,19L,24L,32L,40L,53L,66L,87L,108L,142L,176L,231L,286L,375L,464L,608L,752L,985L,1218L,1595L,1972L,2582L,3192L,4179L,5166L,6763L,8360L,10944L,13528L,17709L,21890L,28655L,35420L,46366L,57312L,75023L,92734L,121391L,150048L,196416L };
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
public class A094707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094707Inst : IEnumerable<long>
{
public static readonly long[] Value=A094707.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094707.Bytes);
public long this[int i]=>Value[i];

public static A094707Inst Instance=new A094707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094708
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,2L,2L,2L,3L,3L,4L,4L,4L,4L,5L,5L,5L,6L,6L,7L,7L,7L,7L,8L,8L,9L,9L,9L,9L,10L,10L,11L,11L,11L,11L,12L,12L,13L,13L,13L,13L,13L,14L,14L,15L,15L,15L,16L,16L,16L,17L,17L,18L,18L,18L,18L,19L,19L,19L,19L,20L,21L };
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
public class A094708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094708Inst : IEnumerable<long>
{
public static readonly long[] Value=A094708.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094708.Bytes);
public long this[int i]=>Value[i];

public static A094708Inst Instance=new A094708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094709
{
public static readonly long[] Value={ 0L,1L,1L,13L,1L,17L,59L,23L,79L,101L,83L,239L,71L,149L,367L,73L,911L,313L,373L,523L,313L,331L,197L,101L,1493L,523L,293L,577L,2699L,1481L,1453L,5647L,647L,419L,757L,4253L,509L,239L,10499L,191L,4013L,2659L,617L,6733L,1297L,971L };
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
public class A094709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094709Inst : IEnumerable<long>
{
public static readonly long[] Value=A094709.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094709.Bytes);
public long this[int i]=>Value[i];

public static A094709Inst Instance=new A094709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094710
{
public static readonly BigInteger[] Value={ 5L,29L,197L,2309L,30013L,510451L,9699667L,223092791L,6469693129L,200560490047L,7420738134571L,304250263527139L,13082761331669881L,614889782588491043L,BigInteger.Parse("32589158477190044657"),BigInteger.Parse("1922760350154212638159"),BigInteger.Parse("117288381359406970982957"),BigInteger.Parse("7858321551080267055878717"),BigInteger.Parse("557940830126698960967414867") };
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
public class A094710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094710Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094710.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094710.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094710Inst Instance=new A094710Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094711
{
public static readonly BigInteger[] Value={ 7L,31L,223L,2311L,30047L,510569L,9699713L,223092949L,6469693331L,200560490213L,7420738135049L,304250263527281L,13082761331670179L,614889782588491777L,BigInteger.Parse("32589158477190044803"),BigInteger.Parse("1922760350154212639981"),BigInteger.Parse("117288381359406970983583") };
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
public class A094711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094711Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094711.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094711.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094711Inst Instance=new A094711Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094712
{
public static readonly long[] Value={ 2L,5L,7L,13L,23L,31L,37L,47L,71L,79L,103L,127L,151L,167L,191L,199L,223L,239L,263L,271L,311L,359L,367L,383L,431L,439L,463L,479L,487L,503L,599L,607L,631L,647L,719L,727L,743L,751L,823L,839L,863L,887L,911L,919L,967L,983L,991L };
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
public class A094712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094712Inst : IEnumerable<long>
{
public static readonly long[] Value=A094712.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094712.Bytes);
public long this[int i]=>Value[i];

public static A094712Inst Instance=new A094712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094713
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,2L,1L,0L,1L,2L,1L,1L,0L,1L,0L,2L,3L,1L,3L,0L,2L,1L,2L,0L,3L,2L,2L,3L,0L,1L,1L,0L,3L,3L,2L,0L,1L,2L,0L,2L,0L,3L,2L,3L,0L,3L,4L,4L,0L,5L,0L,1L,5L,2L,4L,2L,0L,2L,2L,2L,2L,3L,3L,4L,0L,0L,2L,2L,0L,5L,1L,5L,4L,5L,2L,0L,3L,0L,3L,5L,2L,7L,0L,4L,0L,0L,5L,2L,0L,7L,8L,3L,2L,2L,4L,5L,8L,3L };
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
public class A094713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094713Inst : IEnumerable<long>
{
public static readonly long[] Value=A094713.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094713.Bytes);
public long this[int i]=>Value[i];

public static A094713Inst Instance=new A094713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094714
{
public static readonly long[] Value={ 2L,3L,41L,89L,251L,269L,593L,461L,521L,929L,761L,941L,1109L,1481L,1601L,1361L,2309L,1949L,1889L,2141L,2729L,2609L,3701L,3461L,3989L,3449L,5309L,4241L,4289L,5081L,7589L,5381L,9521L,6569L,8861L,7229L,7829L,8501L,8069L,13781L,8609L,12689L,10601L,11261L,14741L };
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
public class A094714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094714Inst : IEnumerable<long>
{
public static readonly long[] Value=A094714.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094714.Bytes);
public long this[int i]=>Value[i];

public static A094714Inst Instance=new A094714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094715
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,10L,2L,35L,29L,85L,211L,220L,926L,1001L,3095L,5461L,9829L,25126L,37130L,97223L,164921L,349525L,728575L,1309528L,2973350L,5326685L,11450531L,22369621L,43942081L,91869970L,174174002L,365088395L,708653429L,1431655765L,2884834891L };
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
public class A094715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094715Inst : IEnumerable<long>
{
public static readonly long[] Value=A094715.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094715.Bytes);
public long this[int i]=>Value[i];

public static A094715Inst Instance=new A094715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094716
{
public static readonly long[] Value={ 0L,1L,2L,36L,4L,36L,6L,18L,8L,140L,36L,36L,36L,46L,36L,58L,16L,70L,18L,140L,20L,140L,22L,110L,24L,52214L,36L,140L,36L,156L,36L,172L,36L,2598L,36L,2978L,36L,24906114455136L,38L,233046L,40L,262L,42L,4710L,44L,5222L,46L,322L,48L,342L,50L,364L,52L,7554L,54L,8210L,56L,430L,58L,946636L };
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
public class A094716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094716Inst : IEnumerable<long>
{
public static readonly long[] Value=A094716.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094716.Bytes);
public long this[int i]=>Value[i];

public static A094716Inst Instance=new A094716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094717
{
public static readonly long[] Value={ 1L,1L,2L,5L,12L,36L,113L,351L,1080L,3281L,9882L,29646L,88817L,266085L,797526L,2391485L,7173360L,21520080L,64563521L,193700403L,581120892L,1743392201L,5230206126L,15690618378L,47071766561L,141215033961L,423644570442L,1270932914165L };
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
public class A094717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094717Inst : IEnumerable<long>
{
public static readonly long[] Value=A094717.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094717.Bytes);
public long this[int i]=>Value[i];

public static A094717Inst Instance=new A094717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094718
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,2L,2L,1L,0L,1L,2L,3L,4L,1L,0L,1L,2L,3L,5L,4L,1L,0L,1L,2L,3L,6L,8L,8L,1L,0L,1L,2L,3L,6L,9L,13L,8L,1L,0L,1L,2L,3L,6L,10L,18L,21L,16L,1L,0L,1L,2L,3L,6L,10L,19L,27L,34L,16L,1L,0L,1L,2L,3L,6L,10L,20L,33L,54L,55L,32L,1L,0L,1L,2L,3L,6L,10L,20L,34L,61L,81L,89L,32L,1L };
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
public class A094718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094718Inst : IEnumerable<long>
{
public static readonly long[] Value=A094718.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094718.Bytes);
public long this[int i]=>Value[i];

public static A094718Inst Instance=new A094718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094719
{
public static readonly long[] Value={ 1L,2L,4L,6L,11L,16L,29L,43L,78L,119L,217L,340L,624L,1000L,1847L,3015L,5602L,9282L,17341L,29084L,54605L,92512L,174455L,298110L,564332L,971562L,1845363L,3198129L,6092037L,10621152L,20282470L,35554558L,68042536L,119874493L,229840129L };
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
public class A094719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094719Inst : IEnumerable<long>
{
public static readonly long[] Value=A094719.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094719.Bytes);
public long this[int i]=>Value[i];

public static A094719Inst Instance=new A094719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094720
{
public static readonly long[] Value={ 1L,2L,0L,3L,5L,6L,4L,9L,1L,6L,7L,4L,9L,6L,1L,0L,3L,3L,4L,2L,8L,6L,2L,8L,3L,3L,3L,8L,1L,4L,8L,7L,3L,1L,3L,1L,7L,7L,5L,5L,5L,2L,8L,3L,8L,5L,7L,7L,0L,9L,6L,0L,7L,4L,0L,3L,9L,0L,3L,8L,2L,4L,2L,7L,8L,1L,0L,9L,4L,2L,0L,5L,9L,6L,0L,6L,5L,9L,9L,6L,1L,4L,0L,3L,4L,1L,9L,8L,1L,9L,2L,3L,0L,9L,4L,4L,4L,9L,2L,8L,9L,3L,7L,1L,4L };
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
public class A094720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094720Inst : IEnumerable<long>
{
public static readonly long[] Value=A094720.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094720.Bytes);
public long this[int i]=>Value[i];

public static A094720Inst Instance=new A094720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094721
{
public static readonly long[] Value={ 2L,0L,2L,5L,4L,3L,8L,4L,6L,7L,7L,7L,6L,5L,7L,3L,8L,8L,7L,7L,1L,3L,5L,1L,8L,7L,3L,9L,1L,4L,1L,7L,6L,5L,2L,4L,7L,0L,6L,5L,2L,9L,3L,0L,6L,1L,7L,6L,5L,8L,2L,8L,3L,9L,5L,5L,6L,2L,9L,2L,4L,7L,5L,5L,2L,6L,2L,3L,2L,4L,2L,5L,0L,9L,6L,3L,2L,5L,4L,7L,3L,7L,9L,1L,9L,3L,2L,2L,0L,8L,4L,1L,6L,5L,3L,8L,6L,5L,9L,6L,8L,6L,4L,7L,5L };
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
public class A094721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094721Inst : IEnumerable<long>
{
public static readonly long[] Value=A094721.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094721.Bytes);
public long this[int i]=>Value[i];

public static A094721Inst Instance=new A094721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094722
{
public static readonly long[] Value={ 3657500101L,88362852307L,2428095424619L,12055296811267L,75063692618249L,156740126985437L };
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
public class A094722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094722Inst : IEnumerable<long>
{
public static readonly long[] Value=A094722.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094722.Bytes);
public long this[int i]=>Value[i];

public static A094722Inst Instance=new A094722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094723
{
public static readonly long[] Value={ 1L,3L,8L,21L,54L,137L,344L,857L,2122L,5229L,12836L,31413L,76686L,186833L,454448L,1103921L,2678674L,6494037L,15732284L,38089677L,92173782L,222961529L,539145416L,1303349513L,3150038746L,7611815613L,18390447188L,44426264421L,107310084894L };
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
public class A094723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094723Inst : IEnumerable<long>
{
public static readonly long[] Value=A094723.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094723.Bytes);
public long this[int i]=>Value[i];

public static A094723Inst Instance=new A094723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094756
{
public static readonly long[] Value={ 2L,4L,2L,7L,2L,4L,2L,7L,2L,4L,2L,16L,2L,4L,2L,7L,2L,4L,2L,7L,2L,4L,2L,16L,2L,4L,2L,7L,2L,4L,2L,7L,2L,4L,2L,16L,2L,4L,2L,7L,2L,4L,2L,7L,2L,4L,2L,22L,2L,4L,2L,7L,2L,4L,2L,7L,2L,4L,2L,16L,2L,4L,2L,7L,2L,4L,2L,7L,2L,4L,2L,16L,2L,4L,2L,7L,2L,4L,2L,7L,2L,4L,2L,16L,2L,4L,2L,7L,2L,4L,2L,7L,2L,4L,2L,22L,2L,4L,2L,7L,2L,4L };
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
public class A094756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094756Inst : IEnumerable<long>
{
public static readonly long[] Value=A094756.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094756.Bytes);
public long this[int i]=>Value[i];

public static A094756Inst Instance=new A094756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094757
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,2L,7L,2L,9L,10L,11L,12L,13L,14L,10L,16L,17L,18L,19L,10L,21L,22L,23L,16L,25L,26L,27L,28L,29L,27L,31L,32L,27L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,40L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,56L,64L,65L,66L,67L,68L,69L,70L,71L,72L };
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
public class A094757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094757Inst : IEnumerable<long>
{
public static readonly long[] Value=A094757.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094757.Bytes);
public long this[int i]=>Value[i];

public static A094757Inst Instance=new A094757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094758
{
public static readonly long[] Value={ 1L,1L,3L,4L,5L,3L,7L,8L,9L,5L,11L,8L,13L,7L,15L,16L,17L,9L,19L,20L,21L,11L,23L,9L,25L,13L,27L,28L,29L,15L,31L,32L,33L,17L,35L,36L,37L,19L,39L,40L,41L,21L,43L,44L,45L,23L,47L,48L,49L,25L,51L,52L,53L,27L,55L,56L,57L,29L,59L,40L,61L,31L,63L,64L,65L,33L,67L,68L,69L,35L,71L,72L,73L,37L };
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
public class A094758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094758Inst : IEnumerable<long>
{
public static readonly long[] Value=A094758.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094758.Bytes);
public long this[int i]=>Value[i];

public static A094758Inst Instance=new A094758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094759
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,6L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L };
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
public class A094759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094759Inst : IEnumerable<long>
{
public static readonly long[] Value=A094759.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094759.Bytes);
public long this[int i]=>Value[i];

public static A094759Inst Instance=new A094759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094760
{
public static readonly long[] Value={ 1L,33L,666L,11110L,166665L,2333331L,31111108L,399999996L,4999999995L };
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
public class A094760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094760Inst : IEnumerable<long>
{
public static readonly long[] Value=A094760.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094760.Bytes);
public long this[int i]=>Value[i];

public static A094760Inst Instance=new A094760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094761
{
public static readonly long[] Value={ 0L,1L,3L,5L,4L,6L,8L,10L,12L,9L,11L,13L,15L,17L,19L,21L,16L,18L,20L,22L,24L,26L,28L,30L,32L,25L,27L,29L,31L,33L,35L,37L,39L,41L,43L,45L,36L,38L,40L,42L,44L,46L,48L,50L,52L,54L,56L,58L,60L,49L,51L,53L,55L,57L,59L,61L,63L,65L,67L,69L,71L,73L,75L,77L,64L,66L,68L,70L,72L,74L,76L,78L };
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
public class A094761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094761Inst : IEnumerable<long>
{
public static readonly long[] Value=A094761.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094761.Bytes);
public long this[int i]=>Value[i];

public static A094761Inst Instance=new A094761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094762
{
public static readonly long[] Value={ 1L,2L,4L,11L,41L,177L,820L,4020L,20900L,115473L,677557L,4211561L,27640354L,190891144L,1382942176L,10480109395L,82864804285L,682076675105L,5832741942932L,51724157711104L,474869815108196L,4506715736350193L,44152005850890065L,445958869286416705L };
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
public class A094762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094762Inst : IEnumerable<long>
{
public static readonly long[] Value=A094762.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094762.Bytes);
public long this[int i]=>Value[i];

public static A094762Inst Instance=new A094762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094763
{
public static readonly long[] Value={ 2L,3L,5L,6L,8L,12L,15L,21L,26L,27L,29L,33L,41L,46L,56L,63L,77L,90L,99L,117L,134L,147L,150L,156L,168L,192L,215L,234L,243L,261L,266L,276L,296L,303L,317L,345L,366L,371L,381L,401L,402L,404L,408L,416L,432L,464L,487L,490L,496L,508L,532L,535L,541L,553L,577L,578L,580L,584L,592L,608L };
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
public class A094763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094763Inst : IEnumerable<long>
{
public static readonly long[] Value=A094763.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094763.Bytes);
public long this[int i]=>Value[i];

public static A094763Inst Instance=new A094763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094764
{
public static readonly long[] Value={ 7L,10L,11L,13L,17L,18L,20L,24L,32L,39L,42L,48L,60L,71L,78L,92L,103L,106L,112L,124L,127L,133L,145L,146L,148L,152L,160L,176L,183L,197L,198L,200L,204L,212L,228L,231L,237L,249L,273L,290L,291L,293L,297L,305L,321L,353L,382L,403L,406L,412L,424L,448L,455L,469L,497L,510L,536L,543L };
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
public class A094764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094764Inst : IEnumerable<long>
{
public static readonly long[] Value=A094764.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094764.Bytes);
public long this[int i]=>Value[i];

public static A094764Inst Instance=new A094764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094765
{
public static readonly long[] Value={ 0L,1L,4L,7L,4L,7L,10L,13L,16L,9L,12L,15L,18L,21L,24L,27L,16L,19L,22L,25L,28L,31L,34L,37L,40L,25L,28L,31L,34L,37L,40L,43L,46L,49L,52L,55L,36L,39L,42L,45L,48L,51L,54L,57L,60L,63L,66L,69L,72L,49L,52L,55L,58L,61L,64L,67L,70L,73L,76L,79L,82L,85L,88L,91L,64L,67L,70L,73L,76L,79L,82L,85L,88L,91L };
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
public class A094765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094765Inst : IEnumerable<long>
{
public static readonly long[] Value=A094765.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094765.Bytes);
public long this[int i]=>Value[i];

public static A094765Inst Instance=new A094765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094766
{
public static readonly long[] Value={ 11L,15L,27L,31L,43L,57L,73L,91L,111L,133L,157L,183L,211L,241L,273L,307L,343L,381L,421L,463L,507L,553L,601L,651L,703L,757L,813L,871L,931L,993L,1057L,1123L,1191L,1261L,1333L,1407L,1483L,1561L,1641L,1723L,1807L,1893L,1981L,2071L,2163L,2257L,2353L,2451L,2551L,2653L };
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
public class A094766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094766Inst : IEnumerable<long>
{
public static readonly long[] Value=A094766.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094766.Bytes);
public long this[int i]=>Value[i];

public static A094766Inst Instance=new A094766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094767
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,13L,26L,40L,81L,123L,205L,412L,620L,1034L,2072L,3120L,5204L,8332L,16677L,25056L,41772L,66854L,133748L,200749L,334741L,535694L,870558L,1741321L,2612619L,4355177L,6968828L,11324625L,22650284L,33978635L,56635145L,90624176L,147267645L };
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
public class A094767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094767Inst : IEnumerable<long>
{
public static readonly long[] Value=A094767.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094767.Bytes);
public long this[int i]=>Value[i];

public static A094767Inst Instance=new A094767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094768
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,9L,16L,25L,42L,68L,110L,179L,291L,470L,763L,1236L,2005L,3241L,5252L,8502L,13770L,22272L,36058L,58355L,94455L,152878L,247333L,400279L,647722L,1048180L,1696193L,2744373L,4440857L,7185700L,11627320L,18814256L,30443581L,49257837L };
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
public class A094768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094768Inst : IEnumerable<long>
{
public static readonly long[] Value=A094768.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094768.Bytes);
public long this[int i]=>Value[i];

public static A094768Inst Instance=new A094768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094769
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,6L,12L,18L,37L,56L,94L,189L,285L,475L,952L,1434L,2392L,3830L,7666L,11518L,19202L,30732L,61482L,92281L,153874L,246248L,400178L,800450L,1200967L,2001985L,3203426L,5205696L,10411867L,15619275L,26034003L,41658056L,67695885L,109356333L };
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
public class A094769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094769Inst : IEnumerable<long>
{
public static readonly long[] Value=A094769.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094769.Bytes);
public long this[int i]=>Value[i];

public static A094769Inst Instance=new A094769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094770
{
public static readonly long[] Value={ 8L,1L,8L,9L,0L,9L,3L,9L,3L,3L,7L,0L,3L,3L,5L,9L,1L,7L,7L,5L,9L,6L,7L,2L,4L,2L,5L,3L,4L,8L,0L,8L,5L,0L,8L,9L,9L,9L,8L,4L,9L,4L,4L,3L,1L,9L,3L,8L,9L,2L,5L,9L,7L,1L,3L,4L,4L,8L,8L,5L,0L,2L,3L,3L,2L,6L,0L,0L,3L,3L,9L,2L,3L,9L,3L,2L,2L,8L,0L,9L,8L,2L,3L,0L,0L,8L,5L,3L,9L,5L,2L,6L,4L,7L,0L,8L,8L,2L,6L,7L,5L,9L,5L,4L,0L };
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
public class A094770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094770Inst : IEnumerable<long>
{
public static readonly long[] Value=A094770.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094770.Bytes);
public long this[int i]=>Value[i];

public static A094770Inst Instance=new A094770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094771
{
public static readonly long[] Value={ 3L,5L,0L,6L,8L,0L,1L,2L,4L,6L,0L,6L,6L,0L,4L,2L,6L,0L,4L,8L,6L,2L,4L,6L,0L,2L,0L,6L,0L,4L,8L,6L,3L,4L,2L,4L,5L,6L,4L,9L,6L,4L,1L,1L,1L,2L,4L,0L,1L,5L,2L,0L,9L,4L,4L,5L,0L,2L,4L,4L,7L,7L,5L,9L,1L,4L,7L,3L,5L,4L,4L,8L,4L,8L,8L,5L,3L,6L,1L,4L,2L,0L,6L,8L,9L,9L,2L,3L,9L,0L,5L,2L,3L,8L,9L,4L,0L,2L,5L,0L,6L,6L,3L,1L,3L };
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
public class A094771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094771Inst : IEnumerable<long>
{
public static readonly long[] Value=A094771.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094771.Bytes);
public long this[int i]=>Value[i];

public static A094771Inst Instance=new A094771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094804
{
public static readonly long[] Value={ 0L,0L,1L,4L,1L,3L,1L,2L,1L,2L,4L,2L,4L,2L,4L,2L,1L,2L,1L,3L,1L,2L,1L,5L,1L,2L,3L,2L,3L,5L,3L,3L,3L,2L,3L,2L,1L,2L,1L,2L,1L,2L,1L,3L,1L,1L,1L,3L,1L,4L,2L,3L,2L,3L,2L,2L,2L,1L,2L,4L,2L,3L,2L,1L,1L,1L,1L,6L,1L,4L,1L,2L,1L,3L,1L,1L,1L,3L,1L,4L,1L,1L,2L,3L,2L,4L,2L,3L,2L,3L,2L,5L,2L,5L,2L,2L,2L,4L,2L,1L,4L,3L,4L,2L,4L };
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
public class A094804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094804Inst : IEnumerable<long>
{
public static readonly long[] Value=A094804.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094804.Bytes);
public long this[int i]=>Value[i];

public static A094804Inst Instance=new A094804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094805
{
public static readonly long[] Value={ 6L,210L,840L,341880L,71831760L,64648584000L,2216650756320L };
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
public class A094805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094805Inst : IEnumerable<long>
{
public static readonly long[] Value=A094805.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094805.Bytes);
public long this[int i]=>Value[i];

public static A094805Inst Instance=new A094805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094806
{
public static readonly long[] Value={ 1L,5L,20L,74L,264L,924L,3200L,11016L,37792L,129392L,442496L,1512224L,5165952L,17643456L,60250112L,205729920L,702452224L,2398414592L,8188884992L,27958972928L,95458646016L,325917686784L,1112755552256L,3799191029760L,12971261403136L,44286680330240L };
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
public class A094806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094806Inst : IEnumerable<long>
{
public static readonly long[] Value=A094806.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094806.Bytes);
public long this[int i]=>Value[i];

public static A094806Inst Instance=new A094806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094807
{
public static readonly long[] Value={ 12L,60L,120L,168L,360L,420L,660L,1008L,1092L,1260L,1680L,1848L,1980L,2448L,2640L,2772L,3120L,3420L,3432L,4620L,4680L,5148L,5460L,6072L,7140L,7800L,8160L,8580L,9240L,9828L,10032L,11220L,11628L,12180L,13260L,14280L,14880L,15708L,15912L,15960L,17940L };
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
public class A094807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094807Inst : IEnumerable<long>
{
public static readonly long[] Value=A094807.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094807.Bytes);
public long this[int i]=>Value[i];

public static A094807Inst Instance=new A094807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094808
{
public static readonly BigInteger[] Value={ 5L,136L,10959L,26840L,2495955L,10021808981L,25377192720L,2681584376185L,113220181313816L,12360536835574179L,3507176714646157575L,BigInteger.Parse("152669979363491409744"),BigInteger.Parse("5030798638073511770858765") };
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
public class A094808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094808Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094808.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094808.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094808Inst Instance=new A094808Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094809
{
public static readonly BigInteger[] Value={ 3L,29L,152L,2016L,1056437L,16311831L,102287808L,1627690024L,1085424779823L,17876295136009L,1933742696582736L,1394864457161925217L,BigInteger.Parse("23571778916504612451"),BigInteger.Parse("155523623837575361328"),BigInteger.Parse("2642576343530770503704") };
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
public class A094809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094809Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094809.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094809.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094809Inst Instance=new A094809Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094810
{
public static readonly BigInteger[] Value={ 3L,5L,11L,23L,53L,307L,769L,5039L,13049L,603667L,1578823L,10810469L,427860443429L,16944504081930151L,BigInteger.Parse("31525215457325198354227") };
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
public class A094810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094810Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094810.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094810.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094810Inst Instance=new A094810Inst();

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