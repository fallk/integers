using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A087672
{
public static readonly long[] Value={ 891L,1485L,1584L,2376L,3168L,4455L,4752L,89991L,95931L,101871L,107811L,149985L,155925L,159984L,161865L,167805L,167904L,175824L,183744L,191664L,239976L,247896L,255816L,263736L,271656L,319968L,327888L,335808L,343728L,351648L,449955L,479655L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087672Inst : IEnumerable<long>
{
public static readonly long[] Value=A087672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087672.Bytes);
public long this[int i]=>Value[i];

public static A087672Inst Instance=new A087672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087671
{
public static readonly long[] Value={ 2L,4L,6L,8L,8L,27L,10L,26L,18L,43L,10L,146L,14L,59L,107L,114L,12L,184L,14L,406L,142L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087671Inst : IEnumerable<long>
{
public static readonly long[] Value=A087671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087671.Bytes);
public long this[int i]=>Value[i];

public static A087671Inst Instance=new A087671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087670
{
public static readonly long[] Value={ 3L,5L,336L,18L,8003163168L,86632L,7191948600L,17L,72960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087670Inst : IEnumerable<long>
{
public static readonly long[] Value=A087670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087670.Bytes);
public long this[int i]=>Value[i];

public static A087670Inst Instance=new A087670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087669
{
public static readonly long[] Value={ 0L,1L,3L,2L,5L,4L,5L,2L,4L,9L,19L,7L,16L,7L,8L,3L,27L,9L,5L,25L,10L,11L,32L,4L,13L,4L,17L,6L,17L,6L,78L,3L,23L,47L,13L,6L,4L,6L,27L,9L,20L,6L,4L,17L,9L,28L,106L,4L,24L,28L,37L,20L,27L,10L,12L,13L,7L,83L,108L,10L,16L,9L,6L,3L,10L,11L,15L,8L,11L,6L,156L,15L,38L,46L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087669Inst : IEnumerable<long>
{
public static readonly long[] Value=A087669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087669.Bytes);
public long this[int i]=>Value[i];

public static A087669Inst Instance=new A087669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087668
{
public static readonly long[] Value={ 8L,9L,11L,13L,15L,133L,2317L,39845L,108167L,46779959L,70246181L,248897669L,452691117L,1137506437L,3089581031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087668Inst : IEnumerable<long>
{
public static readonly long[] Value=A087668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087668.Bytes);
public long this[int i]=>Value[i];

public static A087668Inst Instance=new A087668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087635
{
public static readonly long[] Value={ 0L,2L,12L,64L,336L,1760L,9216L,48256L,252672L,1323008L,6927360L,36272128L,189923328L,994451456L,5207015424L,27264286720L,142757658624L,747488804864L,3913902194688L,20493457948672L,107305138913280L,561857001684992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087635Inst : IEnumerable<long>
{
public static readonly long[] Value=A087635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087635.Bytes);
public long this[int i]=>Value[i];

public static A087635Inst Instance=new A087635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087634
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,23L,29L,37L,41L,43L,53L,67L,73L,79L,83L,89L,97L,113L,127L,131L,139L,163L,173L,179L,191L,193L,199L,233L,239L,251L,277L,281L,293L,307L,359L,373L,409L,419L,431L,433L,443L,487L,491L,499L,509L,577L,593L,619L,641L,653L,659L,673L,683L,709L,719L,727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087634Inst : IEnumerable<long>
{
public static readonly long[] Value=A087634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087634.Bytes);
public long this[int i]=>Value[i];

public static A087634Inst Instance=new A087634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087633
{
public static readonly long[] Value={ 0L,5L,33L,265L,2087L,17203L,146439L,1274154L,11271147L,101049993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087633Inst : IEnumerable<long>
{
public static readonly long[] Value=A087633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087633.Bytes);
public long this[int i]=>Value[i];

public static A087633Inst Instance=new A087633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087632
{
public static readonly long[] Value={ 1L,5L,40L,262L,2103L,17210L,146590L,1274284L,11271819L,101051725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087632Inst : IEnumerable<long>
{
public static readonly long[] Value=A087632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087632.Bytes);
public long this[int i]=>Value[i];

public static A087632Inst Instance=new A087632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087631
{
public static readonly long[] Value={ 1L,6L,35L,268L,2092L,17263L,146565L,1274244L,11272025L,101053126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087631Inst : IEnumerable<long>
{
public static readonly long[] Value=A087631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087631.Bytes);
public long this[int i]=>Value[i];

public static A087631Inst Instance=new A087631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087630
{
public static readonly long[] Value={ 0L,5L,35L,266L,2081L,17230L,146487L,1274194L,11271088L,101050133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087630Inst : IEnumerable<long>
{
public static readonly long[] Value=A087630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087630.Bytes);
public long this[int i]=>Value[i];

public static A087630Inst Instance=new A087630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087629
{
public static readonly long[] Value={ 1L,1L,3L,2L,11L,21L,22L,85L,171L,170L,683L,1365L,1366L,5461L,10923L,10922L,43691L,87381L,87382L,349525L,699051L,699050L,2796203L,5592405L,5592406L,22369621L,44739243L,44739242L,178956971L,357913941L,357913942L,1431655765L,2863311531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087629Inst : IEnumerable<long>
{
public static readonly long[] Value=A087629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087629.Bytes);
public long this[int i]=>Value[i];

public static A087629Inst Instance=new A087629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087628
{
public static readonly long[] Value={ 1L,2L,2L,2L,10L,22L,22L,86L,170L,170L,682L,1366L,1366L,5462L,10922L,10922L,43690L,87382L,87382L,349526L,699050L,699050L,2796202L,5592406L,5592406L,22369622L,44739242L,44739242L,178956970L,357913942L,357913942L,1431655766L,2863311530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087628Inst : IEnumerable<long>
{
public static readonly long[] Value=A087628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087628.Bytes);
public long this[int i]=>Value[i];

public static A087628Inst Instance=new A087628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087627
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,4L,3L,6L,6L,4L,8L,8L,5L,10L,10L,6L,12L,12L,7L,14L,14L,8L,16L,16L,9L,18L,18L,10L,20L,20L,11L,22L,22L,12L,24L,24L,13L,26L,26L,14L,28L,28L,15L,30L,30L,16L,32L,32L,17L,34L,34L,18L,36L,36L,19L,38L,38L,20L,40L,40L,21L,42L,42L,22L,44L,44L,23L,46L,46L,24L,48L,48L,25L,50L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087627Inst : IEnumerable<long>
{
public static readonly long[] Value=A087627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087627.Bytes);
public long this[int i]=>Value[i];

public static A087627Inst Instance=new A087627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087626
{
public static readonly long[] Value={ 1L,2L,5L,13L,36L,104L,311L,955L,2995L,9553L,30896L,101082L,333946L,1112496L,3732955L,12605029L,42800317L,146046819L,500555447L,1722402303L,5948047169L,20607691517L,71610355540L,249520257106L,871614139396L,3051737703526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087626Inst : IEnumerable<long>
{
public static readonly long[] Value=A087626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087626.Bytes);
public long this[int i]=>Value[i];

public static A087626Inst Instance=new A087626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087625
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,3L,0L,2L,2L,5L,0L,4L,0L,7L,6L,4L,0L,8L,0L,6L,8L,11L,0L,8L,4L,13L,6L,8L,0L,14L,0L,8L,12L,17L,10L,10L,0L,19L,14L,12L,0L,20L,0L,12L,14L,23L,0L,16L,6L,24L,18L,14L,0L,24L,14L,16L,20L,29L,0L,20L,0L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087625Inst : IEnumerable<long>
{
public static readonly long[] Value=A087625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087625.Bytes);
public long this[int i]=>Value[i];

public static A087625Inst Instance=new A087625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087624
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,2L,0L,1L,1L,2L,0L,2L,0L,2L,2L,1L,0L,2L,0L,2L,2L,2L,0L,2L,1L,2L,1L,2L,0L,3L,0L,1L,2L,2L,2L,2L,0L,2L,2L,2L,0L,3L,0L,2L,2L,2L,0L,2L,1L,2L,2L,2L,0L,2L,2L,2L,2L,2L,0L,3L,0L,2L,2L,1L,2L,3L,0L,2L,2L,3L,0L,2L,0L,2L,2L,2L,2L,3L,0L,2L,1L,2L,0L,3L,2L,2L,2L,2L,0L,3L,2L,2L,2L,2L,2L,2L,0L,2L,2L,2L,0L,3L,0L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087624Inst : IEnumerable<long>
{
public static readonly long[] Value=A087624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087624.Bytes);
public long this[int i]=>Value[i];

public static A087624Inst Instance=new A087624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087623
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,1L,4L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,6L,0L,0L,0L,0L,0L,1L,0L,4L,0L,0L,0L,0L,0L,0L,0L,2L,6L,0L,0L,0L,0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,1L,2L,4L,10L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087623Inst : IEnumerable<long>
{
public static readonly long[] Value=A087623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087623.Bytes);
public long this[int i]=>Value[i];

public static A087623Inst Instance=new A087623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087622
{
public static readonly long[] Value={ 16L,25L,6L,7L,3L,18L,12L,1L,15L,5L,21L,9L,4L,8L,20L,14L,19L,17L,10L,11L,24L,2L,13L,23L,22L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087622Inst : IEnumerable<long>
{
public static readonly long[] Value=A087622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087622.Bytes);
public long this[int i]=>Value[i];

public static A087622Inst Instance=new A087622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087621
{
public static readonly long[] Value={ -1L,2L,4L,-56L,80L,-352L,64L,2176L,-4864L,31232L,-23552L,-14336L,217088L,-2056192L,2375680L,-7307264L,-4390912L,102367232L,-169607168L,877133824L,-397410304L,-3042967552L,9265217536L,-68308434944L,62495129600L,-78483816448L,-342993403904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087621Inst : IEnumerable<long>
{
public static readonly long[] Value=A087621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087621.Bytes);
public long this[int i]=>Value[i];

public static A087621Inst Instance=new A087621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087620
{
public static readonly long[] Value={ 1L,1L,2L,1L,5L,2L,4L,2L,9L,3L,6L,3L,13L,4L,8L,4L,17L,5L,10L,5L,21L,6L,12L,6L,25L,7L,14L,7L,29L,8L,16L,8L,33L,9L,18L,9L,37L,10L,20L,10L,41L,11L,22L,11L,45L,12L,24L,12L,49L,13L,26L,13L,53L,14L,28L,14L,57L,15L,30L,15L,61L,16L,32L,16L,65L,17L,34L,17L,69L,18L,36L,18L,73L,19L,38L,19L,77L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087620Inst : IEnumerable<long>
{
public static readonly long[] Value=A087620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087620.Bytes);
public long this[int i]=>Value[i];

public static A087620Inst Instance=new A087620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087603
{
public static readonly BigInteger[] Value={ 1L,10L,155L,2100L,29525L,410750L,5731375L,79905000L,1114275625L,15537531250L,216660471875L,3021168937500L,42128015328125L,587444444843750L,8191485291484375L,114224297381250000L,1592774664844140625L,BigInteger.Parse("22210083004410156250"),BigInteger.Parse("309703436610529296875") };
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
public class A087603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087603Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087603.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087603.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087603Inst Instance=new A087603Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087602
{
public static readonly long[] Value={ 3L,5L,53L,140453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087602Inst : IEnumerable<long>
{
public static readonly long[] Value=A087602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087602.Bytes);
public long this[int i]=>Value[i];

public static A087602Inst Instance=new A087602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087601
{
public static readonly long[] Value={ 3L,13L,193L,37633L,7300801L,1416317953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087601Inst : IEnumerable<long>
{
public static readonly long[] Value=A087601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087601.Bytes);
public long this[int i]=>Value[i];

public static A087601Inst Instance=new A087601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087600
{
public static readonly ulong[] Value={ 78L,666L,7503L,82621L,828828L,7552441L,87311505L,557362578L,9901692450L,88893307128L,934624072410L,9836548472766L,99245275962778L,994337011743076L,5535761776004778L,89253915287999385L,865474782199906830L,9888742361454004621UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087600Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A087600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087600.Bytes);
public ulong this[int i]=>Value[i];

public static A087600Inst Instance=new A087600Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087599
{
public static readonly long[] Value={ 10L,105L,2211L,16836L,105111L,2220778L,14319276L,221098906L,1087061878L,11402689605L,223577504556L,1264725045100L,50869724563503L,111335989114503L,2399795843858155L,11141229266441550L,127955437456464996L,1070124037258522456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087599Inst : IEnumerable<long>
{
public static readonly long[] Value=A087599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087599.Bytes);
public long this[int i]=>Value[i];

public static A087599Inst Instance=new A087599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087598
{
public static readonly long[] Value={ 10L,21L,28L,36L,45L,55L,66L,78L,171L,465L,528L,666L,2211L,4465L,22791L,333336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087598Inst : IEnumerable<long>
{
public static readonly long[] Value=A087598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087598.Bytes);
public long this[int i]=>Value[i];

public static A087598Inst Instance=new A087598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087597
{
public static readonly long[] Value={ 10L,21L,28L,36L,45L,55L,66L,78L,105L,171L,465L,528L,561L,666L,2211L,4465L,7503L,16836L,18336L,22791L,44850L,53628L,55278L,82621L,105111L,114003L,333336L,427350L,828828L,2220778L,2256750L,3136260L,3373503L,3454506L,3927003L,5443350L,6175855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087597Inst : IEnumerable<long>
{
public static readonly long[] Value=A087597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087597.Bytes);
public long this[int i]=>Value[i];

public static A087597Inst Instance=new A087597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087596
{
public static readonly long[] Value={ 97L,997L,9967L,99989L,999907L,9999907L,99999989L,999999607L,9999999967L,99999999947L,999999999989L,9999999999701L,99999999999923L,999999999999989L,9999999999999887L,99999999999999997L,999999999999999989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087596Inst : IEnumerable<long>
{
public static readonly long[] Value=A087596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087596.Bytes);
public long this[int i]=>Value[i];

public static A087596Inst Instance=new A087596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087595
{
public static readonly long[] Value={ 13L,101L,1009L,10009L,100363L,1000003L,10000141L,100000543L,1000000007L,10000000589L,100000000447L,1000000000063L,10000000000609L,100000000000721L,1000000000000843L,10000000000002547L,100000000000000609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087595Inst : IEnumerable<long>
{
public static readonly long[] Value=A087595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087595.Bytes);
public long this[int i]=>Value[i];

public static A087595Inst Instance=new A087595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087594
{
public static readonly long[] Value={ 13L,29L,31L,41L,47L,53L,61L,79L,83L,97L,103L,113L,163L,227L,229L,331L,347L,367L,401L,449L,487L,503L,521L,523L,541L,547L,557L,563L,569L,587L,601L,661L,709L,743L,769L,821L,823L,881L,883L,907L,941L,947L,967L,997L,1063L,1069L,1103L,1163L,1481L,1609L,1621L,1663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087594Inst : IEnumerable<long>
{
public static readonly long[] Value=A087594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087594.Bytes);
public long this[int i]=>Value[i];

public static A087594Inst Instance=new A087594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087593
{
public static readonly long[] Value={ 13L,29L,31L,41L,47L,53L,61L,79L,83L,97L,101L,103L,107L,109L,113L,163L,227L,229L,241L,263L,269L,281L,307L,331L,347L,367L,401L,449L,463L,487L,503L,509L,521L,523L,541L,547L,557L,563L,569L,587L,601L,607L,641L,647L,661L,701L,709L,743L,769L,787L,809L,821L,823L,829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087593Inst : IEnumerable<long>
{
public static readonly long[] Value=A087593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087593.Bytes);
public long this[int i]=>Value[i];

public static A087593Inst Instance=new A087593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087592
{
public static readonly long[] Value={ 2L,3L,5L,13L,29L,61L,317L,829L,1073742653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087592Inst : IEnumerable<long>
{
public static readonly long[] Value=A087592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087592.Bytes);
public long this[int i]=>Value[i];

public static A087592Inst Instance=new A087592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087591
{
public static readonly BigInteger[] Value={ 3L,31L,412L,211651L,10418334677L,BigInteger.Parse("303890784517200545168"),BigInteger.Parse("20563117581501200054141591291038688169573"),BigInteger.Parse("303842114083788450267402853513117319834854491401577630846309273875657852752036755") };
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
public class A087591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087591Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087591.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087591.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087591Inst Instance=new A087591Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087590
{
public static readonly BigInteger[] Value={ 9L,961L,169744L,44796145801L,BigInteger.Parse("108541697441980694329"),BigInteger.Parse("92349608914479614580158267346076408148224"),BigInteger.Parse("422841804670643762851085416974419806943295619672882300010638032751950909203002329") };
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
public class A087590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087590Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087590.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087590.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087590Inst Instance=new A087590Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087589
{
public static readonly BigInteger[] Value={ 2L,7L,97L,9513L,310128053L,301342952946467904L,BigInteger.Parse("247457310239083566048257894873299791"),BigInteger.Parse("13650863314759698840817047407326791594459658813073613700723169454430254") };
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
public class A087589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087589Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087589.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087589.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087589Inst Instance=new A087589Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087588
{
public static readonly BigInteger[] Value={ 4L,49L,9409L,90497169L,96179409257570809L,BigInteger.Parse("90807575290497169225026709302153216"),BigInteger.Parse("61235120390762052296179409257570809399096508856271866251252832960643681") };
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
public class A087588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087588Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087588.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087588.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087588Inst Instance=new A087588Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087507
{
public static readonly long[] Value={ 1L,1L,1L,4L,2L,2L,7L,3L,3L,10L,4L,4L,13L,5L,5L,16L,6L,6L,19L,7L,7L,22L,8L,8L,25L,9L,9L,28L,10L,10L,31L,11L,11L,34L,12L,12L,37L,13L,13L,40L,14L,14L,43L,15L,15L,46L,16L,16L,49L,17L,17L,52L,18L,18L,55L,19L,19L,58L,20L,20L,61L,21L,21L,64L,22L,22L,67L,23L,23L,70L,24L,24L,73L,25L,25L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087507Inst : IEnumerable<long>
{
public static readonly long[] Value=A087507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087507.Bytes);
public long this[int i]=>Value[i];

public static A087507Inst Instance=new A087507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087506
{
public static readonly long[] Value={ 5L,13L,71L,127L,163L,197L,227L,307L,317L,409L,523L,587L,593L,761L,857L,947L,1151L,1321L,1373L,1783L,1861L,1973L,2039L,2273L,2417L,2543L,3049L,3083L,3457L,3463L,3697L,3739L,4093L,4243L,4253L,4463L,4483L,4519L,4583L,4657L,4723L,4751L,5171L,5179L,5519L,5591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087506Inst : IEnumerable<long>
{
public static readonly long[] Value=A087506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087506.Bytes);
public long this[int i]=>Value[i];

public static A087506Inst Instance=new A087506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087505
{
public static readonly long[] Value={ 0L,2L,4L,8L,10L,14L,16L,20L,22L,32L,34L,38L,44L,46L,52L,56L,58L,62L,70L,74L,76L,86L,88L,92L,100L,104L,112L,118L,122L,128L,130L,134L,136L,146L,148L,154L,164L,170L,172L,176L,190L,196L,202L,206L,212L,218L,220L,224L,230L,232L,238L,242L,244L,256L,260L,274L,284L,286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087505Inst : IEnumerable<long>
{
public static readonly long[] Value=A087505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087505.Bytes);
public long this[int i]=>Value[i];

public static A087505Inst Instance=new A087505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087504
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,3L,3L,4L,3L,4L,4L,6L,5L,6L,5L,7L,6L,8L,7L,9L,7L,9L,8L,11L,9L,11L,9L,12L,10L,13L,11L,14L,11L,14L,12L,16L,13L,16L,13L,17L,14L,18L,15L,19L,15L,19L,16L,21L,17L,21L,17L,22L,18L,23L,19L,24L,19L,24L,20L,26L,21L,26L,21L,27L,22L,28L,23L,29L,23L,29L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087504Inst : IEnumerable<long>
{
public static readonly long[] Value=A087504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087504.Bytes);
public long this[int i]=>Value[i];

public static A087504Inst Instance=new A087504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087503
{
public static readonly long[] Value={ 1L,3L,6L,12L,21L,39L,66L,120L,201L,363L,606L,1092L,1821L,3279L,5466L,9840L,16401L,29523L,49206L,88572L,147621L,265719L,442866L,797160L,1328601L,2391483L,3985806L,7174452L,11957421L,21523359L,35872266L,64570080L,107616801L,193710243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087503Inst : IEnumerable<long>
{
public static readonly long[] Value=A087503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087503.Bytes);
public long this[int i]=>Value[i];

public static A087503Inst Instance=new A087503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087502
{
public static readonly BigInteger[] Value={ 32L,18L,8L,10993850L,2129428800L,21L,5064320L,105263157894736842L,40L,64609423538L,5712L,65L,BigInteger.Parse("58774271029236501660840264682112"),67650L,96L,833L,BigInteger.Parse("586081355679130611935159482937228562988190880"),133L };
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
public class A087502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087502Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087502.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087502.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087502Inst Instance=new A087502Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087501
{
public static readonly long[] Value={ 1L,3L,1L,1L,5L,1L,1L,1L,3L,12L,4L,1L,271L,1L,1L,2L,7L,1L,35L,6L,1L,9L,4L,2L,1L,1L,2L,1L,1L,2L,15L,3L,1L,24L,2L,39L,1L,3L,1L,2L,2L,5L,1L,2L,2L,1L,3L,3L,1L,3L,9L,1L,13L,1L,1L,1L,3L,5L,3L,1L,2L,1L,10L,1L,2L,13L,7L,7L,1L,1L,5L,2L,1L,1L,18L,1L,26L,8L,1L,1L,1L,1L,1L,1L,1L,8L,2L,1L,4L,1L,3L,9L,8L,3L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087501Inst : IEnumerable<long>
{
public static readonly long[] Value=A087501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087501.Bytes);
public long this[int i]=>Value[i];

public static A087501Inst Instance=new A087501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087500
{
public static readonly long[] Value={ 1L,0L,9L,1L,8L,7L,7L,0L,4L,1L,2L,0L,9L,6L,1L,2L,6L,7L,8L,2L,7L,6L,1L,1L,0L,9L,7L,9L,4L,7L,7L,6L,3L,8L,2L,5L,6L,4L,9L,3L,2L,7L,2L,6L,5L,1L,4L,2L,9L,6L,5L,6L,2L,7L,2L,7L,1L,0L,7L,5L,4L,9L,1L,3L,5L,6L,9L,7L,3L,5L,1L,3L,9L,7L,0L,7L,2L,9L,8L,9L,0L,6L,3L,3L,6L,6L,6L,5L,3L,0L,6L,6L,5L,4L,4L,9L,4L,0L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087500Inst : IEnumerable<long>
{
public static readonly long[] Value=A087500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087500.Bytes);
public long this[int i]=>Value[i];

public static A087500Inst Instance=new A087500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087499
{
public static readonly long[] Value={ 1L,1L,0L,2L,5L,4L,3L,1L,3L,6L,6L,7L,0L,7L,2L,8L,0L,1L,3L,8L,3L,6L,0L,9L,3L,4L,0L,2L,5L,2L,2L,5L,6L,8L,3L,5L,1L,0L,2L,2L,2L,2L,1L,2L,8L,4L,1L,4L,9L,3L,1L,8L,4L,0L,2L,3L,3L,1L,3L,1L,9L,8L,4L,7L,6L,8L,6L,3L,2L,5L,6L,2L,6L,9L,4L,7L,4L,4L,6L,0L,3L,3L,3L,6L,4L,1L,3L,9L,2L,0L,7L,8L,7L,2L,3L,7L,1L,7L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087499Inst : IEnumerable<long>
{
public static readonly long[] Value=A087499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087499.Bytes);
public long this[int i]=>Value[i];

public static A087499Inst Instance=new A087499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087498
{
public static readonly long[] Value={ 1L,1L,1L,5L,9L,6L,4L,4L,0L,8L,9L,7L,8L,7L,1L,6L,6L,9L,0L,6L,1L,9L,1L,5L,6L,4L,1L,9L,3L,4L,5L,3L,4L,9L,6L,9L,5L,7L,6L,9L,4L,9L,1L,1L,8L,2L,2L,3L,0L,4L,0L,0L,9L,3L,7L,0L,6L,3L,5L,3L,3L,1L,1L,0L,0L,3L,3L,7L,0L,9L,5L,7L,5L,0L,5L,0L,2L,0L,3L,1L,1L,8L,9L,1L,5L,0L,1L,1L,3L,9L,6L,4L,6L,7L,1L,5L,1L,7L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087498Inst : IEnumerable<long>
{
public static readonly long[] Value=A087498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087498.Bytes);
public long this[int i]=>Value[i];

public static A087498Inst Instance=new A087498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087497
{
public static readonly long[] Value={ 1L,1L,3L,3L,3L,2L,3L,3L,6L,3L,9L,5L,0L,8L,6L,5L,7L,9L,4L,9L,1L,0L,2L,8L,9L,6L,9L,4L,9L,0L,8L,8L,6L,8L,3L,6L,3L,5L,9L,9L,0L,9L,8L,2L,8L,2L,4L,1L,1L,7L,9L,7L,7L,5L,2L,5L,9L,6L,1L,3L,0L,8L,1L,7L,9L,4L,4L,2L,5L,7L,4L,1L,9L,8L,7L,6L,2L,6L,7L,4L,4L,5L,0L,1L,0L,3L,5L,4L,4L,5L,8L,0L,4L,9L,0L,0L,2L,0L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087497Inst : IEnumerable<long>
{
public static readonly long[] Value=A087497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087497.Bytes);
public long this[int i]=>Value[i];

public static A087497Inst Instance=new A087497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087496
{
public static readonly long[] Value={ 1L,1L,5L,6L,5L,5L,2L,3L,7L,4L,4L,2L,1L,5L,1L,4L,4L,2L,3L,1L,5L,2L,6L,0L,5L,9L,9L,8L,7L,4L,3L,4L,1L,0L,0L,4L,6L,8L,4L,0L,2L,1L,3L,0L,7L,0L,7L,1L,8L,7L,6L,1L,2L,9L,2L,2L,3L,1L,0L,6L,7L,0L,7L,7L,3L,8L,2L,8L,6L,7L,2L,2L,7L,1L,5L,0L,3L,5L,7L,6L,6L,4L,3L,9L,2L,6L,5L,1L,7L,9L,7L,1L,8L,3L,9L,2L,9L,3L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087496Inst : IEnumerable<long>
{
public static readonly long[] Value=A087496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087496.Bytes);
public long this[int i]=>Value[i];

public static A087496Inst Instance=new A087496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087495
{
public static readonly long[] Value={ 1L,1L,8L,9L,0L,0L,3L,9L,2L,6L,4L,6L,5L,5L,1L,3L,1L,5L,4L,0L,6L,2L,3L,6L,3L,7L,3L,2L,7L,7L,1L,4L,0L,3L,3L,9L,7L,3L,8L,6L,0L,9L,2L,5L,1L,2L,6L,3L,9L,6L,7L,1L,6L,2L,6L,4L,0L,9L,8L,4L,3L,6L,9L,3L,5L,6L,4L,6L,6L,5L,0L,0L,7L,9L,6L,8L,4L,2L,3L,0L,6L,1L,7L,7L,4L,2L,4L,6L,8L,9L,3L,3L,3L,3L,9L,7L,6L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087495Inst : IEnumerable<long>
{
public static readonly long[] Value=A087495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087495.Bytes);
public long this[int i]=>Value[i];

public static A087495Inst Instance=new A087495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087494
{
public static readonly long[] Value={ 1L,2L,3L,6L,9L,6L,1L,8L,0L,9L,4L,2L,3L,7L,3L,0L,0L,5L,2L,6L,2L,6L,2L,2L,7L,2L,4L,4L,4L,5L,3L,4L,2L,2L,5L,6L,7L,4L,2L,0L,2L,4L,1L,1L,3L,1L,5L,4L,8L,9L,3L,7L,1L,3L,0L,0L,9L,1L,9L,5L,9L,2L,7L,9L,9L,4L,4L,2L,6L,5L,9L,0L,4L,9L,4L,8L,9L,1L,0L,6L,5L,5L,0L,7L,7L,0L,4L,2L,7L,0L,8L,9L,2L,3L,6L,4L,1L,2L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087494Inst : IEnumerable<long>
{
public static readonly long[] Value=A087494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087494.Bytes);
public long this[int i]=>Value[i];

public static A087494Inst Instance=new A087494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087493
{
public static readonly long[] Value={ 1L,3L,1L,3L,5L,0L,7L,0L,7L,8L,6L,8L,7L,9L,8L,5L,7L,6L,6L,7L,1L,7L,3L,3L,9L,4L,4L,7L,0L,7L,2L,7L,8L,6L,8L,2L,8L,1L,5L,8L,1L,2L,9L,8L,6L,1L,4L,8L,4L,7L,9L,2L,0L,5L,8L,8L,0L,9L,8L,4L,9L,8L,0L,5L,4L,2L,3L,8L,8L,1L,3L,6L,0L,3L,3L,8L,8L,1L,5L,9L,2L,5L,0L,5L,2L,4L,2L,9L,1L,5L,4L,1L,1L,8L,2L,2L,0L,8L,6L,1L,1L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087493Inst : IEnumerable<long>
{
public static readonly long[] Value=A087493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087493.Bytes);
public long this[int i]=>Value[i];

public static A087493Inst Instance=new A087493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087492
{
public static readonly long[] Value={ 1L,4L,5L,0L,3L,4L,0L,3L,2L,8L,4L,9L,5L,6L,3L,0L,4L,0L,6L,0L,5L,2L,9L,8L,3L,0L,7L,6L,6L,8L,0L,6L,9L,7L,8L,8L,1L,4L,0L,8L,2L,9L,9L,9L,7L,9L,6L,0L,5L,9L,0L,4L,1L,8L,2L,1L,7L,1L,7L,4L,9L,0L,7L,1L,7L,5L,1L,7L,6L,2L,8L,1L,3L,5L,5L,6L,8L,6L,8L,7L,6L,5L,9L,8L,4L,1L,3L,1L,4L,2L,0L,8L,2L,9L,3L,4L,1L,8L,8L,6L,9L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087492Inst : IEnumerable<long>
{
public static readonly long[] Value=A087492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087492.Bytes);
public long this[int i]=>Value[i];

public static A087492Inst Instance=new A087492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087475
{
public static readonly long[] Value={ 4L,5L,8L,13L,20L,29L,40L,53L,68L,85L,104L,125L,148L,173L,200L,229L,260L,293L,328L,365L,404L,445L,488L,533L,580L,629L,680L,733L,788L,845L,904L,965L,1028L,1093L,1160L,1229L,1300L,1373L,1448L,1525L,1604L,1685L,1768L,1853L,1940L,2029L,2120L,2213L,2308L,2405L,2504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087475Inst : IEnumerable<long>
{
public static readonly long[] Value=A087475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087475.Bytes);
public long this[int i]=>Value[i];

public static A087475Inst Instance=new A087475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087474
{
public static readonly long[] Value={ 1L,10L,0L,25L,10L,0L,39L,27L,14L,4L,77L,49L,36L,18L,8L,171L,77L,49L,36L,18L,8L,199L,171L,77L,49L,36L,18L,8L,577L,399L,351L,155L,75L,35L,15L,5L,887L,696L,594L,486L,368L,228L,56L,30L,0L,1592L,988L,784L,592L,468L,288L,224L,48L,32L,6L,2682L,1736L,988L,784L,592L,468L,288L,224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087474Inst : IEnumerable<long>
{
public static readonly long[] Value=A087474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087474.Bytes);
public long this[int i]=>Value[i];

public static A087474Inst Instance=new A087474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087473
{
public static readonly long[] Value={ 1L,10L,25L,39L,77L,171L,199L,577L,887L,1592L,2682L,3988L,6913L,18747L,39577L,58439L,99428L,173442L,267343L,299137L,574182L,685812L,880543L,1635812L,1974447L,2771717L,18871813L,45797337L,49899368L,58935768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087473Inst : IEnumerable<long>
{
public static readonly long[] Value=A087473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087473.Bytes);
public long this[int i]=>Value[i];

public static A087473Inst Instance=new A087473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087472
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,1L,1L,1L,1L,2L,2L,2L,2L,2L,3L,1L,1L,1L,2L,2L,2L,2L,3L,2L,3L,1L,1L,2L,2L,2L,3L,2L,3L,2L,3L,1L,1L,2L,2L,2L,2L,3L,2L,3L,3L,1L,1L,2L,2L,3L,3L,2L,4L,3L,3L,1L,1L,2L,2L,2L,2L,3L,3L,3L,3L,1L,1L,2L,3L,3L,3L,3L,3L,3L,2L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087472Inst : IEnumerable<long>
{
public static readonly long[] Value=A087472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087472.Bytes);
public long this[int i]=>Value[i];

public static A087472Inst Instance=new A087472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087471
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,2L,4L,6L,8L,0L,2L,4L,6L,8L,0L,3L,6L,9L,2L,5L,8L,2L,8L,4L,0L,4L,8L,2L,6L,0L,8L,6L,6L,8L,0L,5L,0L,5L,0L,0L,0L,5L,0L,0L,0L,6L,2L,8L,8L,0L,8L,8L,6L,0L,0L,7L,4L,2L,6L,5L,8L,8L,0L,8L,0L,8L,6L,8L,6L,0L,6L,0L,8L,4L,0L,9L,8L,4L,8L,0L,0L,8L,4L,8L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087471Inst : IEnumerable<long>
{
public static readonly long[] Value=A087471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087471.Bytes);
public long this[int i]=>Value[i];

public static A087471Inst Instance=new A087471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087470
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,4L,1L,3L,5L,2L,4L,1L,6L,3L,5L,2L,7L,4L,1L,6L,3L,8L,5L,2L,7L,4L,1L,9L,6L,3L,8L,5L,2L,10L,7L,4L,1L,9L,6L,3L,11L,8L,5L,2L,10L,7L,4L,1L,12L,9L,6L,3L,11L,8L,5L,2L,13L,10L,7L,4L,1L,12L,9L,6L,3L,14L,11L,8L,5L,2L,13L,10L,7L,4L,1L,15L,12L,9L,6L,3L,14L,11L,8L,5L,2L,16L,13L,10L,7L,4L,1L,15L,12L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087470Inst : IEnumerable<long>
{
public static readonly long[] Value=A087470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087470.Bytes);
public long this[int i]=>Value[i];

public static A087470Inst Instance=new A087470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087469
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,3L,0L,2L,4L,1L,3L,0L,5L,2L,4L,1L,6L,3L,0L,5L,2L,7L,4L,1L,6L,3L,0L,8L,5L,2L,7L,4L,1L,9L,6L,3L,0L,8L,5L,2L,10L,7L,4L,1L,9L,6L,3L,0L,11L,8L,5L,2L,10L,7L,4L,1L,12L,9L,6L,3L,0L,11L,8L,5L,2L,13L,10L,7L,4L,1L,12L,9L,6L,3L,0L,14L,11L,8L,5L,2L,13L,10L,7L,4L,1L,15L,12L,9L,6L,3L,0L,14L,11L,8L,5L,2L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087469Inst : IEnumerable<long>
{
public static readonly long[] Value=A087469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087469.Bytes);
public long this[int i]=>Value[i];

public static A087469Inst Instance=new A087469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087468
{
public static readonly long[] Value={ 1L,3L,2L,7L,5L,4L,12L,10L,8L,6L,19L,16L,14L,11L,9L,27L,24L,21L,18L,15L,13L,37L,33L,30L,26L,23L,20L,17L,48L,44L,40L,36L,32L,29L,25L,22L,61L,56L,52L,47L,43L,39L,35L,31L,28L,75L,70L,65L,60L,55L,51L,46L,42L,38L,34L,91L,85L,80L,74L,69L,64L,59L,54L,50L,45L,41L,108L,102L,96L,90L,84L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087468Inst : IEnumerable<long>
{
public static readonly long[] Value=A087468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087468.Bytes);
public long this[int i]=>Value[i];

public static A087468Inst Instance=new A087468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087467
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,3L,2L,1L,3L,2L,4L,1L,3L,2L,4L,1L,3L,5L,2L,4L,1L,3L,5L,2L,4L,6L,1L,3L,5L,2L,4L,6L,1L,3L,5L,7L,2L,4L,6L,1L,3L,5L,7L,2L,4L,6L,8L,1L,3L,5L,7L,2L,4L,6L,8L,1L,3L,5L,7L,9L,2L,4L,6L,8L,1L,3L,5L,7L,9L,2L,4L,6L,8L,10L,1L,3L,5L,7L,9L,2L,4L,6L,8L,10L,1L,3L,5L,7L,9L,11L,2L,4L,6L,8L,10L,1L,3L,5L,7L,9L,11L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087467Inst : IEnumerable<long>
{
public static readonly long[] Value=A087467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087467.Bytes);
public long this[int i]=>Value[i];

public static A087467Inst Instance=new A087467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087466
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,2L,1L,0L,2L,1L,3L,0L,2L,1L,3L,0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,5L,0L,2L,4L,1L,3L,5L,0L,2L,4L,6L,1L,3L,5L,0L,2L,4L,6L,1L,3L,5L,7L,0L,2L,4L,6L,1L,3L,5L,7L,0L,2L,4L,6L,8L,1L,3L,5L,7L,0L,2L,4L,6L,8L,1L,3L,5L,7L,9L,0L,2L,4L,6L,8L,1L,3L,5L,7L,9L,0L,2L,4L,6L,8L,10L,1L,3L,5L,7L,9L,0L,2L,4L,6L,8L,10L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087466Inst : IEnumerable<long>
{
public static readonly long[] Value=A087466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087466.Bytes);
public long this[int i]=>Value[i];

public static A087466Inst Instance=new A087466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087465
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,6L,8L,10L,12L,9L,11L,14L,16L,19L,13L,15L,18L,21L,24L,27L,17L,20L,23L,26L,30L,33L,37L,22L,25L,29L,32L,36L,40L,44L,48L,28L,31L,35L,39L,43L,47L,52L,56L,61L,34L,38L,42L,46L,51L,55L,60L,65L,70L,75L,41L,45L,50L,54L,59L,64L,69L,74L,80L,85L,91L,49L,53L,58L,63L,68L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087465Inst : IEnumerable<long>
{
public static readonly long[] Value=A087465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087465.Bytes);
public long this[int i]=>Value[i];

public static A087465Inst Instance=new A087465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087464
{
public static readonly long[] Value={ 0L,0L,2L,0L,6L,10L,0L,42L,86L,0L,342L,682L,0L,2730L,5462L,0L,21846L,43690L,0L,174762L,349526L,0L,1398102L,2796202L,0L,11184810L,22369622L,0L,89478486L,178956970L,0L,715827882L,1431655766L,0L,5726623062L,11453246122L,0L,45812984490L,91625968982L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087464Inst : IEnumerable<long>
{
public static readonly long[] Value=A087464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087464.Bytes);
public long this[int i]=>Value[i];

public static A087464Inst Instance=new A087464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087463
{
public static readonly long[] Value={ 0L,1L,1L,0L,5L,11L,0L,43L,85L,0L,341L,683L,0L,2731L,5461L,0L,21845L,43691L,0L,174763L,349525L,0L,1398101L,2796203L,0L,11184811L,22369621L,0L,89478485L,178956971L,0L,715827883L,1431655765L,0L,5726623061L,11453246123L,0L,45812984491L,91625968981L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087463Inst : IEnumerable<long>
{
public static readonly long[] Value=A087463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087463.Bytes);
public long this[int i]=>Value[i];

public static A087463Inst Instance=new A087463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087462
{
public static readonly long[] Value={ 1L,1L,1L,8L,5L,11L,64L,43L,85L,512L,341L,683L,4096L,2731L,5461L,32768L,21845L,43691L,262144L,174763L,349525L,2097152L,1398101L,2796203L,16777216L,11184811L,22369621L,134217728L,89478485L,178956971L,1073741824L,715827883L,1431655765L,8589934592L,5726623061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087462Inst : IEnumerable<long>
{
public static readonly long[] Value=A087462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087462.Bytes);
public long this[int i]=>Value[i];

public static A087462Inst Instance=new A087462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087461
{
public static readonly long[] Value={ 5L,9L,13L,20L,25L,30L,36L,42L,50L,55L,63L,71L,75L,80L,92L,99L,106L,115L,122L,127L,136L,141L,156L,163L,170L,177L,185L,190L,197L,210L,221L,227L,238L,249L,255L,265L,273L,282L,291L,300L,307L,317L,325L,330L,339L,351L,363L,374L,385L,395L,404L,409L,422L,429L,438L,444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087461Inst : IEnumerable<long>
{
public static readonly long[] Value=A087461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087461.Bytes);
public long this[int i]=>Value[i];

public static A087461Inst Instance=new A087461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087460
{
public static readonly long[] Value={ 2L,3L,4L,10L,11L,30L,83L,226L,4549L,91379L,91380L,248396L,248397L,675213L,4989190L,4989191L,13562026L,13562027L,36865412L,100210580L,2012783315L,5471312310L,40427833595L,40427833596L,109894245428L,812014744421L,812014744422L,2207284924202L,2207284924203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087460Inst : IEnumerable<long>
{
public static readonly long[] Value=A087460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087460.Bytes);
public long this[int i]=>Value[i];

public static A087460Inst Instance=new A087460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087443
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,30L,16L,24L,36L,60L,210L,32L,48L,72L,120L,180L,420L,2310L,64L,96L,144L,216L,240L,360L,840L,900L,1260L,4620L,30030L,128L,192L,288L,432L,480L,720L,1080L,1680L,1800L,2520L,6300L,9240L,13860L,60060L,510510L,256L,384L,576L,864L,960L,1296L,1440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087443Inst : IEnumerable<long>
{
public static readonly long[] Value=A087443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087443.Bytes);
public long this[int i]=>Value[i];

public static A087443Inst Instance=new A087443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087442
{
public static readonly long[] Value={ 45L,225L,325L,405L,561L,637L,891L,1105L,1125L,1225L,1377L,1729L,2025L,2465L,2821L,3321L,3645L,3751L,3825L,4225L,4961L,5589L,5625L,6517L,6525L,6601L,7381L,8125L,8281L,8625L,8911L,9801L,10125L,10585L,10625L,12025L,13357L,13833L,14161L,15841L,15925L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087442Inst : IEnumerable<long>
{
public static readonly long[] Value=A087442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087442.Bytes);
public long this[int i]=>Value[i];

public static A087442Inst Instance=new A087442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087441
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,11L,13L,16L,17L,19L,23L,25L,27L,29L,31L,32L,37L,41L,43L,45L,47L,49L,53L,59L,61L,64L,67L,71L,73L,79L,81L,83L,89L,97L,101L,103L,107L,109L,113L,121L,125L,127L,128L,131L,137L,139L,149L,151L,157L,163L,167L,169L,173L,179L,181L,191L,193L,197L,199L,211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087441Inst : IEnumerable<long>
{
public static readonly long[] Value=A087441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087441.Bytes);
public long this[int i]=>Value[i];

public static A087441Inst Instance=new A087441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087440
{
public static readonly long[] Value={ 1L,4L,13L,46L,172L,664L,2608L,10336L,41152L,164224L,656128L,2622976L,10488832L,41949184L,167784448L,671113216L,2684403712L,10737516544L,42949869568L,171799085056L,687195553792L,2748780642304L,10995119423488L,43980471402496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087440Inst : IEnumerable<long>
{
public static readonly long[] Value=A087440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087440.Bytes);
public long this[int i]=>Value[i];

public static A087440Inst Instance=new A087440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087439
{
public static readonly long[] Value={ 1L,5L,22L,98L,451L,2135L,10312L,50468L,249061L,1235465L,6147802L,30650438L,152986471L,764135195L,3818284492L,19084248008L,95399716681L,476934013325L,2384476356382L,11921800651178L,59607259863691L,298031069141855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087439Inst : IEnumerable<long>
{
public static readonly long[] Value=A087439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087439.Bytes);
public long this[int i]=>Value[i];

public static A087439Inst Instance=new A087439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087438
{
public static readonly long[] Value={ 1L,4L,15L,56L,212L,816L,3184L,12544L,49728L,197888L,789248L,3151872L,12596224L,50360320L,201388032L,805437440L,3221504000L,12885491712L,51540852736L,206161051648L,824639225856L,3298546417664L,13194163650560L,52776608464896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087438Inst : IEnumerable<long>
{
public static readonly long[] Value=A087438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087438.Bytes);
public long this[int i]=>Value[i];

public static A087438Inst Instance=new A087438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087437
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,2L,4L,4L,3L,3L,6L,5L,4L,7L,9L,11L,5L,12L,11L,12L,5L,12L,17L,6L,17L,23L,17L,15L,19L,26L,8L,25L,35L,22L,35L,32L,25L,40L,10L,39L,36L,39L,32L,61L,30L,52L,48L,43L,57L,12L,73L,51L,16L,68L,52L,92L,38L,94L,72L,82L,81L,15L,119L,69L,59L,131L,84L,93L,140L,50L,72L,123L,143L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087437Inst : IEnumerable<long>
{
public static readonly long[] Value=A087437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087437.Bytes);
public long this[int i]=>Value[i];

public static A087437Inst Instance=new A087437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087436
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,1L,0L,2L,1L,1L,1L,1L,1L,2L,0L,1L,2L,1L,1L,2L,1L,1L,1L,2L,1L,3L,1L,1L,2L,1L,0L,2L,1L,2L,2L,1L,1L,2L,1L,1L,2L,1L,1L,3L,1L,1L,1L,2L,2L,2L,1L,1L,3L,2L,1L,2L,1L,1L,2L,1L,1L,3L,0L,2L,2L,1L,1L,2L,2L,1L,2L,1L,1L,3L,1L,2L,2L,1L,1L,4L,1L,1L,2L,2L,1L,2L,1L,1L,3L,2L,1L,2L,1L,2L,1L,1L,2L,3L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087436Inst : IEnumerable<long>
{
public static readonly long[] Value=A087436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087436.Bytes);
public long this[int i]=>Value[i];

public static A087436Inst Instance=new A087436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087435
{
public static readonly BigInteger[] Value={ 10L,241L,10537L,573928L,35547994L,2409600865L,174155363186L,13163230391312L,1029540512731472L,82720372430619225L,6791513306490769978L,BigInteger.Parse("567576781128880904593"),BigInteger.Parse("48140629936389507358024") };
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
public class A087435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087435Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087435.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087435.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087435Inst Instance=new A087435Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087434
{
public static readonly BigInteger[] Value={ 10L,231L,10296L,563391L,34974066L,2374052871L,171745762321L,12989075028126L,1016377282340160L,81690831917887753L,6708792934060150753L,BigInteger.Parse("560785267822390134615"),BigInteger.Parse("47573053155260626453431") };
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
public class A087434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087434Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087434.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087434.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087434Inst Instance=new A087434Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087433
{
public static readonly long[] Value={ 1L,2L,6L,20L,70L,252L,926L,3460L,13110L,50252L,194446L,758100L,2973350L,11716252L,46333566L,183739940L,730176790L,2906358252L,11582386286L,46200404980L,184414199430L,736494536252L,2942491360606L,11759505089220L,47006639297270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087433Inst : IEnumerable<long>
{
public static readonly long[] Value=A087433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087433.Bytes);
public long this[int i]=>Value[i];

public static A087433Inst Instance=new A087433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087432
{
public static readonly long[] Value={ 1L,1L,3L,7L,19L,51L,143L,407L,1179L,3451L,10183L,30207L,89939L,268451L,802623L,2402407L,7196299L,21567051L,64657463L,193885007L,581480259L,1744091251L,5231574703L,15693326007L,47077181819L,141225953051L,423666674343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087432Inst : IEnumerable<long>
{
public static readonly long[] Value=A087432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087432.Bytes);
public long this[int i]=>Value[i];

public static A087432Inst Instance=new A087432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087431
{
public static readonly long[] Value={ 1L,2L,8L,28L,88L,256L,704L,1856L,4736L,11776L,28672L,68608L,161792L,376832L,868352L,1982464L,4489216L,10092544L,22544384L,50069504L,110624768L,243269632L,532676608L,1161822208L,2524971008L,5469372416L,11811160064L,25434259456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087431Inst : IEnumerable<long>
{
public static readonly long[] Value=A087431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087431.Bytes);
public long this[int i]=>Value[i];

public static A087431Inst Instance=new A087431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087430
{
public static readonly long[] Value={ 14L,15L,26L,34L,35L,38L,39L,44L,49L,51L,55L,62L,63L,65L,69L,74L,76L,80L,86L,87L,94L,95L,99L,104L,111L,116L,118L,119L,122L,123L,124L,129L,134L,142L,143L,146L,152L,153L,155L,158L,159L,161L,164L,174L,183L,185L,186L,188L,194L,195L,202L,203L,206L,207L,209L,214L,215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087430Inst : IEnumerable<long>
{
public static readonly long[] Value=A087430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087430.Bytes);
public long this[int i]=>Value[i];

public static A087430Inst Instance=new A087430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087429
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087429Inst : IEnumerable<long>
{
public static readonly long[] Value=A087429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087429.Bytes);
public long this[int i]=>Value[i];

public static A087429Inst Instance=new A087429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087428
{
public static readonly long[] Value={ 2L,6L,4L,4L,14L,15L,7L,9L,24L,11L,32L,33L,13L,15L,46L,16L,52L,19L,19L,61L,22L,24L,75L,77L,78L,28L,28L,86L,99L,34L,36L,105L,40L,114L,41L,124L,43L,45L,136L,46L,146L,49L,149L,150L,56L,59L,58L,58L,176L,181L,61L,191L,66L,199L,69L,204L,71L,212L,213L,76L,234L,79L,79L,239L,252L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087428Inst : IEnumerable<long>
{
public static readonly long[] Value=A087428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087428.Bytes);
public long this[int i]=>Value[i];

public static A087428Inst Instance=new A087428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087411
{
public static readonly long[] Value={ 91L,82L,73L,64L,55L,46L,37L,28L,19L,9L,91L,8L,11L,71L,26L,13L,51L,44L,15L,31L,62L,17L,11L,80L,18L,91L,98L,20L,72L,16L,22L,52L,34L,24L,32L,52L,26L,12L,70L,27L,92L,88L,29L,73L,6L,31L,53L,24L,33L,33L,42L,35L,13L,60L,36L,93L,78L,38L,73L,96L,40L,54L,14L,42L,34L,32L,44L,14L,50L,45L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087411Inst : IEnumerable<long>
{
public static readonly long[] Value=A087411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087411.Bytes);
public long this[int i]=>Value[i];

public static A087411Inst Instance=new A087411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087410
{
public static readonly long[] Value={ 81L,62L,43L,24L,4L,85L,66L,47L,28L,8L,89L,61L,4L,11L,21L,20L,12L,81L,36L,14L,41L,52L,16L,1L,68L,17L,61L,84L,19L,22L,0L,20L,82L,16L,22L,42L,32L,24L,2L,48L,25L,62L,64L,27L,22L,80L,28L,82L,96L,30L,43L,12L,32L,3L,28L,33L,63L,44L,35L,23L,60L,36L,83L,76L,38L,43L,92L,40L,4L,8L,41L,64L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087410Inst : IEnumerable<long>
{
public static readonly long[] Value=A087410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087410.Bytes);
public long this[int i]=>Value[i];

public static A087410Inst Instance=new A087410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087409
{
public static readonly long[] Value={ 61L,21L,82L,43L,3L,64L,24L,85L,46L,6L,67L,27L,88L,49L,9L,61L,2L,10L,81L,14L,12L,1L,26L,13L,21L,38L,14L,41L,50L,15L,61L,62L,16L,81L,74L,18L,1L,86L,19L,21L,98L,20L,42L,10L,21L,62L,22L,22L,82L,34L,24L,2L,46L,25L,22L,58L,26L,42L,70L,27L,62L,82L,28L,82L,94L,30L,3L,6L,31L,23L,18L,32L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087409Inst : IEnumerable<long>
{
public static readonly long[] Value=A087409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087409.Bytes);
public long this[int i]=>Value[i];

public static A087409Inst Instance=new A087409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087408
{
public static readonly long[] Value={ 51L,1L,52L,2L,53L,3L,54L,4L,55L,5L,56L,6L,57L,7L,58L,8L,59L,9L,51L,0L,10L,51L,10L,11L,51L,20L,12L,51L,30L,13L,51L,40L,14L,51L,50L,15L,51L,60L,16L,51L,70L,17L,51L,80L,18L,51L,90L,19L,52L,0L,20L,52L,10L,21L,52L,20L,22L,52L,30L,23L,52L,40L,24L,52L,50L,25L,52L,60L,26L,52L,70L,27L,52L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087408Inst : IEnumerable<long>
{
public static readonly long[] Value=A087408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087408.Bytes);
public long this[int i]=>Value[i];

public static A087408Inst Instance=new A087408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087407
{
public static readonly long[] Value={ 48L,12L,16L,20L,24L,28L,32L,36L,40L,44L,48L,52L,56L,60L,64L,68L,72L,76L,80L,84L,88L,92L,96L,10L,1L,4L,10L,81L,12L,11L,61L,20L,12L,41L,28L,13L,21L,36L,14L,1L,44L,14L,81L,52L,15L,61L,60L,16L,41L,68L,17L,21L,76L,18L,1L,84L,18L,81L,92L,19L,62L,0L,20L,42L,8L,21L,22L,16L,22L,2L,24L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087407Inst : IEnumerable<long>
{
public static readonly long[] Value=A087407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087407.Bytes);
public long this[int i]=>Value[i];

public static A087407Inst Instance=new A087407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087406
{
public static readonly long[] Value={ 24L,68L,10L,12L,14L,16L,18L,20L,22L,24L,26L,28L,30L,32L,34L,36L,38L,40L,42L,44L,46L,48L,50L,52L,54L,56L,58L,60L,62L,64L,66L,68L,70L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,96L,98L,10L,1L,2L,10L,41L,6L,10L,81L,10L,11L,21L,14L,11L,61L,18L,12L,1L,22L,12L,41L,26L,12L,81L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087406Inst : IEnumerable<long>
{
public static readonly long[] Value=A087406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087406.Bytes);
public long this[int i]=>Value[i];

public static A087406Inst Instance=new A087406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087405
{
public static readonly long[] Value={ 2L,2L,22L,98L,502L,2498L,12502L,62498L,312502L,1562498L,7812502L,39062498L,195312502L,976562498L,4882812502L,24414062498L,122070312502L,610351562498L,3051757812502L,15258789062498L,76293945312502L,381469726562498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087405Inst : IEnumerable<long>
{
public static readonly long[] Value=A087405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087405.Bytes);
public long this[int i]=>Value[i];

public static A087405Inst Instance=new A087405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087404
{
public static readonly long[] Value={ 2L,4L,26L,124L,626L,3124L,15626L,78124L,390626L,1953124L,9765626L,48828124L,244140626L,1220703124L,6103515626L,30517578124L,152587890626L,762939453124L,3814697265626L,19073486328124L,95367431640626L,476837158203124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087404Inst : IEnumerable<long>
{
public static readonly long[] Value=A087404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087404.Bytes);
public long this[int i]=>Value[i];

public static A087404Inst Instance=new A087404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087403
{
public static readonly BigInteger[] Value={ 11L,2221L,31L,41L,555555555551L,61L,71L,881L,991L,101L,1111111111111111111L,1212121L,131L,14141414141L,151L,1616161L,BigInteger.Parse("1717171717171717171717171717171"),181L,191L,20201L,211L };
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
public class A087403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087403Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087403.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087403.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087403Inst Instance=new A087403Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087402
{
public static readonly long[] Value={ 11L,222L,44L,222L,22L,66L,44L,22L,66L,222L,222L,66L,222L,888L,44L,666L,88L,44L,22L,888L,66L,44L,88L,444L,66L,222L,66L,66L,44L,222L,22L,66L,66L,66L,44L,66L,888L,22L,44L,88L,66L,222L,444L,66L,2222L,22L,666L,2222L,22L,66L,44L,66L,22L,66L,222L,222L,6666L,44L,22L,66L,444L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087402Inst : IEnumerable<long>
{
public static readonly long[] Value=A087402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087402.Bytes);
public long this[int i]=>Value[i];

public static A087402Inst Instance=new A087402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087401
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,0L,2L,3L,3L,0L,3L,5L,6L,6L,0L,4L,7L,9L,10L,10L,0L,5L,9L,12L,14L,15L,15L,0L,6L,11L,15L,18L,20L,21L,21L,0L,7L,13L,18L,22L,25L,27L,28L,28L,0L,8L,15L,21L,26L,30L,33L,35L,36L,36L,0L,9L,17L,24L,30L,35L,39L,42L,44L,45L,45L,0L,10L,19L,27L,34L,40L,45L,49L,52L,54L,55L,55L,0L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087401Inst : IEnumerable<long>
{
public static readonly long[] Value=A087401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087401.Bytes);
public long this[int i]=>Value[i];

public static A087401Inst Instance=new A087401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087400
{
public static readonly BigInteger[] Value={ 13L,163L,2803L,3565153L,210344143L,BigInteger.Parse("86915972211813115391953"),BigInteger.Parse("4419764102942908730796303703"),BigInteger.Parse("114681479899746991802547357477494803") };
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
public class A087400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087400Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087400.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087400.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087400Inst Instance=new A087400Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087399
{
public static readonly long[] Value={ 25L,121L,5041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087399Inst : IEnumerable<long>
{
public static readonly long[] Value=A087399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087399.Bytes);
public long this[int i]=>Value[i];

public static A087399Inst Instance=new A087399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087398
{
public static readonly BigInteger[] Value={ 13L,103L,1153L,15013L,255253L,4849843L,111546433L,100280245063L,152125131763603L,16294579238595022363UL,BigInteger.Parse("278970415063349480483707693"),BigInteger.Parse("11992411764462614086353260819346129198103"),BigInteger.Parse("481473710367991963528473107950567214598209565303106537707981745633") };
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
public class A087398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087398Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087398.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087398.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087398Inst Instance=new A087398Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087397
{
public static readonly long[] Value={ 3L,10L,6L,15L,45L,66L,120L,153L,231L,378L,435L,630L,780L,861L,1035L,1326L,1653L,1770L,2145L,2415L,2556L,3003L,3321L,3828L,4560L,4950L,5151L,5565L,5778L,6216L,7875L,8385L,9180L,9453L,10878L,11175L,12090L,13041L,13695L,14706L,15753L,16110L,17955L,18336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087397Inst : IEnumerable<long>
{
public static readonly long[] Value=A087397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087397.Bytes);
public long this[int i]=>Value[i];

public static A087397Inst Instance=new A087397Inst();

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