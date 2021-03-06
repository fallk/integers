using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A247282
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,1L,3L,5L,1L,1L,1L,3L,3L,3L,5L,15L,1L,1L,1L,3L,1L,1L,3L,5L,3L,3L,3L,9L,5L,5L,15L,17L,1L,1L,1L,3L,1L,1L,3L,5L,1L,1L,1L,3L,3L,3L,5L,15L,3L,3L,3L,9L,3L,3L,9L,15L,5L,5L,5L,15L,15L,15L,17L,51L,1L,1L,1L,3L,1L,1L,3L,5L,1L,1L,1L,3L,3L,3L,5L,15L,1L,1L,1L,3L,1L,1L,3L,5L,3L,3L,3L,9L,5L,5L,15L,17L,3L,3L,3L,9L,3L,3L,9L,15L,3L,3L,3L,9L,9L,9L,15L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247282Inst : IEnumerable<long>
{
public static readonly long[] Value=A247282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247282.Bytes);
public long this[int i]=>Value[i];

public static A247282Inst Instance=new A247282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247283
{
public static readonly long[] Value={ 5L,7L,9L,15L,18L,27L,36L,54L,72L,108L,144L,216L,288L,432L,576L,864L,1152L,1728L,2304L,3456L,4608L,6912L,9216L,13824L,18432L,27648L,36864L,55296L,73728L,110592L,147456L,221184L,294912L,442368L,589824L,884736L,1179648L,1769472L,2359296L,3538944L,4718592L,7077888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247283Inst : IEnumerable<long>
{
public static readonly long[] Value=A247283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247283.Bytes);
public long this[int i]=>Value[i];

public static A247283Inst Instance=new A247283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247284
{
public static readonly long[] Value={ 4L,6L,13L,18L,38L,63L,113L,188L,338L,563L,1013L,1688L,3038L,5063L,9113L,15188L,27338L,45563L,82013L,136688L,246038L,410063L,738113L,1230188L,2214338L,3690563L,6643013L,11071688L,19929038L,33215063L,59787113L,99645188L,179361338L,298935563L,538084013L,896806688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247284Inst : IEnumerable<long>
{
public static readonly long[] Value=A247284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247284.Bytes);
public long this[int i]=>Value[i];

public static A247284Inst Instance=new A247284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247285
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,5L,7L,1L,1L,7L,19L,14L,1L,1L,9L,36L,59L,26L,1L,1L,11L,58L,150L,162L,46L,1L,1L,13L,85L,300L,543L,408L,79L,1L,1L,15L,117L,523L,1335L,1771L,966L,133L,1L,1L,17L,154L,833L,2747L,5303L,5335L,2184L,221L,1L,1L,19L,196L,1244L,5031L,12792L,19272L,15099L,4767L,364L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247285Inst : IEnumerable<long>
{
public static readonly long[] Value=A247285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247285.Bytes);
public long this[int i]=>Value[i];

public static A247285Inst Instance=new A247285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247286
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,4L,3L,1L,1L,8L,7L,4L,1L,1L,16L,17L,11L,5L,1L,1L,32L,41L,30L,16L,6L,1L,1L,64L,98L,82L,48L,22L,7L,1L,1L,128L,232L,220L,144L,72L,29L,8L,1L,1L,256L,544L,581L,423L,233L,103L,37L,9L,1L,1L,512L,1264L,1512L,1216L,738L,356L,142L,46L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247286Inst : IEnumerable<long>
{
public static readonly long[] Value=A247286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247286.Bytes);
public long this[int i]=>Value[i];

public static A247286Inst Instance=new A247286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247287
{
public static readonly long[] Value={ 0L,0L,1L,4L,13L,38L,108L,304L,857L,2426L,6902L,19728L,56622L,163092L,471205L,1365008L,3963321L,11530786L,33607190L,98105616L,286795300L,839470664L,2460038427L,7216652488L,21190820678L,62279238828L,183185851903L,539220930004L,1588341106957L,4681678922366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247287Inst : IEnumerable<long>
{
public static readonly long[] Value=A247287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247287.Bytes);
public long this[int i]=>Value[i];

public static A247287Inst Instance=new A247287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247288
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,0L,1L,1L,0L,2L,1L,1L,0L,4L,2L,1L,1L,0L,8L,4L,3L,1L,1L,0L,16L,8L,7L,4L,1L,1L,0L,32L,16L,17L,10L,5L,1L,1L,0L,64L,32L,41L,26L,14L,6L,1L,1L,0L,128L,64L,98L,66L,39L,19L,7L,1L,1L,0L,256L,128L,232L,164L,107L,56L,25L,8L,1L,1L,0L,512L,256L,544L,400L,286L,164L,78L,32L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247288Inst : IEnumerable<long>
{
public static readonly long[] Value=A247288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247288.Bytes);
public long this[int i]=>Value[i];

public static A247288Inst Instance=new A247288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247289
{
public static readonly long[] Value={ 0L,0L,0L,2L,7L,18L,45L,110L,267L,652L,1602L,3960L,9845L,24594L,61689L,155270L,391962L,991968L,2515964L,6393610L,16275174L,41491776L,105922244L,270734244L,692756227L,1774418286L,4549173861L,11672860634L,29975156134L,77029918152L,198083586300L,509692521982L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247289Inst : IEnumerable<long>
{
public static readonly long[] Value=A247289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247289.Bytes);
public long this[int i]=>Value[i];

public static A247289Inst Instance=new A247289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247290
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,1L,15L,2L,32L,5L,69L,13L,154L,30L,1L,346L,74L,3L,786L,183L,9L,1806L,449L,28L,4180L,1114L,78L,1L,9745L,2767L,219L,4L,22865L,6882L,611L,14L,53938L,17170L,1674L,50L,127865L,42906L,4569L,161L,1L,304447L,107392L,12398L,506L,5L,727733L,269237L,33450L,1564L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247290Inst : IEnumerable<long>
{
public static readonly long[] Value=A247290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247290.Bytes);
public long this[int i]=>Value[i];

public static A247290Inst Instance=new A247290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247291
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,15L,32L,69L,154L,346L,786L,1806L,4180L,9745L,22865L,53938L,127865L,304447L,727733L,1745736L,4201350L,10140975L,24544000L,59551327L,144822097L,352940719L,861839226L,2108381480L,5166749329L,12681855551L,31174671514L,76742344774L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247291Inst : IEnumerable<long>
{
public static readonly long[] Value=A247291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247291.Bytes);
public long this[int i]=>Value[i];

public static A247291Inst Instance=new A247291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247292
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,16L,1L,35L,2L,77L,5L,172L,13L,391L,32L,899L,78L,1L,2085L,195L,3L,4877L,487L,9L,11490L,1217L,28L,27236L,3055L,81L,64916L,7687L,228L,1L,155483L,19374L,641L,4L,374027L,48925L,1782L,14L,903286L,123760L,4908L,50L,2189219L,313512L,13451L,165L,5322965L,795263L,36690L,522L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247292Inst : IEnumerable<long>
{
public static readonly long[] Value=A247292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247292.Bytes);
public long this[int i]=>Value[i];

public static A247292Inst Instance=new A247292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247293
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,16L,35L,77L,172L,391L,899L,2085L,4877L,11490L,27236L,64916L,155483L,374027L,903286L,2189219L,5322965L,12980660L,31740404L,77804885L,191160040L,470662449L,1161123461L,2869754099L,7104856781L,17618234456L,43754467510L,108816781175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247293Inst : IEnumerable<long>
{
public static readonly long[] Value=A247293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247293.Bytes);
public long this[int i]=>Value[i];

public static A247293Inst Instance=new A247293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247294
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,1L,14L,3L,30L,7L,64L,18L,141L,43L,1L,316L,102L,5L,713L,249L,16L,1626L,608L,49L,3740L,1489L,143L,1L,8659L,3669L,400L,7L,20176L,9058L,1109L,29L,47274L,22407L,3046L,105L,111302L,55560L,8282L,357L,1L,263201L,138004L,22385L,1149L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247294Inst : IEnumerable<long>
{
public static readonly long[] Value=A247294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247294.Bytes);
public long this[int i]=>Value[i];

public static A247294Inst Instance=new A247294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247295
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,14L,30L,64L,141L,316L,713L,1626L,3740L,8659L,20176L,47274L,111302L,263201L,624860L,1488736L,3558412L,8530533L,20505468L,49413242L,119347708L,288873639L,700582008L,1702190653L,4142880297L,10099352082L,24656876772L,60283224645L,147581756005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247295Inst : IEnumerable<long>
{
public static readonly long[] Value=A247295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247295.Bytes);
public long this[int i]=>Value[i];

public static A247295Inst Instance=new A247295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247296
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,3L,7L,18L,45L,112L,281L,706L,1778L,4490L,11363L,28814L,73199L,186257L,474635L,1211122L,3094171L,7913765L,20261142L,51921920L,133171656L,341836748L,878104607L,2257208148L,5805964495L,14942942127L,38480449261L,99145105834L,255573465001L,659114680270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247296Inst : IEnumerable<long>
{
public static readonly long[] Value=A247296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247296.Bytes);
public long this[int i]=>Value[i];

public static A247296Inst Instance=new A247296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247297
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,17L,36L,1L,80L,2L,180L,5L,410L,13L,946L,32L,2203L,80L,5173L,199L,1L,12233L,499L,3L,29108L,1255L,9L,69643L,3161L,28L,167437L,7984L,81L,404311L,20206L,231L,980125L,51228L,650L,1L,2384441L,130090L,1812L,4L,5819576L,330835L,5016L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247297Inst : IEnumerable<long>
{
public static readonly long[] Value=A247297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247297.Bytes);
public long this[int i]=>Value[i];

public static A247297Inst Instance=new A247297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247298
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,17L,36L,80L,180L,410L,946L,2203L,5173L,12233L,29108L,69643L,167437L,404311L,980125L,2384441L,5819576L,14245384L,34964611L,86032272L,212172668L,524371704L,1298509438L,3221425567L,8005623916L,19926840746L,49674610998L,124006308008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247298Inst : IEnumerable<long>
{
public static readonly long[] Value=A247298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247298.Bytes);
public long this[int i]=>Value[i];

public static A247298Inst Instance=new A247298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247299
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,0L,2L,1L,1L,2L,1L,3L,1L,2L,4L,3L,3L,4L,1L,5L,6L,9L,5L,6L,5L,1L,10L,15L,15L,16L,9L,10L,6L,1L,22L,33L,33L,32L,26L,16L,15L,7L,1L,50L,71L,78L,66L,60L,41L,27L,21L,8L,1L,113L,163L,171L,158L,125L,103L,64L,43L,28L,9L,1L,260L,374L,391L,360L,295L,225L,167L,99L,65L,36L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247299Inst : IEnumerable<long>
{
public static readonly long[] Value=A247299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247299.Bytes);
public long this[int i]=>Value[i];

public static A247299Inst Instance=new A247299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247300
{
public static readonly long[] Value={ 0L,1L,3L,7L,17L,40L,94L,222L,526L,1252L,2994L,7191L,17343L,41989L,102023L,248712L,608168L,1491349L,3666685L,9037003L,22323243L,55259206L,137058248L,340567477L,847711177L,2113455657L,5277115687L,13195311961L,33038994039L,82829585094L,207905352180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247300Inst : IEnumerable<long>
{
public static readonly long[] Value=A247300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247300.Bytes);
public long this[int i]=>Value[i];

public static A247300Inst Instance=new A247300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247301
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,2L,2L,2L,4L,3L,4L,6L,6L,6L,12L,10L,12L,20L,18L,20L,36L,32L,36L,64L,56L,64L,112L,100L,112L,200L,176L,200L,352L,312L,352L,624L,552L,624L,1104L,976L,1104L,1952L,1728L,1952L,3456L,3056L,3456L,6112L,5408L,6112L,10816L,9568L,10816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247301Inst : IEnumerable<long>
{
public static readonly long[] Value=A247301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247301.Bytes);
public long this[int i]=>Value[i];

public static A247301Inst Instance=new A247301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247302
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,1L,0L,2L,1L,2L,2L,2L,2L,4L,4L,4L,8L,6L,8L,12L,12L,12L,24L,20L,24L,40L,36L,40L,72L,64L,72L,128L,112L,128L,224L,200L,224L,400L,352L,400L,704L,624L,704L,1248L,1104L,1248L,2208L,1952L,2208L,3904L,3456L,3904L,6912L,6112L,6912L,12224L,10816L,12224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247302Inst : IEnumerable<long>
{
public static readonly long[] Value=A247302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247302.Bytes);
public long this[int i]=>Value[i];

public static A247302Inst Instance=new A247302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247303
{
public static readonly long[] Value={ 1L,0L,0L,2L,0L,2L,3L,0L,2L,4L,3L,2L,5L,2L,2L,8L,2L,4L,7L,2L,7L,6L,4L,8L,7L,4L,6L,10L,4L,10L,11L,0L,10L,12L,7L,10L,11L,6L,8L,16L,9L,8L,12L,10L,10L,14L,13L,8L,15L,12L,10L,18L,10L,14L,17L,8L,14L,20L,15L,10L,21L,10L,10L,32L,10L,12L,23L,10L,19L,22L,16L,16L,21L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247303Inst : IEnumerable<long>
{
public static readonly long[] Value=A247303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247303.Bytes);
public long this[int i]=>Value[i];

public static A247303Inst Instance=new A247303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247304
{
public static readonly BigInteger[] Value={ 1L,3L,15L,105L,945L,10263L,127699L,1751685L,25807445L,401449271L,6519160851L,109656966853L,1899821492925L,33757439931675L,613135175204151L,11352879180474205L,213825919244349885L,4089023317563827335L,BigInteger.Parse("79269914519539177315"),BigInteger.Parse("1555788699527063688453") };
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
public class A247304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247304Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A247304.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A247304.Bytes);
public BigInteger this[int i]=>Value[i];

public static A247304Inst Instance=new A247304Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247305
{
public static readonly long[] Value={ 404550L,2653056L,3643650L,5633046L,6413571L,10122750L,10656036L,13762881L,19841850L,26634051L,32800950L,47848653L,56769840L,71634465L,89184690L,103672800L,137108520L,317053971L,345069585L,392714325L,408508236L,440762895L,508948560L,598735710L,718830486L,825215625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247305Inst : IEnumerable<long>
{
public static readonly long[] Value=A247305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247305.Bytes);
public long this[int i]=>Value[i];

public static A247305Inst Instance=new A247305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247306
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,3L,10L,1L,1L,3L,15L,35L,1L,1L,3L,15L,91L,126L,1L,1L,3L,15L,105L,603L,462L,1L,1L,3L,15L,105L,903L,4213L,1716L,1L,1L,3L,15L,105L,945L,8778L,30537L,6435L,1L,1L,3L,15L,105L,945L,10263L,92235L,227475L,24310L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247306Inst : IEnumerable<long>
{
public static readonly long[] Value=A247306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247306.Bytes);
public long this[int i]=>Value[i];

public static A247306Inst Instance=new A247306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247307
{
public static readonly BigInteger[] Value={ 0L,6L,20L,63L,204L,682L,2340L,381300L,1398101L,5162220L,71582788L,1010580540L,14467258260L,3059510616420L,2573485501354569L,9938978487990060L,148764065110560900L,BigInteger.Parse("510526106256177860940"),BigInteger.Parse("117943982401427236556700"),BigInteger.Parse("1799331452449680632120820") };
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
public class A247307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247307Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A247307.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A247307.Bytes);
public BigInteger this[int i]=>Value[i];

public static A247307Inst Instance=new A247307Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247308
{
public static readonly long[] Value={ 1L,7L,37L,163L,661L,2643L,10497L,41505L,162171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247308Inst : IEnumerable<long>
{
public static readonly long[] Value=A247308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247308.Bytes);
public long this[int i]=>Value[i];

public static A247308Inst Instance=new A247308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247309
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,2L,3L,3L,5L,8L,8L,13L,21L,21L,34L,55L,55L,89L,144L,144L,233L,377L,377L,610L,987L,987L,1597L,2584L,2584L,4181L,6765L,6765L,10946L,17711L,17711L,28657L,46368L,46368L,75025L,121393L,121393L,196418L,317811L,317811L,514229L,832040L,832040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247309Inst : IEnumerable<long>
{
public static readonly long[] Value=A247309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247309.Bytes);
public long this[int i]=>Value[i];

public static A247309Inst Instance=new A247309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247310
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,2L,1L,0L,0L,2L,3L,5L,3L,0L,0L,5L,8L,13L,8L,0L,0L,13L,21L,34L,21L,0L,0L,34L,55L,89L,55L,0L,0L,89L,144L,233L,144L,0L,0L,233L,377L,610L,377L,0L,0L,610L,987L,1597L,987L,0L,0L,1597L,2584L,4181L,2584L,0L,0L,4181L,6765L,10946L,6765L,0L,0L,10946L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247310Inst : IEnumerable<long>
{
public static readonly long[] Value=A247310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247310.Bytes);
public long this[int i]=>Value[i];

public static A247310Inst Instance=new A247310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247311
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,2L,2L,1L,4L,5L,3L,9L,12L,8L,21L,29L,20L,50L,70L,49L,120L,169L,119L,289L,408L,288L,697L,985L,696L,1682L,2378L,1681L,4060L,5741L,4059L,9801L,13860L,9800L,23661L,33461L,23660L,57122L,80782L,57121L,137904L,195025L,137903L,332929L,470832L,332928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247311Inst : IEnumerable<long>
{
public static readonly long[] Value=A247311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247311.Bytes);
public long this[int i]=>Value[i];

public static A247311Inst Instance=new A247311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247312
{
public static readonly BigInteger[] Value={ 11252109375L,47450841796875L,187605480615234375L,BigInteger.Parse("712096246922607421875"),BigInteger.Parse("2627953955633148193359375"),BigInteger.Parse("9500846300153588104248046875"),BigInteger.Parse("29357159521824837441192448139190673828125"),BigInteger.Parse("80932484400013426603726400434970855712890625"),BigInteger.Parse("218326368611836548856645001359283924102783203125") };
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
public class A247312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247312Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A247312.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A247312.Bytes);
public BigInteger this[int i]=>Value[i];

public static A247312Inst Instance=new A247312Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247313
{
public static readonly long[] Value={ 1L,3L,11L,47L,219L,1063L,5251L,26127L,130379L,651383L,3255891L,16277407L,81382939L,406906503L,2034516131L,10172547887L,50862673899L,254313238423L,1271565929971L,6357829125567L,31789144579259L,158945720799143L,794728599801411L,3973642990618447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247313Inst : IEnumerable<long>
{
public static readonly long[] Value=A247313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247313.Bytes);
public long this[int i]=>Value[i];

public static A247313Inst Instance=new A247313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247314
{
public static readonly long[] Value={ 7L,6L,7L,0L,4L,1L,5L,0L,0L,9L,6L,1L,7L,6L,5L,3L,0L,9L,4L,1L,2L,7L,3L,9L,1L,7L,7L,5L,8L,6L,8L,2L,0L,8L,8L,1L,3L,0L,2L,0L,9L,3L,7L,5L,1L,5L,0L,1L,2L,5L,2L,2L,1L,9L,2L,1L,9L,7L,2L,1L,7L,0L,1L,6L,2L,0L,0L,0L,9L,1L,5L,2L,2L,5L,9L,6L,8L,6L,2L,4L,5L,2L,3L,2L,7L,4L,1L,1L,7L,3L,0L,4L,7L,4L,8L,8L,2L,4L,7L,7L,7L,7L,8L,8L,5L,9L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247314Inst : IEnumerable<long>
{
public static readonly long[] Value=A247314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247314.Bytes);
public long this[int i]=>Value[i];

public static A247314Inst Instance=new A247314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247315
{
public static readonly long[] Value={ 1L,15L,24L,69L,114L,133L,147L,153L,186L,198L,258L,270L,276L,288L,306L,339L,366L,393L,429L,474L,495L,507L,609L,627L,639L,717L,763L,817L,871L,1062L,1080L,1083L,1086L,1141L,1149L,1158L,1224L,1257L,1266L,1267L,1278L,1305L,1339L,1356L,1374L,1377L,1386L,1431L,1446L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247315Inst : IEnumerable<long>
{
public static readonly long[] Value=A247315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247315.Bytes);
public long this[int i]=>Value[i];

public static A247315Inst Instance=new A247315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247316
{
public static readonly long[] Value={ 1L,21L,27L,34L,54L,63L,81L,171L,205L,212L,214L,237L,243L,272L,291L,315L,324L,333L,342L,351L,356L,358L,394L,402L,405L,424L,432L,441L,459L,493L,502L,504L,513L,538L,540L,544L,565L,585L,624L,630L,663L,702L,712L,714L,716L,718L,723L,729L,745L,804L,810L,831L,834L,835L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247316Inst : IEnumerable<long>
{
public static readonly long[] Value=A247316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247316.Bytes);
public long this[int i]=>Value[i];

public static A247316Inst Instance=new A247316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247317
{
public static readonly long[] Value={ 1L,2907L,3339L,3726L,4293L,4371L,4614L,5049L,5319L,5607L,5751L,6291L,17901L,18009L,18441L,19413L,20349L,20655L,20943L,21219L,21267L,21573L,21627L,22137L,22191L,23355L,24831L,25647L,25731L,26019L,26145L,26163L,27405L,27537L,28035L,28215L,28227L,28305L,29601L,30429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247317Inst : IEnumerable<long>
{
public static readonly long[] Value=A247317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247317.Bytes);
public long this[int i]=>Value[i];

public static A247317Inst Instance=new A247317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247318
{
public static readonly long[] Value={ 0L,4L,8L,4L,8L,0L,8L,0L,1L,4L,4L,9L,4L,6L,3L,6L,3L,2L,7L,0L,5L,7L,2L,4L,9L,3L,3L,8L,8L,2L,4L,7L,6L,5L,5L,6L,3L,3L,3L,0L,5L,6L,0L,0L,6L,6L,9L,5L,2L,3L,7L,1L,3L,9L,7L,7L,1L,6L,6L,5L,5L,9L,9L,8L,3L,8L,6L,6L,2L,0L,4L,8L,2L,0L,5L,4L,0L,2L,2L,5L,4L,2L,7L,6L,2L,5L,8L,8L,8L,8L,8L,7L,3L,1L,1L,3L,3L,9L,2L,4L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247318Inst : IEnumerable<long>
{
public static readonly long[] Value=A247318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247318.Bytes);
public long this[int i]=>Value[i];

public static A247318Inst Instance=new A247318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247319
{
public static readonly long[] Value={ 6L,4L,5L,3L,6L,5L,8L,4L,6L,3L,3L,4L,3L,4L,1L,0L,8L,1L,8L,9L,6L,2L,3L,3L,6L,0L,5L,1L,3L,1L,9L,1L,2L,9L,5L,3L,6L,0L,6L,5L,3L,0L,4L,1L,1L,6L,3L,6L,5L,2L,6L,0L,0L,7L,4L,6L,3L,4L,0L,6L,2L,3L,2L,2L,1L,0L,0L,7L,9L,4L,6L,5L,8L,8L,8L,4L,9L,6L,7L,1L,6L,9L,8L,2L,8L,7L,5L,7L,3L,3L,3L,5L,4L,8L,7L,0L,5L,7L,4L,9L,9L,8L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247319Inst : IEnumerable<long>
{
public static readonly long[] Value=A247319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247319.Bytes);
public long this[int i]=>Value[i];

public static A247319Inst Instance=new A247319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247320
{
public static readonly long[] Value={ 1L,7L,5L,5L,7L,1L,3L,4L,3L,1L,3L,7L,3L,1L,0L,6L,0L,4L,0L,7L,3L,1L,8L,6L,5L,8L,9L,9L,9L,5L,5L,2L,3L,8L,6L,8L,4L,3L,0L,0L,4L,5L,4L,6L,4L,1L,3L,6L,9L,4L,2L,2L,3L,4L,9L,2L,4L,1L,6L,6L,9L,9L,7L,4L,9L,4L,4L,4L,4L,1L,1L,5L,2L,6L,0L,2L,1L,7L,0L,1L,5L,3L,3L,2L,3L,1L,4L,1L,8L,6L,5L,9L,4L,2L,0L,6L,2L,4L,3L,0L,6L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247320Inst : IEnumerable<long>
{
public static readonly long[] Value=A247320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247320.Bytes);
public long this[int i]=>Value[i];

public static A247320Inst Instance=new A247320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247321
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,2L,1L,2L,4L,2L,2L,5L,5L,6L,5L,7L,13L,10L,7L,18L,22L,20L,18L,29L,45L,40L,29L,63L,87L,74L,63L,116L,166L,150L,116L,229L,329L,282L,229L,445L,627L,558L,445L,856L,1232L,1072L,856L,1677L,2373L,2088L,1677L,3229L,4621L,4050L,3229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247321Inst : IEnumerable<long>
{
public static readonly long[] Value=A247321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247321.Bytes);
public long this[int i]=>Value[i];

public static A247321Inst Instance=new A247321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247322
{
public static readonly long[] Value={ 1L,2L,5L,9L,18L,35L,67L,132L,253L,495L,956L,1859L,3605L,6994L,13577L,26333L,51114L,99159L,192431L,373372L,724497L,1405819L,2727804L,5293079L,10270553L,19929026L,38670013L,75035105L,145597538L,282516315L,548192811L,1063708916L,2064013525L,4004996055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247322Inst : IEnumerable<long>
{
public static readonly long[] Value=A247322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247322.Bytes);
public long this[int i]=>Value[i];

public static A247322Inst Instance=new A247322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247323
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,5L,7L,18L,29L,63L,116L,229L,445L,856L,1677L,3229L,6298L,12185L,23675L,45922L,89097L,172931L,335460L,651065L,1263145L,2451184L,4756105L,9228777L,17907538L,34747357L,67424063L,130828370L,253859365L,492585879L,955810772L,1854647997L,3598744709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247323Inst : IEnumerable<long>
{
public static readonly long[] Value=A247323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247323.Bytes);
public long this[int i]=>Value[i];

public static A247323Inst Instance=new A247323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247324
{
public static readonly long[] Value={ 1L,2L,4L,8L,10L,11L,13L,14L,15L,18L,21L,25L,26L,27L,31L,34L,35L,36L,38L,39L,40L,42L,43L,44L,46L,47L,50L,51L,53L,54L,55L,59L,60L,63L,64L,65L,68L,70L,71L,72L,73L,77L,78L,79L,80L,83L,84L,85L,86L,87L,92L,94L,95L,97L,100L,103L,107L,109L,110L,112L,114L,118L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247324Inst : IEnumerable<long>
{
public static readonly long[] Value=A247324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247324.Bytes);
public long this[int i]=>Value[i];

public static A247324Inst Instance=new A247324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247325
{
public static readonly long[] Value={ 0L,1L,1L,4L,5L,13L,22L,45L,87L,166L,329L,627L,1232L,2373L,4621L,8956L,17377L,33737L,65422L,127009L,246363L,478134L,927685L,1800119L,3492960L,6777593L,13151433L,25518580L,49516525L,96081013L,186435302L,361757509L,701951407L,1362062118L,2642933937L,5128331659L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247325Inst : IEnumerable<long>
{
public static readonly long[] Value=A247325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247325.Bytes);
public long this[int i]=>Value[i];

public static A247325Inst Instance=new A247325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247326
{
public static readonly long[] Value={ 0L,0L,2L,2L,6L,10L,20L,40L,74L,150L,282L,558L,1072L,2088L,4050L,7850L,15254L,29562L,57412L,111344L,216106L,419294L,813594L,1578750L,3063264L,5944144L,11533698L,22380210L,43426118L,84263882L,163505076L,317263672L,615616874L,1194537286L,2317872890L,4497581934L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247326Inst : IEnumerable<long>
{
public static readonly long[] Value=A247326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247326.Bytes);
public long this[int i]=>Value[i];

public static A247326Inst Instance=new A247326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247327
{
public static readonly long[] Value={ 1L,4L,12L,9L,27L,45L,16L,48L,80L,112L,25L,75L,125L,175L,225L,36L,108L,180L,252L,324L,396L,49L,147L,245L,343L,441L,539L,637L,64L,192L,320L,448L,576L,704L,832L,960L,81L,243L,405L,567L,729L,891L,1053L,1215L,1377L,100L,300L,500L,700L,900L,1100L,1300L,1500L,1700L,1900L,121L,363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247327Inst : IEnumerable<long>
{
public static readonly long[] Value=A247327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247327.Bytes);
public long this[int i]=>Value[i];

public static A247327Inst Instance=new A247327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247328
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,15L,17L,19L,21L,23L,25L,27L,29L,31L,33L,35L,37L,39L,41L,43L,45L,47L,49L,51L,53L,55L,57L,59L,61L,63L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,105L,107L,109L,111L,113L,115L,117L,119L,121L,123L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247328Inst : IEnumerable<long>
{
public static readonly long[] Value=A247328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247328.Bytes);
public long this[int i]=>Value[i];

public static A247328Inst Instance=new A247328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247329
{
public static readonly BigInteger[] Value={ 1L,2L,9L,58L,475L,4666L,53116L,684762L,9833391L,155341258L,2673209561L,49717424868L,992847765988L,21172798741316L,479921234767976L,11516219861132586L,291523666535143823L,7761036379846481206L,BigInteger.Parse("216699016885046232187"),BigInteger.Parse("6330257697841339549706"),BigInteger.Parse("193043926318644060255531") };
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
public class A247329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247329Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A247329.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A247329.Bytes);
public BigInteger this[int i]=>Value[i];

public static A247329Inst Instance=new A247329Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247330
{
public static readonly BigInteger[] Value={ 1L,3L,12L,75L,633L,6330L,70410L,845490L,10778385L,144342129L,2016502329L,29249703273L,439097183598L,6807064047249L,108811265375748L,1791748638013341L,30373586425246566L,529855701281428431L,9509268033398381151UL,BigInteger.Parse("175539561089425403601"),BigInteger.Parse("3332349856995500161920"),BigInteger.Parse("65037265540406292591147") };
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
public class A247330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247330Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A247330.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A247330.Bytes);
public BigInteger this[int i]=>Value[i];

public static A247330Inst Instance=new A247330Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247331
{
public static readonly BigInteger[] Value={ 1L,4L,20L,148L,1492L,18068L,244628L,3582612L,55783252L,913716116L,15633525524L,278068128660L,5124595687636L,97633146977428L,1919960496128660L,38930551809036436L,813367272118600276L,17501331733030883732UL,BigInteger.Parse("387693438148021391892"),BigInteger.Parse("8839040069648710445460") };
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
public class A247331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247331Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A247331.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A247331.Bytes);
public BigInteger this[int i]=>Value[i];

public static A247331Inst Instance=new A247331Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247332
{
public static readonly long[] Value={ 1L,2L,3L,7L,16L,41L,107L,286L,782L,2179L,6172L,17702L,51272L,149727L,440341L,1303130L,3877837L,11596602L,34832573L,105041452L,317900632L,965240836L,2939479066L,8976098663L,27478467863L,84314278171L,259262013763L,798802232031L,2465713674230L,7624219181757L,23612883510015L,73241919575468L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247332Inst : IEnumerable<long>
{
public static readonly long[] Value=A247332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247332.Bytes);
public long this[int i]=>Value[i];

public static A247332Inst Instance=new A247332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247333
{
public static readonly long[] Value={ 1L,1L,2L,4L,11L,31L,92L,283L,893L,2875L,9407L,31189L,104555L,353794L,1206821L,4145350L,14326184L,49778473L,173794610L,609392578L,2145057797L,7577098816L,26850456704L,95425761829L,340047930692L,1214738997142L,4349231444405L,15604726428805L,56098211626478L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247333Inst : IEnumerable<long>
{
public static readonly long[] Value=A247333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247333.Bytes);
public long this[int i]=>Value[i];

public static A247333Inst Instance=new A247333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247334
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,10L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247334Inst : IEnumerable<long>
{
public static readonly long[] Value=A247334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247334.Bytes);
public long this[int i]=>Value[i];

public static A247334Inst Instance=new A247334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247335
{
public static readonly BigInteger[] Value={ 1L,10L,361L,13690L,519841L,19740250L,749609641L,28465426090L,1080936581761L,41047124680810L,1558709801289001L,59189925324301210L,2247658452522156961L,BigInteger.Parse("85351831270517663290"),BigInteger.Parse("3241121929827149048041"),BigInteger.Parse("123077281502161146162250") };
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
public class A247335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247335Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A247335.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A247335.Bytes);
public BigInteger this[int i]=>Value[i];

public static A247335Inst Instance=new A247335Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247336
{
public static readonly long[] Value={ 0L,1L,4L,6L,11L,13L,22L,23L,26L,33L,46L,57L,60L,61L,76L,78L,97L,118L,120L,121L,141L,166L,193L,212L,222L,237L,247L,251L,253L,286L,321L,339L,358L,397L,438L,481L,502L,508L,526L,573L,620L,622L,673L,722L,725L,726L,781L,838L,897L,958L,996L,1013L,1018L,1021L,1086L,1153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247336Inst : IEnumerable<long>
{
public static readonly long[] Value=A247336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247336.Bytes);
public long this[int i]=>Value[i];

public static A247336Inst Instance=new A247336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247337
{
public static readonly long[] Value={ 20L,11L,31L,42L,73L,115L,188L,2913L,4721L,7634L,12355L,19989L,322144L,521233L,843377L,1364610L,2207987L,35711597L,57782584L,93494181L,151276765L,2447610946L,3960317711L,6407928657L,10368246368L,16776175025L,271443121393L,439204196418L,710647317811L,1149851514229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247337Inst : IEnumerable<long>
{
public static readonly long[] Value=A247337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247337.Bytes);
public long this[int i]=>Value[i];

public static A247337Inst Instance=new A247337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247338
{
public static readonly long[] Value={ 2L,11L,13L,24L,37L,511L,818L,1329L,2147L,3476L,55123L,89199L,144322L,233521L,377843L,6101364L,9872207L,15973571L,25845778L,41819349L,676515127L,1094624476L,1771139603L,2865764079L,46368103682L,75025167761L,121393271443L,196418439204L,317811710647L,5142291149851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247338Inst : IEnumerable<long>
{
public static readonly long[] Value=A247338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247338.Bytes);
public long this[int i]=>Value[i];

public static A247338Inst Instance=new A247338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247339
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,6L,1L,2L,1L,10L,1L,2L,1L,14L,1L,16L,1L,2L,1L,20L,1L,2L,1L,24L,1L,26L,1L,2L,1L,4L,1L,2L,1L,5L,1L,36L,1L,2L,1L,40L,1L,2L,1L,5L,1L,12L,1L,2L,1L,9L,1L,2L,1L,54L,1L,56L,1L,2L,1L,5L,1L,2L,1L,4L,1L,66L,1L,2L,1L,5L,1L,2L,1L,74L,1L,23L,1L,2L,1L,6L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247339Inst : IEnumerable<long>
{
public static readonly long[] Value=A247339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247339.Bytes);
public long this[int i]=>Value[i];

public static A247339Inst Instance=new A247339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247340
{
public static readonly long[] Value={ 3L,8L,30L,46L,50L,76L,100L,144L,254L,266L,274L,286L,334L,380L,456L,494L,504L,516L,520L,526L,566L,664L,670L,726L,756L,810L,836L,844L,874L,1040L,1064L,1086L,1130L,1164L,1216L,1250L,1300L,1476L,1714L,1740L,1800L,1826L,1834L,1946L,1950L,2014L,2194L,2200L,2220L,2324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247340Inst : IEnumerable<long>
{
public static readonly long[] Value=A247340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247340.Bytes);
public long this[int i]=>Value[i];

public static A247340Inst Instance=new A247340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247341
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,4L,1L,1L,2L,3L,1L,1L,4L,4L,6L,30L,3L,1L,6L,1L,32L,3L,3L,2L,22L,1L,6L,1L,2L,14L,7L,1L,10L,1L,2L,6L,3L,4L,2L,5L,2L,6L,1L,1L,37L,53L,53L,13L,64L,1L,67L,1L,45L,29L,17L,12L,14L,1L,2L,5L,15L,36L,10L,7L,1L,1L,81L,4L,18L,5L,55L,8L,33L,19L,8L,6L,2L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247341Inst : IEnumerable<long>
{
public static readonly long[] Value=A247341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247341.Bytes);
public long this[int i]=>Value[i];

public static A247341Inst Instance=new A247341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247342
{
public static readonly long[] Value={ 1L,2L,1L,1L,1L,1L,4L,3L,2L,1L,3L,1L,1L,6L,1L,1L,1L,3L,1L,15L,29L,5L,1L,2L,3L,6L,1L,6L,20L,6L,3L,50L,3L,22L,8L,5L,5L,1L,84L,8L,7L,36L,3L,6L,7L,20L,6L,6L,8L,1L,6L,3L,2L,38L,1L,5L,3L,2L,5L,16L,1L,12L,13L,7L,1L,4L,16L,5L,32L,1L,6L,13L,4L,150L,7L,29L,17L,9L,12L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247342Inst : IEnumerable<long>
{
public static readonly long[] Value=A247342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247342.Bytes);
public long this[int i]=>Value[i];

public static A247342Inst Instance=new A247342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247343
{
public static readonly long[] Value={ 1L,-4L,-4L,6L,-4L,16L,-4L,-4L,6L,16L,-4L,-24L,-4L,16L,16L,1L,-4L,-24L,-4L,-24L,16L,16L,-4L,16L,6L,16L,-4L,-24L,-4L,-64L,-4L,0L,16L,16L,16L,36L,-4L,16L,16L,16L,-4L,-64L,-4L,-24L,-24L,16L,-4L,-4L,6L,-24L,16L,-24L,-4L,16L,16L,16L,16L,16L,-4L,96L,-4L,16L,-24L,0L,16L,-64L,-4L,-24L,16L,-64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247343Inst : IEnumerable<long>
{
public static readonly long[] Value=A247343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247343.Bytes);
public long this[int i]=>Value[i];

public static A247343Inst Instance=new A247343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247344
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,305L,7905L,137105L,2090305L,30673905L,446213025L,6483539025L,94216001025L,1369259983025L,19900452349025L,289229603172625L,4203610924242625L,61094494859232625L,887935798190222625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247344Inst : IEnumerable<long>
{
public static readonly long[] Value=A247344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247344.Bytes);
public long this[int i]=>Value[i];

public static A247344Inst Instance=new A247344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247345
{
public static readonly long[] Value={ 16L,40L,70L,96L,180L,3664L,24717L,15492L,84198L,65489L,3725L,16974L,41702L,3788L,5757L,1958L,14609L,62892L,44745L,9385L,169L,40L,70L,96L,180L,3664L,24717L,15492L,84198L,65489L,3725L,16974L,41702L,3788L,5757L,1958L,14609L,62892L,44745L,9385L,169L,40L,70L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247345Inst : IEnumerable<long>
{
public static readonly long[] Value=A247345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247345.Bytes);
public long this[int i]=>Value[i];

public static A247345Inst Instance=new A247345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247346
{
public static readonly long[] Value={ 151L,201L,227L,341L,403L,423L,537L,605L,635L,715L,805L,847L,891L,909L,953L,955L,1003L,1073L,1075L,1129L,1131L,1191L,1271L,1273L,1337L,1431L,1433L,1505L,1613L,1693L,1697L,1783L,1787L,1907L,1911L,2007L,2011L,2147L,2149L,2257L,2259L,2263L,2377L,2383L,2421L,2503L,2541L,2547L,2675L,2681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247346Inst : IEnumerable<long>
{
public static readonly long[] Value=A247346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247346.Bytes);
public long this[int i]=>Value[i];

public static A247346Inst Instance=new A247346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247347
{
public static readonly long[] Value={ 11L,23L,719L,1439L,5639L,25799L,28319L,35879L,56039L,58679L,77279L,98999L,104759L,121559L,166919L,174599L,206639L,253679L,334319L,350159L,424079L,433439L,451679L,452759L,535919L,539159L,582719L,595319L,645839L,671039L,743279L,818999L,824039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247347Inst : IEnumerable<long>
{
public static readonly long[] Value=A247347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247347.Bytes);
public long this[int i]=>Value[i];

public static A247347Inst Instance=new A247347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247348
{
public static readonly long[] Value={ 174599L,334319L,535919L,671039L,907199L,2129399L,2298119L,3103799L,3369959L,4351199L,4598159L,5697599L,6184799L,6446159L,7224839L,7943759L,7957319L,8148839L,8346959L,8656919L,9096359L,9339119L,9463319L,9511199L,10514159L,10780559L,11816999L,12424319L,13781039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247348Inst : IEnumerable<long>
{
public static readonly long[] Value=A247348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247348.Bytes);
public long this[int i]=>Value[i];

public static A247348Inst Instance=new A247348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247349
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,2L,2L,1L,2L,3L,3L,2L,1L,2L,3L,2L,3L,3L,2L,1L,4L,2L,1L,4L,2L,3L,3L,3L,2L,3L,3L,3L,2L,1L,4L,3L,3L,2L,1L,4L,3L,2L,3L,3L,3L,4L,3L,2L,3L,3L,3L,3L,2L,1L,4L,3L,3L,3L,3L,2L,1L,4L,4L,3L,2L,5L,3L,2L,1L,4L,4L,3L,2L,5L,3L,3L,3L,4L,4L,4L,3L,2L,5L,3L,3L,3L,4L,3L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247349Inst : IEnumerable<long>
{
public static readonly long[] Value=A247349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247349.Bytes);
public long this[int i]=>Value[i];

public static A247349Inst Instance=new A247349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247350
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,12L,14L,15L,17L,22L,28L,33L,35L,39L,40L,45L,53L,57L,58L,59L,65L,70L,73L,74L,77L,80L,82L,83L,85L,93L,97L,99L,100L,102L,103L,104L,107L,115L,117L,118L,122L,128L,134L,139L,142L,143L,148L,152L,159L,164L,173L,178L,182L,184L,185L,188L,190L,195L,198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247350Inst : IEnumerable<long>
{
public static readonly long[] Value=A247350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247350.Bytes);
public long this[int i]=>Value[i];

public static A247350Inst Instance=new A247350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247351
{
public static readonly BigInteger[] Value={ 3L,31L,313L,3137L,31397L,314159L,3141601L,31415899L,314159257L,3141592661L,31415926541L,314159265359L,3141592653581L,31415926535879L,314159265358951L,3141592653589771L,31415926535897921L,314159265358979347L,3141592653589793239L,BigInteger.Parse("31415926535897932363") };
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
public class A247351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247351Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A247351.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A247351.Bytes);
public BigInteger this[int i]=>Value[i];

public static A247351Inst Instance=new A247351Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247352
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,0L,1L,1L,0L,2L,2L,1L,2L,2L,3L,4L,2L,5L,8L,5L,5L,10L,12L,13L,10L,17L,28L,22L,17L,38L,49L,45L,38L,66L,100L,87L,66L,138L,191L,166L,138L,257L,370L,329L,257L,508L,724L,627L,508L,981L,1392L,1232L,981L,1900L,2721L,2373L,1900L,3702L,5254L,4621L,3702L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247352Inst : IEnumerable<long>
{
public static readonly long[] Value=A247352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247352.Bytes);
public long this[int i]=>Value[i];

public static A247352Inst Instance=new A247352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247353
{
public static readonly long[] Value={ 1L,3L,5L,11L,20L,40L,77L,149L,291L,561L,1094L,2116L,4113L,7975L,15477L,30035L,58268L,113084L,219397L,425753L,826091L,1602969L,3110382L,6035336L,11710993L,22723803L,44093269L,85558059L,166016420L,322136912L,625072109L,1212885517L,2353473731L,4566663857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247353Inst : IEnumerable<long>
{
public static readonly long[] Value=A247353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247353.Bytes);
public long this[int i]=>Value[i];

public static A247353Inst Instance=new A247353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247354
{
public static readonly long[] Value={ 0L,1L,0L,2L,2L,5L,10L,17L,38L,66L,138L,257L,508L,981L,1900L,3702L,7154L,13925L,26966L,52381L,101594L,197150L,382578L,742257L,1440440L,2794777L,5423256L,10522954L,20418882L,39620597L,76879298L,149176601L,289460206L,561667802L,1089854522L,2114747217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247354Inst : IEnumerable<long>
{
public static readonly long[] Value=A247354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247354.Bytes);
public long this[int i]=>Value[i];

public static A247354Inst Instance=new A247354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247355
{
public static readonly long[] Value={ 0L,1L,2L,3L,8L,12L,28L,49L,100L,191L,370L,724L,1392L,2721L,5254L,10223L,19812L,38456L,74628L,144769L,280984L,545107L,1057862L,2052520L,3982816L,7728177L,14995626L,29097643L,56460416L,109556004L,212580908L,412491201L,800394316L,1553079415L,3013584442L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247355Inst : IEnumerable<long>
{
public static readonly long[] Value=A247355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247355.Bytes);
public long this[int i]=>Value[i];

public static A247355Inst Instance=new A247355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247356
{
public static readonly long[] Value={ 3L,5L,7L,16L,17L,19L,22L,23L,30L,32L,33L,41L,45L,49L,56L,61L,67L,74L,75L,76L,88L,90L,91L,98L,99L,101L,105L,108L,115L,116L,117L,120L,125L,131L,137L,138L,140L,141L,154L,158L,164L,167L,170L,172L,175L,178L,185L,188L,189L,193L,194L,199L,203L,221L,230L,231L,234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247356Inst : IEnumerable<long>
{
public static readonly long[] Value=A247356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247356.Bytes);
public long this[int i]=>Value[i];

public static A247356Inst Instance=new A247356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247357
{
public static readonly long[] Value={ 1L,3L,5L,7L,8L,10L,12L,14L,16L,18L,20L,21L,23L,25L,27L,29L,31L,33L,35L,37L,38L,40L,42L,44L,46L,48L,50L,52L,54L,56L,58L,60L,62L,63L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,85L,87L,89L,91L,92L,94L,96L,98L,100L,102L,104L,106L,108L,110L,112L,114L,116L,118L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247357Inst : IEnumerable<long>
{
public static readonly long[] Value=A247357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247357.Bytes);
public long this[int i]=>Value[i];

public static A247357Inst Instance=new A247357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247358
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,4L,1L,4L,8L,9L,1L,5L,16L,16L,27L,1L,6L,25L,32L,64L,81L,1L,7L,36L,64L,125L,243L,256L,1L,8L,49L,128L,216L,625L,729L,1024L,1L,9L,64L,256L,343L,1296L,2187L,3125L,4096L,1L,10L,81L,512L,512L,2401L,6561L,7776L,15625L,16384L,1L,11L,100L,729L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247358Inst : IEnumerable<long>
{
public static readonly long[] Value=A247358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247358.Bytes);
public long this[int i]=>Value[i];

public static A247358Inst Instance=new A247358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247359
{
public static readonly long[] Value={ 4L,6L,7L,8L,10L,11L,13L,14L,15L,16L,17L,18L,19L,20L,24L,26L,27L,28L,30L,34L,36L,37L,38L,40L,44L,46L,47L,48L,50L,54L,56L,57L,58L,60L,64L,66L,67L,68L,70L,74L,76L,77L,78L,80L,84L,86L,87L,88L,90L,94L,96L,97L,98L,100L,104L,106L,107L,108L,110L,111L,113L,114L,115L,116L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247359Inst : IEnumerable<long>
{
public static readonly long[] Value=A247359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247359.Bytes);
public long this[int i]=>Value[i];

public static A247359Inst Instance=new A247359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247360
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,8L,9L,10L,17L,18L,19L,20L,21L,22L,23L,25L,26L,27L,28L,29L,31L,32L,33L,35L,36L,37L,38L,39L,41L,42L,43L,45L,46L,47L,48L,49L,51L,52L,53L,55L,56L,57L,58L,59L,61L,62L,63L,65L,66L,67L,68L,69L,70L,77L,78L,79L,80L,81L,82L,83L,85L,86L,87L,88L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247360Inst : IEnumerable<long>
{
public static readonly long[] Value=A247360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247360.Bytes);
public long this[int i]=>Value[i];

public static A247360Inst Instance=new A247360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247361
{
public static readonly long[] Value={ 1L,4L,2L,6L,3L,7L,5L,8L,9L,10L,12L,11L,21L,13L,22L,14L,23L,15L,25L,16L,29L,17L,31L,18L,32L,19L,33L,20L,35L,24L,39L,26L,41L,27L,42L,28L,43L,30L,45L,34L,49L,36L,51L,37L,52L,38L,53L,40L,55L,44L,59L,46L,61L,47L,62L,48L,63L,50L,65L,54L,69L,56L,71L,57L,72L,58L,73L,60L,75L,64L,79L,66L,81L,67L,82L,68L,83L,70L,85L,74L,89L,76L,91L,77L,92L,78L,93L,80L,95L,84L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247361Inst : IEnumerable<long>
{
public static readonly long[] Value=A247361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247361.Bytes);
public long this[int i]=>Value[i];

public static A247361Inst Instance=new A247361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247362
{
public static readonly long[] Value={ 0L,4L,1L,6L,2L,7L,3L,8L,5L,10L,9L,11L,12L,13L,21L,14L,22L,15L,23L,16L,25L,17L,29L,18L,31L,19L,32L,20L,33L,24L,35L,26L,39L,27L,41L,28L,42L,30L,43L,34L,45L,36L,49L,37L,51L,38L,52L,40L,53L,44L,55L,46L,59L,47L,61L,48L,62L,50L,63L,54L,65L,56L,69L,57L,71L,58L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247362Inst : IEnumerable<long>
{
public static readonly long[] Value=A247362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247362.Bytes);
public long this[int i]=>Value[i];

public static A247362Inst Instance=new A247362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247363
{
public static readonly BigInteger[] Value={ 1L,3L,16L,64L,343L,4096L,59049L,1000000L,14348907L,129140163L,1475789056L,38443359375L,1099511627776L,34271896307633L,1156831381426176L,42052983462257059L,1152921504606846976L,BigInteger.Parse("18446744073709551616"),BigInteger.Parse("295147905179352825856"),BigInteger.Parse("12116574790945106558976") };
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
public class A247363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247363Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A247363.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A247363.Bytes);
public BigInteger this[int i]=>Value[i];

public static A247363Inst Instance=new A247363Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247364
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,4L,4L,3L,1L,1L,9L,9L,6L,4L,1L,1L,21L,21L,15L,8L,5L,1L,1L,51L,51L,36L,22L,10L,6L,1L,1L,127L,127L,91L,54L,30L,12L,7L,1L,1L,323L,323L,232L,142L,75L,39L,14L,8L,1L,1L,835L,835L,603L,370L,205L,99L,49L,16L,9L,1L,1L,2188L,2188L,1585L,983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247364Inst : IEnumerable<long>
{
public static readonly long[] Value=A247364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247364.Bytes);
public long this[int i]=>Value[i];

public static A247364Inst Instance=new A247364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247365
{
public static readonly BigInteger[] Value={ 1L,2L,13L,130L,1807L,32280L,705421L,18237164L,544505521L,18438430990L,698246022001L,29239344782022L,1341545985079903L,66926098621724300L,3606825675219961657L,BigInteger.Parse("208826700420103831480"),BigInteger.Parse("12926842112341879416001"),BigInteger.Parse("851962999949978920707834"),BigInteger.Parse("59561112879709434549509941") };
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
public class A247365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247365Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A247365.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A247365.Bytes);
public BigInteger this[int i]=>Value[i];

public static A247365Inst Instance=new A247365Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247366
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,3L,4L,4L,4L,5L,5L,6L,6L,7L,8L,8L,9L,9L,10L,11L,12L,12L,13L,14L,15L,16L,16L,18L,19L,20L,22L,22L,24L,25L,27L,27L,29L,31L,32L,33L,36L,38L,39L,41L,44L,45L,46L,48L,50L,54L,55L,58L,62L,64L,66L,67L,72L,76L,78L,81L,83L,88L,90L,93L,96L,101L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247366Inst : IEnumerable<long>
{
public static readonly long[] Value=A247366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247366.Bytes);
public long this[int i]=>Value[i];

public static A247366Inst Instance=new A247366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247367
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,1L,3L,3L,2L,2L,2L,4L,4L,2L,4L,4L,3L,3L,4L,5L,3L,5L,5L,5L,5L,2L,4L,6L,6L,4L,6L,6L,5L,6L,4L,6L,5L,5L,7L,7L,5L,5L,7L,7L,7L,5L,7L,7L,7L,6L,5L,8L,6L,6L,8L,8L,8L,8L,6L,8L,8L,6L,8L,8L,7L,5L,9L,9L,7L,9L,9L,9L,8L,7L,7L,9L,9L,9L,9L,9L,7L,8L,8L,10L,10L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247367Inst : IEnumerable<long>
{
public static readonly long[] Value=A247367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247367.Bytes);
public long this[int i]=>Value[i];

public static A247367Inst Instance=new A247367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247368
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,5L,9L,17L,4L,65L,121L,277L,841L,2746L,441L,28561L,93025L,312001L,583696L,5309441L,14145121L,116815697L,719795241L,4487760170L,433763929L,175081030037L,1091329140889L,6935920173025L,53828252727076L,610296440614897L,1223724862004841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247368Inst : IEnumerable<long>
{
public static readonly long[] Value=A247368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247368.Bytes);
public long this[int i]=>Value[i];

public static A247368Inst Instance=new A247368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247369
{
public static readonly long[] Value={ 0L,-1L,1L,1L,1L,0L,1L,1L,1L,3L,4L,-5L,1L,-7L,9L,8L,25L,-23L,49L,87L,16L,295L,529L,-903L,841L,-1256L,3481L,-1495L,16641L,-44341L,98596L,217651L,4225L,1058961L,2337841L,-5106896L,13608721L,5415345L,67387681L,-173830481L,264517696L,-2288275633L,6941055969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247369Inst : IEnumerable<long>
{
public static readonly long[] Value=A247369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247369.Bytes);
public long this[int i]=>Value[i];

public static A247369Inst Instance=new A247369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247370
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,2L,3L,-1L,7L,10L,13L,9L,37L,40L,133L,369L,877L,-488L,4429L,9881L,16869L,46970L,169039L,65311L,1875739L,6659730L,23387209L,-7406159L,265302649L,923436432L,2717142457L,17805417409L,89803227913L,-79079320720L,2449845576777L,12004801505489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247370Inst : IEnumerable<long>
{
public static readonly long[] Value=A247370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247370.Bytes);
public long this[int i]=>Value[i];

public static A247370Inst Instance=new A247370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247371
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,3L,2L,2L,1L,2L,1L,2L,1L,2L,1L,4L,1L,1L,1L,2L,1L,2L,1L,2L,2L,3L,1L,6L,1L,2L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,2L,2L,2L,2L,1L,6L,1L,2L,2L,1L,1L,4L,1L,3L,1L,4L,1L,2L,1L,2L,1L,2L,1L,6L,1L,3L,1L,2L,1L,6L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247371Inst : IEnumerable<long>
{
public static readonly long[] Value=A247371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247371.Bytes);
public long this[int i]=>Value[i];

public static A247371Inst Instance=new A247371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247372
{
public static readonly long[] Value={ 3L,4L,10L,5L,21L,6L,14L,24L,7L,36L,8L,18L,55L,30L,9L,44L,60L,33L,10L,78L,22L,65L,11L,52L,105L,70L,39L,12L,26L,112L,136L,42L,13L,60L,119L,80L,14L,102L,171L,30L,126L,85L,48L,152L,15L,180L,68L,133L,210L,90L,51L,16L,114L,34L,140L,95L,17L,168L,253L,76L,198L,230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247372Inst : IEnumerable<long>
{
public static readonly long[] Value=A247372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247372.Bytes);
public long this[int i]=>Value[i];

public static A247372Inst Instance=new A247372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247373
{
public static readonly long[] Value={ 2L,7L,0L,2L,4L,6L,7L,3L,3L,1L,4L,0L,1L,9L,6L,8L,4L,1L,7L,8L,4L,1L,7L,8L,5L,5L,1L,6L,7L,0L,8L,6L,6L,5L,9L,9L,9L,6L,0L,0L,7L,4L,1L,4L,6L,7L,0L,9L,3L,9L,2L,5L,0L,5L,1L,7L,0L,6L,1L,5L,2L,6L,0L,9L,3L,2L,2L,6L,1L,5L,6L,6L,8L,7L,4L,5L,1L,0L,5L,0L,3L,5L,0L,5L,7L,4L,4L,8L,5L,2L,1L,5L,7L,8L,8L,4L,9L,8L,4L,8L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247373Inst : IEnumerable<long>
{
public static readonly long[] Value=A247373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247373.Bytes);
public long this[int i]=>Value[i];

public static A247373Inst Instance=new A247373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247374
{
public static readonly long[] Value={ 3L,8L,17L,38L,77L,165L,331L,698L,1397L,2921L,5843L,12149L,24299L,50315L,100631L,207698L,415397L,855105L,1710211L,3512801L,7025603L,14403923L,28807847L,58967773L,117935547L,241071395L,482142791L,984343883L,1968687767L,4014934295L,8029868591L,16360277378L,32720554757L,66607912625L,133215825251L,270969218153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247374Inst : IEnumerable<long>
{
public static readonly long[] Value=A247374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247374.Bytes);
public long this[int i]=>Value[i];

public static A247374Inst Instance=new A247374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247375
{
public static readonly long[] Value={ 0L,1L,2L,3L,8L,9L,18L,19L,32L,33L,50L,51L,72L,73L,98L,99L,128L,129L,162L,163L,200L,201L,242L,243L,288L,289L,338L,339L,392L,393L,450L,451L,512L,513L,578L,579L,648L,649L,722L,723L,800L,801L,882L,883L,968L,969L,1058L,1059L,1152L,1153L,1250L,1251L,1352L,1353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247375Inst : IEnumerable<long>
{
public static readonly long[] Value=A247375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247375.Bytes);
public long this[int i]=>Value[i];

public static A247375Inst Instance=new A247375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247376
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,5L,15L,8L,8L,35L,33L,13L,80L,131L,48L,21L,171L,409L,279L,34L,355L,1180L,1375L,384L,55L,715L,3128L,5335L,2895L,89L,1410L,7858L,18510L,17029L,3840L,144L,2730L,18851L,58253L,78609L,35685L,233L,5208L,43629L,171059L,317758L,243873L,46080L,377L,9810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247376Inst : IEnumerable<long>
{
public static readonly long[] Value=A247376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247376.Bytes);
public long this[int i]=>Value[i];

public static A247376Inst Instance=new A247376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247377
{
public static readonly long[] Value={ 2L,2L,6L,6L,5L,3L,4L,5L,0L,7L,6L,9L,9L,8L,4L,8L,8L,3L,5L,0L,7L,1L,9L,6L,3L,8L,5L,7L,6L,7L,8L,2L,2L,0L,9L,1L,8L,4L,0L,8L,8L,2L,9L,7L,1L,4L,2L,8L,0L,2L,2L,2L,1L,9L,3L,8L,6L,1L,0L,9L,3L,5L,5L,4L,4L,2L,9L,1L,8L,8L,9L,9L,7L,6L,9L,1L,3L,7L,5L,2L,8L,1L,0L,8L,5L,0L,9L,1L,0L,6L,9L,7L,4L,7L,9L,3L,4L,0L,6L,9L,5L,8L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247377Inst : IEnumerable<long>
{
public static readonly long[] Value=A247377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247377.Bytes);
public long this[int i]=>Value[i];

public static A247377Inst Instance=new A247377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247378
{
public static readonly long[] Value={ 1L,-2L,1L,1L,-1L,1L,2L,-3L,-1L,-11L,17L,46L,217L,-143L,2383L,10797L,19054L,497689L,2407303L,-18692747L,-184111831L,-1592624618L,26447728169L,396185367129L,-372098609569L,104735294255689L,1574163501502418L,-29166210748027547L,1549967994300724111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247378Inst : IEnumerable<long>
{
public static readonly long[] Value=A247378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247378.Bytes);
public long this[int i]=>Value[i];

public static A247378Inst Instance=new A247378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247379
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,3L,1L,8L,1L,5L,1L,6L,1L,7L,3L,8L,1L,2L,1L,1L,3L,1L,1L,1L,5L,2L,1L,1L,1L,6L,1L,2L,1L,17L,7L,2L,1L,19L,3L,40L,1L,2L,1L,1L,3L,2L,1L,6L,7L,1L,3L,4L,1L,1L,5L,2L,1L,29L,1L,2L,1L,31L,9L,64L,1L,2L,1L,1L,3L,2L,1L,8L,1L,1L,3L,1L,7L,1L,1L,2L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247379Inst : IEnumerable<long>
{
public static readonly long[] Value=A247379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247379.Bytes);
public long this[int i]=>Value[i];

public static A247379Inst Instance=new A247379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247380
{
public static readonly long[] Value={ 3L,7L,11L,23L,21L,37L,31L,51L,77L,49L,97L,85L,67L,99L,137L,149L,93L,169L,143L,111L,199L,167L,221L,281L,197L,153L,211L,163L,225L,533L,251L,323L,203L,479L,219L,367L,379L,315L,401L,413L,261L,601L,277L,369L,287L,751L,775L,415L,325L,429L,539L,343L,771L,575L,587L,599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247380Inst : IEnumerable<long>
{
public static readonly long[] Value=A247380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247380.Bytes);
public long this[int i]=>Value[i];

public static A247380Inst Instance=new A247380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A247381
{
public static readonly long[] Value={ 36L,72L,12L,36L,180L,6L,252L,72L,36L,90L,396L,12L,468L,126L,60L,7056L,2448L,72L,684L,180L,84L,198L,20700L,24L,900L,234L,5292L,252L,4176L,30L,1116L,288L,132L,306L,1260L,36L,1332L,5472L,156L,360L,5904L,42L,1548L,396L,180L,1656L,82908L,1200L,7056L,1800L,204L,468L,30528L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A247381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A247381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A247381Inst : IEnumerable<long>
{
public static readonly long[] Value=A247381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A247381.Bytes);
public long this[int i]=>Value[i];

public static A247381Inst Instance=new A247381Inst();

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