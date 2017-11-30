using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A199005
{
public static readonly long[] Value={ 1L,1L,1L,5L,3L,16L,6L,100L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199005Inst : IEnumerable<long>
{
public static readonly long[] Value=A199005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199005.Bytes);
public long this[int i]=>Value[i];

public static A199005Inst Instance=new A199005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199006
{
public static readonly long[] Value={ 192L,21504L,190080L,10838016L,16440L,823616L,74306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199006Inst : IEnumerable<long>
{
public static readonly long[] Value=A199006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199006.Bytes);
public long this[int i]=>Value[i];

public static A199006Inst Instance=new A199006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199007
{
public static readonly long[] Value={ 192L,21504L,190080L,10838016L,16440L,790224L,64488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199007Inst : IEnumerable<long>
{
public static readonly long[] Value=A199007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199007.Bytes);
public long this[int i]=>Value[i];

public static A199007Inst Instance=new A199007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199008
{
public static readonly long[] Value={ 6L,25L,196L,972L,9680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199008Inst : IEnumerable<long>
{
public static readonly long[] Value=A199008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199008.Bytes);
public long this[int i]=>Value[i];

public static A199008Inst Instance=new A199008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199009
{
public static readonly long[] Value={ 4L,6L,8L,9L,10L,12L,14L,15L,16L,18L,20L,21L,24L,25L,27L,28L,30L,32L,35L,36L,40L,42L,45L,48L,49L,50L,54L,56L,60L,63L,64L,70L,72L,75L,80L,81L,84L,90L,96L,98L,100L,105L,108L,112L,120L,121L,125L,126L,128L,135L,140L,143L,144L,147L,150L,160L,162L,168L,169L,175L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199009Inst : IEnumerable<long>
{
public static readonly long[] Value=A199009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199009.Bytes);
public long this[int i]=>Value[i];

public static A199009Inst Instance=new A199009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199010
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,1L,3L,1L,1L,3L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199010Inst : IEnumerable<long>
{
public static readonly long[] Value=A199010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199010.Bytes);
public long this[int i]=>Value[i];

public static A199010Inst Instance=new A199010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199011
{
public static readonly long[] Value={ 1L,1L,0L,2L,1L,0L,3L,3L,1L,0L,4L,6L,4L,1L,0L,5L,10L,10L,5L,1L,0L,6L,15L,20L,15L,6L,1L,0L,7L,21L,35L,35L,21L,7L,1L,0L,8L,28L,56L,70L,56L,28L,8L,1L,0L,9L,36L,84L,126L,126L,84L,36L,9L,1L,0L,10L,45L,120L,210L,252L,210L,120L,45L,10L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199011Inst : IEnumerable<long>
{
public static readonly long[] Value=A199011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199011.Bytes);
public long this[int i]=>Value[i];

public static A199011Inst Instance=new A199011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199012
{
public static readonly BigInteger[] Value={ 0L,3L,48L,1308L,96080L,23114160L,18522702240L,50214057399744L,469006445678383872L,BigInteger.Parse("15356719437883766115840"),BigInteger.Parse("1788760016178073736115859200"),BigInteger.Parse("750205198434476437912637004278784"),BigInteger.Parse("1144188684031608529784893493874665232384") };
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
public class A199012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199012Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199012.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199012.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199012Inst Instance=new A199012Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199013
{
public static readonly long[] Value={ 16L,27L,30L,60L,70L,105L,220L,231L,286L,476L,627L,646L,805L,897L,1160L,1276L,1581L,1776L,1798L,2322L,2408L,2967L,3055L,3196L,3526L,4028L,4543L,5360L,5487L,6248L,6461L,6745L,7198L,7881L,7968L,9628L,9717L,10366L,10707L,10864L,11036L,14231L,15368L,15836L,16377L,19304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199013Inst : IEnumerable<long>
{
public static readonly long[] Value=A199013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199013.Bytes);
public long this[int i]=>Value[i];

public static A199013Inst Instance=new A199013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199014
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,9L,12L,18L,27L,36L,54L,108L,1823L,3646L,5469L,7292L,10938L,16407L,21876L,32814L,49221L,65628L,98442L,196884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199014Inst : IEnumerable<long>
{
public static readonly long[] Value=A199014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199014.Bytes);
public long this[int i]=>Value[i];

public static A199014Inst Instance=new A199014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199015
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,8L,11L,13L,13L,15L,17L,19L,20L,22L,22L,24L,28L,28L,30L,30L,31L,35L,37L,37L,39L,41L,41L,43L,45L,47L,48L,52L,52L,52L,54L,54L,58L,60L,62L,64L,64L,64L,67L,69L,69L,71L,75L,75L,77L,79L,79L,83L,83L,83L,83L,87L,90L,92L,94L,94L,96L,98L,98L,98L,100L,102L,106L,108L,108L,110L,112L,112L,115L,117L,117L,117L,121L,121L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199015Inst : IEnumerable<long>
{
public static readonly long[] Value=A199015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199015.Bytes);
public long this[int i]=>Value[i];

public static A199015Inst Instance=new A199015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199016
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,6L,10L,12L,18L,22L,30L,37L,50L,60L,78L,94L,120L,143L,179L,213L,262L,309L,376L,440L,531L,618L,737L,855L,1012L,1167L,1372L,1575L,1840L,2104L,2442L,2783L,3214L,3649L,4193L,4746L,5430L,6126L,6980L,7853L,8914L,10002L,11311L,12660L,14274L,15934L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199016Inst : IEnumerable<long>
{
public static readonly long[] Value=A199016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199016.Bytes);
public long this[int i]=>Value[i];

public static A199016Inst Instance=new A199016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199017
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,5L,5L,6L,7L,7L,8L,9L,10L,11L,12L,13L,14L,14L,16L,16L,17L,19L,20L,22L,23L,25L,26L,27L,29L,30L,31L,34L,35L,38L,40L,41L,45L,45L,48L,51L,52L,57L,60L,62L,66L,68L,71L,75L,78L,83L,86L,93L,97L,100L,107L,109L,115L,120L,124L,132L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199017Inst : IEnumerable<long>
{
public static readonly long[] Value=A199017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199017.Bytes);
public long this[int i]=>Value[i];

public static A199017Inst Instance=new A199017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199018
{
public static readonly long[] Value={ 1L,16L,181L,1996L,21961L,241576L,2657341L,29230756L,321538321L,3536921536L,38906136901L,427967505916L,4707642565081L,51784068215896L,569624750374861L,6265872254123476L,68924594795358241L,758170542748940656L,8339875970238347221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199018Inst : IEnumerable<long>
{
public static readonly long[] Value=A199018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199018.Bytes);
public long this[int i]=>Value[i];

public static A199018Inst Instance=new A199018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199019
{
public static readonly long[] Value={ 2L,32L,362L,3992L,43922L,483152L,5314682L,58461512L,643076642L,7073843072L,77812273802L,855935011832L,9415285130162L,103568136431792L,1139249500749722L,12531744508246952L,137849189590716482L,1516341085497881312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199019Inst : IEnumerable<long>
{
public static readonly long[] Value=A199019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199019.Bytes);
public long this[int i]=>Value[i];

public static A199019Inst Instance=new A199019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199020
{
public static readonly long[] Value={ 3L,43L,483L,5323L,58563L,644203L,7086243L,77948683L,857435523L,9431790763L,103749698403L,1141246682443L,12553713506883L,138090848575723L,1518999334332963L,16708992677662603L,183798919454288643L,2021788113997175083L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199020Inst : IEnumerable<long>
{
public static readonly long[] Value=A199020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199020.Bytes);
public long this[int i]=>Value[i];

public static A199020Inst Instance=new A199020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199021
{
public static readonly long[] Value={ 2L,27L,302L,3327L,36602L,402627L,4428902L,48717927L,535897202L,5894869227L,64843561502L,713279176527L,7846070941802L,86306780359827L,949374583958102L,10443120423539127L,114874324658930402L,1263617571248234427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199021Inst : IEnumerable<long>
{
public static readonly long[] Value=A199021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199021.Bytes);
public long this[int i]=>Value[i];

public static A199021Inst Instance=new A199021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199022
{
public static readonly long[] Value={ 4L,54L,604L,6654L,73204L,805254L,8857804L,97435854L,1071794404L,11789738454L,129687123004L,1426558353054L,15692141883604L,172613560719654L,1898749167916204L,20886240847078254L,229748649317860804L,2527235142496468854L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199022Inst : IEnumerable<long>
{
public static readonly long[] Value=A199022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199022.Bytes);
public long this[int i]=>Value[i];

public static A199022Inst Instance=new A199022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199023
{
public static readonly long[] Value={ 1L,13L,145L,1597L,17569L,193261L,2125873L,23384605L,257230657L,2829537229L,31124909521L,342374004733L,3766114052065L,41427254572717L,455699800299889L,5012697803298781L,55139675836286593L,606536434199152525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199023Inst : IEnumerable<long>
{
public static readonly long[] Value=A199023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199023.Bytes);
public long this[int i]=>Value[i];

public static A199023Inst Instance=new A199023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199024
{
public static readonly long[] Value={ 5L,65L,725L,7985L,87845L,966305L,10629365L,116923025L,1286153285L,14147686145L,155624547605L,1711870023665L,18830570260325L,207136272863585L,2278499001499445L,25063489016493905L,275698379181432965L,3032682170995762625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199024Inst : IEnumerable<long>
{
public static readonly long[] Value=A199024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199024.Bytes);
public long this[int i]=>Value[i];

public static A199024Inst Instance=new A199024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199025
{
public static readonly long[] Value={ 3L,38L,423L,4658L,51243L,563678L,6200463L,68205098L,750256083L,8252816918L,90780986103L,998590847138L,10984499318523L,120829492503758L,1329124417541343L,14620368592954778L,160824054522502563L,1769064599747528198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199025Inst : IEnumerable<long>
{
public static readonly long[] Value=A199025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199025.Bytes);
public long this[int i]=>Value[i];

public static A199025Inst Instance=new A199025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199026
{
public static readonly long[] Value={ 6L,76L,846L,9316L,102486L,1127356L,12400926L,136410196L,1500512166L,16505633836L,181561972206L,1997181694276L,21968998637046L,241658985007516L,2658248835082686L,29240737185909556L,321648109045005126L,3538129199495056396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199026Inst : IEnumerable<long>
{
public static readonly long[] Value=A199026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199026.Bytes);
public long this[int i]=>Value[i];

public static A199026Inst Instance=new A199026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199027
{
public static readonly long[] Value={ 7L,87L,967L,10647L,117127L,1288407L,14172487L,155897367L,1714871047L,18863581527L,207499396807L,2282493364887L,25107427013767L,276181697151447L,3037998668665927L,33417985355325207L,367597838908577287L,4043576227994350167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199027Inst : IEnumerable<long>
{
public static readonly long[] Value=A199027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199027.Bytes);
public long this[int i]=>Value[i];

public static A199027Inst Instance=new A199027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199028
{
public static readonly long[] Value={ 4L,49L,544L,5989L,65884L,724729L,7972024L,87692269L,964614964L,10610764609L,116718410704L,1283902517749L,14122927695244L,155352204647689L,1708874251124584L,18797616762370429L,206773784386074724L,2274511628246821969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199028Inst : IEnumerable<long>
{
public static readonly long[] Value=A199028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199028.Bytes);
public long this[int i]=>Value[i];

public static A199028Inst Instance=new A199028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199029
{
public static readonly long[] Value={ 8L,98L,1088L,11978L,131768L,1449458L,15944048L,175384538L,1929229928L,21221529218L,233436821408L,2567805035498L,28245855390488L,310704409295378L,3417748502249168L,37595233524740858L,413547568772149448L,4549023256493643938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199029Inst : IEnumerable<long>
{
public static readonly long[] Value=A199029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199029.Bytes);
public long this[int i]=>Value[i];

public static A199029Inst Instance=new A199029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199030
{
public static readonly long[] Value={ 9L,109L,1209L,13309L,146409L,1610509L,17715609L,194871709L,2143588809L,23579476909L,259374246009L,2853116706109L,31384283767209L,345227121439309L,3797498335832409L,41772481694156509L,459497298635721609L,5054470284992937709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199030Inst : IEnumerable<long>
{
public static readonly long[] Value=A199030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199030.Bytes);
public long this[int i]=>Value[i];

public static A199030Inst Instance=new A199030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199031
{
public static readonly long[] Value={ 1L,23L,287L,3455L,41471L,497663L,5971967L,71663615L,859963391L,10319560703L,123834728447L,1486016741375L,17832200896511L,213986410758143L,2567836929097727L,30814043149172735L,369768517790072831L,4437222213480873983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199031Inst : IEnumerable<long>
{
public static readonly long[] Value=A199031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199031.Bytes);
public long this[int i]=>Value[i];

public static A199031Inst Instance=new A199031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199032
{
public static readonly long[] Value={ 2L,35L,431L,5183L,62207L,746495L,8957951L,107495423L,1289945087L,15479341055L,185752092671L,2229025112063L,26748301344767L,320979616137215L,3851755393646591L,46221064723759103L,554652776685109247L,6655833320221310975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199032Inst : IEnumerable<long>
{
public static readonly long[] Value=A199032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199032.Bytes);
public long this[int i]=>Value[i];

public static A199032Inst Instance=new A199032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199033
{
public static readonly long[] Value={ 1L,4L,22L,128L,771L,4744L,29618L,186880L,1188679L,7608764L,48953224L,316283264L,2050706932L,13336273528L,86953633242L,568221290496L,3720529001823L,24403423540348L,160314652983158L,1054635453261568L,6946703172803003L,45809043607167328L,302395650703501688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199033Inst : IEnumerable<long>
{
public static readonly long[] Value=A199033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199033.Bytes);
public long this[int i]=>Value[i];

public static A199033Inst Instance=new A199033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199034
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,3L,3L,1L,6L,15L,15L,75L,126L,71L,397L,786L,550L,3043L,5730L,3660L,20610L,39843L,26407L,149468L,288070L,188649L,1074387L,2082753L,1372608L,7852896L,15252825L,10045040L,57692788L,112347998L,74107005L,427035846L,833163180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199034Inst : IEnumerable<long>
{
public static readonly long[] Value=A199034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199034.Bytes);
public long this[int i]=>Value[i];

public static A199034Inst Instance=new A199034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199035
{
public static readonly long[] Value={ 0L,0L,3L,12L,29L,143L,877L,3516L,8987L,81112L,342188L,667215L,7467547L,32878290L,56393050L,697859958L,3145355560L,5126416780L,66563431854L,303713138234L,484994209944L,6455395706354L,29679649731124L,47028010467376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199035Inst : IEnumerable<long>
{
public static readonly long[] Value=A199035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199035.Bytes);
public long this[int i]=>Value[i];

public static A199035Inst Instance=new A199035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199036
{
public static readonly long[] Value={ 0L,3L,10L,127L,631L,8090L,59384L,617083L,5480374L,54176239L,509231783L,4993452921L,48215558259L,473249770477L,4631610073092L,45669141577218L,450616426169273L,4464671668507302L,44308975264570192L,440935402785467477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199036Inst : IEnumerable<long>
{
public static readonly long[] Value=A199036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199036.Bytes);
public long this[int i]=>Value[i];

public static A199036Inst Instance=new A199036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199037
{
public static readonly BigInteger[] Value={ 0L,12L,127L,3916L,86544L,674064L,35902575L,750625102L,5442674205L,326415070048L,6891880687104L,50123775833686L,3107281380843015L,66459989877060602L,486615013344919101L,BigInteger.Parse("30688654869734908624"),BigInteger.Parse("662760542913624114980") };
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
public class A199037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199037Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199037.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199037.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199037Inst Instance=new A199037Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199038
{
public static readonly long[] Value={ 0L,29L,631L,86544L,3806692L,59029339L,7354780137L,330637303049L,5165845286283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199038Inst : IEnumerable<long>
{
public static readonly long[] Value=A199038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199038.Bytes);
public long this[int i]=>Value[i];

public static A199038Inst Instance=new A199038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199039
{
public static readonly long[] Value={ 1L,143L,8090L,674064L,59029339L,5590093696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199039Inst : IEnumerable<long>
{
public static readonly long[] Value=A199039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199039.Bytes);
public long this[int i]=>Value[i];

public static A199039Inst Instance=new A199039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199040
{
public static readonly long[] Value={ 3L,877L,59384L,35902575L,7354780137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199040Inst : IEnumerable<long>
{
public static readonly long[] Value=A199040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199040.Bytes);
public long this[int i]=>Value[i];

public static A199040Inst Instance=new A199040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199041
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,3L,3L,0L,0L,12L,10L,12L,0L,1L,29L,127L,127L,29L,1L,3L,143L,631L,3916L,631L,143L,3L,3L,877L,8090L,86544L,86544L,8090L,877L,3L,1L,3516L,59384L,674064L,3806692L,674064L,59384L,3516L,1L,6L,8987L,617083L,35902575L,59029339L,59029339L,35902575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199041Inst : IEnumerable<long>
{
public static readonly long[] Value=A199041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199041.Bytes);
public long this[int i]=>Value[i];

public static A199041Inst Instance=new A199041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199042
{
public static readonly BigInteger[] Value={ 1L,1L,-1L,-1L,17L,-95L,175L,3775L,-63775L,533825L,108575L,-98151425L,2037293425L,-20945772575L,-111991234225L,10648024541375L,-261756393325375L,3003396413226625L,43283396332525375L,-3352997476533082625L,BigInteger.Parse("94455063540276700625"),BigInteger.Parse("-1135469395905648529375") };
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
public class A199042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199042Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199042.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199042.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199042Inst Instance=new A199042Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199043
{
public static readonly BigInteger[] Value={ 1L,1L,0L,-2L,8L,-16L,-112L,1968L,-16896L,55680L,1243392L,-32546304L,427932672L,-1824506880L,-79446663168L,2767039739904L,-48592416374784L,243186999164928L,17201692341633024L,-744898387504988160L,16285431143888584704UL,BigInteger.Parse("-90779807638034841600") };
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
public class A199043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199043Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199043.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199043.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199043Inst Instance=new A199043Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199044
{
public static readonly BigInteger[] Value={ 1L,0L,6L,0L,74L,0L,1140L,0L,19562L,0L,357756L,0L,6824684L,0L,134166696L,0L,2697855082L,0L,55213424556L,0L,1146078241284L,0L,24067465856088L,0L,510351502965548L,0L,10911807871502232L,0L,234970037988773560L,0L,5091149074269149520L,0L,BigInteger.Parse("110912377099411850090"),0L };
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
public class A199044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199044Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199044.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199044.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199044Inst Instance=new A199044Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199045
{
public static readonly ulong[] Value={ 2L,12L,112L,1120L,10112L,101120L,1002112L,10010112L,100101120L,1001011200L,10002010112L,100012122112L,1000121221120L,10001212211200L,100002002010112L,1000000210010112L,10000002100101120L,100000021001011200L,1000000210010112000L,10000000201221210112UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199045Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A199045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199045.Bytes);
public ulong this[int i]=>Value[i];

public static A199045Inst Instance=new A199045Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199046
{
public static readonly long[] Value={ 1L,7L,2L,8L,4L,6L,6L,3L,1L,8L,9L,9L,7L,1L,7L,7L,2L,2L,2L,3L,5L,6L,5L,9L,1L,8L,4L,8L,2L,7L,4L,7L,9L,4L,6L,2L,7L,5L,7L,2L,0L,3L,2L,2L,2L,5L,2L,9L,5L,0L,7L,7L,4L,5L,0L,7L,4L,7L,2L,1L,4L,4L,5L,6L,9L,2L,2L,9L,8L,4L,6L,3L,1L,5L,1L,3L,8L,8L,6L,4L,5L,1L,0L,6L,7L,8L,5L,5L,9L,1L,2L,1L,7L,9L,0L,7L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199046Inst : IEnumerable<long>
{
public static readonly long[] Value=A199046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199046.Bytes);
public long this[int i]=>Value[i];

public static A199046Inst Instance=new A199046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199047
{
public static readonly long[] Value={ 1L,0L,6L,1L,5L,4L,9L,7L,7L,4L,6L,3L,1L,3L,8L,3L,8L,2L,5L,6L,0L,2L,0L,3L,3L,4L,0L,3L,5L,1L,9L,8L,9L,9L,3L,4L,2L,0L,5L,8L,8L,7L,4L,1L,7L,8L,3L,8L,9L,2L,4L,1L,4L,8L,6L,0L,8L,4L,9L,8L,8L,9L,3L,5L,8L,0L,9L,3L,2L,5L,3L,6L,5L,8L,0L,7L,8L,0L,1L,3L,6L,8L,1L,6L,0L,5L,0L,3L,5L,5L,2L,0L,1L,0L,5L,5L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199047Inst : IEnumerable<long>
{
public static readonly long[] Value=A199047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199047.Bytes);
public long this[int i]=>Value[i];

public static A199047Inst Instance=new A199047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199048
{
public static readonly long[] Value={ 1L,9L,7L,9L,3L,2L,0L,1L,4L,6L,5L,5L,6L,2L,1L,1L,4L,6L,0L,3L,3L,5L,7L,4L,9L,7L,1L,3L,9L,8L,8L,4L,7L,4L,4L,5L,2L,1L,1L,6L,6L,4L,2L,1L,5L,0L,5L,9L,4L,1L,8L,4L,6L,6L,7L,9L,1L,4L,0L,9L,7L,5L,5L,5L,8L,1L,8L,1L,1L,9L,5L,8L,4L,1L,9L,3L,2L,6L,5L,0L,0L,7L,5L,5L,1L,5L,8L,8L,0L,8L,8L,6L,6L,3L,9L,3L,3L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199048Inst : IEnumerable<long>
{
public static readonly long[] Value=A199048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199048.Bytes);
public long this[int i]=>Value[i];

public static A199048Inst Instance=new A199048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199049
{
public static readonly long[] Value={ 1L,4L,1L,8L,3L,1L,0L,0L,9L,1L,6L,2L,2L,5L,2L,5L,0L,4L,5L,6L,9L,1L,9L,4L,9L,6L,0L,0L,8L,0L,3L,7L,4L,8L,2L,3L,9L,8L,7L,4L,7L,3L,3L,8L,7L,1L,5L,0L,3L,0L,4L,5L,6L,6L,1L,4L,3L,6L,9L,8L,3L,6L,8L,8L,5L,4L,8L,6L,4L,1L,9L,7L,7L,4L,5L,6L,5L,4L,9L,0L,8L,3L,2L,4L,4L,1L,8L,4L,8L,3L,8L,6L,0L,2L,5L,4L,1L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199049Inst : IEnumerable<long>
{
public static readonly long[] Value=A199049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199049.Bytes);
public long this[int i]=>Value[i];

public static A199049Inst Instance=new A199049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199050
{
public static readonly long[] Value={ 2L,1L,5L,9L,4L,7L,8L,2L,9L,6L,9L,7L,4L,1L,1L,6L,0L,1L,8L,2L,6L,8L,9L,2L,3L,8L,7L,8L,5L,2L,4L,6L,8L,9L,0L,0L,9L,2L,9L,0L,4L,7L,3L,6L,2L,4L,8L,0L,8L,4L,3L,6L,6L,7L,3L,1L,0L,5L,5L,8L,9L,2L,8L,8L,0L,1L,0L,2L,8L,9L,1L,3L,3L,4L,9L,1L,8L,2L,7L,5L,7L,1L,4L,6L,3L,4L,1L,3L,1L,8L,3L,7L,0L,2L,2L,1L,5L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199050Inst : IEnumerable<long>
{
public static readonly long[] Value=A199050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199050.Bytes);
public long this[int i]=>Value[i];

public static A199050Inst Instance=new A199050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199051
{
public static readonly long[] Value={ 1L,1L,0L,2L,4L,4L,0L,9L,9L,2L,7L,8L,2L,4L,7L,4L,5L,0L,2L,9L,0L,0L,5L,1L,2L,3L,2L,6L,9L,5L,8L,5L,7L,9L,1L,1L,5L,6L,4L,4L,2L,2L,5L,6L,9L,1L,4L,6L,4L,3L,4L,4L,8L,9L,0L,7L,6L,6L,8L,5L,2L,3L,7L,9L,8L,9L,4L,1L,3L,6L,3L,8L,1L,2L,7L,7L,3L,5L,7L,8L,6L,7L,0L,0L,8L,0L,5L,9L,3L,6L,5L,3L,8L,3L,1L,6L,7L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199051Inst : IEnumerable<long>
{
public static readonly long[] Value=A199051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199051.Bytes);
public long this[int i]=>Value[i];

public static A199051Inst Instance=new A199051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199052
{
public static readonly long[] Value={ 1L,3L,9L,8L,4L,0L,3L,0L,6L,8L,9L,5L,6L,7L,0L,4L,2L,8L,1L,9L,1L,3L,6L,2L,1L,0L,7L,0L,1L,0L,0L,3L,3L,0L,8L,6L,9L,9L,2L,9L,2L,5L,4L,1L,2L,5L,1L,2L,3L,2L,2L,0L,9L,0L,4L,8L,2L,2L,7L,3L,3L,7L,6L,6L,8L,4L,7L,7L,1L,7L,9L,8L,3L,3L,7L,9L,6L,0L,2L,2L,4L,7L,0L,0L,9L,9L,0L,4L,2L,9L,7L,6L,8L,1L,8L,5L,7L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199052Inst : IEnumerable<long>
{
public static readonly long[] Value=A199052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199052.Bytes);
public long this[int i]=>Value[i];

public static A199052Inst Instance=new A199052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199053
{
public static readonly long[] Value={ 3L,9L,5L,8L,0L,9L,2L,3L,4L,4L,6L,9L,1L,3L,7L,8L,3L,7L,5L,8L,2L,5L,4L,7L,9L,9L,4L,3L,4L,0L,5L,2L,1L,8L,9L,2L,5L,2L,3L,5L,7L,9L,4L,8L,7L,5L,1L,2L,6L,5L,5L,7L,7L,0L,9L,3L,7L,9L,1L,5L,1L,6L,5L,3L,6L,3L,6L,5L,2L,8L,5L,8L,6L,7L,4L,8L,6L,5L,4L,0L,4L,5L,7L,4L,0L,3L,0L,5L,1L,1L,4L,2L,7L,0L,4L,0L,3L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199053Inst : IEnumerable<long>
{
public static readonly long[] Value=A199053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199053.Bytes);
public long this[int i]=>Value[i];

public static A199053Inst Instance=new A199053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199054
{
public static readonly long[] Value={ 1L,9L,4L,6L,8L,7L,7L,7L,4L,4L,6L,7L,0L,6L,8L,2L,9L,0L,8L,3L,3L,5L,4L,7L,3L,5L,4L,6L,6L,9L,7L,7L,2L,3L,8L,6L,1L,8L,8L,1L,5L,9L,2L,3L,4L,1L,2L,9L,4L,2L,8L,9L,9L,9L,1L,3L,7L,3L,1L,9L,5L,9L,9L,7L,7L,7L,1L,2L,3L,9L,0L,9L,2L,4L,6L,1L,9L,9L,5L,4L,9L,1L,6L,9L,6L,4L,6L,8L,6L,8L,3L,4L,1L,6L,6L,2L,2L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199054Inst : IEnumerable<long>
{
public static readonly long[] Value=A199054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199054.Bytes);
public long this[int i]=>Value[i];

public static A199054Inst Instance=new A199054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199055
{
public static readonly long[] Value={ 3L,0L,6L,7L,5L,5L,3L,5L,4L,1L,3L,7L,7L,5L,3L,0L,0L,7L,0L,1L,1L,6L,5L,1L,6L,3L,4L,7L,3L,3L,3L,6L,0L,1L,4L,7L,8L,3L,9L,0L,9L,6L,1L,9L,0L,2L,7L,0L,1L,9L,8L,4L,5L,7L,0L,9L,0L,6L,8L,2L,0L,2L,0L,1L,6L,0L,2L,4L,1L,5L,1L,1L,8L,4L,1L,3L,1L,8L,1L,3L,2L,9L,5L,8L,2L,5L,5L,6L,2L,4L,2L,4L,6L,7L,4L,5L,1L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199055Inst : IEnumerable<long>
{
public static readonly long[] Value=A199055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199055.Bytes);
public long this[int i]=>Value[i];

public static A199055Inst Instance=new A199055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199056
{
public static readonly long[] Value={ 2L,1L,3L,1L,0L,4L,7L,7L,6L,4L,0L,5L,6L,3L,5L,5L,7L,1L,0L,0L,0L,1L,1L,3L,3L,6L,9L,5L,3L,5L,8L,5L,5L,3L,8L,8L,7L,1L,6L,9L,6L,5L,8L,2L,1L,6L,7L,7L,7L,6L,2L,1L,4L,8L,1L,1L,0L,6L,6L,9L,0L,2L,9L,9L,1L,0L,1L,9L,6L,2L,6L,3L,2L,9L,5L,7L,4L,2L,0L,2L,9L,4L,8L,2L,7L,1L,0L,7L,2L,2L,7L,9L,3L,3L,0L,4L,9L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199056Inst : IEnumerable<long>
{
public static readonly long[] Value=A199056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199056.Bytes);
public long this[int i]=>Value[i];

public static A199056Inst Instance=new A199056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199057
{
public static readonly long[] Value={ 5L,8L,5L,3L,2L,0L,5L,6L,4L,3L,4L,1L,9L,9L,3L,0L,7L,6L,5L,4L,2L,6L,7L,4L,6L,8L,6L,9L,6L,7L,3L,7L,7L,2L,8L,3L,6L,0L,9L,1L,9L,4L,4L,1L,8L,5L,7L,0L,6L,8L,3L,8L,9L,5L,9L,1L,6L,3L,9L,4L,2L,7L,5L,0L,4L,7L,2L,3L,3L,0L,4L,0L,8L,9L,3L,1L,4L,1L,8L,2L,1L,3L,1L,2L,1L,2L,5L,7L,5L,7L,4L,1L,8L,3L,9L,7L,6L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199057Inst : IEnumerable<long>
{
public static readonly long[] Value=A199057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199057.Bytes);
public long this[int i]=>Value[i];

public static A199057Inst Instance=new A199057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199058
{
public static readonly long[] Value={ 2L,2L,9L,1L,9L,6L,5L,0L,4L,1L,2L,6L,7L,4L,2L,8L,6L,4L,9L,0L,9L,5L,1L,3L,3L,1L,1L,8L,3L,9L,4L,4L,4L,3L,3L,8L,9L,5L,3L,7L,0L,8L,4L,4L,8L,8L,9L,5L,3L,1L,5L,0L,9L,7L,9L,1L,1L,5L,2L,1L,5L,3L,3L,5L,1L,5L,4L,7L,8L,6L,1L,2L,5L,9L,9L,2L,9L,0L,7L,7L,1L,8L,0L,8L,4L,2L,3L,3L,8L,3L,5L,8L,8L,9L,2L,2L,4L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199058Inst : IEnumerable<long>
{
public static readonly long[] Value=A199058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199058.Bytes);
public long this[int i]=>Value[i];

public static A199058Inst Instance=new A199058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199059
{
public static readonly long[] Value={ 8L,5L,6L,4L,3L,0L,5L,5L,5L,9L,0L,7L,5L,6L,1L,1L,7L,9L,4L,6L,3L,6L,3L,2L,5L,3L,8L,7L,5L,2L,4L,8L,2L,9L,7L,6L,0L,9L,8L,9L,3L,9L,8L,2L,3L,9L,7L,2L,4L,3L,4L,5L,1L,5L,7L,3L,3L,8L,4L,1L,3L,9L,9L,3L,0L,5L,3L,9L,4L,8L,8L,2L,7L,0L,6L,6L,5L,1L,9L,3L,8L,7L,2L,9L,7L,0L,9L,8L,5L,0L,5L,1L,4L,3L,8L,2L,6L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199059Inst : IEnumerable<long>
{
public static readonly long[] Value=A199059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199059.Bytes);
public long this[int i]=>Value[i];

public static A199059Inst Instance=new A199059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199060
{
public static readonly long[] Value={ 7L,4L,8L,4L,4L,2L,4L,4L,7L,0L,1L,5L,8L,1L,1L,1L,5L,4L,6L,4L,3L,5L,9L,6L,4L,6L,5L,0L,1L,0L,4L,0L,6L,2L,7L,4L,4L,1L,5L,8L,5L,8L,8L,0L,9L,8L,3L,8L,9L,2L,3L,8L,8L,0L,8L,4L,0L,2L,0L,7L,3L,0L,4L,5L,2L,3L,4L,2L,2L,2L,8L,0L,1L,9L,1L,4L,8L,7L,9L,1L,9L,6L,0L,5L,7L,2L,5L,9L,8L,1L,3L,8L,6L,1L,8L,1L,5L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199060Inst : IEnumerable<long>
{
public static readonly long[] Value=A199060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199060.Bytes);
public long this[int i]=>Value[i];

public static A199060Inst Instance=new A199060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199061
{
public static readonly long[] Value={ 9L,5L,2L,6L,0L,9L,7L,8L,3L,7L,1L,1L,3L,0L,6L,7L,1L,3L,7L,4L,7L,3L,4L,8L,0L,7L,3L,7L,9L,2L,3L,6L,0L,7L,0L,5L,8L,6L,4L,4L,5L,2L,8L,6L,2L,8L,1L,4L,1L,4L,5L,1L,1L,1L,7L,3L,6L,0L,8L,6L,8L,2L,8L,4L,8L,5L,0L,5L,0L,2L,3L,7L,8L,5L,1L,3L,9L,0L,0L,6L,4L,0L,3L,1L,9L,7L,1L,4L,1L,4L,7L,4L,1L,2L,1L,7L,9L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199061Inst : IEnumerable<long>
{
public static readonly long[] Value=A199061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199061.Bytes);
public long this[int i]=>Value[i];

public static A199061Inst Instance=new A199061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199062
{
public static readonly long[] Value={ 5L,0L,7L,1L,1L,8L,9L,2L,8L,4L,1L,5L,3L,7L,3L,9L,7L,5L,3L,6L,3L,0L,7L,5L,1L,8L,2L,4L,4L,9L,8L,5L,1L,9L,9L,6L,9L,5L,7L,7L,2L,8L,9L,7L,4L,6L,6L,5L,4L,0L,7L,7L,4L,1L,8L,0L,9L,1L,8L,0L,7L,7L,6L,2L,9L,8L,6L,6L,3L,4L,1L,0L,2L,9L,2L,3L,4L,4L,4L,5L,4L,6L,6L,7L,0L,1L,4L,6L,4L,7L,7L,4L,9L,8L,5L,9L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199062Inst : IEnumerable<long>
{
public static readonly long[] Value=A199062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199062.Bytes);
public long this[int i]=>Value[i];

public static A199062Inst Instance=new A199062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199063
{
public static readonly long[] Value={ 1L,2L,1L,1L,6L,5L,1L,2L,8L,2L,4L,3L,1L,5L,7L,7L,1L,2L,2L,6L,9L,0L,9L,7L,0L,1L,0L,8L,4L,4L,1L,9L,6L,8L,6L,5L,3L,8L,7L,2L,9L,2L,3L,0L,5L,2L,8L,3L,3L,6L,0L,1L,1L,1L,9L,8L,0L,8L,8L,1L,6L,3L,1L,1L,7L,1L,6L,8L,4L,2L,3L,2L,7L,9L,2L,2L,2L,0L,9L,0L,7L,0L,2L,1L,1L,1L,7L,4L,2L,1L,0L,3L,4L,5L,0L,7L,9L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199063Inst : IEnumerable<long>
{
public static readonly long[] Value=A199063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199063.Bytes);
public long this[int i]=>Value[i];

public static A199063Inst Instance=new A199063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199064
{
public static readonly long[] Value={ 8L,0L,0L,6L,7L,8L,3L,0L,4L,5L,7L,0L,0L,9L,1L,1L,2L,1L,1L,2L,4L,1L,3L,4L,0L,6L,6L,0L,4L,5L,3L,2L,7L,5L,6L,2L,0L,5L,7L,6L,8L,7L,6L,6L,4L,6L,2L,2L,7L,2L,4L,0L,5L,6L,9L,1L,3L,6L,4L,5L,5L,1L,9L,4L,5L,3L,5L,4L,4L,3L,9L,3L,1L,7L,5L,4L,2L,0L,8L,6L,9L,8L,6L,6L,3L,1L,8L,3L,9L,2L,7L,7L,9L,0L,2L,5L,5L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199064Inst : IEnumerable<long>
{
public static readonly long[] Value=A199064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199064.Bytes);
public long this[int i]=>Value[i];

public static A199064Inst Instance=new A199064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199065
{
public static readonly long[] Value={ 1L,4L,1L,1L,9L,8L,7L,3L,1L,0L,2L,3L,2L,3L,0L,3L,2L,8L,8L,8L,7L,3L,0L,6L,3L,5L,7L,9L,6L,8L,8L,4L,5L,9L,7L,9L,1L,6L,4L,0L,2L,1L,9L,8L,7L,2L,0L,9L,4L,7L,0L,1L,2L,4L,1L,0L,8L,9L,7L,4L,7L,3L,6L,7L,3L,7L,9L,8L,3L,5L,9L,8L,2L,5L,0L,1L,8L,7L,6L,8L,2L,6L,9L,6L,3L,4L,0L,7L,9L,8L,3L,5L,1L,1L,2L,1L,2L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199065Inst : IEnumerable<long>
{
public static readonly long[] Value=A199065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199065.Bytes);
public long this[int i]=>Value[i];

public static A199065Inst Instance=new A199065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199066
{
public static readonly long[] Value={ 1L,0L,3L,4L,5L,0L,2L,6L,9L,1L,7L,7L,7L,3L,8L,2L,7L,3L,4L,5L,2L,1L,7L,6L,7L,9L,0L,0L,8L,8L,5L,1L,3L,1L,0L,5L,8L,1L,1L,0L,1L,9L,0L,5L,2L,6L,6L,5L,5L,7L,0L,4L,4L,8L,7L,4L,1L,2L,7L,1L,1L,3L,0L,7L,8L,5L,5L,0L,2L,0L,5L,6L,4L,3L,9L,9L,6L,9L,8L,5L,2L,2L,9L,6L,7L,5L,3L,0L,1L,0L,6L,4L,9L,3L,9L,0L,8L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199066Inst : IEnumerable<long>
{
public static readonly long[] Value=A199066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199066.Bytes);
public long this[int i]=>Value[i];

public static A199066Inst Instance=new A199066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199067
{
public static readonly long[] Value={ 1L,1L,9L,6L,0L,8L,2L,0L,3L,3L,2L,9L,7L,1L,3L,4L,8L,1L,9L,1L,4L,5L,6L,2L,1L,9L,5L,2L,9L,4L,1L,0L,4L,3L,2L,1L,1L,5L,9L,7L,2L,0L,4L,7L,1L,5L,9L,5L,9L,6L,8L,3L,8L,0L,5L,1L,0L,2L,3L,8L,0L,7L,4L,0L,4L,9L,8L,1L,6L,1L,1L,3L,2L,3L,3L,5L,5L,1L,9L,8L,2L,1L,9L,3L,1L,4L,3L,5L,8L,7L,7L,8L,5L,0L,2L,9L,8L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199067Inst : IEnumerable<long>
{
public static readonly long[] Value=A199067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199067.Bytes);
public long this[int i]=>Value[i];

public static A199067Inst Instance=new A199067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199068
{
public static readonly long[] Value={ 3L,7L,0L,8L,8L,7L,3L,4L,0L,1L,1L,1L,9L,9L,2L,0L,7L,0L,6L,0L,1L,4L,2L,9L,3L,4L,5L,7L,3L,4L,4L,8L,8L,9L,9L,2L,9L,4L,8L,9L,9L,8L,3L,1L,9L,9L,9L,7L,2L,7L,6L,9L,5L,6L,8L,7L,9L,0L,7L,1L,7L,0L,5L,0L,6L,9L,2L,0L,6L,6L,0L,3L,0L,4L,2L,1L,8L,8L,7L,2L,5L,9L,6L,2L,2L,3L,7L,6L,8L,2L,1L,9L,4L,9L,4L,2L,2L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199068Inst : IEnumerable<long>
{
public static readonly long[] Value=A199068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199068.Bytes);
public long this[int i]=>Value[i];

public static A199068Inst Instance=new A199068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199069
{
public static readonly long[] Value={ 1L,5L,8L,1L,1L,2L,1L,9L,7L,2L,2L,0L,7L,4L,1L,1L,9L,1L,8L,3L,1L,2L,8L,8L,3L,1L,1L,8L,0L,2L,8L,2L,2L,7L,3L,5L,8L,5L,0L,3L,1L,0L,2L,9L,7L,9L,7L,6L,8L,8L,0L,2L,5L,6L,3L,6L,4L,2L,6L,9L,0L,6L,4L,4L,0L,3L,4L,9L,9L,2L,6L,0L,8L,5L,5L,3L,0L,2L,1L,8L,2L,3L,8L,5L,5L,6L,6L,5L,7L,3L,9L,3L,9L,0L,9L,9L,8L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199069Inst : IEnumerable<long>
{
public static readonly long[] Value=A199069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199069.Bytes);
public long this[int i]=>Value[i];

public static A199069Inst Instance=new A199069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199070
{
public static readonly long[] Value={ 8L,6L,1L,0L,7L,7L,6L,7L,4L,7L,3L,9L,5L,5L,2L,9L,9L,0L,2L,4L,1L,9L,8L,2L,3L,6L,5L,6L,7L,0L,3L,7L,7L,6L,3L,1L,0L,9L,4L,3L,0L,3L,9L,3L,3L,5L,8L,1L,2L,7L,3L,9L,0L,8L,9L,2L,8L,5L,6L,4L,3L,0L,9L,6L,2L,6L,0L,8L,4L,5L,1L,8L,3L,9L,2L,1L,6L,9L,4L,9L,3L,0L,5L,8L,6L,3L,0L,8L,4L,2L,1L,8L,8L,4L,7L,9L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199070Inst : IEnumerable<long>
{
public static readonly long[] Value=A199070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199070.Bytes);
public long this[int i]=>Value[i];

public static A199070Inst Instance=new A199070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199071
{
public static readonly long[] Value={ 1L,4L,0L,7L,1L,0L,6L,6L,3L,9L,7L,6L,3L,0L,3L,9L,9L,0L,5L,9L,9L,6L,1L,6L,6L,8L,8L,9L,0L,3L,5L,9L,5L,7L,1L,2L,8L,5L,0L,8L,7L,2L,6L,3L,1L,0L,5L,4L,0L,1L,0L,4L,5L,4L,1L,3L,6L,1L,7L,6L,9L,4L,2L,3L,1L,7L,2L,2L,7L,3L,2L,3L,1L,9L,6L,9L,6L,4L,2L,7L,3L,6L,7L,4L,7L,2L,9L,1L,3L,6L,5L,2L,1L,3L,2L,7L,1L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199071Inst : IEnumerable<long>
{
public static readonly long[] Value=A199071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199071.Bytes);
public long this[int i]=>Value[i];

public static A199071Inst Instance=new A199071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199072
{
public static readonly long[] Value={ 2L,8L,3L,5L,2L,5L,5L,5L,1L,4L,4L,4L,1L,2L,2L,7L,4L,8L,6L,1L,8L,4L,5L,1L,1L,7L,3L,2L,7L,8L,6L,2L,1L,3L,5L,0L,3L,2L,2L,8L,8L,4L,9L,3L,7L,7L,7L,2L,9L,1L,6L,0L,1L,8L,2L,7L,7L,5L,5L,2L,4L,0L,5L,2L,1L,5L,1L,4L,5L,2L,6L,0L,6L,2L,4L,5L,3L,8L,6L,0L,7L,7L,8L,9L,1L,9L,4L,4L,4L,8L,2L,4L,8L,4L,6L,1L,3L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199072Inst : IEnumerable<long>
{
public static readonly long[] Value=A199072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199072.Bytes);
public long this[int i]=>Value[i];

public static A199072Inst Instance=new A199072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199073
{
public static readonly long[] Value={ 1L,5L,8L,1L,1L,1L,3L,5L,8L,4L,2L,6L,8L,0L,1L,2L,6L,2L,3L,6L,2L,3L,5L,1L,3L,3L,0L,1L,1L,3L,1L,8L,9L,6L,6L,7L,8L,7L,2L,0L,2L,3L,7L,3L,1L,0L,7L,9L,2L,1L,8L,9L,5L,8L,1L,2L,5L,2L,1L,2L,1L,0L,4L,8L,8L,9L,3L,3L,9L,5L,3L,3L,2L,1L,6L,1L,0L,1L,2L,1L,9L,4L,3L,5L,4L,0L,9L,3L,2L,0L,7L,4L,2L,5L,9L,6L,1L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199073Inst : IEnumerable<long>
{
public static readonly long[] Value=A199073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199073.Bytes);
public long this[int i]=>Value[i];

public static A199073Inst Instance=new A199073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199074
{
public static readonly long[] Value={ 5L,1L,3L,2L,7L,4L,7L,7L,7L,7L,0L,2L,5L,6L,8L,2L,3L,4L,5L,1L,7L,1L,8L,5L,0L,4L,2L,0L,2L,4L,9L,9L,0L,2L,8L,7L,6L,3L,0L,7L,4L,1L,4L,1L,1L,3L,7L,0L,7L,7L,7L,1L,8L,1L,7L,2L,5L,5L,6L,9L,9L,4L,9L,2L,2L,6L,8L,7L,0L,1L,5L,7L,8L,5L,9L,8L,2L,1L,2L,8L,2L,1L,4L,2L,9L,2L,4L,7L,4L,0L,8L,2L,0L,3L,1L,6L,7L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199074Inst : IEnumerable<long>
{
public static readonly long[] Value=A199074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199074.Bytes);
public long this[int i]=>Value[i];

public static A199074Inst Instance=new A199074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199075
{
public static readonly long[] Value={ 1L,7L,2L,6L,7L,8L,5L,3L,2L,2L,3L,7L,1L,0L,9L,3L,1L,9L,6L,9L,4L,1L,7L,1L,4L,1L,6L,8L,5L,6L,3L,4L,9L,9L,4L,6L,6L,1L,7L,1L,0L,5L,8L,0L,5L,9L,3L,1L,3L,0L,0L,9L,9L,3L,9L,4L,8L,9L,0L,9L,7L,0L,2L,8L,1L,6L,5L,7L,4L,3L,2L,2L,7L,6L,5L,3L,3L,0L,3L,2L,0L,3L,4L,8L,7L,4L,2L,3L,1L,7L,3L,3L,6L,2L,6L,1L,8L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199075Inst : IEnumerable<long>
{
public static readonly long[] Value=A199075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199075.Bytes);
public long this[int i]=>Value[i];

public static A199075Inst Instance=new A199075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199076
{
public static readonly long[] Value={ 7L,1L,7L,0L,8L,6L,3L,8L,9L,1L,8L,1L,9L,2L,1L,8L,2L,6L,6L,9L,7L,0L,0L,4L,2L,9L,5L,3L,3L,3L,3L,0L,7L,7L,1L,8L,7L,3L,8L,6L,3L,1L,8L,4L,1L,8L,2L,8L,5L,8L,2L,3L,0L,6L,4L,5L,9L,4L,3L,8L,2L,5L,1L,8L,4L,8L,5L,7L,2L,8L,6L,7L,3L,5L,4L,3L,7L,1L,4L,5L,9L,0L,1L,0L,5L,6L,5L,4L,4L,1L,6L,8L,9L,7L,6L,4L,5L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199076Inst : IEnumerable<long>
{
public static readonly long[] Value=A199076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199076.Bytes);
public long this[int i]=>Value[i];

public static A199076Inst Instance=new A199076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199077
{
public static readonly long[] Value={ 4L,3L,8L,0L,9L,5L,8L,9L,7L,4L,2L,1L,3L,4L,0L,4L,5L,2L,7L,3L,0L,7L,2L,2L,5L,9L,0L,3L,6L,5L,4L,4L,5L,6L,4L,2L,4L,0L,7L,9L,0L,3L,3L,6L,7L,7L,9L,6L,3L,6L,8L,6L,4L,0L,2L,4L,3L,6L,2L,9L,7L,8L,9L,3L,6L,7L,2L,7L,6L,1L,3L,3L,7L,2L,7L,9L,6L,1L,1L,4L,1L,4L,4L,1L,0L,4L,3L,1L,3L,0L,2L,6L,7L,1L,8L,9L,9L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199077Inst : IEnumerable<long>
{
public static readonly long[] Value=A199077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199077.Bytes);
public long this[int i]=>Value[i];

public static A199077Inst Instance=new A199077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199078
{
public static readonly long[] Value={ 9L,7L,0L,4L,1L,5L,8L,4L,1L,6L,3L,5L,5L,9L,0L,4L,4L,7L,8L,4L,3L,5L,9L,2L,6L,5L,7L,4L,3L,0L,8L,4L,4L,1L,0L,3L,4L,5L,4L,9L,4L,2L,7L,9L,9L,4L,0L,0L,0L,3L,2L,1L,3L,3L,6L,7L,2L,4L,8L,1L,7L,1L,3L,3L,1L,9L,1L,9L,8L,1L,9L,3L,6L,7L,1L,2L,3L,6L,1L,7L,1L,0L,9L,3L,6L,6L,9L,8L,9L,9L,0L,3L,2L,9L,1L,8L,3L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199078Inst : IEnumerable<long>
{
public static readonly long[] Value=A199078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199078.Bytes);
public long this[int i]=>Value[i];

public static A199078Inst Instance=new A199078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199079
{
public static readonly long[] Value={ 6L,7L,6L,7L,0L,1L,5L,9L,4L,0L,7L,3L,0L,7L,7L,8L,7L,4L,1L,9L,4L,8L,5L,5L,7L,2L,0L,3L,8L,4L,0L,1L,6L,6L,9L,7L,7L,4L,7L,6L,2L,6L,9L,0L,0L,8L,3L,6L,5L,9L,2L,0L,9L,8L,0L,7L,6L,8L,9L,7L,6L,7L,6L,7L,4L,9L,0L,6L,6L,3L,1L,1L,0L,6L,3L,0L,2L,6L,6L,3L,2L,3L,7L,1L,0L,3L,6L,9L,4L,7L,7L,3L,5L,9L,3L,2L,9L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199079Inst : IEnumerable<long>
{
public static readonly long[] Value=A199079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199079.Bytes);
public long this[int i]=>Value[i];

public static A199079Inst Instance=new A199079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199080
{
public static readonly long[] Value={ 1L,7L,2L,5L,1L,7L,1L,2L,0L,5L,4L,2L,8L,9L,3L,0L,1L,2L,7L,1L,3L,4L,4L,2L,4L,0L,0L,2L,0L,6L,3L,2L,3L,1L,6L,2L,3L,5L,0L,8L,1L,1L,9L,4L,2L,4L,8L,7L,6L,9L,8L,3L,8L,6L,0L,5L,5L,8L,4L,1L,7L,0L,8L,5L,7L,9L,5L,5L,2L,6L,1L,3L,8L,2L,7L,8L,3L,6L,5L,4L,5L,7L,7L,1L,1L,2L,5L,3L,1L,6L,2L,3L,6L,0L,1L,3L,6L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199080Inst : IEnumerable<long>
{
public static readonly long[] Value=A199080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199080.Bytes);
public long this[int i]=>Value[i];

public static A199080Inst Instance=new A199080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199081
{
public static readonly long[] Value={ 4L,2L,3L,0L,2L,8L,1L,8L,1L,8L,8L,5L,1L,6L,0L,4L,2L,8L,8L,5L,1L,2L,9L,3L,3L,2L,4L,7L,3L,2L,6L,0L,7L,1L,8L,9L,5L,7L,2L,6L,9L,9L,8L,1L,0L,8L,4L,9L,1L,9L,9L,6L,0L,1L,7L,7L,7L,0L,2L,2L,5L,5L,3L,1L,6L,0L,9L,3L,4L,1L,1L,9L,8L,1L,1L,0L,6L,1L,3L,3L,0L,2L,6L,5L,3L,6L,7L,5L,5L,1L,7L,6L,3L,8L,0L,5L,6L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199081Inst : IEnumerable<long>
{
public static readonly long[] Value=A199081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199081.Bytes);
public long this[int i]=>Value[i];

public static A199081Inst Instance=new A199081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199082
{
public static readonly long[] Value={ 1L,9L,6L,1L,8L,8L,4L,2L,4L,6L,4L,1L,0L,8L,3L,4L,8L,9L,3L,4L,1L,9L,2L,8L,0L,7L,7L,9L,7L,7L,4L,8L,9L,4L,2L,6L,8L,2L,5L,7L,4L,7L,1L,2L,0L,7L,1L,2L,7L,2L,1L,8L,6L,6L,5L,5L,2L,0L,8L,9L,8L,6L,8L,6L,9L,2L,3L,2L,5L,8L,8L,5L,0L,6L,8L,5L,9L,0L,3L,7L,8L,4L,0L,1L,3L,8L,9L,0L,9L,6L,5L,8L,4L,8L,8L,1L,9L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199082Inst : IEnumerable<long>
{
public static readonly long[] Value=A199082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199082.Bytes);
public long this[int i]=>Value[i];

public static A199082Inst Instance=new A199082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199083
{
public static readonly long[] Value={ 7L,7L,4L,9L,8L,0L,8L,1L,4L,4L,2L,3L,0L,4L,3L,4L,4L,5L,9L,5L,8L,5L,9L,3L,5L,0L,2L,4L,7L,0L,4L,0L,1L,9L,1L,4L,6L,7L,6L,9L,3L,8L,6L,6L,1L,8L,5L,6L,1L,6L,3L,3L,1L,0L,6L,1L,5L,5L,2L,5L,6L,6L,3L,6L,2L,3L,7L,4L,2L,3L,1L,3L,5L,3L,1L,4L,1L,1L,7L,5L,2L,0L,4L,7L,9L,4L,0L,9L,8L,0L,8L,2L,5L,1L,2L,7L,7L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199083Inst : IEnumerable<long>
{
public static readonly long[] Value=A199083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199083.Bytes);
public long this[int i]=>Value[i];

public static A199083Inst Instance=new A199083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199084
{
public static readonly long[] Value={ 1L,-1L,3L,-4L,5L,-5L,7L,-12L,9L,-9L,11L,-20L,13L,-13L,15L,-32L,17L,-21L,19L,-36L,21L,-21L,23L,-60L,25L,-25L,27L,-52L,29L,-45L,31L,-80L,33L,-33L,35L,-84L,37L,-37L,39L,-108L,41L,-65L,43L,-84L,45L,-45L,47L,-160L,49L,-65L,51L,-100L,53L,-81L,55L,-156L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199084Inst : IEnumerable<long>
{
public static readonly long[] Value=A199084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199084.Bytes);
public long this[int i]=>Value[i];

public static A199084Inst Instance=new A199084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199085
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,11L,15L,20L,26L,32L,39L,47L,55L,64L,74L,84L,95L,107L,119L,132L,146L,160L,175L,191L,207L,224L,242L,260L,279L,299L,319L,340L,362L,384L,407L,431L,455L,480L,506L,532L,559L,587L,615L,644L,674L,704L,735L,767L,799L,832L,866L,900L,935L,971L,1007L,1044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199085Inst : IEnumerable<long>
{
public static readonly long[] Value=A199085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199085.Bytes);
public long this[int i]=>Value[i];

public static A199085Inst Instance=new A199085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199086
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,2L,5L,1L,2L,2L,4L,7L,1L,2L,2L,3L,4L,11L,1L,2L,2L,3L,4L,7L,15L,1L,2L,2L,3L,3L,5L,8L,22L,1L,2L,2L,3L,3L,5L,6L,12L,30L,1L,2L,2L,3L,3L,4L,5L,9L,14L,42L,1L,2L,2L,3L,3L,4L,5L,7L,10L,21L,56L,1L,2L,2L,3L,3L,4L,4L,6L,8L,13L,24L,77L,1L,2L,2L,3L,3L,4L,4L,6L,7L,11L,17L,34L,101L,1L,2L,2L,3L,3L,4L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199086Inst : IEnumerable<long>
{
public static readonly long[] Value=A199086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199086.Bytes);
public long this[int i]=>Value[i];

public static A199086Inst Instance=new A199086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199087
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,2L,4L,1L,3L,2L,4L,5L,1L,6L,3L,2L,8L,4L,9L,5L,1L,12L,6L,3L,7L,2L,16L,8L,4L,10L,9L,5L,11L,1L,13L,12L,6L,14L,3L,7L,15L,2L,18L,16L,8L,19L,4L,10L,20L,9L,23L,5L,11L,24L,1L,13L,25L,12L,29L,6L,14L,30L,3L,17L,7L,15L,35L,2L,18L,36L,16L,21L,8L,19L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199087Inst : IEnumerable<long>
{
public static readonly long[] Value=A199087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199087.Bytes);
public long this[int i]=>Value[i];

public static A199087Inst Instance=new A199087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199088
{
public static readonly long[] Value={ 2L,2L,4L,5L,4L,6L,5L,4L,7L,5L,6L,5L,5L,8L,5L,6L,7L,5L,6L,5L,6L,9L,5L,6L,7L,6L,8L,5L,6L,7L,6L,6L,7L,6L,10L,6L,6L,7L,6L,8L,7L,6L,9L,6L,6L,7L,6L,8L,7L,6L,7L,6L,8L,7L,6L,11L,7L,6L,7L,6L,8L,7L,6L,9L,7L,8L,7L,6L,10L,7L,6L,7L,7L,8L,7L,6L,9L,7L,8L,7L,7L,8L,7L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199088Inst : IEnumerable<long>
{
public static readonly long[] Value=A199088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199088.Bytes);
public long this[int i]=>Value[i];

public static A199088Inst Instance=new A199088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199089
{
public static readonly BigInteger[] Value={ 5L,709L,127973L,26249645L,5813473253L,1354962283005L,327517079413293L,81354547180103625L,BigInteger.Parse("20640739602876893733"),BigInteger.Parse("5326171952368494472061"),BigInteger.Parse("1393506059395687309946181"),BigInteger.Parse("368808221492178082683574433") };
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
public class A199089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199089Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199089.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199089.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199089Inst Instance=new A199089Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199090
{
public static readonly BigInteger[] Value={ 5L,420L,44837L,5471810L,726413391L,101787127746L,14800090575471L,2211229549716802L,337343474770282699L,BigInteger.Parse("52327061345761775192") };
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
public class A199090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199090Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199090.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199090.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199090Inst Instance=new A199090Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199091
{
public static readonly long[] Value={ 1L,709L,24353L,5471810L,349276385L,59171718202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199091Inst : IEnumerable<long>
{
public static readonly long[] Value=A199091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199091.Bytes);
public long this[int i]=>Value[i];

public static A199091Inst Instance=new A199091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199092
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,5L,0L,5L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,420L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,709L,0L,44837L,0L,44837L,0L,709L,0L,0L,0L,24353L,0L,0L,0L,0L,24353L,0L,0L,0L,0L,0L,5471810L,0L,0L,0L,5471810L,0L,0L,0L,0L,0L,0L,0L,349276385L,0L,0L,349276385L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199092Inst : IEnumerable<long>
{
public static readonly long[] Value=A199092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199092.Bytes);
public long this[int i]=>Value[i];

public static A199092Inst Instance=new A199092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199093
{
public static readonly long[] Value={ 1L,6L,280L,732964L,5569129037L,114472439855502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199093Inst : IEnumerable<long>
{
public static readonly long[] Value=A199093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199093.Bytes);
public long this[int i]=>Value[i];

public static A199093Inst Instance=new A199093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199094
{
public static readonly long[] Value={ 1L,1L,1L,6L,15L,15L,105L,280L,280L,2100L,5775L,5775L,45045L,126126L,126126L,1009008L,2858856L,2858856L,23279256L,66512160L,66512160L,548725320L,1577585295L,1577585295L,13146544125L,37978905250L,37978905250L,319022804100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199094Inst : IEnumerable<long>
{
public static readonly long[] Value=A199094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199094.Bytes);
public long this[int i]=>Value[i];

public static A199094Inst Instance=new A199094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199095
{
public static readonly long[] Value={ 1L,6L,15L,280L,2040L,5503L,113010L,857532L,2340127L,50784920L,395160694L,1085939598L,24341903776L,192371505064L,530944513322L,12155425553076L,97080455287086L,268728663225260L,6244348288426664L,50251726336557552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199095Inst : IEnumerable<long>
{
public static readonly long[] Value=A199095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199095.Bytes);
public long this[int i]=>Value[i];

public static A199095Inst Instance=new A199095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199096
{
public static readonly BigInteger[] Value={ 1L,15L,280L,5295L,101460L,1999365L,40210161L,820951127L,16962540224L,353916457700L,7444303111792L,157654572063308L,3358267477535756L,71896125048485001L,1545960357028561441L,BigInteger.Parse("33370692254737883179") };
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
public class A199096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199096Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199096.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199096.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199096Inst Instance=new A199096Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199097
{
public static readonly BigInteger[] Value={ 6L,280L,5295L,732964L,38753124L,743464228L,115707966228L,6468027944244L,127149344295419L,20829692931992406L,1196759182608043852L,BigInteger.Parse("23839712978251419910"),BigInteger.Parse("4020627629769950572704"),BigInteger.Parse("234848943742720409725658") };
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
public class A199097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199097Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199097.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199097.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199097Inst Instance=new A199097Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199098
{
public static readonly BigInteger[] Value={ 15L,2040L,101460L,38753124L,5569129037L,287771242262L,123022787797053L,18696906414385635L,993411195529074382L,BigInteger.Parse("446003814998395266655"),BigInteger.Parse("69706902367712447882179"),BigInteger.Parse("3759620769505560043717063") };
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
public class A199098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199098Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199098.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199098.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199098Inst Instance=new A199098Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199099
{
public static readonly long[] Value={ 15L,5503L,1999365L,743464228L,287771242262L,114472439855502L,46438726281827509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199099Inst : IEnumerable<long>
{
public static readonly long[] Value=A199099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199099.Bytes);
public long this[int i]=>Value[i];

public static A199099Inst Instance=new A199099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199100
{
public static readonly long[] Value={ 105L,113010L,40210161L,115707966228L,123022787797053L,46438726281827509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199100Inst : IEnumerable<long>
{
public static readonly long[] Value=A199100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199100.Bytes);
public long this[int i]=>Value[i];

public static A199100Inst Instance=new A199100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199101
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,6L,15L,15L,6L,15L,280L,280L,280L,15L,15L,2040L,5295L,5295L,2040L,15L,105L,5503L,101460L,732964L,101460L,5503L,105L,280L,113010L,1999365L,38753124L,38753124L,1999365L,113010L,280L,280L,857532L,40210161L,743464228L,5569129037L,743464228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199101Inst : IEnumerable<long>
{
public static readonly long[] Value=A199101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199101.Bytes);
public long this[int i]=>Value[i];

public static A199101Inst Instance=new A199101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199102
{
public static readonly long[] Value={ 1L,2L,6L,20L,63L,213L,719L,2505L,8864L,31948L,116725L,432074L,1616022L,6100775L,23214144L,88949045L,342899474L,1329020016L,5175758820L,20243197030L,79480515302L,313155710230L,1237771800135L,4906616164195L,19502048947616L,77703941363599L,310305199056779L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199102Inst : IEnumerable<long>
{
public static readonly long[] Value=A199102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199102.Bytes);
public long this[int i]=>Value[i];

public static A199102Inst Instance=new A199102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199103
{
public static readonly long[] Value={ 1L,1L,3L,8L,23L,67L,202L,622L,1955L,6248L,20261L,66484L,220429L,737260L,2484734L,8429714L,28766001L,98670291L,340011308L,1176505537L,4086143638L,14239716570L,49776772808L,174492148048L,613266137776L,2160518118345L,7628244051977L,26988540797766L,95666557041459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199103Inst : IEnumerable<long>
{
public static readonly long[] Value=A199103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199103.Bytes);
public long this[int i]=>Value[i];

public static A199103Inst Instance=new A199103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199104
{
public static readonly long[] Value={ 1L,1L,3L,9L,28L,88L,284L,931L,3109L,10532L,36162L,125546L,440201L,1556519L,5544715L,19879791L,71685522L,259809731L,945913555L,3457947627L,12687782600L,46709518473L,172484216742L,638712762962L,2371241532557L,8824154454401L,32909438791706L,122984173008460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199104Inst : IEnumerable<long>
{
public static readonly long[] Value=A199104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199104.Bytes);
public long this[int i]=>Value[i];

public static A199104Inst Instance=new A199104Inst();

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