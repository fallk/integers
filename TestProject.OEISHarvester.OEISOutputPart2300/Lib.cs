using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A274151
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,2L,2L,4L,5L,6L,8L,11L,14L,17L,20L,26L,36L,45L,56L,74L,96L,120L,150L,191L,245L,318L,405L,517L,665L,850L,1073L,1364L,1749L,2233L,2860L,3660L,4678L,5970L,7610L,9691L,12357L,15808L,20190L,25815L,32990L,42127L,53730L,68537L,87474L,111636L,142653L,182214L,232784L,297231L,379421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274151Inst : IEnumerable<long>
{
public static readonly long[] Value=A274151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274151.Bytes);
public long this[int i]=>Value[i];

public static A274151Inst Instance=new A274151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274150
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,4L,5L,7L,10L,14L,17L,23L,33L,43L,61L,82L,111L,150L,202L,278L,376L,516L,694L,941L,1281L,1731L,2369L,3208L,4364L,5915L,8015L,10911L,14792L,20139L,27314L,37082L,50358L,68309L,92891L,126054L,171277L,232504L,315584L,428704L,581880L,790589L,1073298L,1457466L,1979119L,2686767L,3649316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274150Inst : IEnumerable<long>
{
public static readonly long[] Value=A274150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274150.Bytes);
public long this[int i]=>Value[i];

public static A274150Inst Instance=new A274150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274149
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,3L,4L,6L,7L,9L,12L,17L,22L,29L,38L,51L,68L,90L,119L,158L,209L,277L,368L,489L,648L,858L,1137L,1509L,2002L,2655L,3520L,4667L,6189L,8208L,10885L,14436L,19141L,25382L,33659L,44638L,59195L,78497L,104092L,138036L,183050L,242745L,321904L,426875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274149Inst : IEnumerable<long>
{
public static readonly long[] Value=A274149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274149.Bytes);
public long this[int i]=>Value[i];

public static A274149Inst Instance=new A274149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274148
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,3L,5L,6L,8L,12L,17L,23L,32L,44L,61L,86L,119L,164L,228L,318L,442L,614L,850L,1181L,1643L,2282L,3167L,4398L,6110L,8489L,11790L,16372L,22737L,31584L,43870L,60930L,84622L,117533L,163248L,226742L,314918L,437389L,607498L,843772L,1171927L,1627699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274148Inst : IEnumerable<long>
{
public static readonly long[] Value=A274148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274148.Bytes);
public long this[int i]=>Value[i];

public static A274148Inst Instance=new A274148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274115
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,8L,17L,35L,75L,157L,337L,712L,1529L,3248L,6976L,14869L,31937L,68222L,146536L,313487L,673351L,1441999L,3097326L,6637879L,14257734L,30572032L,65666593L,140860379L,302557585L,649202036L,1394434685L,2992721902L,6428118868L,13798302512L,29637567305L,63626933527L,136665012979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274115Inst : IEnumerable<long>
{
public static readonly long[] Value=A274115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274115.Bytes);
public long this[int i]=>Value[i];

public static A274115Inst Instance=new A274115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274114
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,8L,17L,37L,81L,180L,405L,917L,2090L,4795L,11054L,25589L,59475L,138712L,324483L,761163L,1790028L,4219139L,9965328L,23582735L,55906518L,132751359L,315700152L,751837207L,1792853416L,4280568845L,10232005939L,24484563844L,58650123942L,140625967460L,337488663293L,810641635789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274114Inst : IEnumerable<long>
{
public static readonly long[] Value=A274114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274114.Bytes);
public long this[int i]=>Value[i];

public static A274114Inst Instance=new A274114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274113
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,5L,7L,11L,16L,26L,39L,63L,95L,154L,235L,381L,585L,948L,1464L,2373L,3682L,5967L,9293L,15060L,23531L,38131L,59741L,96801L,152020L,246310L,387611L,627985L,990027L,1603893L,2532609L,4102726L,6487600L,10509114L,16639214L,26952186L,42722941L,69199472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274113Inst : IEnumerable<long>
{
public static readonly long[] Value=A274113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274113.Bytes);
public long this[int i]=>Value[i];

public static A274113Inst Instance=new A274113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274112
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,4L,5L,8L,12L,17L,23L,35L,52L,75L,105L,157L,232L,337L,480L,712L,1049L,1529L,2199L,3248L,4777L,6976L,10092L,14869L,21845L,31937L,46377L,68222L,100159L,146536L,213328L,313487L,460023L,673351L,981976L,1441999L,2115350L,3097326L,4522529L,6637879L,9735205L,14257734L,20836827L,30572032L,44829766L,65666593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274112Inst : IEnumerable<long>
{
public static readonly long[] Value=A274112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274112.Bytes);
public long this[int i]=>Value[i];

public static A274112Inst Instance=new A274112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274111
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,3L,5L,7L,10L,13L,20L,28L,45L,65L,101L,143L,222L,317L,500L,726L,1143L,1661L,2608L,3796L,5983L,8764L,13835L,20335L,32089L,47251L,74637L,110227L,174302L,258095L,408276L,605664L,958551L,1424659L,2256136L,3359446L,5322449L,7937666L,12580545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274111Inst : IEnumerable<long>
{
public static readonly long[] Value=A274111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274111.Bytes);
public long this[int i]=>Value[i];

public static A274111Inst Instance=new A274111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274110
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,14L,24L,42L,73L,128L,224L,393L,689L,1209L,2121L,3722L,6531L,11461L,20112L,35294L,61936L,108690L,190737L,334720L,587392L,1030801L,1808929L,3174449L,5570769L,9776018L,17155715L,30106181L,52832664L,92714862L,162703240L,285524282L,501060185L,879299328L,1543062752L,2707886361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274110Inst : IEnumerable<long>
{
public static readonly long[] Value=A274110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274110.Bytes);
public long this[int i]=>Value[i];

public static A274110Inst Instance=new A274110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274109
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,1L,1L,2L,1L,3L,3L,2L,2L,1L,2L,2L,2L,2L,2L,1L,3L,3L,2L,3L,2L,2L,1L,2L,2L,4L,1L,3L,2L,2L,1L,5L,5L,3L,4L,2L,3L,2L,2L,1L,2L,2L,2L,2L,3L,2L,3L,2L,2L,1L,6L,6L,4L,5L,2L,4L,2L,3L,2L,2L,1L,3L,3L,5L,3L,4L,1L,4L,2L,3L,2L,2L,1L,4L,4L,3L,3L,4L,4L,2L,4L,2L,3L,2L,2L,1L,4L,4L,5L,3L,4L,3L,3L,2L,4L,2L,3L,2L,2L,1L,8L,8L,5L,7L,3L,5L,3L,4L,2L,4L,2L,3L,2L,2L,1L,3L,3L,5L,2L,5L,2L,4L,2L,4L,2L,4L,2L,3L,2L,2L,1L,9L,9L,6L,7L,3L,7L,3L,4L,3L,4L,2L,4L,2L,3L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274109Inst : IEnumerable<long>
{
public static readonly long[] Value=A274109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274109.Bytes);
public long this[int i]=>Value[i];

public static A274109Inst Instance=new A274109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274108
{
public static readonly long[] Value={ 0L,0L,1L,2L,5L,5L,11L,11L,16L,17L,27L,21L,37L,33L,38L,42L,59L,46L,71L,57L,70L,75L,97L,72L,104L,99L,109L,103L,141L,102L,157L,133L,148L,153L,166L,140L,207L,183L,192L,174L,241L,180L,259L,215L,223L,247L,295L,219L,300L,260L,292L,279L,353L,275L,336L,300L,346L,351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274108Inst : IEnumerable<long>
{
public static readonly long[] Value=A274108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274108.Bytes);
public long this[int i]=>Value[i];

public static A274108Inst Instance=new A274108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274107
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,13L,-1L,-9L,4L,8L,0L,13L,8L,0L,49L,17L,-9L,34L,-7L,-33L,10L,-13L,-39L,28L,-4L,-30L,13L,26L,0L,43L,20L,-6L,61L,29L,3L,46L,32L,6L,49L,26L,0L,157L,71L,-9L,124L,29L,-51L,82L,5L,-75L,130L,44L,-36L,97L,-25L,-105L,28L,-49L,-129L,76L,-10L,-90L,43L,-25L,-105L,28L,-49L,-129L,100L,14L,-66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274107Inst : IEnumerable<long>
{
public static readonly long[] Value=A274107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274107.Bytes);
public long this[int i]=>Value[i];

public static A274107Inst Instance=new A274107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274106
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,2L,1L,8L,14L,4L,1L,12L,38L,32L,4L,1L,18L,98L,184L,100L,8L,1L,24L,188L,576L,652L,208L,8L,1L,32L,356L,1704L,3532L,2816L,632L,16L,1L,40L,580L,3840L,12052L,16944L,9080L,1280L,16L,1L,50L,940L,8480L,38932L,89256L,93800L,37600L,3856L,32L,1L,60L,1390L,16000L,98292L,322848L,540080L,412800L,116656L,7744L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274106Inst : IEnumerable<long>
{
public static readonly long[] Value=A274106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274106.Bytes);
public long this[int i]=>Value[i];

public static A274106Inst Instance=new A274106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274105
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,5L,4L,1L,8L,14L,4L,1L,13L,46L,46L,8L,1L,18L,98L,184L,100L,8L,1L,25L,206L,674L,836L,308L,16L,1L,32L,356L,1704L,3532L,2816L,632L,16L,1L,41L,612L,4196L,13756L,20476L,11896L,1912L,32L,1L,50L,940L,8480L,38932L,89256L,93800L,37600L,3856L,32L,1L,61L,1440L,16940L,106772L,361780L,629336L,506600L,154256L,11600L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274105Inst : IEnumerable<long>
{
public static readonly long[] Value=A274105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274105.Bytes);
public long this[int i]=>Value[i];

public static A274105Inst Instance=new A274105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274104
{
public static readonly long[] Value={ 2L,7L,23L,78L,274L,988L,3628L,13495L,50675L,191673L,729145L,2786655L,10691111L,41150011L,158825371L,614483086L,2382366586L,9253540456L,36001307656L,140269835866L,547245301906L,2137552658206L,8358366985726L,32715599554876L,128168506456852L,502538379368656L,1971926625140816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274104Inst : IEnumerable<long>
{
public static readonly long[] Value=A274104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274104.Bytes);
public long this[int i]=>Value[i];

public static A274104Inst Instance=new A274104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274103
{
public static readonly long[] Value={ 3L,6L,17L,66L,327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274103Inst : IEnumerable<long>
{
public static readonly long[] Value=A274103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274103.Bytes);
public long this[int i]=>Value[i];

public static A274103Inst Instance=new A274103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274102
{
public static readonly long[] Value={ 0L,0L,1L,-1L,2L,-2L,3L,-3L,4L,-4L,4L,-4L,4L,-4L,3L,-3L,2L,-2L,1L,-1L,0L,0L,-2L,2L,-4L,4L,-6L,6L,-8L,8L,-10L,10L,-12L,12L,-14L,14L,-16L,16L,-18L,18L,-19L,19L,-21L,21L,-22L,22L,-23L,23L,-24L,24L,-24L,24L,-24L,24L,-24L,24L,-23L,23L,-23L,23L,-22L,22L,-20L,20L,-19L,19L,-17L,17L,-15L,15L,-13L,13L,-10L,10L,-7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274102Inst : IEnumerable<long>
{
public static readonly long[] Value=A274102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274102.Bytes);
public long this[int i]=>Value[i];

public static A274102Inst Instance=new A274102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274101
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,-1L,-1L,2L,0L,-2L,0L,3L,0L,-3L,0L,4L,-2L,-4L,2L,4L,-3L,-4L,3L,4L,-5L,-4L,5L,3L,-6L,-3L,6L,2L,-8L,-2L,8L,1L,-9L,-1L,9L,0L,-10L,0L,10L,-2L,-11L,2L,11L,-4L,-11L,4L,11L,-6L,-12L,6L,12L,-8L,-12L,8L,12L,-10L,-11L,10L,11L,-12L,-10L,12L,10L,-14L,-9L,14L,9L,-16L,-8L,16L,8L,-18L,-7L,18L,7L,-19L,-5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274101Inst : IEnumerable<long>
{
public static readonly long[] Value=A274101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274101.Bytes);
public long this[int i]=>Value[i];

public static A274101Inst Instance=new A274101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274100
{
public static readonly long[] Value={ 1L,2L,5L,15L,64L,351L,2280L,16335L,123464L,959631L,7566280L,60090255L,478968264L,3824743311L,30569959880L,244447781775L,1955134763464L,15639288341391L,125107148059080L,1000828550570895L,8006513870533064L,64051652831273871L,512411390124519880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274100Inst : IEnumerable<long>
{
public static readonly long[] Value=A274100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274100.Bytes);
public long this[int i]=>Value[i];

public static A274100Inst Instance=new A274100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273651
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,8L,10L,7L,1L,24L,21L,31L,30L,31L,27L,29L,14L,49L,64L,19L,67L,37L,20L,56L,20L,74L,50L,34L,73L,29L,109L,64L,4L,137L,66L,32L,154L,64L,106L,51L,119L,97L,95L,110L,63L,102L,169L,28L,166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273651Inst : IEnumerable<long>
{
public static readonly long[] Value=A273651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273651.Bytes);
public long this[int i]=>Value[i];

public static A273651Inst Instance=new A273651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273650
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,8L,0L,0L,0L,10L,0L,7L,0L,0L,20L,1L,0L,0L,16L,0L,0L,24L,0L,21L,0L,21L,32L,0L,0L,31L,22L,27L,0L,30L,0L,31L,24L,0L,22L,27L,0L,0L,0L,21L,28L,29L,0L,45L,0L,54L,4L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273650Inst : IEnumerable<long>
{
public static readonly long[] Value=A273650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273650.Bytes);
public long this[int i]=>Value[i];

public static A273650Inst Instance=new A273650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273649
{
public static readonly long[] Value={ 3L,13L,11L,33L,28L,32L,39L,73L,52L,72L,44L,108L,20L,92L,15L,213L,152L,108L,148L,120L,72L,152L,68L,144L,284L,24L,176L,248L,76L,168L,39L,381L,256L,244L,296L,256L,116L,292L,-24L,388L,340L,156L,92L,400L,200L,236L,84L,428L,636L,268L,276L,356L,48L,640L,-88L,504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273649Inst : IEnumerable<long>
{
public static readonly long[] Value=A273649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273649.Bytes);
public long this[int i]=>Value[i];

public static A273649Inst Instance=new A273649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273648
{
public static readonly long[] Value={ 1L,5L,22L,50L,111L,200L,321L,481L,714L,999L,1356L,1757L,2266L,2795L,3416L,4052L,4901L,5902L,7011L,8268L,9645L,11094L,12695L,14364L,16177L,18274L,20395L,22692L,25237L,27858L,30647L,33475L,36684L,40149L,43858L,47863L,52124L,56501L,61170L,65815L,70848L,76221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273648Inst : IEnumerable<long>
{
public static readonly long[] Value=A273648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273648.Bytes);
public long this[int i]=>Value[i];

public static A273648Inst Instance=new A273648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273647
{
public static readonly long[] Value={ 1L,4L,28L,160L,636L,2828L,11620L,47388L,189744L,762824L,3056616L,12220008L,48892908L,195589736L,782409540L,3129838452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273647Inst : IEnumerable<long>
{
public static readonly long[] Value=A273647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273647.Bytes);
public long this[int i]=>Value[i];

public static A273647Inst Instance=new A273647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273646
{
public static readonly long[] Value={ 1L,4L,17L,28L,61L,89L,121L,160L,233L,285L,357L,401L,509L,529L,621L,636L,849L,1001L,1109L,1257L,1377L,1449L,1601L,1669L,1813L,2097L,2121L,2297L,2545L,2621L,2789L,2828L,3209L,3465L,3709L,4005L,4261L,4377L,4669L,4645L,5033L,5373L,5529L,5621L,6021L,6221L,6457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273646Inst : IEnumerable<long>
{
public static readonly long[] Value=A273646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273646.Bytes);
public long this[int i]=>Value[i];

public static A273646Inst Instance=new A273646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273645
{
public static readonly long[] Value={ 4L,4L,12L,8L,12L,12L,36L,28L,12L,12L,36L,28L,28L,20L,100L,68L,-4L,-20L,20L,-4L,20L,28L,92L,60L,28L,12L,100L,60L,76L,52L,324L,324L,-84L,-188L,12L,-36L,-28L,44L,84L,-20L,44L,36L,60L,44L,100L,36L,300L,284L,-44L,-132L,84L,-12L,68L,116L,284L,148L,92L,36L,260L,164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273645Inst : IEnumerable<long>
{
public static readonly long[] Value=A273645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273645.Bytes);
public long this[int i]=>Value[i];

public static A273645Inst Instance=new A273645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273644
{
public static readonly long[] Value={ 1L,6L,15L,36L,65L,106L,159L,248L,365L,494L,635L,812L,1017L,1250L,1503L,1856L,2277L,2694L,3091L,3508L,3921L,4354L,4815L,5368L,5981L,6622L,7275L,8028L,8841L,9730L,10671L,11936L,13525L,15030L,16347L,17676L,18969L,20234L,21543L,22936L,24309L,25726L,27179L,28692L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273644Inst : IEnumerable<long>
{
public static readonly long[] Value=A273644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273644.Bytes);
public long this[int i]=>Value[i];

public static A273644Inst Instance=new A273644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273643
{
public static readonly long[] Value={ 1L,5L,21L,89L,353L,1265L,4673L,17697L,68113L,265001L,1038577L,4091673L,16181889L,64179177L,255083473L,1015457849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273643Inst : IEnumerable<long>
{
public static readonly long[] Value=A273643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273643.Bytes);
public long this[int i]=>Value[i];

public static A273643Inst Instance=new A273643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273642
{
public static readonly long[] Value={ 1L,5L,9L,21L,29L,41L,53L,89L,117L,129L,141L,177L,205L,233L,253L,353L,421L,417L,397L,417L,413L,433L,461L,553L,613L,641L,653L,753L,813L,889L,941L,1265L,1589L,1505L,1317L,1329L,1293L,1265L,1309L,1393L,1373L,1417L,1453L,1513L,1557L,1657L,1693L,1993L,2277L,2233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273642Inst : IEnumerable<long>
{
public static readonly long[] Value=A273642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273642.Bytes);
public long this[int i]=>Value[i];

public static A273642Inst Instance=new A273642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273641
{
public static readonly long[] Value={ 7L,13L,23L,25L,48L,36L,52L,36L,103L,73L,76L,52L,172L,76L,108L,44L,240L,128L,100L,68L,312L,160L,116L,132L,244L,188L,160L,88L,460L,148L,144L,152L,388L,284L,196L,132L,524L,276L,292L,220L,332L,372L,260L,276L,496L,328L,84L,356L,512L,464L,240L,88L,808L,384L,364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273641Inst : IEnumerable<long>
{
public static readonly long[] Value=A273641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273641.Bytes);
public long this[int i]=>Value[i];

public static A273641Inst Instance=new A273641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273640
{
public static readonly long[] Value={ 1L,9L,30L,74L,143L,260L,413L,618L,859L,1203L,1620L,2113L,2658L,3375L,4168L,5069L,6014L,7199L,8512L,9925L,11406L,13199L,15152L,17221L,19422L,21867L,24500L,27293L,30174L,33515L,37004L,40637L,44422L,48595L,53052L,57705L,62490L,67799L,73384L,79261L,85358L,91787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273640Inst : IEnumerable<long>
{
public static readonly long[] Value=A273640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273640.Bytes);
public long this[int i]=>Value[i];

public static A273640Inst Instance=new A273640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273639
{
public static readonly long[] Value={ 1L,8L,44L,205L,901L,3633L,14677L,59125L,237109L,951249L,3804061L,15204521L,60841793L,243398773L,973620069L,3894638321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273639Inst : IEnumerable<long>
{
public static readonly long[] Value=A273639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273639.Bytes);
public long this[int i]=>Value[i];

public static A273639Inst Instance=new A273639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273638
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,11L,11L,11L,2L,3L,2L,2L,3L,4L,5L,3L,3L,3L,5L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,3L,3L,4L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273638Inst : IEnumerable<long>
{
public static readonly long[] Value=A273638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273638.Bytes);
public long this[int i]=>Value[i];

public static A273638Inst Instance=new A273638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273637
{
public static readonly long[] Value={ 9L,3L,9L,3L,2L,5L,6L,5L,1L,5L,6L,7L,6L,3L,6L,1L,5L,9L,4L,1L,6L,1L,0L,1L,4L,3L,2L,4L,1L,4L,6L,6L,1L,3L,6L,6L,1L,4L,2L,8L,8L,8L,6L,4L,1L,7L,0L,4L,7L,9L,1L,6L,1L,0L,9L,3L,2L,9L,5L,9L,1L,8L,7L,2L,3L,5L,7L,8L,7L,3L,7L,9L,0L,3L,3L,9L,5L,2L,4L,5L,3L,9L,5L,2L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273637Inst : IEnumerable<long>
{
public static readonly long[] Value=A273637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273637.Bytes);
public long this[int i]=>Value[i];

public static A273637Inst Instance=new A273637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273636
{
public static readonly long[] Value={ 9L,1L,0L,4L,5L,3L,1L,8L,1L,4L,0L,9L,2L,4L,2L,2L,7L,9L,1L,6L,9L,5L,3L,8L,0L,3L,4L,4L,6L,6L,2L,5L,8L,6L,2L,8L,5L,7L,4L,5L,8L,6L,5L,8L,0L,2L,9L,4L,3L,3L,8L,0L,1L,2L,6L,5L,0L,6L,1L,5L,5L,4L,9L,9L,2L,1L,3L,6L,4L,6L,6L,2L,5L,0L,0L,5L,2L,6L,4L,8L,2L,1L,0L,7L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273636Inst : IEnumerable<long>
{
public static readonly long[] Value=A273636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273636.Bytes);
public long this[int i]=>Value[i];

public static A273636Inst Instance=new A273636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273539
{
public static readonly long[] Value={ 1L,5L,37L,197L,901L,3845L,15877L,64517L,260101L,1044485L,4186117L,16760837L,67076101L,268369925L,1073610757L,4294705157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273539Inst : IEnumerable<long>
{
public static readonly long[] Value=A273539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273539.Bytes);
public long this[int i]=>Value[i];

public static A273539Inst Instance=new A273539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273538
{
public static readonly long[] Value={ 1L,5L,17L,37L,61L,97L,125L,197L,237L,305L,337L,473L,521L,617L,629L,901L,973L,1105L,1137L,1401L,1449L,1609L,1561L,2089L,2169L,2361L,2345L,2785L,2785L,3001L,2789L,3845L,3981L,4241L,4273L,4793L,4841L,5129L,4953L,5993L,6073L,6393L,6249L,7073L,6945L,7289L,6697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273538Inst : IEnumerable<long>
{
public static readonly long[] Value=A273538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273538.Bytes);
public long this[int i]=>Value[i];

public static A273538Inst Instance=new A273538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273537
{
public static readonly long[] Value={ 4L,4L,8L,0L,16L,20L,12L,0L,8L,8L,32L,8L,28L,64L,28L,16L,-16L,0L,40L,40L,12L,12L,60L,48L,72L,20L,48L,32L,76L,124L,92L,-8L,-48L,-4L,56L,60L,-4L,36L,60L,40L,200L,56L,48L,20L,36L,156L,68L,-52L,160L,96L,0L,16L,68L,180L,132L,52L,256L,52L,232L,104L,52L,192L,244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273537Inst : IEnumerable<long>
{
public static readonly long[] Value=A273537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273537.Bytes);
public long this[int i]=>Value[i];

public static A273537Inst Instance=new A273537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273536
{
public static readonly long[] Value={ 1L,6L,15L,32L,49L,82L,135L,200L,265L,338L,419L,532L,653L,802L,1015L,1256L,1513L,1754L,1995L,2276L,2597L,2930L,3275L,3680L,4133L,4658L,5203L,5796L,6421L,7122L,7947L,8864L,9773L,10634L,11491L,12404L,13377L,14346L,15351L,16416L,17521L,18826L,20187L,21596L,23025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273536Inst : IEnumerable<long>
{
public static readonly long[] Value=A273536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273536.Bytes);
public long this[int i]=>Value[i];

public static A273536Inst Instance=new A273536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273535
{
public static readonly long[] Value={ 1L,5L,17L,65L,241L,917L,3473L,13145L,50593L,198689L,779069L,3087701L,12314561L,49200165L,196648533L,785726841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273535Inst : IEnumerable<long>
{
public static readonly long[] Value=A273535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273535.Bytes);
public long this[int i]=>Value[i];

public static A273535Inst Instance=new A273535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273534
{
public static readonly long[] Value={ 1L,5L,9L,17L,17L,33L,53L,65L,65L,73L,81L,113L,121L,149L,213L,241L,257L,241L,241L,281L,321L,333L,345L,405L,453L,525L,545L,593L,625L,701L,825L,917L,909L,861L,857L,913L,973L,969L,1005L,1065L,1105L,1305L,1361L,1409L,1429L,1465L,1621L,1689L,1637L,1797L,1893L,1893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273534Inst : IEnumerable<long>
{
public static readonly long[] Value=A273534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273534.Bytes);
public long this[int i]=>Value[i];

public static A273534Inst Instance=new A273534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273533
{
public static readonly long[] Value={ 3L,9L,11L,29L,16L,36L,15L,73L,3L,121L,-1L,89L,63L,33L,115L,149L,-53L,237L,-57L,301L,-41L,121L,159L,213L,-69L,301L,-5L,225L,107L,229L,55L,309L,-61L,529L,-133L,389L,-1L,461L,-29L,301L,15L,613L,-173L,705L,-165L,429L,167L,317L,23L,561L,-113L,809L,-169L,629L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273533Inst : IEnumerable<long>
{
public static readonly long[] Value=A273533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273533.Bytes);
public long this[int i]=>Value[i];

public static A273533Inst Instance=new A273533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273532
{
public static readonly long[] Value={ 1L,5L,18L,42L,95L,164L,269L,389L,582L,778L,1095L,1411L,1816L,2284L,2785L,3401L,4166L,4878L,5827L,6719L,7912L,9064L,10337L,11769L,13414L,14990L,16867L,18739L,20836L,23040L,25473L,27961L,30758L,33494L,36759L,39891L,43412L,46932L,50913L,54865L,59118L,63386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273532Inst : IEnumerable<long>
{
public static readonly long[] Value=A273532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273532.Bytes);
public long this[int i]=>Value[i];

public static A273532Inst Instance=new A273532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273531
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,10001L,10001L,1L,1L,10001L,10001L,100000001L,100000001L,1000100010001L,1000100010001L,1L,1L,10001L,10001L,100000001L,100000001L,1000100010001L,1000100010001L,10000000000000001L,10000000000000001L,BigInteger.Parse("100010000000000010001"),BigInteger.Parse("100010000000000010001") };
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
public class A273531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273531Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273531.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273531.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273531Inst Instance=new A273531Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273530
{
public static readonly long[] Value={ 349L,853L,12634L,42937L,51741L,59912L,97677L,169748L,195137L,199528L,231892L,269728L,337768L,343636L,392272L,403037L,599561L,920456L,1458538L,1521873L,1645873L,1894121L,2337928L,2388697L,3131728L,3159673L,3186349L,3731769L,3835024L,3890248L,4037794L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273530Inst : IEnumerable<long>
{
public static readonly long[] Value=A273530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273530.Bytes);
public long this[int i]=>Value[i];

public static A273530Inst Instance=new A273530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273529
{
public static readonly long[] Value={ 337L,409L,449L,577L,1009L,1129L,1489L,1801L,2377L,2521L,2609L,2689L,2833L,3041L,3169L,3329L,3361L,3433L,3529L,3889L,4049L,4513L,4657L,5209L,5569L,5689L,5857L,5881L,5953L,6529L,6553L,6569L,7177L,7297L,8009L,8089L,8209L,8329L,8641L,8737L,8761L,9433L,9697L,9769L,10169L,10321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273529Inst : IEnumerable<long>
{
public static readonly long[] Value=A273529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273529.Bytes);
public long this[int i]=>Value[i];

public static A273529Inst Instance=new A273529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273528
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,3L,2L,0L,2L,9L,10L,3L,0L,2L,25L,50L,35L,8L,0L,-12L,86L,270L,260L,102L,14L,0L,-120L,140L,1344L,2030L,1260L,350L,36L,0L,-1248L,-1016L,7336L,15862L,13048L,5236L,1024L,78L,0L,-9216L,-22464L,28528L,124488L,139776L,76104L,22152L,3312L,200L,0L,-90720L,-322344L,1860L,1036990L,1514205L,1018563L,379890L,80760L,9165L,431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273528Inst : IEnumerable<long>
{
public static readonly long[] Value=A273528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273528.Bytes);
public long this[int i]=>Value[i];

public static A273528Inst Instance=new A273528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273527
{
public static readonly long[] Value={ 8L,18L,24L,20L,26L,10L,166L,19L,48L,14L,58L,45L,205L,31L,248L,30L,49L,178L,3054L,122L,140L,294L,174L,80L,152L,233L,79L,920L,295L,359L,107L,308L,257L,8L,180L,96L,98L,34L,230L,921L,527L,164L,428L,901L,344L,88L,627L,1003L,192L,240L,50L,38L,1747L,609L,1028L,432L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273527Inst : IEnumerable<long>
{
public static readonly long[] Value=A273527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273527.Bytes);
public long this[int i]=>Value[i];

public static A273527Inst Instance=new A273527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273526
{
public static readonly long[] Value={ 1L,1L,3L,11L,38L,127L,423L,1423L,4854L,16787L,58776L,208001L,742888L,2674427L,9694831L,35357655L,129644774L,477638683L,1767263172L,6564120401L,24466267000L,91482563619L,343059613628L,1289904147301L,4861946401428L,18367353072127L,69533550915978L,263747951750333L,1002242216651340L,3814986502092275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273526Inst : IEnumerable<long>
{
public static readonly long[] Value=A273526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273526.Bytes);
public long this[int i]=>Value[i];

public static A273526Inst Instance=new A273526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273525
{
public static readonly long[] Value={ 2L,3L,5L,15L,875L,603919253973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273525Inst : IEnumerable<long>
{
public static readonly long[] Value=A273525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273525.Bytes);
public long this[int i]=>Value[i];

public static A273525Inst Instance=new A273525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273524
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,11L,17L,18L,54L,509L,529L,2526L,3042L,3421L,4485L,13127L,17602L,23825L,27381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273524Inst : IEnumerable<long>
{
public static readonly long[] Value=A273524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273524.Bytes);
public long this[int i]=>Value[i];

public static A273524Inst Instance=new A273524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273507
{
public static readonly long[] Value={ 6L,45L,72L,630L,30L,144L,14175L,56700L,3240L,10368L,467775L,42525L,45360L,3888L,62208L,42567525L,2910600L,145800L,272160L,31104L,746496L,1277025750L,3831077250L,471517200L,729000L,13996800L,559872L,497664L,97692469875L,114932317500L,10945935000L,20207880000L,4199040L,124416L,746496L,23887872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273507Inst : IEnumerable<long>
{
public static readonly long[] Value=A273507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273507.Bytes);
public long this[int i]=>Value[i];

public static A273507Inst Instance=new A273507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273506
{
public static readonly long[] Value={ 1L,-1L,7L,1L,-1L,11L,-1L,319L,-143L,715L,1L,-26L,559L,-221L,4199L,-2L,139L,-323L,6137L,-2261L,52003L,1L,-10897L,135983L,-4199L,527459L,-52003L,37145L,-1L,15409L,-317281L,21586489L,-52877L,7429L,-88711L,1964315L,1L,-76L,269123L,-100901L,274873L,-8671L,227447L,-227447L,39803225L,-2L,466003L,-213739L,522629L,-59074189L,226061641L,-10690009L,25701511L,-42077695L,547010035L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273506Inst : IEnumerable<long>
{
public static readonly long[] Value=A273506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273506.Bytes);
public long this[int i]=>Value[i];

public static A273506Inst Instance=new A273506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273505
{
public static readonly long[] Value={ 4L,0L,12L,-12L,20L,-8L,44L,-52L,36L,0L,80L,-84L,116L,-84L,148L,-164L,84L,-12L,180L,-184L,180L,-180L,280L,-272L,348L,-236L,352L,-264L,264L,-200L,396L,-364L,252L,-68L,356L,-408L,332L,-224L,324L,-172L,240L,-168L,420L,-440L,556L,-436L,664L,-552L,592L,-588L,552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273505Inst : IEnumerable<long>
{
public static readonly long[] Value=A273505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273505.Bytes);
public long this[int i]=>Value[i];

public static A273505Inst Instance=new A273505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273504
{
public static readonly long[] Value={ 1L,6L,11L,28L,33L,58L,75L,136L,145L,190L,235L,360L,401L,558L,631L,852L,909L,1050L,1179L,1488L,1613L,1918L,2043L,2448L,2581L,3062L,3307L,3904L,4237L,4834L,5231L,6024L,6453L,7134L,7747L,8716L,9277L,10170L,10839L,11832L,12653L,13714L,14607L,15920L,16793L,18222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273504Inst : IEnumerable<long>
{
public static readonly long[] Value=A273504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273504.Bytes);
public long this[int i]=>Value[i];

public static A273504Inst Instance=new A273504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273503
{
public static readonly long[] Value={ 1L,5L,17L,61L,221L,793L,2761L,11153L,43561L,174765L,695393L,2770901L,11045381L,44187869L,176521361L,706067621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273503Inst : IEnumerable<long>
{
public static readonly long[] Value=A273503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273503.Bytes);
public long this[int i]=>Value[i];

public static A273503Inst Instance=new A273503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273502
{
public static readonly long[] Value={ 1L,5L,5L,17L,5L,25L,17L,61L,9L,45L,45L,125L,41L,157L,73L,221L,57L,141L,129L,309L,125L,305L,125L,405L,133L,481L,245L,597L,333L,597L,397L,793L,429L,681L,613L,969L,561L,893L,669L,993L,821L,1061L,893L,1313L,873L,1429L,993L,1657L,1105L,1697L,1109L,1661L,1509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273502Inst : IEnumerable<long>
{
public static readonly long[] Value=A273502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273502.Bytes);
public long this[int i]=>Value[i];

public static A273502Inst Instance=new A273502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273501
{
public static readonly long[] Value={ 4L,12L,16L,32L,24L,48L,24L,96L,40L,80L,24L,160L,40L,112L,-8L,320L,72L,144L,24L,288L,40L,176L,-72L,576L,72L,208L,-40L,480L,-24L,240L,-264L,1152L,136L,272L,24L,544L,40L,304L,-200L,1088L,72L,336L,-168L,864L,-152L,368L,-648L,2176L,136L,400L,-104L,928L,-88L,432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273501Inst : IEnumerable<long>
{
public static readonly long[] Value=A273501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273501.Bytes);
public long this[int i]=>Value[i];

public static A273501Inst Instance=new A273501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273500
{
public static readonly long[] Value={ 1L,6L,23L,56L,121L,210L,347L,508L,765L,1062L,1439L,1840L,2401L,3002L,3715L,4420L,5445L,6542L,7783L,9048L,10601L,12194L,13963L,15660L,17933L,20278L,22831L,25344L,28337L,31306L,34515L,37460L,41557L,45790L,50295L,54824L,59897L,65010L,70427L,75644L,81949L,88326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273500Inst : IEnumerable<long>
{
public static readonly long[] Value=A273500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273500.Bytes);
public long this[int i]=>Value[i];

public static A273500Inst Instance=new A273500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273499
{
public static readonly long[] Value={ 1L,5L,17L,33L,65L,89L,137L,161L,257L,297L,377L,401L,561L,601L,713L,705L,1025L,1097L,1241L,1265L,1553L,1593L,1769L,1697L,2273L,2345L,2553L,2513L,2993L,2969L,3209L,2945L,4097L,4233L,4505L,4529L,5073L,5113L,5417L,5217L,6305L,6377L,6713L,6545L,7409L,7257L,7625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273499Inst : IEnumerable<long>
{
public static readonly long[] Value=A273499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273499.Bytes);
public long this[int i]=>Value[i];

public static A273499Inst Instance=new A273499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273498
{
public static readonly long[] Value={ 2L,65L,72L,128L,468L,730L,793L,1241L,1332L,1458L,2000L,2745L,3528L,4097L,4160L,4608L,4825L,5096L,5840L,5913L,6344L,8125L,8192L,9000L,9325L,9928L,12168L,13357L,13498L,14824L,15626L,15633L,15689L,16354L,17640L,18369L,18737L,19721L,19773L,21953L,22681L,27792L,29449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273498Inst : IEnumerable<long>
{
public static readonly long[] Value=A273498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273498.Bytes);
public long this[int i]=>Value[i];

public static A273498Inst Instance=new A273498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273497
{
public static readonly long[] Value={ 8L,49L,347L,2539L,20499L,172053L,1477193L,12994813L,116094359L,1049467021L,9579839305L,88147018203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273497Inst : IEnumerable<long>
{
public static readonly long[] Value=A273497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273497.Bytes);
public long this[int i]=>Value[i];

public static A273497Inst Instance=new A273497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273496
{
public static readonly long[] Value={ 1L,0L,2L,2L,0L,2L,0L,6L,0L,2L,6L,0L,8L,0L,2L,0L,20L,0L,10L,0L,2L,20L,0L,30L,0L,12L,0L,2L,0L,70L,0L,42L,0L,14L,0L,2L,70L,0L,112L,0L,56L,0L,16L,0L,2L,0L,252L,0L,168L,0L,72L,0L,18L,0L,2L,252L,0L,420L,0L,240L,0L,90L,0L,20L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273496Inst : IEnumerable<long>
{
public static readonly long[] Value=A273496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273496.Bytes);
public long this[int i]=>Value[i];

public static A273496Inst Instance=new A273496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273495
{
public static readonly ulong[] Value={ 1L,10L,100L,1000L,10000L,100010L,1000100L,10000000L,100000000L,1000100000L,10001000000L,100000001000L,1000000010000L,10001000100010L,100010001000100L,1000000000000000L,10000000000000000L,100010000000000000L,1000100000000000000L,10000000100000000000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273495Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A273495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273495.Bytes);
public ulong this[int i]=>Value[i];

public static A273495Inst Instance=new A273495Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273494
{
public static readonly long[] Value={ 2L,3L,3L,5L,4L,5L,4L,8L,7L,7L,5L,8L,7L,7L,5L,13L,11L,12L,9L,11L,10L,9L,6L,13L,11L,12L,9L,11L,10L,9L,6L,21L,18L,19L,14L,19L,17L,16L,11L,18L,15L,17L,13L,14L,13L,11L,7L,21L,18L,19L,14L,19L,17L,16L,11L,18L,15L,17L,13L,14L,13L,11L,7L,34L,29L,31L,23L,30L,27L,25L,17L,31L,26L,29L,22L,25L,23L,20L,13L,29L,25L,26L,19L,27L,24L,23L,16L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273494Inst : IEnumerable<long>
{
public static readonly long[] Value=A273494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273494.Bytes);
public long this[int i]=>Value[i];

public static A273494Inst Instance=new A273494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273493
{
public static readonly long[] Value={ 2L,3L,3L,5L,5L,4L,4L,8L,8L,7L,7L,7L,7L,5L,5L,13L,13L,11L,11L,12L,12L,9L,9L,11L,11L,10L,10L,9L,9L,6L,6L,21L,21L,18L,18L,19L,19L,14L,14L,19L,19L,17L,17L,16L,16L,11L,11L,18L,18L,15L,15L,17L,17L,13L,13L,14L,14L,13L,13L,11L,11L,7L,7L,34L,34L,29L,29L,31L,31L,23L,23L,30L,30L,27L,27L,25L,25L,17L,17L,31L,31L,26L,26L,29L,29L,22L,22L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273493Inst : IEnumerable<long>
{
public static readonly long[] Value=A273493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273493.Bytes);
public long this[int i]=>Value[i];

public static A273493Inst Instance=new A273493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273492
{
public static readonly long[] Value={ 10L,12L,14L,16L,18L,21L,23L,25L,27L,29L,30L,32L,34L,36L,38L,41L,43L,45L,47L,49L,50L,52L,54L,56L,58L,61L,63L,65L,67L,69L,70L,72L,74L,76L,78L,81L,83L,85L,87L,89L,90L,92L,94L,96L,98L,1000L,1001L,1002L,1004L,1005L,1006L,1008L,1009L,1010L,1011L,1013L,1014L,1015L,1017L,1018L,1019L,1020L,1022L,1023L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273492Inst : IEnumerable<long>
{
public static readonly long[] Value=A273492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273492.Bytes);
public long this[int i]=>Value[i];

public static A273492Inst Instance=new A273492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273491
{
public static readonly long[] Value={ 4L,4L,12L,12L,12L,16L,24L,44L,28L,32L,32L,60L,28L,48L,56L,76L,60L,64L,64L,92L,60L,80L,80L,108L,76L,96L,80L,124L,60L,112L,120L,140L,124L,128L,128L,156L,124L,144L,144L,172L,140L,160L,144L,188L,124L,176L,176L,204L,172L,192L,176L,220L,156L,208L,192L,236L,172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273491Inst : IEnumerable<long>
{
public static readonly long[] Value=A273491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273491.Bytes);
public long this[int i]=>Value[i];

public static A273491Inst Instance=new A273491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273490
{
public static readonly long[] Value={ 1L,6L,15L,36L,69L,114L,175L,260L,389L,546L,735L,956L,1237L,1546L,1903L,2316L,2805L,3354L,3967L,4644L,5413L,6242L,7151L,8140L,9237L,10410L,11679L,13028L,14501L,16034L,17679L,19444L,21349L,23378L,25535L,27820L,30261L,32826L,35535L,38388L,41413L,44578L,47903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273490Inst : IEnumerable<long>
{
public static readonly long[] Value=A273490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273490.Bytes);
public long this[int i]=>Value[i];

public static A273490Inst Instance=new A273490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273489
{
public static readonly long[] Value={ 1L,5L,21L,85L,413L,1765L,7325L,30085L,122813L,499045L,2020445L,8156485L,32854013L,132108325L,530526365L,2128417285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273489Inst : IEnumerable<long>
{
public static readonly long[] Value=A273489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273489.Bytes);
public long this[int i]=>Value[i];

public static A273489Inst Instance=new A273489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273488
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,5L,5L,3L,6L,6L,7L,2L,13L,8L,12L,10L,17L,2L,15L,9L,18L,24L,12L,8L,12L,23L,15L,11L,21L,25L,30L,14L,29L,27L,23L,25L,34L,29L,42L,19L,42L,35L,57L,16L,69L,45L,41L,23L,45L,43L,43L,34L,60L,77L,52L,23L,53L,64L,74L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273488Inst : IEnumerable<long>
{
public static readonly long[] Value=A273488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273488.Bytes);
public long this[int i]=>Value[i];

public static A273488Inst Instance=new A273488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273487
{
public static readonly long[] Value={ 6L,5L,0L,4L,4L,5L,6L,0L,8L,4L,2L,1L,9L,1L,2L,6L,9L,1L,3L,9L,0L,4L,4L,4L,3L,6L,1L,1L,0L,4L,6L,5L,9L,6L,4L,5L,5L,7L,7L,0L,1L,0L,2L,9L,6L,9L,2L,2L,0L,5L,4L,9L,7L,6L,0L,2L,0L,1L,9L,3L,5L,8L,8L,5L,5L,5L,2L,3L,4L,2L,8L,6L,9L,1L,6L,8L,2L,1L,3L,6L,7L,7L,4L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273487Inst : IEnumerable<long>
{
public static readonly long[] Value=A273487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273487.Bytes);
public long this[int i]=>Value[i];

public static A273487Inst Instance=new A273487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273486
{
public static readonly long[] Value={ 1L,5L,9L,21L,33L,45L,61L,85L,129L,157L,189L,221L,281L,309L,357L,413L,489L,549L,613L,677L,769L,829L,909L,989L,1097L,1173L,1269L,1349L,1473L,1533L,1645L,1765L,1905L,2029L,2157L,2285L,2441L,2565L,2709L,2853L,3025L,3165L,3325L,3469L,3657L,3781L,3957L,4133L,4337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273486Inst : IEnumerable<long>
{
public static readonly long[] Value=A273486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273486.Bytes);
public long this[int i]=>Value[i];

public static A273486Inst Instance=new A273486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273485
{
public static readonly long[] Value={ 4L,0L,12L,-8L,20L,-8L,44L,-40L,52L,-40L,76L,-56L,84L,-72L,156L,-136L,164L,-152L,204L,-184L,212L,-200L,284L,-248L,308L,-272L,364L,-312L,452L,-400L,588L,-536L,484L,-512L,668L,-624L,612L,-608L,700L,-696L,692L,-616L,668L,-664L,884L,-840L,1100L,-1008L,1012L,-960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273485Inst : IEnumerable<long>
{
public static readonly long[] Value=A273485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273485.Bytes);
public long this[int i]=>Value[i];

public static A273485Inst Instance=new A273485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273484
{
public static readonly long[] Value={ 1L,6L,11L,28L,37L,66L,87L,152L,177L,254L,291L,404L,461L,602L,671L,896L,985L,1238L,1339L,1644L,1765L,2098L,2231L,2648L,2817L,3294L,3499L,4068L,4325L,5034L,5343L,6240L,6601L,7446L,7779L,8780L,9157L,10146L,10527L,11608L,11993L,13070L,13531L,14660L,15125L,16474L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273484Inst : IEnumerable<long>
{
public static readonly long[] Value=A273484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273484.Bytes);
public long this[int i]=>Value[i];

public static A273484Inst Instance=new A273484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273483
{
public static readonly long[] Value={ 1L,5L,17L,65L,225L,897L,3537L,13745L,56465L,217537L,907449L,3752361L,15510281L,65256161L,273273209L,1135354345L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273483Inst : IEnumerable<long>
{
public static readonly long[] Value=A273483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273483.Bytes);
public long this[int i]=>Value[i];

public static A273483Inst Instance=new A273483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273482
{
public static readonly long[] Value={ 1L,5L,5L,17L,9L,29L,21L,65L,25L,77L,37L,113L,57L,141L,69L,225L,89L,253L,101L,305L,121L,333L,133L,417L,169L,477L,205L,569L,257L,709L,309L,897L,361L,845L,333L,1001L,377L,989L,381L,1081L,385L,1077L,461L,1129L,465L,1349L,509L,1609L,601L,1613L,653L,1817L,697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273482Inst : IEnumerable<long>
{
public static readonly long[] Value=A273482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273482.Bytes);
public long this[int i]=>Value[i];

public static A273482Inst Instance=new A273482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273481
{
public static readonly long[] Value={ 3L,21L,24L,32L,40L,48L,56L,64L,72L,80L,88L,96L,104L,112L,120L,128L,136L,144L,152L,160L,168L,176L,184L,192L,200L,208L,216L,224L,232L,240L,248L,256L,264L,272L,280L,288L,296L,304L,312L,320L,328L,336L,344L,352L,360L,368L,376L,384L,392L,400L,408L,416L,424L,432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273481Inst : IEnumerable<long>
{
public static readonly long[] Value=A273481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273481.Bytes);
public long this[int i]=>Value[i];

public static A273481Inst Instance=new A273481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273480
{
public static readonly long[] Value={ 1L,5L,30L,79L,160L,281L,450L,675L,964L,1325L,1766L,2295L,2920L,3649L,4490L,5451L,6540L,7765L,9134L,10655L,12336L,14185L,16210L,18419L,20820L,23421L,26230L,29255L,32504L,35985L,39706L,43675L,47900L,52389L,57150L,62191L,67520L,73145L,79074L,85315L,91876L,98765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273480Inst : IEnumerable<long>
{
public static readonly long[] Value=A273480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273480.Bytes);
public long this[int i]=>Value[i];

public static A273480Inst Instance=new A273480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273479
{
public static readonly long[] Value={ 1L,0L,100L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,14L,15L,16L,17L,18L,19L,21L,22L,23L,24L,25L,26L,27L,28L,29L,31L,32L,33L,34L,35L,36L,37L,38L,39L,41L,42L,43L,44L,45L,46L,47L,48L,49L,51L,52L,53L,54L,55L,56L,57L,58L,59L,110L,120L,61L,10L,62L,130L,63L,64L,20L,65L,66L,140L,67L,68L,69L,30L,71L,72L,73L,150L,74L,75L,76L,77L,40L,78L,79L,81L,82L,83L,50L,84L,85L,86L,87L,88L,160L,89L,91L,92L,93L,94L,95L,60L,96L,97L,98L,99L,111L,1110L,112L,113L,114L,115L,1120L,116L,117L,118L,119L,121L,70L,122L,123L,124L,125L,126L,170L,127L,128L,129L,131L,132L,1130L,133L,134L,135L,136L,137L,138L,80L,139L,141L,142L,143L,144L,145L,1140L,146L,147L,148L,149L,151L,152L,153L,90L,154L,155L,156L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273479Inst : IEnumerable<long>
{
public static readonly long[] Value=A273479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273479.Bytes);
public long this[int i]=>Value[i];

public static A273479Inst Instance=new A273479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273478
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,90L,91L,19L,10L,29L,11L,12L,92L,13L,14L,93L,15L,16L,39L,17L,18L,20L,49L,21L,22L,23L,24L,94L,25L,26L,27L,28L,95L,30L,31L,32L,33L,34L,35L,36L,37L,38L,40L,41L,42L,43L,44L,45L,46L,47L,48L,50L,51L,52L,53L,54L,55L,56L,57L,58L,60L,61L,62L,63L,64L,65L,66L,67L,68L,70L,71L,72L,73L,74L,75L,76L,77L,59L,78L,80L,81L,82L,83L,84L,85L,86L,87L,88L,100L,101L,102L,103L,104L,105L,106L,107L,108L,110L,111L,112L,113L,114L,115L,116L,117L,118L,120L,121L,122L,123L,124L,109L,125L,126L,127L,128L,130L,131L,69L,132L,133L,134L,79L,135L,136L,137L,138L,140L,141L,142L,143L,144L,119L,145L,146L,147L,129L,148L,150L,151L,152L,96L,153L,154L,155L,156L,157L,158L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273478Inst : IEnumerable<long>
{
public static readonly long[] Value=A273478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273478.Bytes);
public long this[int i]=>Value[i];

public static A273478Inst Instance=new A273478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273477
{
public static readonly BigInteger[] Value={ 1L,1L,23L,1086L,13097L,261110L,5732276L,105028302L,2057123951L,40750196324L,789214306848L,15416490294168L,301533431477968L,5881271193704355L,114836714153318686L,2242611029205195253L,BigInteger.Parse("43780084385383228801"),BigInteger.Parse("854790034707804119211"),BigInteger.Parse("16689735991827528511674") };
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
public class A273477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273477Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273477.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273477.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273477Inst Instance=new A273477Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273476
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,80L,81L,9L,82L,10L,83L,11L,18L,12L,13L,28L,14L,15L,16L,84L,17L,19L,20L,85L,21L,22L,23L,38L,24L,25L,26L,27L,29L,30L,31L,32L,33L,34L,35L,36L,37L,39L,40L,41L,42L,43L,44L,45L,46L,47L,49L,50L,51L,52L,53L,54L,55L,56L,57L,59L,60L,61L,62L,63L,64L,65L,66L,67L,86L,69L,70L,71L,72L,73L,74L,75L,76L,77L,79L,90L,91L,92L,93L,94L,95L,96L,97L,99L,100L,101L,102L,103L,104L,105L,106L,107L,109L,110L,111L,112L,113L,114L,87L,115L,116L,108L,117L,119L,120L,121L,122L,123L,124L,125L,126L,127L,129L,130L,131L,132L,133L,134L,135L,136L,137L,139L,140L,141L,142L,143L,144L,145L,146L,48L,147L,149L,150L,58L,151L,152L,153L,154L,155L,156L,157L,159L,160L,161L,162L,163L,164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273476Inst : IEnumerable<long>
{
public static readonly long[] Value=A273476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273476.Bytes);
public long this[int i]=>Value[i];

public static A273476Inst Instance=new A273476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273443
{
public static readonly long[] Value={ 1L,4L,21L,41L,80L,120L,168L,224L,288L,360L,440L,528L,624L,728L,840L,960L,1088L,1224L,1368L,1520L,1680L,1848L,2024L,2208L,2400L,2600L,2808L,3024L,3248L,3480L,3720L,3968L,4224L,4488L,4760L,5040L,5328L,5624L,5928L,6240L,6560L,6888L,7224L,7568L,7920L,8280L,8648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273443Inst : IEnumerable<long>
{
public static readonly long[] Value=A273443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273443.Bytes);
public long this[int i]=>Value[i];

public static A273443Inst Instance=new A273443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273442
{
public static readonly BigInteger[] Value={ 1L,3L,95L,5595L,484729L,55545735L,7923937307L,1353285904971L,269240651261153L,61157779792168059L,15617503320899550135UL,BigInteger.Parse("4429016799173481942427"),BigInteger.Parse("1381112305978592892946825"),BigInteger.Parse("469689278931628969590283855"),BigInteger.Parse("173002815169302537782725771395") };
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
public class A273442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273442Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273442.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273442.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273442Inst Instance=new A273442Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273441
{
public static readonly BigInteger[] Value={ 1L,165L,17105L,1452880L,111684573L,8161132980L,582816362700L,41367826311240L,2950036744905393L,212871288926657075L,15617503320899550135UL,BigInteger.Parse("1168755168529889495100"),BigInteger.Parse("89415279382066253241846"),BigInteger.Parse("7003566076056061232032785"),BigInteger.Parse("562166804049332506124053492") };
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
public class A273441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273441Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273441.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273441.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273441Inst Instance=new A273441Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273440
{
public static readonly BigInteger[] Value={ 1L,135L,11715L,848430L,56457258L,3616660047L,228859354295L,14526558274800L,933767559522083L,61157779792168059L,4097522595384976251L,BigInteger.Parse("281552808746124677190"),BigInteger.Parse("19873435970688901729621"),BigInteger.Parse("1442409484607029199323392"),BigInteger.Parse("107706418622406296313956423") };
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
public class A273440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273440Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273440.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273440.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273440Inst Instance=new A273440Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273439
{
public static readonly BigInteger[] Value={ 1L,108L,7710L,469590L,26750823L,1488656598L,82839614429L,4672159568505L,269240651261153L,15931093968844912L,970803214965494976L,BigInteger.Parse("61032579212845013280"),BigInteger.Parse("3962346372673358180536"),BigInteger.Parse("265758042459395190801852"),BigInteger.Parse("18415788640437877637900864"),BigInteger.Parse("1318210727391112435230475378") };
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
public class A273439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273439Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273439.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273439.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273439Inst Instance=new A273439Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273438
{
public static readonly BigInteger[] Value={ 1L,84L,4830L,243390L,11717013L,560544138L,27196758875L,1353285904971L,69495472079033L,3696068344472504L,203958595104203576L,11687491140975605592UL,BigInteger.Parse("695597351310503327386"),BigInteger.Parse("42988755956609918306640"),BigInteger.Parse("2757417607812192585058358"),BigInteger.Parse("183451189952939198906121968") };
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
public class A273438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273438Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273438.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273438.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273438Inst Instance=new A273438Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273437
{
public static readonly BigInteger[] Value={ 1L,63L,2842L,116172L,4654713L,189142107L,7923937307L,345104368752L,15688849238062L,745831503236820L,37094603885430728L,1929672890969261256L,BigInteger.Parse("104918114960824458448"),BigInteger.Parse("5956513043619244790970"),BigInteger.Parse("352719666690509340493680"),BigInteger.Parse("21759830035878816514854144") };
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
public class A273437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273437Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273437.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273437.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273437Inst Instance=new A273437Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273436
{
public static readonly BigInteger[] Value={ 1L,45L,1540L,49840L,1632099L,55545735L,1987186025L,75078221130L,2999597292406L,126693681294180L,5650573288138415L,265702055516788800L,13149171975158028874UL,BigInteger.Parse("683615652343279677360"),BigInteger.Parse("37269087381803600233878"),BigInteger.Parse("2126880663709734887508320"),BigInteger.Parse("126841125623724152774643951") };
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
public class A273436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273436Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273436.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273436.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273436Inst Instance=new A273436Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273435
{
public static readonly BigInteger[] Value={ 1L,30L,745L,18515L,484729L,13591116L,409987640L,13303809750L,463397746636L,17276343754098L,687247936771032L,29079485483123985L,1304889365985201424L,BigInteger.Parse("61922948839969015928"),BigInteger.Parse("3099416199490785094272"),BigInteger.Parse("163229892984351540698188"),BigInteger.Parse("9024648860521246301700096") };
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
public class A273435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273435Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273435.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273435.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273435Inst Instance=new A273435Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273434
{
public static readonly BigInteger[] Value={ 1L,18L,305L,5595L,113974L,2581964L,64727522L,1783995060L,53705023251L,1755078270264L,61920105083187L,2346728722199680L,95117694573257784L,4106779625155078528L,BigInteger.Parse("188206877039146217476"),BigInteger.Parse("9125798298446360109312"),BigInteger.Parse("466820173490890114763781"),BigInteger.Parse("25126459591455539907002880") };
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
public class A273434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273434Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273434.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273434.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273434Inst Instance=new A273434Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273433
{
public static readonly BigInteger[] Value={ 3L,8L,57L,1047L,27216L,861642L,21444846L,674273372L,147534349327L,45941644105613L,244158265828023L,569209871196597077L,15204969799577672558UL,BigInteger.Parse("2111244131216208612515"),BigInteger.Parse("129192323492968413250921"),BigInteger.Parse("25814874251189658671192458"),BigInteger.Parse("13543096262710710570994132579") };
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
public class A273433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273433Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273433.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273433.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273433Inst Instance=new A273433Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273432
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,1L,4L,1L,1L,3L,1L,3L,2L,1L,3L,3L,2L,3L,5L,2L,3L,4L,6L,1L,3L,5L,1L,6L,1L,3L,7L,2L,2L,5L,6L,5L,6L,3L,6L,4L,1L,3L,4L,5L,4L,5L,7L,2L,3L,8L,6L,7L,3L,4L,8L,3L,2L,6L,3L,5L,7L,3L,8L,7L,2L,4L,10L,4L,4L,7L,9L,7L,2L,4L,2L,7L,3L,5L,11L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273432Inst : IEnumerable<long>
{
public static readonly long[] Value=A273432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273432.Bytes);
public long this[int i]=>Value[i];

public static A273432Inst Instance=new A273432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273431
{
public static readonly long[] Value={ 1L,4L,28L,157L,733L,3081L,12877L,51821L,206833L,830405L,3325905L,13313637L,53308989L,213158361L,852730457L,3411030957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273431Inst : IEnumerable<long>
{
public static readonly long[] Value=A273431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273431.Bytes);
public long this[int i]=>Value[i];

public static A273431Inst Instance=new A273431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273430
{
public static readonly long[] Value={ 1L,4L,17L,28L,61L,93L,141L,157L,221L,296L,393L,405L,480L,577L,693L,733L,857L,1025L,1145L,1297L,1397L,1597L,1637L,1765L,1965L,2145L,2229L,2433L,2689L,2681L,2981L,3081L,3389L,3537L,3985L,4381L,4413L,4781L,4969L,5105L,5421L,5693L,6073L,6165L,6525L,6725L,7101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273430Inst : IEnumerable<long>
{
public static readonly long[] Value=A273430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273430.Bytes);
public long this[int i]=>Value[i];

public static A273430Inst Instance=new A273430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273429
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,2L,1L,1L,3L,3L,2L,2L,2L,2L,1L,1L,3L,4L,3L,2L,2L,2L,1L,1L,3L,4L,4L,2L,2L,3L,1L,1L,3L,4L,3L,3L,3L,3L,2L,1L,4L,4L,2L,2L,3L,3L,1L,1L,3L,5L,5L,3L,3L,5L,3L,1L,3L,3L,3L,2L,2L,4L,2L,2L,5L,7L,5L,4L,5L,4L,1L,3L,6L,6L,6L,4L,4L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273429Inst : IEnumerable<long>
{
public static readonly long[] Value=A273429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273429.Bytes);
public long this[int i]=>Value[i];

public static A273429Inst Instance=new A273429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273428
{
public static readonly long[] Value={ 4L,4L,8L,4L,8L,8L,32L,12L,8L,16L,24L,20L,40L,32L,64L,16L,-16L,4L,40L,52L,32L,56L,8L,24L,40L,52L,104L,48L,104L,56L,156L,152L,-40L,-40L,16L,76L,120L,40L,84L,52L,44L,168L,120L,160L,120L,120L,336L,116L,-52L,88L,120L,176L,224L,192L,196L,176L,212L,236L,188L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273428Inst : IEnumerable<long>
{
public static readonly long[] Value=A273428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273428.Bytes);
public long this[int i]=>Value[i];

public static A273428Inst Instance=new A273428Inst();

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