using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A101241
{
public static readonly long[] Value={ 1L,8L,18L,19L,20L,70L,71L,81L,82L,92L,98L,108L,118L,128L,138L,148L,158L,168L,178L,188L,198L,199L,209L,219L,229L,239L,249L,259L,269L,279L,289L,290L,700L,710L,720L,730L,740L,750L,760L,770L,780L,790L,791L,801L,811L,821L,831L,841L,851L,861L,871L,881L,891L,892L,902L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101241Inst : IEnumerable<long>
{
public static readonly long[] Value=A101241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101241.Bytes);
public long this[int i]=>Value[i];

public static A101241Inst Instance=new A101241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101242
{
public static readonly long[] Value={ 1L,9L,10L,80L,81L,91L,99L,109L,119L,129L,139L,149L,159L,169L,179L,189L,190L,800L,810L,820L,830L,840L,850L,860L,870L,880L,890L,891L,901L,911L,921L,931L,941L,951L,961L,971L,981L,991L,999L,1009L,1019L,1029L,1039L,1049L,1059L,1069L,1079L,1089L,1099L,1109L,1119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101242Inst : IEnumerable<long>
{
public static readonly long[] Value=A101242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101242.Bytes);
public long this[int i]=>Value[i];

public static A101242Inst Instance=new A101242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101243
{
public static readonly long[] Value={ 0L,90L,900L,910L,920L,930L,940L,950L,960L,970L,980L,990L,9000L,9010L,9020L,9030L,9040L,9050L,9060L,9070L,9080L,9090L,9100L,9110L,9120L,9130L,9140L,9150L,9160L,9170L,9180L,9190L,9200L,9210L,9220L,9230L,9240L,9250L,9260L,9270L,9280L,9290L,9300L,9310L,9320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101243Inst : IEnumerable<long>
{
public static readonly long[] Value=A101243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101243.Bytes);
public long this[int i]=>Value[i];

public static A101243Inst Instance=new A101243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101244
{
public static readonly long[] Value={ 0L,10L,20L,100L,101L,111L,211L,212L,222L,322L,323L,333L,433L,434L,444L,544L,545L,555L,655L,656L,666L,766L,767L,777L,877L,878L,880L,900L,1000L,1001L,1102L,1202L,1203L,1303L,1304L,1404L,1405L,1505L,1506L,1606L,1607L,1707L,1708L,1808L,1809L,1909L,1910L,2010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101244Inst : IEnumerable<long>
{
public static readonly long[] Value=A101244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101244.Bytes);
public long this[int i]=>Value[i];

public static A101244Inst Instance=new A101244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101245
{
public static readonly long[] Value={ 2L,5L,7L,2L,3L,31L,3L,5L,11L,61L,2L,3L,5L,13L,127L,3L,5L,7L,11L,29L,197L,2L,3L,5L,7L,11L,17L,347L,3L,5L,7L,11L,13L,17L,29L,491L,2L,3L,5L,7L,11L,13L,17L,19L,733L,3L,5L,7L,11L,13L,17L,19L,23L,31L,971L,2L,3L,5L,7L,11L,13L,17L,19L,23L,31L,1321L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,47L,1667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101245Inst : IEnumerable<long>
{
public static readonly long[] Value=A101245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101245.Bytes);
public long this[int i]=>Value[i];

public static A101245Inst Instance=new A101245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101246
{
public static readonly long[] Value={ 1L,3L,7L,605L,607L,1446L,1529L,8531L,9178L,9234L,9234L,15312L,56209L,56383L,56402L,56480L,69273L,79821L,120357L,125046L,128943L,135648L,142857L,145926L,149706L,152064L,156042L,159840L,26537980L,26537994L,26538065L,27018456L,27018495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101246Inst : IEnumerable<long>
{
public static readonly long[] Value=A101246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101246.Bytes);
public long this[int i]=>Value[i];

public static A101246Inst Instance=new A101246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101247
{
public static readonly long[] Value={ 1L,6L,13L,22L,31L,61L,66L,106L,116L,126L,136L,146L,156L,166L,176L,186L,193L,203L,213L,223L,233L,243L,253L,263L,273L,283L,292L,302L,312L,322L,332L,342L,352L,362L,372L,382L,391L,601L,611L,621L,631L,641L,651L,661L,671L,681L,691L,696L,1006L,1016L,1026L,1036L,1046L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101247Inst : IEnumerable<long>
{
public static readonly long[] Value=A101247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101247.Bytes);
public long this[int i]=>Value[i];

public static A101247Inst Instance=new A101247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101248
{
public static readonly long[] Value={ 1L,2L,11L,12L,21L,22L,31L,32L,111L,112L,121L,122L,141L,142L,152L,161L,162L,172L,182L,211L,212L,221L,222L,241L,242L,251L,261L,262L,271L,281L,311L,312L,321L,322L,331L,332L,910L,920L,1111L,1112L,1121L,1122L,1141L,1142L,1151L,1152L,1161L,1162L,1171L,1172L,1181L,1182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101248Inst : IEnumerable<long>
{
public static readonly long[] Value=A101248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101248.Bytes);
public long this[int i]=>Value[i];

public static A101248Inst Instance=new A101248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101249
{
public static readonly long[] Value={ 577L,5711L,5717L,5737L,5741L,5743L,5779L,5783L,57107L,57131L,57139L,57149L,57163L,57173L,57179L,57191L,57193L,57223L,57241L,57251L,57269L,57271L,57283L,57331L,57347L,57349L,57367L,57373L,57383L,57389L,57397L,57457L,57467L,57487L,57503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101249Inst : IEnumerable<long>
{
public static readonly long[] Value=A101249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101249.Bytes);
public long this[int i]=>Value[i];

public static A101249Inst Instance=new A101249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101250
{
public static readonly long[] Value={ 71119L,71129L,71143L,71147L,71153L,71161L,71167L,71171L,711131L,711163L,711173L,711181L,711223L,711307L,711317L,711353L,711397L,711409L,711463L,711479L,711499L,711509L,711523L,711563L,711577L,711617L,711653L,711691L,711701L,711709L,711727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101250Inst : IEnumerable<long>
{
public static readonly long[] Value=A101250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101250.Bytes);
public long this[int i]=>Value[i];

public static A101250Inst Instance=new A101250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101251
{
public static readonly long[] Value={ 2357L,23531L,23537L,23561L,23567L,235181L,235199L,235211L,235241L,235307L,235337L,235349L,235397L,235439L,235523L,235541L,235577L,235601L,235607L,235661L,235673L,235751L,235787L,235811L,235877L,235919L,235967L,235997L,2351033L,2351171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101251Inst : IEnumerable<long>
{
public static readonly long[] Value=A101251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101251.Bytes);
public long this[int i]=>Value[i];

public static A101251Inst Instance=new A101251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101252
{
public static readonly long[] Value={ 35729L,35731L,35747L,35753L,35759L,35771L,35797L,357103L,357107L,357109L,357131L,357139L,357179L,357197L,357199L,357211L,357229L,357239L,357241L,357263L,357271L,357281L,357283L,357293L,357347L,357349L,357353L,357359L,357389L,357421L,357431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101252Inst : IEnumerable<long>
{
public static readonly long[] Value=A101252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101252.Bytes);
public long this[int i]=>Value[i];

public static A101252Inst Instance=new A101252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101253
{
public static readonly long[] Value={ 2L,19L,113L,617L,1877L,8753L,52517L,255043L,1532173L,9287521L,48499459L,353653063L,2136716521L,18171787987L,111795382441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101253Inst : IEnumerable<long>
{
public static readonly long[] Value=A101253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101253.Bytes);
public long this[int i]=>Value[i];

public static A101253Inst Instance=new A101253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101254
{
public static readonly long[] Value={ 2L,31L,98L,277L,1218L,5297L,25686L,90953L,315516L,1294379L,7743358L,54991121L,364542120L,2515329959L,16440340258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101254Inst : IEnumerable<long>
{
public static readonly long[] Value=A101254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101254.Bytes);
public long this[int i]=>Value[i];

public static A101254Inst Instance=new A101254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101255
{
public static readonly long[] Value={ 1L,2L,4L,9L,11L,15L,18L,23L,82L,34L,76L,133L,118L,292L,342L,180L,71L,621L,278L,145L,528L,783L,280L,397L,1606L,1129L,1154L,1521L,928L,4510L,5597L,1607L,1379L,2039L,2283L,682L,1935L,6053L,10356L,4598L,4481L,9561L,4287L,14315L,6328L,15299L,3836L,9140L,6708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101255Inst : IEnumerable<long>
{
public static readonly long[] Value=A101255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101255.Bytes);
public long this[int i]=>Value[i];

public static A101255Inst Instance=new A101255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101256
{
public static readonly long[] Value={ 0L,0L,0L,4L,4L,10L,10L,18L,27L,37L,37L,49L,49L,63L,78L,94L,94L,112L,112L,132L,153L,175L,175L,199L,224L,250L,277L,305L,305L,335L,335L,367L,400L,434L,469L,505L,505L,543L,582L,622L,622L,664L,664L,708L,753L,799L,799L,847L,896L,946L,997L,1049L,1049L,1103L,1158L,1214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101256Inst : IEnumerable<long>
{
public static readonly long[] Value=A101256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101256.Bytes);
public long this[int i]=>Value[i];

public static A101256Inst Instance=new A101256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101257
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,2L,0L,0L,0L,0L,1L,1L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,0L,2L,1L,2L,0L,0L,1L,1L,3L,0L,1L,0L,3L,4L,1L,0L,2L,0L,0L,2L,1L,0L,3L,1L,1L,1L,1L,0L,4L,0L,1L,2L,0L,3L,5L,0L,1L,2L,3L,0L,1L,0L,1L,0L,3L,4L,1L,0L,2L,0L,1L,0L,5L,2L,1L,2L,3L,0L,1L,6L,3L,1L,1L,4L,4L,0L,0L,2L,0L,0L,5L,0L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101257Inst : IEnumerable<long>
{
public static readonly long[] Value=A101257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101257.Bytes);
public long this[int i]=>Value[i];

public static A101257Inst Instance=new A101257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101258
{
public static readonly long[] Value={ 0L,10L,15L,20L,30L,35L,40L,45L,46L,50L,52L,54L,55L,60L,70L,75L,80L,90L,100L,110L,120L,130L,140L,150L,160L,170L,180L,190L,195L,200L,205L,210L,215L,220L,225L,230L,235L,240L,245L,250L,255L,260L,265L,270L,275L,280L,285L,290L,300L,310L,320L,330L,340L,350L,360L,370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101258Inst : IEnumerable<long>
{
public static readonly long[] Value=A101258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101258.Bytes);
public long this[int i]=>Value[i];

public static A101258Inst Instance=new A101258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101259
{
public static readonly long[] Value={ 87L,195L,244L,495L,11584L,35595L,137452847104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101259Inst : IEnumerable<long>
{
public static readonly long[] Value=A101259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101259.Bytes);
public long this[int i]=>Value[i];

public static A101259Inst Instance=new A101259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101260
{
public static readonly long[] Value={ 84L,140L,224L,308L,364L,476L,532L,644L,812L,868L,1036L,1148L,1204L,1316L,1372L,1484L,1652L,1708L,1876L,1988L,2044L,2212L,2324L,2492L,2716L,2828L,2884L,2996L,3052L,3164L,3556L,3668L,3836L,3892L,4172L,4228L,4396L,4544L,4564L,4676L,4844L,5012L,5068L,5348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101260Inst : IEnumerable<long>
{
public static readonly long[] Value=A101260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101260.Bytes);
public long this[int i]=>Value[i];

public static A101260Inst Instance=new A101260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101261
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,3L,1L,8L,1L,5L,1L,9L,1L,6L,1L,16L,1L,7L,1L,14L,1L,10L,1L,21L,1L,11L,1L,19L,1L,12L,1L,32L,1L,13L,1L,24L,1L,15L,1L,34L,1L,17L,1L,30L,1L,18L,1L,45L,1L,20L,1L,36L,1L,22L,1L,47L,1L,23L,1L,40L,1L,25L,1L,64L,1L,26L,1L,44L,1L,27L,1L,59L,1L,28L,1L,51L,1L,29L,1L,74L,1L,31L,1L,56L,1L,33L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101261Inst : IEnumerable<long>
{
public static readonly long[] Value=A101261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101261.Bytes);
public long this[int i]=>Value[i];

public static A101261Inst Instance=new A101261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101262
{
public static readonly long[] Value={ 1L,2L,6L,35L,76L,90L,110L,142L,198L,328L,952L,9067L,18996L,20991L,23456L,26575L,30652L,36205L,44217L,56781L,79321L,131533L,384870L,5202154L,10762714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101262Inst : IEnumerable<long>
{
public static readonly long[] Value=A101262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101262.Bytes);
public long this[int i]=>Value[i];

public static A101262Inst Instance=new A101262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101263
{
public static readonly long[] Value={ 5L,1L,7L,6L,3L,8L,0L,9L,0L,2L,0L,5L,0L,4L,1L,5L,2L,4L,6L,9L,7L,7L,9L,7L,6L,7L,5L,2L,4L,8L,0L,9L,6L,6L,5L,6L,6L,9L,8L,1L,3L,7L,8L,0L,2L,6L,3L,9L,8L,6L,1L,0L,2L,7L,6L,2L,8L,0L,0L,6L,4L,1L,4L,6L,3L,0L,1L,1L,3L,9L,4L,9L,4L,9L,7L,6L,0L,3L,9L,9L,3L,8L,4L,4L,7L,3L,5L,9L,4L,9L,3L,8L,8L,4L,9L,9L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101263Inst : IEnumerable<long>
{
public static readonly long[] Value=A101263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101263.Bytes);
public long this[int i]=>Value[i];

public static A101263Inst Instance=new A101263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101264
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101264Inst : IEnumerable<long>
{
public static readonly long[] Value=A101264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101264.Bytes);
public long this[int i]=>Value[i];

public static A101264Inst Instance=new A101264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101265
{
public static readonly long[] Value={ 1L,2L,6L,21L,77L,286L,1066L,3977L,14841L,55386L,206702L,771421L,2878981L,10744502L,40099026L,149651601L,558507377L,2084377906L,7779004246L,29031639077L,108347552061L,404358569166L,1509086724602L,5631988329241L,21018866592361L,78443478040202L,292755045568446L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101265Inst : IEnumerable<long>
{
public static readonly long[] Value=A101265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101265.Bytes);
public long this[int i]=>Value[i];

public static A101265Inst Instance=new A101265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101266
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101266Inst : IEnumerable<long>
{
public static readonly long[] Value=A101266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101266.Bytes);
public long this[int i]=>Value[i];

public static A101266Inst Instance=new A101266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101267
{
public static readonly long[] Value={ 1L,2L,4L,3L,7L,9L,6L,5L,13L,15L,19L,17L,11L,14L,10L,8L,24L,27L,32L,29L,37L,40L,35L,33L,21L,23L,30L,26L,18L,22L,16L,12L,44L,49L,56L,52L,62L,67L,59L,57L,73L,76L,82L,79L,69L,74L,66L,63L,39L,43L,50L,46L,58L,64L,54L,51L,34L,38L,47L,42L,28L,36L,25L,20L,84L,90L,102L,94L,110L,116L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101267Inst : IEnumerable<long>
{
public static readonly long[] Value=A101267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101267.Bytes);
public long this[int i]=>Value[i];

public static A101267Inst Instance=new A101267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101268
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,13L,22L,38L,63L,101L,160L,254L,403L,635L,984L,1492L,2225L,3281L,4814L,7044L,10271L,14889L,21416L,30586L,43401L,61205L,85748L,119296L,164835L,226423L,309664L,422302L,574827L,781237L,1060182L,1436368L,1942589L,2622079L,3531152L,4742316L,6348411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101268Inst : IEnumerable<long>
{
public static readonly long[] Value=A101268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101268.Bytes);
public long this[int i]=>Value[i];

public static A101268Inst Instance=new A101268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101269
{
public static readonly BigInteger[] Value={ 0L,1L,11L,299L,15371L,1285371L,159158691L,27376820379L,6246962876475L,1826295061189275L,665694890795056275L,BigInteger.Parse("296004348848796457275"),BigInteger.Parse("157710301268790933578475"),BigInteger.Parse("99189386694727572925906875") };
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
public class A101269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101269Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A101269.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A101269.Bytes);
public BigInteger this[int i]=>Value[i];

public static A101269Inst Instance=new A101269Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101270
{
public static readonly long[] Value={ 0L,1L,-1L,0L,3L,0L,-1L,0L,2L,1L,0L,-30L,0L,45L,0L,7L,0L,-60L,0L,72L,-1L,0L,21L,0L,-105L,0L,105L,0L,-149L,0L,2142L,0L,-7560L,0L,6480L,-43L,0L,-2220L,0L,20790L,0L,-56700L,0L,42525L,0L,53L,0L,-2280L,0L,15120L,0L,-33600L,0L,22400L,-43L,0L,561L,0L,-9900L,0L,49896L,0L,-93555L,0L,56133L,0L,-33889L,0L,817674L,0L,-9163440L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101270Inst : IEnumerable<long>
{
public static readonly long[] Value=A101270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101270.Bytes);
public long this[int i]=>Value[i];

public static A101270Inst Instance=new A101270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101271
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,6L,8L,9L,12L,12L,16L,15L,21L,20L,26L,25L,33L,28L,40L,36L,45L,42L,56L,44L,65L,56L,70L,64L,84L,66L,96L,81L,100L,88L,120L,90L,133L,110L,132L,121L,161L,120L,175L,140L,176L,156L,208L,153L,220L,180L,222L,196L,261L,184L,280L,225L,270L,240L,312L,230L,341L,272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101271Inst : IEnumerable<long>
{
public static readonly long[] Value=A101271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101271.Bytes);
public long this[int i]=>Value[i];

public static A101271Inst Instance=new A101271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101272
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101272Inst : IEnumerable<long>
{
public static readonly long[] Value=A101272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101272.Bytes);
public long this[int i]=>Value[i];

public static A101272Inst Instance=new A101272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101273
{
public static readonly long[] Value={ 171L,181L,272L,282L,1531L,1631L,2532L,2632L,3151L,3161L,3252L,3262L,11711L,11811L,12712L,12812L,14171L,14181L,14271L,14272L,15171L,15172L,16171L,16181L,17141L,17161L,17162L,17261L,17331L,17910L,18141L,18161L,18331L,18910L,21721L,21821L,22722L,22822L,24171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101273Inst : IEnumerable<long>
{
public static readonly long[] Value=A101273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101273.Bytes);
public long this[int i]=>Value[i];

public static A101273Inst Instance=new A101273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101274
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,10L,14L,21L,15L,16L,26L,25L,34L,22L,48L,38L,71L,40L,74L,90L,28L,69L,113L,47L,94L,54L,46L,143L,153L,83L,128L,49L,249L,75L,133L,225L,125L,131L,270L,145L,230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101274Inst : IEnumerable<long>
{
public static readonly long[] Value=A101274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101274.Bytes);
public long this[int i]=>Value[i];

public static A101274Inst Instance=new A101274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101275
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,13L,7L,1L,1L,44L,34L,10L,1L,1L,165L,150L,64L,13L,1L,1L,680L,659L,346L,103L,16L,1L,1L,3001L,2973L,1753L,659L,151L,19L,1L,1L,13880L,13844L,8716L,3798L,1116L,208L,22L,1L,1L,66345L,66300L,43384L,20798L,7226L,1744L,274L,25L,1L,1L,324908L,324853L,217804L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101275Inst : IEnumerable<long>
{
public static readonly long[] Value=A101275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101275.Bytes);
public long this[int i]=>Value[i];

public static A101275Inst Instance=new A101275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101276
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,2L,0L,2L,2L,2L,6L,0L,4L,3L,8L,6L,16L,0L,9L,6L,14L,30L,16L,45L,0L,21L,11L,36L,54L,106L,45L,126L,0L,51L,22L,74L,168L,196L,360L,126L,357L,0L,127L,43L,173L,372L,706L,675L,1197L,357L,1016L,0L,323L,87L,378L,981L,1636L,2775L,2268L,3913L,1016L,2907L,0L,835L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101276Inst : IEnumerable<long>
{
public static readonly long[] Value=A101276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101276.Bytes);
public long this[int i]=>Value[i];

public static A101276Inst Instance=new A101276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101277
{
public static readonly long[] Value={ 1L,2L,3L,6L,10L,16L,25L,38L,57L,84L,121L,172L,243L,338L,465L,636L,862L,1158L,1546L,2050L,2702L,3542L,4616L,5986L,7729L,9932L,12707L,16196L,20563L,26010L,32788L,41194L,51591L,64418L,80195L,99558L,123269L,152226L,187514L,230434L,282519L,345596L,421844L,513834L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101277Inst : IEnumerable<long>
{
public static readonly long[] Value=A101277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101277.Bytes);
public long this[int i]=>Value[i];

public static A101277Inst Instance=new A101277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101278
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,12L,9L,18L,36L,5L,10L,20L,15L,30L,60L,45L,90L,180L,25L,50L,100L,75L,150L,300L,225L,450L,900L,7L,14L,28L,21L,42L,84L,63L,126L,252L,35L,70L,140L,105L,210L,420L,315L,630L,1260L,175L,350L,700L,525L,1050L,2100L,1575L,3150L,6300L,49L,98L,196L,147L,294L,588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101278Inst : IEnumerable<long>
{
public static readonly long[] Value=A101278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101278.Bytes);
public long this[int i]=>Value[i];

public static A101278Inst Instance=new A101278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101279
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,3L,1L,4L,2L,5L,1L,6L,3L,7L,1L,8L,4L,9L,2L,10L,5L,11L,1L,12L,6L,13L,3L,14L,7L,15L,1L,16L,8L,17L,4L,18L,9L,19L,2L,20L,10L,21L,5L,22L,11L,23L,1L,24L,12L,25L,6L,26L,13L,27L,3L,28L,14L,29L,7L,30L,15L,31L,1L,32L,16L,33L,8L,34L,17L,35L,4L,36L,18L,37L,9L,38L,19L,39L,2L,40L,20L,41L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101279Inst : IEnumerable<long>
{
public static readonly long[] Value=A101279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101279.Bytes);
public long this[int i]=>Value[i];

public static A101279Inst Instance=new A101279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101280
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,8L,1L,22L,16L,1L,52L,136L,1L,114L,720L,272L,1L,240L,3072L,3968L,1L,494L,11616L,34304L,7936L,1L,1004L,40776L,230144L,176896L,1L,2026L,136384L,1328336L,2265344L,353792L,1L,4072L,441568L,6949952L,21953408L,11184128L,1L,8166L,1398000L,33981760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101280Inst : IEnumerable<long>
{
public static readonly long[] Value=A101280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101280.Bytes);
public long this[int i]=>Value[i];

public static A101280Inst Instance=new A101280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101281
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,8L,8L,5L,1L,36L,28L,18L,7L,1L,164L,120L,68L,32L,9L,1L,764L,552L,292L,136L,50L,11L,1L,3652L,2616L,1356L,608L,240L,72L,13L,1L,17852L,12680L,6532L,2880L,1140L,388L,98L,15L,1L,88868L,62664L,32156L,14128L,5572L,1976L,588L,128L,17L,1L,449004L,314744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101281Inst : IEnumerable<long>
{
public static readonly long[] Value=A101281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101281.Bytes);
public long this[int i]=>Value[i];

public static A101281Inst Instance=new A101281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101282
{
public static readonly long[] Value={ 2L,5L,1L,14L,7L,1L,42L,36L,11L,1L,132L,165L,80L,16L,1L,429L,715L,484L,155L,22L,1L,1430L,3003L,2639L,1183L,273L,29L,1L,4862L,12376L,13468L,7840L,2554L,448L,37L,1L,16796L,50388L,65688L,47328L,20124L,5031L,696L,46L,1L,58786L,203490L,310080L,267444L,141219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101282Inst : IEnumerable<long>
{
public static readonly long[] Value=A101282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101282.Bytes);
public long this[int i]=>Value[i];

public static A101282Inst Instance=new A101282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101283
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,7L,5L,16L,6L,15L,13L,32L,9L,14L,10L,31L,12L,29L,11L,64L,25L,30L,26L,17L,63L,28L,18L,61L,20L,27L,128L,19L,24L,57L,23L,62L,21L,58L,49L,22L,127L,60L,50L,33L,125L,52L,59L,256L,34L,51L,56L,36L,121L,55L,126L,35L,40L,53L,39L,122L,113L,37L,48L,54L,255L,47L,38L,124L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101283Inst : IEnumerable<long>
{
public static readonly long[] Value=A101283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101283.Bytes);
public long this[int i]=>Value[i];

public static A101283Inst Instance=new A101283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101284
{
public static readonly long[] Value={ 5L,9L,11L,17L,29L,35L,39L,51L,65L,71L,77L,95L,101L,107L,117L,129L,131L,137L,141L,149L,161L,179L,185L,201L,215L,239L,249L,267L,269L,287L,297L,299L,305L,309L,315L,327L,329L,339L,341L,347L,371L,375L,381L,401L,407L,429L,431L,441L,449L,459L,471L,479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101284Inst : IEnumerable<long>
{
public static readonly long[] Value=A101284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101284.Bytes);
public long this[int i]=>Value[i];

public static A101284Inst Instance=new A101284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101285
{
public static readonly long[] Value={ 55L,62L,65L,73L,82L,87L,98L,110L,123L,131L,147L,165L,175L,196L,220L,247L,262L,294L,330L,349L,392L,440L,494L,523L,587L,659L,698L,784L,880L,988L,1047L,1175L,1319L,1397L,1568L,1760L,1976L,2093L,2349L,2637L,2794L,3136L,3520L,3951L,4186L,4699L,5274L,5588L,6272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101285Inst : IEnumerable<long>
{
public static readonly long[] Value=A101285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101285.Bytes);
public long this[int i]=>Value[i];

public static A101285Inst Instance=new A101285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101286
{
public static readonly long[] Value={ 55L,58L,62L,65L,69L,73L,78L,82L,87L,92L,98L,104L,110L,117L,123L,131L,139L,147L,156L,165L,175L,185L,196L,208L,220L,233L,247L,262L,277L,294L,311L,330L,349L,370L,392L,415L,440L,466L,494L,523L,554L,587L,622L,659L,698L,740L,784L,831L,880L,932L,988L,1047L,1109L,1175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101286Inst : IEnumerable<long>
{
public static readonly long[] Value=A101286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101286.Bytes);
public long this[int i]=>Value[i];

public static A101286Inst Instance=new A101286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101287
{
public static readonly long[] Value={ 92L,104L,117L,139L,156L,185L,208L,233L,277L,311L,370L,415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101287Inst : IEnumerable<long>
{
public static readonly long[] Value=A101287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101287.Bytes);
public long this[int i]=>Value[i];

public static A101287Inst Instance=new A101287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101288
{
public static readonly long[] Value={ 1L,5L,6L,7L,5L,5L,4L,2L,2L,3L,3L,4L,9L,6L,7L,10L,12L,10L,12L,13L,15L,26L,27L,30L,36L,41L,43L,46L,48L,49L,68L,69L,70L,73L,76L,94L,95L,97L,98L,97L,104L,114L,118L,118L,120L,122L,131L,135L,138L,139L,153L,155L,160L,162L,162L,170L,178L,177L,182L,181L,184L,188L,191L,192L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101288Inst : IEnumerable<long>
{
public static readonly long[] Value=A101288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101288.Bytes);
public long this[int i]=>Value[i];

public static A101288Inst Instance=new A101288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101289
{
public static readonly long[] Value={ 1L,7L,22L,63L,127L,280L,463L,855L,1309L,2135L,3004L,4704L,6189L,9037L,11776L,16359L,20350L,27901L,33650L,44695L,53614L,68790L,80731L,103776L,118882L,148701L,171220L,210469L,237337L,292292L,324633L,393351L,438922L,522298L,576346L,690333L,749399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101289Inst : IEnumerable<long>
{
public static readonly long[] Value=A101289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101289.Bytes);
public long this[int i]=>Value[i];

public static A101289Inst Instance=new A101289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101290
{
public static readonly long[] Value={ 0L,1L,1L,3L,3L,3L,5L,5L,5L,7L,7L,7L,7L,7L,7L,9L,9L,9L,11L,11L,11L,11L,11L,11L,12L,12L,12L,14L,14L,14L,14L,14L,14L,15L,15L,15L,16L,16L,16L,16L,16L,16L,16L,16L,16L,18L,18L,18L,19L,19L,19L,19L,19L,19L,20L,20L,20L,20L,20L,20L,22L,22L,22L,23L,23L,23L,23L,23L,23L,25L,25L,25L,25L,25L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101290Inst : IEnumerable<long>
{
public static readonly long[] Value=A101290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101290.Bytes);
public long this[int i]=>Value[i];

public static A101290Inst Instance=new A101290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101291
{
public static readonly BigInteger[] Value={ 45L,4905L,494550L,49495500L,4949955000L,494999550000L,49499995500000L,4949999955000000L,494999999550000000L,BigInteger.Parse("49499999995500000000"),BigInteger.Parse("4949999999955000000000"),BigInteger.Parse("494999999999550000000000"),BigInteger.Parse("49499999999995500000000000"),BigInteger.Parse("4949999999999955000000000000") };
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
public class A101291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101291Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A101291.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A101291.Bytes);
public BigInteger this[int i]=>Value[i];

public static A101291Inst Instance=new A101291Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101292
{
public static readonly BigInteger[] Value={ 1L,2L,5L,12L,34L,135L,741L,5068L,40356L,362925L,3628855L,39916866L,479001678L,6227020891L,87178291305L,1307674368120L,20922789888136L,355687428096153L,6402373705728171L,121645100408832190L,2432902008176640210L,BigInteger.Parse("51090942171709440231"),BigInteger.Parse("1124000727777607680253") };
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
public class A101292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101292Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A101292.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A101292.Bytes);
public BigInteger this[int i]=>Value[i];

public static A101292Inst Instance=new A101292Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101293
{
public static readonly BigInteger[] Value={ 1L,1L,3L,18L,103682L,BigInteger.Parse("11981655542024930675232002") };
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
public class A101293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101293Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A101293.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A101293.Bytes);
public BigInteger this[int i]=>Value[i];

public static A101293Inst Instance=new A101293Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101294
{
public static readonly long[] Value={ 56L,93L,94L,117L,143L,144L,145L,146L,160L,207L,214L,215L,216L,217L,297L,303L,325L,326L,327L,393L,537L,687L,723L,801L,1137L,1347L,1467L,1537L,1713L,1943L,1983L,2103L,2217L,2304L,2305L,2306L,2427L,2643L,2666L,2716L,3867L,3914L,4413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101294Inst : IEnumerable<long>
{
public static readonly long[] Value=A101294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101294.Bytes);
public long this[int i]=>Value[i];

public static A101294Inst Instance=new A101294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101295
{
public static readonly BigInteger[] Value={ 1L,1L,2L,11L,1575L,1844349560L,BigInteger.Parse("153758476658245881594406593"),BigInteger.Parse("347537071782505941949439171855284853031279455482877609142244398412144336038") };
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
public class A101295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101295Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A101295.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A101295.Bytes);
public BigInteger this[int i]=>Value[i];

public static A101295Inst Instance=new A101295Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101296
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,2L,5L,3L,4L,2L,6L,2L,4L,4L,7L,2L,6L,2L,6L,4L,4L,2L,8L,3L,4L,5L,6L,2L,9L,2L,10L,4L,4L,4L,11L,2L,4L,4L,8L,2L,9L,2L,6L,6L,4L,2L,12L,3L,6L,4L,6L,2L,8L,4L,8L,4L,4L,2L,13L,2L,4L,6L,14L,4L,9L,2L,6L,4L,9L,2L,15L,2L,4L,6L,6L,4L,9L,2L,12L,7L,4L,2L,13L,4L,4L,4L,8L,2L,13L,4L,6L,4L,4L,4L,16L,2L,6L,6L,11L,2L,9L,2L,8L,9L,4L,2L,15L,2L,9L,4L,12L,2L,9L,4L,6L,6L,4L,4L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101296Inst : IEnumerable<long>
{
public static readonly long[] Value=A101296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101296.Bytes);
public long this[int i]=>Value[i];

public static A101296Inst Instance=new A101296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101297
{
public static readonly long[] Value={ 1L,1L,0L,3L,8L,7L,9L,9L,8L,8L,0L,5L,6L,3L,3L,5L,3L,1L,7L,2L,3L,9L,7L,8L,5L,6L,8L,2L,3L,4L,8L,2L,7L,5L,6L,4L,2L,1L,9L,2L,4L,7L,7L,0L,2L,4L,8L,3L,1L,3L,4L,4L,5L,0L,8L,7L,3L,6L,9L,7L,2L,2L,6L,3L,6L,2L,3L,3L,9L,1L,9L,1L,0L,6L,7L,6L,2L,3L,4L,3L,3L,9L,8L,5L,5L,3L,5L,2L,0L,6L,8L,2L,6L,1L,1L,9L,8L,9L,2L,7L,8L,6L,5L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101297Inst : IEnumerable<long>
{
public static readonly long[] Value=A101297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101297.Bytes);
public long this[int i]=>Value[i];

public static A101297Inst Instance=new A101297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101298
{
public static readonly long[] Value={ 3L,5L,9L,2L,3L,7L,3L,8L,9L,0L,0L,4L,0L,1L,0L,4L,3L,6L,8L,6L,0L,8L,9L,8L,6L,1L,7L,8L,7L,2L,9L,8L,4L,5L,1L,0L,1L,5L,6L,2L,6L,8L,8L,6L,4L,0L,7L,6L,3L,3L,8L,4L,9L,7L,1L,6L,7L,8L,2L,7L,0L,7L,6L,8L,0L,7L,9L,3L,5L,7L,8L,2L,4L,2L,5L,1L,8L,7L,5L,0L,7L,4L,3L,5L,6L,5L,6L,6L,5L,7L,5L,3L,4L,6L,9L,5L,0L,0L,8L,6L,5L,2L,1L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101298Inst : IEnumerable<long>
{
public static readonly long[] Value=A101298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101298.Bytes);
public long this[int i]=>Value[i];

public static A101298Inst Instance=new A101298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101299
{
public static readonly long[] Value={ 3L,4L,6L,7L,10L,11L,15L,16L,18L,20L,21L,22L,24L,25L,26L,27L,28L,29L,30L,31L,34L,35L,37L,38L,42L,50L,52L,53L,64L,65L,66L,70L,77L,79L,83L,91L,105L,113L,116L,126L,127L,128L,130L,132L,133L,135L,138L,141L,144L,150L,152L,157L,159L,161L,164L,168L,189L,198L,224L,225L,231L,241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101299Inst : IEnumerable<long>
{
public static readonly long[] Value=A101299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101299.Bytes);
public long this[int i]=>Value[i];

public static A101299Inst Instance=new A101299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101300
{
public static readonly long[] Value={ 3L,3L,5L,7L,7L,11L,11L,13L,13L,13L,13L,17L,17L,19L,19L,19L,19L,23L,23L,29L,29L,29L,29L,31L,31L,31L,31L,31L,31L,37L,37L,41L,41L,41L,41L,41L,41L,43L,43L,43L,43L,47L,47L,53L,53L,53L,53L,59L,59L,59L,59L,59L,59L,61L,61L,61L,61L,61L,61L,67L,67L,71L,71L,71L,71L,71L,71L,73L,73L,73L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101300Inst : IEnumerable<long>
{
public static readonly long[] Value=A101300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101300.Bytes);
public long this[int i]=>Value[i];

public static A101300Inst Instance=new A101300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101301
{
public static readonly long[] Value={ 1L,3L,7L,13L,23L,35L,51L,69L,91L,119L,149L,185L,225L,267L,313L,365L,423L,483L,549L,619L,691L,769L,851L,939L,1035L,1135L,1237L,1343L,1451L,1563L,1689L,1819L,1955L,2093L,2241L,2391L,2547L,2709L,2875L,3047L,3225L,3405L,3595L,3787L,3983L,4181L,4391L,4613L,4839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101301Inst : IEnumerable<long>
{
public static readonly long[] Value=A101301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101301.Bytes);
public long this[int i]=>Value[i];

public static A101301Inst Instance=new A101301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101302
{
public static readonly long[] Value={ 3L,7L,13L,23L,149L,313L,619L,691L,769L,1237L,1451L,4391L,7639L,9787L,11527L,19489L,21943L,27997L,32869L,35449L,36107L,36767L,46817L,49939L,55691L,56543L,59119L,61757L,69127L,70079L,73973L,81047L,83117L,87337L,89491L,91673L,93871L,106537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101302Inst : IEnumerable<long>
{
public static readonly long[] Value=A101302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101302.Bytes);
public long this[int i]=>Value[i];

public static A101302Inst Instance=new A101302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101303
{
public static readonly long[] Value={ 3L,7L,28L,60L,360L,1512L,3276L,16256L,65528L,261120L,79360L,1098240L,13852800L,25261824L,79536128L,1040179456L,1710858240L,13815410400L,71687577600L,137707384824L,151060010112L,1932916285440L,4212741841200L,508764077015040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101303Inst : IEnumerable<long>
{
public static readonly long[] Value=A101303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101303.Bytes);
public long this[int i]=>Value[i];

public static A101303Inst Instance=new A101303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101304
{
public static readonly BigInteger[] Value={ 9L,17L,65L,257L,4097L,16385L,262145L,1048577L,16777217L,1073741825L,4294967297L,274877906945L,4398046511105L,17592186044417L,281474976710657L,18014398509481985L,1152921504606846977L,4611686018427387905L,BigInteger.Parse("295147905179352825857"),BigInteger.Parse("4722366482869645213697") };
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
public class A101304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101304Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A101304.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A101304.Bytes);
public BigInteger this[int i]=>Value[i];

public static A101304Inst Instance=new A101304Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101305
{
public static readonly BigInteger[] Value={ 0L,10L,10100L,101001000L,10100100010000L,10100100010000100000UL,BigInteger.Parse("101001000100001000001000000"),BigInteger.Parse("10100100010000100000100000010000000"),BigInteger.Parse("10100100010000100000100000010000000100000000") };
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
public class A101305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101305Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A101305.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A101305.Bytes);
public BigInteger this[int i]=>Value[i];

public static A101305Inst Instance=new A101305Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101306
{
public static readonly long[] Value={ 2L,5L,10L,17L,18L,21L,28L,37L,40L,49L,50L,57L,58L,61L,68L,71L,80L,81L,88L,89L,92L,101L,104L,113L,120L,121L,124L,131L,140L,143L,150L,151L,158L,167L,176L,177L,184L,187L,194L,197L,206L,207L,208L,211L,218L,227L,228L,231L,238L,247L,250L,259L,260L,261L,268L,271L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101306Inst : IEnumerable<long>
{
public static readonly long[] Value=A101306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101306.Bytes);
public long this[int i]=>Value[i];

public static A101306Inst Instance=new A101306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101307
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,7L,6L,1L,18L,18L,6L,47L,59L,24L,2L,129L,188L,96L,16L,362L,605L,369L,90L,4L,1038L,1948L,1395L,436L,45L,3022L,6305L,5164L,1981L,315L,9L,8917L,20460L,18885L,8568L,1830L,126L,26600L,66585L,68352L,35818L,9565L,1071L,21L,80098L,217186L,245497L,145796L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101307Inst : IEnumerable<long>
{
public static readonly long[] Value=A101307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101307.Bytes);
public long this[int i]=>Value[i];

public static A101307Inst Instance=new A101307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101308
{
public static readonly long[] Value={ 1L,1L,1L,3L,7L,18L,47L,129L,362L,1038L,3022L,8917L,26600L,80098L,243132L,743180L,2285597L,7067271L,21957947L,68517606L,214633572L,674712991L,2127790260L,6729876378L,21342679122L,67851885121L,216204228642L,690371596017L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101308Inst : IEnumerable<long>
{
public static readonly long[] Value=A101308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101308.Bytes);
public long this[int i]=>Value[i];

public static A101308Inst Instance=new A101308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101309
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101309Inst : IEnumerable<long>
{
public static readonly long[] Value=A101309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101309.Bytes);
public long this[int i]=>Value[i];

public static A101309Inst Instance=new A101309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101310
{
public static readonly long[] Value={ 0L,20L,320L,5320L,75320L,1175320L,14175320L,184175320L,2084175320L,25084175320L,315084175320L,3415084175320L,40415084175320L,450415084175320L,4750415084175320L,51750415084175320L,581750415084175320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101310Inst : IEnumerable<long>
{
public static readonly long[] Value=A101310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101310.Bytes);
public long this[int i]=>Value[i];

public static A101310Inst Instance=new A101310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101311
{
public static readonly long[] Value={ 1L,1233L,8833L,10100L,990100L,5882353L,94122353L,1765038125L,2584043776L,7416043776L,8235038125L,116788321168L,123288328768L,876712328768L,883212321168L,7681802663025L,8896802846976L,13793103448276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101311Inst : IEnumerable<long>
{
public static readonly long[] Value=A101311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101311.Bytes);
public long this[int i]=>Value[i];

public static A101311Inst Instance=new A101311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101312
{
public static readonly long[] Value={ 2L,1L,3L,1L,2L,2L,2L,2L,1L,1L,2L,2L,1L,3L,1L,1L,2L,2L,1L,2L,1L,2L,2L,1L,3L,1L,1L,3L,2L,1L,3L,1L,2L,2L,2L,2L,1L,1L,2L,2L,1L,3L,1L,1L,2L,2L,1L,2L,1L,2L,2L,1L,3L,1L,1L,3L,2L,1L,3L,1L,2L,2L,2L,2L,1L,1L,2L,2L,1L,3L,1L,1L,2L,2L,1L,2L,1L,2L,2L,1L,3L,1L,1L,3L,2L,1L,3L,1L,2L,2L,2L,2L,1L,1L,2L,2L,1L,3L,1L,1L,2L,2L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101312Inst : IEnumerable<long>
{
public static readonly long[] Value=A101312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101312.Bytes);
public long this[int i]=>Value[i];

public static A101312Inst Instance=new A101312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101313
{
public static readonly BigInteger[] Value={ 1L,3L,12L,68L,525L,5262L,65674L,987408L,17426565L,353759300L,8127640224L,208600774032L,5917247520457L,183872561612040L,6212370268252950L,226762373954676608L,8893485959056048521L,BigInteger.Parse("372980176625914811568"),BigInteger.Parse("16656844860594186642100"),BigInteger.Parse("789196576594282265505600") };
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
public class A101313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101313Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A101313.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A101313.Bytes);
public BigInteger this[int i]=>Value[i];

public static A101313Inst Instance=new A101313Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101314
{
public static readonly long[] Value={ 2L,8L,4L,6L,6L,8L,1L,3L,7L,0L,4L,0L,8L,3L,8L,4L,6L,1L,6L,8L,0L,2L,2L,5L,6L,7L,6L,7L,6L,9L,7L,1L,9L,1L,3L,0L,9L,8L,6L,5L,0L,2L,6L,7L,0L,5L,8L,5L,0L,4L,5L,4L,3L,1L,5L,1L,6L,9L,3L,1L,4L,7L,0L,9L,7L,7L,6L,6L,8L,9L,4L,3L,9L,0L,2L,5L,9L,2L,4L,4L,3L,7L,8L,3L,9L,6L,3L,7L,5L,5L,9L,8L,6L,0L,1L,1L,0L,7L,5L,0L,6L,3L,7L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101314Inst : IEnumerable<long>
{
public static readonly long[] Value=A101314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101314.Bytes);
public long this[int i]=>Value[i];

public static A101314Inst Instance=new A101314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101315
{
public static readonly long[] Value={ 3L,5L,11L,431L,1877L,2081L,3851L,9437L,10427L,11351L,12821L,14561L,20147L,26861L,30137L,30851L,37571L,38711L,38921L,40637L,46817L,59357L,73361L,116687L,120941L,125507L,127817L,138371L,144407L,153521L,173021L,177011L,178091L,178817L,185567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101315Inst : IEnumerable<long>
{
public static readonly long[] Value=A101315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101315.Bytes);
public long this[int i]=>Value[i];

public static A101315Inst Instance=new A101315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101316
{
public static readonly long[] Value={ 1L,2L,21L,32L,33L,34L,41L,51L,62L,63L,71L,82L,84L,91L,93L,211L,311L,411L,511L,522L,531L,533L,622L,711L,713L,721L,731L,733L,742L,751L,753L,754L,822L,911L,913L,915L,2111L,3111L,3122L,4112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101316Inst : IEnumerable<long>
{
public static readonly long[] Value=A101316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101316.Bytes);
public long this[int i]=>Value[i];

public static A101316Inst Instance=new A101316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101317
{
public static readonly long[] Value={ 110L,121L,132L,143L,154L,165L,176L,187L,198L,220L,231L,242L,253L,264L,275L,286L,297L,330L,341L,352L,363L,374L,385L,396L,440L,451L,462L,473L,484L,495L,550L,561L,572L,583L,594L,660L,671L,682L,693L,770L,781L,792L,880L,891L,990L,1010L,1021L,1032L,1043L,1054L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101317Inst : IEnumerable<long>
{
public static readonly long[] Value=A101317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101317.Bytes);
public long this[int i]=>Value[i];

public static A101317Inst Instance=new A101317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101318
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,20L,100L,101L,110L,200L,1000L,1001L,1010L,1100L,2000L,10000L,10001L,10010L,10100L,11000L,20000L,100000L,100001L,100010L,100100L,101000L,110000L,200000L,1000000L,10000000L,10000001L,10000010L,10000100L,10001000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101318Inst : IEnumerable<long>
{
public static readonly long[] Value=A101318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101318.Bytes);
public long this[int i]=>Value[i];

public static A101318Inst Instance=new A101318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101319
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,12L,8L,4L,5L,14L,17L,28L,18L,21L,35L,50L,40L,15L,30L,31L,51L,72L,23L,43L,66L,56L,20L,16L,9L,27L,54L,55L,87L,120L,38L,45L,79L,115L,153L,192L,13L,37L,73L,112L,26L,41L,81L,126L,105L,152L,52L,42L,59L,104L,44L,36L,33L,78L,88L,46L,67L,124L,80L,24L,19L,64L,10L,32L,11L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101319Inst : IEnumerable<long>
{
public static readonly long[] Value=A101319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101319.Bytes);
public long this[int i]=>Value[i];

public static A101319Inst Instance=new A101319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101320
{
public static readonly long[] Value={ 15855L,31785L,267300L,280665L,399675L,561330L,946050L,990510L,1022220L,1082115L,1164735L,1283250L,1303875L,1309545L,1514880L,1669065L,1924410L,2850225L,3078675L,3092760L,3492270L,3536385L,3611205L,3920670L,4148970L,4454775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101320Inst : IEnumerable<long>
{
public static readonly long[] Value=A101320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101320.Bytes);
public long this[int i]=>Value[i];

public static A101320Inst Instance=new A101320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101321
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,3L,1L,1L,7L,7L,4L,1L,1L,11L,13L,10L,5L,1L,1L,16L,21L,19L,13L,6L,1L,1L,22L,31L,31L,25L,16L,7L,1L,1L,29L,43L,46L,41L,31L,19L,8L,1L,1L,37L,57L,64L,61L,51L,37L,22L,9L,1L,1L,46L,73L,85L,85L,76L,61L,43L,25L,10L,1L,1L,56L,91L,109L,113L,106L,91L,71L,49L,28L,11L,1L,1L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101321Inst : IEnumerable<long>
{
public static readonly long[] Value=A101321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101321.Bytes);
public long this[int i]=>Value[i];

public static A101321Inst Instance=new A101321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101322
{
public static readonly long[] Value={ 1L,1L,1L,4L,1L,5L,1L,6L,9L,7L,1L,11L,1L,9L,13L,16L,1L,15L,1L,19L,17L,13L,1L,22L,25L,15L,21L,25L,1L,29L,1L,28L,25L,19L,33L,36L,1L,21L,29L,37L,1L,41L,1L,37L,41L,25L,1L,46L,49L,45L,37L,43L,1L,51L,49L,55L,41L,31L,1L,56L,1L,33L,61L,64L,57L,61L,1L,55L,49L,67L,1L,71L,1L,39L,65L,61L,73L,71L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101322Inst : IEnumerable<long>
{
public static readonly long[] Value=A101322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101322.Bytes);
public long this[int i]=>Value[i];

public static A101322Inst Instance=new A101322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101323
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,10L,12L,101L,117L,227L,884L,1323L,2167L,3483L,6274L,7887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101323Inst : IEnumerable<long>
{
public static readonly long[] Value=A101323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101323.Bytes);
public long this[int i]=>Value[i];

public static A101323Inst Instance=new A101323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101324
{
public static readonly long[] Value={ 7L,13L,19L,29L,43L,53L,61L,107L,113L,181L,193L,229L,251L,317L,337L,383L,433L,463L,491L,601L,827L,857L,887L,997L,1033L,1061L,1163L,1193L,1307L,1373L,1531L,1693L,1699L,1721L,1789L,1811L,1831L,1931L,2003L,2029L,2267L,2339L,2347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101324Inst : IEnumerable<long>
{
public static readonly long[] Value=A101324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101324.Bytes);
public long this[int i]=>Value[i];

public static A101324Inst Instance=new A101324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101325
{
public static readonly long[] Value={ 2L,5L,6L,15L,24L,33L,42L,51L,60L,70L,76L,107L,166L,170L,255L,261L,344L,352L,433L,434L,522L,525L,611L,616L,700L,707L,1607L,1616L,1625L,1634L,1643L,1652L,1661L,1670L,2507L,2516L,2525L,2534L,2543L,2552L,2561L,2570L,3407L,3416L,3425L,3434L,3443L,3452L,3461L,3470L,4307L,4316L,4325L,4334L,4343L,4352L,4361L,4370L,5207L,5216L,5225L,5234L,5243L,5252L,5261L,5270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101325Inst : IEnumerable<long>
{
public static readonly long[] Value=A101325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101325.Bytes);
public long this[int i]=>Value[i];

public static A101325Inst Instance=new A101325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101326
{
public static readonly long[] Value={ 3L,3L,11L,3L,5L,31L,3L,5L,17L,59L,3L,5L,7L,13L,127L,3L,5L,7L,11L,41L,191L,3L,5L,7L,11L,13L,23L,337L,3L,5L,7L,11L,13L,17L,19L,509L,3L,5L,7L,11L,13L,17L,19L,43L,701L,3L,5L,7L,11L,13L,17L,19L,23L,29L,983L,3L,5L,7L,11L,13L,17L,19L,23L,29L,47L,1289L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101326Inst : IEnumerable<long>
{
public static readonly long[] Value=A101326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101326.Bytes);
public long this[int i]=>Value[i];

public static A101326Inst Instance=new A101326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101327
{
public static readonly BigInteger[] Value={ 0L,1L,127L,BigInteger.Parse("170141183460469231731687303715884105727") };
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
public class A101327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101327Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A101327.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A101327.Bytes);
public BigInteger this[int i]=>Value[i];

public static A101327Inst Instance=new A101327Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101328
{
public static readonly long[] Value={ 1L,5L,11L,17L,23L,29L,35L,41L,47L,53L,59L,65L,71L,77L,83L,89L,95L,101L,107L,113L,119L,125L,131L,137L,143L,149L,155L,161L,167L,173L,179L,185L,191L,197L,203L,209L,215L,221L,227L,233L,239L,245L,251L,257L,263L,269L,275L,281L,287L,293L,299L,305L,311L,317L,323L,329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101328Inst : IEnumerable<long>
{
public static readonly long[] Value=A101328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101328.Bytes);
public long this[int i]=>Value[i];

public static A101328Inst Instance=new A101328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101329
{
public static readonly BigInteger[] Value={ 7L,31L,131071L,BigInteger.Parse("231584178474632390847141970017375815706539969331281128078915168015826259279871") };
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
public class A101329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101329Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A101329.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A101329.Bytes);
public BigInteger this[int i]=>Value[i];

public static A101329Inst Instance=new A101329Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101330
{
public static readonly long[] Value={ 3L,5L,5L,8L,8L,8L,11L,13L,13L,11L,13L,18L,21L,18L,13L,16L,21L,29L,29L,21L,16L,18L,26L,34L,40L,34L,26L,18L,21L,29L,42L,47L,47L,42L,29L,21L,24L,34L,47L,58L,55L,58L,47L,34L,24L,26L,39L,55L,65L,68L,68L,65L,55L,39L,26L,29L,42L,63L,76L,76L,84L,76L,76L,63L,42L,29L,32L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101330Inst : IEnumerable<long>
{
public static readonly long[] Value=A101330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101330.Bytes);
public long this[int i]=>Value[i];

public static A101330Inst Instance=new A101330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101331
{
public static readonly BigInteger[] Value={ 3L,5L,257L,BigInteger.Parse("340282366920938463463374607431768211457") };
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
public class A101331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101331Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A101331.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A101331.Bytes);
public BigInteger this[int i]=>Value[i];

public static A101331Inst Instance=new A101331Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101332
{
public static readonly long[] Value={ 3L,8L,21L,40L,55L,84L,105L,144L,189L,220L,275L,336L,377L,448L,495L,576L,663L,720L,817L,880L,987L,1100L,1173L,1296L,1425L,1508L,1647L,1736L,1885L,2040L,2139L,2304L,2475L,2584L,2765L,2880L,3071L,3268L,3393L,3600L,3731L,3948L,4171L,4312L,4545L,4784L,4935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101332Inst : IEnumerable<long>
{
public static readonly long[] Value=A101332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101332.Bytes);
public long this[int i]=>Value[i];

public static A101332Inst Instance=new A101332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101333
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,2L,4L,8L,16L,32L,65L,130L,260L,520L,1040L,2080L,4161L,8322L,16644L,33288L,66577L,133154L,266309L,532618L,1065236L,2130472L,4260944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101333Inst : IEnumerable<long>
{
public static readonly long[] Value=A101333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101333.Bytes);
public long this[int i]=>Value[i];

public static A101333Inst Instance=new A101333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101334
{
public static readonly BigInteger[] Value={ 0L,0L,1L,11L,131L,1829L,29849L,561399L,11994247L,287420489L,7642052309L,223394306387L,7123940054219L,246181194216957L,9165811757198641L,365836296342931439L,15584321022199735823UL,BigInteger.Parse("705800730789742512401"),BigInteger.Parse("33866021217511735389485"),BigInteger.Parse("1716275655660313589123979") };
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
public class A101334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101334Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A101334.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A101334.Bytes);
public BigInteger this[int i]=>Value[i];

public static A101334Inst Instance=new A101334Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101335
{
public static readonly BigInteger[] Value={ 136L,244L,2178L,6514L,58618L,76438L,2755907L,6586433L,8139850L,9057586L,277668893L,756738746L,21914086555935085L,37878721692554416L,187864919457180831L,375609204308055082L,13397885590701080090UL,BigInteger.Parse("40091536165423401387"),BigInteger.Parse("108493282045082839040458"),BigInteger.Parse("183144838903847612823687") };
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
public class A101335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101335Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A101335.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A101335.Bytes);
public BigInteger this[int i]=>Value[i];

public static A101335Inst Instance=new A101335Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101336
{
public static readonly long[] Value={ 0L,0L,0L,1L,-1L,-1L,1L,2L,0L,3L,-4L,-4L,-2L,-1L,4L,2L,0L,0L,2L,3L,-4L,6L,-7L,-7L,-5L,-9L,3L,7L,13L,14L,10L,10L,9L,2L,-16L,-13L,-11L,-10L,7L,23L,16L,16L,25L,26L,13L,11L,-14L,-14L,-12L,-4L,-10L,-23L,-11L,-10L,-9L,-25L,-20L,2L,29L,29L,26L,27L,-6L,4L,2L,10L,0L,0L,-18L,-37L,-36L,-35L,-34L,-34L,2L,1L,19L,16L,31L,32L,25L,28L,-15L,-15L,-6L,-27L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101336Inst : IEnumerable<long>
{
public static readonly long[] Value=A101336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101336.Bytes);
public long this[int i]=>Value[i];

public static A101336Inst Instance=new A101336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101337
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,2L,5L,10L,17L,26L,37L,50L,65L,82L,4L,5L,8L,13L,20L,29L,40L,53L,68L,85L,9L,10L,13L,18L,25L,34L,45L,58L,73L,90L,16L,17L,20L,25L,32L,41L,52L,65L,80L,97L,25L,26L,29L,34L,41L,50L,61L,74L,89L,106L,36L,37L,40L,45L,52L,61L,72L,85L,100L,117L,49L,50L,53L,58L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101337Inst : IEnumerable<long>
{
public static readonly long[] Value=A101337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101337.Bytes);
public long this[int i]=>Value[i];

public static A101337Inst Instance=new A101337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101338
{
public static readonly long[] Value={ 1L,2L,4L,9L,20L,41L,77L,134L,219L,340L,506L,727L,1014L,1379L,1835L,2396L,3077L,3894L,4864L,6005L,7336L,8877L,10649L,12674L,14975L,17576L,20502L,23779L,27434L,31495L,35991L,40952L,46409L,52394L,58940L,66081L,73852L,82289L,91429L,101310L,111971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101338Inst : IEnumerable<long>
{
public static readonly long[] Value=A101338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101338.Bytes);
public long this[int i]=>Value[i];

public static A101338Inst Instance=new A101338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101339
{
public static readonly BigInteger[] Value={ 2L,24L,3120L,823536L,285311670600L,302875106592240L,BigInteger.Parse("827240261886336764160"),BigInteger.Parse("1978419655660313589123960"),BigInteger.Parse("20880467999847912034355032910544"),BigInteger.Parse("2567686153161211134561828214731016126483440") };
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
public class A101339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101339Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A101339.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A101339.Bytes);
public BigInteger this[int i]=>Value[i];

public static A101339Inst Instance=new A101339Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101340
{
public static readonly BigInteger[] Value={ 6L,30L,3130L,823550L,285311670622L,302875106592266L,BigInteger.Parse("827240261886336764194"),BigInteger.Parse("1978419655660313589123998"),BigInteger.Parse("20880467999847912034355032910590"),BigInteger.Parse("2567686153161211134561828214731016126483498") };
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
public class A101340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101340Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A101340.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A101340.Bytes);
public BigInteger this[int i]=>Value[i];

public static A101340Inst Instance=new A101340Inst();

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