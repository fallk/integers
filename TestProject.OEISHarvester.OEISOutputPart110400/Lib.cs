using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A188461
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,10L,10L,1L,1L,16L,39L,16L,1L,1L,23L,99L,99L,23L,1L,1L,31L,203L,375L,203L,31L,1L,1L,40L,366L,1065L,1065L,366L,40L,1L,1L,50L,605L,2521L,4027L,2521L,605L,50L,1L,1L,61L,939L,5266L,12220L,12220L,5266L,939L,61L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188461Inst : IEnumerable<long>
{
public static readonly long[] Value=A188461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188461.Bytes);
public long this[int i]=>Value[i];

public static A188461Inst Instance=new A188461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188462
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188462Inst : IEnumerable<long>
{
public static readonly long[] Value=A188462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188462.Bytes);
public long this[int i]=>Value[i];

public static A188462Inst Instance=new A188462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188463
{
public static readonly long[] Value={ 1L,3L,1L,7L,7L,1L,15L,30L,12L,1L,31L,103L,79L,18L,1L,63L,312L,387L,166L,25L,1L,127L,873L,1586L,1085L,305L,33L,1L,255L,2314L,5768L,5719L,2545L,512L,42L,1L,511L,5899L,19261L,25994L,16661L,5285L,805L,52L,1L,1023L,14604L,60337L,106009L,92008L,41881L,10038L,1204L,63L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188463Inst : IEnumerable<long>
{
public static readonly long[] Value=A188463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188463.Bytes);
public long this[int i]=>Value[i];

public static A188463Inst Instance=new A188463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188464
{
public static readonly long[] Value={ 1L,3L,8L,22L,62L,178L,519L,1533L,4578L,13800L,41937L,128345L,395232L,1223792L,3807903L,11900549L,37339043L,117574429L,371429284L,1176876762L,3739129185L,11909686261L,38022182028L,121648373964L,389979453010L,1252517211660L,4029754366713L,12986073134365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188464Inst : IEnumerable<long>
{
public static readonly long[] Value=A188464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188464.Bytes);
public long this[int i]=>Value[i];

public static A188464Inst Instance=new A188464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188465
{
public static readonly long[] Value={ 7L,73L,127L,337L,487L,601L,881L,937L,1801L,2593L,2647L,3079L,3943L,4057L,4201L,6553L,7993L,9199L,10657L,14407L,15289L,16759L,18041L,18121L,20521L,20809L,21673L,22111L,24967L,25111L,26407L,28393L,28729L,36793L,39367L,41161L,42463L,47737L,47881L,49201L,49297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188465Inst : IEnumerable<long>
{
public static readonly long[] Value=A188465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188465.Bytes);
public long this[int i]=>Value[i];

public static A188465Inst Instance=new A188465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188466
{
public static readonly long[] Value={ 1L,4L,6L,16L,36L,55L,78L,105L,124L,144L,171L,200L,253L,325L,406L,465L,666L,689L,715L,741L,915L,930L,990L,1027L,1081L,1136L,1240L,1421L,1448L,1610L,1653L,1711L,1752L,1764L,1800L,1827L,2211L,2352L,2448L,2667L,2800L,2835L,3403L,3600L,3619L,3620L,3660L,3900L,4840L,4970L,5253L,5264L,5513L,5671L,5886L,6100L,6328L,8001L,8112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188466Inst : IEnumerable<long>
{
public static readonly long[] Value=A188466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188466.Bytes);
public long this[int i]=>Value[i];

public static A188466Inst Instance=new A188466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188467
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188467Inst : IEnumerable<long>
{
public static readonly long[] Value=A188467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188467.Bytes);
public long this[int i]=>Value[i];

public static A188467Inst Instance=new A188467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188468
{
public static readonly long[] Value={ 2L,4L,5L,7L,10L,12L,13L,15L,18L,20L,23L,25L,26L,28L,31L,33L,34L,36L,39L,41L,44L,46L,47L,49L,52L,54L,57L,59L,60L,62L,65L,67L,68L,70L,73L,75L,78L,80L,81L,83L,86L,88L,89L,91L,94L,96L,99L,101L,102L,104L,107L,109L,112L,114L,115L,117L,120L,122L,123L,125L,128L,130L,133L,135L,136L,138L,141L,143L,146L,148L,149L,151L,154L,156L,157L,159L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188468Inst : IEnumerable<long>
{
public static readonly long[] Value=A188468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188468.Bytes);
public long this[int i]=>Value[i];

public static A188468Inst Instance=new A188468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188469
{
public static readonly long[] Value={ 1L,3L,6L,8L,9L,11L,14L,16L,17L,19L,21L,22L,24L,27L,29L,30L,32L,35L,37L,38L,40L,42L,43L,45L,48L,50L,51L,53L,55L,56L,58L,61L,63L,64L,66L,69L,71L,72L,74L,76L,77L,79L,82L,84L,85L,87L,90L,92L,93L,95L,97L,98L,100L,103L,105L,106L,108L,110L,111L,113L,116L,118L,119L,121L,124L,126L,127L,129L,131L,132L,134L,137L,139L,140L,142L,144L,145L,147L,150L,152L,153L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188469Inst : IEnumerable<long>
{
public static readonly long[] Value=A188469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188469.Bytes);
public long this[int i]=>Value[i];

public static A188469Inst Instance=new A188469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188470
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188470Inst : IEnumerable<long>
{
public static readonly long[] Value=A188470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188470.Bytes);
public long this[int i]=>Value[i];

public static A188470Inst Instance=new A188470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188471
{
public static readonly long[] Value={ 5L,13L,26L,34L,47L,60L,68L,81L,89L,102L,115L,123L,136L,149L,157L,170L,178L,191L,204L,212L,225L,233L,246L,259L,267L,280L,293L,301L,314L,322L,335L,348L,356L,369L,382L,390L,403L,411L,424L,437L,445L,458L,466L,479L,492L,500L,513L,526L,534L,547L,555L,568L,581L,589L,602L,610L,623L,636L,644L,657L,670L,678L,691L,699L,712L,725L,733L,746L,759L,767L,780L,788L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188471Inst : IEnumerable<long>
{
public static readonly long[] Value=A188471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188471.Bytes);
public long this[int i]=>Value[i];

public static A188471Inst Instance=new A188471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188472
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188472Inst : IEnumerable<long>
{
public static readonly long[] Value=A188472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188472.Bytes);
public long this[int i]=>Value[i];

public static A188472Inst Instance=new A188472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188473
{
public static readonly long[] Value={ 3L,8L,11L,16L,19L,21L,24L,29L,32L,37L,40L,42L,45L,50L,53L,55L,58L,63L,66L,71L,74L,76L,79L,84L,87L,92L,95L,97L,100L,105L,108L,110L,113L,118L,121L,126L,129L,131L,134L,139L,142L,144L,147L,152L,155L,160L,163L,165L,168L,173L,176L,181L,184L,186L,189L,194L,197L,199L,202L,207L,210L,215L,218L,220L,223L,228L,231L,236L,239L,241L,244L,249L,252L,254L,257L,262L,265L,270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188473Inst : IEnumerable<long>
{
public static readonly long[] Value=A188473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188473.Bytes);
public long this[int i]=>Value[i];

public static A188473Inst Instance=new A188473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188474
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,10L,10L,1L,1L,16L,40L,16L,1L,1L,23L,102L,102L,23L,1L,1L,31L,209L,393L,209L,31L,1L,1L,40L,376L,1122L,1122L,376L,40L,1L,1L,50L,620L,2656L,4296L,2656L,620L,50L,1L,1L,61L,960L,5536L,13100L,13100L,5536L,960L,61L,1L,1L,73L,1417L,10522L,34036L,50180L,34036L,10522L,1417L,73L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188474Inst : IEnumerable<long>
{
public static readonly long[] Value=A188474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188474.Bytes);
public long this[int i]=>Value[i];

public static A188474Inst Instance=new A188474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188475
{
public static readonly long[] Value={ 1L,3L,11L,29L,61L,111L,183L,281L,409L,571L,771L,1013L,1301L,1639L,2031L,2481L,2993L,3571L,4219L,4941L,5741L,6623L,7591L,8649L,9801L,11051L,12403L,13861L,15429L,17111L,18911L,20833L,22881L,25059L,27371L,29821L,32413L,35151L,38039L,41081L,44281L,47643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188475Inst : IEnumerable<long>
{
public static readonly long[] Value=A188475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188475.Bytes);
public long this[int i]=>Value[i];

public static A188475Inst Instance=new A188475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188620
{
public static readonly long[] Value={ 3L,17L,29L,73L,127L,251L,281L,433L,521L,577L,757L,1009L,1217L,1459L,2663L,2729L,2753L,2927L,3257L,3457L,3529L,3719L,5039L,5573L,5897L,6833L,6841L,7561L,7589L,8009L,8191L,8513L,9001L,9929L,10657L,11161L,12097L,12377L,12511L,12637L,13499L,16001L,16481L,17921L,18089L,18523L,19001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188620Inst : IEnumerable<long>
{
public static readonly long[] Value=A188620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188620.Bytes);
public long this[int i]=>Value[i];

public static A188620Inst Instance=new A188620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188621
{
public static readonly long[] Value={ 3L,2L,6L,12L,3L,5L,42L,56L,14L,18L,8L,10L,33L,2L,27L,240L,60L,68L,15L,3L,13L,105L,61L,67L,138L,150L,47L,51L,24L,26L,930L,117L,21L,6L,40L,66L,315L,41L,7L,231L,35L,37L,118L,5L,83L,495L,220L,230L,564L,55L,28L,147L,663L,98L,10L,50L,92L,798L,221L,229L,885L,12L,741L,615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188621Inst : IEnumerable<long>
{
public static readonly long[] Value=A188621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188621.Bytes);
public long this[int i]=>Value[i];

public static A188621Inst Instance=new A188621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188622
{
public static readonly long[] Value={ 1L,3L,10L,34L,118L,418L,1508L,5524L,20486L,76722L,289580L,1099836L,4198396L,16093236L,61902472L,238805864L,923574598L,3579675026L,13900879132L,54071886764L,210645038548L,821701422716L,3209243934712L,12547819633304L,49109812222108L,192382627198868L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188622Inst : IEnumerable<long>
{
public static readonly long[] Value=A188622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188622.Bytes);
public long this[int i]=>Value[i];

public static A188622Inst Instance=new A188622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188623
{
public static readonly long[] Value={ 1L,2L,2L,5L,7L,8L,12L,15L,17L,22L,26L,29L,35L,40L,44L,51L,57L,62L,70L,77L,83L,92L,100L,107L,117L,126L,134L,145L,155L,164L,176L,187L,197L,210L,222L,233L,247L,260L,272L,287L,301L,314L,330L,345L,359L,376L,392L,407L,425L,442L,458L,477L,495L,512L,532L,551L,569L,590L,610L,629L,651L,672L,692L,715L,737L,758L,782L,805L,827L,852L,876L,899L,925L,950L,974L,1001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188623Inst : IEnumerable<long>
{
public static readonly long[] Value=A188623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188623.Bytes);
public long this[int i]=>Value[i];

public static A188623Inst Instance=new A188623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188624
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,7L,11L,19L,32L,56L,102L,180L,331L,596L,1101L,2015L,3724L,6904L,12782L,23923L,44444L,83755L,156334L,296084L,555531L,1056095L,1991784L,3797790L,7197369L,13757665L,26186491L,50164787L,95847772L,183980036L,352670170L,678215028L,1303661995L,2511483176L,4838822931L,9337575130L,18025920971L,34840575458L,67371021603L,130412367572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188624Inst : IEnumerable<long>
{
public static readonly long[] Value=A188624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188624.Bytes);
public long this[int i]=>Value[i];

public static A188624Inst Instance=new A188624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188625
{
public static readonly long[] Value={ 1L,1L,3L,7L,19L,56L,180L,596L,2015L,6904L,23923L,83755L,296084L,1056095L,3797790L,13757665L,50164787L,183980036L,678215028L,2511483176L,9337575130L,34840575458L,130412367572L,489546890178L,1842438724560L,6950471604901L,26276784902865L,99539079724648L,377759500611913L,1436093975018569L,5468247624237042L,20853026397347178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188625Inst : IEnumerable<long>
{
public static readonly long[] Value=A188625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188625.Bytes);
public long this[int i]=>Value[i];

public static A188625Inst Instance=new A188625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188626
{
public static readonly long[] Value={ 1L,3L,7L,16L,37L,86L,199L,456L,1033L,2314L,5131L,11276L,24589L,53262L,114703L,245776L,524305L,1114130L,2359315L,4980756L,10485781L,22020118L,46137367L,96469016L,201326617L,419430426L,872415259L,1811939356L,3758096413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188626Inst : IEnumerable<long>
{
public static readonly long[] Value=A188626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188626.Bytes);
public long this[int i]=>Value[i];

public static A188626Inst Instance=new A188626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188627
{
public static readonly long[] Value={ 5L,4L,15L,6L,1L,13L,2L,1L,1L,21L,3L,2L,16L,1L,4L,1L,1L,157L,1L,9L,1L,3L,1L,5L,1L,2L,1L,3L,1L,1L,1L,1L,11L,1L,1L,22L,1L,9L,1L,1L,1L,1L,12L,1L,7L,6L,1L,3L,2L,8L,1L,1L,1L,1L,4L,2L,3L,1L,10L,17L,1L,2L,1L,5L,8L,1L,2L,1L,6L,1L,12L,1L,39L,16L,14L,1L,46L,72L,16L,3L,1L,1L,5L,2L,1L,5L,2L,1L,10L,4L,2L,2L,3L,2L,1L,3L,2L,2L,27L,10L,4L,2L,8L,1L,2L,6L,3L,945L,1L,1L,106L,1L,1L,3L,1L,2L,6L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188627Inst : IEnumerable<long>
{
public static readonly long[] Value=A188627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188627.Bytes);
public long this[int i]=>Value[i];

public static A188627Inst Instance=new A188627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188628
{
public static readonly long[] Value={ 7L,4L,2L,1L,1L,1L,2L,1L,11L,11L,32L,16L,8L,4L,2L,1L,4006L,2003L,9284L,4642L,2321L,107566L,53783L,313702L,156851L,1364479L,1493338L,746669L,12145148L,6072574L,3036287L,107186842L,53593421L,323781196L,161890598L,80945299L,3501584548L,1750792274L,875396137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188628Inst : IEnumerable<long>
{
public static readonly long[] Value=A188628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188628.Bytes);
public long this[int i]=>Value[i];

public static A188628Inst Instance=new A188628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188629
{
public static readonly long[] Value={ 2L,4L,8L,14L,16L,22L,38L,58L,135L,158L,178L,256L,297L,382L,502L,542L,568L,676L,718L,878L,1202L,1215L,1312L,1318L,1382L,1438L,1593L,1622L,1822L,2018L,2144L,2336L,2558L,2578L,2744L,2858L,2902L,3062L,3118L,3296L,3375L,3778L,3993L,4023L,4064L,4192L,4282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188629Inst : IEnumerable<long>
{
public static readonly long[] Value=A188629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188629.Bytes);
public long this[int i]=>Value[i];

public static A188629Inst Instance=new A188629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188630
{
public static readonly long[] Value={ 36L,45L,210L,630L,780L,990L,1540L,2850L,3570L,4095L,4851L,8778L,11781L,15400L,17955L,19110L,21528L,25200L,26565L,26796L,33930L,37128L,40755L,43956L,61425L,61776L,70125L,79800L,105570L,113050L,122265L,145530L,176715L,189420L,192510L,246753L,270480L,303810L,349866L,437580L,500500L,526851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188630Inst : IEnumerable<long>
{
public static readonly long[] Value=A188630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188630.Bytes);
public long this[int i]=>Value[i];

public static A188630Inst Instance=new A188630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188631
{
public static readonly long[] Value={ 62L,63L,74L,164L,188L,194L,195L,207L,255L,275L,278L,279L,284L,314L,356L,362L,363L,398L,399L,404L,422L,423L,428L,455L,458L,459L,483L,494L,524L,539L,584L,614L,615L,662L,674L,692L,734L,747L,758L,759L,764L,824L,854L,867L,890L,927L,935L,944L,956L,998L,999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188631Inst : IEnumerable<long>
{
public static readonly long[] Value=A188631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188631.Bytes);
public long this[int i]=>Value[i];

public static A188631Inst Instance=new A188631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188632
{
public static readonly long[] Value={ 1L,4L,12L,44L,160L,640L,2240L,8912L,32256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188632Inst : IEnumerable<long>
{
public static readonly long[] Value=A188632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188632.Bytes);
public long this[int i]=>Value[i];

public static A188632Inst Instance=new A188632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188633
{
public static readonly long[] Value={ 36L,60L,72L,84L,100L,108L,120L,132L,140L,144L,156L,168L,180L,196L,200L,204L,216L,220L,228L,240L,252L,260L,264L,276L,280L,288L,300L,308L,312L,324L,336L,340L,348L,360L,364L,372L,380L,392L,396L,400L,408L,420L,432L,440L,444L,456L,460L,468L,476L,480L,484L,492L,500L,504L,516L,520L,528L,532L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188633Inst : IEnumerable<long>
{
public static readonly long[] Value=A188633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188633.Bytes);
public long this[int i]=>Value[i];

public static A188633Inst Instance=new A188633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188634
{
public static readonly BigInteger[] Value={ 1L,1L,4L,46L,1066L,41506L,2441314L,202229266L,22447207906L,3216941445106L,578333776748674L,127464417117501586L,BigInteger.Parse("33800841048945424546"),BigInteger.Parse("10617398393395844992306"),BigInteger.Parse("3898852051843774954576834"),BigInteger.Parse("1654948033478889053351543506"),BigInteger.Parse("804119629083230641164978005986") };
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
public class A188634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188634Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188634.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188634.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188634Inst Instance=new A188634Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188635
{
public static readonly long[] Value={ 2L,10L,2L,40L,10L,2L,2L,1L,14L,1L,12L,3L,2L,1L,3L,9L,2L,12L,3L,1L,5L,1L,51L,29L,1L,3L,2L,35L,1L,27L,3L,75L,5L,1L,3L,2L,36L,1L,5L,1L,1L,3L,1L,2L,40L,1L,2L,7L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,8L,11L,6L,1L,2L,1L,3L,1L,2L,7L,1L,9L,1L,1L,9L,2L,1L,2L,1L,2L,7L,2L,34L,9L,13L,1L,2L,2L,24L,2L,1L,2L,1L,3L,1L,2L,2L,2L,1L,3L,1L,1L,2L,4L,11L,3L,1L,3L,1L,6L,1L,5L,20L,2L,1L,1L,4L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188635Inst : IEnumerable<long>
{
public static readonly long[] Value=A188635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188635.Bytes);
public long this[int i]=>Value[i];

public static A188635Inst Instance=new A188635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188668
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,-2L,4L,-1L,0L,0L,0L,1L,3L,-9L,9L,-2L,-21L,27L,-9L,1L,0L,0L,0L,0L,1L,-4L,16L,-24L,16L,-3L,92L,-176L,120L,-32L,3L,-232L,256L,-96L,16L,-1L,0L,0L,0L,0L,0L,1L,5L,-25L,50L,-50L,25L,-4L,-315L,775L,-750L,350L,-75L,6L,2115L,-3275L,1950L,-550L,75L,-4L,-3005L,3125L,-1250L,250L,-25L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188668Inst : IEnumerable<long>
{
public static readonly long[] Value=A188668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188668.Bytes);
public long this[int i]=>Value[i];

public static A188668Inst Instance=new A188668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188669
{
public static readonly long[] Value={ 1L,2L,4L,9L,26L,77L,246L,805L,2702L,9238L,32066L,112674L,400024L,1432736L,5170584L,18783763L,68635478L,252087092L,930138522L,3446163221L,12815663678L,47820430994L,178987624514L,671825076732L,2528212128756L,9536894864387L,36054433808299L,136583760727865L,518401146543812L,1971076359414358L,7506908923471954L,28634752202227978L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188669Inst : IEnumerable<long>
{
public static readonly long[] Value=A188669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188669.Bytes);
public long this[int i]=>Value[i];

public static A188669Inst Instance=new A188669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188670
{
public static readonly long[] Value={ 3L,6L,5L,3L,6L,8L,3L,6L,13L,3L,6L,21L,3L,6L,34L,3L,6L,55L,3L,6L,89L,3L,6L,144L,3L,6L,233L,3L,6L,377L,3L,6L,610L,3L,6L,987L,3L,6L,1597L,3L,6L,2584L,3L,6L,4181L,3L,6L,6765L,3L,6L,10946L,3L,6L,17711L,3L,6L,28657L,3L,6L,46368L,3L,6L,75025L,3L,6L,121393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188670Inst : IEnumerable<long>
{
public static readonly long[] Value=A188670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188670.Bytes);
public long this[int i]=>Value[i];

public static A188670Inst Instance=new A188670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188671
{
public static readonly long[] Value={ 1L,0L,-24L,-32L,108L,275L,-176L,-1056L,45L,3157L,1080L,-6541L,-836L,16839L,2072L,-33824L,1188L,67100L,1672L,-95883L,19162L,161083L,-8208L,-224653L,2707L,371325L,67500L,-520025L,-1188L,870551L,8512L,-1082400L,148334L,1419889L,10428L,-1588228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188671Inst : IEnumerable<long>
{
public static readonly long[] Value=A188671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188671.Bytes);
public long this[int i]=>Value[i];

public static A188671Inst Instance=new A188671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188672
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,2L,4L,0L,2L,3L,0L,0L,0L,6L,2L,2L,3L,2L,7L,4L,2L,4L,0L,2L,7L,2L,2L,4L,3L,2L,2L,4L,2L,4L,4L,2L,2L,3L,5L,5L,2L,2L,3L,2L,2L,2L,3L,2L,4L,3L,2L,3L,4L,2L,0L,2L,2L,2L,5L,2L,3L,4L,2L,5L,2L,2L,3L,3L,2L,2L,2L,2L,4L,4L,2L,2L,3L,2L,2L,3L,2L,4L,3L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188672Inst : IEnumerable<long>
{
public static readonly long[] Value=A188672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188672.Bytes);
public long this[int i]=>Value[i];

public static A188672Inst Instance=new A188672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188673
{
public static readonly long[] Value={ 4L,6L,10L,9L,14L,15L,22L,21L,25L,34L,33L,39L,46L,46L,49L,55L,62L,74L,69L,74L,86L,82L,85L,91L,134L,106L,106L,118L,111L,115L,129L,133L,142L,141L,166L,158L,159L,166L,169L,178L,202L,183L,194L,206L,202L,201L,213L,226L,274L,302L,235L,262L,254L,253L,259L,265L,274L,274L,314L,298L,302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188673Inst : IEnumerable<long>
{
public static readonly long[] Value=A188673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188673.Bytes);
public long this[int i]=>Value[i];

public static A188673Inst Instance=new A188673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188674
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,2L,3L,4L,5L,7L,9L,13L,17L,24L,31L,42L,54L,71L,90L,117L,147L,188L,236L,298L,371L,466L,576L,716L,882L,1088L,1331L,1633L,1987L,2422L,2935L,3557L,4290L,5177L,6216L,7465L,8932L,10682L,12731L,15169L,18016L,21387L,25321L,29955L,35353L,41696L,49063L,57689L,67698L,79375L,92896L,108633L,126817L,147922L,172272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188674Inst : IEnumerable<long>
{
public static readonly long[] Value=A188674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188674.Bytes);
public long this[int i]=>Value[i];

public static A188674Inst Instance=new A188674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188675
{
public static readonly long[] Value={ 1L,4L,19L,103L,598L,3601L,22165L,138445L,873916L,5560741L,35605756L,229142476L,1480820176L,9603245620L,62463474700L,407330900284L,2662179813931L,17433248900656L,114359597479261L,751343566800961L,4943188072606456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188675Inst : IEnumerable<long>
{
public static readonly long[] Value=A188675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188675.Bytes);
public long this[int i]=>Value[i];

public static A188675Inst Instance=new A188675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188676
{
public static readonly long[] Value={ 1L,2L,13L,71L,424L,2579L,15985L,100295L,635176L,4051649L,25993366L,167543354L,1084134346L,7038291098L,45821937982L,299045487602L,1955803426045L,12815265660680L,84111082917925L,552872886403775L,3638971619401720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188676Inst : IEnumerable<long>
{
public static readonly long[] Value=A188676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188676.Bytes);
public long this[int i]=>Value[i];

public static A188676Inst Instance=new A188676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188677
{
public static readonly long[] Value={ 11L,13L,19L,23L,29L,37L,43L,53L,59L,61L,67L,71L,83L,97L,109L,131L,139L,151L,157L,181L,197L,227L,233L,239L,251L,263L,269L,293L,317L,353L,359L,383L,409L,433L,439L,499L,509L,523L,541L,571L,601L,613L,619L,643L,661L,691L,709L,739L,751L,773L,797L,827L,857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188677Inst : IEnumerable<long>
{
public static readonly long[] Value=A188677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188677.Bytes);
public long this[int i]=>Value[i];

public static A188677Inst Instance=new A188677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188678
{
public static readonly long[] Value={ 1L,0L,3L,9L,46L,227L,1201L,6551L,36712L,209963L,1220752L,7193888L,42873220L,257957352L,1564809168L,9559946496L,58768808463L,363261736872L,2256369305793L,14076552984507L,88163556913188L,554148894304557L,3494365949734563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188678Inst : IEnumerable<long>
{
public static readonly long[] Value=A188678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188678.Bytes);
public long this[int i]=>Value[i];

public static A188678Inst Instance=new A188678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188679
{
public static readonly BigInteger[] Value={ 1L,10L,235L,7291L,252316L,9270325L,353892421L,13874930821L,554792522662L,22521121103287L,925224047453512L,38381686035811912L,1605078750713101912L,BigInteger.Parse("67578873844051699048"),BigInteger.Parse("2861782692234129345448"),BigInteger.Parse("121795323921169907086504") };
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
public class A188679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188679Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188679.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188679.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188679Inst Instance=new A188679Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188680
{
public static readonly BigInteger[] Value={ 1L,8L,217L,6839L,238186L,8779823L,335842273L,13185196127L,527732395714L,21438596184911L,881264330165314L,36575197658193086L,1530121867019096914L,BigInteger.Parse("64443673226319500222"),BigInteger.Parse("2729760145163758146178"),BigInteger.Parse("116203781083772019594878") };
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
public class A188680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188680Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188680.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188680.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188680Inst Instance=new A188680Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188681
{
public static readonly BigInteger[] Value={ 1L,3L,45L,1008L,27225L,819819L,26509392L,901402560L,31818681873L,1156122556875L,42985853635725L,1628541825580800L,62667882587091600L,2443473892345873968L,BigInteger.Parse("96351855806554401600"),BigInteger.Parse("3836565846094702507776"),BigInteger.Parse("154071018890153214025473") };
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
public class A188681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188681Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188681.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188681.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188681Inst Instance=new A188681Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188682
{
public static readonly BigInteger[] Value={ 1L,4L,49L,1057L,28282L,848101L,27357493L,928760053L,32747441926L,1188869998801L,44174723634526L,1672716549215326L,64340599136306926L,2507814491482180894L,BigInteger.Parse("98859670298036582494"),BigInteger.Parse("3935425516392739090270"),BigInteger.Parse("158006444406545953115743") };
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
public class A188682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188682Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188682.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188682.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188682Inst Instance=new A188682Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188683
{
public static readonly BigInteger[] Value={ 1L,2L,43L,965L,26260L,793559L,25715833L,875686727L,30942995146L,1125179561729L,41860674073996L,1586681151506804L,61081201435584796L,2382392690910289172L,BigInteger.Parse("93969463115644112428"),BigInteger.Parse("3742596382979058395348") };
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
public class A188683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188683Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188683.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188683.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188683Inst Instance=new A188683Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189004
{
public static readonly long[] Value={ 1L,1L,21L,56L,781L,2415L,31529L,100352L,1292697L,4140081L,53175517L,170537640L,2188978117L,7022359583L,90124167441L,289143013376L,3710708201969L,11905151192865L,152783289861989L,490179860527896L,6290652543875133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189004Inst : IEnumerable<long>
{
public static readonly long[] Value=A189004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189004.Bytes);
public long this[int i]=>Value[i];

public static A189004Inst Instance=new A189004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189005
{
public static readonly long[] Value={ 1L,1L,55L,209L,6336L,30305L,817991L,4140081L,108435745L,557568000L,14479521761L,74795194705L,1937528668711L,10021992194369L,259423766712000L,1342421467113969L,34741645659770711L,179796299139278305L,4652799879944138561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189005Inst : IEnumerable<long>
{
public static readonly long[] Value=A189005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189005.Bytes);
public long this[int i]=>Value[i];

public static A189005Inst Instance=new A189005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189006
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,3L,3L,1L,1L,1L,1L,5L,4L,5L,1L,1L,1L,1L,8L,11L,11L,8L,1L,1L,1L,1L,13L,15L,36L,15L,13L,1L,1L,1L,1L,21L,41L,95L,95L,41L,21L,1L,1L,1L,1L,34L,56L,281L,192L,281L,56L,34L,1L,1L,1L,1L,55L,153L,781L,1183L,1183L,781L,153L,55L,1L,1L,1L,1L,89L,209L,2245L,2415L,6728L,2415L,2245L,209L,89L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189006Inst : IEnumerable<long>
{
public static readonly long[] Value=A189006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189006.Bytes);
public long this[int i]=>Value[i];

public static A189006Inst Instance=new A189006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189007
{
public static readonly long[] Value={ 1L,4L,8L,16L,16L,32L,32L,64L,32L,64L,64L,128L,64L,128L,128L,256L,64L,128L,128L,256L,128L,256L,256L,512L,128L,256L,256L,512L,256L,512L,512L,1024L,128L,256L,256L,512L,256L,512L,512L,1024L,256L,512L,512L,1024L,512L,1024L,1024L,2048L,256L,512L,512L,1024L,512L,1024L,1024L,2048L,512L,1024L,1024L,2048L,1024L,2048L,2048L,4096L,256L,512L,512L,1024L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189007Inst : IEnumerable<long>
{
public static readonly long[] Value=A189007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189007.Bytes);
public long this[int i]=>Value[i];

public static A189007Inst Instance=new A189007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189008
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189008Inst : IEnumerable<long>
{
public static readonly long[] Value=A189008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189008.Bytes);
public long this[int i]=>Value[i];

public static A189008Inst Instance=new A189008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189009
{
public static readonly long[] Value={ 1L,3L,5L,7L,10L,11L,14L,15L,18L,19L,22L,23L,26L,27L,28L,32L,33L,34L,38L,39L,40L,44L,45L,46L,50L,51L,52L,56L,57L,58L,62L,63L,65L,68L,70L,71L,73L,76L,78L,79L,81L,84L,86L,87L,89L,92L,94L,95L,97L,100L,102L,103L,105L,108L,110L,111L,113L,116L,118L,119L,121L,124L,125L,127L,128L,131L,134L,135L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189009Inst : IEnumerable<long>
{
public static readonly long[] Value=A189009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189009.Bytes);
public long this[int i]=>Value[i];

public static A189009Inst Instance=new A189009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189010
{
public static readonly long[] Value={ 2L,4L,6L,8L,9L,12L,13L,16L,17L,20L,21L,24L,25L,29L,30L,31L,35L,36L,37L,41L,42L,43L,47L,48L,49L,53L,54L,55L,59L,60L,61L,64L,66L,67L,69L,72L,74L,75L,77L,80L,82L,83L,85L,88L,90L,91L,93L,96L,98L,99L,101L,104L,106L,107L,109L,112L,114L,115L,117L,120L,122L,123L,126L,129L,130L,132L,133L,136L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189010Inst : IEnumerable<long>
{
public static readonly long[] Value=A189010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189010.Bytes);
public long this[int i]=>Value[i];

public static A189010Inst Instance=new A189010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189011
{
public static readonly long[] Value={ 0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189011Inst : IEnumerable<long>
{
public static readonly long[] Value=A189011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189011.Bytes);
public long this[int i]=>Value[i];

public static A189011Inst Instance=new A189011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189012
{
public static readonly long[] Value={ 1L,4L,5L,9L,10L,11L,12L,15L,18L,19L,22L,23L,26L,27L,31L,32L,35L,37L,38L,41L,42L,44L,45L,48L,49L,52L,55L,56L,57L,60L,61L,63L,64L,66L,69L,70L,73L,76L,78L,79L,80L,83L,84L,86L,87L,89L,94L,95L,98L,101L,103L,104L,106L,107L,110L,111L,113L,114L,116L,119L,120L,123L,124L,127L,130L,132L,133L,137L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189012Inst : IEnumerable<long>
{
public static readonly long[] Value=A189012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189012.Bytes);
public long this[int i]=>Value[i];

public static A189012Inst Instance=new A189012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189013
{
public static readonly long[] Value={ 2L,3L,6L,7L,8L,13L,14L,16L,17L,20L,21L,24L,25L,28L,29L,30L,33L,34L,36L,39L,40L,43L,46L,47L,50L,51L,53L,54L,58L,59L,62L,65L,67L,68L,71L,72L,74L,75L,77L,81L,82L,85L,88L,90L,91L,92L,93L,96L,97L,99L,100L,102L,105L,108L,109L,112L,115L,117L,118L,121L,122L,125L,126L,128L,129L,131L,134L,135L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189013Inst : IEnumerable<long>
{
public static readonly long[] Value=A189013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189013.Bytes);
public long this[int i]=>Value[i];

public static A189013Inst Instance=new A189013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189014
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189014Inst : IEnumerable<long>
{
public static readonly long[] Value=A189014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189014.Bytes);
public long this[int i]=>Value[i];

public static A189014Inst Instance=new A189014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189015
{
public static readonly long[] Value={ 1L,3L,6L,7L,10L,11L,12L,16L,17L,18L,23L,24L,25L,26L,31L,32L,33L,34L,40L,41L,42L,43L,44L,50L,51L,52L,53L,54L,55L,62L,63L,64L,65L,66L,67L,70L,75L,76L,78L,79L,80L,81L,84L,89L,90L,93L,94L,95L,96L,99L,100L,105L,106L,109L,110L,111L,112L,115L,116L,122L,123L,126L,127L,128L,129L,130L,133L,134L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189015Inst : IEnumerable<long>
{
public static readonly long[] Value=A189015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189015.Bytes);
public long this[int i]=>Value[i];

public static A189015Inst Instance=new A189015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189016
{
public static readonly long[] Value={ 2L,4L,5L,8L,9L,13L,14L,15L,19L,20L,21L,22L,27L,28L,29L,30L,35L,36L,37L,38L,39L,45L,46L,47L,48L,49L,56L,57L,58L,59L,60L,61L,68L,69L,71L,72L,73L,74L,77L,82L,83L,85L,86L,87L,88L,91L,92L,97L,98L,101L,102L,103L,104L,107L,108L,113L,114L,117L,118L,119L,120L,121L,124L,125L,131L,132L,135L,136L,137L,138L,139L,142L,143L,150L,151L,154L,155L,156L,157L,158L,159L,162L,163L,170L,171L,174L,175L,177L,178L,179L,180L,183L,184L,187L,192L,193L,196L,197L,199L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189016Inst : IEnumerable<long>
{
public static readonly long[] Value=A189016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189016.Bytes);
public long this[int i]=>Value[i];

public static A189016Inst Instance=new A189016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189017
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189017Inst : IEnumerable<long>
{
public static readonly long[] Value=A189017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189017.Bytes);
public long this[int i]=>Value[i];

public static A189017Inst Instance=new A189017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189018
{
public static readonly long[] Value={ 1L,3L,6L,7L,10L,11L,12L,16L,17L,18L,23L,24L,25L,26L,31L,32L,33L,34L,40L,41L,42L,43L,44L,50L,51L,52L,53L,54L,56L,61L,63L,64L,65L,66L,68L,73L,75L,76L,77L,78L,80L,84L,86L,88L,89L,90L,92L,94L,98L,100L,102L,103L,104L,106L,108L,112L,114L,116L,117L,118L,121L,123L,127L,128L,130L,132L,133L,134L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189018Inst : IEnumerable<long>
{
public static readonly long[] Value=A189018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189018.Bytes);
public long this[int i]=>Value[i];

public static A189018Inst Instance=new A189018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189019
{
public static readonly long[] Value={ 2L,4L,5L,8L,9L,13L,14L,15L,19L,20L,21L,22L,27L,28L,29L,30L,35L,36L,37L,38L,39L,45L,46L,47L,48L,49L,55L,57L,58L,59L,60L,62L,67L,69L,70L,71L,72L,74L,79L,81L,82L,83L,85L,87L,91L,93L,95L,96L,97L,99L,101L,105L,107L,109L,110L,111L,113L,115L,119L,120L,122L,124L,125L,126L,129L,131L,135L,136L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189019Inst : IEnumerable<long>
{
public static readonly long[] Value=A189019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189019.Bytes);
public long this[int i]=>Value[i];

public static A189019Inst Instance=new A189019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189292
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189292Inst : IEnumerable<long>
{
public static readonly long[] Value=A189292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189292.Bytes);
public long this[int i]=>Value[i];

public static A189292Inst Instance=new A189292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189293
{
public static readonly long[] Value={ 3L,5L,7L,10L,11L,12L,17L,18L,19L,20L,21L,28L,29L,30L,31L,33L,34L,35L,40L,42L,44L,47L,48L,49L,50L,51L,54L,57L,59L,61L,68L,69L,70L,72L,73L,74L,76L,77L,79L,80L,82L,83L,84L,85L,86L,87L,89L,94L,99L,103L,107L,112L,116L,117L,119L,120L,121L,122L,123L,124L,126L,127L,129L,130L,132L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189293Inst : IEnumerable<long>
{
public static readonly long[] Value=A189293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189293.Bytes);
public long this[int i]=>Value[i];

public static A189293Inst Instance=new A189293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189294
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,9L,13L,14L,15L,16L,22L,23L,24L,25L,26L,27L,32L,36L,37L,38L,39L,41L,43L,45L,46L,52L,53L,55L,56L,58L,60L,62L,63L,64L,65L,66L,67L,71L,75L,78L,81L,88L,90L,91L,92L,93L,95L,96L,97L,98L,100L,101L,102L,104L,105L,106L,108L,109L,110L,111L,113L,114L,115L,118L,125L,128L,131L,137L,142L,144L,148L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189294Inst : IEnumerable<long>
{
public static readonly long[] Value=A189294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189294.Bytes);
public long this[int i]=>Value[i];

public static A189294Inst Instance=new A189294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189295
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189295Inst : IEnumerable<long>
{
public static readonly long[] Value=A189295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189295.Bytes);
public long this[int i]=>Value[i];

public static A189295Inst Instance=new A189295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189296
{
public static readonly long[] Value={ 2L,5L,7L,8L,11L,13L,15L,18L,20L,21L,22L,25L,28L,30L,31L,32L,34L,35L,38L,43L,44L,47L,49L,51L,52L,53L,54L,55L,59L,60L,61L,63L,66L,72L,74L,75L,77L,80L,82L,84L,85L,86L,88L,89L,90L,91L,93L,94L,97L,100L,101L,103L,105L,107L,110L,112L,115L,120L,122L,124L,126L,127L,128L,130L,131L,135L,136L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189296Inst : IEnumerable<long>
{
public static readonly long[] Value=A189296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189296.Bytes);
public long this[int i]=>Value[i];

public static A189296Inst Instance=new A189296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189297
{
public static readonly long[] Value={ 1L,3L,4L,6L,9L,10L,12L,14L,16L,17L,19L,23L,24L,26L,27L,29L,33L,36L,37L,39L,40L,41L,42L,45L,46L,48L,50L,56L,57L,58L,62L,64L,65L,67L,68L,69L,70L,71L,73L,76L,78L,79L,81L,83L,87L,92L,95L,96L,98L,99L,102L,104L,106L,108L,109L,111L,113L,114L,116L,117L,118L,119L,121L,123L,125L,129L,132L,133L,134L,137L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189297Inst : IEnumerable<long>
{
public static readonly long[] Value=A189297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189297.Bytes);
public long this[int i]=>Value[i];

public static A189297Inst Instance=new A189297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189298
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189298Inst : IEnumerable<long>
{
public static readonly long[] Value=A189298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189298.Bytes);
public long this[int i]=>Value[i];

public static A189298Inst Instance=new A189298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189299
{
public static readonly long[] Value={ 2L,3L,5L,7L,8L,11L,12L,13L,18L,19L,20L,21L,22L,28L,30L,31L,32L,33L,34L,35L,38L,44L,47L,48L,49L,51L,52L,53L,54L,55L,57L,59L,61L,66L,72L,74L,76L,77L,79L,80L,82L,83L,84L,85L,86L,88L,89L,90L,91L,93L,94L,97L,99L,103L,107L,112L,115L,120L,122L,124L,126L,127L,128L,130L,132L,133L,134L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189299Inst : IEnumerable<long>
{
public static readonly long[] Value=A189299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189299.Bytes);
public long this[int i]=>Value[i];

public static A189299Inst Instance=new A189299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189300
{
public static readonly long[] Value={ 1L,4L,6L,9L,10L,14L,15L,16L,17L,23L,24L,25L,26L,27L,29L,36L,37L,39L,40L,41L,42L,43L,45L,46L,50L,56L,58L,60L,62L,63L,64L,65L,67L,68L,69L,70L,71L,73L,75L,78L,81L,87L,92L,95L,96L,98L,100L,101L,102L,104L,105L,106L,108L,109L,110L,111L,113L,114L,116L,117L,118L,119L,121L,123L,125L,129L,131L,137L,142L,144L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189300Inst : IEnumerable<long>
{
public static readonly long[] Value=A189300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189300.Bytes);
public long this[int i]=>Value[i];

public static A189300Inst Instance=new A189300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189301
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189301Inst : IEnumerable<long>
{
public static readonly long[] Value=A189301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189301.Bytes);
public long this[int i]=>Value[i];

public static A189301Inst Instance=new A189301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189302
{
public static readonly long[] Value={ 1L,3L,6L,9L,11L,12L,15L,18L,21L,24L,27L,30L,33L,35L,36L,39L,41L,43L,45L,47L,48L,51L,54L,57L,59L,60L,63L,66L,69L,72L,75L,78L,81L,83L,86L,90L,93L,96L,99L,102L,105L,107L,108L,111L,114L,117L,120L,123L,126L,129L,131L,132L,135L,137L,139L,141L,143L,144L,147L,150L,153L,155L,156L,159L,161L,163L,166L,169L,171L,172L,175L,177L,179L,180L,183L,185L,187L,189L,191L,192L,195L,198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189302Inst : IEnumerable<long>
{
public static readonly long[] Value=A189302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189302.Bytes);
public long this[int i]=>Value[i];

public static A189302Inst Instance=new A189302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189303
{
public static readonly long[] Value={ 2L,4L,5L,7L,8L,10L,13L,14L,16L,17L,19L,20L,22L,23L,25L,26L,28L,29L,31L,32L,34L,37L,38L,40L,42L,44L,46L,49L,50L,52L,53L,55L,56L,58L,61L,62L,64L,65L,67L,68L,70L,71L,73L,74L,76L,77L,79L,80L,82L,84L,85L,87L,88L,89L,91L,92L,94L,95L,97L,98L,100L,101L,103L,104L,106L,109L,110L,112L,113L,115L,116L,118L,119L,121L,122L,124L,125L,127L,128L,130L,133L,134L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189303Inst : IEnumerable<long>
{
public static readonly long[] Value=A189303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189303.Bytes);
public long this[int i]=>Value[i];

public static A189303Inst Instance=new A189303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189304
{
public static readonly BigInteger[] Value={ 1L,14L,960L,654049L,3373180708L,146610388175180L,BigInteger.Parse("52114841233680255776"),BigInteger.Parse("153220700522675894994117846") };
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
public class A189304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189304Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189304.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189304.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189304Inst Instance=new A189304Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189305
{
public static readonly long[] Value={ 2L,14L,73L,400L,2177L,11854L,64554L,351521L,1914208L,10423761L,56762346L,309097942L,1683185225L,9165743600L,49911830577L,271793641686L,1480045568402L,8059551617921L,43888089440192L,238991507967969L,1301422358761490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189305Inst : IEnumerable<long>
{
public static readonly long[] Value=A189305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189305.Bytes);
public long this[int i]=>Value[i];

public static A189305Inst Instance=new A189305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189306
{
public static readonly long[] Value={ 3L,73L,960L,14714L,216708L,3224934L,47862876L,710856569L,10555661105L,156750811549L,2327708940824L,34565989342645L,513297241320175L,7622351430906057L,113190239801459420L,1680850155699514974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189306Inst : IEnumerable<long>
{
public static readonly long[] Value=A189306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189306.Bytes);
public long this[int i]=>Value[i];

public static A189306Inst Instance=new A189306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189307
{
public static readonly BigInteger[] Value={ 5L,400L,14714L,654049L,27850597L,1198076276L,51426223446L,2208514085834L,94835559790076L,4072414321238637L,174876227462904797L,7509482312424443718L,BigInteger.Parse("322469872590578998976"),BigInteger.Parse("13847402256925194712245"),BigInteger.Parse("594630892478640240887537") };
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
public class A189307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189307Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189307.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189307.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189307Inst Instance=new A189307Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189324
{
public static readonly long[] Value={ 11L,17L,31L,51L,91L,157L,253L,374L,509L,649L,789L,929L,1069L,1209L,1349L,1489L,1629L,1769L,1909L,2049L,2189L,2329L,2469L,2609L,2749L,2889L,3029L,3169L,3309L,3449L,3589L,3729L,3869L,4009L,4149L,4289L,4429L,4569L,4709L,4849L,4989L,5129L,5269L,5409L,5549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189324Inst : IEnumerable<long>
{
public static readonly long[] Value=A189324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189324.Bytes);
public long this[int i]=>Value[i];

public static A189324Inst Instance=new A189324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189325
{
public static readonly long[] Value={ 13L,24L,49L,95L,179L,321L,548L,866L,1267L,1733L,2248L,2806L,3408L,4056L,4752L,5498L,6296L,7148L,8056L,9022L,10048L,11136L,12288L,13506L,14792L,16148L,17576L,19078L,20656L,22312L,24048L,25866L,27768L,29756L,31832L,33998L,36256L,38608L,41056L,43602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189325Inst : IEnumerable<long>
{
public static readonly long[] Value=A189325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189325.Bytes);
public long this[int i]=>Value[i];

public static A189325Inst Instance=new A189325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189326
{
public static readonly long[] Value={ 2L,4L,2L,5L,6L,2L,7L,7L,8L,2L,8L,12L,11L,10L,2L,10L,12L,20L,16L,12L,2L,11L,18L,21L,32L,22L,14L,2L,13L,17L,36L,33L,49L,28L,16L,2L,14L,24L,31L,64L,54L,70L,34L,18L,2L,16L,22L,49L,51L,110L,84L,94L,40L,20L,2L,17L,30L,42L,95L,91L,179L,119L,120L,46L,22L,2L,19L,27L,63L,76L,179L,157L,275L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189326Inst : IEnumerable<long>
{
public static readonly long[] Value=A189326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189326.Bytes);
public long this[int i]=>Value[i];

public static A189326Inst Instance=new A189326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189327
{
public static readonly long[] Value={ 2L,6L,7L,12L,12L,18L,17L,24L,22L,30L,27L,36L,32L,42L,37L,48L,42L,54L,47L,60L,52L,66L,57L,72L,62L,78L,67L,84L,72L,90L,77L,96L,82L,102L,87L,108L,92L,114L,97L,120L,102L,126L,107L,132L,112L,138L,117L,144L,122L,150L,127L,156L,132L,162L,137L,168L,142L,174L,147L,180L,152L,186L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189327Inst : IEnumerable<long>
{
public static readonly long[] Value=A189327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189327.Bytes);
public long this[int i]=>Value[i];

public static A189327Inst Instance=new A189327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189328
{
public static readonly long[] Value={ 2L,8L,11L,20L,21L,36L,31L,49L,42L,63L,51L,79L,60L,93L,72L,105L,80L,125L,89L,133L,104L,149L,109L,168L,117L,178L,135L,190L,138L,213L,147L,219L,166L,234L,166L,257L,176L,263L,197L,274L,196L,303L,205L,304L,227L,319L,225L,346L,234L,347L,259L,360L,254L,392L,262L,389L,290L,404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189328Inst : IEnumerable<long>
{
public static readonly long[] Value=A189328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189328.Bytes);
public long this[int i]=>Value[i];

public static A189328Inst Instance=new A189328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189329
{
public static readonly long[] Value={ 2L,10L,16L,32L,33L,64L,51L,95L,76L,122L,91L,166L,102L,185L,141L,214L,137L,272L,155L,277L,201L,304L,191L,380L,199L,366L,272L,396L,237L,480L,253L,462L,335L,483L,286L,593L,299L,545L,403L,584L,335L,684L,353L,648L,465L,660L,388L,808L,395L,726L,531L,767L,435L,896L,456L,826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189329Inst : IEnumerable<long>
{
public static readonly long[] Value=A189329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189329.Bytes);
public long this[int i]=>Value[i];

public static A189329Inst Instance=new A189329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189330
{
public static readonly long[] Value={ 2L,12L,22L,49L,54L,110L,91L,179L,154L,238L,190L,360L,215L,376L,333L,453L,290L,604L,334L,607L,478L,634L,411L,904L,428L,771L,658L,882L,504L,1132L,537L,1023L,832L,1023L,627L,1453L,625L,1158L,1007L,1336L,710L,1614L,753L,1459L,1191L,1398L,825L,2016L,831L,1574L,1337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189330Inst : IEnumerable<long>
{
public static readonly long[] Value=A189330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189330.Bytes);
public long this[int i]=>Value[i];

public static A189330Inst Instance=new A189330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189331
{
public static readonly long[] Value={ 2L,14L,28L,70L,84L,179L,157L,321L,283L,461L,390L,720L,482L,784L,747L,988L,684L,1299L,796L,1371L,1121L,1395L,973L,2066L,1061L,1707L,1531L,2058L,1207L,2624L,1282L,2386L,1968L,2303L,1599L,3439L,1482L,2615L,2372L,3304L,1705L,3744L,1798L,3430L,2993L,3157L,1975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189331Inst : IEnumerable<long>
{
public static readonly long[] Value=A189331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189331.Bytes);
public long this[int i]=>Value[i];

public static A189331Inst Instance=new A189331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189332
{
public static readonly long[] Value={ 2L,16L,34L,94L,119L,275L,253L,548L,477L,845L,725L,1375L,951L,1608L,1522L,2126L,1511L,2758L,1809L,3130L,2557L,3125L,2312L,4710L,2551L,3930L,3502L,4942L,2922L,6053L,3105L,5798L,4483L,5381L,4049L,8173L,3634L,6207L,5339L,8368L,4204L,8795L,4353L,8395L,7148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189332Inst : IEnumerable<long>
{
public static readonly long[] Value=A189332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189332.Bytes);
public long this[int i]=>Value[i];

public static A189332Inst Instance=new A189332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189333
{
public static readonly long[] Value={ 2L,18L,40L,120L,157L,393L,374L,866L,775L,1426L,1261L,2448L,1761L,3006L,2890L,4232L,3063L,5605L,3802L,6615L,5533L,6899L,5188L,10472L,5864L,8986L,7964L,11411L,7088L,13830L,7645L,13841L,10360L,12801L,9755L,19139L,9300L,15031L,12334L,20347L,10558L,20918L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189333Inst : IEnumerable<long>
{
public static readonly long[] Value=A189333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189333.Bytes);
public long this[int i]=>Value[i];

public static A189333Inst Instance=new A189333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189334
{
public static readonly long[] Value={ 1L,4L,36L,340L,3220L,30500L,288900L,2736500L,25920500L,245522500L,2325622500L,22028612500L,208658012500L,1976437062500L,18721080562500L,177328620312500L,1679680800312500L,15910164901562500L,150703245014062500L,1427481625632812500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189334Inst : IEnumerable<long>
{
public static readonly long[] Value=A189334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189334.Bytes);
public long this[int i]=>Value[i];

public static A189334Inst Instance=new A189334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189335
{
public static readonly long[] Value={ 2L,16L,512L,36626L,6814820L,2650369322L,2739456017053L,6190300153637745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189335Inst : IEnumerable<long>
{
public static readonly long[] Value=A189335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189335.Bytes);
public long this[int i]=>Value[i];

public static A189335Inst Instance=new A189335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189336
{
public static readonly long[] Value={ 4L,16L,64L,225L,784L,2704L,9409L,32761L,114244L,398161L,1387684L,4835601L,16851025L,58721569L,204633025L,713103616L,2485022500L,8659791364L,30177596089L,105162706944L,366470415424L,1277074025929L,4450340433889L,15508521343396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189336Inst : IEnumerable<long>
{
public static readonly long[] Value=A189336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189336.Bytes);
public long this[int i]=>Value[i];

public static A189336Inst Instance=new A189336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189337
{
public static readonly long[] Value={ 8L,64L,512L,3375L,21952L,140608L,912673L,5929741L,38614472L,251239591L,1634691752L,10633486599L,69173457625L,449983383247L,2927275422625L,19042718961664L,123878371625000L,805862864751112L,5242361459792813L,34103003909455872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189337Inst : IEnumerable<long>
{
public static readonly long[] Value=A189337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189337.Bytes);
public long this[int i]=>Value[i];

public static A189337Inst Instance=new A189337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189338
{
public static readonly long[] Value={ 15L,225L,3375L,36626L,390721L,3988168L,42069350L,442969881L,4709354541L,49857094654L,528436125424L,5591212296038L,59196669906872L,626540356943069L,6633322246811551L,70220475509151710L,743409267344795743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189338Inst : IEnumerable<long>
{
public static readonly long[] Value=A189338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189338.Bytes);
public long this[int i]=>Value[i];

public static A189338Inst Instance=new A189338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189339
{
public static readonly ulong[] Value={ 28L,784L,21952L,390721L,6814820L,109746642L,1857004061L,31177656076L,533269057178L,9053472938552L,154252966185542L,2618674812680579L,44520074517291894L,756141322418868556L,12851400623635035810UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189339Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A189339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189339.Bytes);
public ulong this[int i]=>Value[i];

public static A189339Inst Instance=new A189339Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189372
{
public static readonly long[] Value={ 1L,3L,5L,7L,10L,11L,14L,16L,18L,20L,21L,24L,26L,28L,30L,33L,34L,37L,39L,40L,43L,44L,47L,49L,51L,53L,56L,57L,59L,61L,63L,66L,67L,70L,72L,74L,76L,78L,80L,82L,84L,86L,89L,90L,93L,95L,97L,99L,100L,103L,105L,107L,109L,112L,113L,116L,118L,119L,122L,123L,126L,128L,130L,132L,135L,136L,138L,141L,142L,145L,146L,149L,151L,153L,155L,157L,159L,161L,163L,165L,168L,169L,172L,174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189372Inst : IEnumerable<long>
{
public static readonly long[] Value=A189372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189372.Bytes);
public long this[int i]=>Value[i];

public static A189372Inst Instance=new A189372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189373
{
public static readonly long[] Value={ 6L,28L,33550336L,137438691328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189373Inst : IEnumerable<long>
{
public static readonly long[] Value=A189373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189373.Bytes);
public long this[int i]=>Value[i];

public static A189373Inst Instance=new A189373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189374
{
public static readonly long[] Value={ 1L,2L,3L,7L,11L,15L,25L,35L,45L,65L,85L,105L,140L,175L,210L,266L,322L,378L,462L,546L,630L,750L,870L,990L,1155L,1320L,1485L,1705L,1925L,2145L,2431L,2717L,3003L,3367L,3731L,4095L,4550L,5005L,5460L,6020L,6580L,7140L,7820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189374Inst : IEnumerable<long>
{
public static readonly long[] Value=A189374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189374.Bytes);
public long this[int i]=>Value[i];

public static A189374Inst Instance=new A189374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189375
{
public static readonly long[] Value={ 1L,2L,3L,4L,8L,12L,16L,20L,30L,40L,50L,60L,80L,100L,120L,140L,175L,210L,245L,280L,336L,392L,448L,504L,588L,672L,756L,840L,960L,1080L,1200L,1320L,1485L,1650L,1815L,1980L,2200L,2420L,2640L,2860L,3146L,3432L,3718L,4004L,4368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189375Inst : IEnumerable<long>
{
public static readonly long[] Value=A189375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189375.Bytes);
public long this[int i]=>Value[i];

public static A189375Inst Instance=new A189375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189376
{
public static readonly long[] Value={ 1L,3L,6L,10L,17L,27L,40L,56L,78L,106L,140L,180L,230L,290L,360L,440L,535L,645L,770L,910L,1071L,1253L,1456L,1680L,1932L,2212L,2520L,2856L,3228L,3636L,4080L,4560L,5085L,5655L,6270L,6930L,7645L,8415L,9240L,10120L,11066L,12078L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189376Inst : IEnumerable<long>
{
public static readonly long[] Value=A189376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189376.Bytes);
public long this[int i]=>Value[i];

public static A189376Inst Instance=new A189376Inst();

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