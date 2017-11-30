using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A286858
{
public static readonly long[] Value={ 1L,1L,7L,7L,23L,31L,95L,127L,287L,511L,1151L,2047L,4607L,8191L,18431L,32767L,66047L,131071L,264191L,327679L,1056767L,1310719L,4227071L,5242879L,16908287L,20971519L,67633151L,83886079L,270532607L,335544319L,1082130431L,1342177279L,4295098367L,5368709119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286858Inst : IEnumerable<long>
{
public static readonly long[] Value=A286858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286858.Bytes);
public long this[int i]=>Value[i];

public static A286858Inst Instance=new A286858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286857
{
public static readonly long[] Value={ 1L,2L,7L,14L,29L,62L,125L,254L,497L,1022L,2033L,4094L,8177L,16382L,32753L,65534L,130817L,262142L,524033L,1048562L,2096897L,4194290L,8388353L,16777202L,33554177L,67108850L,134217473L,268435442L,536870657L,1073741810L,2147483393L,4294967282L,8589869057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286857Inst : IEnumerable<long>
{
public static readonly long[] Value=A286857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286857.Bytes);
public long this[int i]=>Value[i];

public static A286857Inst Instance=new A286857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286856
{
public static readonly long[] Value={ 1L,1L,111L,111L,10111L,11111L,1011111L,1111111L,100011111L,111111111L,10001111111L,11111111111L,1000111111111L,1111111111111L,100011111111111L,111111111111111L,10000000111111111L,11111111111111111L,1000000011111111111L,1001111111111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286856Inst : IEnumerable<long>
{
public static readonly long[] Value=A286856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286856.Bytes);
public long this[int i]=>Value[i];

public static A286856Inst Instance=new A286856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286855
{
public static readonly ulong[] Value={ 1L,10L,111L,1110L,11101L,111110L,1111101L,11111110L,111110001L,1111111110L,11111110001L,111111111110L,1111111110001L,11111111111110L,111111111110001L,1111111111111110L,11111111100000001L,111111111111111110L,1111111111100000001L,11111111111111110010UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286855Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A286855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286855.Bytes);
public ulong this[int i]=>Value[i];

public static A286855Inst Instance=new A286855Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286518
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,1L,4L,2L,4L,1L,20L,1L,4L,4L,8L,1L,20L,1L,20L,4L,4L,1L,88L,2L,4L,4L,20L,1L,96L,1L,16L,4L,4L,4L,196L,1L,4L,4L,88L,1L,96L,1L,20L,20L,4L,1L,368L,2L,20L,4L,20L,1L,88L,4L,88L,4L,4L,1L,1824L,1L,4L,20L,32L,4L,96L,1L,20L,4L,96L,1L,1688L,1L,4L,20L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286518Inst : IEnumerable<long>
{
public static readonly long[] Value=A286518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286518.Bytes);
public long this[int i]=>Value[i];

public static A286518Inst Instance=new A286518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286517
{
public static readonly long[] Value={ 3L,5L,7L,3L,11L,13L,5L,17L,19L,7L,23L,5L,3L,29L,31L,11L,35L,37L,13L,41L,43L,1L,47L,7L,17L,53L,55L,19L,59L,61L,7L,13L,67L,23L,71L,73L,5L,77L,79L,3L,83L,17L,29L,89L,13L,31L,19L,97L,11L,101L,103L,7L,107L,109L,37L,113L,23L,13L,119L,11L,41L,5L,127L,43L,131L,19L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286517Inst : IEnumerable<long>
{
public static readonly long[] Value=A286517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286517.Bytes);
public long this[int i]=>Value[i];

public static A286517Inst Instance=new A286517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286516
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,3L,7L,2L,3L,5L,11L,1L,13L,7L,15L,2L,17L,3L,19L,5L,7L,11L,23L,1L,5L,13L,3L,7L,29L,5L,31L,2L,11L,17L,7L,1L,37L,19L,13L,5L,41L,21L,43L,11L,3L,23L,47L,1L,7L,5L,17L,13L,53L,3L,11L,7L,19L,29L,59L,1L,61L,31L,7L,2L,65L,11L,67L,17L,23L,5L,71L,1L,73L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286516Inst : IEnumerable<long>
{
public static readonly long[] Value=A286516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286516.Bytes);
public long this[int i]=>Value[i];

public static A286516Inst Instance=new A286516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286515
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,6L,1L,6L,1L,10L,1L,6L,1L,210L,5L,6L,1L,30L,5L,210L,7L,330L,5L,30L,1L,546L,7L,14L,1L,30L,1L,462L,77L,3570L,35L,6L,1L,51870L,455L,210L,7L,2310L,55L,2310L,7L,4830L,35L,210L,1L,6630L,221L,858L,11L,330L,55L,798L,19L,870L,5L,30L,1L,930930L,5005L,4290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286515Inst : IEnumerable<long>
{
public static readonly long[] Value=A286515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286515.Bytes);
public long this[int i]=>Value[i];

public static A286515Inst Instance=new A286515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286514
{
public static readonly long[] Value={ 1L,3L,3L,5L,11L,7L,9L,41L,51L,11L,17L,149L,383L,183L,21L,31L,547L,2865L,2629L,663L,39L,57L,2007L,21449L,38437L,18635L,2435L,71L,105L,7361L,160579L,561743L,531669L,133709L,8935L,131L,193L,27001L,1202181L,8207075L,15179657L,7455797L,956009L,32775L,241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286514Inst : IEnumerable<long>
{
public static readonly long[] Value=A286514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286514.Bytes);
public long this[int i]=>Value[i];

public static A286514Inst Instance=new A286514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286513
{
public static readonly long[] Value={ 1L,1L,3L,1L,7L,4L,1L,17L,13L,7L,1L,41L,43L,35L,11L,1L,99L,142L,181L,81L,18L,1L,239L,469L,933L,621L,199L,29L,1L,577L,1549L,4811L,4741L,2309L,477L,47L,1L,1393L,5116L,24807L,36211L,26660L,8303L,1155L,76L,1L,3363L,16897L,127913L,276561L,307983L,143697L,30277L,2785L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286513Inst : IEnumerable<long>
{
public static readonly long[] Value=A286513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286513.Bytes);
public long this[int i]=>Value[i];

public static A286513Inst Instance=new A286513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286512
{
public static readonly long[] Value={ 17L,31L,63L,86L,91L,103L,118L,133L,155L,157L,211L,270L,290L,301L,338L,352L,421L,432L,440L,441L,450L,478L,513L,533L,693L,853L,1051L,1237L,1363L,1459L,1526L,1665L,2781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286512Inst : IEnumerable<long>
{
public static readonly long[] Value=A286512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286512.Bytes);
public long this[int i]=>Value[i];

public static A286512Inst Instance=new A286512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286511
{
public static readonly long[] Value={ 1L,1L,3L,1L,7L,10L,17L,1L,22L,29L,35L,40L,28L,74L,5L,1L,70L,73L,90L,109L,103L,125L,30L,89L,158L,172L,165L,123L,171L,212L,228L,262L,242L,52L,264L,274L,167L,349L,1L,383L,288L,423L,404L,445L,412L,394L,514L,427L,478L,527L,626L,229L,602L,581L,536L,665L,710L,698L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286511Inst : IEnumerable<long>
{
public static readonly long[] Value=A286511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286511.Bytes);
public long this[int i]=>Value[i];

public static A286511Inst Instance=new A286511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286510
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,4L,2L,1L,6L,5L,2L,9L,11L,12L,5L,7L,9L,8L,8L,17L,12L,11L,16L,12L,23L,20L,16L,17L,17L,23L,17L,26L,18L,19L,25L,26L,32L,38L,21L,21L,18L,27L,25L,24L,27L,52L,30L,44L,33L,19L,44L,54L,45L,57L,14L,29L,27L,39L,58L,28L,41L,39L,62L,26L,25L,69L,48L,51L,61L,44L,47L,37L,63L,77L,55L,55L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286510Inst : IEnumerable<long>
{
public static readonly long[] Value=A286510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286510.Bytes);
public long this[int i]=>Value[i];

public static A286510Inst Instance=new A286510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286509
{
public static readonly long[] Value={ 1L,1L,0L,1L,-1L,0L,1L,-2L,1L,0L,1L,-3L,3L,0L,0L,1L,-4L,6L,-2L,-1L,0L,1L,-5L,10L,-7L,-1L,1L,0L,1L,-6L,15L,-16L,3L,4L,-1L,0L,1L,-7L,21L,-30L,15L,6L,-6L,1L,0L,1L,-8L,28L,-50L,40L,0L,-17L,6L,0L,0L,1L,-9L,36L,-77L,84L,-26L,-30L,24L,-3L,-1L,0L,1L,-10L,45L,-112L,154L,-90L,-30L,64L,-21L,-2L,2L,0L,1L,-11L,55L,-156L,258L,-217L,15L,125L,-81L,6L,9L,-3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286509Inst : IEnumerable<long>
{
public static readonly long[] Value=A286509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286509.Bytes);
public long this[int i]=>Value[i];

public static A286509Inst Instance=new A286509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286508
{
public static readonly long[] Value={ 1L,10L,10L,100L,100L,1000L,1000L,10000L,10000L,100000L,100000L,1000000L,1000000L,10000000L,10000000L,100000000L,100000000L,1000000000L,1000000000L,10000000000L,10000000000L,100000000000L,100000000000L,1000000000000L,1000000000000L,10000000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286508Inst : IEnumerable<long>
{
public static readonly long[] Value=A286508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286508.Bytes);
public long this[int i]=>Value[i];

public static A286508Inst Instance=new A286508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286507
{
public static readonly long[] Value={ 1L,1L,10L,10L,100L,100L,1000L,1000L,10000L,10000L,100000L,100000L,1000000L,1000000L,10000000L,10000000L,100000000L,100000000L,1000000000L,1000000000L,10000000000L,10000000000L,100000000000L,100000000000L,1000000000000L,1000000000000L,10000000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286507Inst : IEnumerable<long>
{
public static readonly long[] Value=A286507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286507.Bytes);
public long this[int i]=>Value[i];

public static A286507Inst Instance=new A286507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286506
{
public static readonly long[] Value={ 1L,1L,0L,7L,24L,15L,96L,63L,0L,1023L,0L,4095L,0L,4095L,24576L,16383L,0L,262143L,196608L,393215L,786432L,2097151L,3145728L,6291455L,14680064L,4194303L,58720256L,218103807L,67108864L,973078527L,0L,4294967295L,0L,536870911L,29527900160L,2147483647L,109521666048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286506Inst : IEnumerable<long>
{
public static readonly long[] Value=A286506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286506.Bytes);
public long this[int i]=>Value[i];

public static A286506Inst Instance=new A286506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286505
{
public static readonly long[] Value={ 1L,2L,0L,14L,3L,60L,3L,252L,0L,1023L,0L,4095L,0L,16380L,3L,65532L,0L,262143L,6L,1048570L,6L,4194302L,6L,16777210L,14L,67108848L,14L,268435443L,4L,1073741799L,0L,4294967295L,0L,17179869152L,59L,68719476704L,51L,274877906936L,51L,1099511627728L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286505Inst : IEnumerable<long>
{
public static readonly long[] Value=A286505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286505.Bytes);
public long this[int i]=>Value[i];

public static A286505Inst Instance=new A286505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286504
{
public static readonly BigInteger[] Value={ 1L,1L,0L,111L,11000L,1111L,1100000L,111111L,0L,1111111111L,0L,111111111111L,0L,111111111111L,110000000000000L,11111111111111L,0L,111111111111111111L,110000000000000000L,1011111111111111111L,11000000000000000000UL,BigInteger.Parse("111111111111111111111"),BigInteger.Parse("1100000000000000000000") };
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
public class A286504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286504Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286504.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286504.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286504Inst Instance=new A286504Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286503
{
public static readonly BigInteger[] Value={ 1L,10L,0L,1110L,11L,111100L,11L,11111100L,0L,1111111111L,0L,111111111111L,0L,11111111111100L,11L,1111111111111100L,0L,111111111111111111L,110L,11111111111111111010UL,110L,BigInteger.Parse("1111111111111111111110"),110L,BigInteger.Parse("111111111111111111111010"),1110L,BigInteger.Parse("11111111111111111111110000") };
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
public class A286503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286503Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286503.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286503.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286503Inst Instance=new A286503Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286454
{
public static readonly long[] Value={ 1L,5L,8L,9L,12L,32L,23L,20L,13L,49L,38L,51L,47L,82L,49L,35L,68L,51L,80L,72L,124L,140L,122L,74L,18L,175L,26L,111L,155L,334L,192L,65L,257L,280L,82L,116L,255L,329L,355L,99L,327L,570L,380L,177L,72L,469L,437L,132L,31L,72L,532L,216L,498L,74L,257L,144L,599L,634L,597L,448L,632L,745L,159L,119L,784L,1044L,782L,331L,907L,570L,863L,186L,905L,1039L,72L,384L,140L,1335L,1037L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286454Inst : IEnumerable<long>
{
public static readonly long[] Value=A286454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286454.Bytes);
public long this[int i]=>Value[i];

public static A286454Inst Instance=new A286454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286453
{
public static readonly long[] Value={ 0L,2L,5L,11L,94L,5L,14L,254L,17L,9L,195L,47L,259L,500L,9L,11L,413L,138L,44L,303L,32L,20L,2784L,47L,354L,216L,5L,329L,506L,9L,77L,3161L,356L,35L,175L,107L,202L,2709L,216L,24L,11188L,14L,420L,356L,24L,285L,450L,498L,70L,2349L,35L,51L,115937L,5L,20L,329L,74L,310L,3420L,864L,1243L,336L,500L,11L,384L,20L,580L,47285L,87L,14L,615L,498L,1296L,3015L,9L,74L,3491L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286453Inst : IEnumerable<long>
{
public static readonly long[] Value=A286453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286453.Bytes);
public long this[int i]=>Value[i];

public static A286453Inst Instance=new A286453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286452
{
public static readonly long[] Value={ 0L,2L,5L,2L,18L,5L,14L,16L,5L,9L,50L,5L,42L,59L,9L,2L,73L,23L,44L,31L,14L,20L,199L,5L,18L,61L,5L,40L,115L,9L,77L,67L,50L,35L,40L,5L,90L,179L,61L,9L,391L,14L,185L,50L,9L,100L,205L,23L,14L,94L,35L,27L,1006L,5L,20L,40L,44L,115L,395L,31L,228L,131L,59L,2L,61L,20L,295L,442L,54L,14L,320L,23L,346L,265L,9L,44L,125L,61L,275L,31L,23L,104L,1349L,14L,52L,314L,65L,125L,430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286452Inst : IEnumerable<long>
{
public static readonly long[] Value=A286452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286452.Bytes);
public long this[int i]=>Value[i];

public static A286452Inst Instance=new A286452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286451
{
public static readonly long[] Value={ 0L,2L,6L,4L,3L,9L,10L,7L,1L,5L,6L,13L,3L,14L,10L,11L,3L,2L,6L,8L,21L,9L,10L,18L,1L,5L,10L,19L,3L,14L,21L,16L,15L,5L,15L,4L,3L,9L,10L,12L,3L,27L,6L,13L,3L,14L,15L,24L,1L,2L,10L,8L,3L,14L,10L,25L,15L,5L,6L,19L,3L,27L,10L,22L,6L,20L,6L,8L,21L,20L,10L,7L,3L,5L,6L,13L,21L,14L,15L,17L,1L,5L,6L,34L,6L,9L,10L,18L,3L,5L,15L,19L,36L,20L,10L,31L,3L,2L,6L,4L,3L,14L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286451Inst : IEnumerable<long>
{
public static readonly long[] Value=A286451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286451.Bytes);
public long this[int i]=>Value[i];

public static A286451Inst Instance=new A286451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286450
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,6L,3L,2L,7L,8L,1L,9L,10L,11L,12L,7L,13L,14L,5L,15L,16L,17L,14L,18L,19L,20L,21L,22L,23L,24L,12L,25L,1L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,1L,5L,56L,31L,57L,58L,59L,7L,60L,61L,62L,17L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286450Inst : IEnumerable<long>
{
public static readonly long[] Value=A286450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286450.Bytes);
public long this[int i]=>Value[i];

public static A286450Inst Instance=new A286450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286449
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,4L,5L,1L,6L,2L,7L,8L,9L,3L,5L,1L,10L,11L,12L,13L,7L,14L,15L,16L,17L,7L,18L,4L,19L,16L,20L,1L,12L,18L,15L,21L,22L,10L,15L,23L,24L,16L,25L,3L,9L,26L,27L,28L,29L,30L,20L,5L,31L,16L,32L,33L,34L,35L,36L,37L,38L,19L,15L,1L,27L,16L,39L,7L,25L,8L,40L,41L,42L,34L,35L,9L,36L,16L,43L,44L,29L,32L,45L,46L,47L,24L,48L,8L,49L,50L,40L,10L,36L,51L,40L,52L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286449Inst : IEnumerable<long>
{
public static readonly long[] Value=A286449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286449.Bytes);
public long this[int i]=>Value[i];

public static A286449Inst Instance=new A286449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286448
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,3L,5L,6L,2L,7L,8L,7L,9L,9L,10L,11L,12L,11L,13L,14L,15L,16L,17L,1L,1L,18L,19L,20L,21L,22L,23L,1L,24L,6L,25L,26L,27L,6L,28L,29L,30L,29L,31L,32L,15L,33L,34L,13L,35L,27L,10L,36L,37L,38L,39L,2L,40L,41L,42L,43L,44L,45L,46L,24L,47L,48L,49L,6L,50L,51L,52L,53L,22L,54L,55L,24L,56L,57L,58L,59L,60L,61L,62L,63L,64L,38L,65L,66L,67L,9L,68L,1L,69L,69L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286448Inst : IEnumerable<long>
{
public static readonly long[] Value=A286448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286448.Bytes);
public long this[int i]=>Value[i];

public static A286448Inst Instance=new A286448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286447
{
public static readonly BigInteger[] Value={ 1L,1L,2L,228L,252642L,3286762710L,423091508279496L,BigInteger.Parse("488322998306377824150"),BigInteger.Parse("5405955851967092442258037800"),BigInteger.Parse("561273297862912365721571649672300480"),BigInteger.Parse("524055990531978935668322776302483856990581000") };
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
public class A286447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286447Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286447.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286447.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286447Inst Instance=new A286447Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286446
{
public static readonly long[] Value={ 0L,1L,6L,142L,1280L,7301L,29603L,96485L,266636L,652908L,1452054L,2992513L,5789499L,10629381L,18660890L,31530854L,51525116L,81772345L,126449707L,191075297L,282794784L,410784700L,586640186L,824912741L,1143620051L,1564946921L,2115898646L,2829194838L,3744093216L,4907506597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286446Inst : IEnumerable<long>
{
public static readonly long[] Value=A286446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286446.Bytes);
public long this[int i]=>Value[i];

public static A286446Inst Instance=new A286446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286445
{
public static readonly long[] Value={ 0L,2L,14L,97L,398L,1290L,3366L,7731L,15888L,30248L,53850L,91147L,147496L,230290L,348148L,512457L,736204L,1035986L,1430420L,1942691L,2598470L,3429064L,4468784L,5758755L,7343670L,9276330L,11613714L,14422313L,17773458L,21749506L,26438362L,31940587L,38363044L,45826992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286445Inst : IEnumerable<long>
{
public static readonly long[] Value=A286445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286445.Bytes);
public long this[int i]=>Value[i];

public static A286445Inst Instance=new A286445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286444
{
public static readonly long[] Value={ 0L,3L,10L,32L,70L,143L,252L,424L,660L,995L,1430L,2008L,2730L,3647L,4760L,6128L,7752L,9699L,11970L,14640L,17710L,21263L,25300L,29912L,35100L,40963L,47502L,54824L,62930L,71935L,81840L,92768L,104720L,117827L,132090L,147648L,164502L,182799L,202540L,223880L,246820L,271523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286444Inst : IEnumerable<long>
{
public static readonly long[] Value=A286444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286444.Bytes);
public long this[int i]=>Value[i];

public static A286444Inst Instance=new A286444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286443
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,3L,3L,2L,1L,1L,4L,10L,14L,6L,1L,6L,32L,97L,142L,105L,46L,14L,3L,1L,1L,8L,70L,398L,1280L,2386L,2574L,1569L,524L,87L,3L,1L,11L,143L,1290L,7301L,26471L,62067L,94423L,93358L,60287L,25881L,7697L,1678L,281L,40L,5L,1L,1L,13L,252L,3366L,29603L,176591L,728868L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286443Inst : IEnumerable<long>
{
public static readonly long[] Value=A286443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286443.Bytes);
public long this[int i]=>Value[i];

public static A286443Inst Instance=new A286443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286442
{
public static readonly long[] Value={ 0L,57L,9233L,563287L,12649059L,152516103L,1211235921L,7147857411L,33812251267L,134823778299L,469266000129L,1462057867743L,4154650828483L,10922915001087L,26867398129329L,62381437357035L,137705497065315L,290721776912275L,589883390417697L,1155073034088999L,2190429436721571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286442Inst : IEnumerable<long>
{
public static readonly long[] Value=A286442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286442.Bytes);
public long this[int i]=>Value[i];

public static A286442Inst Instance=new A286442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286441
{
public static readonly long[] Value={ 0L,219L,15160L,369787L,4366982L,32450843L,175628996L,755759531L,2734928266L,8643796747L,24503068784L,63522668395L,152816062222L,345005930315L,737473609532L,1503178571195L,2938515130514L,5535661080283L,10089397100584L,17851538034587L,30750030827926L,51694565135803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286441Inst : IEnumerable<long>
{
public static readonly long[] Value=A286441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286441.Bytes);
public long this[int i]=>Value[i];

public static A286441Inst Instance=new A286441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286440
{
public static readonly long[] Value={ 0L,546L,14064L,157248L,1056516L,5086902L,19399860L,62311740L,175452816L,445146906L,1037833944L,2255992584L,4622997276L,9007684494L,16802136156L,30169344996L,52381036968L,88270019922L,144826036032L,231969248016L,363541216308L,558559556262L,842789431428L,1250692671180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286440Inst : IEnumerable<long>
{
public static readonly long[] Value=A286440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286440.Bytes);
public long this[int i]=>Value[i];

public static A286440Inst Instance=new A286440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286439
{
public static readonly long[] Value={ 0L,1L,25L,747L,7459L,42983L,176373L,575775L,1595487L,3908979L,8701313L,17936083L,34713675L,63739327L,111921149L,189119943L,309074343L,490526475L,758575017L,1146284219L,1696579123L,2464458903L,3519561925L,4949117807L,6861323439L,9389181603L,12694842513L,16974490275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286439Inst : IEnumerable<long>
{
public static readonly long[] Value=A286439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286439.Bytes);
public long this[int i]=>Value[i];

public static A286439Inst Instance=new A286439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286390
{
public static readonly long[] Value={ 0L,2L,-1L,3L,-5L,7L,-12L,20L,-31L,51L,-83L,133L,-216L,350L,-565L,915L,-1481L,2395L,-3876L,6272L,-10147L,16419L,-26567L,42985L,-69552L,112538L,-182089L,294627L,-476717L,771343L,-1248060L,2019404L,-3267463L,5286867L,-8554331L,13841197L,-22395528L,36236726L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286390Inst : IEnumerable<long>
{
public static readonly long[] Value=A286390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286390.Bytes);
public long this[int i]=>Value[i];

public static A286390Inst Instance=new A286390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286389
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,4L,4L,5L,6L,7L,8L,8L,9L,10L,10L,11L,12L,13L,14L,14L,15L,16L,16L,17L,18L,18L,19L,20L,20L,21L,22L,23L,24L,24L,25L,26L,26L,27L,28L,29L,30L,30L,31L,32L,32L,33L,34L,34L,35L,36L,36L,37L,38L,39L,40L,40L,41L,42L,42L,43L,44L,45L,46L,46L,47L,48L,48L,49L,50L,51L,52L,52L,53L,54L,54L,55L,56L,57L,58L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286389Inst : IEnumerable<long>
{
public static readonly long[] Value=A286389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286389.Bytes);
public long this[int i]=>Value[i];

public static A286389Inst Instance=new A286389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286388
{
public static readonly long[] Value={ 0L,1L,4L,3L,2L,6L,7L,10L,9L,15L,4L,21L,2L,28L,41L,36L,2L,45L,4L,55L,35L,66L,7L,78L,20L,91L,64L,105L,2L,120L,16L,136L,77L,153L,43L,171L,2L,190L,133L,210L,2L,231L,4L,253L,135L,276L,11L,300L,35L,325L,188L,351L,2L,378L,102L,406L,209L,435L,4L,465L,2L,496L,372L,528L,104L,561L,4L,595L,299L,630L,7L,666L,2L,703L,376L,741L,77L,780L,11L,820L,405L,861L,4L,903L,170L,946L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286388Inst : IEnumerable<long>
{
public static readonly long[] Value=A286388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286388.Bytes);
public long this[int i]=>Value[i];

public static A286388Inst Instance=new A286388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286387
{
public static readonly long[] Value={ 0L,1L,1L,4L,1L,7L,4L,9L,1L,14L,7L,13L,4L,29L,9L,16L,1L,23L,14L,43L,7L,36L,13L,29L,4L,43L,29L,64L,9L,67L,16L,25L,1L,34L,23L,89L,14L,115L,43L,46L,7L,85L,36L,79L,13L,46L,29L,79L,4L,97L,43L,142L,29L,89L,64L,91L,9L,136L,67L,157L,16L,121L,25L,36L,1L,47L,34L,151L,23L,236L,89L,157L,14L,211L,115L,104L,43L,225L,46L,109L,7L,162L,85L,235L,36L,139L,79L,174L,13L,101L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286387Inst : IEnumerable<long>
{
public static readonly long[] Value=A286387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286387.Bytes);
public long this[int i]=>Value[i];

public static A286387Inst Instance=new A286387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286386
{
public static readonly long[] Value={ 3L,12L,14L,21L,10L,28L,14L,36L,31L,44L,14L,52L,10L,60L,46L,69L,10L,76L,14L,84L,62L,92L,14L,100L,43L,108L,78L,116L,10L,124L,14L,132L,94L,140L,58L,149L,10L,156L,110L,164L,10L,172L,14L,180L,126L,188L,14L,196L,63L,204L,142L,212L,10L,220L,90L,228L,158L,236L,14L,244L,10L,252L,174L,261L,106L,268L,14L,276L,190L,284L,14L,292L,10L,300L,206L,308L,94L,316L,14L,324L,223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286386Inst : IEnumerable<long>
{
public static readonly long[] Value=A286386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286386.Bytes);
public long this[int i]=>Value[i];

public static A286386Inst Instance=new A286386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286385
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,3L,3L,12L,12L,3L,1L,17L,3L,9L,11L,50L,1L,36L,3L,21L,23L,3L,5L,75L,18L,9L,85L,43L,1L,33L,5L,180L,17L,3L,29L,134L,3L,9L,29L,99L,1L,69L,3L,33L,97L,15L,5L,281L,64L,54L,23L,55L,5L,255L,19L,177L,35L,3L,1L,147L,5L,15L,171L,602L,35L,51L,3L,45L,49L,87L,1L,480L,5L,9L,121L,67L,47L,87L,3L,381L,504L,3L,5L,271L,25L,9L,35L,171L,7L,291L,75L,93L,57L,15L,41L,963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286385Inst : IEnumerable<long>
{
public static readonly long[] Value=A286385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286385.Bytes);
public long this[int i]=>Value[i];

public static A286385Inst Instance=new A286385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286384
{
public static readonly long[] Value={ 1L,2L,2L,2L,6L,4L,4L,8L,6L,12L,2L,8L,6L,2L,12L,2L,24L,12L,6L,24L,2L,12L,6L,16L,16L,2L,30L,6L,6L,36L,4L,12L,6L,72L,2L,24L,12L,2L,30L,48L,6L,32L,6L,2L,60L,12L,6L,32L,6L,6L,48L,12L,6L,60L,2L,2L,30L,12L,24L,72L,2L,6L,12L,6L,60L,12L,12L,216L,6L,6L,6L,48L,6L,2L,60L,48L,6L,60L,2L,96L,2L,12L,30L,2L,96L,12L,30L,6L,6L,180L,2L,24L,24L,8L,30L,64L,36L,2L,30L,6L,30L,144L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286384Inst : IEnumerable<long>
{
public static readonly long[] Value=A286384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286384.Bytes);
public long this[int i]=>Value[i];

public static A286384Inst Instance=new A286384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286383
{
public static readonly long[] Value={ 1L,2L,2L,6L,2L,4L,4L,12L,2L,8L,6L,12L,2L,6L,8L,24L,2L,12L,6L,24L,2L,6L,12L,36L,4L,6L,6L,30L,2L,16L,16L,48L,6L,32L,6L,60L,2L,6L,12L,72L,2L,12L,6L,30L,2L,12L,24L,72L,2L,6L,12L,30L,2L,24L,12L,60L,2L,12L,6L,48L,6L,6L,32L,96L,2L,12L,30L,96L,2L,30L,12L,180L,2L,6L,6L,30L,8L,24L,24L,216L,6L,6L,6L,60L,6L,12L,12L,60L,2L,48L,6L,60L,2L,6L,48L,144L,4L,30L,6L,30L,2L,64L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286383Inst : IEnumerable<long>
{
public static readonly long[] Value=A286383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286383.Bytes);
public long this[int i]=>Value[i];

public static A286383Inst Instance=new A286383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286382
{
public static readonly long[] Value={ 2L,5L,16L,12L,67L,9L,16L,23L,436L,80L,1771L,18L,67L,80L,1771L,668L,16111L,48L,277L,302L,7141L,2630L,64621L,156L,1129L,1178L,28681L,10442L,258841L,14L,16L,23L,436L,80L,1771L,31L,436L,467L,21946L,1832L,87991L,94L,1771L,1832L,87991L,16292L,793171L,328L,7141L,7262L,352381L,64982L,3173941L,1228L,28681L,28922L,1410361L,259562L,12698281L,25L,67L,80L,1771L,668L,16111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286382Inst : IEnumerable<long>
{
public static readonly long[] Value=A286382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286382.Bytes);
public long this[int i]=>Value[i];

public static A286382Inst Instance=new A286382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286381
{
public static readonly long[] Value={ 2L,5L,16L,12L,67L,9L,16L,23L,436L,80L,1771L,18L,67L,80L,1771L,668L,16111L,48L,277L,302L,7141L,2630L,64621L,14L,16L,23L,436L,80L,1771L,31L,436L,467L,21946L,1832L,87991L,94L,1771L,1832L,87991L,16292L,793171L,328L,7141L,7262L,352381L,64982L,3173941L,25L,67L,80L,1771L,668L,16111L,94L,1771L,1832L,87991L,16292L,793171L,706L,16111L,16292L,793171L,405452L,19841851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286381Inst : IEnumerable<long>
{
public static readonly long[] Value=A286381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286381.Bytes);
public long this[int i]=>Value[i];

public static A286381Inst Instance=new A286381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286380
{
public static readonly long[] Value={ 0L,1L,2L,1L,1L,3L,5L,1L,6L,2L,4L,3L,2L,6L,5L,1L,3L,7L,6L,2L,1L,5L,4L,3L,7L,3L,41L,6L,5L,6L,39L,1L,8L,4L,3L,7L,6L,7L,11L,2L,40L,2L,9L,5L,4L,5L,38L,3L,7L,8L,7L,3L,2L,42L,41L,6L,10L,6L,10L,6L,5L,40L,39L,1L,8L,9L,8L,4L,3L,4L,37L,7L,42L,7L,3L,7L,6L,12L,11L,2L,6L,41L,40L,2L,1L,10L,9L,5L,9L,5L,33L,5L,4L,39L,38L,3L,43L,8L,7L,8L,7L,8L,31L,3L,12L,3L,36L,42L,41L,42L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286380Inst : IEnumerable<long>
{
public static readonly long[] Value=A286380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286380.Bytes);
public long this[int i]=>Value[i];

public static A286380Inst Instance=new A286380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286379
{
public static readonly long[] Value={ 1L,2L,7L,5L,16L,18L,29L,14L,31L,50L,67L,42L,67L,98L,195L,44L,16L,100L,67L,115L,637L,242L,277L,117L,125L,289L,955L,224L,277L,450L,497L,152L,131L,248L,160L,271L,436L,454L,643L,320L,436L,1246L,1771L,550L,2716L,1058L,1129L,375L,160L,655L,1343L,692L,1771L,1918L,3332L,623L,880L,1355L,2557L,1020L,1129L,1922L,3507L,560L,166L,736L,67L,775L,1349L,1070L,277L,856L,436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286379Inst : IEnumerable<long>
{
public static readonly long[] Value=A286379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286379.Bytes);
public long this[int i]=>Value[i];

public static A286379Inst Instance=new A286379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286378
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,3L,5L,2L,6L,4L,7L,3L,8L,5L,9L,2L,10L,6L,11L,4L,12L,7L,13L,3L,13L,8L,14L,5L,15L,9L,16L,2L,17L,10L,18L,6L,19L,11L,20L,4L,21L,12L,22L,7L,23L,13L,24L,3L,24L,13L,25L,8L,26L,14L,27L,5L,28L,15L,29L,9L,30L,16L,31L,2L,32L,17L,33L,10L,34L,18L,35L,6L,36L,19L,37L,11L,38L,20L,39L,4L,40L,21L,41L,12L,42L,22L,43L,7L,44L,23L,45L,13L,46L,24L,47L,3L,47L,24L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286378Inst : IEnumerable<long>
{
public static readonly long[] Value=A286378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286378.Bytes);
public long this[int i]=>Value[i];

public static A286378Inst Instance=new A286378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286377
{
public static readonly BigInteger[] Value={ 1L,2L,2L,60L,2L,2520L,60L,138600L,2L,87318000L,2520L,189189000L,60L,792148896000000L,138600L,70756686000L,2L,2288271225240000L,87318000L,BigInteger.Parse("944154902157667200000000"),2520L,BigInteger.Parse("20388496616888400000000"),189189000L,BigInteger.Parse("127170673342713000000"),60L,BigInteger.Parse("701323506627727183200000000"),792148896000000L,BigInteger.Parse("21149759041410320377056000000000000000"),138600L };
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
public class A286377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286377Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286377.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286377.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286377Inst Instance=new A286377Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286376
{
public static readonly long[] Value={ 2L,2L,6L,2L,24L,6L,12L,2L,60L,24L,180L,6L,120L,12L,24L,2L,60L,60L,420L,24L,180L,180L,60L,6L,192L,120L,384L,12L,240L,24L,48L,2L,60L,60L,420L,60L,720L,420L,360L,24L,420L,180L,1260L,180L,4620L,60L,420L,6L,720L,192L,5040L,120L,5040L,384L,1680L,12L,1440L,240L,4320L,24L,480L,48L,96L,2L,60L,60L,420L,60L,2520L,420L,1260L,60L,420L,720L,1260L,420L,1260L,360L,180L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286376Inst : IEnumerable<long>
{
public static readonly long[] Value=A286376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286376.Bytes);
public long this[int i]=>Value[i];

public static A286376Inst Instance=new A286376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286375
{
public static readonly long[] Value={ 1L,2L,2L,36L,2L,96L,36L,840L,2L,1260L,96L,1260L,36L,2310L,840L,5040L,2L,1260L,1260L,69300L,96L,4620L,1260L,4320L,36L,1680L,2310L,12600L,840L,36960L,5040L,30240L,2L,1260L,1260L,831600L,1260L,415800L,69300L,2646000L,96L,27720L,4620L,900900L,1260L,221760L,4320L,277200L,36L,83160L,1680L,13860L,2310L,180180L,12600L,166320L,840L,15315300L,36960L,13860L,5040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286375Inst : IEnumerable<long>
{
public static readonly long[] Value=A286375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286375.Bytes);
public long this[int i]=>Value[i];

public static A286375Inst Instance=new A286375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286342
{
public static readonly long[] Value={ 2399L,3511L,4919L,6661L,2129L,11311L,14281L,17729L,21701L,26209L,26407L,37049L,43441L,50527L,252823L,66931L,64153L,86561L,19531L,109673L,122651L,136601L,151561L,167593L,184703L,202949L,222361L,242971L,50441L,287933L,261707L,338137L,365291L,393847L,79259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286342Inst : IEnumerable<long>
{
public static readonly long[] Value=A286342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286342.Bytes);
public long this[int i]=>Value[i];

public static A286342Inst Instance=new A286342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286341
{
public static readonly long[] Value={ 2L,5L,6L,9L,11L,14L,16L,17L,20L,23L,24L,27L,29L,30L,33L,36L,38L,41L,42L,45L,47L,50L,52L,53L,56L,59L,61L,64L,65L,68L,70L,71L,74L,77L,78L,81L,83L,86L,88L,89L,92L,95L,96L,99L,101L,102L,105L,108L,110L,113L,114L,117L,119L,120L,123L,126L,127L,130L,132L,135L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286341Inst : IEnumerable<long>
{
public static readonly long[] Value=A286341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286341.Bytes);
public long this[int i]=>Value[i];

public static A286341Inst Instance=new A286341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286340
{
public static readonly long[] Value={ 1L,3L,4L,7L,8L,10L,12L,13L,15L,18L,19L,21L,22L,25L,26L,28L,31L,32L,34L,35L,37L,39L,40L,43L,44L,46L,48L,49L,51L,54L,55L,57L,58L,60L,62L,63L,66L,67L,69L,72L,73L,75L,76L,79L,80L,82L,84L,85L,87L,90L,91L,93L,94L,97L,98L,100L,103L,104L,106L,107L,109L,111L,112L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286340Inst : IEnumerable<long>
{
public static readonly long[] Value=A286340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286340.Bytes);
public long this[int i]=>Value[i];

public static A286340Inst Instance=new A286340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286339
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286339Inst : IEnumerable<long>
{
public static readonly long[] Value=A286339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286339.Bytes);
public long this[int i]=>Value[i];

public static A286339Inst Instance=new A286339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286338
{
public static readonly long[] Value={ 5L,6L,9L,14L,16L,17L,23L,24L,27L,29L,30L,36L,41L,42L,45L,50L,52L,53L,59L,64L,65L,68L,70L,71L,77L,78L,81L,86L,88L,89L,95L,96L,99L,101L,102L,108L,113L,114L,117L,119L,120L,126L,127L,130L,135L,137L,138L,144L,149L,150L,153L,158L,160L,161L,167L,168L,171L,173L,174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286338Inst : IEnumerable<long>
{
public static readonly long[] Value=A286338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286338.Bytes);
public long this[int i]=>Value[i];

public static A286338Inst Instance=new A286338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286337
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,8L,10L,11L,12L,13L,15L,18L,19L,20L,21L,22L,25L,26L,28L,31L,32L,33L,34L,35L,37L,38L,39L,40L,43L,44L,46L,47L,48L,49L,51L,54L,55L,56L,57L,58L,60L,61L,62L,63L,66L,67L,69L,72L,73L,74L,75L,76L,79L,80L,82L,83L,84L,85L,87L,90L,91L,92L,93L,94L,97L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286337Inst : IEnumerable<long>
{
public static readonly long[] Value=A286337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286337.Bytes);
public long this[int i]=>Value[i];

public static A286337Inst Instance=new A286337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286336
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286336Inst : IEnumerable<long>
{
public static readonly long[] Value=A286336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286336.Bytes);
public long this[int i]=>Value[i];

public static A286336Inst Instance=new A286336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286335
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,3L,3L,2L,0L,1L,4L,6L,6L,2L,0L,1L,5L,10L,13L,9L,3L,0L,1L,6L,15L,24L,24L,14L,4L,0L,1L,7L,21L,40L,51L,42L,22L,5L,0L,1L,8L,28L,62L,95L,100L,73L,32L,6L,0L,1L,9L,36L,91L,162L,206L,190L,120L,46L,8L,0L,1L,10L,45L,128L,259L,384L,425L,344L,192L,66L,10L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286335Inst : IEnumerable<long>
{
public static readonly long[] Value=A286335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286335.Bytes);
public long this[int i]=>Value[i];

public static A286335Inst Instance=new A286335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286334
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,3L,1L,2L,3L,1L,3L,2L,3L,4L,1L,5L,3L,5L,2L,3L,4L,6L,1L,10L,6L,4L,7L,3L,7L,2L,7L,5L,3L,4L,5L,6L,7L,10L,17L,1L,18L,11L,8L,7L,6L,5L,4L,7L,10L,3L,11L,8L,5L,7L,11L,19L,2L,13L,9L,7L,5L,13L,8L,14L,3L,13L,10L,7L,11L,4L,13L,9L,5L,16L,11L,6L,13L,7L,8L,9L,10L,11L,13L,15L,18L,22L,28L,39L,66L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286334Inst : IEnumerable<long>
{
public static readonly long[] Value=A286334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286334.Bytes);
public long this[int i]=>Value[i];

public static A286334Inst Instance=new A286334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286333
{
public static readonly long[] Value={ 19L,23L,29L,41L,43L,47L,53L,59L,61L,67L,83L,89L,101L,103L,107L,127L,149L,157L,163L,181L,191L,307L,317L,331L,359L,367L,701L,709L,727L,739L,757L,761L,787L,797L,907L,937L,941L,947L,983L,1103L,1109L,1123L,1181L,1301L,1319L,1327L,1949L,1951L,1979L,1987L,1993L,3121L,3187L,3361L,3373L,3701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286333Inst : IEnumerable<long>
{
public static readonly long[] Value=A286333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286333.Bytes);
public long this[int i]=>Value[i];

public static A286333Inst Instance=new A286333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286332
{
public static readonly long[] Value={ 0L,2L,2L,1L,4L,3L,3L,1L,4L,2L,6L,5L,0L,2L,7L,1L,4L,3L,3L,1L,4L,7L,7L,5L,0L,2L,8L,4L,4L,6L,3L,1L,8L,7L,7L,5L,0L,2L,2L,1L,4L,6L,3L,1L,8L,2L,7L,5L,0L,2L,8L,1L,4L,6L,3L,1L,4L,2L,7L,5L,0L,2L,8L,1L,4L,6L,3L,1L,8L,7L,7L,5L,0L,2L,8L,1L,4L,6L,3L,1L,8L,2L,7L,5L,0L,2L,8L,1L,4L,6L,3L,1L,8L,2L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286332Inst : IEnumerable<long>
{
public static readonly long[] Value=A286332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286332.Bytes);
public long this[int i]=>Value[i];

public static A286332Inst Instance=new A286332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286331
{
public static readonly long[] Value={ 1L,1L,1L,1L,9L,6L,1L,49L,294L,168L,1L,225L,7350L,37800L,20160L,1L,961L,144150L,4036200L,19373760L,9999360L,1L,3969L,2542806L,326932200L,8543828160L,39687459840L,20158709760L,1L,16129L,42677334L,23435953128L,2812314375360L,71124337751040L,325139829719040L,163849992929280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286331Inst : IEnumerable<long>
{
public static readonly long[] Value=A286331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286331.Bytes);
public long this[int i]=>Value[i];

public static A286331Inst Instance=new A286331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286330
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,5L,7L,10L,11L,15L,19L,26L,32L,42L,50L,66L,78L,101L,118L,150L,178L,224L,263L,327L,382L,471L,551L,670L,781L,944L,1098L,1317L,1526L,1821L,2105L,2498L,2879L,3399L,3908L,4592L,5266L,6164L,7056L,8220L,9388L,10897L,12424L,14368L,16342L,18843L,21394L,24585L,27858L,31932L,36119L,41277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286330Inst : IEnumerable<long>
{
public static readonly long[] Value=A286330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286330.Bytes);
public long this[int i]=>Value[i];

public static A286330Inst Instance=new A286330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286329
{
public static readonly BigInteger[] Value={ 1L,-104L,6444L,-311744L,13018830L,-493025760L,17411253944L,-583472867840L,18770817643749L,-584450497233840L,17716721171780388L,-525192444572011776L,15276991910654781638UL,BigInteger.Parse("-437229195695756884672"),BigInteger.Parse("12338641730218147891560"),BigInteger.Parse("-343932138212987023388672") };
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
public class A286329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286329Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286329.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286329.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286329Inst Instance=new A286329Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286328
{
public static readonly long[] Value={ 4L,3L,24L,60L,14L,9L,180L,264L,20L,480L,19L,84L,924L,1104L,51L,1740L,155L,2244L,2520L,2664L,3120L,3444L,99L,51L,51L,5304L,5724L,65L,399L,8064L,8580L,9384L,9660L,221L,11400L,12324L,13284L,13944L,14964L,16020L,819L,18240L,194L,99L,19800L,22260L,24864L,25764L,26220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286328Inst : IEnumerable<long>
{
public static readonly long[] Value=A286328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286328.Bytes);
public long this[int i]=>Value[i];

public static A286328Inst Instance=new A286328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286327
{
public static readonly long[] Value={ 0L,1L,1L,1L,4L,1L,4L,5L,1L,9L,4L,5L,13L,1L,10L,9L,4L,17L,5L,13L,16L,1L,20L,10L,9L,25L,4L,25L,17L,5L,34L,13L,16L,26L,1L,41L,20L,10L,37L,9L,25L,29L,4L,50L,25L,17L,40L,5L,36L,34L,13L,53L,16L,26L,45L,1L,49L,41L,20L,58L,10L,37L,52L,9L,64L,25L,29L,65L,4L,50L,61L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286327Inst : IEnumerable<long>
{
public static readonly long[] Value=A286327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286327.Bytes);
public long this[int i]=>Value[i];

public static A286327Inst Instance=new A286327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286166
{
public static readonly long[] Value={ 1L,1L,6L,3L,28L,23L,88L,79L,368L,479L,1120L,1855L,6080L,4991L,22912L,19711L,98048L,69119L,386560L,324607L,1473536L,1259519L,6264832L,4444159L,24768512L,17620991L,100556800L,68108287L,401063936L,284393471L,1585020928L,1128071167L,6436093952L,4358799359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286166Inst : IEnumerable<long>
{
public static readonly long[] Value=A286166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286166.Bytes);
public long this[int i]=>Value[i];

public static A286166Inst Instance=new A286166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286165
{
public static readonly long[] Value={ 1L,2L,3L,12L,7L,58L,13L,242L,29L,1006L,49L,4046L,125L,16306L,205L,65330L,509L,261826L,829L,1047794L,1997L,4193074L,3325L,16774082L,7997L,67103938L,13309L,268422914L,31997L,1073722306L,53053L,4294917314L,127997L,17179791106L,212221L,68719276802L,511997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286165Inst : IEnumerable<long>
{
public static readonly long[] Value=A286165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286165.Bytes);
public long this[int i]=>Value[i];

public static A286165Inst Instance=new A286165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286164
{
public static readonly long[] Value={ 0L,2L,5L,7L,9L,16L,14L,29L,12L,16L,20L,67L,27L,16L,23L,121L,35L,67L,44L,67L,23L,16L,54L,277L,18L,16L,38L,67L,65L,436L,77L,497L,23L,16L,31L,631L,90L,16L,23L,277L,104L,436L,119L,67L,80L,16L,135L,1129L,25L,67L,23L,67L,152L,277L,31L,277L,23L,16L,170L,1771L,189L,16L,80L,2017L,31L,436L,209L,67L,23L,436L,230L,2557L,252L,16L,80L,67L,40L,436L,275L,1129L,138L,16L,299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286164Inst : IEnumerable<long>
{
public static readonly long[] Value=A286164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286164.Bytes);
public long this[int i]=>Value[i];

public static A286164Inst Instance=new A286164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286163
{
public static readonly long[] Value={ 2L,5L,12L,14L,23L,42L,38L,44L,40L,61L,80L,117L,80L,84L,216L,152L,23L,148L,80L,148L,601L,142L,302L,375L,109L,142L,911L,183L,302L,1020L,530L,560L,61L,61L,142L,856L,467L,142L,412L,430L,467L,1741L,1832L,265L,2497L,412L,1178L,1323L,109L,265L,826L,265L,1832L,1735L,2932L,489L,412L,412L,2630L,2835L,1178L,672L,2787L,2144L,61L,625L,80L,148L,601L,850L,302L,2998L,467L,601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286163Inst : IEnumerable<long>
{
public static readonly long[] Value=A286163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286163.Bytes);
public long this[int i]=>Value[i];

public static A286163Inst Instance=new A286163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286162
{
public static readonly long[] Value={ 2L,5L,7L,9L,16L,12L,29L,14L,16L,23L,67L,18L,67L,38L,121L,20L,16L,23L,67L,31L,436L,80L,277L,25L,67L,80L,631L,48L,277L,138L,497L,27L,16L,23L,67L,31L,436L,80L,277L,40L,436L,467L,1771L,94L,1771L,302L,1129L,33L,67L,80L,631L,94L,1771L,668L,2557L,59L,277L,302L,2557L,156L,1129L,530L,2017L,35L,16L,23L,67L,31L,436L,80L,277L,40L,436L,467L,1771L,94L,1771L,302L,1129L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286162Inst : IEnumerable<long>
{
public static readonly long[] Value=A286162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286162.Bytes);
public long this[int i]=>Value[i];

public static A286162Inst Instance=new A286162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286161
{
public static readonly long[] Value={ 1L,5L,2L,18L,2L,23L,2L,59L,7L,23L,2L,94L,2L,23L,16L,195L,2L,80L,2L,94L,16L,23L,2L,355L,7L,23L,29L,94L,2L,467L,2L,672L,16L,23L,16L,706L,2L,23L,16L,355L,2L,467L,2L,94L,67L,23L,2L,1331L,7L,80L,16L,94L,2L,302L,16L,355L,16L,23L,2L,1894L,2L,23L,67L,2422L,16L,467L,2L,94L,16L,467L,2L,2779L,2L,23L,67L,94L,16L,467L,2L,1331L,121L,23L,2L,1894L,16L,23L,16L,355L,2L,1832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286161Inst : IEnumerable<long>
{
public static readonly long[] Value=A286161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286161.Bytes);
public long this[int i]=>Value[i];

public static A286161Inst Instance=new A286161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286160
{
public static readonly long[] Value={ 1L,2L,5L,12L,14L,23L,27L,59L,42L,40L,65L,109L,90L,61L,86L,261L,152L,142L,189L,179L,148L,115L,275L,473L,273L,148L,318L,265L,434L,674L,495L,1097L,320L,226L,430L,1093L,702L,271L,430L,757L,860L,832L,945L,485L,619L,373L,1127L,1969L,1032L,485L,698L,619L,1430L,838L,1030L,1105L,856L,556L,1769L,2791L,1890L,625L,1117L,4497L,1426L,1196L,2277L,935L,1220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286160Inst : IEnumerable<long>
{
public static readonly long[] Value=A286160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286160.Bytes);
public long this[int i]=>Value[i];

public static A286160Inst Instance=new A286160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286159
{
public static readonly long[] Value={ 1L,1L,3L,1L,4L,6L,1L,4L,3L,10L,1L,4L,8L,7L,15L,1L,4L,8L,3L,6L,21L,1L,4L,8L,13L,7L,11L,28L,1L,4L,8L,13L,3L,12L,10L,36L,1L,4L,8L,13L,19L,7L,6L,16L,45L,1L,4L,8L,13L,19L,3L,12L,11L,15L,55L,1L,4L,8L,13L,19L,26L,7L,18L,17L,22L,66L,1L,4L,8L,13L,19L,26L,3L,12L,6L,10L,21L,78L,1L,4L,8L,13L,19L,26L,34L,7L,18L,11L,16L,29L,91L,1L,4L,8L,13L,19L,26L,34L,3L,12L,25L,17L,23L,28L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286159Inst : IEnumerable<long>
{
public static readonly long[] Value=A286159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286159.Bytes);
public long this[int i]=>Value[i];

public static A286159Inst Instance=new A286159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286158
{
public static readonly long[] Value={ 1L,3L,1L,6L,4L,1L,10L,3L,4L,1L,15L,7L,8L,4L,1L,21L,6L,3L,8L,4L,1L,28L,11L,7L,13L,8L,4L,1L,36L,10L,12L,3L,13L,8L,4L,1L,45L,16L,6L,7L,19L,13L,8L,4L,1L,55L,15L,11L,12L,3L,19L,13L,8L,4L,1L,66L,22L,17L,18L,7L,26L,19L,13L,8L,4L,1L,78L,21L,10L,6L,12L,3L,26L,19L,13L,8L,4L,1L,91L,29L,16L,11L,18L,7L,34L,26L,19L,13L,8L,4L,1L,105L,28L,23L,17L,25L,12L,3L,34L,26L,19L,13L,8L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286158Inst : IEnumerable<long>
{
public static readonly long[] Value=A286158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286158.Bytes);
public long this[int i]=>Value[i];

public static A286158Inst Instance=new A286158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286157
{
public static readonly long[] Value={ 1L,3L,2L,6L,1L,2L,10L,4L,5L,2L,15L,3L,1L,5L,2L,21L,7L,4L,9L,5L,2L,28L,6L,8L,1L,9L,5L,2L,36L,11L,3L,4L,14L,9L,5L,2L,45L,10L,7L,8L,1L,14L,9L,5L,2L,55L,16L,12L,13L,4L,20L,14L,9L,5L,2L,66L,15L,6L,3L,8L,1L,20L,14L,9L,5L,2L,78L,22L,11L,7L,13L,4L,27L,20L,14L,9L,5L,2L,91L,21L,17L,12L,19L,8L,1L,27L,20L,14L,9L,5L,2L,105L,29L,10L,18L,3L,13L,4L,35L,27L,20L,14L,9L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286157Inst : IEnumerable<long>
{
public static readonly long[] Value=A286157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286157.Bytes);
public long this[int i]=>Value[i];

public static A286157Inst Instance=new A286157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286156
{
public static readonly long[] Value={ 1L,2L,3L,2L,1L,6L,2L,5L,4L,10L,2L,5L,1L,3L,15L,2L,5L,9L,4L,7L,21L,2L,5L,9L,1L,8L,6L,28L,2L,5L,9L,14L,4L,3L,11L,36L,2L,5L,9L,14L,1L,8L,7L,10L,45L,2L,5L,9L,14L,20L,4L,13L,12L,16L,55L,2L,5L,9L,14L,20L,1L,8L,3L,6L,15L,66L,2L,5L,9L,14L,20L,27L,4L,13L,7L,11L,22L,78L,2L,5L,9L,14L,20L,27L,1L,8L,19L,12L,17L,21L,91L,2L,5L,9L,14L,20L,27L,35L,4L,13L,3L,18L,10L,29L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286156Inst : IEnumerable<long>
{
public static readonly long[] Value=A286156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286156.Bytes);
public long this[int i]=>Value[i];

public static A286156Inst Instance=new A286156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286155
{
public static readonly long[] Value={ -1L,4L,6L,2L,-2L,3L,11L,3L,2L,15L,7L,23L,-3L,27L,10L,22L,30L,39L,43L,35L,28L,16L,12L,31L,-4L,34L,14L,21L,37L,17L,24L,10L,7L,26L,20L,45L,29L,57L,18L,14L,-5L,12L,19L,65L,36L,56L,68L,81L,19L,26L,24L,18L,89L,77L,66L,46L,38L,69L,109L,20L,-6L,17L,117L,76L,44L,55L,79L,47L,58L,124L,141L,21L,16L,149L,133L,64L,54L,91L,67L,107L,48L,140L,125L,177L,-7L,185L,132L,150L,53L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286155Inst : IEnumerable<long>
{
public static readonly long[] Value=A286155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286155.Bytes);
public long this[int i]=>Value[i];

public static A286155Inst Instance=new A286155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286154
{
public static readonly long[] Value={ 0L,1L,5L,2L,18L,2L,40L,7L,23L,7L,96L,7L,142L,16L,38L,29L,238L,16L,308L,29L,80L,46L,444L,29L,234L,67L,173L,67L,676L,29L,791L,121L,212L,121L,328L,67L,1093L,154L,302L,121L,1339L,67L,1499L,191L,302L,232L,1785L,121L,994L,191L,530L,277L,2227L,154L,864L,277L,668L,379L,2718L,121L,2944L,436L,668L,497L,1228L,191L,3505L,497L,992L,277L,3936L,277L,4207L,631L,822L,631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286154Inst : IEnumerable<long>
{
public static readonly long[] Value=A286154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286154.Bytes);
public long this[int i]=>Value[i];

public static A286154Inst Instance=new A286154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286153
{
public static readonly long[] Value={ 2L,11L,13L,7L,5L,8L,22L,8L,7L,26L,16L,38L,9L,42L,19L,37L,47L,58L,62L,52L,43L,29L,23L,48L,14L,51L,25L,34L,56L,30L,39L,19L,16L,41L,33L,64L,46L,80L,31L,25L,20L,23L,32L,88L,53L,79L,93L,108L,32L,41L,39L,31L,116L,102L,89L,67L,57L,94L,140L,33L,27L,30L,148L,101L,63L,76L,106L,68L,81L,157L,176L,34L,29L,184L,166L,87L,75L,118L,92L,138L,69L,175L,158L,216L,35L,224L,165L,185L,74L,150L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286153Inst : IEnumerable<long>
{
public static readonly long[] Value=A286153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286153.Bytes);
public long this[int i]=>Value[i];

public static A286153Inst Instance=new A286153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286152
{
public static readonly long[] Value={ 0L,2L,2L,12L,2L,40L,2L,59L,18L,61L,2L,179L,2L,86L,73L,261L,2L,265L,2L,265L,100L,148L,2L,757L,33L,185L,129L,367L,2L,1297L,2L,1097L,166L,271L,131L,1735L,2L,320L,205L,1105L,2L,1741L,2L,619L,517L,430L,2L,3113L,52L,850L,295L,769L,2L,1747L,205L,1517L,346L,625L,2L,5297L,2L,698L,730L,4497L,248L,2821L,2L,1117L,460L,2821L,2L,7069L,2L,941L,1070L,1315L,248L,3457L,2L,4513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286152Inst : IEnumerable<long>
{
public static readonly long[] Value=A286152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286152.Bytes);
public long this[int i]=>Value[i];

public static A286152Inst Instance=new A286152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286151
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,5L,6L,11L,13L,9L,10L,7L,5L,8L,14L,15L,22L,8L,7L,26L,20L,21L,16L,38L,9L,42L,19L,27L,28L,37L,47L,58L,62L,52L,43L,35L,36L,29L,23L,48L,14L,51L,25L,34L,44L,45L,56L,30L,39L,19L,16L,41L,33L,64L,54L,55L,46L,80L,31L,25L,20L,23L,32L,88L,53L,65L,66L,79L,93L,108L,32L,41L,39L,31L,116L,102L,89L,77L,78L,67L,57L,94L,140L,33L,27L,30L,148L,101L,63L,76L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286151Inst : IEnumerable<long>
{
public static readonly long[] Value=A286151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286151.Bytes);
public long this[int i]=>Value[i];

public static A286151Inst Instance=new A286151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286134
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,-1L,-1L,-1L,0L,0L,-1L,1L,0L,1L,-1L,0L,1L,2L,-1L,2L,1L,0L,1L,-1L,0L,0L,1L,0L,0L,-1L,0L,-2L,-1L,0L,0L,1L,-1L,-2L,1L,-1L,-2L,-2L,1L,0L,0L,0L,1L,-2L,1L,0L,0L,2L,0L,0L,2L,1L,-1L,1L,0L,0L,1L,1L,-1L,0L,0L,3L,2L,2L,0L,-1L,0L,1L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286134Inst : IEnumerable<long>
{
public static readonly long[] Value=A286134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286134.Bytes);
public long this[int i]=>Value[i];

public static A286134Inst Instance=new A286134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286133
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,-1L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,-1L,0L,0L,0L,0L,-1L,-2L,-1L,1L,0L,1L,-1L,1L,0L,-1L,1L,-2L,0L,-1L,0L,1L,2L,2L,0L,0L,0L,1L,2L,0L,-1L,1L,-1L,-1L,1L,0L,-2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-2L,1L,3L,-1L,-1L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286133Inst : IEnumerable<long>
{
public static readonly long[] Value=A286133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286133.Bytes);
public long this[int i]=>Value[i];

public static A286133Inst Instance=new A286133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286132
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,-1L,0L,0L,1L,-1L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,-1L,1L,-1L,-1L,-1L,-1L,0L,0L,0L,2L,-2L,-1L,-1L,1L,1L,-1L,-2L,0L,-1L,-1L,0L,1L,0L,1L,0L,2L,-1L,0L,0L,-1L,2L,0L,0L,0L,2L,-1L,0L,0L,1L,0L,2L,1L,1L,0L,0L,2L,1L,0L,-1L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286132Inst : IEnumerable<long>
{
public static readonly long[] Value=A286132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286132.Bytes);
public long this[int i]=>Value[i];

public static A286132Inst Instance=new A286132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286131
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,-1L,-1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,-1L,1L,1L,0L,0L,-3L,1L,0L,0L,0L,-2L,0L,-1L,1L,1L,1L,0L,0L,0L,-1L,1L,1L,-1L,0L,1L,0L,-1L,1L,0L,0L,-1L,0L,1L,0L,-1L,1L,-1L,-2L,-1L,0L,1L,1L,4L,-1L,-1L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286131Inst : IEnumerable<long>
{
public static readonly long[] Value=A286131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286131.Bytes);
public long this[int i]=>Value[i];

public static A286131Inst Instance=new A286131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286130
{
public static readonly long[] Value={ 24L,26L,87L,250L,440L,448L,644L,875L,1320L,1640L,1768L,1996L,2480L,2500L,2656L,4400L,6544L,8250L,8360L,8420L,8727L,8875L,13200L,16400L,19984L,19996L,24800L,25000L,25424L,43750L,44000L,45712L,63528L,73840L,75184L,82500L,83346L,83478L,83600L,84200L,132000L,164000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286130Inst : IEnumerable<long>
{
public static readonly long[] Value=A286130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286130.Bytes);
public long this[int i]=>Value[i];

public static A286130Inst Instance=new A286130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286129
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,-1L,-1L,-1L,-1L,1L,0L,1L,0L,2L,-1L,2L,2L,0L,0L,-1L,1L,-2L,-1L,0L,0L,-2L,0L,-2L,-2L,0L,2L,-1L,0L,-2L,1L,0L,0L,4L,2L,0L,-2L,2L,1L,2L,1L,0L,1L,-1L,2L,0L,-4L,2L,0L,-1L,0L,2L,-4L,2L,-2L,0L,-2L,-4L,-3L,-2L,0L,2L,-1L,2L,5L,-2L,2L,-1L,0L,-6L,1L,-4L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286129Inst : IEnumerable<long>
{
public static readonly long[] Value=A286129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286129.Bytes);
public long this[int i]=>Value[i];

public static A286129Inst Instance=new A286129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286128
{
public static readonly long[] Value={ 0L,0L,1L,-1L,-1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,-2L,1L,1L,-2L,1L,0L,0L,-1L,-2L,1L,1L,0L,0L,0L,2L,2L,-1L,-2L,0L,0L,4L,-1L,-1L,0L,0L,-2L,-1L,2L,-2L,-1L,2L,-1L,0L,-1L,-2L,-2L,1L,4L,0L,0L,0L,0L,-2L,4L,-4L,2L,1L,2L,4L,3L,-3L,0L,2L,1L,-4L,-5L,2L,-2L,0L,0L,-4L,-1L,0L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286128Inst : IEnumerable<long>
{
public static readonly long[] Value=A286128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286128.Bytes);
public long this[int i]=>Value[i];

public static A286128Inst Instance=new A286128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286127
{
public static readonly long[] Value={ 1L,5L,3L,1L,0L,2L,6L,2L,4L,5L,8L,9L,0L,0L,2L,1L,1L,9L,2L,1L,6L,2L,2L,3L,1L,6L,7L,1L,5L,9L,5L,3L,0L,5L,3L,2L,1L,0L,8L,6L,5L,8L,0L,4L,5L,5L,6L,8L,1L,5L,1L,0L,2L,3L,1L,2L,3L,9L,1L,2L,0L,6L,0L,8L,4L,6L,0L,2L,7L,0L,4L,5L,1L,4L,9L,6L,8L,1L,3L,8L,8L,7L,6L,3L,9L,4L,8L,6L,5L,8L,2L,9L,6L,3L,2L,5L,1L,2L,3L,4L,9L,9L,3L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286127Inst : IEnumerable<long>
{
public static readonly long[] Value=A286127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286127.Bytes);
public long this[int i]=>Value[i];

public static A286127Inst Instance=new A286127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286126
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,42L,90L,100L,120L,156L,1000L,3615L,5219L,6174L,9723L,10000L,18278L,22620L,47988L,54240L,100000L,551880L,837930L,1000000L,2000718L,10000000L,12204240L,12356630L,25137930L,40358373L,54066635L,62193780L,100000000L,133878822L,168751484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286126Inst : IEnumerable<long>
{
public static readonly long[] Value=A286126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286126.Bytes);
public long this[int i]=>Value[i];

public static A286126Inst Instance=new A286126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286125
{
public static readonly long[] Value={ 3L,4L,8L,672L,720L,3960L,25056L,114912L,323928L,1064880L,3899880L,16758000L,59222400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286125Inst : IEnumerable<long>
{
public static readonly long[] Value=A286125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286125.Bytes);
public long this[int i]=>Value[i];

public static A286125Inst Instance=new A286125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286124
{
public static readonly long[] Value={ 0L,2L,40L,1564L,497400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286124Inst : IEnumerable<long>
{
public static readonly long[] Value=A286124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286124.Bytes);
public long this[int i]=>Value[i];

public static A286124Inst Instance=new A286124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286123
{
public static readonly long[] Value={ 1L,2L,2L,0L,4L,0L,56L,0L,208L,0L,608L,0L,3776L,512L,896L,23552L,16640L,83968L,85504L,348160L,3072L,1236992L,14336L,2867200L,2207744L,1212416L,4251648L,2818048L,27312128L,1441792L,229376L,1310720L,402718720L,2621440L,3222142976L,5242880L,4980736L,35651584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286123Inst : IEnumerable<long>
{
public static readonly long[] Value=A286123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286123.Bytes);
public long this[int i]=>Value[i];

public static A286123Inst Instance=new A286123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286122
{
public static readonly long[] Value={ 1L,1L,2L,0L,4L,0L,14L,0L,22L,0L,50L,0L,110L,16L,224L,58L,260L,74L,916L,170L,1536L,466L,3584L,980L,6920L,1312L,14352L,3392L,24752L,6656L,57344L,10240L,65584L,20480L,229400L,40960L,409600L,69632L,958464L,131072L,1593344L,360448L,3676160L,589824L,6553600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286122Inst : IEnumerable<long>
{
public static readonly long[] Value=A286122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286122.Bytes);
public long this[int i]=>Value[i];

public static A286122Inst Instance=new A286122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286121
{
public static readonly BigInteger[] Value={ 1L,10L,10L,0L,100L,0L,111000L,0L,11010000L,0L,1001100000L,0L,111011000000L,1000000000L,1110000000L,101110000000000L,100000100000000L,10100100000000000L,10100111000000000L,1010101000000000000L,110000000000L,BigInteger.Parse("100101110000000000000"),11100000000000L };
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
public class A286121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286121Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286121.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286121.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286121Inst Instance=new A286121Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286120
{
public static readonly long[] Value={ 1L,1L,10L,0L,100L,0L,1110L,0L,10110L,0L,110010L,0L,1101110L,10000L,11100000L,111010L,100000100L,1001010L,1110010100L,10101010L,11000000000L,111010010L,111000000000L,1111010100L,1101100001000L,10100100000L,11100000010000L,110101000000L,110000010110000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286120Inst : IEnumerable<long>
{
public static readonly long[] Value=A286120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286120.Bytes);
public long this[int i]=>Value[i];

public static A286120Inst Instance=new A286120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286119
{
public static readonly long[] Value={ 1L,1L,0L,7L,16L,31L,0L,255L,0L,511L,0L,2047L,4096L,8191L,0L,28671L,73728L,114687L,32768L,458751L,1179648L,1703935L,262144L,6815743L,19922944L,27262975L,12582912L,8388607L,520093696L,8388607L,2030043136L,234881023L,603979776L,3087007743L,2147483648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286119Inst : IEnumerable<long>
{
public static readonly long[] Value=A286119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286119.Bytes);
public long this[int i]=>Value[i];

public static A286119Inst Instance=new A286119Inst();

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