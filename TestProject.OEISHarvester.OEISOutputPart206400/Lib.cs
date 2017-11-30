using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A244782
{
public static readonly long[] Value={ 1L,3L,7L,17L,41L,123L,345L,953L,2613L,7149L,19541L,53397L,145893L,437679L,1273955L,3675989L,10551223L,30194773L,86246645L,246068131L,701551365L,1999277391L,5695980955L,17087942865L,50401117439L,147878352761L,432425644451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244782Inst : IEnumerable<long>
{
public static readonly long[] Value=A244782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244782.Bytes);
public long this[int i]=>Value[i];

public static A244782Inst Instance=new A244782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244783
{
public static readonly long[] Value={ 2L,6L,20L,72L,268L,876L,3236L,12284L,42396L,159876L,614936L,2198628L,8407796L,32629532L,119560228L,461654712L,1803031416L,6724605836L,26147874800L,102596362036L,387701367548L,1515422726468L,5694815620420L,22229878552752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244783Inst : IEnumerable<long>
{
public static readonly long[] Value=A244783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244783.Bytes);
public long this[int i]=>Value[i];

public static A244783Inst Instance=new A244783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244784
{
public static readonly long[] Value={ 3L,13L,51L,201L,941L,4153L,18143L,87353L,405423L,1865359L,8547093L,39098077L,190729523L,907786567L,4292846081L,20230294033L,95161072323L,467762504103L,2259396954323L,10859408587343L,52047262337997L,249044033481767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244784Inst : IEnumerable<long>
{
public static readonly long[] Value=A244784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244784.Bytes);
public long this[int i]=>Value[i];

public static A244784Inst Instance=new A244784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244785
{
public static readonly long[] Value={ 4L,18L,88L,454L,2424L,13270L,73988L,384360L,2126012L,11983288L,68380920L,371177576L,2103489988L,12072527960L,69865022356L,389690375308L,2242267086352L,13018490319724L,73199231868324L,423255665348852L,2467041278509640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244785Inst : IEnumerable<long>
{
public static readonly long[] Value=A244785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244785.Bytes);
public long this[int i]=>Value[i];

public static A244785Inst Instance=new A244785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244786
{
public static readonly long[] Value={ 5L,23L,135L,851L,5101L,30359L,197949L,1246529L,8310879L,53948531L,347868515L,2236201867L,15074788081L,99623032135L,655028793333L,4457297710973L,29858344752095L,199117280958573L,1324641756965469L,8800128837526961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244786Inst : IEnumerable<long>
{
public static readonly long[] Value=A244786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244786.Bytes);
public long this[int i]=>Value[i];

public static A244786Inst Instance=new A244786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244787
{
public static readonly long[] Value={ 4L,26L,166L,1116L,7730L,54842L,396488L,2909656L,21610932L,162100016L,1225834896L,8922787256L,67040518864L,509020798128L,3892934735724L,29936839485280L,223995395536680L,1713567578188868L,13203130087417636L,102232099278447604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244787Inst : IEnumerable<long>
{
public static readonly long[] Value=A244787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244787.Bytes);
public long this[int i]=>Value[i];

public static A244787Inst Instance=new A244787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244788
{
public static readonly long[] Value={ 2L,1L,2L,2L,3L,4L,3L,6L,7L,8L,4L,13L,20L,17L,12L,5L,18L,51L,72L,41L,24L,4L,23L,88L,201L,268L,123L,36L,5L,26L,135L,454L,941L,876L,345L,72L,6L,33L,166L,851L,2424L,4153L,3236L,953L,144L,7L,48L,243L,1116L,5101L,13270L,18143L,12284L,2613L,252L,6L,57L,382L,1919L,7730L,30359L,73988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244788Inst : IEnumerable<long>
{
public static readonly long[] Value=A244788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244788.Bytes);
public long this[int i]=>Value[i];

public static A244788Inst Instance=new A244788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244789
{
public static readonly long[] Value={ 2L,1L,2L,3L,4L,5L,4L,5L,6L,7L,6L,7L,8L,9L,10L,9L,10L,11L,12L,13L,12L,13L,14L,15L,16L,15L,16L,17L,18L,17L,18L,19L,20L,21L,20L,21L,22L,23L,24L,23L,24L,25L,26L,25L,26L,27L,28L,29L,28L,29L,30L,31L,32L,31L,32L,33L,34L,35L,34L,35L,36L,37L,36L,37L,38L,39L,40L,39L,40L,41L,42L,43L,42L,43L,44L,45L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244789Inst : IEnumerable<long>
{
public static readonly long[] Value=A244789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244789.Bytes);
public long this[int i]=>Value[i];

public static A244789Inst Instance=new A244789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244790
{
public static readonly long[] Value={ 2L,3L,6L,13L,18L,23L,26L,33L,48L,57L,52L,71L,82L,105L,118L,111L,138L,153L,184L,201L,192L,227L,246L,285L,306L,315L,338L,361L,408L,395L,444L,471L,498L,553L,538L,595L,626L,657L,720L,703L,768L,803L,838L,853L,890L,963L,1002L,1079L,1058L,1099L,1180L,1223L,1308L,1285L,1330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244790Inst : IEnumerable<long>
{
public static readonly long[] Value=A244790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244790.Bytes);
public long this[int i]=>Value[i];

public static A244790Inst Instance=new A244790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244791
{
public static readonly long[] Value={ 4L,7L,20L,51L,88L,135L,166L,243L,382L,509L,512L,741L,936L,1261L,1532L,1543L,2000L,2367L,2956L,3425L,3448L,4211L,4804L,5735L,6456L,6815L,7642L,8515L,9866L,9913L,11408L,12561L,13768L,15617L,15686L,17703L,19236L,20831L,23256L,23351L,25968L,27935L,29972L,30963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244791Inst : IEnumerable<long>
{
public static readonly long[] Value=A244791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244791.Bytes);
public long this[int i]=>Value[i];

public static A244791Inst Instance=new A244791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244792
{
public static readonly long[] Value={ 8L,17L,72L,201L,454L,851L,1116L,1919L,3162L,4821L,5036L,8185L,11436L,15901L,21134L,21873L,30746L,37251L,50078L,62067L,63826L,82963L,96446L,121995L,144936L,155695L,183642L,207867L,252596L,257575L,310050L,356231L,395774L,467467L,475588L,557823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244792Inst : IEnumerable<long>
{
public static readonly long[] Value=A244792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244792.Bytes);
public long this[int i]=>Value[i];

public static A244792Inst Instance=new A244792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244793
{
public static readonly long[] Value={ 12L,41L,268L,941L,2424L,5101L,7730L,14519L,26882L,47381L,54282L,93567L,138214L,207081L,288862L,319535L,489922L,628893L,878082L,1128849L,1220884L,1640461L,1997876L,2688937L,3290036L,3680517L,4461044L,5245231L,6537106L,7081377L,8727400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244793Inst : IEnumerable<long>
{
public static readonly long[] Value=A244793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244793.Bytes);
public long this[int i]=>Value[i];

public static A244793Inst Instance=new A244793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244794
{
public static readonly long[] Value={ 24L,123L,876L,4153L,13270L,30359L,54842L,118709L,249138L,451435L,578416L,1097315L,1689194L,2764601L,4168526L,4963149L,7736592L,10637277L,15795400L,20870151L,23943826L,33943725L,42406142L,59306385L,76126258L,89257109L,110426270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244794Inst : IEnumerable<long>
{
public static readonly long[] Value=A244794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244794.Bytes);
public long this[int i]=>Value[i];

public static A244794Inst Instance=new A244794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244795
{
public static readonly long[] Value={ 36L,345L,3236L,18143L,73988L,197949L,396488L,940083L,2280068L,4535323L,6219898L,12556597L,21778114L,37625779L,59656736L,74529439L,127085928L,182325201L,281772734L,402272779L,478748680L,702649285L,917558424L,1352825865L,1790333160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244795Inst : IEnumerable<long>
{
public static readonly long[] Value=A244795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244795.Bytes);
public long this[int i]=>Value[i];

public static A244795Inst Instance=new A244795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244796
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,5L,4L,5L,3L,5L,7L,8L,7L,7L,3L,5L,3L,11L,7L,7L,11L,7L,3L,7L,11L,8L,7L,3L,11L,9L,11L,7L,7L,7L,5L,11L,11L,9L,3L,5L,3L,17L,7L,13L,8L,11L,15L,7L,3L,11L,7L,7L,19L,7L,8L,3L,5L,15L,11L,15L,7L,5L,11L,7L,15L,5L,15L,19L,3L,11L,11L,3L,7L,11L,15L,3L,5L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244796Inst : IEnumerable<long>
{
public static readonly long[] Value=A244796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244796.Bytes);
public long this[int i]=>Value[i];

public static A244796Inst Instance=new A244796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244797
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,3L,1L,3L,3L,1L,3L,3L,1L,5L,3L,3L,1L,3L,3L,1L,3L,4L,3L,3L,5L,1L,7L,1L,3L,3L,3L,7L,1L,5L,1L,3L,3L,7L,5L,3L,1L,7L,1L,7L,1L,3L,3L,8L,1L,7L,3L,1L,3L,7L,5L,3L,1L,5L,5L,1L,3L,3L,3L,1L,11L,3L,3L,7L,1L,7L,7L,3L,3L,3L,3L,5L,3L,7L,3L,3L,1L,7L,1L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244797Inst : IEnumerable<long>
{
public static readonly long[] Value=A244797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244797.Bytes);
public long this[int i]=>Value[i];

public static A244797Inst Instance=new A244797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244798
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,2L,2L,3L,4L,2L,4L,2L,2L,6L,4L,4L,6L,2L,5L,4L,6L,4L,8L,2L,2L,4L,7L,6L,2L,6L,4L,6L,2L,6L,2L,4L,6L,10L,4L,6L,8L,2L,4L,6L,2L,7L,8L,10L,10L,2L,6L,4L,6L,6L,2L,10L,6L,4L,2L,2L,14L,6L,8L,10L,6L,2L,6L,2L,6L,2L,10L,4L,10L,6L,6L,10L,2L,2L,2L,6L,10L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244798Inst : IEnumerable<long>
{
public static readonly long[] Value=A244798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244798.Bytes);
public long this[int i]=>Value[i];

public static A244798Inst Instance=new A244798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244799
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,8L,9L,12L,14L,17L,21L,23L,25L,29L,29L,33L,37L,41L,42L,46L,49L,51L,52L,56L,62L,64L,68L,66L,70L,74L,83L,86L,86L,90L,93L,99L,103L,108L,106L,111L,113L,119L,123L,125L,124L,130L,139L,147L,144L,148L,148L,156L,160L,163L,164L,168L,174L,182L,180L,182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244799Inst : IEnumerable<long>
{
public static readonly long[] Value=A244799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244799.Bytes);
public long this[int i]=>Value[i];

public static A244799Inst Instance=new A244799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244800
{
public static readonly long[] Value={ 2L,2L,3L,3L,5L,5L,8L,7L,9L,12L,10L,14L,16L,14L,18L,20L,22L,20L,25L,25L,24L,28L,31L,33L,35L,37L,35L,41L,39L,39L,44L,45L,51L,49L,56L,52L,54L,55L,61L,62L,66L,62L,68L,68L,73L,69L,72L,76L,83L,81L,85L,83L,81L,88L,93L,95L,95L,89L,97L,99L,97L,103L,107L,105L,103L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244800Inst : IEnumerable<long>
{
public static readonly long[] Value=A244800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244800.Bytes);
public long this[int i]=>Value[i];

public static A244800Inst Instance=new A244800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244801
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,3L,16L,3L,15L,26L,25L,13L,39L,39L,16L,28L,10L,48L,7L,55L,58L,49L,21L,5L,37L,97L,22L,24L,26L,60L,13L,64L,58L,117L,120L,60L,44L,160L,44L,130L,174L,131L,94L,31L,141L,5L,112L,3L,154L,18L,29L,5L,182L,250L,2L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244801Inst : IEnumerable<long>
{
public static readonly long[] Value=A244801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244801.Bytes);
public long this[int i]=>Value[i];

public static A244801Inst Instance=new A244801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244802
{
public static readonly long[] Value={ 1L,10L,43L,100L,181L,286L,415L,568L,745L,946L,1171L,1420L,1693L,1990L,2311L,2656L,3025L,3418L,3835L,4276L,4741L,5230L,5743L,6280L,6841L,7426L,8035L,8668L,9325L,10006L,10711L,11440L,12193L,12970L,13771L,14596L,15445L,16318L,17215L,18136L,19081L,20050L,21043L,22060L,23101L,24166L,25255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244802Inst : IEnumerable<long>
{
public static readonly long[] Value=A244802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244802.Bytes);
public long this[int i]=>Value[i];

public static A244802Inst Instance=new A244802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244803
{
public static readonly long[] Value={ 1L,12L,47L,106L,189L,296L,427L,582L,761L,964L,1191L,1442L,1717L,2016L,2339L,2686L,3057L,3452L,3871L,4314L,4781L,5272L,5787L,6326L,6889L,7476L,8087L,8722L,9381L,10064L,10771L,11502L,12257L,13036L,13839L,14666L,15517L,16392L,17291L,18214L,19161L,20132L,21127L,22146L,23189L,24256L,25347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244803Inst : IEnumerable<long>
{
public static readonly long[] Value=A244803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244803.Bytes);
public long this[int i]=>Value[i];

public static A244803Inst Instance=new A244803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244804
{
public static readonly long[] Value={ 1L,14L,51L,112L,197L,306L,439L,596L,777L,982L,1211L,1464L,1741L,2042L,2367L,2716L,3089L,3486L,3907L,4352L,4821L,5314L,5831L,6372L,6937L,7526L,8139L,8776L,9437L,10122L,10831L,11564L,12321L,13102L,13907L,14736L,15589L,16466L,17367L,18292L,19241L,20214L,21211L,22232L,23277L,24346L,25439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244804Inst : IEnumerable<long>
{
public static readonly long[] Value=A244804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244804.Bytes);
public long this[int i]=>Value[i];

public static A244804Inst Instance=new A244804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244805
{
public static readonly long[] Value={ 1L,16L,55L,118L,205L,316L,451L,610L,793L,1000L,1231L,1486L,1765L,2068L,2395L,2746L,3121L,3520L,3943L,4390L,4861L,5356L,5875L,6418L,6985L,7576L,8191L,8830L,9493L,10180L,10891L,11626L,12385L,13168L,13975L,14806L,15661L,16540L,17443L,18370L,19321L,20296L,21295L,22318L,23365L,24436L,25531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244805Inst : IEnumerable<long>
{
public static readonly long[] Value=A244805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244805.Bytes);
public long this[int i]=>Value[i];

public static A244805Inst Instance=new A244805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244806
{
public static readonly long[] Value={ 1L,18L,59L,124L,213L,326L,463L,624L,809L,1018L,1251L,1508L,1789L,2094L,2423L,2776L,3153L,3554L,3979L,4428L,4901L,5398L,5919L,6464L,7033L,7626L,8243L,8884L,9549L,10238L,10951L,11688L,12449L,13234L,14043L,14876L,15733L,16614L,17519L,18448L,19401L,20378L,21379L,22404L,23453L,24526L,25623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244806Inst : IEnumerable<long>
{
public static readonly long[] Value=A244806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244806.Bytes);
public long this[int i]=>Value[i];

public static A244806Inst Instance=new A244806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244807
{
public static readonly long[] Value={ 1L,2L,9L,1L,5L,3L,3L,7L,3L,1L,3L,0L,1L,9L,3L,2L,8L,4L,3L,8L,3L,4L,0L,0L,5L,4L,5L,7L,0L,8L,9L,7L,9L,1L,7L,1L,1L,1L,1L,1L,7L,1L,9L,1L,7L,1L,1L,1L,1L,2L,7L,2L,9L,2L,7L,2L,1L,2L,1L,2L,7L,3L,9L,3L,7L,3L,1L,3L,1L,3L,7L,4L,9L,4L,7L,4L,1L,4L,1L,4L,7L,5L,9L,5L,7L,5L,1L,5L,1L,6L,7L,6L,9L,6L,7L,6L,1L,7L,1L,7L,7L,7L,9L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244807Inst : IEnumerable<long>
{
public static readonly long[] Value=A244807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244807.Bytes);
public long this[int i]=>Value[i];

public static A244807Inst Instance=new A244807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244808
{
public static readonly long[] Value={ 1L,1L,6L,5L,5L,1L,1L,2L,2L,3L,4L,5L,6L,7L,8L,9L,3L,1L,2L,4L,2L,1L,7L,4L,7L,2L,2L,4L,8L,2L,9L,3L,5L,3L,7L,2L,8L,4L,5L,1L,7L,5L,5L,9L,2L,6L,5L,6L,3L,7L,7L,4L,0L,8L,9L,1L,3L,9L,1L,0L,0L,1L,1L,1L,2L,2L,1L,5L,1L,3L,3L,1L,2L,1L,5L,5L,1L,0L,1L,7L,7L,1L,1L,1L,9L,9L,1L,3L,2L,1L,1L,2L,8L,2L,3L,3L,2L,4L,2L,5L,6L,2L,3L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244808Inst : IEnumerable<long>
{
public static readonly long[] Value=A244808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244808.Bytes);
public long this[int i]=>Value[i];

public static A244808Inst Instance=new A244808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244809
{
public static readonly long[] Value={ 1L,3L,0L,7L,7L,0L,6L,5L,7L,1L,3L,5L,1L,1L,2L,2L,7L,2L,3L,1L,3L,4L,3L,5L,6L,3L,0L,7L,1L,6L,9L,7L,7L,0L,1L,7L,0L,2L,3L,8L,7L,5L,5L,3L,8L,7L,8L,2L,3L,0L,1L,5L,2L,3L,4L,2L,5L,7L,7L,3L,2L,0L,1L,8L,3L,4L,5L,7L,8L,8L,9L,0L,7L,2L,3L,7L,0L,7L,8L,8L,7L,1L,3L,3L,8L,6L,8L,2L,3L,1L,3L,5L,2L,7L,8L,2L,5L,3L,4L,3L,2L,9L,0L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244809Inst : IEnumerable<long>
{
public static readonly long[] Value=A244809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244809.Bytes);
public long this[int i]=>Value[i];

public static A244809Inst Instance=new A244809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244810
{
public static readonly long[] Value={ 1L,1L,8L,5L,9L,3L,1L,0L,9L,3L,3L,1L,6L,8L,1L,9L,1L,4L,2L,1L,2L,9L,7L,1L,9L,4L,2L,2L,2L,9L,9L,3L,1L,3L,7L,3L,6L,7L,6L,4L,7L,1L,5L,5L,4L,4L,6L,6L,7L,6L,7L,8L,6L,9L,0L,9L,1L,0L,0L,4L,0L,1L,4L,1L,9L,2L,6L,9L,3L,4L,3L,3L,6L,4L,9L,5L,0L,4L,6L,4L,7L,9L,3L,8L,9L,9L,9L,3L,0L,4L,1L,0L,5L,2L,9L,3L,3L,7L,5L,4L,6L,6L,1L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244810Inst : IEnumerable<long>
{
public static readonly long[] Value=A244810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244810.Bytes);
public long this[int i]=>Value[i];

public static A244810Inst Instance=new A244810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244811
{
public static readonly long[] Value={ 1L,4L,1L,1L,9L,4L,9L,7L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,8L,9L,9L,5L,9L,4L,9L,9L,0L,0L,1L,7L,3L,0L,6L,9L,9L,4L,3L,5L,7L,2L,2L,5L,8L,4L,4L,9L,1L,0L,8L,7L,6L,0L,5L,9L,4L,4L,4L,5L,4L,2L,5L,5L,7L,4L,9L,9L,2L,0L,5L,7L,9L,0L,4L,9L,9L,4L,5L,5L,1L,2L,8L,5L,6L,4L,4L,9L,3L,0L,2L,7L,2L,0L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244811Inst : IEnumerable<long>
{
public static readonly long[] Value=A244811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244811.Bytes);
public long this[int i]=>Value[i];

public static A244811Inst Instance=new A244811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244812
{
public static readonly long[] Value={ 1L,1L,0L,6L,0L,8L,1L,3L,5L,3L,4L,4L,6L,1L,5L,9L,9L,1L,2L,6L,2L,1L,7L,7L,1L,2L,3L,7L,6L,2L,9L,6L,7L,3L,7L,6L,4L,4L,6L,5L,7L,5L,5L,3L,6L,6L,6L,1L,1L,7L,7L,9L,2L,8L,0L,6L,9L,0L,3L,5L,0L,4L,1L,7L,0L,2L,9L,3L,3L,6L,3L,4L,4L,0L,3L,5L,9L,6L,8L,2L,7L,4L,8L,7L,1L,9L,9L,0L,8L,2L,1L,4L,2L,9L,4L,3L,9L,4L,2L,7L,6L,4L,7L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244812Inst : IEnumerable<long>
{
public static readonly long[] Value=A244812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244812.Bytes);
public long this[int i]=>Value[i];

public static A244812Inst Instance=new A244812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244813
{
public static readonly long[] Value={ 1L,5L,2L,0L,1L,5L,2L,2L,3L,1L,4L,1L,1L,1L,7L,2L,9L,1L,3L,0L,3L,4L,2L,3L,6L,7L,1L,7L,3L,7L,9L,0L,3L,2L,1L,2L,8L,3L,3L,4L,7L,8L,6L,6L,0L,7L,8L,9L,7L,0L,1L,2L,8L,7L,4L,5L,3L,8L,8L,9L,2L,3L,1L,2L,5L,2L,5L,6L,2L,5L,9L,0L,3L,2L,4L,5L,8L,3L,8L,9L,7L,8L,3L,4L,0L,7L,8L,9L,7L,0L,3L,5L,8L,7L,9L,0L,3L,8L,5L,6L,2L,3L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244813Inst : IEnumerable<long>
{
public static readonly long[] Value=A244813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244813.Bytes);
public long this[int i]=>Value[i];

public static A244813Inst Instance=new A244813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244814
{
public static readonly long[] Value={ 1L,1L,2L,6L,1L,1L,1L,2L,3L,3L,4L,5L,6L,7L,8L,9L,7L,5L,2L,1L,2L,1L,7L,1L,3L,7L,3L,2L,0L,2L,0L,3L,3L,6L,7L,3L,2L,1L,6L,4L,7L,5L,6L,5L,8L,8L,6L,6L,5L,1L,8L,8L,8L,4L,0L,9L,7L,1L,3L,1L,0L,1L,1L,8L,1L,2L,2L,1L,6L,1L,4L,4L,1L,5L,1L,5L,6L,1L,7L,1L,7L,8L,1L,0L,1L,9L,0L,2L,6L,2L,1L,2L,2L,3L,2L,3L,4L,2L,3L,2L,6L,6L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244814Inst : IEnumerable<long>
{
public static readonly long[] Value=A244814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244814.Bytes);
public long this[int i]=>Value[i];

public static A244814Inst Instance=new A244814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244815
{
public static readonly long[] Value={ 1L,6L,3L,2L,3L,4L,5L,8L,0L,1L,3L,6L,1L,4L,4L,2L,3L,3L,3L,0L,5L,4L,5L,8L,6L,8L,3L,7L,9L,9L,9L,1L,1L,1L,1L,1L,7L,1L,9L,1L,7L,1L,1L,1L,1L,1L,7L,1L,9L,2L,7L,2L,1L,2L,1L,2L,7L,2L,9L,2L,7L,3L,1L,3L,1L,3L,7L,3L,9L,3L,7L,4L,1L,4L,1L,4L,7L,4L,9L,4L,7L,5L,1L,5L,1L,5L,7L,5L,9L,6L,7L,6L,1L,6L,1L,7L,7L,7L,9L,7L,7L,7L,1L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244815Inst : IEnumerable<long>
{
public static readonly long[] Value=A244815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244815.Bytes);
public long this[int i]=>Value[i];

public static A244815Inst Instance=new A244815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244816
{
public static readonly long[] Value={ 1L,1L,4L,6L,7L,4L,1L,4L,0L,3L,3L,3L,6L,4L,4L,9L,5L,1L,2L,8L,2L,1L,7L,9L,5L,2L,3L,9L,4L,2L,0L,9L,9L,3L,7L,9L,0L,4L,6L,8L,7L,5L,6L,7L,0L,6L,6L,6L,9L,7L,8L,4L,4L,8L,0L,2L,5L,6L,3L,3L,0L,1L,9L,0L,1L,2L,4L,2L,7L,1L,4L,9L,5L,4L,3L,5L,6L,8L,1L,7L,7L,4L,1L,8L,4L,9L,5L,4L,5L,2L,1L,8L,7L,2L,2L,3L,3L,0L,9L,4L,6L,0L,3L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244816Inst : IEnumerable<long>
{
public static readonly long[] Value=A244816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244816.Bytes);
public long this[int i]=>Value[i];

public static A244816Inst Instance=new A244816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244817
{
public static readonly long[] Value={ 1L,7L,4L,3L,5L,0L,8L,9L,1L,1L,1L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,6L,6L,7L,7L,8L,9L,9L,1L,9L,1L,1L,2L,6L,3L,3L,7L,7L,5L,6L,6L,2L,8L,8L,9L,1L,1L,1L,6L,4L,4L,5L,7L,1L,7L,8L,2L,2L,1L,2L,1L,7L,4L,5L,4L,6L,9L,0L,1L,9L,3L,4L,2L,6L,7L,8L,7L,7L,2L,3L,6L,2L,7L,8L,9L,1L,2L,4L,6L,4L,8L,9L,7L,1L,4L,5L,2L,2L,0L,1L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244817Inst : IEnumerable<long>
{
public static readonly long[] Value=A244817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244817.Bytes);
public long this[int i]=>Value[i];

public static A244817Inst Instance=new A244817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244818
{
public static readonly long[] Value={ 1L,1L,6L,7L,1L,8L,1L,4L,1L,3L,6L,6L,6L,4L,3L,9L,3L,7L,2L,1L,2L,3L,7L,1L,7L,9L,3L,2L,8L,5L,0L,3L,5L,0L,8L,4L,8L,4L,6L,4L,7L,9L,6L,5L,2L,3L,7L,6L,3L,6L,8L,8L,0L,9L,1L,9L,3L,9L,1L,0L,0L,1L,3L,1L,2L,2L,1L,8L,1L,3L,4L,1L,6L,1L,5L,5L,1L,5L,1L,7L,7L,1L,7L,1L,9L,9L,2L,0L,2L,1L,1L,2L,6L,2L,3L,4L,2L,3L,2L,5L,6L,2L,3L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244818Inst : IEnumerable<long>
{
public static readonly long[] Value=A244818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244818.Bytes);
public long this[int i]=>Value[i];

public static A244818Inst Instance=new A244818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244819
{
public static readonly long[] Value={ 1L,3L,4L,7L,12L,13L,19L,21L,28L,31L,37L,39L,43L,49L,52L,57L,61L,67L,73L,76L,79L,84L,91L,93L,97L,103L,109L,111L,124L,127L,129L,133L,139L,147L,148L,151L,156L,157L,163L,169L,172L,181L,183L,193L,196L,199L,201L,211L,217L,219L,223L,228L,229L,237L,241L,244L,247L,259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244819Inst : IEnumerable<long>
{
public static readonly long[] Value=A244819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244819.Bytes);
public long this[int i]=>Value[i];

public static A244819Inst Instance=new A244819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244820
{
public static readonly BigInteger[] Value={ 1L,1L,5L,37L,513L,11281L,400513L,22016065L,1861165057L,238780240129L,46058931537921L,13292137309135873L,5694523821282066433L,BigInteger.Parse("3612945464580972908545"),BigInteger.Parse("3375333122746593847050241"),BigInteger.Parse("4635513066684099431721615361"),BigInteger.Parse("9320885421210678888076169707521"),BigInteger.Parse("27400026186934818737377587727761409") };
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
public class A244820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244820Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244820.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A244820.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244820Inst Instance=new A244820Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244821
{
public static readonly BigInteger[] Value={ 1L,1L,7L,82L,2377L,125956L,13786849L,2767780450L,1068587690545L,755247058160104L,990216775791709921L,BigInteger.Parse("2368086973433913986398"),BigInteger.Parse("10296184143094869761471305"),BigInteger.Parse("81305381330548263178299374860"),BigInteger.Parse("1153396004725120797831718629888193"),BigInteger.Parse("29585981132637810261211357828811890786") };
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
public class A244821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244821Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244821.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A244821.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244821Inst Instance=new A244821Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244822
{
public static readonly BigInteger[] Value={ 1L,1L,9L,145L,7169L,702721L,173051905L,86399717377L,99140462706689L,233906591488868353L,BigInteger.Parse("1206701231035902853121"),BigInteger.Parse("12911553576265127971258369"),BigInteger.Parse("292981931017250265780757463041"),BigInteger.Parse("13856406784814016950200694583853057"),BigInteger.Parse("1362697700959059311763086710096185524225") };
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
public class A244822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244822Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244822.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A244822.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244822Inst Instance=new A244822Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244823
{
public static readonly long[] Value={ 3L,2L,6L,1L,2L,2L,5L,5L,7L,1L,7L,4L,9L,4L,0L,5L,5L,5L,6L,7L,9L,4L,1L,0L,1L,8L,4L,8L,3L,7L,6L,3L,3L,2L,8L,2L,0L,3L,0L,1L,7L,9L,6L,9L,9L,0L,1L,7L,7L,9L,2L,8L,1L,2L,1L,2L,3L,0L,5L,1L,0L,2L,4L,8L,1L,0L,0L,5L,8L,2L,8L,4L,3L,2L,0L,9L,0L,0L,1L,9L,4L,1L,7L,8L,0L,1L,6L,1L,1L,7L,7L,9L,3L,4L,3L,5L,7L,7L,4L,7L,0L,4L,1L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244823Inst : IEnumerable<long>
{
public static readonly long[] Value=A244823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244823.Bytes);
public long this[int i]=>Value[i];

public static A244823Inst Instance=new A244823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244824
{
public static readonly long[] Value={ 1L,4L,15L,56L,220L,857L,3403L,13535L,54077L,215900L,862954L,3450545L,13802279L,55201838L,220792018L,883134861L,3532518195L,14129951284L,56519699688L,226078355122L,904312961284L,3617249936000L,14468996179294L,57875977567596L,231503907383054L,926015589350438L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244824Inst : IEnumerable<long>
{
public static readonly long[] Value=A244824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244824.Bytes);
public long this[int i]=>Value[i];

public static A244824Inst Instance=new A244824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244825
{
public static readonly long[] Value={ 2L,4L,8L,16L,30L,60L,120L,230L,460L,920L,1790L,3580L,7160L,14060L,28120L,56240L,111080L,222160L,436570L,873140L,1746280L,3456450L,6912900L,13632470L,27264940L,54529880L,108170410L,216340820L,427929590L,855859180L,1711718360L,3401531820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244825Inst : IEnumerable<long>
{
public static readonly long[] Value=A244825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244825.Bytes);
public long this[int i]=>Value[i];

public static A244825Inst Instance=new A244825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244826
{
public static readonly long[] Value={ 3L,9L,25L,75L,219L,657L,1947L,5737L,16835L,50505L,150269L,445611L,1318207L,3954621L,11801871L,35144759L,104488339L,310274387L,930823161L,2782086765L,8302860633L,24751434187L,73723434683L,221170304049L,661776939649L,1978053826173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244826Inst : IEnumerable<long>
{
public static readonly long[] Value=A244826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244826.Bytes);
public long this[int i]=>Value[i];

public static A244826Inst Instance=new A244826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244827
{
public static readonly long[] Value={ 4L,16L,62L,242L,950L,3744L,14802L,58662L,232916L,926120L,3628422L,14381528L,57148222L,227453736L,906239638L,3576510068L,14222021944L,56647350200L,225861048608L,901148151936L,3573218491998L,14238032956598L,56794010648340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244827Inst : IEnumerable<long>
{
public static readonly long[] Value=A244827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244827.Bytes);
public long this[int i]=>Value[i];

public static A244827Inst Instance=new A244827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244828
{
public static readonly long[] Value={ 5L,25L,117L,573L,2833L,13785L,68311L,339839L,1677913L,8250991L,41042033L,202864491L,1010570485L,5010240575L,24786030031L,123527459073L,613216664859L,3059004849315L,15214286790073L,75565229450871L,374920922490613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244828Inst : IEnumerable<long>
{
public static readonly long[] Value=A244828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244828.Bytes);
public long this[int i]=>Value[i];

public static A244828Inst Instance=new A244828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244829
{
public static readonly long[] Value={ 6L,34L,200L,1162L,6916L,40894L,241778L,1430672L,8475456L,50269530L,298497516L,1774316022L,10556785428L,62863697768L,374624132594L,2233999412230L,13329983230896L,79580534303918L,475323860972326L,2840244474933300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244829Inst : IEnumerable<long>
{
public static readonly long[] Value=A244829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244829.Bytes);
public long this[int i]=>Value[i];

public static A244829Inst Instance=new A244829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244830
{
public static readonly long[] Value={ 7L,47L,315L,2187L,14859L,102301L,707567L,4909019L,34131599L,235879457L,1640010727L,11344645093L,78932862607L,546804464049L,3807531069519L,26553509055677L,184619426459623L,1281567860483415L,8934495943129527L,62115641873469909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244830Inst : IEnumerable<long>
{
public static readonly long[] Value=A244830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244830.Bytes);
public long this[int i]=>Value[i];

public static A244830Inst Instance=new A244830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244831
{
public static readonly long[] Value={ 8L,62L,482L,3792L,29588L,234128L,1843104L,14502774L,115222470L,912575878L,7225657450L,57221629692L,455860849506L,3624824433746L,28817478599294L,229114198330698L,1821915526639762L,14491296852589844L,115291956697930848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244831Inst : IEnumerable<long>
{
public static readonly long[] Value=A244831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244831.Bytes);
public long this[int i]=>Value[i];

public static A244831Inst Instance=new A244831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244832
{
public static readonly long[] Value={ 2L,3L,4L,4L,9L,8L,5L,16L,25L,16L,6L,25L,62L,75L,30L,7L,34L,117L,242L,219L,60L,8L,47L,200L,573L,950L,657L,120L,9L,62L,315L,1162L,2833L,3744L,1947L,230L,10L,79L,482L,2187L,6916L,13785L,14802L,5737L,460L,11L,98L,679L,3792L,14859L,40894L,68311L,58662L,16835L,920L,12L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244832Inst : IEnumerable<long>
{
public static readonly long[] Value=A244832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244832.Bytes);
public long this[int i]=>Value[i];

public static A244832Inst Instance=new A244832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244833
{
public static readonly long[] Value={ 4L,9L,16L,25L,34L,47L,62L,79L,98L,115L,138L,163L,190L,219L,250L,277L,312L,349L,388L,429L,464L,509L,556L,605L,656L,709L,754L,811L,870L,931L,994L,1047L,1114L,1183L,1254L,1327L,1402L,1465L,1544L,1625L,1708L,1793L,1864L,1953L,2044L,2137L,2232L,2329L,2410L,2511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244833Inst : IEnumerable<long>
{
public static readonly long[] Value=A244833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244833.Bytes);
public long this[int i]=>Value[i];

public static A244833Inst Instance=new A244833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244834
{
public static readonly long[] Value={ 8L,25L,62L,117L,200L,315L,482L,679L,948L,1221L,1612L,2039L,2580L,3155L,3870L,4549L,5456L,6393L,7522L,8673L,9928L,11315L,12952L,14597L,16528L,18453L,20512L,22739L,25320L,27871L,30818L,33451L,36776L,40041L,43780L,47435L,51612L,55315L,59940L,64441L,69552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244834Inst : IEnumerable<long>
{
public static readonly long[] Value=A244834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244834.Bytes);
public long this[int i]=>Value[i];

public static A244834Inst Instance=new A244834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244835
{
public static readonly long[] Value={ 16L,75L,242L,573L,1162L,2187L,3792L,6015L,9262L,13157L,18834L,25837L,35450L,46475L,60540L,75733L,95800L,118569L,147542L,178703L,213796L,254841L,303516L,356489L,421292L,488619L,562216L,645721L,742110L,844421L,961734L,1082763L,1224050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244835Inst : IEnumerable<long>
{
public static readonly long[] Value=A244835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244835.Bytes);
public long this[int i]=>Value[i];

public static A244835Inst Instance=new A244835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244836
{
public static readonly long[] Value={ 30L,219L,950L,2833L,6916L,14859L,29588L,53105L,91096L,142873L,221230L,329953L,486452L,685227L,953512L,1261375L,1692336L,2215665L,2897664L,3691943L,4607584L,5752875L,7157736L,8770613L,10766662L,12925703L,15444348L,18397849L,21891900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244836Inst : IEnumerable<long>
{
public static readonly long[] Value=A244836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244836.Bytes);
public long this[int i]=>Value[i];

public static A244836Inst Instance=new A244836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244837
{
public static readonly long[] Value={ 60L,657L,3744L,13785L,40894L,102301L,234128L,469965L,899962L,1546427L,2609956L,4235013L,6691374L,10137699L,14994252L,21202309L,30029182L,41389319L,57093568L,76200471L,100077420L,130353465L,168833560L,216003911L,275053774L,344237817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244837Inst : IEnumerable<long>
{
public static readonly long[] Value=A244837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244837.Bytes);
public long this[int i]=>Value[i];

public static A244837Inst Instance=new A244837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244838
{
public static readonly long[] Value={ 120L,1947L,14802L,68311L,241778L,707567L,1843104L,4169823L,8845276L,16751959L,30898724L,54205781L,92280518L,149540911L,236133224L,354549419L,532056058L,774782421L,1128139914L,1581912569L,2174674256L,2962827439L,4005794864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244838Inst : IEnumerable<long>
{
public static readonly long[] Value=A244838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244838.Bytes);
public long this[int i]=>Value[i];

public static A244838Inst Instance=new A244838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244839
{
public static readonly long[] Value={ 8L,7L,2L,9L,2L,9L,2L,8L,9L,5L,2L,0L,3L,5L,4L,5L,1L,8L,9L,5L,7L,9L,4L,1L,9L,9L,1L,0L,2L,8L,7L,3L,2L,5L,3L,7L,3L,8L,2L,9L,9L,4L,5L,2L,0L,5L,3L,4L,3L,2L,4L,4L,5L,6L,8L,9L,3L,7L,1L,6L,2L,1L,1L,2L,1L,7L,0L,4L,7L,7L,3L,1L,6L,7L,0L,9L,0L,9L,0L,5L,4L,7L,6L,9L,6L,9L,2L,0L,2L,3L,2L,2L,4L,3L,1L,5L,5L,5L,1L,7L,5L,2L,1L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244839Inst : IEnumerable<long>
{
public static readonly long[] Value=A244839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244839.Bytes);
public long this[int i]=>Value[i];

public static A244839Inst Instance=new A244839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244840
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,1L,1L,1L,2L,1L,1L,3L,2L,1L,1L,2L,1L,4L,1L,2L,1L,2L,1L,4L,5L,2L,1L,1L,1L,3L,1L,5L,3L,1L,2L,1L,1L,1L,1L,5L,1L,7L,2L,1L,1L,2L,1L,4L,1L,2L,7L,8L,1L,2L,1L,2L,3L,4L,1L,6L,7L,8L,9L,2L,1L,1L,1L,1L,2L,5L,1L,7L,4L,3L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244840Inst : IEnumerable<long>
{
public static readonly long[] Value=A244840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244840.Bytes);
public long this[int i]=>Value[i];

public static A244840Inst Instance=new A244840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244841
{
public static readonly BigInteger[] Value={ 6L,36L,780L,14196L,4017156L,65514540L,17050729020L,273715645476L,70274600998836L,288161745774346860L,4611068345031103956L,BigInteger.Parse("18889015647572689857420"),BigInteger.Parse("4835666805462139528038300"),BigInteger.Parse("77370924198368872644117636"),BigInteger.Parse("19807014039751725440882699796") };
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
public class A244841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244841Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244841.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A244841.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244841Inst Instance=new A244841Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244842
{
public static readonly BigInteger[] Value={ 0L,99L,10989L,1109889L,111098889L,11110988889L,1111109888889L,111111098888889L,11111110988888889L,1111111109888888889L,BigInteger.Parse("111111111098888888889"),BigInteger.Parse("11111111110988888888889"),BigInteger.Parse("1111111111109888888888889"),BigInteger.Parse("111111111111098888888888889"),BigInteger.Parse("11111111111110988888888888889") };
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
public class A244842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244842Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244842.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A244842.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244842Inst Instance=new A244842Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244843
{
public static readonly long[] Value={ 5L,6L,9L,5L,9L,6L,1L,5L,8L,1L,8L,3L,6L,1L,4L,5L,0L,6L,2L,3L,6L,4L,5L,5L,5L,3L,6L,7L,2L,7L,1L,7L,4L,6L,9L,0L,1L,0L,7L,8L,7L,6L,1L,2L,6L,8L,2L,1L,2L,2L,8L,7L,8L,3L,6L,8L,2L,8L,1L,8L,4L,0L,8L,1L,2L,4L,8L,5L,2L,3L,0L,0L,2L,5L,0L,2L,9L,9L,1L,8L,1L,1L,6L,1L,4L,0L,5L,6L,5L,7L,4L,2L,2L,2L,7L,2L,4L,5L,8L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244843Inst : IEnumerable<long>
{
public static readonly long[] Value=A244843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244843.Bytes);
public long this[int i]=>Value[i];

public static A244843Inst Instance=new A244843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244844
{
public static readonly long[] Value={ 9L,5L,5L,9L,3L,3L,8L,3L,7L,0L,0L,5L,5L,7L,0L,3L,4L,5L,1L,5L,8L,7L,2L,2L,5L,6L,3L,3L,9L,5L,8L,1L,5L,4L,2L,9L,9L,1L,6L,4L,2L,4L,1L,6L,1L,2L,6L,7L,8L,4L,5L,7L,5L,3L,8L,1L,6L,4L,3L,1L,5L,7L,6L,5L,8L,5L,3L,9L,9L,9L,1L,6L,4L,1L,5L,5L,9L,5L,8L,3L,8L,1L,6L,4L,2L,4L,2L,0L,3L,3L,8L,6L,6L,3L,8L,0L,2L,2L,3L,4L,1L,7L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244844Inst : IEnumerable<long>
{
public static readonly long[] Value=A244844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244844.Bytes);
public long this[int i]=>Value[i];

public static A244844Inst Instance=new A244844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244845
{
public static readonly BigInteger[] Value={ 111L,101111L,11011111L,1110111111L,111101111111L,11111011111111L,1111110111111111L,111111101111111111L,11111111011111111111UL,BigInteger.Parse("1111111110111111111111"),BigInteger.Parse("111111111101111111111111"),BigInteger.Parse("11111111111011111111111111"),BigInteger.Parse("1111111111110111111111111111") };
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
public class A244845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244845Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244845.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A244845.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244845Inst Instance=new A244845Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244846
{
public static readonly long[] Value={ 3L,10L,6L,10L,36L,28L,36L,28L,36L,78L,36L,66L,66L,66L,66L,78L,78L,66L,190L,78L,78L,120L,210L,300L,136L,210L,120L,120L,120L,120L,136L,300L,210L,210L,210L,406L,190L,190L,276L,210L,210L,276L,210L,378L,630L,210L,276L,276L,276L,378L,276L,378L,300L,630L,300L,300L,300L,276L,300L,378L,378L,300L,630L,528L,378L,630L,378L,406L,630L,378L,528L,528L,406L,378L,528L,528L,630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244846Inst : IEnumerable<long>
{
public static readonly long[] Value=A244846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244846.Bytes);
public long this[int i]=>Value[i];

public static A244846Inst Instance=new A244846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244847
{
public static readonly long[] Value={ 2L,7L,6L,3L,9L,3L,2L,0L,2L,2L,5L,0L,0L,2L,1L,0L,3L,0L,3L,5L,9L,0L,8L,2L,6L,3L,3L,1L,2L,6L,8L,7L,2L,3L,7L,6L,4L,5L,5L,9L,3L,8L,1L,6L,4L,0L,3L,8L,8L,4L,7L,4L,2L,7L,5L,7L,2L,9L,1L,0L,2L,7L,5L,4L,5L,8L,9L,4L,7L,9L,0L,7L,4L,3L,6L,2L,1L,9L,5L,1L,0L,0L,5L,8L,5L,5L,8L,5L,5L,9L,1L,6L,2L,1L,2L,1L,7L,7L,2L,5L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244847Inst : IEnumerable<long>
{
public static readonly long[] Value=A244847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244847.Bytes);
public long this[int i]=>Value[i];

public static A244847Inst Instance=new A244847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244848
{
public static readonly long[] Value={ 1L,5L,201L,664L,37025L,78171L,3944467L,138044449L,1910108568L,1641098748L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244848Inst : IEnumerable<long>
{
public static readonly long[] Value=A244848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244848.Bytes);
public long this[int i]=>Value[i];

public static A244848Inst Instance=new A244848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244849
{
public static readonly long[] Value={ 1L,7L,90L,155L,8290L,63293L,4338436L,5194868L,62759188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244849Inst : IEnumerable<long>
{
public static readonly long[] Value=A244849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244849.Bytes);
public long this[int i]=>Value[i];

public static A244849Inst Instance=new A244849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244850
{
public static readonly long[] Value={ 1L,0L,4L,6L,8L,5L,4L,5L,9L,4L,3L,3L,0L,7L,1L,1L,7L,6L,2L,6L,2L,1L,5L,8L,4L,3L,6L,5L,8L,3L,9L,5L,0L,3L,6L,1L,5L,6L,6L,3L,0L,6L,1L,8L,8L,4L,2L,2L,9L,2L,8L,6L,5L,9L,2L,4L,0L,8L,9L,7L,9L,9L,0L,3L,2L,4L,4L,5L,1L,6L,1L,1L,6L,4L,6L,0L,4L,9L,9L,5L,6L,6L,7L,8L,9L,2L,4L,0L,1L,9L,5L,0L,8L,7L,1L,2L,2L,5L,4L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244850Inst : IEnumerable<long>
{
public static readonly long[] Value=A244850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244850.Bytes);
public long this[int i]=>Value[i];

public static A244850Inst Instance=new A244850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244851
{
public static readonly long[] Value={ 1L,7L,314L,1655L,11569L,383374L,3052836L,31843469L,458415111L,164840426684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244851Inst : IEnumerable<long>
{
public static readonly long[] Value=A244851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244851.Bytes);
public long this[int i]=>Value[i];

public static A244851Inst Instance=new A244851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244852
{
public static readonly long[] Value={ 1L,17L,149L,146L,7997L,45419L,3972963L,27487124L,406680034L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244852Inst : IEnumerable<long>
{
public static readonly long[] Value=A244852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244852.Bytes);
public long this[int i]=>Value[i];

public static A244852Inst Instance=new A244852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244853
{
public static readonly long[] Value={ 11L,17L,71L,113L,131L,151L,167L,181L,211L,227L,281L,431L,467L,521L,547L,617L,743L,829L,853L,883L,1163L,1193L,1733L,2131L,2137L,3121L,3181L,3413L,3457L,3727L,4441L,5351L,6143L,6151L,6473L,6779L,6823L,6977L,8263L,8293L,8423L,9787L,11273L,11321L,11369L,11483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244853Inst : IEnumerable<long>
{
public static readonly long[] Value=A244853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244853.Bytes);
public long this[int i]=>Value[i];

public static A244853Inst Instance=new A244853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244854
{
public static readonly long[] Value={ 3L,0L,8L,4L,2L,5L,1L,3L,7L,5L,3L,4L,0L,4L,2L,4L,5L,6L,8L,3L,8L,5L,7L,7L,8L,4L,3L,7L,4L,6L,1L,2L,9L,7L,2L,2L,9L,7L,8L,5L,5L,3L,1L,0L,6L,4L,7L,6L,2L,7L,4L,7L,0L,7L,0L,7L,5L,4L,1L,7L,1L,6L,8L,0L,0L,6L,8L,7L,6L,4L,0L,0L,7L,0L,0L,6L,0L,0L,1L,6L,3L,8L,4L,3L,8L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244854Inst : IEnumerable<long>
{
public static readonly long[] Value=A244854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244854.Bytes);
public long this[int i]=>Value[i];

public static A244854Inst Instance=new A244854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244855
{
public static readonly long[] Value={ 0L,0L,15L,80L,624L,4095L,28560L,194480L,1336335L,9150624L,62742240L,429981695L,2947295520L,20200652640L,138458409999L,949005240560L,6504586067280L,44583076827135L,305577005139120L,2094455819300624L,14355614096087055L,98394841894789440L,674408281676875200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244855Inst : IEnumerable<long>
{
public static readonly long[] Value=A244855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244855.Bytes);
public long this[int i]=>Value[i];

public static A244855Inst Instance=new A244855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244856
{
public static readonly BigInteger[] Value={ 1L,1L,7L,95L,1614L,30718L,626434L,13383650L,295692145L,6700461777L,154871912815L,3637093846055L,86539594779772L,2081721640140460L,50542732376144460L,1236960716959913020L,BigInteger.Parse("30483096737455969766"),BigInteger.Parse("755783491624380578998"),BigInteger.Parse("18839297079646725396450") };
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
public class A244856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244856Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244856.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A244856.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244856Inst Instance=new A244856Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244857
{
public static readonly long[] Value={ 1L,111L,315L,1344L,3312L,4416L,6624L,11112L,12312L,31311L,114192L,121716L,134112L,134136L,141312L,231336L,282624L,313416L,314112L,411648L,431136L,613116L,628224L,1112232L,1112832L,1121232L,1122112L,1122312L,1122912L,1143216L,1211232L,1212112L,1212192L,1212312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244857Inst : IEnumerable<long>
{
public static readonly long[] Value=A244857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244857.Bytes);
public long this[int i]=>Value[i];

public static A244857Inst Instance=new A244857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244858
{
public static readonly long[] Value={ 6L,2L,4L,2L,3L,1L,7L,6L,1L,2L,7L,3L,5L,7L,5L,2L,1L,5L,6L,7L,1L,8L,0L,3L,4L,4L,4L,2L,0L,0L,3L,8L,7L,7L,3L,7L,4L,6L,3L,1L,2L,6L,8L,1L,5L,2L,8L,6L,1L,9L,1L,9L,2L,6L,8L,6L,0L,4L,7L,9L,3L,7L,0L,3L,9L,1L,7L,8L,8L,6L,0L,2L,6L,3L,0L,3L,5L,0L,9L,0L,8L,4L,9L,4L,0L,2L,7L,0L,0L,7L,7L,9L,0L,3L,4L,3L,7L,6L,4L,5L,1L,9L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244858Inst : IEnumerable<long>
{
public static readonly long[] Value=A244858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244858.Bytes);
public long this[int i]=>Value[i];

public static A244858Inst Instance=new A244858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244859
{
public static readonly BigInteger[] Value={ 0L,1L,10L,111L,100L,10L,1110L,111111L,1000L,111111111L,10L,11L,11100L,111111L,1111110L,1110L,10000L,1111111111111111L,1111111110L,111111111111111111L,100L,111111L,110L,BigInteger.Parse("1111111111111111111111"),111000L,100L };
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
public class A244859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244859Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244859.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A244859.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244859Inst Instance=new A244859Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244860
{
public static readonly long[] Value={ 1L,1L,1L,2L,0L,1L,2L,0L,1L,2L,0L,1L,1L,1L,1L,0L,3L,0L,1L,1L,1L,2L,0L,0L,2L,0L,1L,1L,1L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244860Inst : IEnumerable<long>
{
public static readonly long[] Value=A244860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244860.Bytes);
public long this[int i]=>Value[i];

public static A244860Inst Instance=new A244860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244861
{
public static readonly long[] Value={ 0L,0L,9L,1L,7L,3L,6L,2L,8L,2L,4L,7L,4L,1L,9L,3L,3L,7L,2L,5L,0L,0L,2L,9L,5L,9L,8L,4L,2L,9L,8L,2L,9L,3L,9L,5L,0L,9L,3L,2L,0L,7L,5L,2L,7L,3L,0L,0L,9L,2L,8L,1L,4L,2L,5L,7L,2L,9L,3L,5L,1L,1L,3L,6L,0L,3L,2L,9L,5L,6L,0L,8L,7L,6L,6L,6L,9L,6L,7L,8L,2L,7L,0L,7L,6L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244861Inst : IEnumerable<long>
{
public static readonly long[] Value=A244861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244861.Bytes);
public long this[int i]=>Value[i];

public static A244861Inst Instance=new A244861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244862
{
public static readonly long[] Value={ 2L,3L,5L,23L,7L,19L,11L,17L,13L,61L,29L,53L,31L,37L,41L,59L,43L,73L,47L,83L,67L,79L,71L,167L,89L,101L,97L,103L,107L,137L,109L,139L,113L,131L,127L,157L,149L,173L,151L,163L,179L,233L,181L,193L,191L,227L,197L,257L,199L,211L,223L,229L,239L,251L,241L,271L,263L,269L,277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244862Inst : IEnumerable<long>
{
public static readonly long[] Value=A244862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244862.Bytes);
public long this[int i]=>Value[i];

public static A244862Inst Instance=new A244862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244863
{
public static readonly long[] Value={ 4L,9L,10L,22L,121L,169L,178L,187L,202L,259L,295L,301L,358L,394L,466L,493L,529L,538L,565L,583L,655L,718L,745L,763L,781L,799L,817L,835L,862L,871L,889L,898L,934L,943L,961L,979L,1003L,1111L,1159L,1177L,1186L,1195L,1267L,1285L,1294L,1339L,1357L,1366L,1393L,1438L,1465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244863Inst : IEnumerable<long>
{
public static readonly long[] Value=A244863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244863.Bytes);
public long this[int i]=>Value[i];

public static A244863Inst Instance=new A244863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244864
{
public static readonly long[] Value={ 1L,10L,49L,165L,440L,1001L,2030L,3774L,6555L,10780L,16951L,25675L,37674L,53795L,75020L,102476L,137445L,181374L,235885L,302785L,384076L,481965L,598874L,737450L,900575L,1091376L,1313235L,1569799L,1864990L,2203015L,2588376L,3025880L,3520649L,4078130L,4704105L,5404701L,6186400L,7056049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244864Inst : IEnumerable<long>
{
public static readonly long[] Value=A244864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244864.Bytes);
public long this[int i]=>Value[i];

public static A244864Inst Instance=new A244864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244865
{
public static readonly long[] Value={ 1L,14L,85L,336L,1023L,2610L,5860L,11942L,22555L,40068L,67677L,109578L,171157L,259196L,382096L,550116L,775629L,1073394L,1460845L,1958396L,2589763L,3382302L,4367364L,5580666L,7062679L,8859032L,11020933L,13605606L,16676745L,20304984L,24568384L,29552936L,35353081L,42072246L,49823397L,58729608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244865Inst : IEnumerable<long>
{
public static readonly long[] Value=A244865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244865.Bytes);
public long this[int i]=>Value[i];

public static A244865Inst Instance=new A244865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244866
{
public static readonly long[] Value={ 1L,18L,114L,438L,1263L,3024L,6356L,12132L,21501L,35926L,57222L,87594L,129675L,186564L,261864L,359720L,484857L,642618L,839002L,1080702L,1375143L,1730520L,2155836L,2660940L,3256565L,3954366L,4766958L,5707954L,6792003L,8034828L,9453264L,11065296L,12890097L,14948066L,17260866L,19851462L,22744159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244866Inst : IEnumerable<long>
{
public static readonly long[] Value=A244866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244866.Bytes);
public long this[int i]=>Value[i];

public static A244866Inst Instance=new A244866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244867
{
public static readonly long[] Value={ 1L,32L,320L,1784L,7040L,22104L,58980L,139320L,299343L,596200L,1115972L,1983488L,3374150L,5527952L,8765880L,13508880L,20299581L,29826960L,42954136L,60749480L,84521228L,115855784L,156659900L,209206920L,276187275L,360763416L,466629372L,598075120L,760055954L,958267040L,1199223344L,1490345120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244867Inst : IEnumerable<long>
{
public static readonly long[] Value=A244867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244867.Bytes);
public long this[int i]=>Value[i];

public static A244867Inst Instance=new A244867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244868
{
public static readonly long[] Value={ 1L,22L,158L,654L,1980L,4906L,10577L,20588L,37059L,62710L,100936L,155882L,232518L,336714L,475315L,656216L,888437L,1182198L,1548994L,2001670L,2554496L,3223242L,4025253L,4979524L,6106775L,7429526L,8972172L,10761058L,12824554L,15193130L,17899431L,20978352L,24467113L,28405334L,32835110L,37801086L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244868Inst : IEnumerable<long>
{
public static readonly long[] Value=A244868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244868.Bytes);
public long this[int i]=>Value[i];

public static A244868Inst Instance=new A244868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244869
{
public static readonly long[] Value={ 1L,9L,43L,143L,379L,859L,1738L,3226L,5597L,9197L,14453L,21881L,32095L,45815L,63876L,87236L,116985L,154353L,200719L,257619L,326755L,410003L,509422L,627262L,765973L,928213L,1116857L,1335005L,1585991L,1873391L,2201032L,2573000L,2993649L,3467609L,3999795L,4595415L,5259979L,5999307L,6819538L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244869Inst : IEnumerable<long>
{
public static readonly long[] Value=A244869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244869.Bytes);
public long this[int i]=>Value[i];

public static A244869Inst Instance=new A244869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244870
{
public static readonly long[] Value={ 1L,8L,37L,121L,318L,717L,1446L,2678L,4639L,7614L,11955L,18087L,26516L,37835L,52732L,71996L,96525L,127332L,165553L,212453L,269434L,338041L,419970L,517074L,631371L,765050L,920479L,1100211L,1306992L,1543767L,1813688L,2120120L,2466649L,2857088L,3295485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244870Inst : IEnumerable<long>
{
public static readonly long[] Value=A244870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244870.Bytes);
public long this[int i]=>Value[i];

public static A244870Inst Instance=new A244870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244871
{
public static readonly long[] Value={ 1L,10L,55L,217L,672L,1755L,4030L,8386L,16135L,29140L,49941L,81915L,129430L,198037L,294652L,427780L,607725L,846846L,1159795L,1563805L,2078956L,2728495L,3539130L,4541382L,5769907L,7263880L,9067345L,11229631L,13805730L,16856745L,20450296L,24661000L,29570905L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244871Inst : IEnumerable<long>
{
public static readonly long[] Value=A244871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244871.Bytes);
public long this[int i]=>Value[i];

public static A244871Inst Instance=new A244871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244872
{
public static readonly long[] Value={ 1L,15L,114L,569L,2138L,6562L,17329L,40765L,87512L,174452L,327137L,582784L,993895L,1632561L,2595510L,4009958L,6040323L,8895861L,12839284L,18196419L,25366968L,34836428L,47189231L,63123163L,83465122L,109188274L,141430667L,181515362L,230972141L,291560851L,365296444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244872Inst : IEnumerable<long>
{
public static readonly long[] Value=A244872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244872.Bytes);
public long this[int i]=>Value[i];

public static A244872Inst Instance=new A244872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244873
{
public static readonly long[] Value={ 1L,29L,289L,1640L,6604L,21122L,57271L,137155L,298184L,599954L,1132942L,2029229L,3475465L,5728289L,9132418L,14141618L,21342771L,31483251L,45501823L,64563278L,90097018L,123839804L,167882881L,224723693L,297322402L,389163424L,504322196L,647537387L,824288767L,1040880947L,1304533204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244873Inst : IEnumerable<long>
{
public static readonly long[] Value=A244873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244873.Bytes);
public long this[int i]=>Value[i];

public static A244873Inst Instance=new A244873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244874
{
public static readonly long[] Value={ 1L,17L,137L,707L,2709L,8417L,22408L,53008L,114251L,228431L,429325L,766167L,1308451L,2151643L,3423880L,5293736L,7979133L,11757477L,16977097L,24070067L,33566489L,46110317L,62476800L,83591624L,110551831L,144648595L,187391933L,240537431L,306115063L,386460183L,484246768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244874Inst : IEnumerable<long>
{
public static readonly long[] Value=A244874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244874.Bytes);
public long this[int i]=>Value[i];

public static A244874Inst Instance=new A244874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244875
{
public static readonly long[] Value={ 1L,21L,179L,938L,3612L,11242L,29947L,70855L,152720L,305330L,573812L,1023939L,1748545L,2875153L,4574922L,7073018L,10660515L,15707931L,22680505L,32155320L,44840378L,61595732L,83456781L,111659833L,147670042L,193211824L,250301858L,321284777L,408871655L,516181395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244875Inst : IEnumerable<long>
{
public static readonly long[] Value=A244875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244875.Bytes);
public long this[int i]=>Value[i];

public static A244875Inst Instance=new A244875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244876
{
public static readonly long[] Value={ 1L,18L,154L,813L,3157L,9880L,26429L,62713L,135470L,271285L,510485L,911840L,1558368L,2564093L,4082142L,6313934L,9519951L,14031732L,20265700L,28738335L,40083439L,55070862L,74627587L,99860383L,132081092L,172833583L,223923623L,287450506L,365841890L,461890475L,578794188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244876Inst : IEnumerable<long>
{
public static readonly long[] Value=A244876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244876.Bytes);
public long this[int i]=>Value[i];

public static A244876Inst Instance=new A244876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244877
{
public static readonly long[] Value={ 1L,108L,3396L,49852L,447777L,2862384L,14265040L,58788720L,208577633L,655618172L,1864806372L,4877412332L,11877770177L,27199536768L,59037366080L,122252641280L,242826555969L,464730264172L,860261412132L,1545252073596L,2700999547873L,4605325025136L,7675844020560L,12529356938800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244877Inst : IEnumerable<long>
{
public static readonly long[] Value=A244877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244877.Bytes);
public long this[int i]=>Value[i];

public static A244877Inst Instance=new A244877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244878
{
public static readonly long[] Value={ 1L,15L,130L,760L,3355L,12043L,36935L,100135L,245870L,556580L,1177295L,2351165L,4469610L,8141210L,14284170L,24247962L,39970575L,64178685L,100639000L,154470030L,232524589L,343854445L,500269705L,717006745L,1013519780L,1414412506L,1950527645L,2660213675L,3590789540L,4800229700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244878Inst : IEnumerable<long>
{
public static readonly long[] Value=A244878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244878.Bytes);
public long this[int i]=>Value[i];

public static A244878Inst Instance=new A244878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244879
{
public static readonly long[] Value={ 1L,18L,129L,571L,1884L,5103L,11998L,25362L,49347L,89848L,154935L,255333L,404950L,621453L,926892L,1348372L,1918773L,2677518L,3671389L,4955391L,6593664L,8660443L,11241066L,14433030L,18347095L,23108436L,28857843L,35752969L,43969626L,53703129L,65169688L,78607848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244879Inst : IEnumerable<long>
{
public static readonly long[] Value=A244879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244879.Bytes);
public long this[int i]=>Value[i];

public static A244879Inst Instance=new A244879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244880
{
public static readonly long[] Value={ 1L,47L,650L,4726L,23219L,87677L,274132L,743724L,1806597L,4016683L,8306078L,16168802L,29904823L,52936313L,90209192L,148694104L,238002057L,371131047L,565361074L,843316046L,1234212155L,1775313397L,2513615996L,3507784580L,4830364045L,6570292131L,8835738822L,11757299770L,15491572031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244880Inst : IEnumerable<long>
{
public static readonly long[] Value=A244880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244880.Bytes);
public long this[int i]=>Value[i];

public static A244880Inst Instance=new A244880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244881
{
public static readonly long[] Value={ 1L,34L,353L,2037L,8272L,26585L,72302L,173502L,377739L,760804L,1437799L,2576795L,4415346L,7280131L,11609996L,17982668L,27145413L,40049910L,57891613L,82153873L,114657092L,157613181L,213685594L,286055210L,378492335L,495435096L,642074499L,824446423L,1049530822L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244881Inst : IEnumerable<long>
{
public static readonly long[] Value=A244881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244881.Bytes);
public long this[int i]=>Value[i];

public static A244881Inst Instance=new A244881Inst();

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