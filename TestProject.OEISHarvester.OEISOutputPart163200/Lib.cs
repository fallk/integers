using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A287317
{
public static readonly BigInteger[] Value={ 1L,10L,270L,10900L,551950L,32232060L,2070891900L,142317232200L,10277494548750L,770878551371500L,59577647564312020L,4717432065143561400L,BigInteger.Parse("381091087190569291900"),BigInteger.Parse("31308955091335405435000"),BigInteger.Parse("2609450031306515140215000"),BigInteger.Parse("220199552765301571338488400") };
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
public class A287317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287317Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287317.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A287317.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287317Inst Instance=new A287317Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287318
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,0L,1L,4L,6L,0L,1L,6L,36L,20L,0L,1L,8L,90L,400L,70L,0L,1L,10L,168L,1860L,4900L,252L,0L,1L,12L,270L,5120L,44730L,63504L,924L,0L,1L,14L,396L,10900L,190120L,1172556L,853776L,3432L,0L,1L,16L,546L,19920L,551950L,7939008L,32496156L,11778624L,12870L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287318Inst : IEnumerable<long>
{
public static readonly long[] Value=A287318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287318.Bytes);
public long this[int i]=>Value[i];

public static A287318Inst Instance=new A287318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287319
{
public static readonly BigInteger[] Value={ 1L,3L,151L,26512143L,BigInteger.Parse("318400215865581346424671"),BigInteger.Parse("1240913164837493520914469575281720548839055905624577375251388717505927743") };
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
public class A287319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287319Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287319.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A287319.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287319Inst Instance=new A287319Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287385
{
public static readonly long[] Value={ 0L,1L,2L,2L,1L,0L,0L,2L,1L,0L,2L,1L,2L,1L,0L,0L,1L,2L,0L,1L,2L,0L,2L,1L,2L,1L,0L,0L,1L,2L,0L,2L,1L,2L,1L,0L,0L,2L,1L,2L,1L,0L,0L,1L,2L,0L,1L,2L,2L,1L,0L,0L,2L,1L,0L,1L,2L,2L,1L,0L,0L,2L,1L,0L,1L,2L,0L,2L,1L,2L,1L,0L,0L,2L,1L,2L,1L,0L,0L,1L,2L,0L,1L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287385Inst : IEnumerable<long>
{
public static readonly long[] Value=A287385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287385.Bytes);
public long this[int i]=>Value[i];

public static A287385Inst Instance=new A287385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287386
{
public static readonly long[] Value={ 1L,6L,7L,10L,15L,16L,19L,22L,27L,28L,31L,36L,37L,42L,43L,46L,51L,52L,55L,60L,61L,64L,67L,72L,73L,78L,79L,82L,87L,88L,91L,94L,99L,100L,105L,106L,109L,112L,117L,118L,123L,124L,127L,132L,133L,136L,141L,142L,145L,150L,151L,154L,157L,162L,163L,168L,169L,172L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287386Inst : IEnumerable<long>
{
public static readonly long[] Value=A287386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287386.Bytes);
public long this[int i]=>Value[i];

public static A287386Inst Instance=new A287386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287387
{
public static readonly long[] Value={ 2L,5L,9L,12L,14L,17L,20L,24L,26L,29L,33L,35L,39L,41L,44L,47L,50L,54L,56L,59L,63L,65L,69L,71L,75L,77L,80L,83L,86L,90L,92L,96L,98L,102L,104L,107L,110L,114L,116L,120L,122L,125L,128L,131L,135L,137L,140L,144L,147L,149L,152L,155L,159L,161L,164L,167L,171L,174L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287387Inst : IEnumerable<long>
{
public static readonly long[] Value=A287387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287387.Bytes);
public long this[int i]=>Value[i];

public static A287387Inst Instance=new A287387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287388
{
public static readonly long[] Value={ 3L,4L,8L,11L,13L,18L,21L,23L,25L,30L,32L,34L,38L,40L,45L,48L,49L,53L,57L,58L,62L,66L,68L,70L,74L,76L,81L,84L,85L,89L,93L,95L,97L,101L,103L,108L,111L,113L,115L,119L,121L,126L,129L,130L,134L,138L,139L,143L,146L,148L,153L,156L,158L,160L,165L,166L,170L,173L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287388Inst : IEnumerable<long>
{
public static readonly long[] Value=A287388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287388.Bytes);
public long this[int i]=>Value[i];

public static A287388Inst Instance=new A287388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287389
{
public static readonly long[] Value={ 0L,3L,8L,80L,99L,323L,360L,575L,840L,4224L,5775L,9999L,32760L,36480L,36863L,42024L,84680L,349280L,808200L,829920L,848240L,998000L,999999L,3055503L,3272480L,3426200L,3640463L,3644280L,3682560L,5597955L,8462280L,8803088L,30481440L,32855823L,80622440L,99999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287389Inst : IEnumerable<long>
{
public static readonly long[] Value=A287389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287389.Bytes);
public long this[int i]=>Value[i];

public static A287389Inst Instance=new A287389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287390
{
public static readonly long[] Value={ 121L,143L,187L,209L,221L,247L,299L,377L,403L,481L,533L,559L,611L,689L,767L,793L,871L,923L,949L,1027L,1079L,1157L,1261L,1313L,1339L,1391L,1417L,1469L,1651L,1703L,1781L,1807L,1937L,1963L,2041L,2119L,2171L,2197L,2249L,2329L,2363L,2533L,2567L,2669L,2771L,2839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287390Inst : IEnumerable<long>
{
public static readonly long[] Value=A287390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287390.Bytes);
public long this[int i]=>Value[i];

public static A287390Inst Instance=new A287390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287391
{
public static readonly long[] Value={ 1L,169L,289L,323L,361L,391L,437L,493L,527L,529L,551L,589L,629L,667L,697L,703L,713L,731L,779L,799L,817L,841L,851L,893L,899L,901L,943L,961L,989L,1003L,1007L,1037L,1073L,1081L,1121L,1139L,1147L,1159L,1189L,1207L,1219L,1241L,1247L,1271L,1273L,1333L,1343L,1349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287391Inst : IEnumerable<long>
{
public static readonly long[] Value=A287391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287391.Bytes);
public long this[int i]=>Value[i];

public static A287391Inst Instance=new A287391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287392
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,4L,4L,4L,4L,4L,9L,9L,9L,9L,9L,16L,16L,16L,16L,16L,25L,25L,25L,25L,25L,36L,36L,36L,36L,36L,49L,49L,49L,49L,49L,64L,64L,64L,64L,64L,81L,81L,81L,81L,81L,100L,100L,100L,100L,100L,121L,121L,121L,121L,121L,144L,144L,144L,144L,144L,169L,169L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287392Inst : IEnumerable<long>
{
public static readonly long[] Value=A287392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287392.Bytes);
public long this[int i]=>Value[i];

public static A287392Inst Instance=new A287392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287393
{
public static readonly long[] Value={ 0L,2L,4L,4L,4L,4L,4L,6L,8L,8L,8L,8L,8L,10L,12L,12L,12L,12L,12L,14L,16L,16L,16L,16L,16L,18L,20L,20L,20L,20L,20L,22L,24L,24L,24L,24L,24L,26L,28L,28L,28L,28L,28L,30L,32L,32L,32L,32L,32L,34L,36L,36L,36L,36L,36L,38L,40L,40L,40L,40L,40L,42L,44L,44L,44L,44L,44L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287393Inst : IEnumerable<long>
{
public static readonly long[] Value=A287393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287393.Bytes);
public long this[int i]=>Value[i];

public static A287393Inst Instance=new A287393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287394
{
public static readonly long[] Value={ 0L,2L,4L,6L,6L,6L,6L,6L,6L,6L,8L,10L,12L,12L,12L,12L,12L,12L,12L,14L,16L,18L,18L,18L,18L,18L,18L,18L,20L,22L,24L,24L,24L,24L,24L,24L,24L,26L,28L,30L,30L,30L,30L,30L,30L,30L,32L,34L,36L,36L,36L,36L,36L,36L,36L,38L,40L,42L,42L,42L,42L,42L,42L,42L,44L,46L,48L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287394Inst : IEnumerable<long>
{
public static readonly long[] Value=A287394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287394.Bytes);
public long this[int i]=>Value[i];

public static A287394Inst Instance=new A287394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287395
{
public static readonly long[] Value={ 1L,2L,11L,14L,19L,131L,270L,299L,1906L,6551L,8448L,110476L,120698L,274190L,360430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287395Inst : IEnumerable<long>
{
public static readonly long[] Value=A287395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287395.Bytes);
public long this[int i]=>Value[i];

public static A287395Inst Instance=new A287395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287396
{
public static readonly BigInteger[] Value={ 3L,56L,1568L,53312L,1931776L,71300096L,2645479424L,98305622016L,3654656065536L,135885355483136L,5052615982317568L,187873377732526080L,6985794697679601664L,BigInteger.Parse("259756778648305139712"),BigInteger.Parse("9658687473893481906176"),BigInteger.Parse("359144636249686988029952"),BigInteger.Parse("13354285908291066433372160") };
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
public class A287396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287396Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287396.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A287396.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287396Inst Instance=new A287396Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287397
{
public static readonly long[] Value={ 0L,1L,2L,2L,1L,0L,1L,0L,2L,1L,0L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,1L,0L,2L,2L,1L,0L,0L,1L,2L,1L,0L,2L,1L,0L,2L,2L,1L,0L,0L,1L,2L,0L,1L,2L,2L,1L,0L,1L,0L,2L,1L,0L,2L,2L,1L,0L,0L,1L,2L,0L,1L,2L,2L,1L,0L,1L,0L,2L,2L,1L,0L,0L,1L,2L,1L,0L,2L,1L,0L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287397Inst : IEnumerable<long>
{
public static readonly long[] Value=A287397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287397.Bytes);
public long this[int i]=>Value[i];

public static A287397Inst Instance=new A287397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287398
{
public static readonly long[] Value={ 1L,6L,8L,11L,15L,16L,21L,22L,26L,30L,31L,35L,38L,42L,43L,46L,51L,53L,56L,60L,61L,64L,69L,71L,75L,76L,80L,83L,87L,88L,91L,96L,98L,102L,103L,107L,111L,112L,116L,119L,123L,124L,127L,132L,134L,136L,141L,143L,146L,150L,151L,156L,157L,161L,165L,166L,170L,173L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287398Inst : IEnumerable<long>
{
public static readonly long[] Value=A287398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287398.Bytes);
public long this[int i]=>Value[i];

public static A287398Inst Instance=new A287398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287399
{
public static readonly long[] Value={ 2L,5L,7L,10L,14L,17L,20L,23L,25L,29L,32L,34L,37L,41L,44L,47L,50L,52L,55L,59L,62L,65L,68L,70L,74L,77L,79L,82L,86L,89L,92L,95L,97L,101L,104L,106L,110L,113L,115L,118L,122L,125L,128L,131L,133L,137L,140L,142L,145L,149L,152L,155L,158L,160L,164L,167L,169L,172L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287399Inst : IEnumerable<long>
{
public static readonly long[] Value=A287399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287399.Bytes);
public long this[int i]=>Value[i];

public static A287399Inst Instance=new A287399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287400
{
public static readonly long[] Value={ 3L,4L,9L,12L,13L,18L,19L,24L,27L,28L,33L,36L,39L,40L,45L,48L,49L,54L,57L,58L,63L,66L,67L,72L,73L,78L,81L,84L,85L,90L,93L,94L,99L,100L,105L,108L,109L,114L,117L,120L,121L,126L,129L,130L,135L,138L,139L,144L,147L,148L,153L,154L,159L,162L,163L,168L,171L,174L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287400Inst : IEnumerable<long>
{
public static readonly long[] Value=A287400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287400.Bytes);
public long this[int i]=>Value[i];

public static A287400Inst Instance=new A287400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287433
{
public static readonly long[] Value={ 1L,2L,3L,4L,25L,5L,49L,6L,9L,7L,121L,8L,169L,50L,10L,16L,289L,11L,361L,17L,12L,122L,529L,13L,26L,170L,14L,18L,841L,15L,961L,19L,123L,290L,27L,20L,1369L,362L,171L,21L,1681L,36L,1849L,22L,28L,530L,2209L,23L,51L,29L,291L,24L,2809L,37L,30L,52L,363L,842L,3481L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287433Inst : IEnumerable<long>
{
public static readonly long[] Value=A287433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287433.Bytes);
public long this[int i]=>Value[i];

public static A287433Inst Instance=new A287433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287434
{
public static readonly BigInteger[] Value={ 45L,24885L,315L,45L,340725L,196365L,15L,10965L,196365L,10465L,1652115781968795L,340725L,25245L,BigInteger.Parse("3976914451825623169001741646052688658398236092769201887156089117865"),15345L,13695L,6232413355673505L,79365L };
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
public class A287434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287434Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287434.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A287434.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287434Inst Instance=new A287434Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287435
{
public static readonly long[] Value={ 1L,6L,8L,12L,14L,16L,20L,22L,27L,30L,32L,34L,38L,40L,45L,46L,51L,53L,56L,58L,63L,64L,69L,71L,75L,77L,79L,84L,86L,88L,92L,94L,99L,100L,105L,107L,110L,112L,117L,118L,123L,125L,129L,131L,133L,136L,141L,143L,147L,149L,151L,155L,157L,162L,164L,166L,171L,172L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287435Inst : IEnumerable<long>
{
public static readonly long[] Value=A287435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287435.Bytes);
public long this[int i]=>Value[i];

public static A287435Inst Instance=new A287435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287436
{
public static readonly long[] Value={ 2L,4L,9L,10L,15L,17L,21L,23L,25L,28L,33L,35L,39L,41L,43L,47L,49L,54L,57L,59L,61L,65L,67L,72L,73L,78L,80L,82L,87L,89L,93L,95L,97L,101L,103L,108L,111L,113L,115L,119L,121L,126L,127L,132L,134L,137L,139L,144L,145L,150L,152L,156L,158L,160L,165L,167L,169L,173L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287436Inst : IEnumerable<long>
{
public static readonly long[] Value=A287436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287436.Bytes);
public long this[int i]=>Value[i];

public static A287436Inst Instance=new A287436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287437
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,18L,19L,24L,26L,29L,31L,36L,37L,42L,44L,48L,50L,52L,55L,60L,62L,66L,68L,70L,74L,76L,81L,83L,85L,90L,91L,96L,98L,102L,104L,106L,109L,114L,116L,120L,122L,124L,128L,130L,135L,138L,140L,142L,146L,148L,153L,154L,159L,161L,163L,168L,170L,174L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287437Inst : IEnumerable<long>
{
public static readonly long[] Value=A287437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287437.Bytes);
public long this[int i]=>Value[i];

public static A287437Inst Instance=new A287437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287438
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,0L,2L,1L,0L,1L,2L,0L,2L,1L,0L,0L,1L,2L,2L,1L,0L,1L,2L,0L,0L,1L,2L,1L,2L,0L,2L,1L,0L,0L,1L,2L,2L,1L,0L,1L,2L,0L,0L,1L,2L,0L,1L,2L,1L,2L,0L,2L,1L,0L,2L,1L,0L,1L,2L,0L,0L,1L,2L,1L,2L,0L,2L,1L,0L,0L,1L,2L,0L,1L,2L,1L,2L,0L,2L,1L,0L,1L,2L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287438Inst : IEnumerable<long>
{
public static readonly long[] Value=A287438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287438.Bytes);
public long this[int i]=>Value[i];

public static A287438Inst Instance=new A287438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287439
{
public static readonly long[] Value={ 2L,4L,7L,12L,22L,38L,68L,120L,212L,376L,664L,1176L,2080L,3680L,6512L,11520L,20384L,36064L,63808L,112896L,199744L,353408L,625280L,1106304L,1957376L,3463168L,6127360L,10841088L,19181056L,33936896L,60044288L,106235904L,187962368L,332560384L,588396544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287439Inst : IEnumerable<long>
{
public static readonly long[] Value=A287439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287439.Bytes);
public long this[int i]=>Value[i];

public static A287439Inst Instance=new A287439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287440
{
public static readonly long[] Value={ 1L,2L,5L,6L,7L,8L,9L,11L,13L,14L,17L,18L,19L,20L,21L,24L,25L,26L,28L,29L,30L,31L,32L,34L,35L,36L,38L,39L,41L,43L,44L,47L,48L,49L,50L,51L,54L,55L,56L,57L,58L,60L,62L,63L,66L,67L,68L,70L,71L,72L,74L,75L,78L,79L,80L,81L,82L,85L,86L,87L,89L,90L,91L,93L,94L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287440Inst : IEnumerable<long>
{
public static readonly long[] Value=A287440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287440.Bytes);
public long this[int i]=>Value[i];

public static A287440Inst Instance=new A287440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287441
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,18L,19L,23L,27L,29L,31L,36L,37L,41L,45L,48L,50L,52L,55L,59L,63L,65L,67L,72L,75L,77L,79L,83L,85L,90L,91L,95L,99L,102L,104L,106L,109L,113L,117L,119L,121L,126L,129L,131L,133L,138L,140L,142L,146L,148L,153L,154L,158L,162L,163L,167L,171L,173L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287441Inst : IEnumerable<long>
{
public static readonly long[] Value=A287441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287441.Bytes);
public long this[int i]=>Value[i];

public static A287441Inst Instance=new A287441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287442
{
public static readonly long[] Value={ 11L,12L,15L,24L,36L,101L,102L,104L,105L,125L,208L,306L,315L,735L,1001L,1002L,1004L,1005L,1008L,1025L,1125L,1352L,1734L,2016L,3006L,3015L,3024L,3375L,6048L,7007L,7056L,9072L,10001L,10002L,10004L,10005L,10008L,10016L,10025L,10125L,10625L,11011L,13013L,14112L,18144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287442Inst : IEnumerable<long>
{
public static readonly long[] Value=A287442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287442.Bytes);
public long this[int i]=>Value[i];

public static A287442Inst Instance=new A287442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287443
{
public static readonly long[] Value={ 0L,1L,2L,2L,0L,1L,0L,2L,1L,0L,2L,1L,0L,1L,2L,2L,0L,1L,0L,1L,2L,0L,2L,1L,2L,0L,1L,0L,1L,2L,0L,2L,1L,2L,0L,1L,0L,1L,2L,2L,0L,1L,0L,2L,1L,0L,2L,1L,0L,1L,2L,2L,0L,1L,0L,1L,2L,2L,0L,1L,0L,2L,1L,0L,1L,2L,0L,2L,1L,2L,0L,1L,0L,2L,1L,0L,1L,2L,2L,0L,1L,0L,1L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287443Inst : IEnumerable<long>
{
public static readonly long[] Value=A287443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287443.Bytes);
public long this[int i]=>Value[i];

public static A287443Inst Instance=new A287443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287444
{
public static readonly long[] Value={ 1L,5L,7L,10L,13L,17L,19L,22L,26L,28L,31L,35L,37L,41L,43L,46L,49L,53L,55L,59L,61L,64L,67L,71L,73L,76L,80L,82L,86L,88L,91L,94L,98L,100L,103L,107L,109L,113L,115L,118L,121L,125L,127L,130L,134L,136L,139L,143L,145L,149L,151L,154L,157L,161L,163L,167L,169L,172L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287444Inst : IEnumerable<long>
{
public static readonly long[] Value=A287444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287444.Bytes);
public long this[int i]=>Value[i];

public static A287444Inst Instance=new A287444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287445
{
public static readonly long[] Value={ 2L,6L,9L,12L,14L,18L,20L,24L,27L,29L,33L,36L,38L,42L,45L,48L,50L,54L,56L,60L,63L,65L,69L,72L,75L,77L,81L,83L,87L,90L,92L,96L,99L,102L,104L,108L,110L,114L,117L,120L,122L,126L,128L,132L,135L,137L,141L,144L,146L,150L,153L,156L,158L,162L,164L,168L,171L,174L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287445Inst : IEnumerable<long>
{
public static readonly long[] Value=A287445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287445.Bytes);
public long this[int i]=>Value[i];

public static A287445Inst Instance=new A287445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287446
{
public static readonly long[] Value={ 3L,4L,8L,11L,15L,16L,21L,23L,25L,30L,32L,34L,39L,40L,44L,47L,51L,52L,57L,58L,62L,66L,68L,70L,74L,78L,79L,84L,85L,89L,93L,95L,97L,101L,105L,106L,111L,112L,116L,119L,123L,124L,129L,131L,133L,138L,140L,142L,147L,148L,152L,155L,159L,160L,165L,166L,170L,173L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287446Inst : IEnumerable<long>
{
public static readonly long[] Value=A287446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287446.Bytes);
public long this[int i]=>Value[i];

public static A287446Inst Instance=new A287446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287447
{
public static readonly long[] Value={ 0L,1L,2L,2L,0L,1L,1L,0L,2L,1L,0L,2L,0L,1L,2L,2L,0L,1L,2L,0L,1L,0L,1L,2L,1L,0L,2L,2L,0L,1L,0L,1L,2L,1L,0L,2L,0L,1L,2L,2L,0L,1L,1L,0L,2L,1L,0L,2L,0L,1L,2L,2L,0L,1L,1L,0L,2L,0L,1L,2L,2L,0L,1L,0L,1L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,0L,1L,2L,1L,0L,2L,1L,0L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287447Inst : IEnumerable<long>
{
public static readonly long[] Value=A287447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287447.Bytes);
public long this[int i]=>Value[i];

public static A287447Inst Instance=new A287447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287448
{
public static readonly long[] Value={ 3L,4L,10L,12L,15L,16L,22L,23L,27L,33L,37L,40L,42L,45L,46L,52L,53L,59L,61L,64L,65L,69L,73L,76L,77L,83L,84L,88L,92L,95L,96L,100L,106L,107L,113L,117L,120L,122L,125L,126L,132L,133L,139L,141L,144L,145L,151L,152L,156L,162L,166L,169L,171L,174L,175L,179L,183L,186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287448Inst : IEnumerable<long>
{
public static readonly long[] Value=A287448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287448.Bytes);
public long this[int i]=>Value[i];

public static A287448Inst Instance=new A287448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287465
{
public static readonly BigInteger[] Value={ 1L,10L,0L,1000L,1000L,0L,0L,0L,1100000L,0L,0L,0L,0L,11000000000000L,0L,0L,1111000000000L,0L,0L,0L,1100000000000000000L,0L,1100000000000000000L,0L,0L,0L,0L,0L,0L,0L,0L,0L,BigInteger.Parse("1111111100000000000000000"),0L,0L,0L,BigInteger.Parse("1100000000000000000000000000000") };
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
public class A287465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287465Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287465.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A287465.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287465Inst Instance=new A287465Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287466
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,0L,0L,0L,12L,0L,0L,0L,0L,3L,0L,0L,240L,0L,0L,0L,12L,0L,48L,0L,0L,0L,0L,0L,0L,0L,0L,0L,65280L,0L,0L,0L,192L,50176L,512L,1024L,16384L,1024L,2240L,66560L,393216L,9216L,0L,58368L,73728L,139264L,368640L,9216L,2105344L,107520L,3678208L,11264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287466Inst : IEnumerable<long>
{
public static readonly long[] Value=A287466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287466.Bytes);
public long this[int i]=>Value[i];

public static A287466Inst Instance=new A287466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287467
{
public static readonly long[] Value={ 1L,2L,0L,8L,8L,0L,0L,0L,96L,0L,0L,0L,0L,12288L,0L,0L,7680L,0L,0L,0L,393216L,0L,393216L,0L,0L,0L,0L,0L,0L,0L,0L,0L,33423360L,0L,0L,0L,1610612736L,146800640L,536870912L,536870912L,67108864L,2147483648L,105226698752L,8724152320L,201326592L,38654705664L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287467Inst : IEnumerable<long>
{
public static readonly long[] Value=A287467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287467.Bytes);
public long this[int i]=>Value[i];

public static A287467Inst Instance=new A287467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287468
{
public static readonly long[] Value={ 1L,0L,11L,0L,111L,0L,1111L,0L,11111L,0L,111111L,0L,1111111L,0L,11111111L,0L,111111111L,0L,1111111111L,0L,11111111111L,0L,111111111111L,0L,1111111111111L,0L,11111111111111L,0L,111111111111111L,0L,1111111111111111L,0L,11111111111111111L,0L,111111111111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287468Inst : IEnumerable<long>
{
public static readonly long[] Value=A287468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287468.Bytes);
public long this[int i]=>Value[i];

public static A287468Inst Instance=new A287468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287469
{
public static readonly BigInteger[] Value={ 1L,0L,110L,0L,11100L,0L,1111000L,0L,111110000L,0L,11111100000L,0L,1111111000000L,0L,111111110000000L,0L,11111111100000000L,0L,1111111111000000000L,0L,BigInteger.Parse("111111111110000000000"),0L,BigInteger.Parse("11111111111100000000000"),0L,BigInteger.Parse("1111111111111000000000000"),0L };
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
public class A287469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287469Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287469.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A287469.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287469Inst Instance=new A287469Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287470
{
public static readonly long[] Value={ 1L,0L,6L,0L,28L,0L,120L,0L,496L,0L,2016L,0L,8128L,0L,32640L,0L,130816L,0L,523776L,0L,2096128L,0L,8386560L,0L,33550336L,0L,134209536L,0L,536854528L,0L,2147450880L,0L,8589869056L,0L,34359607296L,0L,137438691328L,0L,549755289600L,0L,2199022206976L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287470Inst : IEnumerable<long>
{
public static readonly long[] Value=A287470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287470.Bytes);
public long this[int i]=>Value[i];

public static A287470Inst Instance=new A287470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287471
{
public static readonly long[] Value={ 13L,115L,666L,3234L,14379L,60981L,251968L,1026124L,4145241L,16670823L,66879606L,267944070L,1072693399L,4292739241L,17175150780L,68709515472L,274856935653L,1099467587835L,4397954236690L,17591993106730L,70368341524803L,281474137850205L,1125898162012536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287471Inst : IEnumerable<long>
{
public static readonly long[] Value=A287471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287471.Bytes);
public long this[int i]=>Value[i];

public static A287471Inst Instance=new A287471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287472
{
public static readonly long[] Value={ 1L,231L,1035L,6786L,190036L,193131L,766941L,1237951L,1348903L,3069003L,3396921L,8034036L,9152781L,11875501L,15694003L,28001386L,29587278L,35149920L,61643856L,63196903L,130758706L,178161126L,198214005L,227751153L,268111746L,339210081L,402102261L,654224878L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287472Inst : IEnumerable<long>
{
public static readonly long[] Value=A287472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287472.Bytes);
public long this[int i]=>Value[i];

public static A287472Inst Instance=new A287472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287473
{
public static readonly long[] Value={ 1L,10L,136L,630L,2016L,7875L,9180L,18915L,32896L,37128L,46056L,58311L,66430L,103740L,131841L,198135L,225456L,301476L,323610L,332520L,408156L,499500L,738720L,786885L,839160L,862641L,922761L,924120L,1065070L,1079715L,1183491L,1385280L,1851850L,1906128L,1925703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287473Inst : IEnumerable<long>
{
public static readonly long[] Value=A287473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287473.Bytes);
public long this[int i]=>Value[i];

public static A287473Inst Instance=new A287473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287474
{
public static readonly long[] Value={ 3L,5L,31L,197L,1123L,6485L,37567L,217397L,1258051L,7280549L,42133471L,243831461L,1411082659L,8166108917L,47258275711L,273489449237L,1582717053571L,9159378096965L,53006446688671L,306754821216389L,1775227849020643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287474Inst : IEnumerable<long>
{
public static readonly long[] Value=A287474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287474.Bytes);
public long this[int i]=>Value[i];

public static A287474Inst Instance=new A287474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287475
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,2L,0L,1L,1L,1L,2L,2L,0L,2L,1L,0L,1L,2L,1L,2L,2L,2L,2L,3L,0L,2L,2L,2L,1L,3L,0L,1L,1L,1L,2L,1L,1L,3L,2L,4L,2L,2L,2L,4L,2L,4L,3L,5L,0L,2L,2L,6L,2L,0L,2L,4L,1L,4L,3L,5L,0L,3L,1L,0L,1L,2L,1L,2L,2L,2L,1L,4L,1L,2L,3L,3L,2L,3L,4L,4L,2L,4L,2L,8L,2L,4L,4L,6L,2L,4L,4L,4L,3L,6L,5L,7L,0L,3L,2L,10L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287475Inst : IEnumerable<long>
{
public static readonly long[] Value=A287475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287475.Bytes);
public long this[int i]=>Value[i];

public static A287475Inst Instance=new A287475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287476
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,2L,2L,3L,2L,3L,2L,3L,2L,4L,1L,3L,1L,3L,2L,4L,2L,5L,2L,5L,2L,5L,2L,4L,3L,5L,4L,7L,2L,3L,3L,7L,1L,4L,1L,2L,3L,6L,2L,5L,1L,5L,2L,5L,2L,7L,2L,6L,2L,7L,2L,4L,5L,7L,5L,10L,2L,7L,2L,7L,2L,7L,4L,9L,4L,8L,7L,11L,3L,6L,7L,9L,3L,4L,4L,5L,4L,5L,4L,7L,7L,9L,3L,7L,1L,3L,5L,7L,3L,8L,1L,7L,2L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287476Inst : IEnumerable<long>
{
public static readonly long[] Value=A287476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287476.Bytes);
public long this[int i]=>Value[i];

public static A287476Inst Instance=new A287476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287477
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,1L,2L,1L,4L,1L,4L,3L,6L,3L,6L,3L,6L,3L,8L,5L,8L,3L,10L,5L,10L,3L,12L,5L,12L,7L,14L,7L,14L,7L,16L,7L,14L,7L,18L,9L,16L,9L,20L,11L,18L,9L,22L,11L,20L,9L,24L,13L,20L,9L,26L,13L,22L,9L,28L,13L,24L,11L,30L,13L,26L,11L,32L,15L,28L,13L,34L,15L,30L,17L,36L,19L,30L,15L,38L,19L,34L,17L,40L,17L,34L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287477Inst : IEnumerable<long>
{
public static readonly long[] Value=A287477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287477.Bytes);
public long this[int i]=>Value[i];

public static A287477Inst Instance=new A287477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287478
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,22L,23L,24L,25L,26L,27L,28L,29L,30L,33L,34L,35L,36L,37L,38L,39L,40L,44L,45L,46L,47L,48L,49L,50L,55L,56L,57L,58L,59L,60L,66L,67L,68L,69L,70L,77L,78L,79L,80L,88L,89L,90L,99L,100L,101L,102L,103L,104L,105L,106L,107L,108L,109L,111L,112L,113L,114L,115L,116L,117L,118L,119L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287478Inst : IEnumerable<long>
{
public static readonly long[] Value=A287478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287478.Bytes);
public long this[int i]=>Value[i];

public static A287478Inst Instance=new A287478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287479
{
public static readonly long[] Value={ 0L,1L,1L,-3L,-3L,9L,9L,-27L,-27L,81L,81L,-243L,-243L,729L,729L,-2187L,-2187L,6561L,6561L,-19683L,-19683L,59049L,59049L,-177147L,-177147L,531441L,531441L,-1594323L,-1594323L,4782969L,4782969L,-14348907L,-14348907L,43046721L,43046721L,-129140163L,-129140163L,387420489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287479Inst : IEnumerable<long>
{
public static readonly long[] Value=A287479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287479.Bytes);
public long this[int i]=>Value[i];

public static A287479Inst Instance=new A287479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287480
{
public static readonly long[] Value={ 1L,1L,2L,1L,7L,0L,12L,3L,24L,6L,57L,5L,122L,1L,255L,0L,480L,15L,976L,32L,2015L,64L,4028L,163L,8016L,334L,16049L,647L,32120L,1158L,64325L,2219L,128592L,4574L,257573L,8523L,515760L,16846L,1031189L,33643L,2063504L,66398L,4127777L,132039L,8255608L,263814L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287480Inst : IEnumerable<long>
{
public static readonly long[] Value=A287480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287480.Bytes);
public long this[int i]=>Value[i];

public static A287480Inst Instance=new A287480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287545
{
public static readonly long[] Value={ 1L,2L,3L,12L,7L,56L,15L,246L,27L,1004L,51L,4060L,127L,16310L,223L,65400L,391L,261882L,919L,1048044L,1619L,4193278L,3467L,16775156L,7371L,67104702L,13671L,268425918L,28131L,1073723996L,60863L,4294933208L,114559L,17179799762L,217069L,68719343230L,503175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287545Inst : IEnumerable<long>
{
public static readonly long[] Value=A287545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287545.Bytes);
public long this[int i]=>Value[i];

public static A287545Inst Instance=new A287545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287546
{
public static readonly long[] Value={ 1L,1L,6L,3L,28L,7L,120L,111L,432L,223L,1632L,959L,8128L,7039L,32128L,7935L,115456L,97791L,478720L,228351L,1657856L,2095103L,6871040L,3141631L,27684864L,33021951L,120938496L,131448831L,418824192L,244809727L,2128314368L,459210751L,8556052480L,5037228031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287546Inst : IEnumerable<long>
{
public static readonly long[] Value=A287546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287546.Bytes);
public long this[int i]=>Value[i];

public static A287546Inst Instance=new A287546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287547
{
public static readonly long[] Value={ 1140813701L,1314331181L,1729804331L,2615969891L,2765625631L,3827771821L,4266876641L,4348917061L,4700742041L,4845745831L,4877408441L,5311420901L,5395463741L,5409482081L,5693097391L,5816498981L,5902417331L,6173160871L,6692523011L,6914652461L,6960900641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287547Inst : IEnumerable<long>
{
public static readonly long[] Value=A287547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287547.Bytes);
public long this[int i]=>Value[i];

public static A287547Inst Instance=new A287547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287548
{
public static readonly long[] Value={ 1L,2L,1L,5L,3L,2L,14L,9L,7L,4L,42L,28L,23L,16L,10L,132L,90L,76L,57L,42L,24L,429L,297L,255L,199L,156L,108L,66L,1430L,1001L,869L,695L,563L,420L,304L,174L,4862L,3432L,3003L,2442L,2019L,1568L,1210L,836L,504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287548Inst : IEnumerable<long>
{
public static readonly long[] Value=A287548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287548.Bytes);
public long this[int i]=>Value[i];

public static A287548Inst Instance=new A287548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287549
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,10L,11L,13L,14L,17L,18L,20L,22L,24L,25L,28L,29L,32L,34L,36L,37L,42L,43L,45L,47L,50L,51L,56L,57L,60L,62L,64L,66L,71L,72L,74L,76L,81L,82L,87L,88L,91L,94L,96L,97L,104L,105L,108L,110L,113L,114L,119L,121L,126L,128L,130L,131L,140L,141L,143L,146L,150L,152L,157L,158L,161L,163L,168L,169L,178L,179L,181L,184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287549Inst : IEnumerable<long>
{
public static readonly long[] Value=A287549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287549.Bytes);
public long this[int i]=>Value[i];

public static A287549Inst Instance=new A287549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287550
{
public static readonly long[] Value={ 491525857L,1470227987L,2834347387L,4314407477L,4766711387L,6401372837L,6871241197L,8971400797L,10168905497L,11776429517L,11871902557L,14538547967L,14925896087L,15218517367L,15646776877L,15875854927L,17310026197L,17942416307L,18347931587L,19241492057L,19379888947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287550Inst : IEnumerable<long>
{
public static readonly long[] Value=A287550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287550.Bytes);
public long this[int i]=>Value[i];

public static A287550Inst Instance=new A287550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287551
{
public static readonly long[] Value={ 1L,5L,8L,9L,13L,19L,22L,24L,27L,28L,32L,36L,39L,40L,46L,47L,51L,57L,58L,64L,68L,71L,73L,76L,77L,81L,85L,88L,89L,93L,99L,102L,104L,107L,108L,114L,115L,121L,123L,126L,127L,131L,135L,138L,139L,145L,146L,152L,154L,157L,158L,164L,165L,169L,173L,176L,177L,181L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287551Inst : IEnumerable<long>
{
public static readonly long[] Value=A287551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287551.Bytes);
public long this[int i]=>Value[i];

public static A287551Inst Instance=new A287551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287552
{
public static readonly long[] Value={ 1L,8L,11L,14L,20L,23L,26L,29L,35L,38L,41L,48L,50L,53L,60L,63L,68L,71L,74L,77L,83L,86L,89L,96L,98L,101L,108L,111L,113L,120L,123L,126L,131L,134L,137L,144L,146L,149L,156L,159L,161L,168L,171L,174L,180L,183L,186L,189L,194L,197L,204L,207L,209L,216L,219L,222L,228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287552Inst : IEnumerable<long>
{
public static readonly long[] Value=A287552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287552.Bytes);
public long this[int i]=>Value[i];

public static A287552Inst Instance=new A287552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287553
{
public static readonly long[] Value={ 2L,5L,12L,15L,17L,24L,27L,30L,36L,39L,42L,45L,51L,54L,57L,64L,65L,72L,75L,78L,84L,87L,90L,93L,99L,102L,105L,112L,114L,117L,124L,127L,132L,135L,138L,141L,147L,150L,153L,160L,162L,165L,172L,175L,177L,184L,187L,190L,195L,198L,201L,208L,210L,213L,220L,223L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287553Inst : IEnumerable<long>
{
public static readonly long[] Value=A287553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287553.Bytes);
public long this[int i]=>Value[i];

public static A287553Inst Instance=new A287553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287554
{
public static readonly long[] Value={ 3L,6L,9L,16L,18L,21L,28L,31L,33L,40L,43L,46L,52L,55L,58L,61L,66L,69L,76L,79L,81L,88L,91L,94L,100L,103L,106L,109L,115L,118L,121L,128L,129L,136L,139L,142L,148L,151L,154L,157L,163L,166L,169L,176L,178L,181L,188L,191L,196L,199L,202L,205L,211L,214L,217L,224L,226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287554Inst : IEnumerable<long>
{
public static readonly long[] Value=A287554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287554.Bytes);
public long this[int i]=>Value[i];

public static A287554Inst Instance=new A287554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287555
{
public static readonly long[] Value={ 4L,7L,10L,13L,19L,22L,25L,32L,34L,37L,44L,47L,49L,56L,59L,62L,67L,70L,73L,80L,82L,85L,92L,95L,97L,104L,107L,110L,116L,119L,122L,125L,130L,133L,140L,143L,145L,152L,155L,158L,164L,167L,170L,173L,179L,182L,185L,192L,193L,200L,203L,206L,212L,215L,218L,221L,227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287555Inst : IEnumerable<long>
{
public static readonly long[] Value=A287555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287555.Bytes);
public long this[int i]=>Value[i];

public static A287555Inst Instance=new A287555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287556
{
public static readonly long[] Value={ 0L,1L,3L,2L,1L,3L,2L,0L,2L,0L,1L,3L,3L,2L,0L,1L,1L,3L,2L,0L,2L,0L,1L,3L,3L,2L,0L,1L,0L,1L,3L,2L,3L,2L,0L,1L,0L,1L,3L,2L,1L,3L,2L,0L,2L,0L,1L,3L,2L,0L,1L,3L,3L,2L,0L,1L,0L,1L,3L,2L,1L,3L,2L,0L,1L,3L,2L,0L,2L,0L,1L,3L,3L,2L,0L,1L,0L,1L,3L,2L,3L,2L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287556Inst : IEnumerable<long>
{
public static readonly long[] Value=A287556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287556.Bytes);
public long this[int i]=>Value[i];

public static A287556Inst Instance=new A287556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287557
{
public static readonly long[] Value={ 1L,8L,10L,15L,20L,22L,27L,29L,35L,37L,44L,46L,50L,55L,57L,64L,68L,70L,75L,77L,83L,85L,92L,94L,98L,103L,105L,112L,113L,120L,122L,127L,130L,135L,137L,144L,145L,152L,154L,159L,164L,166L,171L,173L,179L,181L,188L,190L,195L,197L,204L,206L,210L,215L,217L,224L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287557Inst : IEnumerable<long>
{
public static readonly long[] Value=A287557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287557.Bytes);
public long this[int i]=>Value[i];

public static A287557Inst Instance=new A287557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287558
{
public static readonly long[] Value={ 2L,5L,11L,16L,17L,23L,28L,30L,36L,38L,41L,47L,51L,56L,58L,61L,65L,71L,76L,78L,84L,86L,89L,95L,99L,104L,106L,109L,114L,117L,123L,128L,131L,136L,138L,141L,146L,149L,155L,160L,161L,167L,172L,174L,180L,182L,185L,191L,196L,198L,201L,207L,211L,216L,218L,221L,226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287558Inst : IEnumerable<long>
{
public static readonly long[] Value=A287558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287558.Bytes);
public long this[int i]=>Value[i];

public static A287558Inst Instance=new A287558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287559
{
public static readonly long[] Value={ 4L,7L,9L,14L,19L,21L,26L,32L,34L,40L,43L,45L,49L,54L,60L,63L,67L,69L,74L,80L,82L,88L,91L,93L,97L,102L,108L,111L,116L,119L,121L,126L,129L,134L,140L,143L,148L,151L,153L,158L,163L,165L,170L,176L,178L,184L,187L,189L,194L,200L,203L,205L,209L,214L,220L,223L,228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287559Inst : IEnumerable<long>
{
public static readonly long[] Value=A287559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287559.Bytes);
public long this[int i]=>Value[i];

public static A287559Inst Instance=new A287559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287560
{
public static readonly long[] Value={ 3L,6L,12L,13L,18L,24L,25L,31L,33L,39L,42L,48L,52L,53L,59L,62L,66L,72L,73L,79L,81L,87L,90L,96L,100L,101L,107L,110L,115L,118L,124L,125L,132L,133L,139L,142L,147L,150L,156L,157L,162L,168L,169L,175L,177L,183L,186L,192L,193L,199L,202L,208L,212L,213L,219L,222L,227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287560Inst : IEnumerable<long>
{
public static readonly long[] Value=A287560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287560.Bytes);
public long this[int i]=>Value[i];

public static A287560Inst Instance=new A287560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287850
{
public static readonly long[] Value={ 1L,3L,3L,14L,7L,63L,12L,249L,31L,1023L,54L,4071L,119L,16380L,255L,65470L,507L,262142L,991L,1048319L,2046L,4194303L,4095L,16776188L,8191L,67108862L,16379L,268431358L,32767L,1073741820L,65535L,4294950902L,131071L,17179867135L,262136L,68719407615L,524284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287850Inst : IEnumerable<long>
{
public static readonly long[] Value=A287850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287850.Bytes);
public long this[int i]=>Value[i];

public static A287850Inst Instance=new A287850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287851
{
public static readonly long[] Value={ 1L,3L,6L,7L,28L,63L,24L,159L,496L,1023L,864L,3711L,7616L,4095L,32640L,32255L,114432L,131071L,515584L,1046527L,1047552L,4194303L,8386560L,4186111L,33550336L,33554431L,117432320L,134184959L,536854528L,268435455L,2147450880L,1878917119L,8589869056L,17175674879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287851Inst : IEnumerable<long>
{
public static readonly long[] Value=A287851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287851.Bytes);
public long this[int i]=>Value[i];

public static A287851Inst Instance=new A287851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287852
{
public static readonly long[] Value={ 1L,1L,0L,1L,10L,1L,10L,1L,10L,1101L,10L,1L,1110L,1L,0L,1111L,0L,10000L,10000011L,10000L,10000000L,1110011L,10001100L,1000100L,10110100L,1001000L,10001001L,10000000L,1000001L,10100010L,100001L,11000010L,100101L,111010L,1000000000001011L,1100L,1000000100000100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287852Inst : IEnumerable<long>
{
public static readonly long[] Value=A287852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287852.Bytes);
public long this[int i]=>Value[i];

public static A287852Inst Instance=new A287852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287853
{
public static readonly BigInteger[] Value={ 1L,10L,0L,1000L,1000L,100000L,100000L,10000000L,10000000L,1011000000L,1000000000L,100000000000L,111000000000L,10000000000000L,0L,1111000000000000L,0L,10000000000000L,1100000100000000000L,1000000000000000L,10000000000000L,BigInteger.Parse("1100111000000000000000") };
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
public class A287853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287853Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287853.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A287853.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287853Inst Instance=new A287853Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287854
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,1L,2L,1L,2L,13L,2L,1L,14L,1L,0L,15L,0L,16L,131L,16L,128L,115L,140L,68L,180L,72L,137L,128L,65L,162L,33L,194L,37L,58L,32779L,12L,33028L,8L,33289L,16640L,34367L,25088L,33792L,25615L,39440L,25600L,39455L,25600L,39424L,25631L,39808L,25628L,33795L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287854Inst : IEnumerable<long>
{
public static readonly long[] Value=A287854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287854.Bytes);
public long this[int i]=>Value[i];

public static A287854Inst Instance=new A287854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287855
{
public static readonly long[] Value={ 1L,2L,0L,8L,8L,32L,32L,128L,128L,704L,512L,2048L,3584L,8192L,0L,61440L,0L,8192L,395264L,32768L,8192L,3375104L,1605632L,2228224L,5898240L,4718592L,76021760L,1048576L,272629760L,289406976L,1107296256L,1124073472L,5502926848L,6174015488L,27917811712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287855Inst : IEnumerable<long>
{
public static readonly long[] Value=A287855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287855.Bytes);
public long this[int i]=>Value[i];

public static A287855Inst Instance=new A287855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287856
{
public static readonly BigInteger[] Value={ 1L,10L,11L,1110L,101L,111110L,1001L,11111110L,11101L,1111110010L,101111L,111111110110L,1001011L,11111111110100L,11111011L,1111111110001110L,101111011L,111111111110001110L,1001111011L,11111111111110000110UL,11101111111L,BigInteger.Parse("1111111111110010011110"),101111111111L };
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
public class A287856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287856Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287856.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A287856.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287856Inst Instance=new A287856Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287857
{
public static readonly long[] Value={ 1L,1L,110L,111L,10100L,11111L,1001000L,1111111L,101110000L,100111111L,11110100000L,11011111111L,1101001000000L,101111111111L,110111110000000L,111000111111111L,11011110100000000L,11100011111111111L,1101111001000000000L,1100001111111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287857Inst : IEnumerable<long>
{
public static readonly long[] Value=A287857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287857.Bytes);
public long this[int i]=>Value[i];

public static A287857Inst Instance=new A287857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287858
{
public static readonly long[] Value={ 1L,2L,3L,14L,5L,62L,9L,254L,29L,1010L,47L,4086L,75L,16372L,251L,65422L,379L,262030L,635L,1048454L,1919L,4193438L,3071L,16776606L,4863L,67108254L,16383L,268427678L,24575L,1073735582L,40959L,4294960990L,122879L,17179813726L,196591L,68719437374L,311279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287858Inst : IEnumerable<long>
{
public static readonly long[] Value=A287858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287858.Bytes);
public long this[int i]=>Value[i];

public static A287858Inst Instance=new A287858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287859
{
public static readonly long[] Value={ 1L,1L,6L,7L,20L,31L,72L,127L,368L,319L,1952L,1791L,6720L,3071L,28544L,29183L,113920L,116735L,455168L,401407L,2087936L,1986559L,8382464L,7979007L,33460224L,31916031L,134209536L,127434751L,536821760L,511311871L,2147254272L,2062024703L,8589344768L,8247312383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287859Inst : IEnumerable<long>
{
public static readonly long[] Value=A287859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287859.Bytes);
public long this[int i]=>Value[i];

public static A287859Inst Instance=new A287859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287860
{
public static readonly long[] Value={ 1L,1L,7L,29L,163L,925L,5580L,34751L,222627L,1456952L,9699872L,65474460L,446971110L,3080074508L,21393773841L,149614083615L,1052537452164L,7443584137525L,52888757972865L,377382278671610L,2703141489113003L,19430405608302831L,140118758417377105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287860Inst : IEnumerable<long>
{
public static readonly long[] Value=A287860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287860.Bytes);
public long this[int i]=>Value[i];

public static A287860Inst Instance=new A287860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287861
{
public static readonly long[] Value={ 36L,120L,180L,240L,360L,540L,720L,1080L,1200L,1260L,1680L,2160L,2520L,3780L,5040L,7560L,10080L,15120L,25200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287861Inst : IEnumerable<long>
{
public static readonly long[] Value=A287861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287861.Bytes);
public long this[int i]=>Value[i];

public static A287861Inst Instance=new A287861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287862
{
public static readonly long[] Value={ 36L,60L,108L,112L,120L,180L,216L,360L,540L,840L,1200L,1620L,2016L,2160L,2520L,3360L,3780L,4800L,5040L,6480L,7560L,8400L,10080L,12600L,15120L,25200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287862Inst : IEnumerable<long>
{
public static readonly long[] Value=A287862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287862.Bytes);
public long this[int i]=>Value[i];

public static A287862Inst Instance=new A287862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287863
{
public static readonly long[] Value={ 1L,3L,1L,3L,2L,4L,5L,4L,6L,7L,4L,6L,7L,8L,10L,11L,9L,10L,11L,10L,12L,13L,11L,12L,13L,14L,14L,15L,15L,16L,17L,16L,17L,19L,18L,22L,23L,22L,23L,24L,26L,25L,20L,21L,25L,26L,28L,29L,26L,27L,25L,26L,32L,31L,30L,31L,31L,32L,36L,37L,33L,34L,31L,32L,36L,35L,37L,38L,35L,34L,36L,37L,41L,42L,39L,40L,42L,41L,45L,46L,35L,34L,48L,49L,49L,50L,44L,45L,50L,49L,49L,50L,48L,49L,48L,49L,51L,52L,54L,55L,52L,51L,55L,56L,58L,59L,57L,58L,63L,64L,64L,65L,65L,64L,59L,60L,62L,63L,69L,70L,63L,64L,62L,63L,68L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287863Inst : IEnumerable<long>
{
public static readonly long[] Value=A287863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287863.Bytes);
public long this[int i]=>Value[i];

public static A287863Inst Instance=new A287863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287864
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,6L,7L,7L,8L,8L,9L,9L,10L,10L,11L,11L,12L,12L,13L,13L,13L,14L,14L,15L,15L,16L,16L,17L,17L,18L,18L,19L,19L,20L,20L,21L,21L,21L,22L,22L,23L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287864Inst : IEnumerable<long>
{
public static readonly long[] Value=A287864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287864.Bytes);
public long this[int i]=>Value[i];

public static A287864Inst Instance=new A287864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287865
{
public static readonly long[] Value={ 1L,3L,7L,5L,11L,23L,47L,19L,13L,3L,7L,5L,11L,23L,47L,19L,13L,3L,7L,5L,11L,23L,47L,19L,13L,3L,7L,5L,11L,23L,47L,19L,13L,3L,7L,5L,11L,23L,47L,19L,13L,3L,7L,5L,11L,23L,47L,19L,13L,3L,7L,5L,11L,23L,47L,19L,13L,3L,7L,5L,11L,23L,47L,19L,13L,3L,7L,5L,11L,23L,47L,19L,13L,3L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287865Inst : IEnumerable<long>
{
public static readonly long[] Value=A287865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287865.Bytes);
public long this[int i]=>Value[i];

public static A287865Inst Instance=new A287865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287947
{
public static readonly long[] Value={ 1L,3L,6L,7L,28L,15L,120L,223L,240L,1023L,864L,3967L,4032L,16383L,12672L,65023L,65280L,253951L,255488L,915455L,982016L,4161535L,202752L,16769023L,33026048L,16252927L,134111232L,57901055L,530563072L,234881023L,2143387648L,922615807L,8575188992L,3758096383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287947Inst : IEnumerable<long>
{
public static readonly long[] Value=A287947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287947.Bytes);
public long this[int i]=>Value[i];

public static A287947Inst Instance=new A287947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287948
{
public static readonly long[] Value={ 1L,1L,10L,11L,111L,100L,1100L,1011L,11010L,10110L,111001L,100110L,1101001L,1011101L,11100110L,10010101L,110101101L,101111010L,1110001101L,1001001011L,11011011100L,10110110010L,111011010110L,100110111101L,1101011000101L,1011110100110L,11100011101001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287948Inst : IEnumerable<long>
{
public static readonly long[] Value=A287948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287948.Bytes);
public long this[int i]=>Value[i];

public static A287948Inst Instance=new A287948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287949
{
public static readonly ulong[] Value={ 1L,10L,10L,1100L,11100L,1000L,11000L,11010000L,10110000L,110100000L,10011100000L,11001000000L,1001011000000L,10111010000000L,11001110000000L,1010100100000000L,10110101100000000L,10111101000000000L,1011000111000000000L,11010010010000000000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287949Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A287949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287949.Bytes);
public ulong this[int i]=>Value[i];

public static A287949Inst Instance=new A287949Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287950
{
public static readonly long[] Value={ 1L,1L,2L,3L,7L,4L,12L,11L,26L,22L,57L,38L,105L,93L,230L,149L,429L,378L,909L,587L,1756L,1458L,3798L,2493L,6853L,6054L,14569L,9369L,28062L,23393L,60753L,39898L,109629L,96805L,232934L,150809L,447274L,376045L,974109L,635682L,1757877L,1556427L,3720748L,2411218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287950Inst : IEnumerable<long>
{
public static readonly long[] Value=A287950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287950.Bytes);
public long this[int i]=>Value[i];

public static A287950Inst Instance=new A287950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287951
{
public static readonly long[] Value={ 1L,2L,2L,12L,28L,8L,24L,208L,176L,416L,1248L,1600L,4800L,11904L,13184L,43264L,92928L,96768L,364032L,861184L,486400L,1271808L,3520512L,12423168L,21409792L,26714112L,79224832L,160579584L,255246336L,565608448L,1163624448L,1540947968L,6315245568L,11030626304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287951Inst : IEnumerable<long>
{
public static readonly long[] Value=A287951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287951.Bytes);
public long this[int i]=>Value[i];

public static A287951Inst Instance=new A287951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287952
{
public static readonly BigInteger[] Value={ 1L,11L,1L,1100L,11L,111100L,11L,11111100L,1111L,1111111100L,1L,111111100100L,11001L,11111111100100L,11111L,1111111111111100L,10011101L,111111111111100100L,10011111L,11111111111000100100UL,10011001L,BigInteger.Parse("1111111111111000100100"),10011001L,BigInteger.Parse("111111111111111000100100") };
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
public class A287952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287952Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287952.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A287952.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287952Inst Instance=new A287952Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287953
{
public static readonly BigInteger[] Value={ 1L,11L,100L,11L,11000L,1111L,1100000L,111111L,111100000L,11111111L,10000000000L,1001111111L,1001100000000L,100111111111L,111110000000000L,11111111111111L,10111001000000000L,1001111111111111L,1111100100000000000L,100100011111111111L,BigInteger.Parse("100110010000000000000") };
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
public class A287953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287953Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287953.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A287953.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287953Inst Instance=new A287953Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287954
{
public static readonly long[] Value={ 1L,3L,1L,12L,3L,60L,3L,252L,15L,1020L,1L,4068L,25L,16356L,31L,65532L,157L,262116L,159L,1048100L,153L,4193828L,153L,16776740L,153L,67108388L,921L,268433892L,921L,1073739844L,1017L,4294965316L,58153L,17179867604L,57L,68719366268L,110521L,274877804608L,131023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287954Inst : IEnumerable<long>
{
public static readonly long[] Value=A287954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287954.Bytes);
public long this[int i]=>Value[i];

public static A287954Inst Instance=new A287954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287955
{
public static readonly long[] Value={ 1L,3L,4L,3L,24L,15L,96L,63L,480L,255L,1024L,639L,4864L,2559L,31744L,16383L,94720L,40959L,509952L,149503L,1253376L,598015L,5013504L,2392063L,20054016L,9568255L,80609280L,41549823L,322437120L,143130623L,1340080128L,572522495L,4992139264L,2927624191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287955Inst : IEnumerable<long>
{
public static readonly long[] Value=A287955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287955.Bytes);
public long this[int i]=>Value[i];

public static A287955Inst Instance=new A287955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287956
{
public static readonly long[] Value={ 1L,5L,7L,11L,13L,17L,37L,43L,55L,107L,139L,149L,157L,211L,223L,343L,373L,409L,523L,12049L,16457L,17143L,17543L,18391L,25829L,25945L,31307L,34601L,41687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287956Inst : IEnumerable<long>
{
public static readonly long[] Value=A287956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287956.Bytes);
public long this[int i]=>Value[i];

public static A287956Inst Instance=new A287956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287957
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,3L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,4L,1L,2L,1L,1L,1L,3L,1L,1L,3L,1L,1L,1L,2L,1L,2L,5L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,2L,1L,6L,1L,2L,3L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,7L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287957Inst : IEnumerable<long>
{
public static readonly long[] Value=A287957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287957.Bytes);
public long this[int i]=>Value[i];

public static A287957Inst Instance=new A287957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287958
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,3L,4L,6L,6L,4L,5L,4L,3L,4L,5L,6L,10L,12L,12L,10L,6L,7L,6L,15L,4L,15L,6L,7L,8L,14L,6L,20L,20L,6L,14L,8L,9L,8L,21L,12L,5L,12L,21L,8L,9L,10L,18L,24L,28L,30L,30L,28L,24L,18L,10L,11L,10L,9L,64L,35L,6L,35L,64L,9L,10L,11L,12L,22L,30L,36L,40L,42L,42L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287958Inst : IEnumerable<long>
{
public static readonly long[] Value=A287958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287958.Bytes);
public long this[int i]=>Value[i];

public static A287958Inst Instance=new A287958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287959
{
public static readonly long[] Value={ 3L,43L,8237L,14533L,26153L,11314271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287959Inst : IEnumerable<long>
{
public static readonly long[] Value=A287959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287959.Bytes);
public long this[int i]=>Value[i];

public static A287959Inst Instance=new A287959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287960
{
public static readonly long[] Value={ 2L,5L,8L,11L,14L,20L,23L,29L,32L,35L,38L,41L,47L,50L,56L,62L,65L,68L,74L,77L,83L,86L,89L,92L,95L,104L,110L,113L,116L,119L,128L,131L,137L,140L,146L,149L,155L,167L,170L,173L,176L,182L,185L,194L,197L,200L,203L,209L,212L,218L,221L,230L,236L,239L,245L,251L,254L,263L,266L,272L,275L,278L,281L,284L,293L,299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287960Inst : IEnumerable<long>
{
public static readonly long[] Value=A287960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287960.Bytes);
public long this[int i]=>Value[i];

public static A287960Inst Instance=new A287960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287961
{
public static readonly long[] Value={ 4L,5L,6L,7L,8L,9L,10L,12L,13L,14L,16L,18L,22L,103L,104L,106L,108L,112L,133L,134L,136L,138L,142L,153L,154L,156L,158L,162L,183L,184L,186L,188L,192L,193L,194L,196L,198L,202L,232L,252L,262L,282L,292L,302L,312L,315L,316L,318L,320L,322L,324L,332L,342L,355L,356L,358L,360L,362L,364L,372L,375L,376L,378L,380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287961Inst : IEnumerable<long>
{
public static readonly long[] Value=A287961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287961.Bytes);
public long this[int i]=>Value[i];

public static A287961Inst Instance=new A287961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287962
{
public static readonly long[] Value={ 1L,4L,5L,9L,10L,13L,14L,25L,26L,29L,30L,34L,35L,38L,39L,64L,65L,68L,69L,73L,74L,77L,78L,89L,90L,93L,94L,98L,99L,102L,103L,169L,170L,173L,174L,178L,179L,182L,183L,194L,195L,198L,199L,203L,204L,207L,208L,233L,234L,237L,238L,242L,243L,246L,247L,258L,259L,262L,263L,267L,268L,271L,272L,441L,442L,445L,446L,450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287962Inst : IEnumerable<long>
{
public static readonly long[] Value=A287962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287962.Bytes);
public long this[int i]=>Value[i];

public static A287962Inst Instance=new A287962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288012
{
public static readonly long[] Value={ 1L,1L,0L,1L,10L,0L,0L,0L,1100L,0L,1000L,100L,0L,1100L,0L,100L,11111000L,100L,11001000L,110100L,1000L,11000100L,1011000L,1000100L,1000000L,1000100L,1000000L,101000100L,1000000L,1000100L,101000000L,1000100L,1111100001000000L,101000100L,1111100001000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288012Inst : IEnumerable<long>
{
public static readonly long[] Value=A288012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288012.Bytes);
public long this[int i]=>Value[i];

public static A288012Inst Instance=new A288012Inst();

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