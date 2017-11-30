using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A184889
{
public static readonly BigInteger[] Value={ 1L,30L,5850L,1644500L,542685000L,196017822000L,75031266310000L,29905319000700000L,12279871614662437500UL,BigInteger.Parse("5159062111690898125000"),BigInteger.Parse("2207046771381366217875000"),BigInteger.Parse("958150139674902210123750000") };
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
public class A184889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184889Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184889.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184889.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184889Inst Instance=new A184889Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184890
{
public static readonly BigInteger[] Value={ 1L,60L,12600L,3640000L,1218262500L,443837394000L,170877396690000L,68390813462400000L,BigInteger.Parse("28171137810976875000"),BigInteger.Parse("11864338450927462500000"),BigInteger.Parse("5085530033605547526000000"),BigInteger.Parse("2211345876971860770960000000") };
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
public class A184890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184890Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184890.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184890.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184890Inst Instance=new A184890Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184891
{
public static readonly BigInteger[] Value={ 1L,20L,3850L,1078000L,355066250L,128107903000L,49001272897500L,19520507080800000L,8012558140822125000L,BigInteger.Parse("3365274419145292500000"),BigInteger.Parse("1439327869068441602250000"),BigInteger.Parse("624739666805574817770000000") };
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
public class A184891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184891Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184891.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184891.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184891Inst Instance=new A184891Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184956
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,2L,2L,3L,2L,3L,2L,3L,3L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,4L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,5L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,6L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,7L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,8L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184956Inst : IEnumerable<long>
{
public static readonly long[] Value=A184956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184956.Bytes);
public long this[int i]=>Value[i];

public static A184956Inst Instance=new A184956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184957
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,3L,1L,1L,1L,3L,4L,4L,1L,1L,1L,3L,6L,7L,5L,1L,1L,1L,4L,8L,11L,11L,6L,1L,1L,1L,4L,11L,17L,19L,16L,7L,1L,1L,1L,5L,13L,26L,32L,31L,22L,8L,1L,1L,1L,5L,17L,35L,54L,56L,48L,29L,9L,1L,1L,1L,6L,20L,48L,82L,102L,93L,71L,37L,10L,1L,1L,1L,6L,24L,63L,120L,172L,180L,148L,101L,46L,11L,1L,1L,1L,7L,28L,81L,170L,272L,331L,302L,227L,139L,56L,12L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184957Inst : IEnumerable<long>
{
public static readonly long[] Value=A184957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184957.Bytes);
public long this[int i]=>Value[i];

public static A184957Inst Instance=new A184957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184958
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,5L,25L,269L,1883L,20103L,180927L,2172149L,23893639L,326640467L,4246326071L,65675585793L,985133786895L,17069814958319L,290186854291423L,5579050805341613L,106001965301490647L,2241684406438644939L,BigInteger.Parse("47075372535211543719") };
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
public class A184958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184958Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184958.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184958.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184958Inst Instance=new A184958Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184959
{
public static readonly long[] Value={ 10L,9L,19L,28L,47L,75L,122L,197L,319L,516L,835L,1351L,2186L,3537L,5723L,9260L,14983L,24243L,39226L,63469L,102695L,166164L,268859L,435023L,703882L,1138905L,1842787L,2981692L,4824479L,7806171L,12630650L,20436821L,33067471L,53504292L,86571763L,140076055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184959Inst : IEnumerable<long>
{
public static readonly long[] Value=A184959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184959.Bytes);
public long this[int i]=>Value[i];

public static A184959Inst Instance=new A184959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184960
{
public static readonly long[] Value={ 1L,1L,4L,21L,266L,7848L,1L,367860L,0L,21609299L,1L,1470293674L,1L,113314233799L,9L,9799685588930L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184960Inst : IEnumerable<long>
{
public static readonly long[] Value=A184960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184960.Bytes);
public long this[int i]=>Value[i];

public static A184960Inst Instance=new A184960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184961
{
public static readonly long[] Value={ 1L,1L,4L,21L,266L,7849L,1L,367860L,0L,21609300L,1L,1470293675L,1L,113314233808L,9L,9799685588936L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184961Inst : IEnumerable<long>
{
public static readonly long[] Value=A184961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184961.Bytes);
public long this[int i]=>Value[i];

public static A184961Inst Instance=new A184961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184962
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,3L,3L,1L,0L,13L,15L,6L,1L,0L,75L,95L,45L,10L,1L,0L,541L,735L,390L,105L,15L,1L,0L,4683L,6727L,3885L,1190L,210L,21L,1L,0L,47293L,71127L,43918L,14805L,3010L,378L,28L,1L,0L,545835L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184962Inst : IEnumerable<long>
{
public static readonly long[] Value=A184962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184962.Bytes);
public long this[int i]=>Value[i];

public static A184962Inst Instance=new A184962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184963
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,4L,21L,266L,7848L,367860L,21609299L,1470293674L,113314233799L,9799685588930L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184963Inst : IEnumerable<long>
{
public static readonly long[] Value=A184963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184963.Bytes);
public long this[int i]=>Value[i];

public static A184963Inst Instance=new A184963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184964
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,9L,6L,267L,3727L,483012L,69823723L,14836130862L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184964Inst : IEnumerable<long>
{
public static readonly long[] Value=A184964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184964.Bytes);
public long this[int i]=>Value[i];

public static A184964Inst Instance=new A184964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184965
{
public static readonly BigInteger[] Value={ 1L,0L,0L,0L,0L,0L,0L,1L,2L,78L,888L,13909L,204448L,3182225L,51504968L,873224962L,15498424578L,287972983669L,5598118158336L,113756109812283L,2413723031593090L,53416658591208438L,1231458960862452472L,BigInteger.Parse("29538634475147637783"),BigInteger.Parse("736321207493996695072") };
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
public class A184965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184965Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184965.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184965.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184965Inst Instance=new A184965Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184966
{
public static readonly long[] Value={ 2L,3L,4L,6L,7L,11L,12L,14L,15L,16L,20L,22L,23L,27L,31L,34L,35L,36L,38L,39L,42L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184966Inst : IEnumerable<long>
{
public static readonly long[] Value=A184966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184966.Bytes);
public long this[int i]=>Value[i];

public static A184966Inst Instance=new A184966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184967
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,8L,9L,10L,12L,13L,16L,20L,21L,22L,24L,25L,26L,28L,29L,30L,32L,33L,34L,36L,37L,41L,42L,44L,45L,46L,48L,50L,52L,54L,56L,57L,58L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184967Inst : IEnumerable<long>
{
public static readonly long[] Value=A184967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184967.Bytes);
public long this[int i]=>Value[i];

public static A184967Inst Instance=new A184967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184968
{
public static readonly long[] Value={ 5L,11L,17L,41L,85L,137L,257L,641L,1285L,2329L,4369L,10537L,17477L,35209L,65537L,163841L,297109L,557057L,1114129L,2687017L,4491589L,8978569L,16843009L,42009217L,71304257L,143163649L,286331153L,690563369L,1145390149L,2281701377L,4295098369L,10737647617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184968Inst : IEnumerable<long>
{
public static readonly long[] Value=A184968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184968.Bytes);
public long this[int i]=>Value[i];

public static A184968Inst Instance=new A184968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184969
{
public static readonly long[] Value={ 3L,9L,18L,30L,45L,63L,84L,109L,137L,168L,202L,239L,279L,322L,369L,419L,472L,528L,587L,649L,714L,783L,855L,930L,1008L,1089L,1173L,1260L,1351L,1445L,1542L,1642L,1745L,1851L,1960L,2073L,2189L,2308L,2430L,2555L,2683L,2814L,2949L,3087L,3228L,3372L,3519L,3669L,3822L,3979L,4139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184969Inst : IEnumerable<long>
{
public static readonly long[] Value=A184969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184969.Bytes);
public long this[int i]=>Value[i];

public static A184969Inst Instance=new A184969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184970
{
public static readonly long[] Value={ 1L,5L,1547L,21609300L,1L,733351105933L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184970Inst : IEnumerable<long>
{
public static readonly long[] Value=A184970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184970.Bytes);
public long this[int i]=>Value[i];

public static A184970Inst Instance=new A184970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184971
{
public static readonly long[] Value={ 1L,5L,1547L,21609301L,1L,733351105934L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184971Inst : IEnumerable<long>
{
public static readonly long[] Value=A184971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184971.Bytes);
public long this[int i]=>Value[i];

public static A184971Inst Instance=new A184971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185036
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,6L,37L,432L,8119L,191254L,4855919L,127937854L,3482858263L,98176518258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185036Inst : IEnumerable<long>
{
public static readonly long[] Value=A185036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185036.Bytes);
public long this[int i]=>Value[i];

public static A185036Inst Instance=new A185036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185037
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,3L,27L,609L,32237L,1885410L,101214661L,5025320937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185037Inst : IEnumerable<long>
{
public static readonly long[] Value=A185037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185037.Bytes);
public long this[int i]=>Value[i];

public static A185037Inst Instance=new A185037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185038
{
public static readonly long[] Value={ 1L,8L,15L,64L,7069L,229826L,62906548L,104509874538L,209233407362L,474536678820L,2653613575299L,14802269029898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185038Inst : IEnumerable<long>
{
public static readonly long[] Value=A185038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185038.Bytes);
public long this[int i]=>Value[i];

public static A185038Inst Instance=new A185038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185039
{
public static readonly long[] Value={ 0L,5L,13L,28L,44L,69L,93L,128L,160L,205L,245L,300L,348L,413L,469L,544L,608L,693L,765L,860L,940L,1045L,1133L,1248L,1344L,1469L,1573L,1708L,1820L,1965L,2085L,2240L,2368L,2533L,2669L,2844L,2988L,3173L,3325L,3520L,3680L,3885L,4053L,4268L,4444L,4669L,4853L,5088L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185039Inst : IEnumerable<long>
{
public static readonly long[] Value=A185039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185039.Bytes);
public long this[int i]=>Value[i];

public static A185039Inst Instance=new A185039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185040
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,54L,220L,973L,4607L,23230L,124088L,698471L,4124961L,25474314L,164063103L,1099233251L,7645091839L,55085061358L,410472347944L,3158307976315L,25057152530411L,204717532709542L,1720324316575275L,14853374782672785L,131632834029683663L,1196258970969508760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185040Inst : IEnumerable<long>
{
public static readonly long[] Value=A185040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185040.Bytes);
public long this[int i]=>Value[i];

public static A185040Inst Instance=new A185040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185041
{
public static readonly long[] Value={ 1L,2L,2L,1L,4L,9L,8L,0L,2L,9L,9L,5L,6L,5L,7L,2L,1L,6L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185041Inst : IEnumerable<long>
{
public static readonly long[] Value=A185041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185041.Bytes);
public long this[int i]=>Value[i];

public static A185041Inst Instance=new A185041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185042
{
public static readonly long[] Value={ 210L,7314L,37960L,134043L,357642L,2713332L,1217250L,14273478L,44939642L,76067298L,163459742L,547163235L,2081479430L,2771263512L,11715712410L,17911205580L,56608713884L,203594236366L,118968284928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185042Inst : IEnumerable<long>
{
public static readonly long[] Value=A185042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185042.Bytes);
public long this[int i]=>Value[i];

public static A185042Inst Instance=new A185042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185043
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,3L,8L,25L,88L,377L,2026L,13349L,104593L,930571L,9124627L,96699740L,1095467916L,13175254799L,167460501260L,2241576473025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185043Inst : IEnumerable<long>
{
public static readonly long[] Value=A185043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185043.Bytes);
public long this[int i]=>Value[i];

public static A185043Inst Instance=new A185043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185044
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,2L,2L,15L,35L,247L,1692L,17409L,197924L,2492824L,33117880L,461597957L,6709514218L,101153412903L,1597440868898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185044Inst : IEnumerable<long>
{
public static readonly long[] Value=A185044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185044.Bytes);
public long this[int i]=>Value[i];

public static A185044Inst Instance=new A185044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185045
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,4L,1L,10L,16L,8L,1L,14L,36L,40L,16L,1L,18L,64L,112L,96L,32L,1L,22L,100L,240L,320L,224L,64L,1L,26L,144L,440L,800L,864L,512L,128L,1L,30L,196L,728L,1680L,2464L,2240L,1152L,256L,1L,34L,256L,1120L,3136L,5824L,7168L,5632L,2560L,512L,1L,38L,324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185045Inst : IEnumerable<long>
{
public static readonly long[] Value=A185045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185045.Bytes);
public long this[int i]=>Value[i];

public static A185045Inst Instance=new A185045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185046
{
public static readonly long[] Value={ 5L,3L,5L,7L,13L,3L,13L,3L,5L,3L,3L,11L,0L,7L,5L,19L,37L,11L,5L,7L,5L,7L,37L,11L,5L,31L,53L,31L,13L,23L,5L,7L,5L,7L,13L,23L,13L,19L,5L,7L,421L,47L,5L,7L,5L,11L,13L,11L,5L,43L,5L,11L,61L,23L,5L,19L,5L,7L,5L,5L,53L,7L,17L,7L,13L,11L,13L,7L,113L,7L,373L,11L,17L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185046Inst : IEnumerable<long>
{
public static readonly long[] Value=A185046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185046.Bytes);
public long this[int i]=>Value[i];

public static A185046Inst Instance=new A185046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185047
{
public static readonly long[] Value={ 1L,4L,21L,126L,819L,5616L,40014L,293436L,2200770L,16805880L,130245570L,1021926780L,8102419470L,64819355760L,522606055815L,4242331511910L,34645707347265L,284459491903860L,2346790808206845L,19444838125142430L,161745698950048395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185047Inst : IEnumerable<long>
{
public static readonly long[] Value=A185047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185047.Bytes);
public long this[int i]=>Value[i];

public static A185047Inst Instance=new A185047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185048
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,2L,6L,4L,8L,4L,10L,6L,12L,6L,14L,8L,16L,8L,18L,10L,20L,10L,22L,12L,24L,12L,26L,14L,28L,14L,30L,16L,32L,16L,34L,18L,36L,18L,38L,20L,40L,20L,42L,22L,44L,22L,46L,24L,48L,24L,50L,26L,52L,26L,54L,28L,56L,28L,58L,30L,60L,30L,62L,32L,64L,32L,66L,34L,68L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185048Inst : IEnumerable<long>
{
public static readonly long[] Value=A185048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185048.Bytes);
public long this[int i]=>Value[i];

public static A185048Inst Instance=new A185048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185049
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185049Inst : IEnumerable<long>
{
public static readonly long[] Value=A185049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185049.Bytes);
public long this[int i]=>Value[i];

public static A185049Inst Instance=new A185049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185050
{
public static readonly long[] Value={ 3L,5L,7L,8L,10L,12L,13L,15L,17L,19L,20L,22L,24L,25L,27L,29L,31L,32L,34L,36L,37L,39L,41L,43L,44L,46L,48L,49L,51L,53L,54L,56L,58L,60L,61L,63L,65L,66L,68L,70L,72L,73L,75L,77L,78L,80L,82L,84L,85L,87L,89L,90L,92L,94L,96L,97L,99L,101L,102L,104L,106L,107L,109L,111L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185050Inst : IEnumerable<long>
{
public static readonly long[] Value=A185050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185050.Bytes);
public long this[int i]=>Value[i];

public static A185050Inst Instance=new A185050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185051
{
public static readonly long[] Value={ -3L,1L,5L,2L,1L,24L,9L,2L,2L,1L,1L,6L,8L,11L,2L,44L,1L,5L,3L,424L,1L,5L,39L,2L,1L,1L,2L,1L,1L,6L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,7L,4L,2L,1L,1L,15L,2L,3L,3L,3L,2L,1L,45L,15L,10L,16L,3L,1L,1L,1L,2L,2L,1L,1L,6L,2L,1L,2L,3L,2L,14L,3L,5L,1L,2L,1L,19L,1L,4L,16L,5L,1L,2L,1L,1L,2L,2L,2L,1L,1L,1L,2L,2L,1L,3L,1L,2L,1L,16L,65L,2L,3L,3L,1L,5L,3L,1L,11L,2L,1L,3L,1L,1L,2L,5L,2L,11L,1L,2L,2L,1L,10L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185051Inst : IEnumerable<long>
{
public static readonly long[] Value=A185051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185051.Bytes);
public long this[int i]=>Value[i];

public static A185051Inst Instance=new A185051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185276
{
public static readonly long[] Value={ 1L,0L,-1L,0L,0L,0L,-1L,0L,1L,0L,-1L,0L,1L,0L,0L,0L,1L,0L,-1L,0L,1L,0L,-1L,0L,0L,0L,-1L,0L,1L,0L,-1L,0L,1L,0L,0L,0L,1L,0L,-1L,0L,1L,0L,-1L,0L,0L,0L,-1L,0L,1L,0L,-1L,0L,1L,0L,0L,0L,1L,0L,-1L,0L,1L,0L,-1L,0L,0L,0L,-1L,0L,1L,0L,-1L,0L,1L,0L,0L,0L,1L,0L,-1L,0L,1L,0L,-1L,0L,0L,0L,-1L,0L,1L,0L,-1L,0L,1L,0L,0L,0L,1L,0L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185276Inst : IEnumerable<long>
{
public static readonly long[] Value=A185276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185276.Bytes);
public long this[int i]=>Value[i];

public static A185276Inst Instance=new A185276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185277
{
public static readonly long[] Value={ 1L,10L,593L,20412L,268705L,2012174L,10609137L,45136576L,177264449L,774840978L,4486784401L,33739007300L,287589316833L,2552470327702L,22897453501745L,205929575454024L,1853088908328577L,16677300287543066L,150094833656289489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185277Inst : IEnumerable<long>
{
public static readonly long[] Value=A185277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185277.Bytes);
public long this[int i]=>Value[i];

public static A185277Inst Instance=new A185277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185278
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,2L,2L,3L,2L,4L,2L,3L,3L,5L,2L,5L,3L,4L,3L,6L,4L,6L,4L,5L,4L,8L,3L,8L,5L,6L,5L,7L,4L,10L,5L,7L,6L,11L,4L,11L,6L,7L,6L,12L,6L,11L,6L,9L,7L,14L,5L,11L,8L,10L,8L,15L,6L,16L,8L,10L,9L,14L,6L,17L,9L,12L,7L,18L,8L,19L,10L,11L,10L,16L,7L,20L,10L,14L,11L,21L,8L,18L,11L,15L,12L,23L,7L,19L,12L,16L,12L,19L,10L,25L,11L,16L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185278Inst : IEnumerable<long>
{
public static readonly long[] Value=A185278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185278.Bytes);
public long this[int i]=>Value[i];

public static A185278Inst Instance=new A185278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185279
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,2L,0L,1L,1L,2L,0L,3L,0L,1L,1L,3L,0L,3L,1L,1L,1L,5L,0L,6L,0L,2L,2L,3L,1L,7L,0L,3L,1L,8L,0L,9L,1L,1L,2L,9L,0L,8L,1L,3L,2L,11L,0L,7L,1L,4L,3L,13L,0L,14L,1L,3L,4L,8L,1L,15L,1L,6L,1L,16L,0L,17L,3L,2L,4L,11L,1L,18L,0L,7L,4L,19L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185279Inst : IEnumerable<long>
{
public static readonly long[] Value=A185279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185279.Bytes);
public long this[int i]=>Value[i];

public static A185279Inst Instance=new A185279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185280
{
public static readonly long[] Value={ 8L,8L,2L,5L,4L,2L,4L,0L,0L,6L,1L,0L,6L,0L,6L,3L,7L,3L,5L,8L,5L,8L,2L,5L,7L,2L,8L,4L,7L,1L,9L,9L,0L,7L,6L,3L,9L,3L,0L,7L,5L,8L,9L,9L,4L,9L,1L,8L,6L,2L,1L,8L,8L,1L,9L,5L,7L,0L,5L,2L,9L,3L,4L,8L,2L,8L,4L,8L,7L,0L,6L,8L,1L,8L,6L,7L,4L,6L,7L,2L,9L,9L,9L,1L,9L,7L,2L,4L,4L,7L,4L,1L,5L,8L,7L,0L,2L,2L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185280Inst : IEnumerable<long>
{
public static readonly long[] Value=A185280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185280.Bytes);
public long this[int i]=>Value[i];

public static A185280Inst Instance=new A185280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185281
{
public static readonly BigInteger[] Value={ 2L,0L,40L,800L,20288L,606400L,20971904L,825910528L,36572366848L,1802071653376L,97938520514560L,5826195568779264L,376854594173526016L,BigInteger.Parse("26349673341110894592"),BigInteger.Parse("1981251753509044977664"),BigInteger.Parse("159466640566146568814592"),BigInteger.Parse("13683137506507195162427392") };
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
public class A185281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185281Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A185281.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A185281.Bytes);
public BigInteger this[int i]=>Value[i];

public static A185281Inst Instance=new A185281Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185282
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,3L,3L,0L,1L,1L,7L,36L,7L,0L,1L,1L,15L,351L,785L,18L,0L,1L,1L,31L,3240L,56217L,26404L,51L,0L,1L,1L,63L,29403L,3695545L,18878418L,1235580L,155L,0L,1L,1L,127L,265356L,238085177L,12107973904L,11163952389L,74394425L,486L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185282Inst : IEnumerable<long>
{
public static readonly long[] Value=A185282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185282.Bytes);
public long this[int i]=>Value[i];

public static A185282Inst Instance=new A185282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185283
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185283Inst : IEnumerable<long>
{
public static readonly long[] Value=A185283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185283.Bytes);
public long this[int i]=>Value[i];

public static A185283Inst Instance=new A185283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185284
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,14L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185284Inst : IEnumerable<long>
{
public static readonly long[] Value=A185284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185284.Bytes);
public long this[int i]=>Value[i];

public static A185284Inst Instance=new A185284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185285
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,10L,6L,1L,0L,74L,52L,12L,1L,0L,730L,570L,160L,20L,1L,0L,9002L,7600L,2430L,380L,30L,1L,0L,133210L,119574L,42070L,7630L,770L,42L,1L,0L,2299754L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185285Inst : IEnumerable<long>
{
public static readonly long[] Value=A185285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185285.Bytes);
public long this[int i]=>Value[i];

public static A185285Inst Instance=new A185285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185286
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,1L,1L,2L,1L,2L,5L,6L,3L,3L,3L,1L,11L,11L,13L,17L,13L,7L,6L,4L,1L,24L,41L,52L,44L,43L,40L,25L,14L,10L,5L,1L,93L,120L,152L,176L,161L,126L,107L,80L,45L,25L,15L,6L,1L,272L,421L,550L,559L,561L,524L,412L,303L,227L,146L,77L,41L,21L,7L,1L,971L,1381L,1813L,2056L,2045L,1835L,1615L,1309L,938L,648L,435L,251L,126L,63L,28L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185286Inst : IEnumerable<long>
{
public static readonly long[] Value=A185286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185286.Bytes);
public long this[int i]=>Value[i];

public static A185286Inst Instance=new A185286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185287
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,2L,2L,0L,1L,3L,3L,0L,0L,1L,4L,5L,3L,0L,0L,1L,5L,8L,7L,3L,0L,0L,1L,6L,12L,13L,7L,0L,0L,0L,1L,7L,17L,22L,16L,6L,0L,0L,0L,1L,8L,23L,35L,32L,17L,4L,0L,0L,0L,1L,9L,30L,53L,58L,39L,14L,0L,0L,0L,0L,1L,10L,38L,77L,98L,80L,40L,10L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185287Inst : IEnumerable<long>
{
public static readonly long[] Value=A185287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185287.Bytes);
public long this[int i]=>Value[i];

public static A185287Inst Instance=new A185287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185288
{
public static readonly long[] Value={ 1L,6L,60L,90L,120L,180L,360L,540L,816L,840L,1080L,1740L,1980L,2280L,2520L,3060L,3960L,5712L,6120L,8280L,9540L,11880L,12240L,16920L,18360L,19260L,24480L,25296L,25560L,32760L,36720L,42840L,48960L,54672L,57240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185288Inst : IEnumerable<long>
{
public static readonly long[] Value=A185288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185288.Bytes);
public long this[int i]=>Value[i];

public static A185288Inst Instance=new A185288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185289
{
public static readonly BigInteger[] Value={ 1L,1L,6L,75L,1612L,52805L,2442666L,151382959L,12093970008L,1209295535049L,147859385866390L,21692929137930611L,3759744512444581860L,BigInteger.Parse("759740612270504941453"),BigInteger.Parse("177000400360669503651138"),BigInteger.Parse("47085371754008630756331255"),BigInteger.Parse("14182051733113750632290151856") };
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
public class A185289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185289Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A185289.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A185289.Bytes);
public BigInteger this[int i]=>Value[i];

public static A185289Inst Instance=new A185289Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185290
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,9L,5L,10L,16L,25L,7L,12L,22L,38L,63L,8L,15L,27L,49L,87L,150L,11L,19L,34L,61L,110L,197L,347L,13L,24L,43L,77L,138L,248L,445L,792L,14L,28L,52L,95L,172L,310L,558L,1003L,1795L,17L,31L,59L,111L,206L,378L,688L,1246L,2249L,4044L,18L,35L,66L,125L,236L,442L,820L,1508L,2754L,5003L,9047L,20L,39L,74L,140L,265L,501L,943L,1763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185290Inst : IEnumerable<long>
{
public static readonly long[] Value=A185290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185290.Bytes);
public long this[int i]=>Value[i];

public static A185290Inst Instance=new A185290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185291
{
public static readonly long[] Value={ 1L,2L,2L,5L,2L,6L,2L,14L,5L,6L,2L,18L,2L,6L,4L,42L,2L,18L,2L,18L,6L,6L,2L,58L,5L,6L,14L,16L,2L,18L,2L,150L,4L,6L,4L,60L,2L,6L,6L,56L,2L,24L,2L,16L,10L,6L,2L,202L,5L,18L,4L,18L,2L,58L,6L,52L,6L,6L,2L,66L,2L,6L,16L,717L,4L,18L,2L,18L,4L,18L,2L,218L,2L,6L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185291Inst : IEnumerable<long>
{
public static readonly long[] Value=A185291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185291.Bytes);
public long this[int i]=>Value[i];

public static A185291Inst Instance=new A185291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185340
{
public static readonly long[] Value={ 1L,1L,2L,6L,1L,16L,0L,60L,2L,266L,2L,1547L,12L,10786L,31L,88193L,220L,805579L,1606L,8037796L,16829L,86223660L,193900L,985883873L,2452820L,11946592242L,32670332L,1L,152808993767L,456028489L,2L,2056701139136L,6636066134L,8L,28566369866514L,100135577994L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185340Inst : IEnumerable<long>
{
public static readonly long[] Value=A185340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185340.Bytes);
public long this[int i]=>Value[i];

public static A185340Inst Instance=new A185340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185341
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,5L,10L,6L,21L,77L,55L,145L,899L,868L,1988L,38411L,90347L,95357L,637807L,3506263L,2382501L,19519203L,649945741L,911672929L,3857971277L,130630182325L,366719420575L,764101349503L,12533062448579L,136235802233249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185341Inst : IEnumerable<long>
{
public static readonly long[] Value=A185341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185341.Bytes);
public long this[int i]=>Value[i];

public static A185341Inst Instance=new A185341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185342
{
public static readonly long[] Value={ 2L,4L,-4L,6L,-12L,8L,8L,-24L,32L,-16L,10L,-40L,80L,-80L,32L,12L,-60L,160L,-240L,192L,-64L,14L,-84L,280L,-560L,672L,-448L,128L,16L,-112L,448L,-1120L,1792L,-1792L,1024L,-256L,18L,-144L,672L,-2016L,4032L,-5376L,4608L,-2304L,512L,20L,-180L,960L,-3360L,8064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185342Inst : IEnumerable<long>
{
public static readonly long[] Value=A185342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185342.Bytes);
public long this[int i]=>Value[i];

public static A185342Inst Instance=new A185342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185343
{
public static readonly BigInteger[] Value={ 2L,0L,2L,6L,62L,210L,2570L,9198L,121574L,2L,23091222L,48L,2L,68186767614L,6L,2L,48L,12600235023025650L,109368L,794502L,24L,BigInteger.Parse("2550476412689091085878"),6L,2L,10L,BigInteger.Parse("8367330694575771627040945250"),4030501264L,6L,955272L,2L,BigInteger.Parse("446564785985483547852197647548252246"),8L,8L,32424L,8L };
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
public class A185343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185343Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A185343.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A185343.Bytes);
public BigInteger this[int i]=>Value[i];

public static A185343Inst Instance=new A185343Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185344
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,2L,2L,12L,31L,220L,1606L,16829L,193900L,2452820L,32670332L,456028489L,6636066134L,100135577994L,1582718914660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185344Inst : IEnumerable<long>
{
public static readonly long[] Value=A185344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185344.Bytes);
public long this[int i]=>Value[i];

public static A185344Inst Instance=new A185344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185345
{
public static readonly long[] Value={ 3L,4L,5L,10L,11L,14L,18L,21L,23L,24L,25L,29L,32L,36L,38L,39L,40L,41L,44L,45L,46L,47L,52L,55L,57L,59L,60L,66L,73L,74L,76L,77L,80L,81L,82L,83L,88L,93L,95L,99L,100L,101L,102L,108L,109L,111L,112L,113L,116L,118L,119L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185345Inst : IEnumerable<long>
{
public static readonly long[] Value=A185345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185345.Bytes);
public long this[int i]=>Value[i];

public static A185345Inst Instance=new A185345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185346
{
public static readonly long[] Value={ -8L,-7L,-5L,-1L,7L,23L,55L,119L,247L,503L,1015L,2039L,4087L,8183L,16375L,32759L,65527L,131063L,262135L,524279L,1048567L,2097143L,4194295L,8388599L,16777207L,33554423L,67108855L,134217719L,268435447L,536870903L,1073741815L,2147483639L,4294967287L,8589934583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185346Inst : IEnumerable<long>
{
public static readonly long[] Value=A185346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185346.Bytes);
public long this[int i]=>Value[i];

public static A185346Inst Instance=new A185346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185347
{
public static readonly long[] Value={ 129L,158L,382L,1114L,1546L,2374L,2582L,3446L,3578L,6218L,6826L,7978L,8266L,9298L,9382L,10202L,12946L,14002L,15178L,15406L,15766L,16382L,16466L,17282L,17362L,18374L,18838L,19226L,19606L,23878L,24074L,25154L,25642L,26206L,29782L,30034L,30638L,32902L,33526L,34862L,34934L,35678L,35978L,36602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185347Inst : IEnumerable<long>
{
public static readonly long[] Value=A185347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185347.Bytes);
public long this[int i]=>Value[i];

public static A185347Inst Instance=new A185347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185348
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,8L,4L,10L,2L,42L,4L,79L,16L,25L,36L,183L,20L,277L,50L,100L,70L,491L,56L,399L,139L,340L,146L,1016L,56L,1285L,398L,493L,342L,706L,184L,2150L,501L,807L,363L,2968L,210L,3522L,775L,935L,904L,4620L,508L,3732L,842L,2011L,1255L,6684L,728L,3355L,1304L,2785L,1877L,9141L,546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185348Inst : IEnumerable<long>
{
public static readonly long[] Value=A185348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185348.Bytes);
public long this[int i]=>Value[i];

public static A185348Inst Instance=new A185348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185349
{
public static readonly long[] Value={ 1L,1L,2L,6L,22L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185349Inst : IEnumerable<long>
{
public static readonly long[] Value=A185349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185349.Bytes);
public long this[int i]=>Value[i];

public static A185349Inst Instance=new A185349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185350
{
public static readonly long[] Value={ 0L,1L,3L,3L,8L,11L,17L,23L,36L,48L,69L,88L,125L,157L,212L,271L,356L,445L,574L,711L,906L,1118L,1400L,1711L,2125L,2583L,3171L,3828L,4666L,5604L,6777L,8095L,9730L,11567L,13815L,16357L,19429L,22910L,27077L,31801L,37432L,43802L,51338L,59871L,69914L,81273L,94562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185350Inst : IEnumerable<long>
{
public static readonly long[] Value=A185350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185350.Bytes);
public long this[int i]=>Value[i];

public static A185350Inst Instance=new A185350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185351
{
public static readonly long[] Value={ 0L,6L,28L,34L,496L,502L,524L,530L,8128L,8134L,8156L,8162L,8624L,8630L,8652L,8658L,33550336L,33550342L,33550364L,33550370L,33550832L,33550838L,33550860L,33550866L,33558464L,33558470L,33558492L,33558498L,33558960L,33558966L,33558988L,33558994L,8589869056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185351Inst : IEnumerable<long>
{
public static readonly long[] Value=A185351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185351.Bytes);
public long this[int i]=>Value[i];

public static A185351Inst Instance=new A185351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185352
{
public static readonly long[] Value={ 2L,4L,8L,17L,39L,92L,275L,922L,2894L,10843L,35944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185352Inst : IEnumerable<long>
{
public static readonly long[] Value=A185352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185352.Bytes);
public long this[int i]=>Value[i];

public static A185352Inst Instance=new A185352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185353
{
public static readonly long[] Value={ 1L,5L,2L,8L,3L,9L,2L,8L,7L,7L,8L,4L,7L,3L,8L,4L,1L,5L,4L,4L,5L,9L,6L,2L,7L,3L,6L,2L,1L,1L,2L,8L,1L,7L,2L,8L,5L,9L,8L,8L,9L,3L,0L,6L,1L,7L,0L,6L,5L,5L,6L,2L,5L,1L,6L,2L,9L,3L,2L,2L,3L,7L,4L,0L,5L,1L,4L,0L,9L,9L,0L,6L,9L,5L,0L,6L,3L,7L,6L,6L,7L,1L,8L,4L,9L,5L,8L,4L,3L,3L,4L,0L,3L,9L,4L,0L,7L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185353Inst : IEnumerable<long>
{
public static readonly long[] Value=A185353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185353.Bytes);
public long this[int i]=>Value[i];

public static A185353Inst Instance=new A185353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185354
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,1L,7L,388L,406824L,1125022326L,3813549359275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185354Inst : IEnumerable<long>
{
public static readonly long[] Value=A185354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185354.Bytes);
public long this[int i]=>Value[i];

public static A185354Inst Instance=new A185354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185355
{
public static readonly long[] Value={ 0L,1L,12L,52L,150L,345L,686L,1232L,2052L,3225L,4840L,6996L,9802L,13377L,17850L,23360L,30056L,38097L,47652L,58900L,72030L,87241L,104742L,124752L,147500L,173225L,202176L,234612L,270802L,311025L,355570L,404736L,458832L,518177L,583100L,653940L,731046L,814777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185355Inst : IEnumerable<long>
{
public static readonly long[] Value=A185355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185355.Bytes);
public long this[int i]=>Value[i];

public static A185355Inst Instance=new A185355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185500
{
public static readonly long[] Value={ 163L,4451L,41643L,511253L,5616321L,64545575L,727129819L,8283584625L,93761899297L,1065767584217L,12080527740895L,137188686654855L,1555953195033973L,17662716526799485L,200379471621898891L,2274227720558492871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185500Inst : IEnumerable<long>
{
public static readonly long[] Value=A185500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185500.Bytes);
public long this[int i]=>Value[i];

public static A185500Inst Instance=new A185500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185501
{
public static readonly BigInteger[] Value={ 1107L,30775L,511253L,10355969L,195165583L,3784477987L,72577946431L,1400254209765L,26934983956119L,519085872480091L,9991604236031191L,192473062350309415L,3705736421701914691L,BigInteger.Parse("71373052403445647521") };
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
public class A185501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185501Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A185501.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A185501.Bytes);
public BigInteger this[int i]=>Value[i];

public static A185501Inst Instance=new A185501Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185502
{
public static readonly long[] Value={ 2887L,207705L,5616321L,195165583L,6164545679L,201869155765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185502Inst : IEnumerable<long>
{
public static readonly long[] Value=A185502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185502.Bytes);
public long this[int i]=>Value[i];

public static A185502Inst Instance=new A185502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185503
{
public static readonly long[] Value={ 13347L,1418183L,64545575L,3784477987L,201869155765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185503Inst : IEnumerable<long>
{
public static readonly long[] Value=A185503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185503.Bytes);
public long this[int i]=>Value[i];

public static A185503Inst Instance=new A185503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185504
{
public static readonly long[] Value={ 0L,99L,99L,163L,697L,163L,1107L,4451L,4451L,1107L,2887L,30775L,41643L,30775L,2887L,13347L,207705L,511253L,511253L,207705L,13347L,43105L,1418183L,5616321L,10355969L,5616321L,1418183L,43105L,174081L,9658679L,64545575L,195165583L,195165583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185504Inst : IEnumerable<long>
{
public static readonly long[] Value=A185504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185504.Bytes);
public long this[int i]=>Value[i];

public static A185504Inst Instance=new A185504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185505
{
public static readonly long[] Value={ 1L,11L,51L,156L,375L,771L,1421L,2416L,3861L,5875L,8591L,12156L,16731L,22491L,29625L,38336L,48841L,61371L,76171L,93500L,113631L,136851L,163461L,193776L,228125L,266851L,310311L,358876L,412931L,472875L,539121L,612096L,692241L,780011L,875875L,980316L,1093831L,1216931L,1350141L,1494000L,1649061L,1815891L,1995071L,2187196L,2392875L,2612731L,2847401L,3097536L,3363801L,3646875L,3947451L,4266236L,4603951L,4961331L,5339125L,5738096L,6159021L,6602691L,7069911L,7561500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185505Inst : IEnumerable<long>
{
public static readonly long[] Value=A185505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185505.Bytes);
public long this[int i]=>Value[i];

public static A185505Inst Instance=new A185505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185506
{
public static readonly long[] Value={ 1L,3L,4L,7L,11L,10L,14L,23L,26L,20L,25L,42L,51L,50L,35L,41L,70L,88L,94L,85L,56L,63L,109L,140L,156L,155L,133L,84L,92L,161L,210L,240L,250L,237L,196L,120L,129L,228L,301L,350L,375L,374L,343L,276L,165L,175L,312L,416L,490L,535L,550L,532L,476L,375L,220L,231L,415L,558L,664L,735L,771L,770L,728L,639L,495L,286L,298L,539L,730L,876L,980L,1043L,1064L,1040L,966L,835L,638L,364L,377L,686L,935L,1130L,1275L,1372L,1421L,1420L,1365L,1250L,1067L,806L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185506Inst : IEnumerable<long>
{
public static readonly long[] Value=A185506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185506.Bytes);
public long this[int i]=>Value[i];

public static A185506Inst Instance=new A185506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185507
{
public static readonly long[] Value={ 1L,4L,5L,11L,19L,15L,25L,49L,55L,35L,50L,105L,136L,125L,70L,91L,200L,280L,300L,245L,126L,154L,350L,515L,600L,575L,434L,210L,246L,574L,875L,1075L,1125L,1001L,714L,330L,375L,894L,1400L,1785L,1975L,1925L,1624L,1110L,495L,550L,1335L,2136L,2800L,3220L,3325L,3080L,2496L,1650L,715L,781L,1925L,3135L,4200L,4970L,5341L,5250L,4680L,3675L,2365L,1001L,1079L,2695L,4455L,6075L,7350L,8134L,8330L,7890L,6825L,5225L,3289L,1365L,1456L,3679L,6160L,8525L,10500L,11886L,12544L,12390L,11400L,9625L,7216L,4459L,1820L,1925L,4914L,8320L,11660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185507Inst : IEnumerable<long>
{
public static readonly long[] Value=A185507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185507.Bytes);
public long this[int i]=>Value[i];

public static A185507Inst Instance=new A185507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185508
{
public static readonly long[] Value={ 1L,5L,6L,16L,29L,21L,41L,89L,99L,56L,91L,219L,295L,259L,126L,182L,469L,705L,755L,574L,252L,336L,910L,1470L,1765L,1645L,1134L,462L,582L,1638L,2786L,3605L,3780L,3206L,2058L,792L,957L,2778L,4914L,6706L,7595L,7266L,5754L,3498L,1287L,1507L,4488L,8190L,11634L,13916L,14406L,12894L,9690L,5643L,2002L,2288L,6963L,13035L,19110L,23814L,26068L,25284L,21510L,15510L,8723L,3003L,3367L,10439L,19965L,30030L,38640L,44100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185508Inst : IEnumerable<long>
{
public static readonly long[] Value=A185508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185508.Bytes);
public long this[int i]=>Value[i];

public static A185508Inst Instance=new A185508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185509
{
public static readonly long[] Value={ 1L,6L,7L,22L,41L,28L,63L,146L,161L,84L,154L,406L,561L,476L,210L,336L,966L,1526L,1631L,1176L,462L,672L,2058L,3556L,4361L,3976L,2562L,924L,1254L,4032L,7434L,9996L,10486L,8568L,5082L,1716L,2211L,7392L,14322L,20580L,23716L,22344L,16842L,9372L,3003L,3718L,12837L,25872L,39102L,48216L,49980L,43512L,30822L,16302L,5005L,6006L,21307L,44352L,69762L,90552L,100548L,96432L,79002L,53262L,27027L,8008L,9373L,34034L,72787L,118272L,159852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185509Inst : IEnumerable<long>
{
public static readonly long[] Value=A185509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185509.Bytes);
public long this[int i]=>Value[i];

public static A185509Inst Instance=new A185509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185510
{
public static readonly long[] Value={ 2L,7L,3L,11L,5L,13L,29L,17L,31L,19L,37L,23L,139L,59L,41L,67L,47L,193L,109L,71L,61L,79L,107L,409L,157L,83L,97L,43L,137L,173L,499L,257L,281L,331L,73L,53L,191L,233L,823L,439L,383L,601L,127L,113L,199L,211L,353L,1381L,599L,1181L,709L,197L,179L,829L,101L,277L,467L,1543L,907L,1601L,1087L,283L,239L,1549L,163L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185510Inst : IEnumerable<long>
{
public static readonly long[] Value=A185510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185510.Bytes);
public long this[int i]=>Value[i];

public static A185510Inst Instance=new A185510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185511
{
public static readonly long[] Value={ 1L,4L,2L,5L,3L,6L,10L,7L,11L,8L,12L,9L,34L,17L,13L,19L,15L,44L,29L,20L,18L,22L,28L,80L,37L,23L,25L,14L,33L,40L,95L,55L,60L,67L,21L,16L,43L,51L,143L,85L,76L,110L,31L,30L,46L,47L,71L,221L,109L,194L,127L,45L,41L,145L,26L,59L,91L,243L,155L,252L,181L,61L,52L,244L,38L,24L,75L,103L,314L,175L,349L,202L,63L,72L,316L,42L,32L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185511Inst : IEnumerable<long>
{
public static readonly long[] Value=A185511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185511.Bytes);
public long this[int i]=>Value[i];

public static A185511Inst Instance=new A185511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185512
{
public static readonly BigInteger[] Value={ 31L,1489L,154561L,80761059L,96865190255L,525819969687473L,7163899183570889649L,BigInteger.Parse("401495654334865659721795"),BigInteger.Parse("61022067811287778788163474527"),BigInteger.Parse("35442207739725827931704064596045201") };
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
public class A185512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185512Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A185512.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A185512.Bytes);
public BigInteger this[int i]=>Value[i];

public static A185512Inst Instance=new A185512Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185513
{
public static readonly long[] Value={ 31L,143L,593L,2553L,10847L,46303L,197329L,841449L,3587359L,15295151L,65211089L,278030937L,1185395807L,5053987327L,21547889233L,91870352457L,391693178911L,1670000659151L,7120119353681L,30356933960889L,129428088631391L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185513Inst : IEnumerable<long>
{
public static readonly long[] Value=A185513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185513.Bytes);
public long this[int i]=>Value[i];

public static A185513Inst Instance=new A185513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185514
{
public static readonly long[] Value={ 143L,1489L,12361L,115979L,1058503L,9856209L,91539073L,853020411L,7948563615L,74110312433L,691029158489L,6444134240459L,60095780277207L,560446106259121L,5226693550531025L,48744151344694907L,454588941498687343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185514Inst : IEnumerable<long>
{
public static readonly long[] Value=A185514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185514.Bytes);
public long this[int i]=>Value[i];

public static A185514Inst Instance=new A185514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185515
{
public static readonly BigInteger[] Value={ 593L,12361L,154561L,2490449L,35659489L,541370505L,7998109489L,119752453041L,1781802607473L,26592505725449L,396308610878561L,5910310463665361L,88113720913502145L,1313850510428863561L,BigInteger.Parse("19589143573382779985") };
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
public class A185515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185515Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A185515.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A185515.Bytes);
public BigInteger this[int i]=>Value[i];

public static A185515Inst Instance=new A185515Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185564
{
public static readonly BigInteger[] Value={ 1024L,3037500L,8977824540L,26533211918040L,78416544382742160L,BigInteger.Parse("231753101877188629380"),BigInteger.Parse("684925618712729136913980"),BigInteger.Parse("2024236566241727245692157080"),BigInteger.Parse("5982450596328307878990974438640") };
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
public class A185564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185564Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A185564.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A185564.Bytes);
public BigInteger this[int i]=>Value[i];

public static A185564Inst Instance=new A185564Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185565
{
public static readonly BigInteger[] Value={ 4096L,45562500L,504547256880L,5586628402633500L,BigInteger.Parse("61858104930689319360"),BigInteger.Parse("684925618712729136913980"),BigInteger.Parse("7583858300260627032845531520"),BigInteger.Parse("83972485690826213759616527499540"),BigInteger.Parse("929787724653148422947168982361958940") };
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
public class A185565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185565Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A185565.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A185565.Bytes);
public BigInteger this[int i]=>Value[i];

public static A185565Inst Instance=new A185565Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185566
{
public static readonly BigInteger[] Value={ 16384L,683437500L,28355191537860L,1176277376648694960L,BigInteger.Parse("48796145962555619907720"),BigInteger.Parse("2024236566241727245692157080"),BigInteger.Parse("83972485690826213759616527499540"),BigInteger.Parse("3483475434832751291309593655505225600") };
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
public class A185566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185566Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A185566.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A185566.Bytes);
public BigInteger this[int i]=>Value[i];

public static A185566Inst Instance=new A185566Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185567
{
public static readonly long[] Value={ 1L,4L,4L,16L,60L,16L,64L,900L,900L,64L,256L,13500L,50580L,13500L,256L,1024L,202500L,2842560L,2842560L,202500L,1024L,4096L,3037500L,159749820L,598507920L,159749820L,3037500L,4096L,16384L,45562500L,8977824540L,126017211780L,126017211780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185567Inst : IEnumerable<long>
{
public static readonly long[] Value=A185567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185567.Bytes);
public long this[int i]=>Value[i];

public static A185567Inst Instance=new A185567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185568
{
public static readonly long[] Value={ 0L,704L,1936L,34816L,172992L,2053216L,12950528L,131772320L,929033280L,8815545344L,65895014896L,602776037920L,4662229953024L,41734072588384L,329907085742480L,2911856599577984L,23363245790844864L,204187515832240736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185568Inst : IEnumerable<long>
{
public static readonly long[] Value=A185568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185568.Bytes);
public long this[int i]=>Value[i];

public static A185568Inst Instance=new A185568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185569
{
public static readonly BigInteger[] Value={ 704L,15776L,319448L,7140256L,159990728L,3638705368L,82978157360L,1901358817256L,43637766654744L,1003656982121376L,23106678843303728L,532562890880016376L,12282302223948007880UL,BigInteger.Parse("283443089332785590088"),BigInteger.Parse("6543858992849366363024") };
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
public class A185569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185569Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A185569.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A185569.Bytes);
public BigInteger this[int i]=>Value[i];

public static A185569Inst Instance=new A185569Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185570
{
public static readonly long[] Value={ 1936L,319448L,13565936L,886180500L,48714917964L,2946419096704L,170291132595760L,10155464818201668L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185570Inst : IEnumerable<long>
{
public static readonly long[] Value=A185570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185570.Bytes);
public long this[int i]=>Value[i];

public static A185570Inst Instance=new A185570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185571
{
public static readonly long[] Value={ 0L,704L,704L,1936L,15776L,1936L,34816L,319448L,319448L,34816L,172992L,7140256L,13565936L,7140256L,172992L,2053216L,159990728L,886180500L,886180500L,159990728L,2053216L,12950528L,3638705368L,48714917964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185571Inst : IEnumerable<long>
{
public static readonly long[] Value=A185571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185571.Bytes);
public long this[int i]=>Value[i];

public static A185571Inst Instance=new A185571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185572
{
public static readonly long[] Value={ 256L,3392L,44944L,598688L,7974976L,106125920L,1412256400L,18797516000L,250200040000L,3330057490400L,44321667132304L,589910483825696L,7851563387466304L,104502021786889760L,1390891472006784400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185572Inst : IEnumerable<long>
{
public static readonly long[] Value=A185572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185572.Bytes);
public long this[int i]=>Value[i];

public static A185572Inst Instance=new A185572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185573
{
public static readonly BigInteger[] Value={ 3392L,125664L,4649320L,173985944L,6508370600L,243047375432L,9075956889192L,339043219347960L,12665293283911784L,473089808175134024L,17671406269801247592UL,BigInteger.Parse("660095110422452092856"),BigInteger.Parse("24657097179457297605704") };
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
public class A185573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185573Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A185573.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A185573.Bytes);
public BigInteger this[int i]=>Value[i];

public static A185573Inst Instance=new A185573Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185574
{
public static readonly BigInteger[] Value={ 44944L,4649320L,480362772L,50465542904L,5296925520216L,554710227464956L,58085158860020628L,6085476832181549456L,BigInteger.Parse("637558422416624947542"),BigInteger.Parse("66788675132255013566752"),BigInteger.Parse("6996533512035946774940652") };
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
public class A185574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185574Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A185574.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A185574.Bytes);
public BigInteger this[int i]=>Value[i];

public static A185574Inst Instance=new A185574Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185575
{
public static readonly long[] Value={ 256L,3392L,3392L,44944L,125664L,44944L,598688L,4649320L,4649320L,598688L,7974976L,173985944L,480362772L,173985944L,7974976L,106125920L,6508370600L,50465542904L,50465542904L,6508370600L,106125920L,1412256400L,243047375432L,5296925520216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185575Inst : IEnumerable<long>
{
public static readonly long[] Value=A185575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185575.Bytes);
public long this[int i]=>Value[i];

public static A185575Inst Instance=new A185575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185576
{
public static readonly long[] Value={ 2L,8L,3L,7L,2L,9L,7L,4L,7L,9L,4L,8L,0L,6L,1L,9L,4L,7L,6L,6L,6L,5L,9L,1L,7L,1L,0L,4L,6L,0L,7L,7L,3L,8L,8L,2L,2L,3L,8L,9L,2L,1L,8L,7L,0L,2L,1L,5L,8L,4L,8L,3L,5L,9L,9L,0L,0L,3L,7L,1L,9L,0L,0L,6L,9L,9L,9L,2L,4L,7L,7L,1L,1L,1L,6L,2L,2L,7L,3L,3L,0L,9L,4L,7L,4L,0L,4L,1L,5L,3L,0L,7L,9L,2L,7L,1L,1L,0L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185576Inst : IEnumerable<long>
{
public static readonly long[] Value=A185576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185576.Bytes);
public long this[int i]=>Value[i];

public static A185576Inst Instance=new A185576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185577
{
public static readonly long[] Value={ 7L,7L,4L,3L,8L,6L,1L,4L,1L,4L,2L,4L,0L,0L,2L,8L,1L,5L,2L,1L,2L,7L,5L,1L,3L,8L,6L,4L,0L,6L,7L,8L,8L,7L,9L,8L,8L,5L,3L,1L,7L,1L,0L,4L,8L,1L,0L,3L,2L,1L,4L,4L,5L,9L,3L,0L,7L,2L,4L,0L,9L,6L,6L,4L,0L,2L,1L,4L,3L,5L,1L,9L,2L,1L,6L,3L,0L,6L,7L,8L,8L,7L,7L,8L,2L,3L,0L,9L,9L,7L,6L,7L,0L,9L,7L,0L,4L,8L,1L,6L,2L,9L,6L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185577Inst : IEnumerable<long>
{
public static readonly long[] Value=A185577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185577.Bytes);
public long this[int i]=>Value[i];

public static A185577Inst Instance=new A185577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185578
{
public static readonly long[] Value={ 1L,4L,8L,0L,3L,8L,9L,8L,0L,6L,5L,1L,2L,2L,2L,2L,5L,9L,7L,9L,0L,7L,7L,6L,1L,7L,0L,6L,3L,5L,2L,8L,1L,7L,5L,5L,5L,7L,0L,7L,6L,6L,0L,5L,0L,8L,5L,1L,3L,6L,8L,8L,5L,5L,3L,6L,4L,5L,5L,3L,6L,2L,5L,7L,0L,0L,8L,7L,5L,7L,3L,1L,7L,4L,3L,5L,0L,4L,6L,1L,2L,7L,3L,9L,8L,8L,9L,1L,0L,7L,8L,8L,9L,0L,2L,0L,4L,5L,9L,0L,1L,8L,6L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185578Inst : IEnumerable<long>
{
public static readonly long[] Value=A185578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185578.Bytes);
public long this[int i]=>Value[i];

public static A185578Inst Instance=new A185578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185579
{
public static readonly long[] Value={ 1L,5L,4L,0L,1L,7L,0L,9L,0L,1L,8L,5L,5L,5L,4L,3L,6L,1L,7L,4L,3L,6L,4L,6L,6L,6L,6L,3L,8L,6L,4L,8L,0L,3L,9L,7L,8L,4L,2L,9L,6L,2L,7L,5L,6L,4L,1L,5L,6L,1L,4L,5L,9L,4L,8L,4L,2L,1L,8L,9L,5L,5L,2L,9L,4L,6L,0L,3L,7L,9L,1L,5L,8L,7L,6L,0L,1L,2L,7L,6L,9L,7L,9L,2L,0L,7L,4L,3L,0L,7L,6L,9L,2L,2L,7L,8L,9L,1L,3L,0L,2L,5L,3L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185579Inst : IEnumerable<long>
{
public static readonly long[] Value=A185579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185579.Bytes);
public long this[int i]=>Value[i];

public static A185579Inst Instance=new A185579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185660
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,13L,15L,16L,17L,20L,22L,37L,44L,46L,48L,52L,57L,61L,63L,68L,69L,70L,72L,81L,84L,86L,94L,96L,99L,101L,106L,108L,112L,117L,123L,124L,134L,138L,162L,178L,189L,191L,193L,200L,202L,206L,223L,224L,229L,260L,264L,271L,279L,282L,294L,297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185660Inst : IEnumerable<long>
{
public static readonly long[] Value=A185660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185660.Bytes);
public long this[int i]=>Value[i];

public static A185660Inst Instance=new A185660Inst();

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