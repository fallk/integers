using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A144084
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,2L,1L,9L,18L,6L,1L,16L,72L,96L,24L,1L,25L,200L,600L,600L,120L,1L,36L,450L,2400L,5400L,4320L,720L,1L,49L,882L,7350L,29400L,52920L,35280L,5040L,1L,64L,1568L,18816L,117600L,376320L,564480L,322560L,40320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144084Inst : IEnumerable<long>
{
public static readonly long[] Value=A144084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144084.Bytes);
public long this[int i]=>Value[i];

public static A144084Inst Instance=new A144084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144083
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,1L,1L,2L,2L,1L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,1L,0L,0L,1L,2L,2L,1L,2L,1L,0L,0L,1L,2L,2L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144083Inst : IEnumerable<long>
{
public static readonly long[] Value=A144083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144083.Bytes);
public long this[int i]=>Value[i];

public static A144083Inst Instance=new A144083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144082
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,2L,-1L,0L,2L,3L,-1L,-1L,0L,3L,4L,0L,-1L,-2L,0L,4L,5L,1L,0L,-2L,-3L,0L,5L,6L,1L,1L,0L,-3L,-4L,0L,6L,7L,0L,1L,2L,0L,-4L,-5L,0L,7L,8L,-1L,0L,2L,3L,0L,-5L,-6L,0L,8L,9L,-1L,-1L,0L,3L,4L,0L,-6L,-7L,0L,9L,10L,0L,-1L,-2L,0L,4L,5L,0L,-7L,-8L,0L,10L,11L,1L,0L,-2L,-3L,0L,5L,6L,0L,-8L,-9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144082Inst : IEnumerable<long>
{
public static readonly long[] Value=A144082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144082.Bytes);
public long this[int i]=>Value[i];

public static A144082Inst Instance=new A144082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144081
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,3L,0L,2L,6L,7L,-4L,0L,6L,14L,15L,-8L,-4L,0L,14L,30L,31L,-8L,-8L,-12L,0L,30L,62L,63L,0L,-8L,-24L,-28L,0L,62L,126L,127L,16L,0L,-24L,-56L,-60L,0L,126L,254L,255L,32L,16L,0L,-56L,-120L,-124L,0L,254L,510L,511L,32L,32L,48L,0L,-120L,-248L,-252L,0L,510L,1022L,1023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144081Inst : IEnumerable<long>
{
public static readonly long[] Value=A144081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144081.Bytes);
public long this[int i]=>Value[i];

public static A144081Inst Instance=new A144081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144080
{
public static readonly long[] Value={ 1L,14L,19L,46L,85L,155L,233L,350L,494L,659L,878L,1163L,1460L,1828L,2260L,2726L,3271L,3873L,4564L,5321L,6151L,7032L,8044L,9151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144080Inst : IEnumerable<long>
{
public static readonly long[] Value=A144080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144080.Bytes);
public long this[int i]=>Value[i];

public static A144080Inst Instance=new A144080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144079
{
public static readonly long[] Value={ 1L,0L,2L,1L,3L,1L,3L,2L,4L,0L,2L,0L,2L,2L,4L,3L,5L,1L,3L,3L,5L,1L,3L,1L,3L,3L,5L,1L,3L,3L,5L,4L,6L,2L,4L,2L,4L,0L,2L,2L,4L,0L,2L,4L,6L,2L,4L,2L,4L,4L,6L,0L,2L,2L,4L,0L,2L,2L,4L,2L,4L,4L,6L,5L,7L,3L,5L,3L,5L,1L,3L,5L,7L,3L,5L,3L,5L,1L,3L,3L,5L,1L,3L,5L,7L,3L,5L,3L,5L,1L,3L,5L,7L,3L,5L,3L,5L,5L,7L,1L,3L,3L,5L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144079Inst : IEnumerable<long>
{
public static readonly long[] Value=A144079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144079.Bytes);
public long this[int i]=>Value[i];

public static A144079Inst Instance=new A144079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144078
{
public static readonly long[] Value={ 0L,2L,0L,2L,0L,2L,0L,2L,0L,4L,2L,4L,2L,2L,0L,2L,0L,4L,2L,2L,0L,4L,2L,4L,2L,2L,0L,4L,2L,2L,0L,2L,0L,4L,2L,4L,2L,6L,4L,4L,2L,6L,4L,2L,0L,4L,2L,4L,2L,2L,0L,6L,4L,4L,2L,6L,4L,4L,2L,4L,2L,2L,0L,2L,0L,4L,2L,4L,2L,6L,4L,2L,0L,4L,2L,4L,2L,6L,4L,4L,2L,6L,4L,2L,0L,4L,2L,4L,2L,6L,4L,2L,0L,4L,2L,4L,2L,2L,0L,6L,4L,4L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144078Inst : IEnumerable<long>
{
public static readonly long[] Value=A144078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144078.Bytes);
public long this[int i]=>Value[i];

public static A144078Inst Instance=new A144078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144077
{
public static readonly long[] Value={ 1L,3L,5L,7L,8L,10L,12L,14L,15L,17L,19L,20L,22L,24L,26L,27L,29L,31L,33L,34L,36L,38L,40L,41L,43L,45L,46L,48L,50L,52L,53L,55L,57L,59L,60L,62L,64L,66L,67L,69L,71L,72L,74L,76L,78L,79L,81L,83L,85L,86L,88L,90L,92L,93L,95L,97L,98L,100L,102L,104L,105L,107L,109L,111L,112L,114L,116L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144077Inst : IEnumerable<long>
{
public static readonly long[] Value=A144077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144077.Bytes);
public long this[int i]=>Value[i];

public static A144077Inst Instance=new A144077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144076
{
public static readonly long[] Value={ 7L,11L,2L,19L,17L,24L,68L,37L,20L,253L,14L,40L,41L,44L,24L,90L,6L,4L,2L,28L,28L,9L,75L,13L,18L,77L,12L,2L,64L,52L,148L,13L,61L,736L,72L,104L,9L,4L,1L,60L,1026L,15L,3403L,24L,72L,12L,81L,88L,98L,252L,110L,15L,22L,199L,1750L,41L,206L,7L,88L,75L,222L,98L,87L,112L,8L,19L,64L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144076Inst : IEnumerable<long>
{
public static readonly long[] Value=A144076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144076.Bytes);
public long this[int i]=>Value[i];

public static A144076Inst Instance=new A144076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144075
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L,6L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,11L,12L,12L,12L,12L,13L,13L,13L,13L,14L,14L,14L,14L,15L,15L,15L,15L,16L,16L,16L,16L,17L,17L,17L,17L,18L,18L,18L,18L,19L,19L,19L,19L,20L,20L,20L,20L,21L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144075Inst : IEnumerable<long>
{
public static readonly long[] Value=A144075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144075.Bytes);
public long this[int i]=>Value[i];

public static A144075Inst Instance=new A144075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144074
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,2L,2L,0L,1L,3L,7L,3L,0L,1L,4L,15L,20L,5L,0L,1L,5L,26L,64L,59L,7L,0L,1L,6L,40L,148L,276L,162L,11L,0L,1L,7L,57L,285L,843L,1137L,449L,15L,0L,1L,8L,77L,488L,2020L,4632L,4648L,1200L,22L,0L,1L,9L,100L,770L,4140L,13876L,25124L,18585L,3194L,30L,0L,1L,10L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144074Inst : IEnumerable<long>
{
public static readonly long[] Value=A144074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144074.Bytes);
public long this[int i]=>Value[i];

public static A144074Inst Instance=new A144074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144073
{
public static readonly BigInteger[] Value={ 1L,9L,126L,1623L,20583L,254493L,3091803L,36974025L,436377771L,5091463423L,58811218362L,673298882775L,7647050353038L,86229872235432L,966019964324004L,10757807941399023L,119146632352548516L,1312935665205028374L,14400230629085596621UL,BigInteger.Parse("157253909597473608945") };
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
public class A144073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144073Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144073.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144073.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144073Inst Instance=new A144073Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144072
{
public static readonly ulong[] Value={ 1L,8L,100L,1144L,12906L,141848L,1532276L,16290920L,170938483L,1773107760L,18208004664L,185316171472L,1871103319988L,18756665504080L,186798940872312L,1849265718114736L,18207140415436701L,178355043327697976L,1738966407826985884L,16881111732250394440UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144072Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A144072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144072.Bytes);
public ulong this[int i]=>Value[i];

public static A144072Inst Instance=new A144072Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144039
{
public static readonly long[] Value={ 0L,1L,1L,8L,43L,295L,1982L,14379L,106464L,811769L,6304231L,49770106L,398042059L,3218655532L,26269422252L,216121646661L,1790428656802L,14922986525284L,125050910828179L,1052916751167676L,8903502888220215L,75579379572985970L,643818145873489913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144039Inst : IEnumerable<long>
{
public static readonly long[] Value=A144039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144039.Bytes);
public long this[int i]=>Value[i];

public static A144039Inst Instance=new A144039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144038
{
public static readonly long[] Value={ 0L,1L,1L,7L,34L,209L,1260L,8219L,54677L,374904L,2617996L,18588586L,133708072L,972484206L,7139186644L,52832157095L,393700752053L,2951755132720L,22250074031893L,168524281244364L,1281906305775734L,9788771511218660L,75010092629043843L,576625427728255451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144038Inst : IEnumerable<long>
{
public static readonly long[] Value=A144038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144038.Bytes);
public long this[int i]=>Value[i];

public static A144038Inst Instance=new A144038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144037
{
public static readonly long[] Value={ 0L,1L,1L,6L,26L,141L,751L,4337L,25512L,154839L,956877L,6014098L,38292603L,246550449L,1602304287L,10497348917L,69253008919L,459673679526L,3067621127220L,20570132531365L,138528107124822L,936524246563021L,6353624897677005L,43242243814689566L,295161330408772329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144037Inst : IEnumerable<long>
{
public static readonly long[] Value=A144037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144037.Bytes);
public long this[int i]=>Value[i];

public static A144037Inst Instance=new A144037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144036
{
public static readonly long[] Value={ 0L,1L,1L,5L,19L,89L,410L,2052L,10440L,54874L,293549L,1597621L,8807766L,49107289L,276358791L,1567866228L,8957204966L,51486464912L,297548288251L,1727856600935L,10076859047404L,58996263573440L,346614270372761L,2042929868812385L,12076076910981403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144036Inst : IEnumerable<long>
{
public static readonly long[] Value=A144036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144036.Bytes);
public long this[int i]=>Value[i];

public static A144036Inst Instance=new A144036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144035
{
public static readonly long[] Value={ 0L,1L,1L,4L,13L,51L,197L,828L,3526L,15538L,69627L,317564L,1466868L,6853320L,32317354L,153636769L,735493374L,3542610091L,17155811156L,83480667707L,407969449010L,2001479974330L,9853652529076L,48666276924852L,241059431701113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144035Inst : IEnumerable<long>
{
public static readonly long[] Value=A144035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144035.Bytes);
public long this[int i]=>Value[i];

public static A144035Inst Instance=new A144035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144034
{
public static readonly long[] Value={ 1L,4L,1L,4L,4L,5L,4L,4L,20L,13L,4L,4L,20L,52L,41L,4L,4L,20L,52L,164L,121L,4L,4L,20L,52L,164L,484L,365L,4L,4L,20L,52L,164L,484L,1460L,1093L,4L,4L,20L,52L,164484L,1460L,4372L,3281L,4L,4L,20L,52L,164L,484L,1460L,4372L,13124L,9841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144034Inst : IEnumerable<long>
{
public static readonly long[] Value=A144034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144034.Bytes);
public long this[int i]=>Value[i];

public static A144034Inst Instance=new A144034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144033
{
public static readonly BigInteger[] Value={ 0L,3L,17L,334L,112832L,12731511431L,BigInteger.Parse("162091383368609713273"),BigInteger.Parse("26273616562349605559829539370677711225282"),BigInteger.Parse("690302927265371504697931559060001667258234745558232348693699327367035940600880144") };
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
public class A144033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144033Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144033.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144033.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144033Inst Instance=new A144033Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144032
{
public static readonly long[] Value={ 1L,0L,1L,-1L,0L,1L,-1L,-1L,0L,0L,-2L,-1L,-1L,0L,-2L,-1L,-2L,-1L,0L,0L,-6L,-2L,-1L,-2L,0L,2L,0L,-10L,-2L,-2L,-1L,0L,2L,6L,0L,-13L,-2L,-2L,-2L,0L,46L,10L,0L,-10L,-1L,-2L,-2L,0L,2L,12L,10L,13L,0L,4L,-2L,-1L,-2L,0L,4L,6L,10L,13L,10L,0L,36L,-2L,-2L,-1L,0L,4L,12L,10L,26L,10L,-4L,0L,84L,-3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144032Inst : IEnumerable<long>
{
public static readonly long[] Value=A144032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144032.Bytes);
public long this[int i]=>Value[i];

public static A144032Inst Instance=new A144032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144031
{
public static readonly long[] Value={ 1L,1L,0L,-2L,-6L,-10L,-13L,-10L,4L,36L,84L,137L,159L,94L,-133L,-573L,-1197L,-1788L,-1864L,-647L,2741L,8784L,16631L,22920L,20769L,87L,-49372L,-130497L,-226511L,-286165L,-214344L,117678L,822398L,1889427L,3022590L,3465187L,1927286L,-3188290L,-13016609L,-26739085L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144031Inst : IEnumerable<long>
{
public static readonly long[] Value=A144031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144031.Bytes);
public long this[int i]=>Value[i];

public static A144031Inst Instance=new A144031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144030
{
public static readonly BigInteger[] Value={ 0L,3L,-7L,54L,2640L,6958919L,48426525812673L,BigInteger.Parse("2345128402285290656984153898"),BigInteger.Parse("5499627223205160049118948689859558542158150443011978304"),BigInteger.Parse("30245899594219299311455265405538113849524609153510746835960216383169646549087764034230396364535519051718802475") };
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
public class A144030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144030Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144030.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144030.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144030Inst Instance=new A144030Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144029
{
public static readonly long[] Value={ 1L,-2L,1L,-3L,-2L,-1L,0L,-3L,2L,-6L,-5L,0L,3L,12L,-7L,6L,-5L,0L,18L,14L,3L,-7L,6L,5L,0L,21L,-6L,36L,0L,-7L,-6L,30L,0L,-9L,-72L,55L,0L,0L,7L,-36L,35L,0L,-108L,-110L,-9L,10L,0L,0L,42L,-42L,-15L,0L,-165L,18L,-221L,-11L,10L,0L,0L,49L,18L,-180L,0L,27L,442L,-373L,0L,-11L,-10L,0L,0L,-21L,216L,-275L,0L,663L,746L,-18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144029Inst : IEnumerable<long>
{
public static readonly long[] Value=A144029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144029.Bytes);
public long this[int i]=>Value[i];

public static A144029Inst Instance=new A144029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144028
{
public static readonly long[] Value={ 1L,-1L,-6L,-7L,3L,36L,55L,-9L,-221L,-373L,-18L,1290L,2506L,643L,-7488L,-16487L,-7258L,42577L,106701L,65695L,-236923L,-681856L,-534130L,1282512L,4304675L,4079414L,-6687222L,-26866199L,-29871373L,33019148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144028Inst : IEnumerable<long>
{
public static readonly long[] Value=A144028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144028.Bytes);
public long this[int i]=>Value[i];

public static A144028Inst Instance=new A144028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144027
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,2L,1L,0L,2L,3L,0L,1L,0L,3L,6L,0L,0L,2L,0L,6L,10L,1L,0L,0L,3L,0L,10L,18L,1L,1L,0L,0L,6L,0L,18L,32L,0L,1L,2L,0L,0L,10L,0L,32L,58L,0L,0L,2L,3L,0L,0L,18L,0L,58L,103L,1L,0L,0L,3L,6L,0L,0L,32L,0L,103L,184L,0L,1L,0L,0L,6L,10L,0L,0L,58L,0L,184L,329L,1L,0L,2L,0L,0L,10L,18L,0L,0L,103L,329L,588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144027Inst : IEnumerable<long>
{
public static readonly long[] Value=A144027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144027.Bytes);
public long this[int i]=>Value[i];

public static A144027Inst Instance=new A144027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144026
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,10L,18L,32L,58L,103L,184L,329L,588L,1051L,1878L,3357L,6000L,10723L,19164L,34251L,61214L,109404L,195530L,349458L,624562L,1116237L,1994974L,3565481L,6372340L,11388848L,20354510L,36378224L,65016314L,116199213L,207674912L,371163175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144026Inst : IEnumerable<long>
{
public static readonly long[] Value=A144026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144026.Bytes);
public long this[int i]=>Value[i];

public static A144026Inst Instance=new A144026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144025
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,4L,2L,2L,5L,9L,4L,4L,5L,13L,21L,9L,8L,10L,13L,35L,51L,21L,18L,20L,26L,35L,96L,127L,51L,42L,45L,52L,70L,96L,267L,323L,127L,102L,105L,117L,140L,192L,267L,750L,835L,323L,254L,255L,273L,315L,384L,534L,720L,2123L,2188L,835L,646L,635L,663L,735L,864L,1068L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144025Inst : IEnumerable<long>
{
public static readonly long[] Value=A144025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144025.Bytes);
public long this[int i]=>Value[i];

public static A144025Inst Instance=new A144025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144024
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,1L,0L,2L,0L,1L,1L,0L,4L,1L,0L,1L,2L,0L,6L,0L,1L,0L,2L,4L,0L,10L,1L,0L,1L,0L,4L,6L,0L,17L,1L,1L,0L,20L,6L,10L,0L,29L,0L,1L,1L,0L,4L,0L,10L,17L,0L,4L,9L,1L,0L,1L,2L,0L,6L,0L,17L,29L,0L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144024Inst : IEnumerable<long>
{
public static readonly long[] Value=A144024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144024.Bytes);
public long this[int i]=>Value[i];

public static A144024Inst Instance=new A144024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143991
{
public static readonly BigInteger[] Value={ 1L,1L,1L,7L,37L,133L,2431L,27007L,176761L,5329837L,12994393L,866792053L,5213746711L,841146804577L,10532583170701L,569600638022431L,16539483668991901L,3333075288160853L,16955228098102446847UL,932411737877492011L,BigInteger.Parse("10996483739066355827053"),BigInteger.Parse("66024590609554132070857") };
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
public class A143991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143991Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143991.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143991.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143991Inst Instance=new A143991Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143990
{
public static readonly BigInteger[] Value={ 1L,1L,4L,42L,888L,31920L,1750320L,136115280L,14254007040L,1934091250560L,330078373228800L,69199130042380800L,17481751115946163200UL,BigInteger.Parse("5237838647954514201600"),BigInteger.Parse("1836425205487182172262400"),BigInteger.Parse("744852154338379227748608000"),BigInteger.Parse("346052141662324885396697088000"),BigInteger.Parse("182572078442025253754006986752000") };
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
public class A143990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143990Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143990.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143990.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143990Inst Instance=new A143990Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143989
{
public static readonly long[] Value={ 2L,4L,5L,8L,9L,13L,15L,16L,22L,24L,26L,31L,36L,37L,40L,46L,49L,50L,55L,61L,70L,74L,76L,81L,82L,94L,99L,100L,106L,115L,120L,127L,133L,136L,142L,144L,145L,154L,159L,166L,170L,178L,184L,202L,205L,219L,221L,225L,235L,246L,250L,253L,256L,265L,268L,274L,295L,298L,301L,310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143989Inst : IEnumerable<long>
{
public static readonly long[] Value=A143989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143989.Bytes);
public long this[int i]=>Value[i];

public static A143989Inst Instance=new A143989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143988
{
public static readonly long[] Value={ 5L,13L,23L,31L,41L,49L,59L,67L,77L,85L,95L,103L,113L,121L,131L,139L,149L,157L,167L,175L,185L,193L,203L,211L,221L,229L,239L,247L,257L,265L,275L,283L,293L,301L,311L,319L,329L,337L,347L,355L,365L,373L,383L,391L,401L,409L,419L,427L,437L,445L,455L,463L,473L,481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143988Inst : IEnumerable<long>
{
public static readonly long[] Value=A143988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143988.Bytes);
public long this[int i]=>Value[i];

public static A143988Inst Instance=new A143988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143987
{
public static readonly long[] Value={ 1L,-1L,1L,1L,2L,0L,-1L,3L,0L,-1L,1L,-4L,0L,4L,1L,-1L,5L,0L,-10L,-5L,2L,1L,-6L,0L,20L,15L,-12L,-9L,-1L,7L,0L,-35L,-35L,42L,63L,9L,1L,-8L,0L,56L,70L,-112L,-252L,-72L,50L,-1L,9L,0L,-84L,-126L,252L,756L,324L,-450L,-267L,1L,-10L,0L,120L,210L,-504L,-1890L,-1080L,2250L,2670L,413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143987Inst : IEnumerable<long>
{
public static readonly long[] Value=A143987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143987.Bytes);
public long this[int i]=>Value[i];

public static A143987Inst Instance=new A143987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143986
{
public static readonly long[] Value={ 1L,2L,4L,3L,12L,4L,32L,5L,9L,12L,96L,6L,240L,32L,12L,5L,640L,9L,1280L,12L,32L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143986Inst : IEnumerable<long>
{
public static readonly long[] Value=A143986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143986.Bytes);
public long this[int i]=>Value[i];

public static A143986Inst Instance=new A143986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143985
{
public static readonly BigInteger[] Value={ 0L,3L,23L,622L,389372L,151612111871L,BigInteger.Parse("22986232466591067568123"),BigInteger.Parse("528366883008165274204418444362589201516015618"),BigInteger.Parse("279171563059764209960524428253973697688487588192684862752843397296212343984911360083984392") };
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
public class A143985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143985Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143985.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143985.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143985Inst Instance=new A143985Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143984
{
public static readonly BigInteger[] Value={ 0L,3L,-1L,6L,12L,95L,8643L,74666874L,5575141774264376L,BigInteger.Parse("31082205803147712138788845611867"),BigInteger.Parse("966103517589229313003894215813508352493573272034098666228778215") };
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
public class A143984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143984Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143984.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143984.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143984Inst Instance=new A143984Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143983
{
public static readonly long[] Value={ 1L,2L,1L,5L,1L,1L,15L,2L,1L,1L,52L,5L,1L,1L,1L,203L,13L,2L,1L,1L,1L,877L,36L,6L,1L,1L,1L,1L,4140L,109L,17L,2L,1L,1L,1L,1L,21147L,359L,44L,7L,1L,1L,1L,1L,1L,115975L,1266L,112L,23L,2L,1L,1L,1L,1L,1L,678570L,4731L,304L,65L,8L,1L,1L,1L,1L,1L,1L,4213597L,18657L,918L,165L,30L,2L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143983Inst : IEnumerable<long>
{
public static readonly long[] Value=A143983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143983.Bytes);
public long this[int i]=>Value[i];

public static A143983Inst Instance=new A143983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143982
{
public static readonly long[] Value={ 0L,0L,1L,4L,10L,20L,36L,64L,120L,240L,496L,1024L,2080L,4160L,8255L,16368L,32504L,64464L,126940L,246640L,470536L,879056L,1607862L,2886800L,5117800L,9046960L,16166475L,29666676L,56666754L,113330260L,236315636L,507817728L,1109184992L,2433554624L,5318390075L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143982Inst : IEnumerable<long>
{
public static readonly long[] Value=A143982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143982.Bytes);
public long this[int i]=>Value[i];

public static A143982Inst Instance=new A143982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143981
{
public static readonly long[] Value={ 1L,3L,6L,9L,15L,19L,26L,36L,46L,59L,80L,100L,128L,167L,211L,267L,341L,429L,541L,682L,850L,1063L,1327L,1647L,2035L,2520L,3100L,3810L,4669L,5708L,6955L,8468L,10267L,12441L,15026L,18120L,21788L,26175L,31355L,37510L,44769L,53362L,63460L,75384L,89348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143981Inst : IEnumerable<long>
{
public static readonly long[] Value=A143981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143981.Bytes);
public long this[int i]=>Value[i];

public static A143981Inst Instance=new A143981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143980
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,6L,21L,56L,126L,252L,462L,792L,1288L,2016L,3108L,4928L,8569L,17154L,38931L,94164L,229824L,550088L,1278662L,2884752L,6335005L,13590930L,28575315L,59014620L,119878606L,239662236L,471605976L,913302656L,1740247806L,3262146492L,6015853242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143980Inst : IEnumerable<long>
{
public static readonly long[] Value=A143980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143980.Bytes);
public long this[int i]=>Value[i];

public static A143980Inst Instance=new A143980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143979
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,2L,4L,4L,2L,3L,5L,6L,5L,3L,4L,6L,8L,8L,6L,4L,4L,8L,10L,10L,10L,8L,4L,5L,9L,12L,13L,13L,12L,9L,5L,6L,10L,14L,16L,16L,16L,14L,10L,6L,6L,12L,16L,18L,20L,20L,18L,16L,12L,6L,7L,13L,18L,21L,23L,24L,23L,21L,18L,13L,7L,8L,14L,20L,24L,26L,28L,28L,26L,24L,20L,14L,8L,8L,16L,22L,26L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143979Inst : IEnumerable<long>
{
public static readonly long[] Value=A143979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143979.Bytes);
public long this[int i]=>Value[i];

public static A143979Inst Instance=new A143979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143978
{
public static readonly long[] Value={ 1L,4L,8L,13L,20L,28L,37L,48L,60L,73L,88L,104L,121L,140L,160L,181L,204L,228L,253L,280L,308L,337L,368L,400L,433L,468L,504L,541L,580L,620L,661L,704L,748L,793L,840L,888L,937L,988L,1040L,1093L,1148L,1204L,1261L,1320L,1380L,1441L,1504L,1568L,1633L,1700L,1768L,1837L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143978Inst : IEnumerable<long>
{
public static readonly long[] Value=A143978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143978.Bytes);
public long this[int i]=>Value[i];

public static A143978Inst Instance=new A143978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143977
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,3L,3L,3L,2L,2L,4L,4L,4L,4L,2L,3L,4L,5L,6L,5L,4L,3L,3L,5L,6L,7L,7L,6L,5L,3L,3L,6L,7L,8L,9L,8L,7L,6L,3L,4L,6L,8L,10L,10L,10L,10L,8L,6L,4L,4L,7L,9L,11L,12L,12L,12L,11L,9L,7L,4L,4L,8L,10L,12L,14L,14L,14L,14L,12L,10L,8L,4L,5L,8L,11L,14L,15L,16L,17L,16L,15L,14L,11L,8L,5L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143977Inst : IEnumerable<long>
{
public static readonly long[] Value=A143977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143977.Bytes);
public long this[int i]=>Value[i];

public static A143977Inst Instance=new A143977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143976
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,2L,3L,4L,4L,3L,4L,6L,6L,6L,4L,4L,7L,8L,8L,7L,4L,5L,8L,10L,11L,10L,8L,5L,6L,10L,12L,14L,14L,12L,10L,6L,6L,11L,14L,16L,17L,16L,14L,11L,6L,7L,12L,16L,19L,20L,20L,19L,16L,12L,7L,8L,14L,18L,22L,24L,24L,24L,22L,18L,14L,8L,8L,15L,20L,24L,27L,28L,28L,27L,24L,20L,15L,8L,9L,16L,22L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143976Inst : IEnumerable<long>
{
public static readonly long[] Value=A143976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143976.Bytes);
public long this[int i]=>Value[i];

public static A143976Inst Instance=new A143976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143911
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,3L,1L,9L,12L,16L,1L,25L,60L,80L,125L,1L,75L,330L,480L,750L,1296L,1L,231L,1680L,3920L,5250L,9072L,16807L,1L,763L,9408L,33600L,49000L,72576L,134456L,262144L,1L,2619L,56952L,254016L,598500L,762048L,1210104L,2359296L,4782969L,1L,9495L,348120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143911Inst : IEnumerable<long>
{
public static readonly long[] Value=A143911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143911.Bytes);
public long this[int i]=>Value[i];

public static A143911Inst Instance=new A143911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143910
{
public static readonly long[] Value={ 597433L,1218277L,78432313L,163484407L,229205803L,301551427L,384490507L,629522587L,692824057L,893222647L,906769117L,1002618037L,1113319447L,1177252693L,1218963517L,1271129953L,1296796477L,1600630333L,1735141783L,1923577987L,2044791673L,2212880077L,2582822587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143910Inst : IEnumerable<long>
{
public static readonly long[] Value=A143910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143910.Bytes);
public long this[int i]=>Value[i];

public static A143910Inst Instance=new A143910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143909
{
public static readonly long[] Value={ 2L,5L,6L,9L,10L,11L,12L,13L,14L,23L,27L,29L,30L,35L,37L,38L,39L,41L,42L,43L,44L,45L,46L,47L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,95L,111L,119L,123L,125L,126L,135L,139L,141L,142L,147L,149L,150L,153L,154L,156L,159L,163L,165L,166L,169L,170L,172L,175L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143909Inst : IEnumerable<long>
{
public static readonly long[] Value=A143909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143909.Bytes);
public long this[int i]=>Value[i];

public static A143909Inst Instance=new A143909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143908
{
public static readonly long[] Value={ 1L,3L,1L,3L,3L,4L,3L,3L,12L,10L,3L,3L,12L,30L,28L,3L,3L,12L,30L,84L,76L,3L,3L,12L,30L,84L,228L,208L,3L,3L,12L,30L,84L,228L,624L,568L,3L,3L,12L,30L,84L,228L,624L,1704L,1552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143908Inst : IEnumerable<long>
{
public static readonly long[] Value=A143908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143908.Bytes);
public long this[int i]=>Value[i];

public static A143908Inst Instance=new A143908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143907
{
public static readonly long[] Value={ 6L,10L,14L,15L,18L,20L,21L,22L,26L,28L,30L,33L,34L,35L,38L,39L,42L,44L,46L,50L,51L,52L,54L,55L,57L,58L,62L,65L,66L,68L,69L,70L,74L,75L,76L,77L,78L,82L,85L,86L,87L,88L,91L,92L,93L,94L,95L,98L,99L,100L,102L,104L,105L,106L,110L,111L,114L,115L,116L,117L,118L,119L,122L,123L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143907Inst : IEnumerable<long>
{
public static readonly long[] Value=A143907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143907.Bytes);
public long this[int i]=>Value[i];

public static A143907Inst Instance=new A143907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143906
{
public static readonly long[] Value={ 1001L,10011001L,10100101L,11000011L,100011110001L,100101101001L,100110011001L,101001100101L,101010010101L,101100001101L,110001100011L,110010010011L,110100001011L,111000000111L,1000011111100001L,1000101111010001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143906Inst : IEnumerable<long>
{
public static readonly long[] Value=A143906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143906.Bytes);
public long this[int i]=>Value[i];

public static A143906Inst Instance=new A143906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143905
{
public static readonly long[] Value={ 9L,153L,165L,195L,2289L,2409L,2457L,2661L,2709L,2829L,3171L,3219L,3339L,3591L,34785L,35793L,36273L,36465L,37833L,38313L,38505L,39321L,39513L,39993L,41925L,42405L,42597L,43413L,43605L,44085L,45453L,45645L,46125L,47133L,50115L,50595L,50787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143905Inst : IEnumerable<long>
{
public static readonly long[] Value=A143905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143905.Bytes);
public long this[int i]=>Value[i];

public static A143905Inst Instance=new A143905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143904
{
public static readonly long[] Value={ 0L,2L,4L,16L,26L,74L,106L,124L,184L,190L,224L,280L,410L,470L,496L,634L,644L,764L,766L,880L,896L,1126L,1196L,1424L,1430L,1616L,1694L,1706L,1786L,1820L,1876L,1964L,1970L,2210L,2216L,2294L,2494L,2746L,2816L,3010L,3026L,3284L,3464L,3574L,3616L,3794L,3820L,3854L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143904Inst : IEnumerable<long>
{
public static readonly long[] Value=A143904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143904.Bytes);
public long this[int i]=>Value[i];

public static A143904Inst Instance=new A143904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143903
{
public static readonly long[] Value={ 1L,4L,5L,6L,8L,14L,17L,18L,19L,20L,21L,22L,24L,25L,26L,27L,28L,30L,32L,34L,36L,40L,46L,48L,54L,58L,60L,66L,67L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,92L,93L,95L,96L,97L,98L,99L,100L,101L,102L,104L,105L,106L,108L,112L,113L,114L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143903Inst : IEnumerable<long>
{
public static readonly long[] Value=A143903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143903.Bytes);
public long this[int i]=>Value[i];

public static A143903Inst Instance=new A143903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143902
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,2L,3L,3L,2L,2L,4L,4L,4L,2L,3L,5L,6L,6L,5L,3L,3L,6L,7L,8L,7L,6L,3L,4L,7L,9L,10L,10L,9L,7L,4L,4L,8L,10L,12L,12L,12L,10L,8L,4L,5L,9L,12L,14L,15L,15L,14L,12L,9L,5L,5L,10L,13L,16L,17L,18L,17L,16L,13L,10L,5L,6L,11L,15L,18L,20L,21L,21L,20L,18L,15L,11L,6L,6L,12L,16L,20L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143902Inst : IEnumerable<long>
{
public static readonly long[] Value=A143902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143902.Bytes);
public long this[int i]=>Value[i];

public static A143902Inst Instance=new A143902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143901
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,2L,3L,3L,2L,3L,4L,5L,4L,3L,3L,5L,6L,6L,5L,3L,4L,6L,8L,8L,8L,6L,4L,4L,7L,9L,10L,10L,9L,7L,4L,5L,8L,11L,12L,13L,12L,11L,8L,5L,5L,9L,12L,14L,15L,15L,14L,12L,9L,5L,6L,10L,14L,16L,18L,18L,18L,16L,14L,10L,6L,6L,11L,15L,18L,20L,21L,21L,20L,18L,15L,11L,6L,7L,12L,17L,20L,23L,24L,25L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143901Inst : IEnumerable<long>
{
public static readonly long[] Value=A143901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143901.Bytes);
public long this[int i]=>Value[i];

public static A143901Inst Instance=new A143901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143900
{
public static readonly BigInteger[] Value={ 0L,0L,0L,1L,26L,733L,29836L,2060191L,267873508L,68709450231L,35184166480296L,36028792251523289L,BigInteger.Parse("73786976171465003256"),BigInteger.Parse("302231454900131663566437"),BigInteger.Parse("2475880078570650265515241808"),BigInteger.Parse("40564819207303337099536803011071"),BigInteger.Parse("1329227995784915872766249150185503728") };
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
public class A143900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143900Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143900.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143900.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143900Inst Instance=new A143900Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143899
{
public static readonly long[] Value={ 1L,4L,15L,6L,1L,10L,85L,252L,210L,120L,45L,10L,1L,20L,285L,1707L,5005L,6435L,6435L,5005L,3003L,1365L,455L,105L,15L,1L,35L,735L,6972L,37457L,116280L,203490L,293930L,352716L,352716L,293930L,203490L,116280L,54264L,20349L,5985L,1330L,210L,21L,1L,56L,1610L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143899Inst : IEnumerable<long>
{
public static readonly long[] Value=A143899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143899.Bytes);
public long this[int i]=>Value[i];

public static A143899Inst Instance=new A143899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143898
{
public static readonly long[] Value={ 1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,3L,1L,1L,1L,3L,2L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,1L,1L,3L,2L,1L,2L,3L,2L,1L,3L,1L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,3L,2L,2L,2L,2L,1L,2L,2L,3L,2L,3L,3L,1L,4L,2L,3L,2L,1L,3L,2L,3L,2L,2L,2L,4L,1L,4L,2L,2L,2L,2L,3L,2L,3L,2L,4L,3L,2L,3L,3L,3L,3L,1L,3L,3L,2L,3L,3L,2L,3L,5L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143898Inst : IEnumerable<long>
{
public static readonly long[] Value=A143898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143898.Bytes);
public long this[int i]=>Value[i];

public static A143898Inst Instance=new A143898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143897
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,6L,4L,1L,16L,32L,44L,60L,70L,56L,28L,8L,1L,128L,448L,864L,1552L,2720L,4288L,6312L,9004L,11992L,14372L,15400L,14630L,11968L,8104L,4376L,1820L,560L,120L,16L,1L,4096L,22528L,67584L,159744L,334080L,644992L,1195008L,2158912L,3811904L,6617184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143897Inst : IEnumerable<long>
{
public static readonly long[] Value=A143897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143897.Bytes);
public long this[int i]=>Value[i];

public static A143897Inst Instance=new A143897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143896
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,9L,10L,12L,14L,16L,18L,20L,24L,25L,28L,30L,32L,36L,40L,42L,44L,48L,54L,56L,60L,64L,66L,70L,72L,80L,81L,84L,90L,96L,100L,108L,112L,120L,126L,132L,140L,144L,150L,156L,160L,162L,168L,176L,180L,192L,196L,208L,210L,216L,225L,240L,252L,256L,264L,270L,272L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143896Inst : IEnumerable<long>
{
public static readonly long[] Value=A143896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143896.Bytes);
public long this[int i]=>Value[i];

public static A143896Inst Instance=new A143896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143863
{
public static readonly long[] Value={ 13L,17L,31L,53L,71L,79L,97L,103L,107L,211L,233L,251L,277L,349L,367L,431L,439L,457L,503L,521L,547L,619L,673L,691L,701L,709L,727L,853L,907L,997L,1021L,1061L,1069L,1087L,1151L,1201L,1223L,1249L,1429L,1447L,1483L,1511L,1601L,1609L,1627L,1663L,1699L,1753L,1789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143863Inst : IEnumerable<long>
{
public static readonly long[] Value=A143863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143863.Bytes);
public long this[int i]=>Value[i];

public static A143863Inst Instance=new A143863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143862
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,3L,1L,4L,2L,5L,1L,9L,1L,7L,7L,9L,1L,19L,1L,14L,16L,11L,1L,43L,2L,13L,29L,34L,1L,56L,1L,51L,46L,17L,16L,130L,1L,19L,67L,139L,1L,105L,1L,142L,162L,23L,1L,315L,2L,151L,121L,246L,1L,219L,211L,321L,154L,29L,1L,1021L,1L,31L,219L,488L,496L,495L,1L,594L,232L,834L,1L,1439L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143862Inst : IEnumerable<long>
{
public static readonly long[] Value=A143862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143862.Bytes);
public long this[int i]=>Value[i];

public static A143862Inst Instance=new A143862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143861
{
public static readonly long[] Value={ 1L,14L,59L,136L,245L,386L,559L,764L,1001L,1270L,1571L,1904L,2269L,2666L,3095L,3556L,4049L,4574L,5131L,5720L,6341L,6994L,7679L,8396L,9145L,9926L,10739L,11584L,12461L,13370L,14311L,15284L,16289L,17326L,18395L,19496L,20629L,21794L,22991L,24220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143861Inst : IEnumerable<long>
{
public static readonly long[] Value=A143861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143861.Bytes);
public long this[int i]=>Value[i];

public static A143861Inst Instance=new A143861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143860
{
public static readonly long[] Value={ 1L,16L,63L,142L,253L,396L,571L,778L,1017L,1288L,1591L,1926L,2293L,2692L,3123L,3586L,4081L,4608L,5167L,5758L,6381L,7036L,7723L,8442L,9193L,9976L,10791L,11638L,12517L,13428L,14371L,15346L,16353L,17392L,18463L,19566L,20701L,21868L,23067L,24298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143860Inst : IEnumerable<long>
{
public static readonly long[] Value=A143860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143860.Bytes);
public long this[int i]=>Value[i];

public static A143860Inst Instance=new A143860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143859
{
public static readonly long[] Value={ 1L,18L,67L,148L,261L,406L,583L,792L,1033L,1306L,1611L,1948L,2317L,2718L,3151L,3616L,4113L,4642L,5203L,5796L,6421L,7078L,7767L,8488L,9241L,10026L,10843L,11692L,12573L,13486L,14431L,15408L,16417L,17458L,18531L,19636L,20773L,21942L,23143L,24376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143859Inst : IEnumerable<long>
{
public static readonly long[] Value=A143859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143859.Bytes);
public long this[int i]=>Value[i];

public static A143859Inst Instance=new A143859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143858
{
public static readonly long[] Value={ 1L,3L,1L,6L,5L,1L,10L,15L,7L,1L,15L,35L,28L,9L,1L,21L,70L,84L,45L,11L,1L,28L,126L,210L,165L,66L,13L,1L,36L,210L,462L,495L,286L,91L,15L,1L,45L,330L,924L,1287L,1001L,455L,120L,17L,1L,55L,495L,1716L,3003L,3003L,1820L,680L,153L,19L,1L,66L,715L,3003L,6435L,8008L,6188L,3060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143858Inst : IEnumerable<long>
{
public static readonly long[] Value=A143858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143858.Bytes);
public long this[int i]=>Value[i];

public static A143858Inst Instance=new A143858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143857
{
public static readonly BigInteger[] Value={ 8L,163L,3074L,62503L,1399684L,34588811L,939524102L,27894275215L,900000000008L,31384283767219L,1176925259169802L,47248516628391479L,2022385242251558924L,BigInteger.Parse("91957716979980468763"),BigInteger.Parse("4427218577690292387854"),BigInteger.Parse("225009351233083599856159") };
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
public class A143857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143857Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143857.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143857.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143857Inst Instance=new A143857Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143856
{
public static readonly long[] Value={ 1L,12L,55L,130L,237L,376L,547L,750L,985L,1252L,1551L,1882L,2245L,2640L,3067L,3526L,4017L,4540L,5095L,5682L,6301L,6952L,7635L,8350L,9097L,9876L,10687L,11530L,12405L,13312L,14251L,15222L,16225L,17260L,18327L,19426L,20557L,21720L,22915L,24142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143856Inst : IEnumerable<long>
{
public static readonly long[] Value=A143856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143856.Bytes);
public long this[int i]=>Value[i];

public static A143856Inst Instance=new A143856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143855
{
public static readonly long[] Value={ 1L,10L,51L,124L,229L,366L,535L,736L,969L,1234L,1531L,1860L,2221L,2614L,3039L,3496L,3985L,4506L,5059L,5644L,6261L,6910L,7591L,8304L,9049L,9826L,10635L,11476L,12349L,13254L,14191L,15160L,16161L,17194L,18259L,19356L,20485L,21646L,22839L,24064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143855Inst : IEnumerable<long>
{
public static readonly long[] Value=A143855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143855.Bytes);
public long this[int i]=>Value[i];

public static A143855Inst Instance=new A143855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143854
{
public static readonly long[] Value={ 1L,20L,71L,154L,269L,416L,595L,806L,1049L,1324L,1631L,1970L,2341L,2744L,3179L,3646L,4145L,4676L,5239L,5834L,6461L,7120L,7811L,8534L,9289L,10076L,10895L,11746L,12629L,13544L,14491L,15470L,16481L,17524L,18599L,19706L,20845L,22016L,23219L,24454L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143854Inst : IEnumerable<long>
{
public static readonly long[] Value=A143854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143854.Bytes);
public long this[int i]=>Value[i];

public static A143854Inst Instance=new A143854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143853
{
public static readonly long[] Value={ 2L,3L,23L,53L,613L,490537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143853Inst : IEnumerable<long>
{
public static readonly long[] Value=A143853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143853.Bytes);
public long this[int i]=>Value[i];

public static A143853Inst Instance=new A143853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143852
{
public static readonly long[] Value={ 6L,8L,1L,16L,16L,13L,21L,20L,13L,34L,7L,17L,36L,37L,17L,27L,5L,13L,3L,29L,28L,6L,30L,8L,17L,66L,9L,1L,47L,52L,89L,8L,14L,77L,41L,81L,6L,31L,1L,1L,91L,8L,124L,13L,31L,13L,82L,17L,55L,69L,103L,10L,13L,100L,119L,18L,155L,6L,91L,40L,111L,11L,32L,55L,9L,10L,15L,37L,10L,115L,23L,124L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143852Inst : IEnumerable<long>
{
public static readonly long[] Value=A143852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143852.Bytes);
public long this[int i]=>Value[i];

public static A143852Inst Instance=new A143852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143851
{
public static readonly long[] Value={ 2L,13L,167L,2239L,439867L,724031017L,1990127567L,54892225873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143851Inst : IEnumerable<long>
{
public static readonly long[] Value=A143851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143851.Bytes);
public long this[int i]=>Value[i];

public static A143851Inst Instance=new A143851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143850
{
public static readonly long[] Value={ 9L,17L,25L,29L,37L,49L,65L,73L,85L,89L,97L,109L,121L,145L,149L,157L,169L,185L,193L,205L,229L,241L,265L,269L,277L,289L,325L,349L,361L,409L,425L,433L,445L,481L,485L,493L,505L,529L,541L,565L,601L,625L,661L,685L,689L,697L,709L,745L,769L,829L,841L,845L,853L,865L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143850Inst : IEnumerable<long>
{
public static readonly long[] Value=A143850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143850.Bytes);
public long this[int i]=>Value[i];

public static A143850Inst Instance=new A143850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143849
{
public static readonly BigInteger[] Value={ 0L,1L,3L,1L,-17L,-2719L,-33231617L,-1990664248298239L,BigInteger.Parse("825155821714086784897292716543"),BigInteger.Parse("-6468873315977272230111786035347284128217298704834756326835199") };
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
public class A143849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143849Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143849.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143849.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143849Inst Instance=new A143849Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143848
{
public static readonly BigInteger[] Value={ 1L,1L,0L,-9L,80L,6111L,29951360L,-207256402585089L,BigInteger.Parse("-3919788933040280447085605363200"),BigInteger.Parse("14683863149476410414382246646213355893861151824423487368369151") };
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
public class A143848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143848Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143848.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143848.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143848Inst Instance=new A143848Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143815
{
public static readonly long[] Value={ 1L,0L,0L,1L,6L,25L,91L,322L,1232L,5672L,32202L,209143L,1432454L,9942517L,69363840L,490303335L,3565609732L,27118060170L,218183781871L,1861370544934L,16729411124821L,156706028787827L,1514442896327792L,14999698898942772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143815Inst : IEnumerable<long>
{
public static readonly long[] Value=A143815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143815.Bytes);
public long this[int i]=>Value[i];

public static A143815Inst Instance=new A143815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143814
{
public static readonly long[] Value={ 3L,5L,8L,12L,7L,15L,21L,16L,9L,24L,32L,27L,20L,11L,35L,45L,40L,33L,24L,13L,48L,60L,55L,48L,39L,28L,15L,63L,77L,72L,65L,56L,45L,32L,17L,80L,96L,91L,84L,75L,64L,51L,36L,19L,99L,117L,112L,105L,96L,85L,72L,57L,40L,21L,120L,140L,135L,128L,119L,108L,95L,80L,63L,44L,23L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143814Inst : IEnumerable<long>
{
public static readonly long[] Value=A143814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143814.Bytes);
public long this[int i]=>Value[i];

public static A143814Inst Instance=new A143814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143813
{
public static readonly long[] Value={ 8L,12L,13L,16L,17L,18L,20L,24L,25L,29L,31L,32L,33L,34L,35L,36L,40L,41L,43L,44L,45L,48L,50L,52L,53L,54L,57L,58L,59L,61L,63L,64L,65L,68L,72L,73L,74L,76L,80L,81L,85L,88L,89L,90L,91L,96L,97L,98L,99L,100L,104L,106L,108L,109L,112L,113L,116L,117L,121L,124L,125L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143813Inst : IEnumerable<long>
{
public static readonly long[] Value=A143813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143813.Bytes);
public long this[int i]=>Value[i];

public static A143813Inst Instance=new A143813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143812
{
public static readonly long[] Value={ 1L,2L,8L,8L,8L,9L,17L,17L,20L,20L,20L,20L,20L,20L,20L,20L,20L,21L,21L,21L,21L,21L,21L,21L,24L,24L,112L,112L,112L,112L,112L,112L,112L,112L,112L,112L,112L,112L,112L,112L,112L,112L,112L,112L,112L,112L,112L,112L,112L,112L,112L,112L,112L,113L,113L,113L,113L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143812Inst : IEnumerable<long>
{
public static readonly long[] Value=A143812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143812.Bytes);
public long this[int i]=>Value[i];

public static A143812Inst Instance=new A143812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143811
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,1L,3L,1L,2L,1L,1L,2L,1L,2L,1L,2L,2L,3L,3L,2L,1L,1L,2L,1L,3L,1L,1L,1L,2L,2L,1L,2L,2L,3L,2L,1L,3L,2L,1L,2L,1L,2L,2L,4L,1L,1L,2L,2L,2L,2L,1L,3L,1L,4L,1L,3L,3L,3L,3L,3L,2L,2L,1L,1L,2L,2L,1L,2L,2L,1L,2L,2L,1L,2L,1L,2L,3L,1L,1L,5L,1L,2L,1L,3L,2L,2L,1L,2L,2L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143811Inst : IEnumerable<long>
{
public static readonly long[] Value=A143811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143811.Bytes);
public long this[int i]=>Value[i];

public static A143811Inst Instance=new A143811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143810
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,2L,1L,1L,0L,3L,1L,0L,0L,0L,5L,1L,1L,2L,0L,0L,6L,1L,0L,0L,0L,0L,0L,10L,1L,1L,0L,3L,0L,0L,0L,11L,1L,0L,2L,0L,0L,0L,0L,0L,16L,1L,1L,0L,0L,5L,0L,0L,0L,0L,19L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,26L,1L,1L,2L,3L,0L,6L,0L,0L,0L,0L,0L,27L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143810Inst : IEnumerable<long>
{
public static readonly long[] Value=A143810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143810.Bytes);
public long this[int i]=>Value[i];

public static A143810Inst Instance=new A143810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143809
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,0L,0L,0L,-1L,0L,-1L,-1L,0L,0L,0L,-2L,1L,-1L,0L,0L,0L,-3L,-1L,0L,0L,0L,0L,0L,-3L,0L,0L,0L,1L,0L,0L,0L,-4L,0L,0L,0L,0L,0L,0L,0L,0L,-3L,1L,-1L,0L,0L,2L,0L,0L,0L,0L,-3L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,1L,0L,1L,0L,3L,0L,0L,0L,0L,0L,-2L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,3L,1L,-1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143809Inst : IEnumerable<long>
{
public static readonly long[] Value=A143809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143809.Bytes);
public long this[int i]=>Value[i];

public static A143809Inst Instance=new A143809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143808
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,2L,4L,5L,1L,2L,4L,10L,12L,1L,2L,4L,10L,24L,29L,1L,2L,4L,10L,24L,58L,70L,1L,2L,4L,10L,24L,58L,140L,169L,1L,2L,4L,10L,24L,58L,140L,338L,408L,1L,2L,4L,10L,24L,58L,140L,338L,816L,985L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143808Inst : IEnumerable<long>
{
public static readonly long[] Value=A143808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143808.Bytes);
public long this[int i]=>Value[i];

public static A143808Inst Instance=new A143808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143807
{
public static readonly long[] Value={ 1L,2L,2L,22L,40L,18L,2468L,11698L,11426L,2178L,74056628L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143807Inst : IEnumerable<long>
{
public static readonly long[] Value=A143807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143807.Bytes);
public long this[int i]=>Value[i];

public static A143807Inst Instance=new A143807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143806
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,2L,6L,11L,12L,7L,24L,50L,70L,70L,36L,120L,274L,450L,595L,540L,250L,720L,1764L,3248L,5145L,6300L,5250L,2229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143806Inst : IEnumerable<long>
{
public static readonly long[] Value=A143806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143806.Bytes);
public long this[int i]=>Value[i];

public static A143806Inst Instance=new A143806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143805
{
public static readonly BigInteger[] Value={ 1L,1L,2L,7L,36L,250L,2229L,24656L,329883L,5233837L,96907908L,2066551242L,50196458429L,1375782397859L,42203985613593L,1438854199059479L,54180508061067099L,2241000820010271224L,BigInteger.Parse("101316373253530824771") };
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
public class A143805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143805Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143805.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143805.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143805Inst Instance=new A143805Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143804
{
public static readonly long[] Value={ 1L,4L,10L,13L,19L,25L,28L,34L,40L,46L,49L,55L,61L,67L,73L,76L,82L,88L,94L,100L,106L,109L,115L,121L,127L,133L,139L,145L,148L,154L,160L,166L,172L,178L,184L,190L,193L,199L,205L,211L,217L,223L,229L,235L,241L,244L,250L,256L,262L,268L,274L,280L,286L,292L,298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143804Inst : IEnumerable<long>
{
public static readonly long[] Value=A143804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143804.Bytes);
public long this[int i]=>Value[i];

public static A143804Inst Instance=new A143804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143803
{
public static readonly long[] Value={ 1L,3L,7L,9L,13L,17L,19L,23L,27L,31L,33L,37L,41L,45L,49L,51L,55L,59L,63L,67L,71L,73L,77L,81L,85L,89L,93L,97L,99L,103L,107L,111L,115L,119L,123L,127L,129L,133L,137L,141L,145L,149L,153L,157L,161L,163L,167L,171L,175L,179L,183L,187L,191L,195L,199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143803Inst : IEnumerable<long>
{
public static readonly long[] Value=A143803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143803.Bytes);
public long this[int i]=>Value[i];

public static A143803Inst Instance=new A143803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143802
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,3L,4L,1L,3L,7L,5L,1L,3L,7L,15L,6L,1L,3L,7L,15L,31L,7L,1L,3L,7L,15L,31L,63L,8L,1L,3L,7L,15L,31L,63L,127L,9L,1L,3L,7L,15L,31L,63L,127L,255L,10L,1L,3L,7L,15L,31L,63L,127L,255L,511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143802Inst : IEnumerable<long>
{
public static readonly long[] Value=A143802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143802.Bytes);
public long this[int i]=>Value[i];

public static A143802Inst Instance=new A143802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143801
{
public static readonly long[] Value={ 223L,359L,383L,449L,503L,547L,701L,797L,881L,1049L,1097L,1229L,1307L,1439L,1627L,1733L,1759L,1987L,1997L,2027L,2221L,2287L,2309L,2437L,2477L,2579L,2617L,2647L,2801L,2861L,2903L,2999L,3023L,3067L,3167L,3191L,3329L,3467L,3581L,3697L,3761L,3911L,3947L,4057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143801Inst : IEnumerable<long>
{
public static readonly long[] Value=A143801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143801.Bytes);
public long this[int i]=>Value[i];

public static A143801Inst Instance=new A143801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143800
{
public static readonly long[] Value={ 0L,12L,19L,24L,28L,31L,34L,36L,38L,40L,42L,43L,44L,46L,47L,48L,49L,50L,51L,52L,53L,54L,54L,55L,56L,56L,57L,58L,58L,59L,59L,60L,61L,61L,62L,62L,63L,63L,63L,64L,64L,65L,65L,66L,66L,66L,67L,67L,67L,68L,68L,68L,69L,69L,69L,70L,70L,70L,71L,71L,71L,71L,72L,72L,72L,73L,73L,73L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143800Inst : IEnumerable<long>
{
public static readonly long[] Value=A143800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143800.Bytes);
public long this[int i]=>Value[i];

public static A143800Inst Instance=new A143800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143767
{
public static readonly long[] Value={ 87L,33L,15L,9L,4L,3L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143767Inst : IEnumerable<long>
{
public static readonly long[] Value=A143767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143767.Bytes);
public long this[int i]=>Value[i];

public static A143767Inst Instance=new A143767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143766
{
public static readonly BigInteger[] Value={ 1L,5L,59L,4021L,16216709L,262981894041341L,BigInteger.Parse("69159476593575838635509822455"),BigInteger.Parse("4783033202697364284917104840982811414253511628131328498629"),BigInteger.Parse("22877406618105405861781317490149379589769149890660405723416585348109182559037843469373513563751798569651299138846801") };
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
public class A143766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143766Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143766.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143766.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143766Inst Instance=new A143766Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143765
{
public static readonly BigInteger[] Value={ 1L,-1L,11L,31L,605L,356975L,127424725111L,BigInteger.Parse("16237060566937994735039"),BigInteger.Parse("263642135854412795003324875413502371940690649"),BigInteger.Parse("69507175797876652622009028770643203522181284529919017784559264153993383198392412717393759") };
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
public class A143765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143765Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143765.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143765.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143765Inst Instance=new A143765Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143764
{
public static readonly BigInteger[] Value={ 1L,4L,36L,1521L,2325625L,5408554896900L,BigInteger.Parse("29252466072845872288372836"),BigInteger.Parse("855706771342998810018458679815602502067088579902649"),BigInteger.Parse("732234078522259249473123638277942895348884466303559008943210424176413224873174808848983192723595659649") };
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
public class A143764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143764Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143764.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143764.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143764Inst Instance=new A143764Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143763
{
public static readonly BigInteger[] Value={ 1L,0L,4L,1L,9L,16L,100L,8649L,74666881L,5575141774264384L,BigInteger.Parse("31082205803147712138788845611876"),BigInteger.Parse("966103517589229313003894215813508352493573272034098666228778225") };
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
public class A143763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143763Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143763.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143763.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143763Inst Instance=new A143763Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143762
{
public static readonly BigInteger[] Value={ 1L,3L,19L,427L,184053L,33876427099L,BigInteger.Parse("1147612313197120118431"),BigInteger.Parse("1317014021401644919149757309088631306730827"),BigInteger.Parse("1734525932568532421128602190712731410907662021613907396581559184320372648524685950609") };
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
public class A143762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143762Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143762.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143762.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143762Inst Instance=new A143762Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143761
{
public static readonly BigInteger[] Value={ 1L,1L,3L,9L,61L,3441L,11819871L,139709267717593L,BigInteger.Parse("19518679486184955909459972969"),BigInteger.Parse("380978848884417414427615903969045678210740619589070918321") };
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
public class A143761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143761Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143761.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143761.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143761Inst Instance=new A143761Inst();

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