using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A112079
{
public static readonly long[] Value={ 529L,10559L,15791L,34271L,39959L,50951L,53231L,53881L,65159L,69599L,82871L,85801L,86641L,88079L,88919L,92039L,92569L,97919L,102001L,113879L,117121L,123191L,128519L,129191L,130729L,138311L,142271L,144169L,152591L,157249L };
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
public class A112079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112079Inst : IEnumerable<long>
{
public static readonly long[] Value=A112079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112079.Bytes);
public long this[int i]=>Value[i];

public static A112079Inst Instance=new A112079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112080
{
public static readonly long[] Value={ 0L,2L,-2L,0L,4L,0L,8L,-2L,0L,0L,0L,12L,-6L,0L,12L,0L,2L,-2L,0L,-6L,0L,18L,-6L,0L,0L,0L,2L,-6L,0L,-4L,0L,2L,-2L,0L,18L,0L,2L,-2L,0L,24L,0L,6L,-2L,0L,0L,0L,6L,-8L,0L,4L,0L,2L,-2L,0L,-6L,0L,32L,-6L,0L,0L,0L,2L,-6L,0L,-10L,0L,2L,-2L,0L,28L,0L,2L,-2L,0L,4L,0L,38L,-2L,0L,0L,0L,6L,-6L,0L,4L,0L,2L };
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
public class A112080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112080Inst : IEnumerable<long>
{
public static readonly long[] Value=A112080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112080.Bytes);
public long this[int i]=>Value[i];

public static A112080Inst Instance=new A112080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112081
{
public static readonly long[] Value={ 0L,1L,-1L,0L,2L,0L,4L,-1L,0L,0L,0L,6L,-3L,0L,6L,0L,1L,-1L,0L,-3L,0L,9L,-3L,0L,0L,0L,1L,-3L,0L,-2L,0L,1L,-1L,0L,9L,0L,1L,-1L,0L,12L,0L,3L,-1L,0L,0L,0L,3L,-4L,0L,2L,0L,1L,-1L,0L,-3L,0L,16L,-3L,0L,0L,0L,1L,-3L,0L,-5L,0L,1L,-1L,0L,14L,0L,1L,-1L,0L,2L,0L,19L,-1L,0L,0L,0L,3L,-3L,0L,2L,0L,1L,-1L,0L };
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
public class A112081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112081Inst : IEnumerable<long>
{
public static readonly long[] Value=A112081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112081.Bytes);
public long this[int i]=>Value[i];

public static A112081Inst Instance=new A112081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112082
{
public static readonly long[] Value={ 1L,4L,6L,9L,10L,11L,14L,16L,19L,21L,24L,25L,26L,29L,31L,34L,36L,39L,41L,44L,45L,46L,49L,51L,54L,56L,59L,60L,61L,64L,66L,69L,71L,74L,76L,79L,80L,81L,84L,86L,89L,91L,94L,95L,96L,99L,101L,104L,105L,106L,109L,111L,114L,115L,116L,119L,121L,124L,126L,129L,130L,131L,134L };
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
public class A112082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112082Inst : IEnumerable<long>
{
public static readonly long[] Value=A112082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112082.Bytes);
public long this[int i]=>Value[i];

public static A112082Inst Instance=new A112082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112083
{
public static readonly long[] Value={ 2L,4L,12L,35L,155L,239L,779L,2855L,5279L,9095L,15695L,59135L,350699L,183395L,1352339L,1477295L,1077959L,6922920L,3038555L,12705840L,14199120L };
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
public class A112083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112083Inst : IEnumerable<long>
{
public static readonly long[] Value=A112083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112083.Bytes);
public long this[int i]=>Value[i];

public static A112083Inst Instance=new A112083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112084
{
public static readonly long[] Value={ 5L,9L,25L,71L,311L,479L,1559L,5711L,10559L,18191L,31391L,118271L,701399L,366791L,2704679L,2954591L,2155919L,13845841L,6077111L,25411681L,28398241L };
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
public class A112084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112084Inst : IEnumerable<long>
{
public static readonly long[] Value=A112084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112084.Bytes);
public long this[int i]=>Value[i];

public static A112084Inst Instance=new A112084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112085
{
public static readonly long[] Value={ 1L,2L,2L,1L,4L,1L,2L,2L,1L,2L,2L,1L,4L,1L,2L,2L,1L,2L,2L,1L,2L,2L,1L,4L,1L,2L,2L,1L,2L,2L,1L,4L,1L,2L,2L,1L,2L,2L,1L,2L,2L,1L,4L,1L,2L,2L,1L,2L,2L,1L,4L,1L,2L,2L,1L,4L,1L,2L,2L,1L,4L,1L,2L,2L,1L,2L,2L,1L,4L,1L,2L,2L,1L,4L,1L,2L,2L,1L,4L,1L,2L,2L,1L,2L,2L,1L,4L,1L,2L,2L,1L,2L,2L,1L,2L,2L,1L,4L,1L,2L,2L,1L };
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
public class A112085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112085Inst : IEnumerable<long>
{
public static readonly long[] Value=A112085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112085.Bytes);
public long this[int i]=>Value[i];

public static A112085Inst Instance=new A112085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112086
{
public static readonly long[] Value={ 2L,4L,6L,16L,72L,420L,3240L };
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
public class A112086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112086Inst : IEnumerable<long>
{
public static readonly long[] Value=A112086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112086.Bytes);
public long this[int i]=>Value[i];

public static A112086Inst Instance=new A112086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112087
{
public static readonly long[] Value={ 4L,12L,28L,52L,84L,124L,172L,228L,292L,364L,444L,532L,628L,732L,844L,964L,1092L,1228L,1372L,1524L,1684L,1852L,2028L,2212L,2404L,2604L,2812L,3028L,3252L,3484L,3724L,3972L,4228L,4492L,4764L,5044L,5332L,5628L,5932L,6244L,6564L,6892L,7228L,7572L,7924L,8284L };
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
public class A112087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112087Inst : IEnumerable<long>
{
public static readonly long[] Value=A112087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112087.Bytes);
public long this[int i]=>Value[i];

public static A112087Inst Instance=new A112087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112088
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,16L,24L,36L,54L,81L,122L,183L,274L,411L,617L,925L,1388L,2082L,3123L,4684L,7026L,10539L,15809L,23713L,35570L,53355L,80032L,120048L,180072L,270108L,405162L,607743L,911615L,1367422L,2051133L,3076700L,4615050L,6922575L,10383862L };
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
public class A112088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112088Inst : IEnumerable<long>
{
public static readonly long[] Value=A112088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112088.Bytes);
public long this[int i]=>Value[i];

public static A112088Inst Instance=new A112088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112089
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,24L };
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
public class A112089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112089Inst : IEnumerable<long>
{
public static readonly long[] Value=A112089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112089.Bytes);
public long this[int i]=>Value[i];

public static A112089Inst Instance=new A112089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112090
{
public static readonly long[] Value={ 7L,11L,13L,15L,21L,31L };
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
public class A112090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112090Inst : IEnumerable<long>
{
public static readonly long[] Value=A112090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112090.Bytes);
public long this[int i]=>Value[i];

public static A112090Inst Instance=new A112090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112091
{
public static readonly long[] Value={ 1L,2L,6L,21L,76L,276L,1001L,3626L,13126L,47501L,171876L,621876L,2250001L,8140626L,29453126L,106562501L,385546876L,1394921876L,5046875001L,18259765626L,66064453126L,239023437501L,864794921876L,3128857421876L,11320312500001L };
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
public class A112091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112091Inst : IEnumerable<long>
{
public static readonly long[] Value=A112091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112091.Bytes);
public long this[int i]=>Value[i];

public static A112091Inst Instance=new A112091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112092
{
public static readonly long[] Value={ 3L,5L,7L,17L,11L,13L,43L,257L,19L,41L,23L,241L,2731L,29L,151L,65537L,43691L,37L,174763L,61681L,337L,397L,47L,97L,251L,53L,87211L,15790321L,59L,61L };
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
public class A112092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112092Inst : IEnumerable<long>
{
public static readonly long[] Value=A112092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112092.Bytes);
public long this[int i]=>Value[i];

public static A112092Inst Instance=new A112092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112093
{
public static readonly BigInteger[] Value={ 0L,3L,13L,197L,1105L,9211L,130277L,82987349L,331950131L,16929464521L,29241805241L,3538258509761L,6259995854281L,1057939300471201L,1057939300716589L,51133732870640471L,372975463296151087L,BigInteger.Parse("107789908892879155343"),BigInteger.Parse("51058377896658637853"),BigInteger.Parse("681986753565766904623961") };
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
public class A112093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112093Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112093.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112093.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112093Inst Instance=new A112093Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112094
{
public static readonly BigInteger[] Value={ 1L,2L,8L,120L,672L,5600L,79200L,50450400L,201801600L,10291881600L,17776886400L,2151003254400L,3805621142400L,643149973065600L,643149973065600L,31085582031504000L,226741892465088000L,BigInteger.Parse("65528406922410432000"),BigInteger.Parse("31039771700089152000"),BigInteger.Parse("414598230598090803264000"),BigInteger.Parse("16583929223923632130560") };
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
public class A112094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112094Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112094.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112094.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112094Inst Instance=new A112094Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112095
{
public static readonly long[] Value={ 1L,2L,3L,4L,9L,6L,5L,7L,8L,16L,12L,18L,13L,23L,25L,27L,49L,64L,81L,512L,10L,14L,11L,17L,19L,32L,53L,128L,256L,65536L,36L,37L,61L,125L,169L,343L,529L,625L,729L,2401L,4096L,19683L,262144L,15L,20L,21L,24L,26L,28L,46L,48L,50L,54L,98L,162L,29L,41L,43L,83L,97L,103L,121L,227L };
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
public class A112095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112095Inst : IEnumerable<long>
{
public static readonly long[] Value=A112095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112095.Bytes);
public long this[int i]=>Value[i];

public static A112095Inst Instance=new A112095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112096
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,4L,2L,8L,2L,8L,1L,12L,12L,28L,4L,16L };
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
public class A112096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112096Inst : IEnumerable<long>
{
public static readonly long[] Value=A112096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112096.Bytes);
public long this[int i]=>Value[i];

public static A112096Inst Instance=new A112096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112097
{
public static readonly long[] Value={ 0L,1L,2L,43L,307L,463L,10201L,24121L,88453L,1503743L,28571327L,680271L,54761843L,156462429L,111170677L,245020174253L,7595625419003L,2531875141141L,17723125990639L,655755661678837L,655755661685297L,867289746102097L,1156097231554841431L,1734145847332548163L };
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
public class A112097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112097Inst : IEnumerable<long>
{
public static readonly long[] Value=A112097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112097.Bytes);
public long this[int i]=>Value[i];

public static A112097Inst Instance=new A112097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112098
{
public static readonly long[] Value={ 1L,2L,3L,60L,420L,630L,13860L,32760L,120120L,2042040L,38798760L,923780L,74364290L,212469400L,150965100L,332727080400L,10314539492400L,3438179830800L,24067258815600L,890488576177200L,890488576177200L,1177742955589200L,1569931359800403600L,2354897039700605400L };
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
public class A112098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112098Inst : IEnumerable<long>
{
public static readonly long[] Value=A112098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112098.Bytes);
public long this[int i]=>Value[i];

public static A112098Inst Instance=new A112098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112099
{
public static readonly long[] Value={ 0L,1L,7L,3L,169L,1523L,133L,72623L,87149L,823077L,15638477L,46915441L,13834041L,224803169L,6936783521L,5587964507L,4157445593923L,12472336782289L,170187831339L,71785227258967L,153825486983593L,4905323862699739L,21820233734078929L,5695081004594650211L };
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
public class A112099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112099Inst : IEnumerable<long>
{
public static readonly long[] Value=A112099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112099.Bytes);
public long this[int i]=>Value[i];

public static A112099Inst Instance=new A112099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112100
{
public static readonly ulong[] Value={ 1L,2L,12L,5L,280L,2520L,220L,120120L,144144L,1361360L,25865840L,77597520L,22881320L,371821450L,11473347600L,9242418900L,6876359661600L,20629078984800L,281488407200L,118731810156960L,254425307479200L,8113340360725600L,36090376087365600L,9419588158802421600UL };
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
public class A112100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112100Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A112100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112100.Bytes);
public ulong this[int i]=>Value[i];

public static A112100Inst Instance=new A112100Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112101
{
public static readonly BigInteger[] Value={ 1L,3L,10L,58L,722L,19826L,1161882L,141436842L,35192653666L,17733070720738L,17997787816364330L,BigInteger.Parse("36678689328450847514"),BigInteger.Parse("149831453090755680149490"),BigInteger.Parse("1225618861520566592060441682"),BigInteger.Parse("20064594684596858150355969600442"),BigInteger.Parse("657195622713393693107201875915723402") };
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
public class A112101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112101Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112101.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112101.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112101Inst Instance=new A112101Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112102
{
public static readonly BigInteger[] Value={ 0L,1L,25L,1129L,63251L,1581371L,52185743L,33242372291L,24176277773L,40688677687159L,2378722720177L,3741730846458901L,86059809503772983L,BigInteger.Parse("72720539036773885963"),BigInteger.Parse("72720539038037143387"),BigInteger.Parse("52722390802769505531767"),BigInteger.Parse("13075152919096992777263341") };
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
public class A112102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112102Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112102.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112102.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112102Inst Instance=new A112102Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112103
{
public static readonly BigInteger[] Value={ 1L,2L,48L,2160L,120960L,3024000L,99792000L,63567504000L,46230912000L,77806624896000L,4548694993920L,7155097225436160L,164567236185031680L,BigInteger.Parse("139059314576351769600"),BigInteger.Parse("139059314576351769600"),BigInteger.Parse("100818003067855032960000"),BigInteger.Parse("25002864760828048174080000") };
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
public class A112103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112103Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112103.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112103.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112103Inst Instance=new A112103Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112104
{
public static readonly long[] Value={ 1L,2L,2L,1L,2L,1L,2L,2L,1L,2L,1L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,1L,2L,1L,2L,2L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,2L,2L,2L,2L,1L,1L,2L,2L,1L,2L,2L,2L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,2L,2L,2L,1L,1L,1L,2L,2L,2L,2L,2L,1L,1L,2L,2L,1L,2L,2L,2L,2L,1L,2L,2L,2L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,2L,2L,1L };
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
public class A112104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112104Inst : IEnumerable<long>
{
public static readonly long[] Value=A112104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112104.Bytes);
public long this[int i]=>Value[i];

public static A112104Inst Instance=new A112104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112105
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,-3L,7L,-10L,-5L,84L,-248L,90L,2160L,-7541L,-5846L,122824L,-186259L,-2036532L,8665409L,36714511L,-345711246L,-517802065L,14415153844L,-9423161197L,-653074772917L,1896978939457L,32374651932128L,-184814895196023L,-1733326272860598L,16839263882542991L,96742403684106435L };
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
public class A112105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112105Inst : IEnumerable<long>
{
public static readonly long[] Value=A112105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112105.Bytes);
public long this[int i]=>Value[i];

public static A112105Inst Instance=new A112105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112106
{
public static readonly long[] Value={ 1L,3L,3L,3L,2L,2L,1L,2L,1L,3L,1L,1L,3L,3L,3L,2L,3L,3L,2L,2L,2L,1L,2L,2L,3L,1L,2L,1L,1L,2L,3L,2L,2L,2L,1L,2L,2L,3L,2L,2L,2L,1L,1L,1L,1L,2L,3L,2L,1L,2L,3L,2L,3L,2L,2L,3L,2L,3L,3L,2L,3L,3L,3L,1L,3L,2L,1L,3L,2L,2L,1L,2L,3L,1L,3L,1L,3L,1L,1L,1L,3L,1L,2L,3L,3L,3L,3L,3L,3L,1L,1L,2L,2L,3L,3L,1L,3L,2L,1L,2L,2L,1L,1L,3L,1L };
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
public class A112106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112106Inst : IEnumerable<long>
{
public static readonly long[] Value=A112106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112106.Bytes);
public long this[int i]=>Value[i];

public static A112106Inst Instance=new A112106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112107
{
public static readonly long[] Value={ 1L,1L,-1L,3L,-10L,35L,-119L,360L,-792L,-33L,12779L,-82525L,305861L,-552011L,-126321L,-8385020L,138177591L,-433073834L,-5366414982L,51203452090L,123835509276L,-4174647911014L,5274854624423L,373574363131841L,-2054088594386738L,-34047892948849106L,391005463740951942L };
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
public class A112107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112107Inst : IEnumerable<long>
{
public static readonly long[] Value=A112107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112107.Bytes);
public long this[int i]=>Value[i];

public static A112107Inst Instance=new A112107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112108
{
public static readonly long[] Value={ 1L,4L,4L,2L,4L,2L,4L,4L,2L,4L,4L,2L,2L,4L,4L,2L,2L,4L,4L,3L,4L,3L,2L,4L,1L,2L,4L,2L,3L,1L,4L,2L,4L,3L,1L,4L,4L,4L,2L,2L,2L,3L,3L,2L,3L,2L,2L,4L,1L,4L,2L,2L,1L,4L,3L,3L,3L,1L,1L,3L,3L,4L,4L,3L,3L,3L,3L,1L,4L,4L,3L,2L,4L,2L,2L,2L,1L,3L,4L,2L,3L,3L,1L,4L,2L,3L,1L,1L,3L,3L,4L,2L,4L,3L,1L,4L,3L,2L,1L,1L,1L,2L,1L,4L,4L };
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
public class A112108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112108Inst : IEnumerable<long>
{
public static readonly long[] Value=A112108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112108.Bytes);
public long this[int i]=>Value[i];

public static A112108Inst Instance=new A112108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112109
{
public static readonly long[] Value={ 1L,1L,-2L,8L,-38L,194L,-992L,4777L,-19831L,56116L,48008L,-2062286L,16053636L,-70193968L,155216743L,-968038798L,23817048561L,-233579083166L,333773365L,21684104628935L,-121906541882294L,-2171063003748135L,30425707365005935L,192144123118329872L };
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
public class A112109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112109Inst : IEnumerable<long>
{
public static readonly long[] Value=A112109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112109.Bytes);
public long this[int i]=>Value[i];

public static A112109Inst Instance=new A112109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112110
{
public static readonly long[] Value={ 1L,5L,5L,5L,5L,5L,4L,4L,4L,4L,3L,1L,1L,1L,5L,3L,1L,1L,5L,3L,4L,3L,2L,1L,5L,4L,1L,4L,1L,5L,1L,4L,5L,4L,2L,1L,5L,2L,5L,4L,5L,5L,4L,1L,1L,5L,4L,3L,5L,1L,5L,2L,2L,3L,1L,3L,2L,5L,2L,5L,3L,2L,3L,5L,2L,1L,2L,3L,1L,5L,1L,4L,5L,4L,3L,3L,2L,4L,2L,3L,4L,5L,2L,5L,5L,2L,4L,2L,3L,5L,3L,2L,4L,2L,2L,1L,1L,2L,3L,4L,5L,3L,3L,1L,5L };
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
public class A112110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112110Inst : IEnumerable<long>
{
public static readonly long[] Value=A112110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112110.Bytes);
public long this[int i]=>Value[i];

public static A112110Inst Instance=new A112110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112111
{
public static readonly long[] Value={ 1L,1L,-3L,17L,-115L,841L,-6288L,46174L,-320366L,1997348L,-10216611L,32418767L,68603755L,-1909624513L,15239954041L,-103620859984L,1499179409198L,-25808959095992L,258001631302410L,-239530586418995L,-25424691109062239L,84868851253494310L };
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
public class A112111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112111Inst : IEnumerable<long>
{
public static readonly long[] Value=A112111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112111.Bytes);
public long this[int i]=>Value[i];

public static A112111Inst Instance=new A112111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112112
{
public static readonly long[] Value={ 1L,6L,6L,3L,4L,4L,6L,2L,5L,3L,3L,5L,3L,2L,5L,3L,3L,4L,5L,4L,3L,2L,6L,4L,3L,6L,2L,5L,6L,4L,2L,5L,4L,5L,1L,1L,1L,4L,4L,2L,3L,6L,6L,5L,5L,4L,3L,5L,5L,2L,2L,1L,3L,6L,1L,5L,2L,6L,5L,4L,3L,4L,6L,6L,5L,5L,6L,1L,5L,6L,6L,3L,3L,1L,5L,4L,5L,1L,5L,2L,2L,4L,3L,4L,2L,1L,6L,1L,3L,2L,4L,1L,3L,5L,3L,1L,3L,2L,6L,2L,5L,1L,3L,6L,2L };
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
public class A112112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112112Inst : IEnumerable<long>
{
public static readonly long[] Value=A112112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112112.Bytes);
public long this[int i]=>Value[i];

public static A112112Inst Instance=new A112112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112113
{
public static readonly long[] Value={ 1L,1L,-4L,28L,-236L,2159L,-20309L,189387L,-1696165L,14092143L,-103605487L,621674576L,-2503235595L,1311059747L,58857366823L,-625935119621L,20416246154579L,-595556154741631L,9331660766550500L,-50486760747953952L,-816026626910008666L };
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
public class A112113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112113Inst : IEnumerable<long>
{
public static readonly long[] Value=A112113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112113.Bytes);
public long this[int i]=>Value[i];

public static A112113Inst Instance=new A112113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112114
{
public static readonly long[] Value={ 1L,7L,7L,7L,7L,7L,7L,7L,6L,6L,6L,6L,6L,6L,5L,3L,3L,3L,3L,3L,2L,2L,1L,1L,1L,1L,7L,4L,7L,4L,4L,4L,3L,2L,5L,3L,1L,1L,7L,5L,2L,4L,2L,2L,1L,2L,6L,5L,1L,5L,7L,7L,7L,7L,5L,6L,5L,6L,4L,1L,6L,1L,2L,7L,1L,5L,3L,7L,2L,4L,4L,4L,3L,2L,4L,5L,7L,7L,3L,1L,2L,3L,5L,5L,6L,4L,7L,6L,1L,6L,5L,2L,1L,1L,6L,1L,4L,3L,1L,2L,3L,3L,3L,7L,1L };
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
public class A112114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112114Inst : IEnumerable<long>
{
public static readonly long[] Value=A112114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112114.Bytes);
public long this[int i]=>Value[i];

public static A112114Inst Instance=new A112114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112115
{
public static readonly long[] Value={ 1L,1L,-5L,43L,-443L,4957L,-57281L,661375L,-7430526L,79197417L,-778914398L,6845802239L,-52074744048L,345158019601L,-2374391391323L,20218882229451L,-34682204747638L,-6385759551091470L,180067413599721613L,-2110513020510554883L };
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
public class A112115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112115Inst : IEnumerable<long>
{
public static readonly long[] Value=A112115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112115.Bytes);
public long this[int i]=>Value[i];

public static A112115Inst Instance=new A112115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112116
{
public static readonly long[] Value={ 1L,8L,8L,4L,8L,4L,8L,8L,4L,8L,8L,4L,4L,8L,8L,4L,4L,8L,8L,2L,4L,6L,4L,6L,2L,4L,8L,8L,2L,2L,8L,4L,8L,2L,2L,8L,8L,6L,4L,4L,6L,2L,4L,3L,8L,5L,8L,8L,7L,5L,4L,3L,4L,6L,6L,2L,1L,7L,2L,7L,8L,8L,8L,2L,8L,8L,4L,2L,7L,8L,8L,5L,3L,4L,2L,6L,5L,1L,8L,7L,4L,1L,5L,4L,4L,7L,4L,2L,4L,7L,6L,4L,6L,2L,6L,3L,5L,6L,7L,2L,5L,7L,8L,8L,7L };
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
public class A112116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112116Inst : IEnumerable<long>
{
public static readonly long[] Value=A112116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112116.Bytes);
public long this[int i]=>Value[i];

public static A112116Inst Instance=new A112116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112117
{
public static readonly BigInteger[] Value={ 1L,1L,-6L,60L,-720L,9398L,-126958L,1719439L,-22778647L,288721672L,-3426131120L,37291873546L,-368633930696L,3421668183648L,-33763691015949L,382711017377914L,-3403489111329505L,-22613095886515578L,1672401759052466166L,BigInteger.Parse("-27936127591842262118"),BigInteger.Parse("-15637150116164531317") };
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
public class A112117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112117Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112117.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112117.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112117Inst Instance=new A112117Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112118
{
public static readonly long[] Value={ 1L,9L,9L,9L,6L,6L,3L,9L,6L,3L,9L,3L,3L,1L,7L,5L,9L,1L,8L,6L,2L,6L,4L,6L,7L,6L,4L,6L,3L,2L,5L,7L,2L,5L,7L,8L,1L,4L,9L,6L,3L,7L,6L,9L,1L,7L,7L,3L,7L,8L,7L,5L,7L,8L,9L,3L,8L,7L,9L,5L,3L,9L,9L,1L,5L,4L,5L,1L,7L,3L,1L,7L,8L,6L,1L,8L,4L,6L,8L,6L,5L,5L,9L,2L,6L,1L,5L,9L,8L,7L,2L,8L,8L,3L,2L,3L,9L,8L,2L,8L,4L,6L,1L,9L,4L };
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
public class A112118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112118Inst : IEnumerable<long>
{
public static readonly long[] Value=A112118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112118.Bytes);
public long this[int i]=>Value[i];

public static A112118Inst Instance=new A112118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112119
{
public static readonly BigInteger[] Value={ 1L,1L,-7L,81L,-1122L,16906L,-264109L,4150081L,-64119406L,955386299L,-13491950523L,178108552187L,-2193288809125L,25965294143459L,-320197330438145L,4331428366450929L,-54509980572007649L,309687851858995853L,8841175049606909354L,BigInteger.Parse("-260481122023484957344"),BigInteger.Parse("727627679068983588258") };
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
public class A112119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112119Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112119.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112119.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112119Inst Instance=new A112119Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112120
{
public static readonly long[] Value={ 1L,10L,10L,5L,10L,5L,8L,3L,4L,3L,2L,1L,9L,2L,8L,1L,7L,4L,9L,4L,7L,8L,2L,4L,5L,5L,6L,5L,6L,6L,6L,5L,6L,7L,3L,1L,2L,10L,10L,10L,5L,7L,10L,1L,4L,7L,1L,1L,5L,7L,2L,8L,9L,4L,3L,7L,5L,10L,4L,4L,9L,8L,7L,8L,4L,6L,7L,1L,2L,2L,3L,5L,9L,1L,10L,2L,5L,4L,5L,9L,3L,4L,10L,1L,1L,10L,4L,2L,6L,4L,8L,2L,2L,4L,9L,2L,10L,8L,4L,7L };
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
public class A112120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112120Inst : IEnumerable<long>
{
public static readonly long[] Value=A112120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112120.Bytes);
public long this[int i]=>Value[i];

public static A112120Inst Instance=new A112120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112121
{
public static readonly BigInteger[] Value={ 1L,1L,-8L,104L,-1619L,27437L,-482626L,8553639L,-149434331L,2527339944L,-40748011084L,619534898788L,-8892967520397L,124088656925363L,-1797865061490547L,28140512084643142L,-424643873334235802L,4269156014010214570L,BigInteger.Parse("19251023484926369328"),BigInteger.Parse("-1456780704021544219838") };
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
public class A112121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112121Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112121.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112121.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112121Inst Instance=new A112121Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112122
{
public static readonly long[] Value={ 1L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,9L,7L,7L,7L,7L,7L,7L,7L,7L,7L,6L,10L,11L,11L,11L,11L,11L,11L,11L,11L,10L,2L,7L,1L,1L,1L,1L,1L,1L,1L,11L,1L,10L,1L,3L,3L,3L,3L,3L,3L,2L,2L,10L,11L,11L,3L,3L,3L,3L,3L,2L,6L,9L,5L,3L,2L,4L,4L,4L,4L,3L,5L,11L,6L,7L };
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
public class A112122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112122Inst : IEnumerable<long>
{
public static readonly long[] Value=A112122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112122.Bytes);
public long this[int i]=>Value[i];

public static A112122Inst Instance=new A112122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112123
{
public static readonly BigInteger[] Value={ 1L,1L,-9L,131L,-2279L,43161L,-849269L,16866851L,-331093879L,6316647841L,-115528321709L,2007845708091L,-33238536213650L,537616162919975L,-8956186512464320L,158920634214746905L,-2786226293720310297L,BigInteger.Parse("38547971903938600271"),BigInteger.Parse("-198392033014273765511") };
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
public class A112123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112123Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112123.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112123.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112123Inst Instance=new A112123Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112124
{
public static readonly long[] Value={ 1L,12L,12L,6L,8L,8L,12L,2L,8L,2L,10L,9L,10L,10L,4L,5L,4L,7L,10L,10L,12L,7L,12L,8L,8L,9L,10L,7L,11L,12L,2L,9L,12L,10L,11L,7L,6L,5L,4L,5L,10L,7L,9L,1L,9L,5L,12L,12L,2L,10L,6L,9L,9L,6L,2L,1L,9L,3L,7L,10L,4L,11L,10L,3L,6L,10L,6L,10L,12L,11L,8L,1L,2L,4L,7L,2L,8L,6L,9L,12L,8L,2L,3L,2L,4L,3L,6L,12L,6L,11L,4L };
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
public class A112124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112124Inst : IEnumerable<long>
{
public static readonly long[] Value=A112124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112124.Bytes);
public long this[int i]=>Value[i];

public static A112124Inst Instance=new A112124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112125
{
public static readonly BigInteger[] Value={ 1L,1L,-10L,160L,-3061L,63775L,-1381434L,30233546L,-654989371L,13821523157L,-280493565375L,5432981693533L,-100769609590332L,1833421110751790L,-34286913831217395L,678578947805323394L,BigInteger.Parse("-13377225136748683778"),BigInteger.Parse("221000164094797572734"),BigInteger.Parse("-2119677884300620846621") };
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
public class A112125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112125Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112125.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112125.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112125Inst Instance=new A112125Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112126
{
public static readonly long[] Value={ 1L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,11L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,8L,1L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,8L,9L,6L,6L,6L,6L,6L,6L,6L,6L,6L,5L,10L,3L,5L,13L,13L,13L,13L,13L,13L,13L,13L,12L,12L,3L,4L,4L,7L,7L,7L,7L,7L,7L,7L,6L,3L };
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
public class A112126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112126Inst : IEnumerable<long>
{
public static readonly long[] Value=A112126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112126.Bytes);
public long this[int i]=>Value[i];

public static A112126Inst Instance=new A112126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112127
{
public static readonly BigInteger[] Value={ 1L,1L,-11L,193L,-4043L,92233L,-2188907L,52544305L,-1250612651L,29060631481L,-651497950667L,13997025548641L,-289196932607819L,5873067677083177L,-122109541297984368L,2669034419647762122L,BigInteger.Parse("-58550172867811577842"),BigInteger.Parse("1127335101086707607932") };
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
public class A112127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112127Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112127.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112127.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112127Inst Instance=new A112127Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112128
{
public static readonly long[] Value={ 1L,-2L,4L,-8L,16L,-28L,48L,-80L,128L,-202L,312L,-472L,704L,-1036L,1504L,-2160L,3072L,-4324L,6036L,-8360L,11488L,-15680L,21264L,-28656L,38400L,-51182L,67864L,-89552L,117632L,-153836L,200352L,-259904L,335872L,-432480L,554952L,-709728L,904784L,-1149916L,1457136L };
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
public class A112128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112128Inst : IEnumerable<long>
{
public static readonly long[] Value=A112128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112128.Bytes);
public long this[int i]=>Value[i];

public static A112128Inst Instance=new A112128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112129
{
public static readonly long[] Value={ 1197630L,20402760L,25451790L,29445850L,43830780L,44898210L,52214050L,76355370L,84234990L,88337550L,99495550L,123074070L,135740430L,155333920L,156954700L,165098290L,216858460L,218715490L,229066110L,232590400L,234109120L,236536510L };
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
public class A112129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112129Inst : IEnumerable<long>
{
public static readonly long[] Value=A112129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112129.Bytes);
public long this[int i]=>Value[i];

public static A112129Inst Instance=new A112129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112130
{
public static readonly long[] Value={ 25451790L,29445850L,76355370L,218715490L,236862990L,380011170L,514144750L,628241740L,777146230L,882792120L,930646080L,944173860L,1105472340L,1349221230L,1542434250L,1564227910L,1832212270L,1898927100L,1994085030L };
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
public class A112130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112130Inst : IEnumerable<long>
{
public static readonly long[] Value=A112130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112130.Bytes);
public long this[int i]=>Value[i];

public static A112130Inst Instance=new A112130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112131
{
public static readonly long[] Value={ 12L,23L,34L,45L,56L,67L,78L,89L,910L,101112L,12131415161718L,181920L,2021L,21222324L,24252627L,27282930L,30313233343536L,3637383940L,404142L,42434445L,45464748L,484950L,5051525354L,54555657585960L,60616263L,6364656667686970L,707172L };
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
public class A112131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112131Inst : IEnumerable<long>
{
public static readonly long[] Value=A112131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112131.Bytes);
public long this[int i]=>Value[i];

public static A112131Inst Instance=new A112131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112132
{
public static readonly long[] Value={ 1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L };
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
public class A112132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112132Inst : IEnumerable<long>
{
public static readonly long[] Value=A112132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112132.Bytes);
public long this[int i]=>Value[i];

public static A112132Inst Instance=new A112132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112133
{
public static readonly long[] Value={ 1L,11L,13L,11L,1L,23L,1L,11L,13L,11L,1L,23L,1L,11L,13L,11L,1L,23L,1L,11L,13L,11L,1L,23L,1L,11L,13L,11L,1L,23L,1L,11L,13L,11L,1L,23L,1L,11L,13L,11L,1L,23L,1L,11L,13L,11L,1L,23L,1L,11L,13L,11L,1L,23L,1L,11L,13L,11L,1L,23L,1L,11L,13L,11L,1L,23L,1L,11L,13L,11L,1L,23L,1L,11L,13L,11L,1L };
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
public class A112133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112133Inst : IEnumerable<long>
{
public static readonly long[] Value=A112133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112133.Bytes);
public long this[int i]=>Value[i];

public static A112133Inst Instance=new A112133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112134
{
public static readonly long[] Value={ 11L,24L,36L,24L,1L,59L,25L,11L,25L,59L,1L,24L,36L,24L,11L,49L,11L,24L,36L,24L,1L,59L,25L,11L,25L,59L,1L,24L,36L,24L,11L,49L,11L,24L,36L,24L,1L,59L,25L,11L,25L,59L,1L,24L,36L,24L,11L,49L,11L,24L,36L,24L,1L,59L,25L,11L,25L,59L,1L,24L,36L,24L,11L,49L,11L,24L,36L,24L,1L,59L,25L,11L };
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
public class A112134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112134Inst : IEnumerable<long>
{
public static readonly long[] Value=A112134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112134.Bytes);
public long this[int i]=>Value[i];

public static A112134Inst Instance=new A112134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112135
{
public static readonly long[] Value={ 95L,120L,60L,24L,60L,85L,60L,36L,95L,60L,145L,84L,11L,25L,59L,36L,84L,60L,1L,155L,25L,84L,71L,24L,60L,1L,144L,95L,25L,71L,24L,61L,84L,71L,25L,59L,25L,71L,84L,61L,24L,71L,25L,95L,144L,1L,60L,24L,71L,84L,25L,155L,1L,60L,84L,36L,59L,25L,11L,84L,145L,60L,95L,36L,60L,85L };
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
public class A112135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112135Inst : IEnumerable<long>
{
public static readonly long[] Value=A112135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112135.Bytes);
public long this[int i]=>Value[i];

public static A112135Inst Instance=new A112135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112136
{
public static readonly long[] Value={ 155L,336L,84L,180L,336L,145L,24L,420L,71L,120L,144L,61L,215L,84L,300L,25L,95L,205L,215L,216L,180L,84L,1L,60L,95L,204L,300L,36L,145L,144L,36L,59L,25L,156L,504L,251L,169L,60L,95L,36L,205L,95L,25L,95L,205L,299L,61L,264L,336L,95L,84L,216L,265L,60L,204L,95L,60L,156L };
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
public class A112136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112136Inst : IEnumerable<long>
{
public static readonly long[] Value=A112136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112136.Bytes);
public long this[int i]=>Value[i];

public static A112136Inst Instance=new A112136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112137
{
public static readonly long[] Value={ 635L,720L,36L,1680L,60L,769L,311L,25L,155L,924L,1L,1404L,131L,289L,95L,120L,205L,611L,84L,660L,361L,84L,575L,85L,396L,215L,205L,95L,624L,61L,239L,25L,431L,480L,780L,60L,265L,479L,120L,961L,24L,335L,685L,95L,565L,336L,155L,600L,324L,181L,755L,169L,516L,95L };
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
public class A112137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112137Inst : IEnumerable<long>
{
public static readonly long[] Value=A112137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112137.Bytes);
public long this[int i]=>Value[i];

public static A112137Inst Instance=new A112137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112138
{
public static readonly long[] Value={ 2675L,1344L,420L,576L,204L,1320L,756L,1080L,445L,815L,924L,3120L,481L,1895L,84L,205L,635L,1140L,265L,180L,1271L,564L,780L,961L,204L,95L,1140L,516L,229L,456L,924L,660L,911L,265L,659L,180L,925L,480L,611L,360L,745L,1140L,864L,155L,456L,205L,1115L,169L };
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
public class A112138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112138Inst : IEnumerable<long>
{
public static readonly long[] Value=A112138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112138.Bytes);
public long this[int i]=>Value[i];

public static A112138Inst Instance=new A112138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112139
{
public static readonly long[] Value={ 5015L,2616L,9240L,2844L,5496L,1140L,325L,5639L,2220L,6636L,1465L,420L,719L,420L,1560L,265L,2675L,2041L,5939L,1621L,3035L,2664L,336L,769L,3791L,1980L,949L,4211L,2329L,755L,2941L,839L,145L,635L,2665L,71L,420L,204L,216L,685L,1824L,3060L,420L,731L };
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
public class A112139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112139Inst : IEnumerable<long>
{
public static readonly long[] Value=A112139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112139.Bytes);
public long this[int i]=>Value[i];

public static A112139Inst Instance=new A112139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112140
{
public static readonly long[] Value={ 0L,0L,1L,0L,1729L,494L,1984L,744L,2500L,2450L,2500L,2550L,1984L,5288L,1729L,6048L,1L,9998L,0L,10000L };
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
public class A112140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112140Inst : IEnumerable<long>
{
public static readonly long[] Value=A112140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112140.Bytes);
public long this[int i]=>Value[i];

public static A112140Inst Instance=new A112140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112141
{
public static readonly BigInteger[] Value={ 4L,24L,216L,2160L,30240L,453600L,9525600L,209563200L,5239080000L,136216080000L,4495130640000L,152834441760000L,5349205461600000L,203269807540800000L,7927522494091200000L,BigInteger.Parse("364666034728195200000"),BigInteger.Parse("17868635701681564800000"),BigInteger.Parse("911300420785759804800000") };
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
public class A112141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112141Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112141.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112141.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112141Inst Instance=new A112141Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112142
{
public static readonly long[] Value={ 1L,12L,66L,232L,639L,1596L,3774L,8328L,17283L,34520L,66882L,125568L,229244L,409236L,716412L,1231048L,2079237L,3459264L,5677832L,9200232L,14729592L,23325752L,36567222L,56778888L,87369483L,133315692L,201825420L,303257512L };
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
public class A112142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112142Inst : IEnumerable<long>
{
public static readonly long[] Value=A112142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112142.Bytes);
public long this[int i]=>Value[i];

public static A112142Inst Instance=new A112142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112143
{
public static readonly long[] Value={ 1L,-4L,2L,8L,-1L,-20L,-2L,40L,3L,-72L,2L,128L,-4L,-220L,-4L,360L,5L,-576L,8L,904L,-8L,-1384L,-10L,2088L,11L,-3108L,12L,4552L,-15L,-6592L,-18L,9448L,22L,-13392L,26L,18816L,-29L,-26216L,-34L,36224L,38L,-49700L,42L,67728L,-51L,-91688L,-56L,123392L,66L,-165128L,78L,219784L,-85L,-291072L };
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
public class A112143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112143Inst : IEnumerable<long>
{
public static readonly long[] Value=A112143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112143.Bytes);
public long this[int i]=>Value[i];

public static A112143Inst Instance=new A112143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112144
{
public static readonly long[] Value={ 1L,-20L,-62L,-216L,-641L,-1636L,-3778L,-8248L,-17277L,-34664L,-66878L,-125312L,-229252L,-409676L,-716420L,-1230328L,-2079227L,-3460416L,-5677816L,-9198424L,-14729608L,-23328520L,-36567242L,-56774712L,-87369461L,-133321908L,-201825396L,-303248408L };
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
public class A112144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112144Inst : IEnumerable<long>
{
public static readonly long[] Value=A112144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112144.Bytes);
public long this[int i]=>Value[i];

public static A112144Inst Instance=new A112144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112145
{
public static readonly long[] Value={ 1L,-8L,-6L,-48L,15L,-168L,-26L,-496L,51L,-1296L,-102L,-3072L,172L,-6840L,-276L,-14448L,453L,-29184L,-728L,-56880L,1128L,-107472L,-1698L,-197616L,2539L,-354888L,-3780L,-624048L,5505L,-1076736L,-7882L,-1826416L,11238L,-3050400L,-15918L,-5022720L,22259L,-8163152L,-30810L };
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
public class A112145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112145Inst : IEnumerable<long>
{
public static readonly long[] Value=A112145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112145.Bytes);
public long this[int i]=>Value[i];

public static A112145Inst Instance=new A112145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112146
{
public static readonly long[] Value={ 1L,0L,9L,-4L,0L,36L,2L,0L,126L,12L,0L,324L,-21L,0L,801L,4L,0L,1764L,36L,0L,3744L,-68L,0L,7452L,21L,0L,14400L,112L,0L,26748L,-184L,0L,48510L,44L,0L,85536L,275L,0L,147924L,-456L,0L,250452L,112L,0L,417276L,644L,0L,683640L,-1019L,0L,1104948L,240L,0L,1761552L,1370L,0L };
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
public class A112146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112146Inst : IEnumerable<long>
{
public static readonly long[] Value=A112146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112146.Bytes);
public long this[int i]=>Value[i];

public static A112146Inst Instance=new A112146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112147
{
public static readonly long[] Value={ 1L,0L,15L,32L,87L,192L,343L,672L,1290L,2176L,3705L,6336L,10214L,16320L,25905L,39936L,61227L,92928L,138160L,204576L,300756L,435328L,626727L,897408L,1271205L,1790592L,2508783L,3487424L,4824825L,6641664L,9083400L,12371904L,16778784L };
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
public class A112147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112147Inst : IEnumerable<long>
{
public static readonly long[] Value=A112147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112147.Bytes);
public long this[int i]=>Value[i];

public static A112147Inst Instance=new A112147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112148
{
public static readonly long[] Value={ 1L,0L,6L,-4L,-3L,12L,-8L,-12L,30L,-20L,-30L,72L,-46L,-60L,156L,-96L,-117L,300L,-188L,-228L,552L,-344L,-420L,1008L,-603L,-732L,1770L,-1048L,-1245L,2976L,-1776L,-2088L,4908L,-2900L,-3420L,7992L,-4658L,-5460L,12756L,-7408L,-8583L,19944L,-11564L,-13344L,30756L,-17744L,-20448L,46944L };
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
public class A112148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112148Inst : IEnumerable<long>
{
public static readonly long[] Value=A112148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112148.Bytes);
public long this[int i]=>Value[i];

public static A112148Inst Instance=new A112148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112149
{
public static readonly long[] Value={ 1L,-4L,0L,-4L,-16L,0L,6L,-40L,0L,-8L,-96L,0L,17L,-204L,0L,-28L,-400L,0L,38L,-760L,0L,-56L,-1376L,0L,84L,-2404L,0L,-124L,-4096L,0L,172L,-6808L,0L,-232L,-11072L,0L,325L,-17688L,0L,-448L,-27792L,0L,594L,-43008L,0L,-784L,-65696L,0L,1049L,-99128L,0L,-1388L,-147888L,0L,1796L,-218408L,0L,-2320L };
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
public class A112149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112149Inst : IEnumerable<long>
{
public static readonly long[] Value=A112149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112149.Bytes);
public long this[int i]=>Value[i];

public static A112149Inst Instance=new A112149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112150
{
public static readonly long[] Value={ 1L,6L,15L,26L,51L,102L,172L,276L,453L,728L,1128L,1698L,2539L,3780L,5505L,7882L,11238L,15918L,22259L,30810L,42438L,58110L,78909L,106392L,142770L,190698L,253179L,334266L,439581L,575784L,750613L,974316L,1260336L,1624702L,2086530L,2670162L,3406695L,4333590L };
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
public class A112150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112150Inst : IEnumerable<long>
{
public static readonly long[] Value=A112150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112150.Bytes);
public long this[int i]=>Value[i];

public static A112150Inst Instance=new A112150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112151
{
public static readonly long[] Value={ 1L,4L,-2L,8L,-1L,20L,2L,40L,3L,72L,-2L,128L,-4L,220L,4L,360L,5L,576L,-8L,904L,-8L,1384L,10L,2088L,11L,3108L,-12L,4552L,-15L,6592L,18L,9448L,22L,13392L,-26L,18816L,-29L,26216L,34L,36224L,38L,49700L,-42L,67728L,-51L,91688L,56L,123392L,66L,165128L,-78L,219784L,-85L,291072L };
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
public class A112151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112151Inst : IEnumerable<long>
{
public static readonly long[] Value=A112151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112151.Bytes);
public long this[int i]=>Value[i];

public static A112151Inst Instance=new A112151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112152
{
public static readonly long[] Value={ 1L,-4L,-2L,-8L,-1L,-20L,2L,-40L,3L,-72L,-2L,-128L,-4L,-220L,4L,-360L,5L,-576L,-8L,-904L,-8L,-1384L,10L,-2088L,11L,-3108L,-12L,-4552L,-15L,-6592L,18L,-9448L,22L,-13392L,-26L,-18816L,-29L,-26216L,34L,-36224L,38L,-49700L,-42L,-67728L,-51L,-91688L,56L,-123392L,66L,-165128L,-78L,-219784L,-85L,-291072L };
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
public class A112152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112152Inst : IEnumerable<long>
{
public static readonly long[] Value=A112152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112152.Bytes);
public long this[int i]=>Value[i];

public static A112152Inst Instance=new A112152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112153
{
public static readonly long[] Value={ 1L,-2L,-2L,-4L,3L,-2L,-6L,-4L,7L,-12L,-10L,-16L,16L,-14L,-20L,-20L,29L,-40L,-40L,-52L,52L,-52L,-70L,-68L,91L,-114L,-116L,-148L,149L,-152L,-190L,-196L,242L,-296L,-306L,-368L,383L,-396L,-478L,-496L,590L,-698L,-730L,-856L,897L,-940L,-1096L,-1152L,1342L,-1548L,-1630L,-1876L,1975L,-2080L,-2390L,-2516L };
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
public class A112153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112153Inst : IEnumerable<long>
{
public static readonly long[] Value=A112153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112153.Bytes);
public long this[int i]=>Value[i];

public static A112153Inst Instance=new A112153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112154
{
public static readonly long[] Value={ 1L,2L,2L,-4L,3L,2L,6L,-4L,7L,12L,10L,-16L,16L,14L,20L,-20L,29L,40L,40L,-52L,52L,52L,70L,-68L,91L,114L,116L,-148L,149L,152L,190L,-196L,242L,296L,306L,-368L,383L,396L,478L,-496L,590L,698L,730L,-856L,897L,940L,1096L,-1152L,1342L,1548L,1630L,-1876L,1975L,2080L,2390L,-2516L };
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
public class A112154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112154Inst : IEnumerable<long>
{
public static readonly long[] Value=A112154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112154.Bytes);
public long this[int i]=>Value[i];

public static A112154Inst Instance=new A112154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112155
{
public static readonly long[] Value={ 1L,-2L,2L,4L,3L,-2L,6L,4L,7L,-12L,10L,16L,16L,-14L,20L,20L,29L,-40L,40L,52L,52L,-52L,70L,68L,91L,-114L,116L,148L,149L,-152L,190L,196L,242L,-296L,306L,368L,383L,-396L,478L,496L,590L,-698L,730L,856L,897L,-940L,1096L,1152L,1342L,-1548L,1630L,1876L,1975L,-2080L,2390L,2516L };
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
public class A112155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112155Inst : IEnumerable<long>
{
public static readonly long[] Value=A112155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112155.Bytes);
public long this[int i]=>Value[i];

public static A112155Inst Instance=new A112155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112156
{
public static readonly long[] Value={ 1L,3L,0L,-2L,6L,0L,-1L,15L,0L,4L,24L,0L,-3L,48L,0L,0L,78L,0L,7L,132L,0L,-8L,204L,0L,-3L,324L,0L,14L,486L,0L,-14L,735L,0L,-4L,1068L,0L,26L,1563L,0L,-26L,2220L,0L,-7L,3159L,0L,44L,4404L,0L,-41L,6135L,0L,-10L,8412L,0L,73L,11508L,0L,-72L,15552L,0L,-20L,20964L,0L,118L,27978L,0L,-109L };
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
public class A112156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112156Inst : IEnumerable<long>
{
public static readonly long[] Value=A112156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112156.Bytes);
public long this[int i]=>Value[i];

public static A112156Inst Instance=new A112156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112157
{
public static readonly long[] Value={ 1L,-2L,-1L,4L,-3L,0L,7L,-8L,-3L,14L,-14L,-4L,26L,-26L,-7L,44L,-41L,-10L,73L,-72L,-20L,118L,-109L,-28L,182L,-174L,-47L,280L,-260L,-66L,419L,-392L,-102L,618L,-568L,-144L,898L,-832L,-216L,1292L,-1178L,-296L,1828L,-1676L,-429L,2568L,-2334L,-588L,3570L,-3248L,-822L,4920L,-4446L,-1114L,6722L,-6084L };
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
public class A112157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112157Inst : IEnumerable<long>
{
public static readonly long[] Value=A112157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112157.Bytes);
public long this[int i]=>Value[i];

public static A112157Inst Instance=new A112157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112158
{
public static readonly long[] Value={ 1L,0L,6L,8L,17L,32L,54L,80L,116L,192L,290L,408L,585L,832L,1192L,1648L,2237L,3072L,4156L,5576L,7414L,9824L,12964L,16896L,22002L,28544L,36794L,47184L,60185L,76736L,97388L,122864L,154615L,194048L,242904L,302800L,376271L,466720L,577176L,711840L };
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
public class A112158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112158Inst : IEnumerable<long>
{
public static readonly long[] Value=A112158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112158.Bytes);
public long this[int i]=>Value[i];

public static A112158Inst Instance=new A112158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112159
{
public static readonly long[] Value={ 1L,0L,1L,-2L,2L,2L,-1L,0L,-4L,2L,5L,-2L,0L,-8L,2L,8L,-3L,2L,-14L,6L,14L,-6L,4L,-24L,12L,24L,-11L,4L,-40L,16L,38L,-16L,5L,-62L,24L,60L,-24L,10L,-94L,40L,91L,-38L,18L,-144L,62L,136L,-57L,24L,-214L,88L,201L,-82L,30L,-308L,122L,288L,-117L,48L,-440L,180L,410L,-168L,74L,-624L,262L,578L,-238L,96L,-874L,356L };
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
public class A112159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112159Inst : IEnumerable<long>
{
public static readonly long[] Value=A112159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112159.Bytes);
public long this[int i]=>Value[i];

public static A112159Inst Instance=new A112159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112160
{
public static readonly long[] Value={ 1L,4L,6L,8L,17L,28L,38L,56L,84L,124L,172L,232L,325L,448L,594L,784L,1049L,1388L,1796L,2320L,3005L,3864L,4912L,6216L,7877L,9940L,12430L,15488L,19309L,23972L,29580L,36408L,44766L,54876L,66978L,81536L,99150L,120272L,145374L,175344L,211242L };
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
public class A112160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112160Inst : IEnumerable<long>
{
public static readonly long[] Value=A112160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112160.Bytes);
public long this[int i]=>Value[i];

public static A112160Inst Instance=new A112160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112161
{
public static readonly long[] Value={ 1L,-1L,-2L,2L,-1L,0L,5L,-3L,-4L,6L,-3L,-4L,12L,-8L,-10L,16L,-9L,-8L,29L,-17L,-22L,38L,-20L,-20L,61L,-36L,-44L,80L,-43L,-44L,121L,-70L,-82L,156L,-84L,-88L,229L,-131L,-154L,294L,-158L,-164L,417L,-234L,-268L,528L,-284L,-300L,730L,-408L,-462L,922L,-495L,-520L,1246L,-690L,-776L,1562L,-837L,-884L,2074L,-1143L };
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
public class A112161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112161Inst : IEnumerable<long>
{
public static readonly long[] Value=A112161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112161.Bytes);
public long this[int i]=>Value[i];

public static A112161Inst Instance=new A112161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112162
{
public static readonly long[] Value={ 1L,1L,7L,9L,10L,23L,38L,47L,75L,112L,148L,217L,293L,385L,553L,728L,928L,1272L,1670L,2111L,2765L,3566L,4504L,5784L,7300L,9123L,11592L,14458L,17838L,22342L,27668L,33884L,41843L,51344L,62548L,76515L,92989L,112514L,136687L,164961L,198190L };
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
public class A112162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112162Inst : IEnumerable<long>
{
public static readonly long[] Value=A112162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112162.Bytes);
public long this[int i]=>Value[i];

public static A112162Inst Instance=new A112162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112163
{
public static readonly long[] Value={ 1L,1L,3L,-3L,6L,3L,10L,-1L,15L,0L,24L,-3L,37L,9L,57L,-12L,84L,12L,118L,-9L,165L,6L,228L,-12L,316L,27L,432L,-42L,582L,42L,776L,-28L,1023L,24L,1344L,-45L,1757L,82L,2283L,-111L,2946L,111L,3774L,-91L,4812L,84L,6108L,-123L,7725L,208L,9732L,-279L,12204L,282L,15240L,-234L,18957L };
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
public class A112163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112163Inst : IEnumerable<long>
{
public static readonly long[] Value=A112163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112163.Bytes);
public long this[int i]=>Value[i];

public static A112163Inst Instance=new A112163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112164
{
public static readonly long[] Value={ 1L,3L,-1L,3L,-2L,9L,2L,9L,-1L,24L,0L,27L,5L,51L,-3L,60L,-4L,108L,6L,129L,-3L,210L,-4L,252L,12L,393L,-8L,474L,-10L,702L,16L,852L,-9L,1224L,-8L,1485L,29L,2070L,-17L,2511L,-22L,3429L,38L,4155L,-20L,5556L,-20L,6723L,61L,8856L,-36L,10695L,-44L,13878L,80L,16722L,-43L,21450L,-44L,25785L };
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
public class A112164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112164Inst : IEnumerable<long>
{
public static readonly long[] Value=A112164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112164.Bytes);
public long this[int i]=>Value[i];

public static A112164Inst Instance=new A112164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112165
{
public static readonly long[] Value={ 1L,1L,-1L,1L,2L,-1L,-2L,-1L,3L,0L,-4L,1L,5L,1L,-7L,0L,8L,0L,-10L,-1L,13L,-2L,-16L,0L,20L,3L,-24L,2L,30L,-2L,-36L,-4L,43L,0L,-52L,3L,61L,2L,-73L,1L,86L,-1L,-102L,-3L,120L,-4L,-140L,1L,165L,8L,-192L,5L,224L,-6L,-260L,-10L,301L,-2L,-348L,7L,401L,7L,-462L,2L,530L,-2L,-608L,-8L,696L,-10L,-796L,3L,909L,18L,-1035L,12L };
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
public class A112165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112165Inst : IEnumerable<long>
{
public static readonly long[] Value=A112165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112165.Bytes);
public long this[int i]=>Value[i];

public static A112165Inst Instance=new A112165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112166
{
public static readonly long[] Value={ 1L,2L,0L,0L,0L,0L,-2L,4L,0L,0L,0L,0L,1L,6L,0L,0L,0L,0L,-2L,12L,0L,0L,0L,0L,4L,18L,0L,0L,0L,0L,-4L,28L,0L,0L,0L,0L,5L,44L,0L,0L,0L,0L,-6L,64L,0L,0L,0L,0L,9L,92L,0L,0L,0L,0L,-12L,132L,0L,0L,0L,0L,13L,186L,0L,0L,0L,0L,-16L,256L,0L,0L,0L,0L,21L,352L,0L,0L,0L,0L,-26L,476L,0L,0L,0L,0L,29L,638L,0L,0L,0L,0L,-36L };
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
public class A112166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112166Inst : IEnumerable<long>
{
public static readonly long[] Value=A112166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112166.Bytes);
public long this[int i]=>Value[i];

public static A112166Inst Instance=new A112166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112167
{
public static readonly long[] Value={ 1L,-2L,0L,0L,0L,0L,-2L,-4L,0L,0L,0L,0L,1L,-6L,0L,0L,0L,0L,-2L,-12L,0L,0L,0L,0L,4L,-18L,0L,0L,0L,0L,-4L,-28L,0L,0L,0L,0L,5L,-44L,0L,0L,0L,0L,-6L,-64L,0L,0L,0L,0L,9L,-92L,0L,0L,0L,0L,-12L,-132L,0L,0L,0L,0L,13L,-186L,0L,0L,0L,0L,-16L,-256L,0L,0L,0L,0L,21L,-352L,0L,0L,0L,0L,-26L,-476L,0L,0L,0L,0L,29L,-638L,0L,0L,0L,0L,-36L };
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
public class A112167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112167Inst : IEnumerable<long>
{
public static readonly long[] Value=A112167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112167.Bytes);
public long this[int i]=>Value[i];

public static A112167Inst Instance=new A112167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112168
{
public static readonly long[] Value={ 1L,-1L,2L,3L,0L,1L,3L,-2L,3L,7L,-4L,5L,11L,-3L,7L,14L,-5L,9L,23L,-11L,19L,35L,-11L,20L,44L,-19L,31L,66L,-27L,45L,91L,-32L,57L,118L,-45L,75L,164L,-68L,112L,222L,-77L,134L,279L,-109L,181L,376L,-148L,242L,490L,-178L,304L,617L,-233L,385L,803L,-314L,517L,1032L,-372L,626L,1281L,-487L,803L };
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
public class A112168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112168Inst : IEnumerable<long>
{
public static readonly long[] Value=A112168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112168.Bytes);
public long this[int i]=>Value[i];

public static A112168Inst Instance=new A112168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112169
{
public static readonly long[] Value={ 1L,0L,3L,4L,9L,12L,15L,24L,39L,52L,66L,96L,130L,168L,219L,292L,390L,492L,625L,804L,1023L,1280L,1599L,2016L,2508L,3096L,3807L,4688L,5760L,7020L,8532L,10368L,12585L,15156L,18213L,21912L,26287L,31404L,37410L,44584L,53004L,62784L,74245L,87768L,103578L };
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
public class A112169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112169Inst : IEnumerable<long>
{
public static readonly long[] Value=A112169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112169.Bytes);
public long this[int i]=>Value[i];

public static A112169Inst Instance=new A112169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112170
{
public static readonly long[] Value={ 1L,1L,1L,0L,-2L,2L,0L,1L,0L,-1L,2L,1L,3L,0L,-2L,5L,2L,3L,0L,-5L,7L,3L,4L,0L,-5L,9L,3L,7L,0L,-7L,14L,8L,11L,0L,-14L,21L,7L,13L,0L,-14L,26L,11L,20L,0L,-21L,39L,16L,26L,0L,-32L,51L,20L,34L,0L,-38L,65L,25L,47L,0L,-49L,90L,40L,63L,0L,-74L,118L,44L,77L,0L,-85L,146L,60L,105L,0L,-111L,196L,80L,132L,0L,-152L };
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
public class A112170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112170Inst : IEnumerable<long>
{
public static readonly long[] Value=A112170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112170.Bytes);
public long this[int i]=>Value[i];

public static A112170Inst Instance=new A112170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112171
{
public static readonly long[] Value={ 1L,2L,0L,0L,-1L,2L,0L,0L,-1L,4L,0L,0L,0L,6L,0L,0L,1L,8L,0L,0L,0L,12L,0L,0L,-1L,18L,0L,0L,1L,24L,0L,0L,2L,32L,0L,0L,-1L,44L,0L,0L,-2L,58L,0L,0L,1L,76L,0L,0L,2L,100L,0L,0L,-1L,128L,0L,0L,-3L,164L,0L,0L,1L,210L,0L,0L,4L,264L,0L,0L,-2L,332L,0L,0L,-5L,416L,0L,0L,2L,516L,0L,0L,5L,640L,0L,0L,-2L,790L,0L,0L };
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
public class A112171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112171Inst : IEnumerable<long>
{
public static readonly long[] Value=A112171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112171.Bytes);
public long this[int i]=>Value[i];

public static A112171Inst Instance=new A112171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112172
{
public static readonly long[] Value={ 1L,-2L,0L,0L,-1L,-2L,0L,0L,-1L,-4L,0L,0L,0L,-6L,0L,0L,1L,-8L,0L,0L,0L,-12L,0L,0L,-1L,-18L,0L,0L,1L,-24L,0L,0L,2L,-32L,0L,0L,-1L,-44L,0L,0L,-2L,-58L,0L,0L,1L,-76L,0L,0L,2L,-100L,0L,0L,-1L,-128L,0L,0L,-3L,-164L,0L,0L,1L,-210L,0L,0L,4L,-264L,0L,0L,-2L,-332L,0L,0L,-5L,-416L,0L,0L,2L,-516L,0L,0L,5L,-640L,0L,0L,-2L,-790L,0L,0L };
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
public class A112172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112172Inst : IEnumerable<long>
{
public static readonly long[] Value=A112172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112172.Bytes);
public long this[int i]=>Value[i];

public static A112172Inst Instance=new A112172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112173
{
public static readonly long[] Value={ 1L,2L,1L,4L,8L,6L,10L,16L,18L,26L,33L,40L,58L,74L,82L,112L,147L,166L,212L,268L,316L,392L,476L,560L,695L,838L,967L,1184L,1430L,1648L,1970L,2352L,2731L,3236L,3803L,4404L,5206L,6080L,6984L,8192L,9553L,10942L,12709L,14736L,16886L,19506L,22448L,25648L };
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
public class A112173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112173Inst : IEnumerable<long>
{
public static readonly long[] Value=A112173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112173.Bytes);
public long this[int i]=>Value[i];

public static A112173Inst Instance=new A112173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112174
{
public static readonly long[] Value={ 1L,1L,0L,2L,-2L,0L,3L,1L,0L,4L,0L,0L,5L,0L,0L,8L,-2L,0L,11L,4L,0L,16L,-4L,0L,21L,4L,0L,26L,-2L,0L,34L,1L,0L,44L,-4L,0L,58L,9L,0L,74L,-12L,0L,93L,9L,0L,116L,-4L,0L,143L,5L,0L,178L,-12L,0L,221L,20L,0L,272L,-24L,0L,332L,20L,0L,402L,-14L,0L,487L,13L,0L,588L,-24L,0L,710L,42L,0L,854L,-50L,0L,1021L,42L,0L };
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
public class A112174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112174Inst : IEnumerable<long>
{
public static readonly long[] Value=A112174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112174.Bytes);
public long this[int i]=>Value[i];

public static A112174Inst Instance=new A112174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112175
{
public static readonly long[] Value={ 1L,-1L,0L,-2L,2L,-1L,2L,-2L,3L,-4L,4L,-4L,7L,-7L,6L,-10L,11L,-11L,14L,-16L,17L,-21L,22L,-24L,32L,-34L,34L,-44L,49L,-50L,60L,-66L,72L,-84L,90L,-98L,117L,-125L,132L,-156L,171L,-181L,206L,-226L,245L,-277L,298L,-322L,369L,-397L,422L,-480L,522L,-557L,620L,-674L,728L,-807L,868L,-936L,1043L,-1121L,1198L };
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
public class A112175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112175Inst : IEnumerable<long>
{
public static readonly long[] Value=A112175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112175.Bytes);
public long this[int i]=>Value[i];

public static A112175Inst Instance=new A112175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112176
{
public static readonly long[] Value={ 1L,-1L,1L,0L,1L,-2L,2L,-2L,3L,-4L,4L,-4L,5L,-7L,7L,-8L,10L,-12L,14L,-14L,17L,-20L,22L,-24L,28L,-33L,36L,-40L,45L,-52L,56L,-62L,71L,-80L,88L,-96L,109L,-122L,133L,-144L,163L,-182L,198L,-216L,240L,-268L,290L,-316L,349L,-386L,420L,-456L,502L,-552L,600L,-650L,713L,-780L,846L,-916L,1001L,-1093L,1182L };
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
public class A112176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112176Inst : IEnumerable<long>
{
public static readonly long[] Value=A112176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112176.Bytes);
public long this[int i]=>Value[i];

public static A112176Inst Instance=new A112176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112177
{
public static readonly long[] Value={ 1L,-2L,0L,-1L,-2L,0L,0L,-2L,0L,-2L,-6L,0L,2L,-6L,0L,-1L,-8L,0L,2L,-14L,0L,-2L,-16L,0L,3L,-20L,0L,-4L,-32L,0L,4L,-38L,0L,-4L,-46L,0L,7L,-66L,0L,-7L,-78L,0L,6L,-96L,0L,-10L,-130L,0L,11L,-154L,0L,-11L,-186L,0L,14L,-244L,0L,-16L,-288L,0L,17L,-346L,0L,-21L,-440L,0L,22L,-518L,0L,-24L,-618L,0L,32L,-768L,0L,-34L,-902L,0L,34L,-1068L };
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
public class A112177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112177Inst : IEnumerable<long>
{
public static readonly long[] Value=A112177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112177.Bytes);
public long this[int i]=>Value[i];

public static A112177Inst Instance=new A112177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112178
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,-1L,0L,0L,-1L,0L,1L,0L,0L,-1L,0L,0L,-1L,-1L,0L,2L,-1L,0L,-2L,-2L,0L,0L,-1L,0L,2L,-1L,0L,-2L,-1L,0L,-1L,-2L,0L,4L,-3L,0L,-4L,-3L,0L,0L,-3L,0L,5L,-2L,0L,-4L,-2L,0L,-2L,-3L,0L,8L,-5L,0L,-7L,-6L,0L,-1L,-5L,0L,9L,-4L,0L,-8L,-4L,0L,-3L,-6L,0L,14L,-9L,0L,-13L,-10L,0L,-2L,-9L,0L,16L,-8L,0L,-14L,-8L,0L,-5L,-11L,0L,24L,-14L,0L,-21L,-16L,0L,-3L };
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
public class A112178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112178Inst : IEnumerable<long>
{
public static readonly long[] Value=A112178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112178.Bytes);
public long this[int i]=>Value[i];

public static A112178Inst Instance=new A112178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}