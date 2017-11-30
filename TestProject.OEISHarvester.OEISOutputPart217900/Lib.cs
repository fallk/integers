using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A256282
{
public static readonly long[] Value={ 1L,-1L,1L,0L,1L,-2L,0L,0L,1L,-4L,2L,0L,0L,-2L,0L,0L,1L,-2L,4L,0L,2L,0L,0L,0L,0L,-3L,2L,0L,0L,-2L,0L,0L,1L,0L,2L,0L,4L,-2L,0L,0L,2L,-2L,0L,0L,0L,-8L,0L,0L,0L,-1L,3L,0L,2L,-2L,0L,0L,0L,0L,2L,0L,0L,-2L,0L,0L,1L,-4L,0L,0L,2L,0L,0L,0L,4L,-2L,2L,0L,0L,0L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256282Inst : IEnumerable<long>
{
public static readonly long[] Value=A256282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256282.Bytes);
public long this[int i]=>Value[i];

public static A256282Inst Instance=new A256282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256283
{
public static readonly long[] Value={ 1L,2L,4L,3L,7L,5L,9L,11L,14L,8L,13L,6L,17L,10L,19L,12L,21L,15L,23L,25L,27L,29L,31L,33L,38L,18L,36L,43L,41L,20L,35L,45L,47L,22L,51L,16L,53L,24L,49L,26L,40L,28L,50L,30L,57L,32L,59L,34L,55L,39L,65L,61L,63L,37L,67L,44L,71L,42L,75L,69L,77L,73L,79L,46L,81L,48L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256283Inst : IEnumerable<long>
{
public static readonly long[] Value=A256283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256283.Bytes);
public long this[int i]=>Value[i];

public static A256283Inst Instance=new A256283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256284
{
public static readonly long[] Value={ 1L,3L,2L,4L,2L,6L,2L,4L,6L,8L,8L,10L,2L,6L,10L,6L,14L,6L,4L,12L,12L,10L,6L,8L,4L,2L,10L,2L,12L,18L,4L,6L,12L,12L,14L,8L,14L,16L,10L,6L,8L,10L,2L,16L,6L,14L,24L,28L,2L,4L,6L,8L,10L,6L,22L,6L,20L,8L,18L,12L,10L,26L,18L,2L,10L,14L,6L,10L,2L,22L,10L,8L,14L,20L,24L,6L,18L,4L,12L,10L,20L,30L,12L,20L,10L,6L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256284Inst : IEnumerable<long>
{
public static readonly long[] Value=A256284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256284.Bytes);
public long this[int i]=>Value[i];

public static A256284Inst Instance=new A256284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256285
{
public static readonly long[] Value={ 1L,2L,43L,3L,5L,4L,29L,7L,109L,6L,173L,8L,9L,757L,17L,11L,23L,14L,673L,10L,2221L,18L,2423L,631L,15L,47L,257L,12L,13L,313L,359L,28L,3433L,19L,727L,467L,1279L,22L,577L,20L,4241L,26L,1481L,16L,929L,21L,37L,1237L,27L,25L,59L,24L,41L,2777L,39L,1439L,5857L,331L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256285Inst : IEnumerable<long>
{
public static readonly long[] Value=A256285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256285.Bytes);
public long this[int i]=>Value[i];

public static A256285Inst Instance=new A256285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256286
{
public static readonly BigInteger[] Value={ 1L,5L,181L,20381L,4940101L,2230319165L,1692864345061L,1997649164976701L,3461226344139932101L,BigInteger.Parse("8430034728440212411325"),BigInteger.Parse("27875832970537774479832741"),BigInteger.Parse("121651171242426267003975420221"),BigInteger.Parse("684351364639262056751911086836101"),BigInteger.Parse("4865203490721997132612204548628407485") };
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
public class A256286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256286Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256286.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256286.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256286Inst Instance=new A256286Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256287
{
public static readonly long[] Value={ 0L,1L,15L,105L,436L,1367L,3539L,8033L,16475L,31275L,55748L,94425L,153192L,239691L,363446L,536375L,772909L,1090592L,1510201L,2056462L,2758123L,3648814L,4767088L,6157387L,7870067L,9962502L,12499033L,15552247L,19202869L,23541165L,28666799L,34690401L,41733315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256287Inst : IEnumerable<long>
{
public static readonly long[] Value=A256287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256287.Bytes);
public long this[int i]=>Value[i];

public static A256287Inst Instance=new A256287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256288
{
public static readonly long[] Value={ 0L,7L,210L,2205L,12208L,47845L,148638L,393617L,922600L,1970325L,3902360L,7270725L,12868128L,21811881L,35617708L,56319375L,86565808L,129780448L,190285326L,273509446L,386137220L,536375658L,734131552L,991339307L,1322171256L,1743437850L,2274824006L,2939374683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256288Inst : IEnumerable<long>
{
public static readonly long[] Value=A256288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256288.Bytes);
public long this[int i]=>Value[i];

public static A256288Inst Instance=new A256288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256289
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,0L,21L,22L,23L,24L,25L,26L,27L,28L,20L,31L,32L,33L,34L,35L,36L,37L,38L,30L,41L,42L,43L,44L,45L,46L,47L,48L,40L,51L,52L,53L,54L,55L,56L,57L,58L,50L,61L,62L,63L,64L,65L,66L,67L,68L,60L,71L,72L,73L,74L,75L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256289Inst : IEnumerable<long>
{
public static readonly long[] Value=A256289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256289.Bytes);
public long this[int i]=>Value[i];

public static A256289Inst Instance=new A256289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256290
{
public static readonly long[] Value={ 4L,5L,44L,45L,54L,55L,444L,445L,454L,455L,544L,545L,554L,555L,4444L,4445L,4454L,4455L,4544L,4545L,4554L,4555L,5444L,5445L,5454L,5455L,5544L,5545L,5554L,5555L,44444L,44445L,44454L,44455L,44544L,44545L,44554L,44555L,45444L,45445L,45454L,45455L,45544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256290Inst : IEnumerable<long>
{
public static readonly long[] Value=A256290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256290.Bytes);
public long this[int i]=>Value[i];

public static A256290Inst Instance=new A256290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256291
{
public static readonly long[] Value={ 5L,6L,55L,56L,65L,66L,555L,556L,565L,566L,655L,656L,665L,666L,5555L,5556L,5565L,5566L,5655L,5656L,5665L,5666L,6555L,6556L,6565L,6566L,6655L,6656L,6665L,6666L,55555L,55556L,55565L,55566L,55655L,55656L,55665L,55666L,56555L,56556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256291Inst : IEnumerable<long>
{
public static readonly long[] Value=A256291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256291.Bytes);
public long this[int i]=>Value[i];

public static A256291Inst Instance=new A256291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256292
{
public static readonly long[] Value={ 6L,7L,66L,67L,76L,77L,666L,667L,676L,677L,766L,767L,776L,777L,6666L,6667L,6676L,6677L,6766L,6767L,6776L,6777L,7666L,7667L,7676L,7677L,7766L,7767L,7776L,7777L,66666L,66667L,66676L,66677L,66766L,66767L,66776L,66777L,67666L,67667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256292Inst : IEnumerable<long>
{
public static readonly long[] Value=A256292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256292.Bytes);
public long this[int i]=>Value[i];

public static A256292Inst Instance=new A256292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256293
{
public static readonly long[] Value={ 1L,2L,0L,7L,8L,6L,1L,2L,0L,22L,23L,21L,25L,26L,24L,19L,20L,18L,4L,5L,3L,7L,8L,6L,1L,2L,0L,67L,68L,66L,70L,71L,69L,64L,65L,63L,76L,77L,75L,79L,80L,78L,73L,74L,72L,58L,59L,57L,61L,62L,60L,55L,56L,54L,13L,14L,12L,16L,17L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256293Inst : IEnumerable<long>
{
public static readonly long[] Value=A256293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256293.Bytes);
public long this[int i]=>Value[i];

public static A256293Inst Instance=new A256293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256294
{
public static readonly long[] Value={ 1L,2L,3L,0L,9L,10L,11L,8L,13L,14L,15L,12L,1L,2L,3L,0L,37L,38L,39L,36L,41L,42L,43L,40L,45L,46L,47L,44L,33L,34L,35L,32L,53L,54L,55L,52L,57L,58L,59L,56L,61L,62L,63L,60L,49L,50L,51L,48L,5L,6L,7L,4L,9L,10L,11L,8L,13L,14L,15L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256294Inst : IEnumerable<long>
{
public static readonly long[] Value=A256294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256294.Bytes);
public long this[int i]=>Value[i];

public static A256294Inst Instance=new A256294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256295
{
public static readonly long[] Value={ 1L,2L,3L,4L,0L,11L,12L,13L,14L,10L,16L,17L,18L,19L,15L,21L,22L,23L,24L,20L,1L,2L,3L,4L,0L,56L,57L,58L,59L,55L,61L,62L,63L,64L,60L,66L,67L,68L,69L,65L,71L,72L,73L,74L,70L,51L,52L,53L,54L,50L,81L,82L,83L,84L,80L,86L,87L,88L,89L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256295Inst : IEnumerable<long>
{
public static readonly long[] Value=A256295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256295.Bytes);
public long this[int i]=>Value[i];

public static A256295Inst Instance=new A256295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256296
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,0L,13L,14L,15L,16L,17L,12L,19L,20L,21L,22L,23L,18L,25L,26L,27L,28L,29L,24L,31L,32L,33L,34L,35L,30L,1L,2L,3L,4L,5L,0L,79L,80L,81L,82L,83L,78L,85L,86L,87L,88L,89L,84L,91L,92L,93L,94L,95L,90L,97L,98L,99L,100L,101L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256296Inst : IEnumerable<long>
{
public static readonly long[] Value=A256296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256296.Bytes);
public long this[int i]=>Value[i];

public static A256296Inst Instance=new A256296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256297
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,0L,15L,16L,17L,18L,19L,20L,14L,22L,23L,24L,25L,26L,27L,21L,29L,30L,31L,32L,33L,34L,28L,36L,37L,38L,39L,40L,41L,35L,43L,44L,45L,46L,47L,48L,42L,1L,2L,3L,4L,5L,6L,0L,106L,107L,108L,109L,110L,111L,105L,113L,114L,115L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256297Inst : IEnumerable<long>
{
public static readonly long[] Value=A256297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256297.Bytes);
public long this[int i]=>Value[i];

public static A256297Inst Instance=new A256297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256298
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,0L,17L,18L,19L,20L,21L,22L,23L,16L,25L,26L,27L,28L,29L,30L,31L,24L,33L,34L,35L,36L,37L,38L,39L,32L,41L,42L,43L,44L,45L,46L,47L,40L,49L,50L,51L,52L,53L,54L,55L,48L,57L,58L,59L,60L,61L,62L,63L,56L,1L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256298Inst : IEnumerable<long>
{
public static readonly long[] Value=A256298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256298.Bytes);
public long this[int i]=>Value[i];

public static A256298Inst Instance=new A256298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256299
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,0L,19L,20L,21L,22L,23L,24L,25L,26L,18L,28L,29L,30L,31L,32L,33L,34L,35L,27L,37L,38L,39L,40L,41L,42L,43L,44L,36L,46L,47L,48L,49L,50L,51L,52L,53L,45L,55L,56L,57L,58L,59L,60L,61L,62L,54L,64L,65L,66L,67L,68L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256299Inst : IEnumerable<long>
{
public static readonly long[] Value=A256299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256299.Bytes);
public long this[int i]=>Value[i];

public static A256299Inst Instance=new A256299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256300
{
public static readonly long[] Value={ 2L,5L,5L,7L,7L,131L,1087L,1087L,1087L,3599111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256300Inst : IEnumerable<long>
{
public static readonly long[] Value=A256300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256300.Bytes);
public long this[int i]=>Value[i];

public static A256300Inst Instance=new A256300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256301
{
public static readonly long[] Value={ 2L,3L,5L,5L,17L,107L,107L,107L,107L,82954517L,82954517L,21113313707L,79017245897L,79017245897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256301Inst : IEnumerable<long>
{
public static readonly long[] Value=A256301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256301.Bytes);
public long this[int i]=>Value[i];

public static A256301Inst Instance=new A256301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256302
{
public static readonly long[] Value={ 2L,5L,5L,5L,11L,11L,11L,11L,11L,11L,23L,23L,23L,23L,23L,23L,23L,23L,23L,23L,23L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256302Inst : IEnumerable<long>
{
public static readonly long[] Value=A256302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256302.Bytes);
public long this[int i]=>Value[i];

public static A256302Inst Instance=new A256302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256303
{
public static readonly long[] Value={ 1L,2L,0L,21L,22L,20L,1L,2L,0L,211L,212L,210L,221L,222L,220L,201L,202L,200L,11L,12L,10L,21L,22L,20L,1L,2L,0L,2111L,2112L,2110L,2121L,2122L,2120L,2101L,2102L,2100L,2211L,2212L,2210L,2221L,2222L,2220L,2201L,2202L,2200L,2011L,2012L,2010L,2021L,2022L,2020L,2001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256303Inst : IEnumerable<long>
{
public static readonly long[] Value=A256303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256303.Bytes);
public long this[int i]=>Value[i];

public static A256303Inst Instance=new A256303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256304
{
public static readonly long[] Value={ 1L,2L,3L,0L,21L,22L,23L,20L,31L,32L,33L,30L,1L,2L,3L,0L,211L,212L,213L,210L,221L,222L,223L,220L,231L,232L,233L,230L,201L,202L,203L,200L,311L,312L,313L,310L,321L,322L,323L,320L,331L,332L,333L,330L,301L,302L,303L,300L,11L,12L,13L,10L,21L,22L,23L,20L,31L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256304Inst : IEnumerable<long>
{
public static readonly long[] Value=A256304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256304.Bytes);
public long this[int i]=>Value[i];

public static A256304Inst Instance=new A256304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256305
{
public static readonly long[] Value={ 1L,2L,3L,4L,0L,21L,22L,23L,24L,20L,31L,32L,33L,34L,30L,41L,42L,43L,44L,40L,1L,2L,3L,4L,0L,211L,212L,213L,214L,210L,221L,222L,223L,224L,220L,231L,232L,233L,234L,230L,241L,242L,243L,244L,240L,201L,202L,203L,204L,200L,311L,312L,313L,314L,310L,321L,322L,323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256305Inst : IEnumerable<long>
{
public static readonly long[] Value=A256305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256305.Bytes);
public long this[int i]=>Value[i];

public static A256305Inst Instance=new A256305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256306
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,0L,21L,22L,23L,24L,25L,20L,31L,32L,33L,34L,35L,30L,41L,42L,43L,44L,45L,40L,51L,52L,53L,54L,55L,50L,1L,2L,3L,4L,5L,0L,211L,212L,213L,214L,215L,210L,221L,222L,223L,224L,225L,220L,231L,232L,233L,234L,235L,230L,241L,242L,243L,244L,245L,240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256306Inst : IEnumerable<long>
{
public static readonly long[] Value=A256306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256306.Bytes);
public long this[int i]=>Value[i];

public static A256306Inst Instance=new A256306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256307
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,0L,21L,22L,23L,24L,25L,26L,20L,31L,32L,33L,34L,35L,36L,30L,41L,42L,43L,44L,45L,46L,40L,51L,52L,53L,54L,55L,56L,50L,61L,62L,63L,64L,65L,66L,60L,1L,2L,3L,4L,5L,6L,0L,211L,212L,213L,214L,215L,216L,210L,221L,222L,223L,224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256307Inst : IEnumerable<long>
{
public static readonly long[] Value=A256307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256307.Bytes);
public long this[int i]=>Value[i];

public static A256307Inst Instance=new A256307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256308
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,0L,21L,22L,23L,24L,25L,26L,27L,20L,31L,32L,33L,34L,35L,36L,37L,30L,41L,42L,43L,44L,45L,46L,47L,40L,51L,52L,53L,54L,55L,56L,57L,50L,61L,62L,63L,64L,65L,66L,67L,60L,71L,72L,73L,74L,75L,76L,77L,70L,1L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256308Inst : IEnumerable<long>
{
public static readonly long[] Value=A256308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256308.Bytes);
public long this[int i]=>Value[i];

public static A256308Inst Instance=new A256308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256309
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,7L,13L,23L,37L,57L,84L,119L,164L,221L,291L,377L,480L,603L,748L,918L,1115L,1342L,1602L,1898L,2233L,2611L,3034L,3507L,4033L,4616L,5260L,5969L,6747L,7599L,8529L,9542L,10642L,11835L,13125L,14518L,16019L,17633L,19366L,21224L,23212L,25337L,27604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256309Inst : IEnumerable<long>
{
public static readonly long[] Value=A256309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256309.Bytes);
public long this[int i]=>Value[i];

public static A256309Inst Instance=new A256309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256310
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,5L,11L,20L,35L,58L,90L,136L,199L,282L,391L,532L,709L,931L,1206L,1540L,1945L,2432L,3009L,3692L,4494L,5427L,6510L,7760L,9192L,10829L,12692L,14800L,17180L,19858L,22856L,26207L,29941L,34085L,38677L,43752L,49342L,55491L,62239L,69624L,77695L,86499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256310Inst : IEnumerable<long>
{
public static readonly long[] Value=A256310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256310.Bytes);
public long this[int i]=>Value[i];

public static A256310Inst Instance=new A256310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256311
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,3L,0L,1L,18L,12L,0L,1L,97L,198L,55L,0L,1L,530L,2520L,1820L,273L,0L,1L,2973L,29886L,42228L,15300L,1428L,0L,1L,17059L,347907L,859180L,564585L,122094L,7752L,0L,1L,99657L,4048966L,16482191L,17493938L,6577494L,942172L,43263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256311Inst : IEnumerable<long>
{
public static readonly long[] Value=A256311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256311.Bytes);
public long this[int i]=>Value[i];

public static A256311Inst Instance=new A256311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256312
{
public static readonly long[] Value={ 712329866165608783L,712329866165608813L,712329866165609323L,712329866165609371L,712329866165610103L,712329866165611741L,712329866165612077L,712329866165612677L,712329866165612803L,712329866165614933L,712329866165621653L,712329866165624023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256312Inst : IEnumerable<long>
{
public static readonly long[] Value=A256312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256312.Bytes);
public long this[int i]=>Value[i];

public static A256312Inst Instance=new A256312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256313
{
public static readonly long[] Value={ 0L,0L,2L,6L,15L,27L,47L,72L,108L,150L,206L,270L,351L,441L,551L,672L,816L,972L,1154L,1350L,1575L,1815L,2087L,2376L,2700L,3042L,3422L,3822L,4263L,4725L,5231L,5760L,6336L,6936L,7586L,8262L,8991L,9747L,10559L,11400L,12300L,13230L,14222L,15246L,16335L,17457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256313Inst : IEnumerable<long>
{
public static readonly long[] Value=A256313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256313.Bytes);
public long this[int i]=>Value[i];

public static A256313Inst Instance=new A256313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256314
{
public static readonly long[] Value={ 0L,0L,1L,5L,13L,30L,57L,101L,164L,255L,377L,540L,748L,1014L,1342L,1747L,2233L,2818L,3507L,4319L,5260L,6351L,7599L,9027L,10642L,12470L,14518L,16814L,19366L,22204L,25337L,28796L,32591L,36756L,41301L,46262L,51649L,57501L,63829L,70673L,78045L,85987L,94512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256314Inst : IEnumerable<long>
{
public static readonly long[] Value=A256314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256314.Bytes);
public long this[int i]=>Value[i];

public static A256314Inst Instance=new A256314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256315
{
public static readonly long[] Value={ 0L,0L,1L,3L,11L,26L,58L,110L,199L,331L,532L,811L,1206L,1729L,2432L,3331L,4494L,5942L,7760L,9975L,12692L,15944L,19858L,24473L,29941L,36308L,43752L,52327L,62239L,73551L,86499L,101155L,117788L,136479L,157532L,181038L,207338L,236534L,269005L,304865L,344534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256315Inst : IEnumerable<long>
{
public static readonly long[] Value=A256315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256315.Bytes);
public long this[int i]=>Value[i];

public static A256315Inst Instance=new A256315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256316
{
public static readonly long[] Value={ 0L,0L,3L,13L,37L,84L,164L,291L,480L,748L,1115L,1602L,2233L,3034L,4033L,5260L,6747L,8529L,10642L,13125L,16019L,19366L,23212L,27604L,32591L,38225L,44559L,51649L,59553L,68331L,78045L,88759L,100540L,113456L,127578L,142979L,159733L,177918L,197613L,218899L,241860L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256316Inst : IEnumerable<long>
{
public static readonly long[] Value=A256316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256316.Bytes);
public long this[int i]=>Value[i];

public static A256316Inst Instance=new A256316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256317
{
public static readonly long[] Value={ 0L,0L,2L,11L,35L,90L,199L,391L,709L,1206L,1945L,3009L,4494L,6510L,9192L,12692L,17180L,22856L,29941L,38677L,49342L,62239L,77695L,96079L,117788L,143247L,172929L,207338L,247010L,292534L,344534L,403670L,470660L,546261L,631269L,726544L,832989L,951549L,1083239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256317Inst : IEnumerable<long>
{
public static readonly long[] Value=A256317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256317.Bytes);
public long this[int i]=>Value[i];

public static A256317Inst Instance=new A256317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256318
{
public static readonly long[] Value={ 4L,6L,4L,8L,4L,7L,6L,9L,9L,1L,7L,0L,8L,0L,5L,1L,0L,7L,4L,9L,2L,6L,9L,2L,4L,8L,6L,8L,3L,2L,9L,3L,9L,0L,6L,0L,8L,8L,2L,9L,4L,1L,1L,8L,7L,5L,7L,5L,9L,0L,1L,0L,8L,3L,7L,9L,1L,1L,7L,1L,5L,7L,1L,4L,8L,5L,0L,9L,6L,0L,4L,2L,3L,7L,2L,8L,6L,2L,5L,4L,0L,6L,2L,8L,0L,9L,2L,6L,5L,6L,0L,5L,2L,2L,3L,8L,7L,3L,0L,7L,9L,4L,4L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256318Inst : IEnumerable<long>
{
public static readonly long[] Value=A256318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256318.Bytes);
public long this[int i]=>Value[i];

public static A256318Inst Instance=new A256318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256319
{
public static readonly long[] Value={ 0L,7L,6L,0L,9L,9L,8L,2L,7L,1L,2L,9L,7L,1L,3L,4L,0L,0L,6L,4L,1L,5L,1L,3L,2L,1L,1L,5L,4L,1L,7L,4L,5L,8L,3L,5L,7L,3L,0L,8L,5L,2L,9L,8L,2L,2L,6L,1L,4L,5L,1L,3L,9L,0L,1L,0L,9L,8L,3L,6L,1L,4L,6L,0L,0L,2L,7L,6L,5L,8L,5L,9L,8L,6L,5L,6L,1L,0L,7L,2L,4L,9L,9L,2L,5L,9L,0L,2L,2L,3L,6L,4L,8L,0L,5L,9L,9L,8L,5L,5L,8L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256319Inst : IEnumerable<long>
{
public static readonly long[] Value=A256319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256319.Bytes);
public long this[int i]=>Value[i];

public static A256319Inst Instance=new A256319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256320
{
public static readonly long[] Value={ 0L,1L,5L,12L,21L,33L,48L,65L,85L,108L,133L,161L,192L,225L,261L,300L,341L,385L,432L,481L,533L,588L,645L,705L,768L,833L,901L,972L,1045L,1121L,1200L,1281L,1365L,1452L,1541L,1633L,1728L,1825L,1925L,2028L,2133L,2241L,2352L,2465L,2581L,2700L,2821L,2945L,3072L,3201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256320Inst : IEnumerable<long>
{
public static readonly long[] Value=A256320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256320.Bytes);
public long this[int i]=>Value[i];

public static A256320Inst Instance=new A256320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256321
{
public static readonly long[] Value={ 0L,2L,8L,19L,33L,52L,75L,102L,133L,169L,208L,252L,300L,352L,408L,469L,533L,602L,675L,752L,833L,919L,1008L,1102L,1200L,1302L,1408L,1519L,1633L,1752L,1875L,2002L,2133L,2269L,2408L,2552L,2700L,2852L,3008L,3169L,3333L,3502L,3675L,3852L,4033L,4219L,4408L,4602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256321Inst : IEnumerable<long>
{
public static readonly long[] Value=A256321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256321.Bytes);
public long this[int i]=>Value[i];

public static A256321Inst Instance=new A256321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256322
{
public static readonly long[] Value={ 0L,4L,16L,37L,65L,102L,147L,200L,261L,331L,408L,494L,588L,690L,800L,919L,1045L,1180L,1323L,1474L,1633L,1801L,1976L,2160L,2352L,2552L,2760L,2977L,3201L,3434L,3675L,3924L,4181L,4447L,4720L,5002L,5292L,5590L,5896L,6211L,6533L,6864L,7203L,7550L,7905L,8269L,8640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256322Inst : IEnumerable<long>
{
public static readonly long[] Value=A256322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256322.Bytes);
public long this[int i]=>Value[i];

public static A256322Inst Instance=new A256322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256323
{
public static readonly long[] Value={ 31L,97L,113L,39L,3781L,257L,3131L,6791L,6287L,2113L,33193L,787L,5933L,2063L,26827L,16153L,115453L,11351L,53107L,92453L,23677L,3389L,277777L,52421L,118127L,99367L,147971L,82307L,547381L,4199L,24659L,365459L,266719L,72803L,951481L,172303L,373591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256323Inst : IEnumerable<long>
{
public static readonly long[] Value=A256323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256323.Bytes);
public long this[int i]=>Value[i];

public static A256323Inst Instance=new A256323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256324
{
public static readonly long[] Value={ 30L,840L,3780L,3520L,750750L,98280L,2099160L,7441920L,10665270L,5313000L,119390700L,3931200L,40139190L,18501420L,313038000L,241274880L,2175918570L,266493240L,1535455740L,3258024000L,1007504190L,172657320L,16812360600L,3742502400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256324Inst : IEnumerable<long>
{
public static readonly long[] Value=A256324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256324.Bytes);
public long this[int i]=>Value[i];

public static A256324Inst Instance=new A256324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256325
{
public static readonly BigInteger[] Value={ 0L,0L,1L,5L,24L,136L,933L,7589L,71376L,760796L,9051353L,118784325L,1703388648L,26486926720L,443732646029L,7965563713781L,152504645563072L,3101366761047860L,66753627906345057L,1515914174890163541L,BigInteger.Parse("36218232449903567992"),BigInteger.Parse("908098606824551207384"),BigInteger.Parse("23839591584412453131765") };
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
public class A256325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256325Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256325.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256325.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256325Inst Instance=new A256325Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256326
{
public static readonly long[] Value={ 0L,1L,3L,4L,6L,70L,73L,109L,237L,264L,337L,496L,1029L,1077L,1254L,1288L,2049L,3606L,5035L,9163L,35899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256326Inst : IEnumerable<long>
{
public static readonly long[] Value=A256326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256326.Bytes);
public long this[int i]=>Value[i];

public static A256326Inst Instance=new A256326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256327
{
public static readonly long[] Value={ 0L,1L,9L,27L,64L,120L,206L,321L,478L,672L,920L,1215L,1575L,1991L,2484L,3042L,3689L,4410L,5231L,6136L,7153L,8262L,9495L,10830L,12300L,13881L,15609L,17457L,19464L,21600L,23906L,26351L,28978L,31752L,34720L,37845L,41175L,44671L,48384L,52272L,56389L,60690L,65231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256327Inst : IEnumerable<long>
{
public static readonly long[] Value=A256327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256327.Bytes);
public long this[int i]=>Value[i];

public static A256327Inst Instance=new A256327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256328
{
public static readonly long[] Value={ 0L,2L,15L,47L,108L,206L,351L,551L,816L,1154L,1575L,2087L,2700L,3422L,4263L,5231L,6336L,7586L,8991L,10559L,12300L,14222L,16335L,18647L,21168L,23906L,26871L,30071L,33516L,37214L,41175L,45407L,49920L,54722L,59823L,65231L,70956L,77006L,83391L,90119L,97200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256328Inst : IEnumerable<long>
{
public static readonly long[] Value=A256328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256328.Bytes);
public long this[int i]=>Value[i];

public static A256328Inst Instance=new A256328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256329
{
public static readonly long[] Value={ 0L,3L,23L,72L,169L,321L,551L,864L,1285L,1815L,2484L,3289L,4263L,5400L,6736L,8262L,10018L,11990L,14222L,16698L,19464L,22500L,25857L,29511L,33516L,37845L,42555L,47616L,53089L,58939L,65231L,71928L,79097L,86697L,94800L,103361L,112455L,122034L,132176L,142830L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256329Inst : IEnumerable<long>
{
public static readonly long[] Value=A256329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256329.Bytes);
public long this[int i]=>Value[i];

public static A256329Inst Instance=new A256329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256330
{
public static readonly long[] Value={ 1L,3L,14L,84L,592L,4659L,39699L,359004L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256330Inst : IEnumerable<long>
{
public static readonly long[] Value=A256330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256330.Bytes);
public long this[int i]=>Value[i];

public static A256330Inst Instance=new A256330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256331
{
public static readonly long[] Value={ 1L,3L,14L,81L,527L,3684L,27022L,205149L,1598303L,12705939L,102653652L,840419676L,6956988612L,58132229976L,489673597926L,4153635860373L,35449185841679L,304179698619129L,2622657870000646L,22710277017073785L,197418128701387895L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256331Inst : IEnumerable<long>
{
public static readonly long[] Value=A256331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256331.Bytes);
public long this[int i]=>Value[i];

public static A256331Inst Instance=new A256331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256332
{
public static readonly BigInteger[] Value={ 1L,3L,13L,65L,351L,1994L,11747L,71117L,439765L,2765775L,17636697L,113766694L,741032618L,4867177299L,32199559769L,214369107989L,1435126789097L,9655274425496L,65246685081291L,442668997422749L,3014127038713923L,20590331364902095L,141078438156193677L,969270926188235574L,6676082724399618966L,BigInteger.Parse("46089922748156948822"),BigInteger.Parse("318876966533117953114"),BigInteger.Parse("2210580887889464667057"),BigInteger.Parse("15353093117180070481879"),BigInteger.Parse("106816339860746421126519") };
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
public class A256332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256332Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256332.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256332.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256332Inst Instance=new A256332Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256333
{
public static readonly BigInteger[] Value={ 1L,3L,13L,61L,301L,1552L,8277L,45284L,252753L,1433633L,8239993L,47887467L,280927846L,1661387046L,9894376821L,59288650788L,357198545904L,2162437157263L,13147835385477L,80251977589719L,491573099486143L,3020738578507674L,18617035563669489L,115046892012376542L,712710925868858139L,4425312432316379040L,BigInteger.Parse("27535525144298975942"),BigInteger.Parse("171670784266383750322"),BigInteger.Parse("1072246008621559982926"),BigInteger.Parse("6708644077265798380125") };
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
public class A256333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256333Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256333.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256333.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256333Inst Instance=new A256333Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256334
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,51L,227L,1052L,5030L,24634L,122950L,623140L,3198502L,16593124L,86864578L,458294970L,2434421685L,13008748377L,69882215729L,377172620330L,2044303447067L,11122504636031L,60723579401396L,332564474286299L,1826591420755058L,10058928726906713L,55528582177881182L,307224615377125853L,1703330011411361882L,9461963582991098963UL,BigInteger.Parse("52655804456941167376"),BigInteger.Parse("293523046295844013225") };
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
public class A256334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256334Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256334.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256334.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256334Inst Instance=new A256334Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256335
{
public static readonly BigInteger[] Value={ 1L,3L,15L,93L,639L,4670L,35607L,280069L,2255979L,18516875L,154313881L,1302252294L,11106135906L,95571461319L,828803505465L,7235996887013L,63549647848195L,561049960940540L,4976419846070007L,44325237810194705L,396301576614077927L,3555397444230816343L,BigInteger.Parse("31996727212476905751"),BigInteger.Parse("288776859922595203094"),BigInteger.Parse("2613107152879937592054"),BigInteger.Parse("23702850369539462227046"),BigInteger.Parse("215483061767106353850246"),BigInteger.Parse("1963017891713523908516093"),BigInteger.Parse("17917224620763719834090179"),BigInteger.Parse("163830901587493323034301583"),BigInteger.Parse("1500542646711279198177939831"),BigInteger.Parse("13765184019931774406496702885") };
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
public class A256335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256335Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256335.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256335.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256335Inst Instance=new A256335Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256336
{
public static readonly long[] Value={ 1L,3L,14L,81L,521L,3554L,25172L,183129L,1359863L,10264359L,78521474L,607449380L,4744167924L,37355679904L,296232263792L,2363773540473L,18965408058723L,152910824717297L,1238260516988018L,10066874219853977L,82134185988563049L,672294915226393926L,5519252917557226452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256336Inst : IEnumerable<long>
{
public static readonly long[] Value=A256336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256336.Bytes);
public long this[int i]=>Value[i];

public static A256336Inst Instance=new A256336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256337
{
public static readonly BigInteger[] Value={ 1L,3L,14L,84L,592L,4624L,38527L,334520L,2985938L,27183525L,251204717L,2349231434L,22186989871L,211295835831L,2026765351330L,19563183525857L,189878734136185L,1852021863338181L,18143610295356357L,178450501118284066L,1761425423533593329L,17443012946883397306UL,BigInteger.Parse("173247241040324621443"),BigInteger.Parse("1725404763442479917997"),BigInteger.Parse("17226646104539624029186"),BigInteger.Parse("172389875494663129310211"),BigInteger.Parse("1728819399958251503320772"),BigInteger.Parse("17371923980126335814068340"),BigInteger.Parse("174882805619639894274925366"),BigInteger.Parse("1763573883561574064590764255"),BigInteger.Parse("17813088298000097109198747848"),BigInteger.Parse("180193867968101208748329431620"),BigInteger.Parse("1825392351254024651444300421782"),BigInteger.Parse("18516189068195200519689971895953"),BigInteger.Parse("188058513067187124022632768762920"),BigInteger.Parse("1912273561123769149363329826421051"),BigInteger.Parse("19466808894886697821847017471202077"),BigInteger.Parse("198381665775949932177580813656191187"),BigInteger.Parse("2023702201274806730119560173885757279"),BigInteger.Parse("20663697938590662344370538856632433182") };
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
public class A256337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256337Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256337.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256337.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256337Inst Instance=new A256337Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256338
{
public static readonly BigInteger[] Value={ 1L,3L,14L,81L,526L,3655L,26522L,198322L,1516296L,11794717L,93028387L,742192059L,5978650560L,48558821234L,397218622275L,3269629207524L,27061726430000L,225078993453143L,1880240716499975L,15768890757767329L,132719696885282352L,1120664726059889642L,9490737694928103944UL,BigInteger.Parse("80593740187789336604"),BigInteger.Parse("686097231181385302494"),BigInteger.Parse("5854230604182513256777"),BigInteger.Parse("50058728487687099021228"),BigInteger.Parse("428893610758038945556024"),BigInteger.Parse("3681458291424994103104272"),BigInteger.Parse("31654643493605098603330050"),BigInteger.Parse("272617697673293256259943417"),BigInteger.Parse("2351397730980411031399548438"),BigInteger.Parse("20310185543805378949877753778"),BigInteger.Parse("175663385844074502933143530174"),BigInteger.Parse("1521230708939544454165789841800"),BigInteger.Parse("13189400713003422051741601456307"),BigInteger.Parse("114483609078595784724427186310842"),BigInteger.Parse("994773380472692869438699360298740"),BigInteger.Parse("8652545469871591210786412806190538") };
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
public class A256338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256338Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256338.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256338.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256338Inst Instance=new A256338Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256339
{
public static readonly long[] Value={ 53L,239L,6719L,7321L,4073561L,6257813L,6521843L,85271063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256339Inst : IEnumerable<long>
{
public static readonly long[] Value=A256339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256339.Bytes);
public long this[int i]=>Value[i];

public static A256339Inst Instance=new A256339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256340
{
public static readonly long[] Value={ 7L,8L,77L,78L,87L,88L,777L,778L,787L,788L,877L,878L,887L,888L,7777L,7778L,7787L,7788L,7877L,7878L,7887L,7888L,8777L,8778L,8787L,8788L,8877L,8878L,8887L,8888L,77777L,77778L,77787L,77788L,77877L,77878L,77887L,77888L,78777L,78778L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256340Inst : IEnumerable<long>
{
public static readonly long[] Value=A256340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256340.Bytes);
public long this[int i]=>Value[i];

public static A256340Inst Instance=new A256340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256341
{
public static readonly long[] Value={ 8L,9L,88L,89L,98L,99L,888L,889L,898L,899L,988L,989L,998L,999L,8888L,8889L,8898L,8899L,8988L,8989L,8998L,8999L,9888L,9889L,9898L,9899L,9988L,9989L,9998L,9999L,88888L,88889L,88898L,88899L,88988L,88989L,88998L,88999L,89888L,89889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256341Inst : IEnumerable<long>
{
public static readonly long[] Value=A256341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256341.Bytes);
public long this[int i]=>Value[i];

public static A256341Inst Instance=new A256341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256342
{
public static readonly long[] Value={ 2L,4L,6L,8L,11L,12L,14L,16L,22L,23L,24L,28L,29L,32L,33L,38L,42L,44L,46L,48L,53L,56L,58L,62L,64L,66L,67L,69L,74L,76L,77L,84L,86L,87L,88L,92L,96L,106L,107L,109L,112L,114L,116L,124L,127L,128L,132L,134L,138L,148L,152L,154L,159L,161L,163L,168L,172L,174L,176L,184L,186L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256342Inst : IEnumerable<long>
{
public static readonly long[] Value=A256342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256342.Bytes);
public long this[int i]=>Value[i];

public static A256342Inst Instance=new A256342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256343
{
public static readonly long[] Value={ 5L,9L,15L,25L,27L,35L,45L,59L,63L,75L,95L,97L,105L,125L,135L,155L,171L,175L,177L,185L,189L,215L,225L,251L,279L,285L,291L,295L,315L,333L,375L,379L,387L,413L,419L,465L,475L,485L,513L,525L,531L,555L,617L,625L,645L,665L,675L,679L,753L,775L,785L,837L,855L,863L,873L,875L,885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256343Inst : IEnumerable<long>
{
public static readonly long[] Value=A256343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256343.Bytes);
public long this[int i]=>Value[i];

public static A256343Inst Instance=new A256343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256344
{
public static readonly long[] Value={ 13L,26L,39L,47L,52L,78L,79L,91L,94L,104L,113L,141L,143L,156L,158L,169L,173L,182L,188L,197L,208L,226L,237L,247L,273L,282L,286L,299L,312L,316L,329L,338L,339L,346L,353L,364L,376L,377L,394L,403L,416L,429L,439L,452L,474L,481L,494L,507L,517L,519L,546L,553L,559L,564L,572L,591L,598L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256344Inst : IEnumerable<long>
{
public static readonly long[] Value=A256344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256344.Bytes);
public long this[int i]=>Value[i];

public static A256344Inst Instance=new A256344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256345
{
public static readonly long[] Value={ 83L,151L,167L,223L,249L,257L,283L,359L,373L,453L,501L,563L,581L,607L,669L,677L,771L,821L,849L,953L,1057L,1077L,1119L,1169L,1321L,1561L,1577L,1689L,1743L,1799L,1821L,1981L,1987L,2017L,2031L,2463L,2513L,2573L,2611L,2833L,2859L,2869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256345Inst : IEnumerable<long>
{
public static readonly long[] Value=A256345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256345.Bytes);
public long this[int i]=>Value[i];

public static A256345Inst Instance=new A256345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256346
{
public static readonly long[] Value={ 10L,17L,18L,20L,30L,34L,36L,40L,49L,50L,51L,54L,55L,60L,68L,70L,72L,73L,80L,85L,90L,98L,99L,100L,102L,108L,110L,115L,118L,119L,120L,126L,136L,140L,144L,145L,146L,147L,150L,153L,160L,165L,170L,180L,187L,190L,194L,196L,198L,199L,200L,204L,207L,210L,211L,216L,219L,220L,230L,236L,238L,240L,245L,250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256346Inst : IEnumerable<long>
{
public static readonly long[] Value=A256346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256346.Bytes);
public long this[int i]=>Value[i];

public static A256346Inst Instance=new A256346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256347
{
public static readonly long[] Value={ 41L,123L,131L,287L,317L,393L,503L,547L,727L,779L,861L,917L,951L,1091L,1237L,1271L,1277L,1509L,1517L,1627L,1637L,1641L,1681L,1763L,2089L,2181L,2219L,2239L,2337L,2357L,2383L,2489L,2531L,2671L,2751L,2789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256347Inst : IEnumerable<long>
{
public static readonly long[] Value=A256347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256347.Bytes);
public long this[int i]=>Value[i];

public static A256347Inst Instance=new A256347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256348
{
public static readonly long[] Value={ 193L,386L,461L,523L,579L,772L,887L,922L,1019L,1046L,1158L,1351L,1383L,1544L,1569L,1774L,1844L,1861L,2038L,2092L,2123L,2153L,2269L,2316L,2509L,2661L,2702L,2766L,2887L,3057L,3088L,3138L,3227L,3391L,3449L,3541L,3548L,3661L,3667L,3688L,3722L,3919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256348Inst : IEnumerable<long>
{
public static readonly long[] Value=A256348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256348.Bytes);
public long this[int i]=>Value[i];

public static A256348Inst Instance=new A256348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256349
{
public static readonly long[] Value={ 81L,101L,271L,303L,361L,405L,505L,509L,567L,653L,707L,743L,813L,839L,909L,1033L,1083L,1187L,1355L,1447L,1515L,1527L,1539L,1753L,1805L,1897L,1919L,1959L,2025L,2121L,2229L,2381L,2439L,2511L,2517L,2525L,2527L,2545L,2579L,2687L,2727L,2749L,2753L,2777L,2803L,2835L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256349Inst : IEnumerable<long>
{
public static readonly long[] Value=A256349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256349.Bytes);
public long this[int i]=>Value[i];

public static A256349Inst Instance=new A256349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256350
{
public static readonly long[] Value={ 4L,6L,12L,26L,27L,35L,38L,45L,46L,48L,49L,50L,52L,56L,57L,58L,63L,64L,65L,66L,68L,77L,81L,82L,84L,85L,88L,95L,105L,116L,117L,118L,119L,121L,122L,134L,136L,138L,142L,153L,154L,161L,165L,166L,171L,175L,176L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256350Inst : IEnumerable<long>
{
public static readonly long[] Value=A256350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256350.Bytes);
public long this[int i]=>Value[i];

public static A256350Inst Instance=new A256350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256351
{
public static readonly long[] Value={ 8L,9L,15L,16L,21L,22L,25L,28L,34L,75L,87L,91L,93L,94L,106L,111L,123L,141L,143L,145L,147L,155L,172L,201L,205L,214L,217L,237L,255L,298L,304L,305L,363L,371L,376L,377L,385L,388L,395L,403L,411L,423L,428L,442L,458L,466L,471L,473L,483L,495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256351Inst : IEnumerable<long>
{
public static readonly long[] Value=A256351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256351.Bytes);
public long this[int i]=>Value[i];

public static A256351Inst Instance=new A256351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256352
{
public static readonly long[] Value={ 10L,33L,39L,133L,183L,185L,203L,235L,291L,295L,303L,325L,343L,381L,391L,451L,475L,517L,535L,539L,561L,583L,655L,703L,723L,753L,775L,791L,799L,841L,867L,889L,895L,943L,1003L,1023L,1083L,1099L,1121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256352Inst : IEnumerable<long>
{
public static readonly long[] Value=A256352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256352.Bytes);
public long this[int i]=>Value[i];

public static A256352Inst Instance=new A256352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256353
{
public static readonly long[] Value={ 55L,169L,247L,253L,323L,493L,529L,556L,671L,1027L,1111L,1243L,1261L,1339L,1375L,1711L,1751L,1803L,2185L,2413L,2431L,2881L,3193L,4381L,4417L,4843L,5029L,5203L,5251L,6631L,7093L,7999L,8515L,8653L,9271L,9307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256353Inst : IEnumerable<long>
{
public static readonly long[] Value=A256353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256353.Bytes);
public long this[int i]=>Value[i];

public static A256353Inst Instance=new A256353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256354
{
public static readonly long[] Value={ 115L,2563L,3523L,5071L,9193L,10873L,12223L,12811L,13231L,15775L,19111L,20203L,23089L,25831L,27007L,28171L,34189L,39859L,40033L,43361L,55033L,57871L,58813L,74371L,84253L,89377L,93043L,95833L,101683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256354Inst : IEnumerable<long>
{
public static readonly long[] Value=A256354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256354.Bytes);
public long this[int i]=>Value[i];

public static A256354Inst Instance=new A256354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256355
{
public static readonly long[] Value={ 11233L,42241L,98281L,131239L,161953L,315151L,358135L,606553L,692263L,785851L,1114081L,1130419L,1525777L,1906363L,3369313L,3403081L,3880873L,5616721L,6036103L,6947611L,7253191L,7516783L,7886593L,8799127L,8811223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256355Inst : IEnumerable<long>
{
public static readonly long[] Value=A256355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256355.Bytes);
public long this[int i]=>Value[i];

public static A256355Inst Instance=new A256355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256356
{
public static readonly long[] Value={ 33247243L,64037779L,104865433L,130237003L,238561081L,550677781L,947051353L,1013991553L,1246382791L,1343122201L,1607697631L,1609062751L,1632753601L,1788658063L,2203645111L,2364166213L,2393866411L,2480419783L,2518589671L,2544177511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256356Inst : IEnumerable<long>
{
public static readonly long[] Value=A256356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256356.Bytes);
public long this[int i]=>Value[i];

public static A256356Inst Instance=new A256356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256357
{
public static readonly long[] Value={ 1L,1L,-2L,5L,-4L,-2L,8L,-3L,7L,-4L,-10L,14L,-12L,8L,8L,-19L,18L,7L,-18L,20L,-16L,-10L,24L,-18L,21L,-12L,-20L,40L,-28L,8L,32L,-51L,20L,18L,-32L,59L,-36L,-18L,24L,-28L,42L,-16L,-42L,38L,-28L,24L,48L,-82L,57L,21L,-36L,44L,-52L,-20L,40L,-24L,36L,-28L,-58L,104L,-60L,32L,56L,-115L,48L,20L,-66L,90L,-48L,-32L,72L,-45L,74L,-36L,-42L,62L,-80L,24L,80L,-124L,61L,42L,-82L,112L,-72L,-42L,56L,-58L,90L,-28L,-96L,120L,-64L,48L,72L,-210L,98L,57L,-70L,145L,-100L,-36L,104L,-68L,64L,-52L,-106L,140L,-108L,40L,72L,-152L,114L,36L,-96L,92L,-84L,-58L,144L,-88L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256357Inst : IEnumerable<long>
{
public static readonly long[] Value=A256357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256357.Bytes);
public long this[int i]=>Value[i];

public static A256357Inst Instance=new A256357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256358
{
public static readonly long[] Value={ 2L,2L,5L,7L,9L,1L,3L,5L,2L,6L,4L,4L,7L,2L,7L,4L,3L,2L,3L,6L,3L,0L,9L,7L,6L,1L,4L,9L,4L,7L,4L,4L,1L,0L,7L,1L,7L,8L,5L,8L,9L,7L,3L,3L,9L,2L,7L,7L,5L,2L,8L,1L,5L,8L,6L,9L,6L,4L,7L,1L,5L,3L,0L,9L,8L,9L,3L,7L,2L,0L,7L,3L,9L,5L,7L,5L,6L,5L,6L,8L,2L,0L,8L,8L,8L,7L,9L,9L,7L,1L,6L,3L,9L,5L,3L,5L,5L,1L,0L,0L,8L,0L,0L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256358Inst : IEnumerable<long>
{
public static readonly long[] Value=A256358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256358.Bytes);
public long this[int i]=>Value[i];

public static A256358Inst Instance=new A256358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256359
{
public static readonly long[] Value={ 5L,8L,10L,13L,17L,18L,20L,25L,26L,28L,29L,32L,35L,37L,40L,41L,43L,45L,50L,52L,53L,55L,58L,61L,62L,65L,68L,72L,80L,82L,83L,85L,90L,92L,97L,98L,99L,101L,104L,109L,113L,117L,118L,122L,125L,126L,127L,128L,133L,134L,136L,145L,146L,148L,152L,153L,160L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256359Inst : IEnumerable<long>
{
public static readonly long[] Value=A256359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256359.Bytes);
public long this[int i]=>Value[i];

public static A256359Inst Instance=new A256359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256360
{
public static readonly long[] Value={ 5L,8L,10L,13L,18L,20L,25L,26L,32L,35L,37L,40L,41L,43L,52L,53L,55L,58L,61L,62L,65L,68L,72L,80L,82L,83L,90L,92L,97L,98L,99L,101L,104L,109L,113L,117L,118L,122L,127L,128L,134L,146L,148L,152L,162L,170L,173L,178L,180L,181L,185L,190L,197L,205L,221L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256360Inst : IEnumerable<long>
{
public static readonly long[] Value=A256360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256360.Bytes);
public long this[int i]=>Value[i];

public static A256360Inst Instance=new A256360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256361
{
public static readonly long[] Value={ 17L,28L,29L,45L,50L,85L,126L,133L,136L,145L,153L,160L,200L,245L,250L,260L,261L,265L,353L,365L,371L,405L,425L,442L,450L,490L,514L,520L,533L,585L,605L,650L,666L,680L,738L,800L,855L,925L,936L,1000L,1025L,1105L,1225L,1233L,1250L,1280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256361Inst : IEnumerable<long>
{
public static readonly long[] Value=A256361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256361.Bytes);
public long this[int i]=>Value[i];

public static A256361Inst Instance=new A256361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256362
{
public static readonly long[] Value={ 125L,325L,370L,793L,845L,1125L,1445L,2080L,2125L,2925L,3125L,3200L,3725L,3757L,5050L,5265L,6125L,6250L,6845L,7605L,8125L,8405L,10125L,10261L,10440L,10625L,11250L,13005L,13690L,14365L,15125L,15925L,18785L,22100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256362Inst : IEnumerable<long>
{
public static readonly long[] Value=A256362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256362.Bytes);
public long this[int i]=>Value[i];

public static A256362Inst Instance=new A256362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256363
{
public static readonly long[] Value={ 4901L,8450L,21125L,33125L,41405L,42050L,47125L,71825L,90625L,117325L,142805L,142885L,151250L,184093L,244205L,272000L,325125L,361250L,520625L,535717L,546325L,638450L,690625L,777925L,861125L,874225L,903125L,982125L,990125L,1035125L,1053405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256363Inst : IEnumerable<long>
{
public static readonly long[] Value=A256363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256363.Bytes);
public long this[int i]=>Value[i];

public static A256363Inst Instance=new A256363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256364
{
public static readonly long[] Value={ 274625L,465125L,528125L,710645L,912925L,983125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256364Inst : IEnumerable<long>
{
public static readonly long[] Value=A256364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256364.Bytes);
public long this[int i]=>Value[i];

public static A256364Inst Instance=new A256364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256365
{
public static readonly long[] Value={ 36125L,190125L,444925L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256365Inst : IEnumerable<long>
{
public static readonly long[] Value=A256365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256365.Bytes);
public long this[int i]=>Value[i];

public static A256365Inst Instance=new A256365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256366
{
public static readonly long[] Value={ 2L,3L,2L,3L,5L,3L,5L,2L,5L,2L,3L,7L,3L,7L,2L,5L,11L,5L,11L,2L,3L,13L,17L,13L,17L,3L,2L,19L,2L,19L,2L,5L,2L,5L,2L,5L,2L,5L,23L,3L,23L,2L,23L,29L,3L,29L,2L,7L,2L,7L,2L,3L,2L,3L,31L,3L,31L,2L,31L,2L,3L,2L,11L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256366Inst : IEnumerable<long>
{
public static readonly long[] Value=A256366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256366.Bytes);
public long this[int i]=>Value[i];

public static A256366Inst Instance=new A256366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256367
{
public static readonly long[] Value={ 1L,0L,4L,3L,5L,9L,0L,1L,0L,9L,5L,9L,4L,9L,8L,4L,7L,5L,3L,8L,1L,1L,8L,4L,1L,7L,7L,1L,2L,8L,7L,0L,2L,2L,7L,3L,3L,3L,5L,4L,8L,8L,9L,6L,9L,6L,9L,3L,4L,0L,3L,7L,8L,9L,7L,1L,0L,6L,5L,8L,9L,3L,0L,6L,7L,0L,3L,3L,5L,5L,3L,4L,3L,4L,8L,9L,7L,2L,3L,7L,0L,4L,6L,9L,9L,3L,1L,7L,0L,5L,3L,3L,9L,9L,6L,4L,1L,8L,2L,8L,5L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256367Inst : IEnumerable<long>
{
public static readonly long[] Value=A256367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256367.Bytes);
public long this[int i]=>Value[i];

public static A256367Inst Instance=new A256367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256368
{
public static readonly long[] Value={ 2L,3L,2L,3L,2L,5L,2L,5L,2L,5L,2L,7L,2L,7L,2L,3L,2L,3L,11L,13L,11L,13L,3L,2L,3L,2L,17L,2L,17L,2L,5L,2L,5L,2L,13L,2L,7L,2L,7L,19L,3L,19L,2L,19L,2L,3L,2L,23L,2L,23L,2L,5L,2L,3L,2L,3L,2L,29L,31L,29L,31L,2L,3L,2L,11L,2L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256368Inst : IEnumerable<long>
{
public static readonly long[] Value=A256368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256368.Bytes);
public long this[int i]=>Value[i];

public static A256368Inst Instance=new A256368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256369
{
public static readonly BigInteger[] Value={ 2L,15L,406L,40258L,14831678L,20517694389L,107429900933236L,2142202276884870716L,BigInteger.Parse("163481473873315612871890"),BigInteger.Parse("47938888004647069685675105423"),BigInteger.Parse("54195408755986948204810401084145420"),BigInteger.Parse("236870277534533345162432986910962427358196") };
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
public class A256369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256369Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256369.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256369.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256369Inst Instance=new A256369Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256370
{
public static readonly long[] Value={ 7L,25L,97L,115L,145L,169L,223L,247L,343L,379L,385L,421L,541L,577L,601L,607L,673L,691L,751L,847L,895L,961L,997L,1111L,1129L,1237L,1267L,1303L,1327L,1459L,1489L,1555L,1615L,1639L,1657L,1663L,1741L,1765L,1771L,1807L,1819L,1831L,1873L,1903L,1927L,1945L,1951L,1963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256370Inst : IEnumerable<long>
{
public static readonly long[] Value=A256370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256370.Bytes);
public long this[int i]=>Value[i];

public static A256370Inst Instance=new A256370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256371
{
public static readonly long[] Value={ 2L,1L,3L,5L,4L,6L,7L,11L,8L,12L,9L,14L,10L,15L,13L,17L,16L,19L,18L,22L,20L,23L,21L,28L,24L,29L,25L,30L,26L,32L,27L,34L,31L,36L,33L,38L,35L,40L,37L,41L,39L,45L,42L,46L,43L,48L,44L,49L,47L,51L,50L,53L,52L,57L,54L,58L,55L,59L,56L,62L,60L,64L,61L,66L,63L,68L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256371Inst : IEnumerable<long>
{
public static readonly long[] Value=A256371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256371.Bytes);
public long this[int i]=>Value[i];

public static A256371Inst Instance=new A256371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256372
{
public static readonly long[] Value={ 3L,6L,7L,122L,123L,226L,227L,506L,507L,794L,795L,970L,971L,3118L,3119L,11074L,11075L,14502L,14503L,55536L,55537L,77752L,77753L,77754L,77755L,85524L,85525L,90434L,90435L,101222L,101223L,101226L,101227L,101230L,101231L,207146L,207147L,227730L,227731L,244576L,244577L,244578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256372Inst : IEnumerable<long>
{
public static readonly long[] Value=A256372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256372.Bytes);
public long this[int i]=>Value[i];

public static A256372Inst Instance=new A256372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256373
{
public static readonly long[] Value={ 0L,5L,34L,36L,100L,165L,520L,528L,544L,549L,565L,814L,1552L,1589L,2568L,2577L,2592L,2593L,2597L,4629L,4663L,8245L,8328L,8469L,8748L,8757L,8765L,16448L,16484L,16512L,16549L,16640L,16645L,16896L,16901L,16904L,16932L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256373Inst : IEnumerable<long>
{
public static readonly long[] Value=A256373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256373.Bytes);
public long this[int i]=>Value[i];

public static A256373Inst Instance=new A256373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256374
{
public static readonly long[] Value={ 17L,31L,59L,101L,157L,227L,311L,409L,521L,647L,787L,941L,1109L,1291L,1487L,1697L,2411L,2677L,2957L,3251L,3559L,3881L,4217L,4567L,4931L,5309L,5701L,6961L,8837L,9341L,9859L,10391L,10937L,11497L,12071L,12659L,13877L,15809L,16481L,17167L,19309L,20051L,20807L,21577L,23159L,23971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256374Inst : IEnumerable<long>
{
public static readonly long[] Value=A256374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256374.Bytes);
public long this[int i]=>Value[i];

public static A256374Inst Instance=new A256374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256375
{
public static readonly long[] Value={ 4L,5L,6L,8L,13L,14L,25L,30L,44L,58L,383L,455L,463L,504L,511L,1358L,2293L,4096L,4374L,8664L,13676L,23993L,84134L,90155L,115794L,127858L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256375Inst : IEnumerable<long>
{
public static readonly long[] Value=A256375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256375.Bytes);
public long this[int i]=>Value[i];

public static A256375Inst Instance=new A256375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256376
{
public static readonly long[] Value={ 23L,83L,163L,263L,383L,523L,683L,863L,1063L,1283L,1523L,1783L,2063L,2683L,3023L,4583L,5023L,5483L,6983L,7523L,8663L,9883L,11863L,14783L,16363L,17183L,19763L,20663L,25463L,29663L,30763L,31883L,33023L,34183L,35363L,36563L,37783L,39023L,40283L,42863L,45523L,49663L,56963L,61583L,64763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256376Inst : IEnumerable<long>
{
public static readonly long[] Value=A256376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256376.Bytes);
public long this[int i]=>Value[i];

public static A256376Inst Instance=new A256376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256377
{
public static readonly long[] Value={ 239L,1871L,390959L,839519L,5622479L,10256399L,14639039L,60453359L,142374959L,188226719L,423474479L,1119903119L,7965713519L,9788425919L,16180741439L,22110152399L,28064855519L,28793774879L,36010838159L,43494981839L,44506450799L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256377Inst : IEnumerable<long>
{
public static readonly long[] Value=A256377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256377.Bytes);
public long this[int i]=>Value[i];

public static A256377Inst Instance=new A256377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256378
{
public static readonly long[] Value={ 239L,1871L,151871L,390959L,839519L,5622479L,10256399L,14639039L,20295599L,27451871L,53551871L,60453359L,68001359L,142374959L,188226719L,224415599L,244351871L,364651871L,423474479L,524701871L,562166159L,1119903119L,2015694719L,2223601871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256378Inst : IEnumerable<long>
{
public static readonly long[] Value=A256378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256378.Bytes);
public long this[int i]=>Value[i];

public static A256378Inst Instance=new A256378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256379
{
public static readonly long[] Value={ 1L,3L,6L,10L,15L,21L,28L,36L,45L,44L,44L,43L,39L,36L,30L,25L,17L,10L,0L,2L,1L,1L,6L,8L,15L,19L,28L,34L,45L,42L,44L,39L,39L,38L,30L,27L,17L,12L,0L,4L,1L,7L,6L,6L,15L,17L,28L,32L,45L,40L,44L,37L,39L,30L,30L,29L,17L,14L,0L,6L,1L,9L,6L,16L,15L,15L,28L,30L,45L,38L,44L,35L,39L,28L,30L,17L,17L,16L,0L,8L,1L,11L,6L,18L,15L,29L,28L,28L,45L,36L,44L,33L,39L,26L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256379Inst : IEnumerable<long>
{
public static readonly long[] Value=A256379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256379.Bytes);
public long this[int i]=>Value[i];

public static A256379Inst Instance=new A256379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256380
{
public static readonly long[] Value={ 109L,239L,653L,1327L,1871L,14669L,15887L,31039L,31583L,33359L,45599L,57839L,84223L,85999L,100559L,112799L,114479L,126719L,130349L,131023L,135119L,140639L,158959L,159503L,167119L,167663L,195599L,213919L,214463L,228479L,242399L,297359L,363439L,365759L,377999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256380Inst : IEnumerable<long>
{
public static readonly long[] Value=A256380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256380.Bytes);
public long this[int i]=>Value[i];

public static A256380Inst Instance=new A256380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256381
{
public static readonly long[] Value={ 7L,12L,18L,36L,52L,54L,88L,90L,118L,126L,158L,180L,206L,212L,216L,218L,250L,256L,262L,292L,298L,302L,306L,324L,326L,332L,338L,358L,368L,374L,410L,414L,448L,450L,508L,514L,530L,532L,540L,548L,556L,562L,576L,586L,594L,626L,632L,652L,682L,684L,692L,700L,710L,720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256381Inst : IEnumerable<long>
{
public static readonly long[] Value=A256381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256381.Bytes);
public long this[int i]=>Value[i];

public static A256381Inst Instance=new A256381Inst();

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