using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A078635
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,2L,4L,5L,5L,5L,7L,8L,8L,8L,12L,14L,15L,15L,19L,21L,22L,22L,28L,33L,35L,37L,43L,48L,50L,52L,62L,70L,75L,79L,92L,100L,105L,109L,126L,140L,148L,157L,177L,194L,202L,211L,237L,261L,276L,290L,324L,351L,370L,384L,424L,462L,489L,514L,562L,609L,640L,670L,728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078635Inst : IEnumerable<long>
{
public static readonly long[] Value=A078635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078635.Bytes);
public long this[int i]=>Value[i];

public static A078635Inst Instance=new A078635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078636
{
public static readonly long[] Value={ 2L,6L,6L,10L,30L,42L,14L,6L,30L,110L,66L,78L,182L,210L,30L,34L,102L,114L,190L,210L,462L,506L,138L,30L,130L,78L,42L,406L,870L,930L,62L,66L,1122L,1190L,210L,222L,1406L,1482L,390L,410L,1722L,1806L,946L,330L,690L,2162L,282L,42L,70L,510L,1326L,1378L,318L,330L,770L,798L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078636Inst : IEnumerable<long>
{
public static readonly long[] Value=A078636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078636.Bytes);
public long this[int i]=>Value[i];

public static A078636Inst Instance=new A078636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078637
{
public static readonly long[] Value={ 6L,6L,30L,30L,210L,42L,42L,30L,330L,330L,858L,546L,2730L,210L,510L,102L,1938L,570L,3990L,2310L,10626L,1518L,690L,390L,390L,546L,1218L,6090L,26970L,930L,2046L,1122L,39270L,3570L,7770L,4218L,54834L,7410L,15990L,8610L,74046L,19866L,14190L,7590L,32430L,6486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078637Inst : IEnumerable<long>
{
public static readonly long[] Value=A078637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078637.Bytes);
public long this[int i]=>Value[i];

public static A078637Inst Instance=new A078637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078638
{
public static readonly long[] Value={ 6L,30L,30L,210L,210L,42L,210L,330L,330L,4290L,6006L,2730L,2730L,3570L,510L,1938L,9690L,3990L,43890L,53130L,10626L,7590L,8970L,390L,2730L,15834L,6090L,188790L,26970L,10230L,34782L,39270L,39270L,132090L,147630L,54834L,274170L,303810L,111930L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078638Inst : IEnumerable<long>
{
public static readonly long[] Value=A078638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078638.Bytes);
public long this[int i]=>Value[i];

public static A078638Inst Instance=new A078638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078639
{
public static readonly long[] Value={ 1L,2L,5L,16L,73L,533L,7303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078639Inst : IEnumerable<long>
{
public static readonly long[] Value=A078639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078639.Bytes);
public long this[int i]=>Value[i];

public static A078639Inst Instance=new A078639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078640
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,2L,2L,2L,2L,3L,3L,2L,3L,4L,5L,5L,5L,4L,4L,5L,6L,6L,6L,6L,7L,8L,6L,7L,8L,9L,9L,6L,7L,8L,11L,10L,8L,9L,9L,11L,11L,10L,10L,11L,14L,13L,12L,11L,12L,15L,16L,13L,12L,11L,14L,17L,14L,15L,15L,16L,17L,14L,15L,15L,19L,20L,14L,15L,16L,23L,23L,18L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078640Inst : IEnumerable<long>
{
public static readonly long[] Value=A078640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078640.Bytes);
public long this[int i]=>Value[i];

public static A078640Inst Instance=new A078640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078641
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,2L,3L,4L,5L,4L,4L,3L,4L,5L,5L,5L,6L,5L,7L,6L,6L,7L,7L,8L,6L,6L,7L,7L,10L,7L,8L,8L,9L,10L,9L,9L,10L,11L,12L,11L,11L,10L,12L,15L,12L,11L,11L,10L,14L,13L,14L,14L,13L,16L,13L,13L,15L,14L,18L,13L,14L,15L,16L,22L,18L,17L,15L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078641Inst : IEnumerable<long>
{
public static readonly long[] Value=A078641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078641.Bytes);
public long this[int i]=>Value[i];

public static A078641Inst Instance=new A078641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078642
{
public static readonly long[] Value={ 4L,6L,10L,16L,26L,42L,68L,110L,178L,288L,466L,754L,1220L,1974L,3194L,5168L,8362L,13530L,21892L,35422L,57314L,92736L,150050L,242786L,392836L,635622L,1028458L,1664080L,2692538L,4356618L,7049156L,11405774L,18454930L,29860704L,48315634L,78176338L,126491972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078642Inst : IEnumerable<long>
{
public static readonly long[] Value=A078642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078642.Bytes);
public long this[int i]=>Value[i];

public static A078642Inst Instance=new A078642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078643
{
public static readonly long[] Value={ 2L,3L,5L,7L,8L,9L,11L,13L,14L,15L,18L,21L,22L,23L,24L,29L,34L,35L,36L,37L,39L,47L,55L,56L,57L,58L,60L,63L,76L,89L,90L,91L,92L,94L,97L,102L,123L,144L,145L,146L,147L,149L,152L,157L,165L,199L,233L,234L,235L,236L,238L,241L,246L,254L,267L,322L,377L,378L,379L,380L,382L,385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078643Inst : IEnumerable<long>
{
public static readonly long[] Value=A078643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078643.Bytes);
public long this[int i]=>Value[i];

public static A078643Inst Instance=new A078643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078660
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,2L,1L,2L,2L,3L,4L,4L,5L,6L,7L,8L,10L,11L,14L,15L,18L,20L,25L,27L,33L,35L,43L,47L,56L,62L,71L,80L,92L,103L,118L,132L,149L,168L,190L,212L,240L,267L,300L,336L,375L,419L,468L,521L,580L,646L,717L,798L,885L,981L,1087L,1204L,1332L,1473L,1626L,1797L,1980L,2187L,2405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078660Inst : IEnumerable<long>
{
public static readonly long[] Value=A078660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078660.Bytes);
public long this[int i]=>Value[i];

public static A078660Inst Instance=new A078660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078661
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,3L,2L,3L,3L,4L,5L,5L,6L,7L,8L,9L,11L,12L,15L,16L,19L,21L,26L,28L,34L,36L,44L,48L,57L,63L,72L,81L,93L,104L,119L,133L,150L,169L,191L,213L,241L,268L,301L,337L,376L,420L,469L,522L,581L,647L,718L,799L,886L,982L,1088L,1205L,1333L,1474L,1627L,1798L,1981L,2188L,2406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078661Inst : IEnumerable<long>
{
public static readonly long[] Value=A078661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078661.Bytes);
public long this[int i]=>Value[i];

public static A078661Inst Instance=new A078661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078662
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,8L,11L,14L,19L,24L,33L,39L,54L,69L,91L,122L,160L,206L,270L,346L,451L,575L,737L,962L,1260L,1635L,2110L,2712L,3491L,4564L,5942L,7773L,10195L,13357L,17441L,22920L,30093L,39658L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078662Inst : IEnumerable<long>
{
public static readonly long[] Value=A078662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078662.Bytes);
public long this[int i]=>Value[i];

public static A078662Inst Instance=new A078662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078663
{
public static readonly long[] Value={ 1L,3L,6L,10L,16L,24L,35L,48L,64L,82L,108L,136L,172L,210L,257L,305L,358L,415L,477L,546L,618L,695L,777L,864L,961L,1060L,1162L,1268L,1382L,1508L,1639L,1777L,1922L,2070L,2225L,2400L,2577L,2757L,2939L,3128L,3325L,3531L,3740L,3959L,4180L,4416L,4654L,4895L,5138L,5391L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078663Inst : IEnumerable<long>
{
public static readonly long[] Value=A078663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078663.Bytes);
public long this[int i]=>Value[i];

public static A078663Inst Instance=new A078663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078664
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,4L,2L,2L,5L,6L,4L,6L,9L,4L,2L,10L,2L,4L,4L,4L,12L,4L,4L,4L,2L,6L,8L,4L,8L,12L,2L,8L,4L,6L,4L,6L,4L,18L,8L,8L,2L,4L,4L,4L,4L,6L,8L,2L,6L,4L,8L,12L,8L,8L,4L,6L,4L,15L,4L,4L,6L,4L,6L,8L,4L,16L,15L,8L,2L,6L,12L,8L,2L,8L,9L,4L,16L,8L,4L,4L,4L,12L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078664Inst : IEnumerable<long>
{
public static readonly long[] Value=A078664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078664.Bytes);
public long this[int i]=>Value[i];

public static A078664Inst Instance=new A078664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078665
{
public static readonly long[] Value={ 1L,1L,2L,5L,47L,105L,1272L,8424L,55856L,388800L,6592492L,37965600L,1573051680L,10106845824L,145938179520L,2694653982720L,18948491739696L,267048208800000L,23293245955795200L,466687809894297600L,3372079713556377600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078665Inst : IEnumerable<long>
{
public static readonly long[] Value=A078665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078665.Bytes);
public long this[int i]=>Value[i];

public static A078665Inst Instance=new A078665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078666
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,3L,12L,19L,64L,155L,510L,1514L,5146L,16966L,58782L,203269L,716607L,2536201L,9062402L,32533568L,117498072L,426212952L,1553048548L,5681011890L,20858998805L,76850220654L,284057538480L,1053134292253L,3915683667721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078666Inst : IEnumerable<long>
{
public static readonly long[] Value=A078666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078666.Bytes);
public long this[int i]=>Value[i];

public static A078666Inst Instance=new A078666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078667
{
public static readonly long[] Value={ 72L,120L,168L,312L,408L,552L,600L,768L,792L,912L,1032L,1848L,2472L,3048L,3192L,3288L,3528L,3720L,4008L,4920L,5160L,5208L,5808L,5928L,6072L,6480L,6792L,6840L,6888L,7080L,7152L,7248L,7512L,7728L,7800L,8520L,8760L,9072L,11400L,11880L,11928L,12792L,13200L,13320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078667Inst : IEnumerable<long>
{
public static readonly long[] Value=A078667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078667.Bytes);
public long this[int i]=>Value[i];

public static A078667Inst Instance=new A078667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078668
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,127L,211L,271L,331L,397L,547L,631L,919L,1657L,1801L,1951L,2269L,2437L,4651L,8191L,14197L,61051L,131071L,371281L,524287L,543607L,723901L,1273609L,1803001L,2685817L,2861461L,5217031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078668Inst : IEnumerable<long>
{
public static readonly long[] Value=A078668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078668.Bytes);
public long this[int i]=>Value[i];

public static A078668Inst Instance=new A078668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078669
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,1L,4L,0L,0L,1L,2L,2L,2L,1L,2L,4L,3L,1L,5L,3L,2L,11L,5L,1L,2L,7L,8L,15L,8L,5L,11L,11L,10L,8L,7L,10L,16L,17L,15L,19L,12L,17L,18L,23L,27L,19L,24L,30L,18L,25L,40L,30L,23L,27L,29L,31L,33L,48L,48L,50L,30L,49L,51L,51L,58L,55L,67L,52L,59L,50L,52L,63L,78L,67L,92L,107L,94L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078669Inst : IEnumerable<long>
{
public static readonly long[] Value=A078669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078669.Bytes);
public long this[int i]=>Value[i];

public static A078669Inst Instance=new A078669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078670
{
public static readonly long[] Value={ 1L,1L,0L,4L,21L,169L,1504L,15755L,177333L,213789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078670Inst : IEnumerable<long>
{
public static readonly long[] Value=A078670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078670.Bytes);
public long this[int i]=>Value[i];

public static A078670Inst Instance=new A078670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078671
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,0L,1L,1L,2L,4L,9L,14L,21L,46L,112L,204L,374L,809L,1586L,3237L,6385L,12539L,25637L,50603L,100891L,20382L,40281L,81405L,161718L,323703L,645928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078671Inst : IEnumerable<long>
{
public static readonly long[] Value=A078671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078671.Bytes);
public long this[int i]=>Value[i];

public static A078671Inst Instance=new A078671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078672
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,6L,16L,59L,188L,685L,2412L,8825L,32110L,118505L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078672Inst : IEnumerable<long>
{
public static readonly long[] Value=A078672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078672.Bytes);
public long this[int i]=>Value[i];

public static A078672Inst Instance=new A078672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078673
{
public static readonly long[] Value={ 1L,1L,0L,2L,6L,38L,247L,1831L,15287L,142199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078673Inst : IEnumerable<long>
{
public static readonly long[] Value=A078673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078673.Bytes);
public long this[int i]=>Value[i];

public static A078673Inst Instance=new A078673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078674
{
public static readonly long[] Value={ 1L,3L,50L,2122L,155712L,17441962L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078674Inst : IEnumerable<long>
{
public static readonly long[] Value=A078674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078674.Bytes);
public long this[int i]=>Value[i];

public static A078674Inst Instance=new A078674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078675
{
public static readonly long[] Value={ 1L,2L,14L,322L,17314L,1573952L,210985926L,38916737688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078675Inst : IEnumerable<long>
{
public static readonly long[] Value=A078675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078675.Bytes);
public long this[int i]=>Value[i];

public static A078675Inst Instance=new A078675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078692
{
public static readonly long[] Value={ 1L,-2L,-2L,1L,1L,-4L,0L,10L,-4L,1L,1L,-6L,6L,19L,-24L,-24L,19L,6L,-6L,1L,1L,-8L,16L,20L,-80L,-8L,134L,-8L,-80L,20L,16L,-8L,1L,1L,-10L,30L,5L,-160L,128L,330L,-340L,-340L,330L,128L,-160L,5L,30L,-10L,1L,1L,-12L,48L,-34L,-240L,468L,399L,-1416L,-192L,2020L,-192L,-1416L,399L,468L,-240L,-34L,48L,-12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078692Inst : IEnumerable<long>
{
public static readonly long[] Value=A078692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078692.Bytes);
public long this[int i]=>Value[i];

public static A078692Inst Instance=new A078692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078693
{
public static readonly long[] Value={ 4L,217L,263L,590L,3385L,3644L,4612L,5949L,14357L,10229L,31545L,40933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078693Inst : IEnumerable<long>
{
public static readonly long[] Value=A078693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078693.Bytes);
public long this[int i]=>Value[i];

public static A078693Inst Instance=new A078693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078694
{
public static readonly long[] Value={ 5L,6L,7L,18L,21L,25L,26L,40L,41L,42L,49L,61L,62L,69L,70L,83L,91L,103L,104L,105L,110L,113L,127L,131L,132L,145L,148L,154L,167L,169L,174L,188L,189L,190L,196L,197L,210L,231L,237L,252L,258L,259L,272L,274L,279L,280L,294L,315L,323L,336L,339L,344L,357L,364L,365L,379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078694Inst : IEnumerable<long>
{
public static readonly long[] Value=A078694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078694.Bytes);
public long this[int i]=>Value[i];

public static A078694Inst Instance=new A078694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078695
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,13L,15L,28L,33L,40L,51L,56L,73L,80L,153L,158L,175L,254L,261L,388L,417L,514L,653L,910L,1563L,1576L,2097L,2294L,2527L,2564L,2583L,3224L,3265L,3296L,3949L,4052L,4411L,5424L,5825L,5938L,6171L,9140L,9157L,9614L,18771L,18794L,25051L,34448L,34495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078695Inst : IEnumerable<long>
{
public static readonly long[] Value=A078695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078695.Bytes);
public long this[int i]=>Value[i];

public static A078695Inst Instance=new A078695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078696
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,7L,9L,16L,25L,33L,58L,91L,120L,211L,271L,482L,753L,994L,1747L,2244L,3991L,5113L,9104L,14217L,18769L,32986L,51755L,68248L,120003L,154127L,274130L,428257L,565322L,993579L,1276240L,2269819L,2907939L,5177758L,8085697L,10674576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078696Inst : IEnumerable<long>
{
public static readonly long[] Value=A078696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078696.Bytes);
public long this[int i]=>Value[i];

public static A078696Inst Instance=new A078696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078697
{
public static readonly long[] Value={ 1L,2L,5L,8L,15L,24L,41L,66L,109L,176L,287L,464L,753L,1218L,1973L,3192L,5167L,8360L,13529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078697Inst : IEnumerable<long>
{
public static readonly long[] Value=A078697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078697.Bytes);
public long this[int i]=>Value[i];

public static A078697Inst Instance=new A078697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078698
{
public static readonly BigInteger[] Value={ 1L,2L,20L,396L,14976L,907200L,79315200L,9551001600L,1513528934400L,305106949324800L,76296489615360000L,BigInteger.Parse("23175289163980800000"),BigInteger.Parse("8404709419090575360000"),BigInteger.Parse("3587225703492542791680000"),BigInteger.Parse("1779970753996760560435200000"),BigInteger.Parse("1016036270188884847558656000000"),BigInteger.Parse("661106386935312429191528448000000") };
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
public class A078698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078698Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078698.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A078698.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078698Inst Instance=new A078698Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078699
{
public static readonly BigInteger[] Value={ 2L,11L,23L,373L,12671L,901273L,19472752251611L,BigInteger.Parse("53072032161200090602953513048447623"),BigInteger.Parse("5027153581127740201460650182713355379768873"),BigInteger.Parse("11604855412241025458500993236724193227031777965785837784548351709747881343573") };
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
public class A078699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078699Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078699.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A078699.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078699Inst Instance=new A078699Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078700
{
public static readonly BigInteger[] Value={ 1L,2L,6L,30L,192L,1560L,15120L,171360L,2217600L,32296320L,522547200L,9300614400L,180583603200L,3798482688000L,86044973414400L,2088355965696000L,54064489070592000L,1487129136869376000L,BigInteger.Parse("43312058119249920000") };
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
public class A078700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078700Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078700.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A078700.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078700Inst Instance=new A078700Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078701
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,3L,7L,1L,3L,5L,11L,3L,13L,7L,3L,1L,17L,3L,19L,5L,3L,11L,23L,3L,5L,13L,3L,7L,29L,3L,31L,1L,3L,17L,5L,3L,37L,19L,3L,5L,41L,3L,43L,11L,3L,23L,47L,3L,7L,5L,3L,13L,53L,3L,5L,7L,3L,29L,59L,3L,61L,31L,3L,1L,5L,3L,67L,17L,3L,5L,71L,3L,73L,37L,3L,19L,7L,3L,79L,5L,3L,41L,83L,3L,5L,43L,3L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078701Inst : IEnumerable<long>
{
public static readonly long[] Value=A078701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078701.Bytes);
public long this[int i]=>Value[i];

public static A078701Inst Instance=new A078701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078702
{
public static readonly long[] Value={ 1L,2L,13L,213L,7584L,454380L,39665160L,4775586480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078702Inst : IEnumerable<long>
{
public static readonly long[] Value=A078702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078702.Bytes);
public long this[int i]=>Value[i];

public static A078702Inst Instance=new A078702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078703
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,2L,2L,1L,3L,1L,1L,3L,1L,1L,2L,2L,2L,3L,1L,1L,2L,2L,2L,2L,1L,1L,4L,1L,2L,3L,1L,2L,2L,1L,1L,3L,3L,1L,2L,2L,1L,4L,1L,2L,3L,1L,2L,2L,1L,1L,4L,2L,1L,3L,2L,1L,4L,2L,1L,2L,1L,3L,3L,1L,2L,2L,2L,2L,2L,1L,1L,6L,2L,2L,2L,1L,2L,2L,2L,1L,4L,2L,1L,3L,1L,2L,4L,1L,1L,3L,2L,2L,4L,2L,2L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078703Inst : IEnumerable<long>
{
public static readonly long[] Value=A078703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078703.Bytes);
public long this[int i]=>Value[i];

public static A078703Inst Instance=new A078703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078704
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,3L,2L,3L,2L,2L,2L,4L,2L,4L,2L,3L,3L,4L,2L,4L,3L,4L,3L,5L,2L,5L,4L,4L,4L,4L,3L,6L,4L,4L,4L,6L,3L,6L,4L,4L,4L,6L,4L,6L,4L,5L,4L,7L,4L,6L,4L,6L,5L,7L,4L,7L,5L,6L,5L,6L,4L,8L,5L,6L,4L,8L,4L,8L,6L,6L,6L,7L,4L,8L,5L,7L,6L,9L,4L,8L,6L,7L,6L,9L,4L,8L,6L,7L,6L,8L,5L,9L,6L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078704Inst : IEnumerable<long>
{
public static readonly long[] Value=A078704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078704.Bytes);
public long this[int i]=>Value[i];

public static A078704Inst Instance=new A078704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078705
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,2L,3L,3L,4L,3L,5L,3L,4L,4L,5L,4L,6L,4L,6L,5L,6L,4L,7L,5L,6L,6L,7L,5L,8L,5L,7L,6L,7L,6L,9L,6L,7L,7L,9L,6L,9L,6L,9L,8L,8L,6L,11L,7L,9L,8L,9L,7L,10L,8L,10L,8L,9L,7L,12L,7L,9L,10L,11L,9L,12L,8L,11L,9L,12L,8L,13L,8L,10L,11L,11L,9L,12L,8L,13L,11L,11L,9L,14L,10L,11L,10L,13L,9L,15L,10L,12L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078705Inst : IEnumerable<long>
{
public static readonly long[] Value=A078705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078705.Bytes);
public long this[int i]=>Value[i];

public static A078705Inst Instance=new A078705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078706
{
public static readonly long[] Value={ 2L,3L,6L,6L,6L,6L,8L,10L,12L,12L,12L,14L,16L,18L,18L,18L,24L,32L,34L,36L,38L,42L,46L,48L,54L,56L,64L,68L,78L,90L,90L,94L,102L,114L,122L,124L,134L,144L,148L,150L,152L,160L,168L,170L,178L,182L,190L,192L,200L,216L,220L,222L,234L,234L,234L,246L,260L,264L,268L,270L,278L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078706Inst : IEnumerable<long>
{
public static readonly long[] Value=A078706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078706.Bytes);
public long this[int i]=>Value[i];

public static A078706Inst Instance=new A078706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078707
{
public static readonly long[] Value={ 1L,1L,2L,9L,16L,125L,216L,2401L,4096L,59049L,100000L,1771561L,2985984L,62748517L,105413504L,2562890625L,4294967296L,118587876497L,198359290368L,6131066257801L,10240000000000L,350277500542221L,584318301411328L,21914624432020321L,36520347436056576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078707Inst : IEnumerable<long>
{
public static readonly long[] Value=A078707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078707.Bytes);
public long this[int i]=>Value[i];

public static A078707Inst Instance=new A078707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078708
{
public static readonly long[] Value={ 1L,3L,3L,7L,6L,9L,8L,15L,9L,18L,12L,21L,14L,24L,18L,31L,18L,27L,20L,42L,24L,36L,24L,45L,31L,42L,27L,56L,30L,54L,32L,63L,36L,54L,48L,63L,38L,60L,42L,90L,42L,72L,44L,84L,54L,72L,48L,93L,57L,93L,54L,98L,54L,81L,72L,120L,60L,90L,60L,126L,62L,96L,72L,127L,84L,108L,68L,126L,72L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078708Inst : IEnumerable<long>
{
public static readonly long[] Value=A078708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078708.Bytes);
public long this[int i]=>Value[i];

public static A078708Inst Instance=new A078708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078709
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,3L,2L,3L,2L,5L,2L,6L,3L,3L,3L,8L,3L,9L,3L,5L,5L,11L,3L,8L,6L,6L,4L,14L,3L,15L,5L,8L,8L,8L,4L,18L,9L,9L,5L,20L,5L,21L,7L,7L,11L,23L,4L,16L,8L,12L,8L,26L,6L,13L,7L,14L,14L,29L,5L,30L,15L,10L,9L,16L,8L,33L,11L,17L,8L,35L,6L,36L,18L,12L,12L,19L,9L,39L,8L,16L,20L,41L,7L,21L,21L,21L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078709Inst : IEnumerable<long>
{
public static readonly long[] Value=A078709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078709.Bytes);
public long this[int i]=>Value[i];

public static A078709Inst Instance=new A078709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078710
{
public static readonly long[] Value={ 0L,0L,0L,4L,1L,12L,2L,7L,3L,40L,4L,60L,9L,17L,8L,112L,9L,144L,13L,35L,27L,220L,14L,104L,41L,60L,25L,364L,23L,420L,34L,93L,75L,166L,30L,612L,97L,133L,45L,760L,47L,840L,67L,124L,147L,1012L,50L,500L,93L,235L,96L,1300L,78L,410L,91L,297L,243L,1624L,69L,1740L,281L,254L,130L,576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078710Inst : IEnumerable<long>
{
public static readonly long[] Value=A078710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078710.Bytes);
public long this[int i]=>Value[i];

public static A078710Inst Instance=new A078710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078711
{
public static readonly long[] Value={ 1L,2L,3L,1L,2L,1L,1L,2L,3L,1L,2L,2L,1L,2L,3L,1L,2L,1L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,1L,1L,2L,3L,1L,2L,2L,1L,2L,3L,1L,2L,1L,1L,2L,3L,1L,2L,1L,1L,2L,3L,1L,2L,1L,1L,2L,3L,1L,2L,2L,1L,2L,3L,1L,2L,1L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,1L,1L,2L,3L,1L,2L,2L,1L,2L,3L,1L,2L,1L,1L,2L,3L,1L,2L,2L,1L,2L,3L,1L,2L,1L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078711Inst : IEnumerable<long>
{
public static readonly long[] Value=A078711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078711.Bytes);
public long this[int i]=>Value[i];

public static A078711Inst Instance=new A078711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078712
{
public static readonly long[] Value={ -3L,1L,-1L,-2L,3L,-4L,2L,1L,-5L,7L,-6L,1L,6L,-12L,13L,-7L,-5L,18L,-25L,20L,-2L,-23L,43L,-45L,22L,21L,-66L,88L,-67L,1L,87L,-154L,155L,-68L,-86L,241L,-309L,223L,18L,-327L,550L,-532L,205L,345L,-877L,1082L,-737L,-140L,1222L,-1959L,1819L,-597L,-1362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078712Inst : IEnumerable<long>
{
public static readonly long[] Value=A078712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078712.Bytes);
public long this[int i]=>Value[i];

public static A078712Inst Instance=new A078712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078713
{
public static readonly long[] Value={ 0L,1L,4L,5L,16L,11L,36L,21L,40L,35L,100L,43L,144L,75L,108L,85L,256L,101L,324L,131L,216L,203L,484L,171L,416L,291L,364L,259L,784L,273L,900L,341L,552L,515L,804L,385L,1296L,651L,780L,519L,1600L,551L,1764L,659L,960L,971L,2116L,683L,1800L,885L,1356L,931L,2704L,911L,1988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078713Inst : IEnumerable<long>
{
public static readonly long[] Value=A078713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078713.Bytes);
public long this[int i]=>Value[i];

public static A078713Inst Instance=new A078713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078714
{
public static readonly long[] Value={ 1L,4L,16L,34L,142L,79L,1276L,289L,394L,709L,103336L,1024L,930022L,6379L,3544L,2599L,75331762L,5119L,677985856L,9214L,31894L,516679L,54916854316L,12994L,88594L,4650109L,30319L,82924L,40034386796182L,46069L,360309481165636L,33784L,2583394L,376658809L,797344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078714Inst : IEnumerable<long>
{
public static readonly long[] Value=A078714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078714.Bytes);
public long this[int i]=>Value[i];

public static A078714Inst Instance=new A078714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078715
{
public static readonly long[] Value={ 1L,2L,3L,5L,10L,19L,20L,30L,50L,100L,190L,200L,300L,500L,1000L,1900L,2000L,3000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078715Inst : IEnumerable<long>
{
public static readonly long[] Value=A078715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078715.Bytes);
public long this[int i]=>Value[i];

public static A078715Inst Instance=new A078715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078716
{
public static readonly long[] Value={ 1L,5L,2L,6L,3L,7L,4L,8L,5L,1L,5L,2L,6L,3L,7L,4L,8L,5L,1L,5L,2L,6L,3L,7L,4L,8L,5L,1L,5L,2L,6L,3L,7L,4L,8L,5L,1L,5L,2L,6L,3L,7L,4L,8L,5L,1L,5L,2L,6L,3L,7L,4L,8L,5L,1L,5L,2L,6L,3L,7L,4L,8L,5L,1L,5L,2L,6L,3L,7L,4L,8L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078716Inst : IEnumerable<long>
{
public static readonly long[] Value=A078716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078716.Bytes);
public long this[int i]=>Value[i];

public static A078716Inst Instance=new A078716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078717
{
public static readonly long[] Value={ 1L,5L,25L,121L,589L,2821L,13565L,64661L,308981L,1468313L,6989025L,33140457L,157329085L,744818613L,3529191009L,16686979329L,78955042017L,372953947349L,1762672203269L,8319554639789L,39285015083693L,185296997240401L,874331369198569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078717Inst : IEnumerable<long>
{
public static readonly long[] Value=A078717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078717.Bytes);
public long this[int i]=>Value[i];

public static A078717Inst Instance=new A078717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078718
{
public static readonly long[] Value={ 0L,1L,3L,-5L,14L,-45L,154L,-546L,1980L,-7293L,27170L,-102102L,386308L,-1469650L,5616324L,-21544100L,82907640L,-319929885L,1237518450L,-4796857230L,18627909300L,-72457790790L,282257178060L,-1100982015900L,4299680491080L,-16809921068850L,65785111513524L,-257683159276956L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078718Inst : IEnumerable<long>
{
public static readonly long[] Value=A078718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078718.Bytes);
public long this[int i]=>Value[i];

public static A078718Inst Instance=new A078718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078719
{
public static readonly long[] Value={ 1L,1L,3L,1L,2L,3L,6L,1L,7L,2L,5L,3L,3L,6L,6L,1L,4L,7L,7L,2L,2L,5L,5L,3L,8L,3L,42L,6L,6L,6L,40L,1L,9L,4L,4L,7L,7L,7L,12L,2L,41L,2L,10L,5L,5L,5L,39L,3L,8L,8L,8L,3L,3L,42L,42L,6L,11L,6L,11L,6L,6L,40L,40L,1L,9L,9L,9L,4L,4L,4L,38L,7L,43L,7L,4L,7L,7L,12L,12L,2L,7L,41L,41L,2L,2L,10L,10L,5L,10L,5L,34L,5L,5L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078719Inst : IEnumerable<long>
{
public static readonly long[] Value=A078719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078719.Bytes);
public long this[int i]=>Value[i];

public static A078719Inst Instance=new A078719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078720
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,1L,3L,1L,2L,2L,2L,2L,2L,2L,4L,2L,2L,2L,3L,3L,2L,2L,2L,2L,2L,1L,2L,2L,2L,1L,5L,2L,2L,2L,2L,2L,2L,1L,3L,1L,3L,2L,2L,2L,2L,1L,3L,2L,2L,2L,3L,3L,1L,1L,2L,2L,2L,2L,2L,2L,1L,1L,6L,2L,2L,2L,2L,2L,2L,1L,2L,1L,2L,2L,2L,2L,2L,2L,4L,2L,1L,1L,4L,4L,2L,2L,2L,2L,2L,1L,2L,2L,1L,1L,3L,1L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078720Inst : IEnumerable<long>
{
public static readonly long[] Value=A078720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078720.Bytes);
public long this[int i]=>Value[i];

public static A078720Inst Instance=new A078720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078721
{
public static readonly long[] Value={ 2L,3L,7L,17L,31L,53L,79L,109L,157L,199L,263L,331L,401L,479L,577L,661L,773L,887L,1021L,1153L,1297L,1459L,1609L,1787L,1993L,2161L,2377L,2609L,2797L,3041L,3313L,3547L,3803L,4079L,4363L,4663L,4987L,5309L,5647L,5953L,6311L,6689L,7027L,7481L,7841L,8263L,8689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078721Inst : IEnumerable<long>
{
public static readonly long[] Value=A078721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078721.Bytes);
public long this[int i]=>Value[i];

public static A078721Inst Instance=new A078721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078722
{
public static readonly long[] Value={ 3L,5L,11L,19L,37L,59L,83L,113L,163L,211L,269L,337L,409L,487L,587L,673L,787L,907L,1031L,1163L,1301L,1471L,1613L,1789L,1997L,2179L,2381L,2617L,2801L,3049L,3319L,3557L,3821L,4091L,4373L,4673L,4993L,5323L,5651L,5981L,6317L,6691L,7039L,7487L,7853L,8269L,8693L,9109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078722Inst : IEnumerable<long>
{
public static readonly long[] Value=A078722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078722.Bytes);
public long this[int i]=>Value[i];

public static A078722Inst Instance=new A078722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078723
{
public static readonly long[] Value={ 3L,11L,23L,43L,71L,103L,149L,193L,251L,313L,389L,463L,569L,653L,761L,881L,1013L,1129L,1289L,1451L,1601L,1777L,1979L,2143L,2357L,2591L,2789L,3023L,3301L,3539L,3793L,4057L,4349L,4651L,4969L,5297L,5639L,5927L,6299L,6673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078723Inst : IEnumerable<long>
{
public static readonly long[] Value=A078723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078723.Bytes);
public long this[int i]=>Value[i];

public static A078723Inst Instance=new A078723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078804
{
public static readonly long[] Value={ 1L,2L,0L,3L,1L,1L,4L,3L,2L,0L,5L,6L,4L,2L,1L,6L,10L,8L,6L,2L,0L,7L,15L,15L,13L,6L,3L,1L,8L,21L,26L,25L,16L,9L,2L,0L,9L,28L,42L,45L,36L,22L,9L,4L,1L,10L,36L,64L,77L,72L,50L,28L,12L,2L,0L,11L,45L,93L,126L,133L,106L,70L,34L,13L,5L,1L,12L,55L,130L,198L,232L,210L,156L,90L,44L,15L,2L,0L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078804Inst : IEnumerable<long>
{
public static readonly long[] Value=A078804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078804.Bytes);
public long this[int i]=>Value[i];

public static A078804Inst Instance=new A078804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078805
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,0L,1L,3L,1L,1L,1L,4L,3L,2L,0L,1L,5L,6L,4L,2L,1L,1L,6L,10L,8L,6L,2L,0L,1L,7L,15L,15L,13L,6L,3L,1L,1L,8L,21L,26L,25L,16L,9L,2L,0L,1L,9L,28L,42L,45L,36L,22L,9L,4L,1L,1L,10L,36L,64L,77L,72L,50L,28L,12L,2L,0L,1L,11L,45L,93L,126L,133L,106L,70L,34L,13L,5L,1L,1L,12L,55L,130L,198L,232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078805Inst : IEnumerable<long>
{
public static readonly long[] Value=A078805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078805.Bytes);
public long this[int i]=>Value[i];

public static A078805Inst Instance=new A078805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078806
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,1L,2L,1L,0L,1L,3L,2L,2L,1L,1L,4L,4L,4L,1L,0L,1L,5L,7L,7L,4L,3L,1L,1L,6L,11L,12L,10L,6L,1L,0L,1L,7L,16L,20L,20L,13L,7L,4L,1L,1L,8L,22L,32L,36L,28L,19L,8L,1L,0L,1L,9L,29L,49L,61L,56L,42L,22L,11L,5L,1L,1L,10L,37L,72L,99L,104L,86L,56L,31L,10L,1L,0L,1L,11L,46L,102L,155L,182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078806Inst : IEnumerable<long>
{
public static readonly long[] Value=A078806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078806.Bytes);
public long this[int i]=>Value[i];

public static A078806Inst Instance=new A078806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078807
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,1L,2L,1L,1L,0L,0L,1L,2L,2L,2L,1L,1L,3L,3L,3L,2L,1L,0L,0L,1L,3L,4L,5L,4L,3L,1L,1L,4L,6L,7L,7L,5L,3L,1L,0L,0L,1L,4L,7L,10L,11L,10L,7L,4L,1L,1L,5L,10L,14L,17L,16L,13L,8L,4L,1L,0L,0L,1L,5L,11L,18L,24L,26L,24L,18L,11L,5L,1L,1L,6L,15L,25L,35L,40L,39L,32L,22L,12L,5L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078807Inst : IEnumerable<long>
{
public static readonly long[] Value=A078807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078807.Bytes);
public long this[int i]=>Value[i];

public static A078807Inst Instance=new A078807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078808
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,2L,1L,0L,1L,2L,2L,2L,1L,0L,0L,0L,1L,2L,3L,3L,3L,1L,0L,1L,3L,4L,5L,4L,3L,1L,0L,0L,0L,1L,3L,5L,7L,7L,6L,4L,1L,0L,1L,4L,7L,10L,11L,10L,7L,4L,1L,0L,0L,0L,1L,4L,8L,13L,16L,17L,14L,10L,5L,1L,0L,1L,5L,11L,18L,24L,26L,24L,18L,11L,5L,1L,0L,0L,0L,1L,5L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078808Inst : IEnumerable<long>
{
public static readonly long[] Value=A078808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078808.Bytes);
public long this[int i]=>Value[i];

public static A078808Inst Instance=new A078808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078809
{
public static readonly long[] Value={ 3L,4L,3L,6L,4L,6L,4L,4L,8L,4L,4L,8L,6L,6L,8L,12L,7L,4L,12L,6L,5L,4L,4L,6L,8L,8L,12L,4L,16L,4L,4L,8L,15L,12L,8L,12L,8L,8L,10L,18L,8L,14L,8L,12L,4L,4L,9L,12L,8L,6L,20L,8L,4L,12L,8L,16L,4L,6L,8L,18L,18L,4L,16L,12L,15L,4L,12L,12L,8L,6L,6L,8L,8L,4L,4L,4L,8L,10L,12L,24L,8L,20L,6L,9L,4L,4L,8L,16L,8L,4L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078809Inst : IEnumerable<long>
{
public static readonly long[] Value=A078809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078809.Bytes);
public long this[int i]=>Value[i];

public static A078809Inst Instance=new A078809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078810
{
public static readonly long[] Value={ 1L,6L,44L,31L,3L,206L,25L,156L,155L,1251L,101L,1028844L,87L,9082L,901L,7801L,69L,687177L,63L,622551L,6534L,550555L,535L,51445051L,61L,46664L,51582L,44540815L,445L,411870051L,423L,390051L,397373L,358042L,44958L,34296978288L,371L,32089L,336767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078810Inst : IEnumerable<long>
{
public static readonly long[] Value=A078810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078810.Bytes);
public long this[int i]=>Value[i];

public static A078810Inst Instance=new A078810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078811
{
public static readonly BigInteger[] Value={ 1L,5L,4L,33L,2468L,25L,176366L,1697L,13842L,1379L,11223344464L,13093L,949667608470093L,9707938L,8318740876L,8486944572L,BigInteger.Parse("7262164064771301847951"),87284065L,BigInteger.Parse("64977257421637963902716694"),689555658595L,5932429101505580572L };
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
public class A078811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078811Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078811.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A078811.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078811Inst Instance=new A078811Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078812
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,1L,4L,10L,6L,1L,5L,20L,21L,8L,1L,6L,35L,56L,36L,10L,1L,7L,56L,126L,120L,55L,12L,1L,8L,84L,252L,330L,220L,78L,14L,1L,9L,120L,462L,792L,715L,364L,105L,16L,1L,10L,165L,792L,1716L,2002L,1365L,560L,136L,18L,1L,11L,220L,1287L,3432L,5005L,4368L,2380L,816L,171L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078812Inst : IEnumerable<long>
{
public static readonly long[] Value=A078812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078812.Bytes);
public long this[int i]=>Value[i];

public static A078812Inst Instance=new A078812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078813
{
public static readonly long[] Value={ 41L,220217L,596275259857L,17L,31L,7583L,167988019L,1898431L,19L,37L,8747L,433L,23L,4647535350279428239L,1637L,29L,1997L,569L,383L,71L,17L,179L,683592593118601L,601L,1259L,109L,47L,19L,83L,367L,43L,151L,8633431L,103L,20859069935591L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078813Inst : IEnumerable<long>
{
public static readonly long[] Value=A078813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078813.Bytes);
public long this[int i]=>Value[i];

public static A078813Inst Instance=new A078813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078814
{
public static readonly long[] Value={ 17L,1433L,499679L,1279L,31L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078814Inst : IEnumerable<long>
{
public static readonly long[] Value=A078814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078814.Bytes);
public long this[int i]=>Value[i];

public static A078814Inst Instance=new A078814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078815
{
public static readonly long[] Value={ 1L,25L,121L,16L,121L,1089L,121L,1089L,1089L,1156L,1089L,1089L,1089L,1089L,1024L,1089L,10404L,1089L,1024L,1089L,1024L,10404L,10404L,10404L,10404L,10404L,10404L,10404L,1024L,10404L,10404L,1024L,10404L,1024L,1024L,10404L,1024L,1024L,1024L,1024L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078815Inst : IEnumerable<long>
{
public static readonly long[] Value=A078815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078815.Bytes);
public long this[int i]=>Value[i];

public static A078815Inst Instance=new A078815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078816
{
public static readonly long[] Value={ 6L,12L,19L,25L,33L,39L,46L,52L,60L,66L,72L,79L,85L,93L,99L,102L,112L,120L,126L,132L,139L,145L,153L,159L,166L,172L,180L,186L,192L,199L,205L,206L,219L,226L,232L,240L,246L,252L,259L,265L,273L,279L,286L,292L,300L,306L,313L,309L,326L,333L,339L,346L,352L,360L,366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078816Inst : IEnumerable<long>
{
public static readonly long[] Value=A078816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078816.Bytes);
public long this[int i]=>Value[i];

public static A078816Inst Instance=new A078816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078817
{
public static readonly long[] Value={ 1L,3L,1L,10L,4L,2L,35L,15L,9L,5L,126L,56L,36L,24L,14L,462L,210L,140L,100L,70L,42L,1716L,792L,540L,400L,300L,216L,132L,6435L,3003L,2079L,1575L,1225L,945L,693L,429L,24310L,11440L,8008L,6160L,4900L,3920L,3080L,2288L,1430L,92378L,43758L,30888L,24024L,19404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078817Inst : IEnumerable<long>
{
public static readonly long[] Value=A078817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078817.Bytes);
public long this[int i]=>Value[i];

public static A078817Inst Instance=new A078817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078818
{
public static readonly long[] Value={ 10L,15L,36L,100L,300L,945L,3080L,10296L,35100L,121550L,426360L,1511640L,5408312L,19501125L,70794000L,258529200L,949074300L,3500409330L,12964479000L,48198087000L,179799820200L,672822343050L,2524918756464L,9500112378000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078818Inst : IEnumerable<long>
{
public static readonly long[] Value=A078818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078818.Bytes);
public long this[int i]=>Value[i];

public static A078818Inst Instance=new A078818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078819
{
public static readonly long[] Value={ 35L,56L,140L,400L,1225L,3920L,12936L,43680L,150150L,523600L,1847560L,6584032L,23661365L,85652000L,312018000L,1142971200L,4207562730L,15557374800L,57750861000L,215145084000L,804104751450L,3014244096864L,11329763650800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078819Inst : IEnumerable<long>
{
public static readonly long[] Value=A078819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078819.Bytes);
public long this[int i]=>Value[i];

public static A078819Inst Instance=new A078819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078932
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,6L,9L,13L,20L,30L,44L,66L,99L,147L,219L,327L,487L,726L,1083L,1614L,2406L,3588L,5349L,7974L,11889L,17725L,26426L,39399L,58739L,87573L,130563L,194655L,290208L,432669L,645062L,961716L,1433814L,2137659L,3187014L,4751490L,7083951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078932Inst : IEnumerable<long>
{
public static readonly long[] Value=A078932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078932.Bytes);
public long this[int i]=>Value[i];

public static A078932Inst Instance=new A078932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078933
{
public static readonly long[] Value={ 2L,5234L,8158L,93844L,367806L,421351L,720114L,939787L,28187351L,110781386L,154319269L,384242766L,390620082L,3790689201L,65589428378L,952764389446L,12438517260105L,35495694227489L,53197086958290L,5853886516781223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078933Inst : IEnumerable<long>
{
public static readonly long[] Value=A078933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078933.Bytes);
public long this[int i]=>Value[i];

public static A078933Inst Instance=new A078933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078934
{
public static readonly long[] Value={ 2L,4L,5L,7L,8L,10L,11L,12L,14L,16L,17L,19L,20L,22L,22L,25L,26L,28L,29L,29L,32L,34L,35L,35L,38L,40L,39L,43L,44L,46L,47L,46L,50L,52L,51L,55L,56L,58L,56L,61L,62L,64L,65L,63L,68L,70L,71L,70L,70L,76L,73L,79L,80L,78L,79L,80L,86L,88L,89L,91L,92L,94L,90L,92L,94L,100L,101L,97L,104L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078934Inst : IEnumerable<long>
{
public static readonly long[] Value=A078934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078934.Bytes);
public long this[int i]=>Value[i];

public static A078934Inst Instance=new A078934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078935
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,6L,5L,5L,6L,6L,7L,7L,10L,8L,9L,9L,10L,14L,11L,11L,12L,15L,13L,13L,18L,14L,15L,15L,16L,22L,17L,17L,21L,18L,19L,19L,26L,20L,21L,21L,22L,30L,23L,23L,24L,28L,35L,25L,34L,26L,27L,33L,35L,38L,29L,29L,30L,30L,31L,31L,42L,40L,39L,33L,34L,46L,35L,35L,36L,36L,37L,37L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078935Inst : IEnumerable<long>
{
public static readonly long[] Value=A078935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078935.Bytes);
public long this[int i]=>Value[i];

public static A078935Inst Instance=new A078935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078936
{
public static readonly long[] Value={ 1L,3L,3L,5L,5L,7L,7L,6L,9L,11L,11L,13L,13L,15L,12L,17L,17L,19L,19L,15L,21L,23L,23L,20L,25L,27L,21L,29L,29L,31L,31L,24L,33L,35L,30L,37L,37L,39L,30L,41L,41L,43L,43L,33L,45L,47L,47L,42L,35L,51L,39L,53L,53L,45L,44L,42L,57L,59L,59L,61L,61L,63L,48L,52L,55L,67L,67L,51L,69L,71L,71L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078936Inst : IEnumerable<long>
{
public static readonly long[] Value=A078936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078936.Bytes);
public long this[int i]=>Value[i];

public static A078936Inst Instance=new A078936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078937
{
public static readonly long[] Value={ 1L,2L,1L,6L,4L,1L,22L,18L,6L,1L,94L,88L,36L,8L,1L,454L,470L,220L,60L,10L,1L,2430L,2724L,1410L,440L,90L,12L,1L,14214L,17010L,9534L,3290L,770L,126L,14L,1L,89918L,113712L,68050L,25424L,6580L,1232L,168L,16L,1L,610182L,809262L,511704L,204120L,57204L,11844L,1848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078937Inst : IEnumerable<long>
{
public static readonly long[] Value=A078937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078937.Bytes);
public long this[int i]=>Value[i];

public static A078937Inst Instance=new A078937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078938
{
public static readonly long[] Value={ 1L,3L,1L,12L,6L,1L,57L,36L,9L,1L,309L,228L,72L,12L,1L,1866L,1545L,570L,120L,15L,1L,12351L,11196L,4635L,1140L,180L,18L,1L,88563L,86457L,39186L,10815L,1995L,252L,21L,1L,681870L,708504L,345828L,104496L,21630L,3192L,336L,24L,1L,5597643L,6136830L,3188268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078938Inst : IEnumerable<long>
{
public static readonly long[] Value=A078938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078938.Bytes);
public long this[int i]=>Value[i];

public static A078938Inst Instance=new A078938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078939
{
public static readonly long[] Value={ 1L,4L,1L,20L,8L,1L,116L,60L,12L,1L,756L,464L,120L,16L,1L,5428L,3780L,1160L,200L,20L,1L,42356L,32568L,11340L,2320L,300L,24L,1L,355636L,296492L,113988L,26460L,4060L,420L,28L,1L,3188340L,2845088L,1185968L,303968L,52920L,6496L,560L,32L,1L,30333492L,28695060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078939Inst : IEnumerable<long>
{
public static readonly long[] Value=A078939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078939.Bytes);
public long this[int i]=>Value[i];

public static A078939Inst Instance=new A078939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078940
{
public static readonly long[] Value={ 1L,4L,19L,103L,622L,4117L,29521L,227290L,1865881L,16239523L,149142952L,1439618143L,14555631781L,153700654036L,1690684883191L,19328770917499L,229203640111870L,2814018686591089L,35711716110387589L,467766675528462562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078940Inst : IEnumerable<long>
{
public static readonly long[] Value=A078940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078940.Bytes);
public long this[int i]=>Value[i];

public static A078940Inst Instance=new A078940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078941
{
public static readonly long[] Value={ 1L,4L,6L,8L,10L,12L,14L,15L,17L,18L,19L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078941Inst : IEnumerable<long>
{
public static readonly long[] Value=A078941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078941.Bytes);
public long this[int i]=>Value[i];

public static A078941Inst Instance=new A078941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078942
{
public static readonly long[] Value={ 1L,4L,6L,8L,10L,12L,14L,15L,17L,18L,19L,21L,22L,23L,24L,26L,28L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078942Inst : IEnumerable<long>
{
public static readonly long[] Value=A078942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078942.Bytes);
public long this[int i]=>Value[i];

public static A078942Inst Instance=new A078942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078943
{
public static readonly long[] Value={ 1L,2L,4L,7L,3L,8L,14L,21L,13L,22L,12L,23L,11L,24L,10L,25L,9L,26L,44L,63L,43L,64L,42L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078943Inst : IEnumerable<long>
{
public static readonly long[] Value=A078943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078943.Bytes);
public long this[int i]=>Value[i];

public static A078943Inst Instance=new A078943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078944
{
public static readonly long[] Value={ 1L,4L,20L,116L,756L,5428L,42356L,355636L,3188340L,30333492L,304716148L,3218555700L,35618229364L,411717043252L,4957730174836L,62045057731892L,805323357485684L,10820999695801908L,150271018666120564L,2153476417340487476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078944Inst : IEnumerable<long>
{
public static readonly long[] Value=A078944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078944.Bytes);
public long this[int i]=>Value[i];

public static A078944Inst Instance=new A078944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078945
{
public static readonly long[] Value={ 1L,5L,29L,189L,1357L,10589L,88909L,797085L,7583373L,76179037L,804638925L,8904557341L,102929260813L,1239432543709L,15511264432973L,201330839371421L,2705249923950477L,37567754666530141L,538369104335121869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078945Inst : IEnumerable<long>
{
public static readonly long[] Value=A078945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078945.Bytes);
public long this[int i]=>Value[i];

public static A078945Inst Instance=new A078945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078946
{
public static readonly long[] Value={ 17L,227L,1277L,1607L,3527L,3917L,4637L,4787L,27737L,38447L,39227L,44267L,71327L,97367L,99707L,113147L,122027L,122387L,124337L,165707L,183497L,187127L,191447L,197957L,198827L,275447L,290657L,312197L,317957L,347057L,349397L,416387L,418337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078946Inst : IEnumerable<long>
{
public static readonly long[] Value=A078946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078946.Bytes);
public long this[int i]=>Value[i];

public static A078946Inst Instance=new A078946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078947
{
public static readonly long[] Value={ 41L,641L,1091L,4001L,9461L,26681L,26711L,44531L,79811L,103991L,110921L,112571L,172421L,223241L,276821L,289841L,290021L,317771L,373181L,381371L,434921L,450881L,493121L,602081L,678761L,788351L,834131L,907211L,974861L,1076501L,1081121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078947Inst : IEnumerable<long>
{
public static readonly long[] Value=A078947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078947.Bytes);
public long this[int i]=>Value[i];

public static A078947Inst Instance=new A078947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078948
{
public static readonly long[] Value={ 29L,59L,269L,1289L,2129L,2789L,5639L,8999L,13679L,14549L,18119L,36779L,62129L,75989L,80669L,83219L,88799L,93479L,113159L,115769L,124769L,132749L,150209L,160079L,163979L,203309L,207509L,223829L,228509L,278489L,282089L,284729L,298679L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078948Inst : IEnumerable<long>
{
public static readonly long[] Value=A078948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078948.Bytes);
public long this[int i]=>Value[i];

public static A078948Inst Instance=new A078948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078949
{
public static readonly long[] Value={ 71L,431L,2339L,2381L,5849L,6959L,27791L,32561L,41609L,45119L,46439L,48479L,51419L,54401L,63599L,78779L,81551L,106859L,115319L,130631L,138569L,143501L,153269L,166601L,183569L,196169L,204359L,229751L,246929L,266081L,279119L,321311L,326999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078949Inst : IEnumerable<long>
{
public static readonly long[] Value=A078949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078949.Bytes);
public long this[int i]=>Value[i];

public static A078949Inst Instance=new A078949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078950
{
public static readonly long[] Value={ 149L,599L,27059L,31319L,42179L,65699L,75209L,85829L,87539L,92219L,135599L,170759L,205949L,221069L,249419L,274829L,278609L,280589L,287849L,302579L,307259L,308309L,350429L,355499L,398339L,406499L,416399L,422549L,541529L,566549L,573479L,585839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078950Inst : IEnumerable<long>
{
public static readonly long[] Value=A078950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078950.Bytes);
public long this[int i]=>Value[i];

public static A078950Inst Instance=new A078950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078951
{
public static readonly long[] Value={ 3299L,5099L,6359L,19469L,30089L,53609L,63689L,71339L,77549L,80909L,105359L,119549L,152939L,186869L,292469L,302969L,344249L,348239L,408209L,415949L,652739L,707669L,737039L,792689L,818339L,831539L,852749L,886979L,910199L,974969L,1072829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078951Inst : IEnumerable<long>
{
public static readonly long[] Value=A078951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078951.Bytes);
public long this[int i]=>Value[i];

public static A078951Inst Instance=new A078951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078952
{
public static readonly long[] Value={ 13L,37L,223L,1087L,1423L,1483L,2683L,4783L,20743L,27733L,29017L,33343L,33613L,35527L,42457L,44263L,45817L,55813L,93487L,108877L,110917L,113143L,118897L,151237L,165703L,187123L,198823L,203653L,205417L,221713L,234187L,234457L,258607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078952Inst : IEnumerable<long>
{
public static readonly long[] Value=A078952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078952.Bytes);
public long this[int i]=>Value[i];

public static A078952Inst Instance=new A078952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078953
{
public static readonly long[] Value={ 67L,2377L,21487L,31177L,65167L,67927L,81547L,139297L,166597L,178597L,185527L,305017L,305407L,321817L,341947L,390487L,427417L,448867L,547357L,600877L,635347L,668527L,693727L,697507L,752287L,764887L,783787L,812347L,819487L,877867L,1196857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078953Inst : IEnumerable<long>
{
public static readonly long[] Value=A078953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078953.Bytes);
public long this[int i]=>Value[i];

public static A078953Inst Instance=new A078953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078954
{
public static readonly long[] Value={ 1597L,3907L,12097L,12907L,38317L,58897L,65827L,90007L,90187L,112237L,129277L,134077L,140407L,176317L,204427L,336757L,374977L,390097L,394717L,435637L,486667L,538147L,543997L,588937L,618577L,678637L,702337L,922627L,990277L,996157L,1086247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078954Inst : IEnumerable<long>
{
public static readonly long[] Value=A078954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078954.Bytes);
public long this[int i]=>Value[i];

public static A078954Inst Instance=new A078954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078955
{
public static readonly long[] Value={ 19L,1279L,1609L,2539L,3529L,4639L,5839L,15259L,19069L,32359L,71329L,75979L,88789L,97369L,112909L,113149L,130639L,135589L,138559L,191449L,229759L,246919L,290659L,312199L,346429L,349369L,357649L,384469L,396619L,416389L,418339L,421699L,433249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078955Inst : IEnumerable<long>
{
public static readonly long[] Value=A078955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078955.Bytes);
public long this[int i]=>Value[i];

public static A078955Inst Instance=new A078955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078956
{
public static readonly long[] Value={ 43L,163L,643L,1213L,2953L,4003L,7573L,11923L,14533L,25453L,26683L,26713L,29863L,41593L,48523L,61543L,68473L,150193L,151153L,172423L,206803L,227593L,290023L,302563L,338563L,343813L,346543L,428023L,527053L,529033L,540373L,547483L,551713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078956Inst : IEnumerable<long>
{
public static readonly long[] Value=A078956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078956.Bytes);
public long this[int i]=>Value[i];

public static A078956Inst Instance=new A078956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078957
{
public static readonly long[] Value={ 12637L,14737L,15787L,17467L,78787L,95257L,104707L,120997L,154057L,243517L,250027L,252877L,351037L,357667L,443227L,496477L,501187L,593497L,624787L,696607L,750787L,917827L,949957L,1003087L,1025257L,1104097L,1109887L,1260877L,1279657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078957Inst : IEnumerable<long>
{
public static readonly long[] Value=A078957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078957.Bytes);
public long this[int i]=>Value[i];

public static A078957Inst Instance=new A078957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078958
{
public static readonly long[] Value={ 1601L,3911L,12101L,14621L,32051L,68891L,122021L,191441L,258101L,259151L,276581L,278801L,305471L,347051L,390101L,394721L,418331L,419591L,421691L,470201L,482501L,509681L,678641L,683471L,832361L,844421L,914351L,929051L,977351L,997091L,1043831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078958Inst : IEnumerable<long>
{
public static readonly long[] Value=A078958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078958.Bytes);
public long this[int i]=>Value[i];

public static A078958Inst Instance=new A078958Inst();

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