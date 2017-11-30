using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A078483
{
public static readonly long[] Value={ 1L,1L,2L,6L,20L,69L,243L,869L,3145L,11491L,42312L,156807L,584288L,2187298L,8221257L,31009841L,117331070L,445174418L,1693270531L,6454992143L,24657428519L,94363587324L,361741068087L,1388892123038L,5340282880156L,20560742443041L,79259430563491L,305889059254747L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078483Inst : IEnumerable<long>
{
public static readonly long[] Value=A078483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078483.Bytes);
public long this[int i]=>Value[i];

public static A078483Inst Instance=new A078483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078482
{
public static readonly long[] Value={ 0L,1L,2L,6L,20L,70L,254L,948L,3618L,14058L,55432L,221262L,892346L,3630680L,14885042L,61432382L,255025212L,1064190214L,4461325382L,18780710508L,79357572866L,336466650450L,1431007889744L,6103431668830L,26099839562738L,111877997049648L,480635694869218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078482Inst : IEnumerable<long>
{
public static readonly long[] Value=A078482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078482.Bytes);
public long this[int i]=>Value[i];

public static A078482Inst Instance=new A078482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078481
{
public static readonly long[] Value={ 0L,1L,1L,3L,7L,19L,53L,153L,453L,1367L,4191L,13015L,40857L,129441L,413337L,1328971L,4298727L,13978971L,45673981L,149867513L,493638797L,1631616239L,5410015615L,17990076527L,59981630321L,200476419713L,671564145137L,2254338511507L,7582179238151L,25547868961315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078481Inst : IEnumerable<long>
{
public static readonly long[] Value=A078481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078481.Bytes);
public long this[int i]=>Value[i];

public static A078481Inst Instance=new A078481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078480
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,21L,117L,792L,6205L,55005L,543597L,5922930L,70518905L,910711193L,12678337945L,189252400480L,3015217932073L,51067619064873L,916176426422089L,17355904144773970L,346195850534379613L,7252654441500887309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078480Inst : IEnumerable<long>
{
public static readonly long[] Value=A078480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078480.Bytes);
public long this[int i]=>Value[i];

public static A078480Inst Instance=new A078480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078479
{
public static readonly long[] Value={ 1L,2L,4L,8L,4L,8L,6L,12L,4L,8L,6L,12L,6L,12L,8L,8L,4L,8L,6L,12L,6L,10L,8L,16L,6L,8L,8L,8L,8L,16L,6L,12L,4L,10L,6L,10L,6L,12L,8L,10L,6L,12L,8L,16L,8L,8L,10L,20L,6L,12L,6L,8L,8L,16L,6L,10L,8L,10L,10L,20L,6L,12L,8L,10L,4L,10L,8L,16L,6L,12L,8L,16L,6L,12L,8L,8L,8L,12L,8L,16L,6L,8L,8L,16L,8L,8L,10L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078479Inst : IEnumerable<long>
{
public static readonly long[] Value=A078479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078479.Bytes);
public long this[int i]=>Value[i];

public static A078479Inst Instance=new A078479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078478
{
public static readonly long[] Value={ 0L,1L,0L,3L,2L,9L,6L,29L,30L,99L,112L,351L,450L,1275L,1734L,4707L,6762L,17577L,26208L,66197L,101862L,250953L,395804L,956385L,1540110L,3660541L,5997600L,14061141L,23382294L,54177741L,91246662L,209295261L,356432166L,810375651L,1393592512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078478Inst : IEnumerable<long>
{
public static readonly long[] Value=A078478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078478.Bytes);
public long this[int i]=>Value[i];

public static A078478Inst Instance=new A078478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078477
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,6L,7L,15L,15L,30L,31L,63L,63L,126L,127L,255L,255L,510L,511L,1023L,1023L,2046L,2047L,4095L,4095L,8190L,8191L,16383L,16383L,32766L,32767L,65535L,65535L,131070L,131071L,262143L,262143L,524286L,524287L,1048575L,1048575L,2097150L,2097151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078477Inst : IEnumerable<long>
{
public static readonly long[] Value=A078477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078477.Bytes);
public long this[int i]=>Value[i];

public static A078477Inst Instance=new A078477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078476
{
public static readonly long[] Value={ 1L,2L,6L,11L,16L,22L,28L,35L,42L,50L,58L,67L,76L,86L,96L,107L,118L,130L,142L,155L,168L,182L,196L,211L,226L,242L,258L,275L,292L,310L,328L,347L,366L,386L,406L,427L,448L,470L,492L,515L,538L,562L,586L,611L,636L,662L,688L,715L,742L,770L,798L,827L,856L,886L,916L,947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078476Inst : IEnumerable<long>
{
public static readonly long[] Value=A078476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078476.Bytes);
public long this[int i]=>Value[i];

public static A078476Inst Instance=new A078476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078475
{
public static readonly long[] Value={ 1L,-2L,15L,-594L,-5187L,23244L,122475L,-279292L,-1157143L,1850930L,6642839L,-8529278L,-27810555L,30741424L,93575187L,-92784984L,-268191855L,244875462L,679807583L,-581798410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078475Inst : IEnumerable<long>
{
public static readonly long[] Value=A078475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078475.Bytes);
public long this[int i]=>Value[i];

public static A078475Inst Instance=new A078475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078474
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,4L,5L,5L,5L,5L,6L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,8L,9L,10L,11L,12L,12L,12L,12L,13L,14L,15L,16L,16L,16L,16L,17L,18L,19L,20L,20L,20L,20L,21L,22L,23L,24L,24L,24L,24L,25L,25L,25L,25L,26L,26L,26L,26L,27L,27L,27L,27L,28L,29L,30L,31L,31L,31L,31L,32L,32L,32L,32L,33L,33L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078474Inst : IEnumerable<long>
{
public static readonly long[] Value=A078474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078474.Bytes);
public long this[int i]=>Value[i];

public static A078474Inst Instance=new A078474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078473
{
public static readonly long[] Value={ 1L,0L,0L,5L,6L,0L,0L,0L,10L,0L,24L,0L,0L,0L,0L,21L,0L,0L,40L,30L,0L,0L,0L,0L,31L,0L,0L,0L,60L,0L,64L,0L,0L,0L,0L,50L,0L,0L,0L,0L,84L,0L,0L,120L,60L,0L,0L,0L,50L,0L,0L,0L,0L,0L,144L,0L,0L,0L,120L,0L,124L,0L,0L,85L,0L,0L,0L,0L,0L,0L,144L,0L,0L,0L,0L,200L,0L,0L,160L,126L,91L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078473Inst : IEnumerable<long>
{
public static readonly long[] Value=A078473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078473.Bytes);
public long this[int i]=>Value[i];

public static A078473Inst Instance=new A078473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078472
{
public static readonly long[] Value={ 1L,6L,12L,22L,46L,67L,107L,137L,168L,228L,292L,342L,426L,546L,606L,656L,800L,920L,1044L,1129L,12L,73L,1473L,1633L,1759L,1850L,2030L,2270L,2510L,2665L,2869L,3089L,3389L,3799L,4119L,4275L,453L,9L,4819L,5029L,5389L,5689L,5993L,6377L,6797L,6967L,7367L,7871L,8231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078472Inst : IEnumerable<long>
{
public static readonly long[] Value=A078472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078472.Bytes);
public long this[int i]=>Value[i];

public static A078472Inst Instance=new A078472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078471
{
public static readonly long[] Value={ 1L,2L,6L,7L,13L,17L,25L,26L,39L,45L,57L,61L,75L,83L,107L,108L,126L,139L,159L,165L,197L,209L,233L,237L,268L,282L,322L,330L,360L,384L,416L,417L,465L,483L,531L,544L,582L,602L,658L,664L,706L,738L,782L,794L,872L,896L,944L,948L,1005L,1036L,1108L,1122L,1176L,1216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078471Inst : IEnumerable<long>
{
public static readonly long[] Value=A078471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078471.Bytes);
public long this[int i]=>Value[i];

public static A078471Inst Instance=new A078471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078470
{
public static readonly long[] Value={ 2L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,3L,1L,1L,1L,22L,209L,2L,1L,15L,25L,2L,1L,11L,1L,1L,5L,8L,2L,2L,20L,1L,4L,1L,2L,3L,3L,2L,1L,2L,2L,5L,1L,1L,2L,195L,1L,1L,1L,1L,1L,27L,27L,1L,45L,4L,5L,1L,2L,82L,1L,1L,2L,1L,6L,6L,1L,8L,1L,2L,1L,17L,3L,8L,1L,4L,1L,1L,2L,4L,8L,6L,2L,3L,6L,2L,2L,5L,2L,3L,5L,1L,5L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078470Inst : IEnumerable<long>
{
public static readonly long[] Value=A078470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078470.Bytes);
public long this[int i]=>Value[i];

public static A078470Inst Instance=new A078470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078469
{
public static readonly long[] Value={ 1L,2L,12L,74L,456L,2810L,17316L,106706L,657552L,4052018L,24969660L,153869978L,948189528L,5843007146L,36006232404L,221880401570L,1367288641824L,8425612252514L,51920962156908L,319951385193962L,1971629273320680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078469Inst : IEnumerable<long>
{
public static readonly long[] Value=A078469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078469.Bytes);
public long this[int i]=>Value[i];

public static A078469Inst Instance=new A078469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078468
{
public static readonly long[] Value={ 1L,4L,13L,47L,188L,825L,3937L,20270L,111835L,657423L,4097622L,26965867L,186685725L,1355314108L,10289242825L,81481911259L,671596664012L,5749877335253L,51042081429213L,469037073951694L,4454991580211951L,43677136038927595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078468Inst : IEnumerable<long>
{
public static readonly long[] Value=A078468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078468.Bytes);
public long this[int i]=>Value[i];

public static A078468Inst Instance=new A078468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078387
{
public static readonly long[] Value={ -1L,-1L,0L,1L,0L,-1L,0L,1L,0L,-1L,1L,0L,-1L,-1L,0L,0L,0L,1L,0L,1L,0L,0L,-1L,0L,0L,1L,-1L,1L,0L,-1L,0L,-1L,1L,0L,-1L,0L,1L,1L,1L,1L,0L,0L,0L,1L,0L,-1L,0L,-1L,1L,1L,0L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,-1L,-1L,-1L,0L,-1L,0L,0L,1L,-1L,0L,-1L,0L,-1L,0L,0L,0L,0L,1L,0L,0L,-1L,0L,-1L,0L,0L,0L,-1L,-1L,0L,1L,0L,0L,-1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078387Inst : IEnumerable<long>
{
public static readonly long[] Value=A078387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078387.Bytes);
public long this[int i]=>Value[i];

public static A078387Inst Instance=new A078387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078386
{
public static readonly long[] Value={ 2L,5L,3L,10L,6L,17L,6L,26L,14L,31L,33L,6L,37L,43L,22L,10L,26L,57L,21L,65L,34L,6L,73L,38L,10L,82L,89L,91L,10L,101L,6L,113L,122L,42L,127L,2L,129L,134L,141L,145L,74L,30L,38L,161L,82L,170L,57L,174L,177L,185L,21L,14L,197L,102L,206L,26L,217L,110L,223L,15L,226L,58L,233L,241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078386Inst : IEnumerable<long>
{
public static readonly long[] Value=A078386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078386.Bytes);
public long this[int i]=>Value[i];

public static A078386Inst Instance=new A078386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078385
{
public static readonly long[] Value={ 1L,4L,6L,4L,4L,16L,8L,12L,12L,30L,20L,12L,36L,42L,20L,20L,24L,36L,36L,48L,32L,24L,72L,36L,32L,40L,88L,72L,40L,100L,36L,112L,60L,36L,126L,64L,84L,66L,92L,112L,72L,40L,72L,132L,80L,64L,108L,56L,116L,144L,108L,84L,196L,64L,102L,96L,180L,80L,222L,120L,112L,112L,232L,240L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078385Inst : IEnumerable<long>
{
public static readonly long[] Value=A078385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078385.Bytes);
public long this[int i]=>Value[i];

public static A078385Inst Instance=new A078385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078384
{
public static readonly long[] Value={ 2L,5L,6L,7L,7L,17L,9L,15L,11L,31L,14L,10L,37L,43L,15L,12L,17L,22L,13L,18L,21L,12L,73L,23L,13L,43L,89L,20L,14L,101L,13L,113L,63L,15L,127L,14L,46L,69L,50L,34L,41L,15L,25L,30L,45L,24L,25L,34L,62L,42L,16L,18L,197L,24L,105L,21L,38L,20L,223L,16L,115L,35L,233L,241L,46L,17L,257L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078384Inst : IEnumerable<long>
{
public static readonly long[] Value=A078384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078384.Bytes);
public long this[int i]=>Value[i];

public static A078384Inst Instance=new A078384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078383
{
public static readonly long[] Value={ 2L,5L,3L,7L,5L,17L,5L,15L,9L,31L,14L,5L,37L,43L,13L,7L,15L,22L,10L,18L,19L,5L,73L,21L,7L,43L,89L,20L,7L,101L,5L,113L,63L,12L,127L,2L,46L,69L,50L,34L,39L,10L,21L,30L,43L,24L,22L,34L,62L,42L,10L,9L,197L,22L,105L,15L,38L,18L,223L,8L,115L,31L,233L,241L,46L,12L,257L,20L,16L,58L,269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078383Inst : IEnumerable<long>
{
public static readonly long[] Value=A078383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078383.Bytes);
public long this[int i]=>Value[i];

public static A078383Inst Instance=new A078383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078382
{
public static readonly long[] Value={ 3L,6L,13L,18L,28L,18L,60L,42L,56L,32L,48L,91L,38L,44L,84L,93L,98L,80L,104L,84L,126L,195L,74L,140L,186L,126L,90L,112L,217L,102L,280L,114L,186L,312L,128L,255L,176L,204L,192L,180L,266L,372L,300L,192L,294L,324L,260L,360L,240L,228L,320L,399L,198L,504L,312L,434L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078382Inst : IEnumerable<long>
{
public static readonly long[] Value=A078382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078382.Bytes);
public long this[int i]=>Value[i];

public static A078382Inst Instance=new A078382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078381
{
public static readonly long[] Value={ 2L,2L,3L,4L,6L,2L,8L,4L,6L,2L,4L,9L,2L,2L,6L,6L,6L,4L,6L,4L,6L,12L,2L,6L,10L,4L,2L,4L,9L,2L,12L,2L,4L,12L,2L,8L,4L,4L,4L,4L,6L,12L,8L,4L,6L,8L,6L,8L,4L,4L,8L,9L,2L,12L,4L,10L,4L,12L,2L,9L,4L,8L,2L,2L,8L,18L,2L,12L,16L,4L,2L,16L,2L,3L,8L,12L,8L,6L,14L,4L,6L,6L,2L,8L,2L,12L,8L,12L,2L,2L,24L,4L,10L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078381Inst : IEnumerable<long>
{
public static readonly long[] Value=A078381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078381.Bytes);
public long this[int i]=>Value[i];

public static A078381Inst Instance=new A078381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078380
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,3L,1L,2L,1L,1L,2L,1L,1L,2L,2L,2L,1L,2L,1L,2L,3L,1L,2L,4L,1L,1L,1L,2L,1L,3L,1L,1L,2L,1L,7L,1L,1L,1L,1L,2L,2L,3L,1L,2L,1L,2L,1L,1L,1L,3L,2L,1L,2L,1L,4L,1L,2L,1L,2L,1L,3L,1L,1L,1L,2L,1L,2L,3L,1L,1L,3L,1L,2L,1L,2L,3L,2L,6L,1L,2L,2L,1L,3L,1L,2L,3L,5L,1L,1L,3L,1L,4L,2L,1L,1L,1L,2L,3L,1L,1L,3L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078380Inst : IEnumerable<long>
{
public static readonly long[] Value=A078380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078380.Bytes);
public long this[int i]=>Value[i];

public static A078380Inst Instance=new A078380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078379
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,7L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078379Inst : IEnumerable<long>
{
public static readonly long[] Value=A078379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078379.Bytes);
public long this[int i]=>Value[i];

public static A078379Inst Instance=new A078379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078378
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,1L,4L,2L,3L,1L,2L,4L,1L,1L,3L,3L,3L,2L,3L,2L,3L,5L,1L,3L,5L,2L,1L,2L,4L,1L,5L,1L,2L,4L,1L,7L,2L,2L,2L,2L,3L,4L,4L,2L,3L,3L,3L,3L,2L,2L,4L,4L,1L,4L,2L,5L,2L,4L,1L,4L,2L,4L,1L,1L,3L,5L,1L,4L,5L,2L,1L,5L,1L,2L,3L,4L,4L,3L,7L,2L,3L,3L,1L,4L,1L,4L,4L,6L,1L,1L,6L,2L,5L,3L,1L,2L,3L,3L,5L,1L,2L,5L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078378Inst : IEnumerable<long>
{
public static readonly long[] Value=A078378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078378.Bytes);
public long this[int i]=>Value[i];

public static A078378Inst Instance=new A078378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078377
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,2L,2L,2L,1L,2L,2L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,1L,2L,1L,2L,3L,1L,1L,2L,2L,2L,2L,2L,3L,2L,2L,2L,3L,2L,3L,2L,2L,2L,2L,1L,3L,2L,2L,2L,3L,1L,2L,2L,2L,1L,1L,3L,3L,1L,3L,3L,2L,1L,3L,1L,1L,3L,3L,2L,2L,2L,2L,2L,2L,1L,2L,1L,3L,2L,2L,1L,1L,3L,2L,2L,2L,1L,2L,3L,2L,2L,1L,2L,3L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078377Inst : IEnumerable<long>
{
public static readonly long[] Value=A078377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078377.Bytes);
public long this[int i]=>Value[i];

public static A078377Inst Instance=new A078377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078376
{
public static readonly long[] Value={ 2L,5L,3L,5L,3L,17L,3L,13L,7L,31L,11L,3L,37L,43L,11L,5L,13L,19L,7L,13L,17L,3L,73L,19L,5L,41L,89L,13L,5L,101L,3L,113L,61L,7L,127L,2L,43L,67L,47L,29L,37L,5L,19L,23L,41L,17L,19L,29L,59L,37L,7L,7L,197L,17L,103L,13L,31L,11L,223L,5L,113L,29L,233L,241L,41L,7L,257L,13L,11L,53L,269L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078376Inst : IEnumerable<long>
{
public static readonly long[] Value=A078376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078376.Bytes);
public long this[int i]=>Value[i];

public static A078376Inst Instance=new A078376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078375
{
public static readonly long[] Value={ 2L,5L,3L,2L,2L,17L,2L,2L,2L,31L,3L,2L,37L,43L,2L,2L,2L,3L,3L,5L,2L,2L,73L,2L,2L,2L,89L,7L,2L,101L,2L,113L,2L,2L,127L,2L,3L,2L,3L,5L,2L,2L,2L,7L,2L,2L,3L,2L,3L,5L,3L,2L,197L,2L,2L,2L,7L,2L,223L,3L,2L,2L,233L,241L,2L,2L,257L,2L,2L,5L,269L,2L,283L,17L,2L,2L,3L,2L,2L,3L,5L,2L,337L,2L,347L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078375Inst : IEnumerable<long>
{
public static readonly long[] Value=A078375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078375.Bytes);
public long this[int i]=>Value[i];

public static A078375Inst Instance=new A078375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078374
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,4L,4L,6L,7L,11L,10L,17L,17L,23L,26L,37L,36L,53L,53L,70L,77L,103L,103L,139L,147L,184L,199L,255L,260L,339L,358L,435L,474L,578L,611L,759L,810L,963L,1045L,1259L,1331L,1609L,1726L,2015L,2200L,2589L,2762L,3259L,3509L,4058L,4416L,5119L,5488L,6364L,6882L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078374Inst : IEnumerable<long>
{
public static readonly long[] Value=A078374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078374.Bytes);
public long this[int i]=>Value[i];

public static A078374Inst Instance=new A078374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078373
{
public static readonly long[] Value={ 2L,3L,7L,19L,27L,97L,171L,231L,487L,763L,1071L,4011L,6171L,10971L,17647L,47059L,99151L,117511L,202471L,260847L,481959L,963919L,1564063L,1805311L,1993215L,6991599L,8400511L,11200681L,36791535L,46564287L,103359483L,206718967L,359502063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078373Inst : IEnumerable<long>
{
public static readonly long[] Value=A078373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078373.Bytes);
public long this[int i]=>Value[i];

public static A078373Inst Instance=new A078373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078372
{
public static readonly long[] Value={ 1L,2L,5L,2L,3L,6L,11L,2L,12L,4L,9L,6L,5L,12L,11L,2L,7L,12L,13L,4L,3L,10L,9L,6L,14L,6L,74L,12L,11L,12L,71L,2L,15L,8L,7L,12L,13L,14L,23L,4L,73L,4L,17L,10L,8L,10L,69L,6L,14L,14L,15L,6L,5L,74L,73L,12L,19L,12L,21L,12L,11L,72L,72L,2L,15L,16L,17L,8L,7L,8L,67L,12L,75L,14L,6L,14L,13L,24L,23L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078372Inst : IEnumerable<long>
{
public static readonly long[] Value=A078372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078372.Bytes);
public long this[int i]=>Value[i];

public static A078372Inst Instance=new A078372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078211
{
public static readonly long[] Value={ 1L,212L,333L,464L,525L,6156L,7007L,8128L,9639L,0L,11011L,122112L,13013L,0L,0L,162816L,1720417L,0L,1905719L,0L,212121L,0L,2320723L,244224L,25625L,0L,2743227L,287728L,2917429L,0L,3143431L,325632L,3372633L,0L,0L,3617136L,373737L,0L,393939L,0L,4136941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078211Inst : IEnumerable<long>
{
public static readonly long[] Value=A078211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078211.Bytes);
public long this[int i]=>Value[i];

public static A078211Inst Instance=new A078211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078210
{
public static readonly long[] Value={ 1L,20L,36L,48L,50L,612L,735L,832L,972L,100L,11011L,1296L,1352L,14112L,1575L,16128L,1734L,18144L,19133L,2000L,21168L,22264L,23276L,24192L,2500L,26364L,27702L,28224L,29435L,30600L,31713L,32768L,33759L,3468L,35525L,36288L,370999L,38988L,39546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078210Inst : IEnumerable<long>
{
public static readonly long[] Value=A078210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078210.Bytes);
public long this[int i]=>Value[i];

public static A078210Inst Instance=new A078210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078209
{
public static readonly long[] Value={ 10L,21L,30L,42L,55L,65L,714L,817L,92L,1015L,1116L,1221L,1312L,1419L,1504L,1643L,177L,183L,1943L,2059L,219L,2212L,2324L,2403L,2522L,2626L,2781L,2889L,2943L,3051L,3175L,3275L,33017L,3475L,3576L,3624L,3768L,38142L,39078L,40136L,4117L,42173L,4393L,4439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078209Inst : IEnumerable<long>
{
public static readonly long[] Value=A078209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078209.Bytes);
public long this[int i]=>Value[i];

public static A078209Inst Instance=new A078209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078208
{
public static readonly long[] Value={ 2L,30L,51L,72L,110L,132L,175L,192L,234L,290L,319L,372L,416L,434L,4710L,5312L,595L,612L,6707L,7100L,735L,792L,8303L,8904L,975L,1014L,10314L,10724L,10904L,11310L,1271L,1312L,13728L,1394L,14910L,1512L,15725L,1634L,1677L,17320L,17917L,18102L,19135L,1936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078208Inst : IEnumerable<long>
{
public static readonly long[] Value=A078208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078208.Bytes);
public long this[int i]=>Value[i];

public static A078208Inst Instance=new A078208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078207
{
public static readonly BigInteger[] Value={ 1L,6L,384L,2856L,22727L,188679L,1612903L,14084506L,124999999L,112359549631L,1111234572418L,1019369022515831L,9409019496692991L,873646201597158837L,BigInteger.Parse("815363874644766139852"),BigInteger.Parse("76437144029054504848414"),BigInteger.Parse("719381682508917578872474"),BigInteger.Parse("679393593475575516018040602") };
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
public class A078207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078207Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078207.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A078207.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078207Inst Instance=new A078207Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078206
{
public static readonly BigInteger[] Value={ 1L,126L,123264L,12340776L,1234553367L,123456631959L,12345677303863L,1234567810050426L,123456789137345679L,BigInteger.Parse("1234567891008671105551"),BigInteger.Parse("1234567891011073225118178"),BigInteger.Parse("123456789101112073716778055751") };
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
public class A078206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078206Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078206.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A078206.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078206Inst Instance=new A078206Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078205
{
public static readonly BigInteger[] Value={ 1L,18L,261L,3502L,44003L,530004L,6200005L,71000006L,800000008L,8900000074L,8999000074522L,98099900812365L,10628099988011209L,11446281093786559142UL,BigInteger.Parse("122644629115519160114"),BigInteger.Parse("13082644736437172941406"),BigInteger.Parse("139008265613936288720365") };
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
public class A078205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078205Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078205.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A078205.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078205Inst Instance=new A078205Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078204
{
public static readonly BigInteger[] Value={ 1L,216L,32103L,4321468L,543217035L,65432173824L,7654321572835L,876543212074068L,98765432187654312L,BigInteger.Parse("109876543212580239340"),BigInteger.Parse("11109876543210457373921742"),BigInteger.Parse("12111098765432151566924849880") };
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
public class A078204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078204Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078204.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A078204.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078204Inst Instance=new A078204Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078203
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,14L,15L,24L,74L,191L,222L,276L,2200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078203Inst : IEnumerable<long>
{
public static readonly long[] Value=A078203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078203.Bytes);
public long this[int i]=>Value[i];

public static A078203Inst Instance=new A078203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078202
{
public static readonly BigInteger[] Value={ 2L,7L,2L,3L,7L,5L,79L,7L,431L,58049L,8375575711L,11L,13055867207L,13L,BigInteger.Parse("94233563770233419658037661865757455268745312881861761180195872329157714108064193"),-1L,130783L,17L,523927L,19L,BigInteger.Parse("2046526777460104549122039297254727662107009") };
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
public class A078202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078202Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078202.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A078202.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078202Inst Instance=new A078202Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078201
{
public static readonly BigInteger[] Value={ 2L,3L,17L,5L,59604644783353249L,7L,BigInteger.Parse("4318114567396436564035293097707729426477458833"),BigInteger.Parse("205688069665150755269371147819668813122841983204711281293004769"),593L,11L };
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
public class A078201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078201Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078201.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A078201.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078201Inst Instance=new A078201Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078200
{
public static readonly long[] Value={ 11L,10L,1L,1L,1L,1L,1L,1L,1L,1L,10L,1L,5L,4L,3L,2L,3L,2L,2L,2L,1L,5L,5L,1L,1L,1L,1L,1L,1L,1L,1L,4L,1L,4L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,3L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,3L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078200Inst : IEnumerable<long>
{
public static readonly long[] Value=A078200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078200.Bytes);
public long this[int i]=>Value[i];

public static A078200Inst Instance=new A078200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078199
{
public static readonly long[] Value={ 1100L,1010L,102L,103L,104L,105L,106L,107L,108L,109L,1100L,111L,560L,452L,342L,230L,348L,234L,236L,238L,120L,605L,610L,123L,124L,125L,126L,127L,128L,129L,130L,524L,132L,532L,134L,135L,136L,137L,138L,139L,140L,423L,142L,143L,432L,145L,146L,147L,148L,149L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078199Inst : IEnumerable<long>
{
public static readonly long[] Value=A078199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078199.Bytes);
public long this[int i]=>Value[i];

public static A078199Inst Instance=new A078199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078198
{
public static readonly long[] Value={ 1L,2L,4L,6L,11L,13L,18L,20L,22L,23L,26L,29L,31L,38L,45L,47L,50L,53L,72L,75L,78L,80L,87L,94L,99L,103L,107L,112L,119L,126L,131L,156L,175L,200L,205L,212L,219L,224L,228L,232L,237L,244L,256L,281L,293L,318L,330L,337L,342L,369L,374L,418L,455L,462L,499L,543L,548L,575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078198Inst : IEnumerable<long>
{
public static readonly long[] Value=A078198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078198.Bytes);
public long this[int i]=>Value[i];

public static A078198Inst Instance=new A078198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078197
{
public static readonly long[] Value={ 13L,2L,4L,17L,10L,11L,20L,1L,3L,12L,195L,200L,370L,27L,223L,201L,94L,88L,2L,108L,111L,87L,252L,16L,33L,92L,30L,62L,4L,131L,71L,189L,110L,142L,143L,17L,19L,270L,85L,106L,66L,124L,97L,134L,239L,10L,103L,25L,228L,34L,235L,93L,15L,18L,76L,301L,153L,38L,325L,11L,20L,242L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078197Inst : IEnumerable<long>
{
public static readonly long[] Value=A078197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078197.Bytes);
public long this[int i]=>Value[i];

public static A078197Inst Instance=new A078197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078196
{
public static readonly long[] Value={ 6L,9L,0L,1L,5L,2L,8L,9L,5L,6L,5L,9L,0L,8L,6L,5L,8L,3L,2L,0L,5L,7L,0L,5L,2L,4L,5L,3L,3L,4L,1L,0L,0L,8L,7L,6L,8L,1L,4L,3L,7L,7L,0L,7L,9L,0L,7L,0L,3L,9L,6L,3L,0L,9L,5L,3L,0L,7L,6L,8L,1L,3L,0L,0L,8L,8L,2L,2L,0L,0L,3L,3L,0L,4L,4L,3L,7L,8L,1L,6L,6L,7L,0L,8L,4L,4L,1L,1L,5L,3L,6L,2L,0L,8L,4L,5L,0L,5L,0L,7L,9L,9L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078196Inst : IEnumerable<long>
{
public static readonly long[] Value=A078196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078196.Bytes);
public long this[int i]=>Value[i];

public static A078196Inst Instance=new A078196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078179
{
public static readonly long[] Value={ 5L,11L,19L,29L,41L,349L,71L,89L,109L,131L,20747L,181L,2177953337809371149L,239L,271L,83537L,5849L,379L,419L,461L,2494357909L,279863L,599L,15649L,701L,19709L,811L,420707233300229L,929L,991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078179Inst : IEnumerable<long>
{
public static readonly long[] Value=A078179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078179.Bytes);
public long this[int i]=>Value[i];

public static A078179Inst Instance=new A078179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078178
{
public static readonly long[] Value={ 2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,4L,2L,16L,2L,2L,4L,3L,2L,2L,2L,7L,4L,2L,3L,2L,3L,2L,10L,2L,2L,108L,3L,6L,2L,3L,7L,2L,2L,4L,2L,16L,3L,2L,2L,2L,20L,2L,7L,2L,3L,3L,2L,2L,2L,2L,9L,4L,2L,2L,7L,8L,3L,2L,2L,2L,24L,2L,6L,2L,12L,4L,3L,8L,6L,2L,4L,3L,9L,194L,3L,13L,2L,8L,2L,2L,3L,8L,2L,10L,6L,4L,2L,2L,54L,2L,132L,4L,10L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078178Inst : IEnumerable<long>
{
public static readonly long[] Value=A078178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078178.Bytes);
public long this[int i]=>Value[i];

public static A078178Inst Instance=new A078178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078177
{
public static readonly long[] Value={ 4L,8L,9L,15L,16L,20L,21L,25L,27L,32L,33L,35L,39L,42L,44L,49L,50L,51L,55L,57L,60L,64L,65L,68L,69L,77L,78L,81L,85L,87L,91L,92L,93L,95L,105L,110L,111L,112L,114L,115L,116L,119L,121L,123L,125L,128L,129L,133L,140L,141L,143L,145L,155L,156L,159L,161L,164L,169L,170L,177L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078177Inst : IEnumerable<long>
{
public static readonly long[] Value=A078177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078177.Bytes);
public long this[int i]=>Value[i];

public static A078177Inst Instance=new A078177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078176
{
public static readonly long[] Value={ 7L,11L,15L,19L,23L,27L,63L,67L,71L,75L,79L,83L,87L,91L,127L,131L,135L,139L,143L,147L,151L,155L,191L,195L,455L,715L,975L,1235L,1495L,1755L,4095L,4099L,4103L,4107L,4111L,4115L,4119L,4123L,4159L,4163L,4167L,4171L,4175L,4179L,4183L,4187L,4223L,4227L,4231L,4235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078176Inst : IEnumerable<long>
{
public static readonly long[] Value=A078176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078176.Bytes);
public long this[int i]=>Value[i];

public static A078176Inst Instance=new A078176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078175
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,8L,9L,11L,13L,15L,16L,17L,19L,20L,21L,23L,25L,27L,29L,31L,32L,33L,35L,37L,39L,41L,42L,43L,44L,47L,49L,50L,51L,53L,55L,57L,59L,60L,61L,64L,65L,67L,68L,69L,71L,73L,77L,78L,79L,81L,83L,85L,87L,89L,91L,92L,93L,95L,97L,101L,103L,105L,107L,109L,110L,111L,112L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078175Inst : IEnumerable<long>
{
public static readonly long[] Value=A078175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078175.Bytes);
public long this[int i]=>Value[i];

public static A078175Inst Instance=new A078175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078174
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,8L,9L,11L,13L,15L,16L,17L,19L,21L,23L,25L,27L,29L,31L,32L,33L,35L,37L,39L,41L,42L,43L,45L,47L,49L,51L,53L,55L,57L,59L,61L,63L,64L,65L,67L,69L,71L,73L,75L,77L,78L,79L,81L,83L,84L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,105L,107L,109L,110L,111L,113L,114L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078174Inst : IEnumerable<long>
{
public static readonly long[] Value=A078174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078174.Bytes);
public long this[int i]=>Value[i];

public static A078174Inst Instance=new A078174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078173
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,3L,3L,4L,4L,4L,4L,6L,3L,5L,5L,6L,4L,6L,5L,6L,7L,4L,5L,6L,5L,7L,9L,7L,6L,6L,5L,8L,9L,6L,8L,8L,3L,8L,9L,10L,7L,7L,5L,10L,9L,7L,7L,12L,7L,10L,9L,9L,7L,10L,11L,12L,9L,6L,7L,10L,7L,8L,11L,12L,13L,11L,5L,11L,9L,10L,9L,12L,5L,8L,15L,10L,12L,12L,9L,12L,12L,7L,8L,14L,15L,11L,11L,12L,10L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078173Inst : IEnumerable<long>
{
public static readonly long[] Value=A078173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078173.Bytes);
public long this[int i]=>Value[i];

public static A078173Inst Instance=new A078173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078172
{
public static readonly long[] Value={ 3L,4L,8L,13L,22L,29L,40L,44L,56L,74L,84L,104L,113L,124L,133L,155L,177L,184L,207L,217L,232L,247L,266L,283L,316L,337L,342L,353L,360L,382L,434L,445L,475L,480L,522L,529L,561L,579L,589L,622L,639L,649L,692L,700L,725L,732L,787L,823L,851L,858L,871L,889L,915L,944L,982L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078172Inst : IEnumerable<long>
{
public static readonly long[] Value=A078172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078172.Bytes);
public long this[int i]=>Value[i];

public static A078172Inst Instance=new A078172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078171
{
public static readonly long[] Value={ 2L,2L,3L,4L,5L,6L,7L,7L,8L,9L,10L,11L,11L,12L,12L,13L,14L,14L,15L,15L,16L,16L,17L,17L,18L,19L,19L,19L,19L,20L,21L,21L,22L,22L,23L,23L,24L,24L,24L,25L,25L,25L,26L,26L,27L,27L,28L,28L,29L,29L,29L,29L,30L,30L,31L,31L,31L,31L,32L,32L,32L,33L,34L,34L,34L,34L,35L,35L,36L,36L,36L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078171Inst : IEnumerable<long>
{
public static readonly long[] Value=A078171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078171.Bytes);
public long this[int i]=>Value[i];

public static A078171Inst Instance=new A078171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078170
{
public static readonly long[] Value={ 1L,2L,1285L,2048L,2056L,2176L,2560L,2570L,2720L,3072L,3084L,3264L,3840L,4080L,1114129L,2097152L,2097184L,2105344L,2228224L,2228258L,2236928L,2621440L,2621480L,2631680L,2785280L,2796160L,3145728L,3145776L,3158016L,3342336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078170Inst : IEnumerable<long>
{
public static readonly long[] Value=A078170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078170.Bytes);
public long this[int i]=>Value[i];

public static A078170Inst Instance=new A078170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078169
{
public static readonly long[] Value={ 1L,2L,771L,1024L,1028L,1088L,1280L,1360L,1536L,1542L,1632L,1920L,2040L,327685L,524288L,524296L,526336L,557056L,559232L,655360L,655370L,657920L,696320L,699040L,786432L,786444L,789504L,835584L,838848L,983040L,986880L,1044480L,1048560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078169Inst : IEnumerable<long>
{
public static readonly long[] Value=A078169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078169.Bytes);
public long this[int i]=>Value[i];

public static A078169Inst Instance=new A078169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078168
{
public static readonly long[] Value={ 1L,2L,257L,512L,514L,544L,640L,680L,768L,816L,960L,1020L,65537L,131072L,131074L,131584L,139264L,139808L,163840L,164480L,174080L,174760L,196608L,197376L,208896L,209712L,245760L,246720L,261120L,262140L,1682227L,1683109L,1683559L,1683937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078168Inst : IEnumerable<long>
{
public static readonly long[] Value=A078168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078168.Bytes);
public long this[int i]=>Value[i];

public static A078168Inst Instance=new A078168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078167
{
public static readonly long[] Value={ 1L,2L,255L,256L,272L,320L,340L,384L,408L,480L,510L,21845L,32768L,32896L,34816L,34952L,40960L,41120L,43520L,43690L,49152L,49344L,52224L,52428L,61440L,61680L,65280L,280999L,281587L,282637L,282949L,283897L,294409L,297449L,300409L,302039L,304399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078167Inst : IEnumerable<long>
{
public static readonly long[] Value=A078167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078167.Bytes);
public long this[int i]=>Value[i];

public static A078167Inst Instance=new A078167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078166
{
public static readonly long[] Value={ 1L,2L,85L,128L,136L,160L,170L,192L,204L,240L,4369L,8192L,8224L,8704L,8738L,10240L,10280L,10880L,12288L,12336L,13056L,15360L,15420L,16320L,47197L,47239L,47989L,49267L,49589L,50557L,51319L,52429L,52649L,55699L,57589L,57953L,59495L,63973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078166Inst : IEnumerable<long>
{
public static readonly long[] Value=A078166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078166.Bytes);
public long this[int i]=>Value[i];

public static A078166Inst Instance=new A078166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078165
{
public static readonly long[] Value={ 1L,2L,51L,64L,68L,80L,96L,102L,120L,1285L,2048L,2056L,2176L,2560L,2570L,2720L,3072L,3084L,3264L,3840L,4080L,7957L,8227L,8279L,9079L,9139L,9709L,9919L,10355L,10595L,11667L,11673L,11691L,12099L,12393L,12483L,12753L,12987L,13797L,14715L,14763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078165Inst : IEnumerable<long>
{
public static readonly long[] Value=A078165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078165.Bytes);
public long this[int i]=>Value[i];

public static A078165Inst Instance=new A078165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078164
{
public static readonly long[] Value={ 1L,2L,17L,32L,34L,40L,48L,60L,257L,512L,514L,544L,640L,680L,768L,816L,960L,1020L,1297L,1387L,1417L,1729L,1971L,2109L,2223L,2289L,2331L,2445L,2457L,2565L,2594L,2608L,2774L,2812L,2834L,2835L,3052L,3260L,3458L,3888L,3912L,3924L,3942L,3996L,4104L,4212L,4218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078164Inst : IEnumerable<long>
{
public static readonly long[] Value=A078164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078164.Bytes);
public long this[int i]=>Value[i];

public static A078164Inst Instance=new A078164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078131
{
public static readonly long[] Value={ 8L,16L,24L,27L,32L,35L,40L,43L,48L,51L,54L,56L,59L,62L,64L,67L,70L,72L,75L,78L,80L,81L,83L,86L,88L,89L,91L,94L,96L,97L,99L,102L,104L,105L,107L,108L,110L,112L,113L,115L,116L,118L,120L,121L,123L,124L,125L,126L,128L,129L,131L,132L,133L,134L,135L,136L,137L,139L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078131Inst : IEnumerable<long>
{
public static readonly long[] Value=A078131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078131.Bytes);
public long this[int i]=>Value[i];

public static A078131Inst Instance=new A078131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078130
{
public static readonly long[] Value={ 8L,16L,24L,27L,32L,35L,40L,43L,48L,51L,54L,56L,59L,62L,67L,70L,75L,78L,81L,83L,86L,89L,94L,97L,102L,105L,108L,110L,113L,116L,121L,124L,125L,129L,132L,133L,135L,137L,140L,141L,143L,148L,149L,151L,156L,157L,159L,162L,164L,165L,167L,170L,173L,175L,178L,181L,183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078130Inst : IEnumerable<long>
{
public static readonly long[] Value=A078130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078130.Bytes);
public long this[int i]=>Value[i];

public static A078130Inst Instance=new A078130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078129
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,10L,11L,12L,13L,14L,15L,17L,18L,19L,20L,21L,22L,23L,25L,26L,28L,29L,30L,31L,33L,34L,36L,37L,38L,39L,41L,42L,44L,45L,46L,47L,49L,50L,52L,53L,55L,57L,58L,60L,61L,63L,65L,66L,68L,69L,71L,73L,74L,76L,77L,79L,82L,84L,85L,87L,90L,92L,93L,95L,98L,100L,101L,103L,106L,109L,111L,114L,117L,119L,122L,127L,130L,138L,146L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078129Inst : IEnumerable<long>
{
public static readonly long[] Value=A078129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078129.Bytes);
public long this[int i]=>Value[i];

public static A078129Inst Instance=new A078129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078128
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,0L,1L,0L,2L,1L,0L,1L,0L,0L,1L,0L,2L,1L,0L,2L,0L,0L,1L,0L,2L,1L,0L,2L,0L,0L,1L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078128Inst : IEnumerable<long>
{
public static readonly long[] Value=A078128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078128.Bytes);
public long this[int i]=>Value[i];

public static A078128Inst Instance=new A078128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078127
{
public static readonly long[] Value={ 1L,9L,2L,9L,0L,1L,3L,1L,6L,7L,9L,6L,9L,1L,2L,4L,2L,9L,3L,6L,3L,1L,8L,9L,7L,6L,4L,0L,2L,8L,0L,3L,2L,7L,8L,5L,2L,4L,5L,0L,9L,6L,8L,6L,7L,6L,2L,0L,0L,0L,7L,5L,2L,7L,1L,7L,1L,3L,4L,9L,2L,2L,7L,4L,4L,3L,6L,0L,5L,7L,0L,3L,5L,9L,2L,7L,7L,8L,7L,7L,0L,3L,9L,1L,4L,4L,3L,0L,5L,5L,1L,6L,3L,8L,7L,8L,4L,6L,0L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078127Inst : IEnumerable<long>
{
public static readonly long[] Value=A078127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078127.Bytes);
public long this[int i]=>Value[i];

public static A078127Inst Instance=new A078127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078126
{
public static readonly long[] Value={ -1L,-1L,0L,1L,3L,5L,8L,11L,15L,19L,24L,29L,35L,41L,48L,55L,63L,71L,80L,89L,99L,109L,120L,131L,143L,155L,168L,181L,195L,209L,224L,239L,255L,271L,288L,305L,323L,341L,360L,379L,399L,419L,440L,461L,483L,505L,528L,551L,575L,599L,624L,649L,675L,701L,728L,755L,783L,811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078126Inst : IEnumerable<long>
{
public static readonly long[] Value=A078126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078126.Bytes);
public long this[int i]=>Value[i];

public static A078126Inst Instance=new A078126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078125
{
public static readonly BigInteger[] Value={ 1L,2L,5L,23L,239L,5828L,342383L,50110484L,18757984046L,18318289003448L,47398244089264547L,BigInteger.Parse("329030840161393127681"),BigInteger.Parse("6190927493941741957366100"),BigInteger.Parse("318447442589056401640929570896"),BigInteger.Parse("45106654667152833836835578059359839") };
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
public class A078125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078125Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078125.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A078125.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078125Inst Instance=new A078125Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078124
{
public static readonly BigInteger[] Value={ 1L,3L,12L,93L,1632L,68457L,7112055L,1879090014L,1287814075131L,2325758241901161L,11213788533232011006UL,BigInteger.Parse("145939965725683888932081"),BigInteger.Parse("5174322925070232320838406581"),BigInteger.Parse("503750821963423009552527526376232") };
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
public class A078124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078124Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078124.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A078124.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078124Inst Instance=new A078124Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078123
{
public static readonly long[] Value={ 1L,2L,1L,5L,6L,1L,23L,51L,18L,1L,239L,861L,477L,54L,1L,5828L,32856L,25263L,4347L,162L,1L,342383L,3013980L,3016107L,699813L,39285L,486L,1L,50110484L,690729981L,865184724L,253656252L,19053063L,354051L,1458L,1L,18757984046L,406279238154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078123Inst : IEnumerable<long>
{
public static readonly long[] Value=A078123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078123.Bytes);
public long this[int i]=>Value[i];

public static A078123Inst Instance=new A078123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078122
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,12L,9L,1L,1L,93L,117L,27L,1L,1L,1632L,3033L,1080L,81L,1L,1L,68457L,177507L,86373L,9801L,243L,1L,1L,7112055L,24975171L,15562314L,2371761L,88452L,729L,1L,1L,1879090014L,8786827629L,6734916423L,1291958181L,64392813L,796797L,2187L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078122Inst : IEnumerable<long>
{
public static readonly long[] Value=A078122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078122.Bytes);
public long this[int i]=>Value[i];

public static A078122Inst Instance=new A078122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078121
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,4L,1L,1L,10L,16L,8L,1L,1L,36L,84L,64L,16L,1L,1L,202L,656L,680L,256L,32L,1L,1L,1828L,8148L,10816L,5456L,1024L,64L,1L,1L,27338L,167568L,274856L,174336L,43680L,4096L,128L,1L,1L,692004L,5866452L,11622976L,8909648L,2794496L,349504L,16384L,256L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078121Inst : IEnumerable<long>
{
public static readonly long[] Value=A078121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078121.Bytes);
public long this[int i]=>Value[i];

public static A078121Inst Instance=new A078121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078120
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,2L,3L,2L,3L,2L,3L,3L,3L,3L,3L,3L,4L,2L,3L,3L,3L,3L,4L,4L,3L,3L,4L,4L,3L,3L,4L,4L,3L,3L,4L,3L,3L,4L,4L,3L,3L,4L,4L,5L,4L,4L,4L,3L,3L,4L,4L,3L,2L,4L,4L,4L,4L,3L,4L,3L,4L,4L,5L,4L,4L,4L,3L,4L,3L,4L,4L,5L,4L,4L,4L,4L,4L,4L,5L,3L,4L,5L,4L,5L,5L,4L,5L,4L,4L,4L,5L,4L,4L,5L,4L,4L,3L,5L,5L,4L,4L,5L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078120Inst : IEnumerable<long>
{
public static readonly long[] Value=A078120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078120.Bytes);
public long this[int i]=>Value[i];

public static A078120Inst Instance=new A078120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078119
{
public static readonly long[] Value={ -1L,1L,0L,5L,0L,8L,2L,11L,3L,14L,0L,22L,6L,16L,8L,25L,0L,31L,8L,32L,10L,28L,4L,48L,13L,30L,12L,48L,0L,56L,12L,47L,24L,42L,12L,73L,14L,44L,16L,78L,0L,76L,20L,62L,32L,56L,6L,104L,25L,69L,20L,80L,14L,96L,36L,92L,22L,74L,0L,138L,26L,64L,56L,107L,18L,112L,24L,102L,26L,120L,0L,159L,34L,78L,64L,116L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078119Inst : IEnumerable<long>
{
public static readonly long[] Value=A078119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078119.Bytes);
public long this[int i]=>Value[i];

public static A078119Inst Instance=new A078119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078118
{
public static readonly long[] Value={ 1L,6L,22L,25L,28L,30L,40L,42L,46L,52L,58L,60L,68L,70L,72L,78L,87L,88L,96L,98L,102L,105L,106L,112L,114L,122L,126L,128L,130L,133L,138L,145L,148L,150L,156L,162L,166L,172L,178L,182L,190L,192L,196L,198L,212L,213L,217L,218L,222L,225L,226L,228L,232L,238L,240L,250L,262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078118Inst : IEnumerable<long>
{
public static readonly long[] Value=A078118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078118.Bytes);
public long this[int i]=>Value[i];

public static A078118Inst Instance=new A078118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078117
{
public static readonly long[] Value={ 8L,11L,15L,17L,15L,11L,12L,14L,12L,14L,9L,14L,12L,17L,21L,23L,21L,16L,18L,20L,18L,20L,15L,20L,18L,23L,27L,29L,27L,22L,24L,26L,24L,26L,21L,26L,24L,29L,33L,35L,33L,28L,30L,32L,30L,32L,27L,32L,30L,35L,39L,41L,39L,34L,36L,38L,36L,38L,33L,38L,36L,41L,45L,47L,45L,40L,42L,44L,39L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078117Inst : IEnumerable<long>
{
public static readonly long[] Value=A078117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078117.Bytes);
public long this[int i]=>Value[i];

public static A078117Inst Instance=new A078117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078116
{
public static readonly long[] Value={ 3L,11L,17L,43L,67L,83L,89L,113L,131L,179L,139L,193L,283L,241L,331L,457L,227L,233L,257L,353L,467L,563L,617L,307L,577L,739L,379L,433L,523L,811L,1009L,443L,449L,491L,569L,641L,683L,953L,1019L,1163L,547L,601L,691L,643L,787L,1777L,761L,827L,857L,929L,971L,1307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078116Inst : IEnumerable<long>
{
public static readonly long[] Value=A078116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078116.Bytes);
public long this[int i]=>Value[i];

public static A078116Inst Instance=new A078116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078099
{
public static readonly long[] Value={ 1L,2L,2L,4L,6L,4L,8L,18L,18L,8L,16L,54L,82L,54L,16L,32L,162L,374L,374L,162L,32L,64L,486L,1706L,2604L,1706L,486L,64L,128L,1458L,7782L,18150L,18150L,7782L,1458L,128L,256L,4374L,35498L,126534L,193662L,126534L,35498L,4374L,256L,512L,13122L,161926L,882180L,2068146L,2068146L,882180L,161926L,13122L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078099Inst : IEnumerable<long>
{
public static readonly long[] Value=A078099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078099.Bytes);
public long this[int i]=>Value[i];

public static A078099Inst Instance=new A078099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078098
{
public static readonly long[] Value={ 3L,7L,11L,13L,21L,29L,39L,39L,49L,69L,67L,69L,69L,79L,83L,87L,81L,101L,111L,115L,133L,141L,139L,151L,187L,157L,191L,187L,199L,213L,223L,211L,221L,241L,255L,275L,309L,293L,287L,279L,295L,293L,303L,283L,325L,345L,357L,367L,403L,393L,419L,419L,477L,457L,519L,487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078098Inst : IEnumerable<long>
{
public static readonly long[] Value=A078098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078098.Bytes);
public long this[int i]=>Value[i];

public static A078098Inst Instance=new A078098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078097
{
public static readonly long[] Value={ 1L,5L,5L,5L,5L,17L,9L,65L,93L,129L,627L,111L,407L,795L,377L,1509L,257L,5207L,1233L,8537L,3917L,20253L,4613L,15435L,5619L,43823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078097Inst : IEnumerable<long>
{
public static readonly long[] Value=A078097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078097.Bytes);
public long this[int i]=>Value[i];

public static A078097Inst Instance=new A078097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078096
{
public static readonly long[] Value={ 1L,1L,3L,19L,1L,7L,1L,105L,37L,163L,73L,43L,45L,649L,3753L,5323L,423L,3123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078096Inst : IEnumerable<long>
{
public static readonly long[] Value=A078096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078096.Bytes);
public long this[int i]=>Value[i];

public static A078096Inst Instance=new A078096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078095
{
public static readonly long[] Value={ 1440L,2560L,2880L,3456L,3584L,5760L,6720L,7168L,8192L,8448L,9600L,10080L,10368L,10800L,12150L,12480L,13440L,14000L,15120L,18144L,21120L,21384L,22400L,25088L,25920L,26880L,28320L,30240L,31104L,31680L,34992L,35840L,38400L,39168L,39366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078095Inst : IEnumerable<long>
{
public static readonly long[] Value=A078095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078095.Bytes);
public long this[int i]=>Value[i];

public static A078095Inst Instance=new A078095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078094
{
public static readonly long[] Value={ 4608L,5440L,6144L,6336L,6480L,7680L,8064L,8640L,8704L,9216L,9984L,10752L,11664L,13440L,14400L,15680L,17280L,19200L,20480L,20736L,21120L,23808L,24192L,26208L,27360L,27840L,28512L,31104L,31360L,32000L,32320L,32400L,32832L,34560L,34992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078094Inst : IEnumerable<long>
{
public static readonly long[] Value=A078094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078094.Bytes);
public long this[int i]=>Value[i];

public static A078094Inst Instance=new A078094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078093
{
public static readonly long[] Value={ 64L,176L,216L,280L,288L,320L,336L,352L,384L,400L,416L,432L,480L,500L,560L,616L,704L,720L,756L,784L,800L,840L,936L,960L,1024L,1040L,1056L,1080L,1120L,1184L,1216L,1260L,1360L,1380L,1400L,1440L,1458L,1512L,1656L,1776L,1820L,1836L,1856L,1904L,1944L,1980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078093Inst : IEnumerable<long>
{
public static readonly long[] Value=A078093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078093.Bytes);
public long this[int i]=>Value[i];

public static A078093Inst Instance=new A078093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078092
{
public static readonly long[] Value={ 4L,32L,64L,96L,144L,180L,216L,224L,240L,360L,400L,432L,576L,600L,648L,672L,800L,972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078092Inst : IEnumerable<long>
{
public static readonly long[] Value=A078092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078092.Bytes);
public long this[int i]=>Value[i];

public static A078092Inst Instance=new A078092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078091
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,13L,1L,2L,2L,3L,1L,1L,6L,1L,4L,1L,10L,1L,5L,1L,13L,1L,12L,384L,1L,2L,1L,14L,1L,11L,1L,2L,33L,1L,4L,1L,8L,1L,1L,1L,1L,2L,2L,1L,1L,11L,1L,1L,1L,8L,7L,1L,1L,5L,6L,7L,1L,1L,2L,3L,1L,8L,1L,1L,1L,2L,1L,1L,1L,7L,1L,2L,1L,2L,1L,15L,1L,2L,2L,15L,1L,2L,2L,1L,1L,8L,3L,2L,1L,1L,3L,13L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078091Inst : IEnumerable<long>
{
public static readonly long[] Value=A078091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078091.Bytes);
public long this[int i]=>Value[i];

public static A078091Inst Instance=new A078091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078090
{
public static readonly long[] Value={ 0L,1L,2L,1L,1L,1L,1L,1L,1L,1L,4L,4L,1L,1L,1L,1L,1L,1L,1L,8L,2L,1L,1L,3L,178L,2L,3L,1L,4L,3L,5L,1L,3L,1L,1L,6L,73L,1L,3L,1L,1L,10L,4L,55L,1L,2L,1L,1L,9L,1L,8L,1L,116L,2L,1L,1L,1L,1L,2L,1L,8L,2L,38L,1L,11L,2L,10L,1L,1L,1L,1L,1L,2L,12L,1L,1L,11L,1L,3L,1L,4L,1L,3L,1L,1L,4L,3L,8L,5L,3L,3L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078090Inst : IEnumerable<long>
{
public static readonly long[] Value=A078090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078090.Bytes);
public long this[int i]=>Value[i];

public static A078090Inst Instance=new A078090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078089
{
public static readonly long[] Value={ 0L,1L,2L,1L,1L,16L,1L,2L,5L,4L,1L,43L,9L,1L,3L,1L,4L,2L,2L,1L,2L,1L,78L,1L,50L,3L,1L,1L,1L,2L,2L,6L,11L,4L,1L,1L,2L,1L,2L,2L,1L,4L,2L,6L,8L,1L,2L,1L,1L,1L,1L,1L,3L,4L,1L,1L,1L,7L,1L,1L,154L,1L,1L,1L,1L,3L,1L,12L,1L,1L,1L,3L,1L,1L,5L,1L,2L,1L,3L,4L,1L,3L,1L,1L,1L,4L,2L,2L,10L,8L,3L,9L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078089Inst : IEnumerable<long>
{
public static readonly long[] Value=A078089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078089.Bytes);
public long this[int i]=>Value[i];

public static A078089Inst Instance=new A078089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078088
{
public static readonly long[] Value={ 0L,1L,2L,1L,9L,1L,1L,1L,1L,1L,1L,3L,3L,3L,1L,1L,5L,1L,11L,1L,2L,1L,10L,1L,68L,2L,1L,15L,11L,1L,5L,3L,2L,1L,2L,82L,2L,7L,2L,1L,3L,6L,1L,1L,2L,5L,43L,9L,3L,6L,2L,1L,1L,2L,8L,1L,1L,3L,1L,1L,4L,1L,1L,1L,5L,6L,2L,1L,9L,13L,1L,2L,14L,2L,7L,1L,1L,1L,3L,1L,5L,169L,1L,2L,1L,2L,7L,43L,2L,3L,1L,1L,7L,1L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078088Inst : IEnumerable<long>
{
public static readonly long[] Value=A078088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078088.Bytes);
public long this[int i]=>Value[i];

public static A078088Inst Instance=new A078088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078087
{
public static readonly long[] Value={ 0L,1L,7L,2L,3L,1L,1L,1L,7L,1L,1L,6L,1L,5L,1L,1L,3L,2L,1L,1L,3L,2L,1L,1L,1L,1L,13L,1L,16L,1L,1L,16L,1L,80L,1L,1L,1L,1L,7L,5L,1L,4L,1L,33L,3L,8L,1L,8L,1L,16L,11L,1L,2L,6L,1L,19L,1L,12L,5L,11L,1L,7L,5L,1L,1L,1L,2L,5L,1L,4L,1L,3L,4L,4L,4L,1L,11L,1L,2L,5L,4L,12L,3L,1L,4L,1L,3L,1L,168L,1L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078087Inst : IEnumerable<long>
{
public static readonly long[] Value=A078087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078087.Bytes);
public long this[int i]=>Value[i];

public static A078087Inst Instance=new A078087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078086
{
public static readonly long[] Value={ 0L,1L,9L,5L,10L,1L,6L,1L,1L,1L,11L,1L,5L,1L,10L,1L,17L,5L,5L,6L,1L,13L,6L,3L,1L,1L,4L,1L,1L,2L,1L,3L,3L,1L,5L,7L,1L,17L,5L,2L,1L,10L,2L,2L,1L,14L,62L,3L,3L,4L,1L,1L,4L,8L,1041L,86L,1L,6L,1L,2L,6L,12L,1L,45L,2L,45L,2L,3L,2L,1L,1L,2L,2L,1L,4L,1L,1L,21L,5L,6L,4L,1L,1L,4L,1L,2L,2L,3L,2L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078086Inst : IEnumerable<long>
{
public static readonly long[] Value=A078086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078086.Bytes);
public long this[int i]=>Value[i];

public static A078086Inst Instance=new A078086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078085
{
public static readonly long[] Value={ 0L,1L,18L,7L,1L,1L,5L,1L,3L,6L,1L,2L,1L,1L,1L,38L,1L,3L,1L,1L,1L,1L,7L,2L,2L,2L,1L,24L,8L,8L,1L,3L,1L,1L,2L,35L,2L,1L,4L,1L,15L,2L,3L,6L,64L,3L,2L,2L,1L,2L,1L,30L,2L,1L,1L,8L,1L,2L,2L,1L,4L,24L,3L,7L,2L,1L,2L,5L,2L,2L,4L,9L,2L,1L,1L,1L,3L,1L,4L,5L,1L,993L,1L,1L,2L,2L,3L,1L,1L,1L,1L,3L,14L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078085Inst : IEnumerable<long>
{
public static readonly long[] Value=A078085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078085.Bytes);
public long this[int i]=>Value[i];

public static A078085Inst Instance=new A078085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078084
{
public static readonly long[] Value={ 0L,1L,40L,2L,1L,3L,211L,1L,4L,14L,3L,1L,2L,1L,2L,1L,1L,3L,1L,1L,2L,1L,12L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,3L,33L,1L,1L,4L,1L,3L,20L,2L,1L,3L,3L,7L,1L,2L,1L,1L,7296L,3L,1L,1L,2L,3L,2L,1L,2L,5L,1L,2L,1L,1L,1L,1L,2L,1L,2L,7L,1L,1L,11L,2L,1L,1L,252L,1L,1L,88L,2L,2L,1L,70L,1L,1L,4L,1L,3L,1L,1L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078084Inst : IEnumerable<long>
{
public static readonly long[] Value=A078084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078084.Bytes);
public long this[int i]=>Value[i];

public static A078084Inst Instance=new A078084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077923
{
public static readonly long[] Value={ 1L,-1L,4L,-10L,27L,-71L,190L,-504L,1341L,-3565L,9480L,-25206L,67023L,-178211L,473858L,-1259972L,3350225L,-8908137L,23686444L,-62981474L,167465667L,-445285695L,1184000006L,-3148217040L,8371005477L,-22258228005L,59183895568L,-157368030094L,418436411767L,-1112608644763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077923Inst : IEnumerable<long>
{
public static readonly long[] Value=A077923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077923.Bytes);
public long this[int i]=>Value[i];

public static A077923Inst Instance=new A077923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077922
{
public static readonly long[] Value={ 1L,-1L,4L,-9L,24L,-60L,154L,-391L,997L,-2538L,6465L,-16464L,41932L,-106792L,271981L,-692685L,1764144L,-4492953L,11442736L,-29142568L,74220826L,-189026955L,481417305L,-1226082390L,3122609041L,-7952717776L,20254126984L,-51583580784L,131374006329L,-334585720425L,852129027964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077922Inst : IEnumerable<long>
{
public static readonly long[] Value=A077922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077922.Bytes);
public long this[int i]=>Value[i];

public static A077922Inst Instance=new A077922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077921
{
public static readonly long[] Value={ 1L,-1L,4L,-8L,21L,-49L,120L,-288L,697L,-1681L,4060L,-9800L,23661L,-57121L,137904L,-332928L,803761L,-1940449L,4684660L,-11309768L,27304197L,-65918161L,159140520L,-384199200L,927538921L,-2239277041L,5406093004L,-13051463048L,31509019101L,-76069501249L,183648021600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077921Inst : IEnumerable<long>
{
public static readonly long[] Value=A077921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077921.Bytes);
public long this[int i]=>Value[i];

public static A077921Inst Instance=new A077921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077920
{
public static readonly long[] Value={ 1L,-1L,4L,-7L,18L,-38L,88L,-195L,441L,-988L,2223L,-4992L,11220L,-25208L,56645L,-127277L,285992L,-642615L,1443946L,-3244514L,7290360L,-16381287L,36808421L,-82707768L,185842671L,-417584688L,938304280L,-2108350576L,4737420745L,-10644887785L,23918845740L,-53745158519L,120764274994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077920Inst : IEnumerable<long>
{
public static readonly long[] Value=A077920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077920.Bytes);
public long this[int i]=>Value[i];

public static A077920Inst Instance=new A077920Inst();

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