using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A023357
{
public static readonly long[] Value={ 13L,293L,6089L,12823L,37967L,40949L,121687L,192037L,243487L,379679L,409499L,471841L,1006193L,1217131L,1397311L,1438793L,1503613L,1541063L,1754591L,2058629L,2088421L,2346791L,2360357L,2428243L,2458609L,2621527L,2646167L,2721053L,3223247L,3280003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023357Inst : IEnumerable<long>
{
public static readonly long[] Value=A023357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023357.Bytes);
public long this[int i]=>Value[i];

public static A023357Inst Instance=new A023357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023356
{
public static readonly long[] Value={ 10061L,20071L,161093L,200713L,291419L,564979L,600791L,606839L,693079L,1826519L,1876807L,2106407L,2249207L,2471471L,3335369L,3955499L,4542547L,4765609L,4829603L,4955981L,5090507L,5534993L,5866247L,5987921L,6091213L,6399521L,6519613L,6522539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023356Inst : IEnumerable<long>
{
public static readonly long[] Value=A023356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023356.Bytes);
public long this[int i]=>Value[i];

public static A023356Inst Instance=new A023356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023355
{
public static readonly long[] Value={ 103L,937L,4129L,17959L,21067L,38561L,113567L,125539L,179999L,215153L,225779L,293651L,310027L,324449L,341227L,384619L,454417L,458981L,491489L,505919L,521527L,526441L,535351L,612889L,640477L,672439L,766211L,791797L,837047L,849763L,873569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023355Inst : IEnumerable<long>
{
public static readonly long[] Value=A023355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023355.Bytes);
public long this[int i]=>Value[i];

public static A023355Inst Instance=new A023355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023354
{
public static readonly long[] Value={ 4099L,8117L,9587L,36899L,73061L,75527L,214771L,240197L,350219L,385709L,453199L,483649L,501029L,556607L,575119L,616991L,701497L,724597L,880067L,961069L,1230311L,1342501L,1376197L,1558811L,1566847L,1613707L,2450779L,2483711L,2536379L,2598157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023354Inst : IEnumerable<long>
{
public static readonly long[] Value=A023354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023354.Bytes);
public long this[int i]=>Value[i];

public static A023354Inst Instance=new A023354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023353
{
public static readonly long[] Value={ 421L,773L,1567L,4111L,68447L,75721L,111373L,127301L,137927L,140321L,156593L,170767L,177131L,192341L,194687L,202637L,240641L,254407L,254963L,308303L,321821L,332951L,395431L,464131L,515663L,710081L,822893L,856393L,989533L,997123L,1012201L,1047077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023353Inst : IEnumerable<long>
{
public static readonly long[] Value=A023353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023353.Bytes);
public long this[int i]=>Value[i];

public static A023353Inst Instance=new A023353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023352
{
public static readonly long[] Value={ 103L,283L,929L,3931L,7759L,52973L,75853L,90031L,93371L,103561L,106949L,110821L,128111L,130841L,137273L,163861L,198553L,288023L,342389L,357031L,377231L,425681L,429973L,435181L,450311L,490663L,526159L,532199L,552791L,574801L,585733L,599719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023352Inst : IEnumerable<long>
{
public static readonly long[] Value=A023352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023352.Bytes);
public long this[int i]=>Value[i];

public static A023352Inst Instance=new A023352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023351
{
public static readonly long[] Value={ 294793L,2586943L,5360623L,6351613L,7965743L,11141083L,11378453L,13458923L,14884823L,15585523L,18691633L,25387763L,29964293L,30766283L,32388253L,38647723L,40653433L,48716873L,48786593L,52628473L,54270533L,55507853L,56575633L,59103403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023351Inst : IEnumerable<long>
{
public static readonly long[] Value=A023351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023351.Bytes);
public long this[int i]=>Value[i];

public static A023351Inst Instance=new A023351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023350
{
public static readonly long[] Value={ 25589L,220469L,225629L,286619L,783269L,1215629L,1407389L,1542029L,1642919L,2329469L,2776979L,3104159L,4082759L,4229129L,5405999L,5905619L,6548849L,6862859L,7681409L,7904669L,8623799L,8971049L,9599309L,9658469L,9725039L,11420579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023350Inst : IEnumerable<long>
{
public static readonly long[] Value=A023350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023350.Bytes);
public long this[int i]=>Value[i];

public static A023350Inst Instance=new A023350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023349
{
public static readonly long[] Value={ 109891L,324763L,852367L,3371527L,3557797L,4448701L,4471549L,5304661L,5616679L,5688919L,5727349L,7766659L,8028109L,8554999L,9034723L,10867099L,11146987L,12396487L,12926401L,14186611L,18274513L,19251517L,20882713L,21810493L,23953921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023349Inst : IEnumerable<long>
{
public static readonly long[] Value=A023349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023349.Bytes);
public long this[int i]=>Value[i];

public static A023349Inst Instance=new A023349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023348
{
public static readonly long[] Value={ 774791L,924731L,4593221L,5181641L,9905521L,11523361L,11755831L,12253321L,14078711L,14545331L,14928791L,18523361L,18686531L,24169001L,25614361L,26221051L,26834461L,30970201L,33446521L,40051021L,42888191L,43703201L,47528561L,48653951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023348Inst : IEnumerable<long>
{
public static readonly long[] Value=A023348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023348.Bytes);
public long this[int i]=>Value[i];

public static A023348Inst Instance=new A023348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023347
{
public static readonly long[] Value={ 831167L,1154567L,2502767L,3019787L,3675197L,5056577L,6352487L,14519177L,26724377L,43003577L,47378927L,47695607L,56406197L,86332457L,86611757L,99568757L,121967987L,126435527L,127990997L,128149127L,128975057L,145281557L,155715407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023347Inst : IEnumerable<long>
{
public static readonly long[] Value=A023347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023347.Bytes);
public long this[int i]=>Value[i];

public static A023347Inst Instance=new A023347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023346
{
public static readonly long[] Value={ 4259L,174079L,253369L,275699L,448859L,527159L,539639L,649969L,1101509L,1218559L,1230629L,1319729L,1426889L,1780939L,1929899L,1947109L,1960919L,2082469L,2087419L,2262409L,2479619L,2499169L,2797999L,2808359L,2809439L,2813339L,3089059L,3363749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023346Inst : IEnumerable<long>
{
public static readonly long[] Value=A023346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023346.Bytes);
public long this[int i]=>Value[i];

public static A023346Inst Instance=new A023346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023345
{
public static readonly long[] Value={ 13L,4637L,5849L,5923L,16183L,16979L,34919L,36277L,67003L,79337L,115571L,159739L,175141L,245753L,249133L,305717L,341569L,359353L,383833L,437263L,455317L,498497L,511519L,567121L,579961L,581699L,633797L,683831L,693431L,849197L,972197L,1022449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023345Inst : IEnumerable<long>
{
public static readonly long[] Value=A023345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023345.Bytes);
public long this[int i]=>Value[i];

public static A023345Inst Instance=new A023345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023344
{
public static readonly long[] Value={ 7L,7621L,15937L,382933L,462271L,518803L,866941L,1025407L,1142503L,1427347L,1742473L,1980067L,2343619L,2910031L,3015283L,4344121L,4352269L,4544209L,5081893L,5116543L,5127043L,5482531L,5484379L,5501473L,5648221L,6452899L,7213897L,7968469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023344Inst : IEnumerable<long>
{
public static readonly long[] Value=A023344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023344.Bytes);
public long this[int i]=>Value[i];

public static A023344Inst Instance=new A023344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023343
{
public static readonly long[] Value={ 79L,34127L,345431L,549089L,669937L,703663L,948593L,978749L,999007L,1251329L,1255333L,1279133L,1500277L,1517413L,1525421L,1642769L,1670629L,1688101L,1727161L,1770127L,2152159L,2161343L,2328517L,2622167L,2745451L,2786681L,2837557L,3281777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023343Inst : IEnumerable<long>
{
public static readonly long[] Value=A023343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023343.Bytes);
public long this[int i]=>Value[i];

public static A023343Inst Instance=new A023343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023342
{
public static readonly long[] Value={ 5333L,26669L,294167L,324869L,344189L,578297L,676829L,807407L,894893L,1078559L,1114427L,1174487L,1624349L,1883363L,2247923L,2926769L,3075029L,3196871L,3427871L,3558407L,4037039L,4205879L,5392799L,6130823L,6479423L,6714497L,6750113L,6915299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023342Inst : IEnumerable<long>
{
public static readonly long[] Value=A023342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023342.Bytes);
public long this[int i]=>Value[i];

public static A023342Inst Instance=new A023342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023341
{
public static readonly long[] Value={ 135859L,174877L,192979L,244219L,292561L,679297L,842341L,964897L,1076029L,1470241L,1990579L,2004943L,2339263L,2615707L,2625577L,2633557L,2892277L,3003787L,3201901L,3758233L,4406797L,5065861L,5157547L,5390857L,5424961L,5546173L,5875369L,7746217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023341Inst : IEnumerable<long>
{
public static readonly long[] Value=A023341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023341.Bytes);
public long this[int i]=>Value[i];

public static A023341Inst Instance=new A023341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023340
{
public static readonly long[] Value={ 18257L,19541L,22063L,48383L,73037L,73133L,78173L,88261L,93811L,101051L,104537L,152377L,153941L,162343L,168043L,175523L,204251L,211681L,238463L,287341L,375253L,386713L,423961L,659513L,672181L,676103L,688027L,741283L,759491L,770951L,786673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023340Inst : IEnumerable<long>
{
public static readonly long[] Value=A023340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023340.Bytes);
public long this[int i]=>Value[i];

public static A023340Inst Instance=new A023340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023339
{
public static readonly long[] Value={ 9769L,13781L,17231L,32059L,32611L,36251L,46381L,47417L,55171L,68927L,103451L,130447L,182599L,189671L,220687L,236627L,241169L,273641L,275711L,350219L,374159L,413951L,471769L,497579L,498439L,520631L,521791L,583777L,601061L,635809L,647401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023339Inst : IEnumerable<long>
{
public static readonly long[] Value=A023339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023339.Bytes);
public long this[int i]=>Value[i];

public static A023339Inst Instance=new A023339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023338
{
public static readonly long[] Value={ 233L,709L,11699L,16417L,24481L,31663L,63317L,94999L,172279L,185243L,205081L,228713L,240347L,266681L,285539L,334511L,372059L,395719L,479327L,583501L,734197L,786613L,856627L,863711L,1146091L,1187167L,1188259L,1423067L,1534591L,1562269L,1594301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023338Inst : IEnumerable<long>
{
public static readonly long[] Value=A023338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023338.Bytes);
public long this[int i]=>Value[i];

public static A023338Inst Instance=new A023338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023337
{
public static readonly long[] Value={ 3181L,61981L,134291L,342821L,459091L,882451L,984931L,1016011L,1028471L,1181701L,1391561L,1897801L,2009311L,2272301L,2476421L,2769791L,3048041L,3085421L,3128821L,3207221L,3545111L,4092931L,4690591L,5015321L,5863651L,6027941L,6361351L,6796541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023337Inst : IEnumerable<long>
{
public static readonly long[] Value=A023337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023337.Bytes);
public long this[int i]=>Value[i];

public static A023337Inst Instance=new A023337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023336
{
public static readonly long[] Value={ 34613L,165443L,321053L,363403L,474143L,496333L,528673L,631853L,834503L,957563L,1199623L,1274803L,1817093L,1918733L,2063423L,2611663L,2889703L,3224233L,3652703L,3697433L,3824413L,3852973L,4655873L,4708793L,5089943L,5508263L,5937853L,6067073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023336Inst : IEnumerable<long>
{
public static readonly long[] Value=A023336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023336.Bytes);
public long this[int i]=>Value[i];

public static A023336Inst Instance=new A023336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023335
{
public static readonly long[] Value={ 10009L,575119L,724499L,1373819L,1725359L,3188569L,3715669L,4980499L,5939779L,9202199L,9565709L,13707469L,14483839L,14886829L,15412739L,16158589L,16740709L,18207349L,19429409L,22428209L,22602719L,22722419L,22749019L,22877119L,24171209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023335Inst : IEnumerable<long>
{
public static readonly long[] Value=A023335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023335.Bytes);
public long this[int i]=>Value[i];

public static A023335Inst Instance=new A023335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023334
{
public static readonly long[] Value={ 11L,4931L,21991L,23021L,37691L,44531L,46021L,57601L,62081L,95621L,124171L,135731L,142111L,189271L,191251L,195511L,216571L,222841L,238291L,251611L,269431L,319211L,368021L,391031L,413411L,427711L,468581L,476591L,625831L,638431L,682951L,701671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023334Inst : IEnumerable<long>
{
public static readonly long[] Value=A023334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023334.Bytes);
public long this[int i]=>Value[i];

public static A023334Inst Instance=new A023334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023333
{
public static readonly long[] Value={ 14723L,20123L,54713L,109433L,594653L,604883L,676493L,759953L,847103L,935843L,1035743L,1049603L,1079033L,1099823L,1222253L,1263323L,1499153L,1754033L,1835003L,1893173L,2017283L,2071493L,2099213L,2199653L,2895743L,2998313L,3389693L,4133663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023333Inst : IEnumerable<long>
{
public static readonly long[] Value=A023333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023333.Bytes);
public long this[int i]=>Value[i];

public static A023333Inst Instance=new A023333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023332
{
public static readonly long[] Value={ 13L,541L,1087L,1861L,3727L,23293L,40387L,87643L,98899L,109111L,115153L,116329L,119101L,131617L,133597L,163909L,197521L,214021L,215389L,218227L,238207L,263239L,294751L,489901L,493693L,665527L,734131L,767881L,808693L,895351L,1038127L,1051957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023332Inst : IEnumerable<long>
{
public static readonly long[] Value=A023332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023332.Bytes);
public long this[int i]=>Value[i];

public static A023332Inst Instance=new A023332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023331
{
public static readonly long[] Value={ 47L,67L,1427L,6047L,12097L,16057L,44507L,76537L,92387L,100057L,132707L,209647L,263387L,354247L,407947L,465407L,477727L,507757L,775237L,787477L,788687L,865327L,907367L,955457L,1015517L,1121387L,1178197L,1302277L,1360367L,1524247L,1623707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023331Inst : IEnumerable<long>
{
public static readonly long[] Value=A023331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023331.Bytes);
public long this[int i]=>Value[i];

public static A023331Inst Instance=new A023331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023330
{
public static readonly long[] Value={ 89L,63419L,127139L,405269L,810809L,1069199L,1122659L,1178609L,1333889L,1598699L,1806089L,1958249L,2164229L,2245319L,2329469L,2606069L,2848949L,3241289L,3339989L,3784199L,3962039L,4088879L,4328459L,4444829L,4658939L,4664249L,4894889L,4897709L,5132999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023330Inst : IEnumerable<long>
{
public static readonly long[] Value=A023330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023330.Bytes);
public long this[int i]=>Value[i];

public static A023330Inst Instance=new A023330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023329
{
public static readonly long[] Value={ 13L,139L,293L,1889L,2939L,3719L,6089L,7741L,12823L,19753L,21391L,22861L,28513L,36721L,37967L,40949L,60899L,76519L,83621L,101747L,121687L,127549L,128239L,142099L,149197L,153817L,155581L,158489L,160159L,169283L,173651L,180749L,185831L,192037L,198221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023329Inst : IEnumerable<long>
{
public static readonly long[] Value=A023329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023329.Bytes);
public long this[int i]=>Value[i];

public static A023329Inst Instance=new A023329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023328
{
public static readonly long[] Value={ 2L,10061L,11777L,17489L,17839L,19379L,19441L,20071L,21773L,30809L,32069L,36529L,39511L,40973L,45503L,52223L,66943L,83813L,100613L,112213L,120067L,135089L,144427L,151573L,156887L,161093L,164999L,179111L,179497L,185923L,200713L,219943L,227489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023328Inst : IEnumerable<long>
{
public static readonly long[] Value=A023328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023328.Bytes);
public long this[int i]=>Value[i];

public static A023328Inst Instance=new A023328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023327
{
public static readonly long[] Value={ 103L,281L,293L,823L,937L,1733L,3361L,3919L,4129L,6101L,8443L,15413L,16217L,17959L,21067L,26459L,26479L,30253L,31247L,36691L,37171L,38561L,40493L,41411L,46451L,57709L,60869L,64621L,79433L,79987L,89821L,92821L,113567L,114997L,118873L,125539L,142573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023327Inst : IEnumerable<long>
{
public static readonly long[] Value=A023327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023327.Bytes);
public long this[int i]=>Value[i];

public static A023327Inst Instance=new A023327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023326
{
public static readonly long[] Value={ 397L,467L,907L,1747L,1901L,4099L,7237L,8117L,8581L,9371L,9587L,23539L,28081L,32611L,36899L,41729L,54767L,55207L,57601L,61991L,64997L,66449L,73061L,74821L,75527L,86291L,115021L,118717L,125659L,126067L,134287L,140677L,147011L,148147L,151531L,171539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023326Inst : IEnumerable<long>
{
public static readonly long[] Value=A023326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023326.Bytes);
public long this[int i]=>Value[i];

public static A023326Inst Instance=new A023326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023325
{
public static readonly long[] Value={ 3L,107L,421L,773L,1567L,1637L,3793L,4111L,6961L,12721L,14107L,17851L,26267L,26557L,31327L,33503L,37003L,42281L,57947L,60091L,65423L,67427L,68447L,75721L,82223L,82657L,87877L,96377L,108107L,111373L,113171L,122117L,123887L,125497L,125887L,127301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023325Inst : IEnumerable<long>
{
public static readonly long[] Value=A023325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023325.Bytes);
public long this[int i]=>Value[i];

public static A023325Inst Instance=new A023325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023068
{
public static readonly long[] Value={ 1254L,2541L,10254L,12540L,12564L,12654L,25401L,25410L,25641L,26541L,100254L,102540L,102564L,102654L,122454L,122544L,124542L,125400L,125442L,125640L,125664L,126540L,126564L,126654L,135063L,135306L,136053L,136305L,150363L,153036L,160353L,163035L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023068Inst : IEnumerable<long>
{
public static readonly long[] Value=A023068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023068.Bytes);
public long this[int i]=>Value[i];

public static A023068Inst Instance=new A023068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023067
{
public static readonly long[] Value={ 1045L,10045L,10225L,10450L,10455L,10545L,100045L,100225L,100450L,100455L,100545L,101125L,102250L,102255L,103353L,103425L,103452L,104500L,104550L,104555L,105234L,105450L,105455L,105545L,1000045L,1000225L,1000450L,1000455L,1000545L,1001125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023067Inst : IEnumerable<long>
{
public static readonly long[] Value=A023067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023067.Bytes);
public long this[int i]=>Value[i];

public static A023067Inst Instance=new A023067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023066
{
public static readonly long[] Value={ 10144L,10432L,11454L,12345L,100144L,100432L,101440L,101544L,102043L,102435L,104302L,104320L,104325L,105432L,114540L,114554L,115454L,120453L,123045L,123450L,123455L,123545L,124535L,125345L,1000144L,1000432L,1001440L,1001544L,1002043L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023066Inst : IEnumerable<long>
{
public static readonly long[] Value=A023066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023066.Bytes);
public long this[int i]=>Value[i];

public static A023066Inst Instance=new A023066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023065
{
public static readonly long[] Value={ 1243L,10324L,10432L,12043L,12304L,12345L,12403L,12430L,12435L,12543L,13024L,13042L,13425L,14253L,14325L,14523L,15243L,100324L,100432L,102534L,103204L,103240L,103254L,103452L,103524L,104032L,104320L,104352L,105234L,105342L,105432L,120043L,120304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023065Inst : IEnumerable<long>
{
public static readonly long[] Value=A023065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023065.Bytes);
public long this[int i]=>Value[i];

public static A023065Inst Instance=new A023065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023064
{
public static readonly long[] Value={ 1342L,2134L,10432L,12043L,12345L,12435L,13042L,13204L,13402L,13420L,13425L,13524L,13542L,14032L,14203L,14235L,15234L,15342L,20134L,20314L,20413L,20431L,21043L,21304L,21340L,21354L,21403L,21534L,23415L,23451L,23514L,24135L,24351L,25134L,100432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023064Inst : IEnumerable<long>
{
public static readonly long[] Value=A023064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023064.Bytes);
public long this[int i]=>Value[i];

public static A023064Inst Instance=new A023064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023063
{
public static readonly long[] Value={ 1034L,10034L,10340L,10344L,10434L,100034L,100340L,100344L,100434L,102243L,102342L,102423L,103400L,103440L,103444L,104340L,104344L,104434L,1000034L,1000340L,1000344L,1000434L,1002243L,1002342L,1002423L,1003400L,1003440L,1003444L,1004340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023063Inst : IEnumerable<long>
{
public static readonly long[] Value=A023063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023063.Bytes);
public long this[int i]=>Value[i];

public static A023063Inst Instance=new A023063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023062
{
public static readonly long[] Value={ 1032L,1234L,10032L,10320L,10322L,10432L,11402L,12014L,12234L,12340L,12344L,12434L,100032L,100320L,100322L,100432L,101343L,103200L,103220L,103222L,103321L,104320L,104322L,104432L,110332L,112334L,114002L,114020L,114022L,114402L,120014L,120140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023062Inst : IEnumerable<long>
{
public static readonly long[] Value=A023062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023062.Bytes);
public long this[int i]=>Value[i];

public static A023062Inst Instance=new A023062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023061
{
public static readonly long[] Value={ 13L,130L,143L,1300L,1313L,1430L,1443L,13000L,13013L,13130L,13143L,14300L,14313L,14430L,14443L,102342L,103242L,120234L,120324L,130000L,130013L,130130L,130143L,131300L,131313L,131430L,131443L,143000L,143013L,143130L,143143L,144300L,144313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023061Inst : IEnumerable<long>
{
public static readonly long[] Value=A023061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023061.Bytes);
public long this[int i]=>Value[i];

public static A023061Inst Instance=new A023061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023060
{
public static readonly long[] Value={ 1023L,10023L,10113L,10230L,10233L,10323L,100023L,100113L,100230L,100233L,100323L,101130L,101133L,101232L,102300L,102330L,102333L,103230L,103233L,103323L,1000023L,1000113L,1000230L,1000233L,1000323L,1001130L,1001133L,1001232L,1002300L,1002330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023060Inst : IEnumerable<long>
{
public static readonly long[] Value=A023060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023060.Bytes);
public long this[int i]=>Value[i];

public static A023060Inst Instance=new A023060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023059
{
public static readonly long[] Value={ 102L,123L,1002L,1020L,1032L,1203L,1230L,1233L,1302L,1323L,10002L,10020L,10032L,10200L,10221L,10320L,10332L,11022L,11223L,12003L,12030L,12033L,12231L,12300L,12330L,12333L,13002L,13020L,13032L,13203L,13230L,13233L,13302L,13323L,100002L,100020L,100032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023059Inst : IEnumerable<long>
{
public static readonly long[] Value=A023059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023059.Bytes);
public long this[int i]=>Value[i];

public static A023059Inst Instance=new A023059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023058
{
public static readonly long[] Value={ 1012L,10012L,10120L,10122L,10212L,100012L,100120L,100122L,100212L,101200L,101220L,101222L,102120L,102122L,102212L,1000012L,1000120L,1000122L,1000212L,1001200L,1001220L,1001222L,1002120L,1002122L,1002212L,1012000L,1012200L,1012220L,1012222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023058Inst : IEnumerable<long>
{
public static readonly long[] Value=A023058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023058.Bytes);
public long this[int i]=>Value[i];

public static A023058Inst Instance=new A023058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023057
{
public static readonly long[] Value={ 6L,14L,22L,29L,31L,34L,42L,44L,46L,50L,52L,54L,58L,62L,64L,66L,70L,72L,78L,82L,84L,86L,88L,90L,91L,96L,98L,102L,105L,110L,111L,114L,117L,118L,120L,122L,124L,126L,130L,132L,134L,136L,140L,142L,153L,156L,158L,160L,162L,164L,165L,172L,176L,177L,178L,179L,181L,182L,188L,190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023057Inst : IEnumerable<long>
{
public static readonly long[] Value=A023057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023057.Bytes);
public long this[int i]=>Value[i];

public static A023057Inst Instance=new A023057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023056
{
public static readonly long[] Value={ 8L,25L,1L,4L,27L,0L,9L,97336L,16L,2187L,3125L,2197L,36L,0L,49L,128L,64L,225L,81L,196L,100L,0L,2025L,1000L,144L,42849L,169L,484L,0L,6859L,0L,7744L,256L,0L,289L,1728L,14348907L,1331L,361L,2704L,400L,0L,441L,0L,9216L,0L,529L,21904L,576L,0L,625L,0L,676L,0L,729L,5776L,784L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023056Inst : IEnumerable<long>
{
public static readonly long[] Value=A023056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023056.Bytes);
public long this[int i]=>Value[i];

public static A023056Inst Instance=new A023056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023055
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,10L,11L,12L,13L,15L,16L,17L,18L,19L,20L,21L,23L,24L,25L,26L,27L,28L,30L,32L,33L,35L,36L,37L,38L,39L,40L,41L,43L,45L,47L,48L,49L,51L,53L,55L,56L,57L,59L,60L,61L,63L,65L,67L,68L,69L,71L,73L,74L,75L,76L,77L,79L,80L,81L,83L,85L,87L,89L,92L,93L,94L,95L,97L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023055Inst : IEnumerable<long>
{
public static readonly long[] Value=A023055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023055.Bytes);
public long this[int i]=>Value[i];

public static A023055Inst Instance=new A023055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023054
{
public static readonly long[] Value={ 1L,1L,3L,4L,7L,8L,13L,14L,20L,22L,29L,31L,40L,42L,52L,55L,66L,69L,82L,85L,99L,103L,118L,122L,139L,143L,161L,166L,185L,190L,211L,216L,238L,244L,267L,273L,298L,304L,330L,337L,364L,371L,400L,407L,437L,445L,476L,484L,517L,525L,559L,568L,603L,612L,649L,658L,696L,706L,745L,755L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023054Inst : IEnumerable<long>
{
public static readonly long[] Value=A023054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023054.Bytes);
public long this[int i]=>Value[i];

public static A023054Inst Instance=new A023054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023053
{
public static readonly long[] Value={ 1L,0L,2L,7L,34L,171L,905L,4952L,27802L,159254L,927081L,5468960L,32621669L,196422509L,1192294778L,7288208927L,44825586130L,277196752569L,1722454028174L,10749430579118L,67346519863117L,423425225290485L,2670741276559282L,16895070479910967L,107165705513319749L,681438064187707596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A023053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023053Inst : IEnumerable<long>
{
public static readonly long[] Value=A023053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023053.Bytes);
public long this[int i]=>Value[i];

public static A023053Inst Instance=new A023053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022988
{
public static readonly long[] Value={ 32L,31L,30L,29L,28L,27L,26L,25L,24L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,-1L,-2L,-3L,-4L,-5L,-6L,-7L,-8L,-9L,-10L,-11L,-12L,-13L,-14L,-15L,-16L,-17L,-18L,-19L,-20L,-21L,-22L,-23L,-24L,-25L,-26L,-27L,-28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022988Inst : IEnumerable<long>
{
public static readonly long[] Value=A022988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022988.Bytes);
public long this[int i]=>Value[i];

public static A022988Inst Instance=new A022988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022987
{
public static readonly long[] Value={ 31L,30L,29L,28L,27L,26L,25L,24L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,-1L,-2L,-3L,-4L,-5L,-6L,-7L,-8L,-9L,-10L,-11L,-12L,-13L,-14L,-15L,-16L,-17L,-18L,-19L,-20L,-21L,-22L,-23L,-24L,-25L,-26L,-27L,-28L,-29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022987Inst : IEnumerable<long>
{
public static readonly long[] Value=A022987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022987.Bytes);
public long this[int i]=>Value[i];

public static A022987Inst Instance=new A022987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022986
{
public static readonly long[] Value={ 30L,29L,28L,27L,26L,25L,24L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,-1L,-2L,-3L,-4L,-5L,-6L,-7L,-8L,-9L,-10L,-11L,-12L,-13L,-14L,-15L,-16L,-17L,-18L,-19L,-20L,-21L,-22L,-23L,-24L,-25L,-26L,-27L,-28L,-29L,-30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022986Inst : IEnumerable<long>
{
public static readonly long[] Value=A022986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022986.Bytes);
public long this[int i]=>Value[i];

public static A022986Inst Instance=new A022986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022985
{
public static readonly long[] Value={ 29L,28L,27L,26L,25L,24L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,-1L,-2L,-3L,-4L,-5L,-6L,-7L,-8L,-9L,-10L,-11L,-12L,-13L,-14L,-15L,-16L,-17L,-18L,-19L,-20L,-21L,-22L,-23L,-24L,-25L,-26L,-27L,-28L,-29L,-30L,-31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022985Inst : IEnumerable<long>
{
public static readonly long[] Value=A022985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022985.Bytes);
public long this[int i]=>Value[i];

public static A022985Inst Instance=new A022985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022984
{
public static readonly long[] Value={ 28L,27L,26L,25L,24L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,-1L,-2L,-3L,-4L,-5L,-6L,-7L,-8L,-9L,-10L,-11L,-12L,-13L,-14L,-15L,-16L,-17L,-18L,-19L,-20L,-21L,-22L,-23L,-24L,-25L,-26L,-27L,-28L,-29L,-30L,-31L,-32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022984Inst : IEnumerable<long>
{
public static readonly long[] Value=A022984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022984.Bytes);
public long this[int i]=>Value[i];

public static A022984Inst Instance=new A022984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022983
{
public static readonly long[] Value={ 27L,26L,25L,24L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,-1L,-2L,-3L,-4L,-5L,-6L,-7L,-8L,-9L,-10L,-11L,-12L,-13L,-14L,-15L,-16L,-17L,-18L,-19L,-20L,-21L,-22L,-23L,-24L,-25L,-26L,-27L,-28L,-29L,-30L,-31L,-32L,-33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022983Inst : IEnumerable<long>
{
public static readonly long[] Value=A022983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022983.Bytes);
public long this[int i]=>Value[i];

public static A022983Inst Instance=new A022983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022982
{
public static readonly long[] Value={ 26L,25L,24L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,-1L,-2L,-3L,-4L,-5L,-6L,-7L,-8L,-9L,-10L,-11L,-12L,-13L,-14L,-15L,-16L,-17L,-18L,-19L,-20L,-21L,-22L,-23L,-24L,-25L,-26L,-27L,-28L,-29L,-30L,-31L,-32L,-33L,-34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022982Inst : IEnumerable<long>
{
public static readonly long[] Value=A022982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022982.Bytes);
public long this[int i]=>Value[i];

public static A022982Inst Instance=new A022982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022981
{
public static readonly long[] Value={ 25L,24L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,-1L,-2L,-3L,-4L,-5L,-6L,-7L,-8L,-9L,-10L,-11L,-12L,-13L,-14L,-15L,-16L,-17L,-18L,-19L,-20L,-21L,-22L,-23L,-24L,-25L,-26L,-27L,-28L,-29L,-30L,-31L,-32L,-33L,-34L,-35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022981Inst : IEnumerable<long>
{
public static readonly long[] Value=A022981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022981.Bytes);
public long this[int i]=>Value[i];

public static A022981Inst Instance=new A022981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022980
{
public static readonly long[] Value={ 24L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,-1L,-2L,-3L,-4L,-5L,-6L,-7L,-8L,-9L,-10L,-11L,-12L,-13L,-14L,-15L,-16L,-17L,-18L,-19L,-20L,-21L,-22L,-23L,-24L,-25L,-26L,-27L,-28L,-29L,-30L,-31L,-32L,-33L,-34L,-35L,-36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022980Inst : IEnumerable<long>
{
public static readonly long[] Value=A022980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022980.Bytes);
public long this[int i]=>Value[i];

public static A022980Inst Instance=new A022980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022979
{
public static readonly long[] Value={ 23L,22L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,-1L,-2L,-3L,-4L,-5L,-6L,-7L,-8L,-9L,-10L,-11L,-12L,-13L,-14L,-15L,-16L,-17L,-18L,-19L,-20L,-21L,-22L,-23L,-24L,-25L,-26L,-27L,-28L,-29L,-30L,-31L,-32L,-33L,-34L,-35L,-36L,-37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022979Inst : IEnumerable<long>
{
public static readonly long[] Value=A022979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022979.Bytes);
public long this[int i]=>Value[i];

public static A022979Inst Instance=new A022979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022978
{
public static readonly long[] Value={ 22L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,-1L,-2L,-3L,-4L,-5L,-6L,-7L,-8L,-9L,-10L,-11L,-12L,-13L,-14L,-15L,-16L,-17L,-18L,-19L,-20L,-21L,-22L,-23L,-24L,-25L,-26L,-27L,-28L,-29L,-30L,-31L,-32L,-33L,-34L,-35L,-36L,-37L,-38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022978Inst : IEnumerable<long>
{
public static readonly long[] Value=A022978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022978.Bytes);
public long this[int i]=>Value[i];

public static A022978Inst Instance=new A022978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022977
{
public static readonly long[] Value={ 21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,-1L,-2L,-3L,-4L,-5L,-6L,-7L,-8L,-9L,-10L,-11L,-12L,-13L,-14L,-15L,-16L,-17L,-18L,-19L,-20L,-21L,-22L,-23L,-24L,-25L,-26L,-27L,-28L,-29L,-30L,-31L,-32L,-33L,-34L,-35L,-36L,-37L,-38L,-39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022977Inst : IEnumerable<long>
{
public static readonly long[] Value=A022977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022977.Bytes);
public long this[int i]=>Value[i];

public static A022977Inst Instance=new A022977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022976
{
public static readonly long[] Value={ 20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,-1L,-2L,-3L,-4L,-5L,-6L,-7L,-8L,-9L,-10L,-11L,-12L,-13L,-14L,-15L,-16L,-17L,-18L,-19L,-20L,-21L,-22L,-23L,-24L,-25L,-26L,-27L,-28L,-29L,-30L,-31L,-32L,-33L,-34L,-35L,-36L,-37L,-38L,-39L,-40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022976Inst : IEnumerable<long>
{
public static readonly long[] Value=A022976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022976.Bytes);
public long this[int i]=>Value[i];

public static A022976Inst Instance=new A022976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022975
{
public static readonly long[] Value={ 19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,-1L,-2L,-3L,-4L,-5L,-6L,-7L,-8L,-9L,-10L,-11L,-12L,-13L,-14L,-15L,-16L,-17L,-18L,-19L,-20L,-21L,-22L,-23L,-24L,-25L,-26L,-27L,-28L,-29L,-30L,-31L,-32L,-33L,-34L,-35L,-36L,-37L,-38L,-39L,-40L,-41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022975Inst : IEnumerable<long>
{
public static readonly long[] Value=A022975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022975.Bytes);
public long this[int i]=>Value[i];

public static A022975Inst Instance=new A022975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022974
{
public static readonly long[] Value={ 18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,-1L,-2L,-3L,-4L,-5L,-6L,-7L,-8L,-9L,-10L,-11L,-12L,-13L,-14L,-15L,-16L,-17L,-18L,-19L,-20L,-21L,-22L,-23L,-24L,-25L,-26L,-27L,-28L,-29L,-30L,-31L,-32L,-33L,-34L,-35L,-36L,-37L,-38L,-39L,-40L,-41L,-42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022974Inst : IEnumerable<long>
{
public static readonly long[] Value=A022974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022974.Bytes);
public long this[int i]=>Value[i];

public static A022974Inst Instance=new A022974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022973
{
public static readonly long[] Value={ 17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,-1L,-2L,-3L,-4L,-5L,-6L,-7L,-8L,-9L,-10L,-11L,-12L,-13L,-14L,-15L,-16L,-17L,-18L,-19L,-20L,-21L,-22L,-23L,-24L,-25L,-26L,-27L,-28L,-29L,-30L,-31L,-32L,-33L,-34L,-35L,-36L,-37L,-38L,-39L,-40L,-41L,-42L,-43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022973Inst : IEnumerable<long>
{
public static readonly long[] Value=A022973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022973.Bytes);
public long this[int i]=>Value[i];

public static A022973Inst Instance=new A022973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022956
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,9L,11L,14L,18L,22L,26L,30L,35L,41L,46L,51L,58L,65L,71L,78L,86L,94L,102L,110L,119L,128L,138L,147L,157L,167L,178L,189L,200L,211L,223L,236L,248L,260L,273L,288L,301L,314L,328L,344L,358L,373L,388L,405L,420L,436L,452L,471L,487L,504L,521L,541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022956Inst : IEnumerable<long>
{
public static readonly long[] Value=A022956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022956.Bytes);
public long this[int i]=>Value[i];

public static A022956Inst Instance=new A022956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022955
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,10L,14L,19L,22L,27L,34L,38L,44L,52L,58L,65L,75L,82L,90L,101L,110L,119L,131L,141L,151L,164L,176L,187L,201L,215L,227L,242L,257L,270L,287L,303L,317L,335L,352L,367L,386L,405L,421L,441L,461L,478L,500L,521L,539L,562L,584L,603L,628L,651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022955Inst : IEnumerable<long>
{
public static readonly long[] Value=A022955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022955.Bytes);
public long this[int i]=>Value[i];

public static A022955Inst Instance=new A022955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022954
{
public static readonly long[] Value={ 1L,8L,13L,19L,26L,35L,45L,56L,68L,82L,97L,113L,130L,148L,168L,189L,211L,234L,258L,283L,310L,338L,367L,397L,428L,460L,493L,527L,563L,600L,638L,677L,717L,758L,800L,843L,887L,933L,980L,1028L,1077L,1127L,1178L,1230L,1283L,1337L,1392L,1449L,1507L,1566L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022954Inst : IEnumerable<long>
{
public static readonly long[] Value=A022954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022954.Bytes);
public long this[int i]=>Value[i];

public static A022954Inst Instance=new A022954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022953
{
public static readonly long[] Value={ 1L,7L,12L,18L,26L,35L,45L,56L,69L,83L,98L,114L,131L,150L,170L,191L,213L,236L,260L,285L,312L,340L,369L,399L,430L,462L,495L,529L,565L,602L,640L,679L,719L,760L,802L,845L,889L,935L,982L,1030L,1079L,1129L,1180L,1232L,1285L,1339L,1394L,1451L,1509L,1568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022953Inst : IEnumerable<long>
{
public static readonly long[] Value=A022953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022953.Bytes);
public long this[int i]=>Value[i];

public static A022953Inst Instance=new A022953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022952
{
public static readonly long[] Value={ 3L,6L,10L,15L,22L,30L,39L,50L,62L,75L,89L,105L,122L,140L,159L,179L,200L,223L,247L,272L,298L,325L,353L,382L,413L,445L,478L,512L,547L,583L,620L,658L,698L,739L,781L,824L,868L,913L,959L,1006L,1054L,1103L,1154L,1206L,1259L,1313L,1368L,1424L,1481L,1539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022952Inst : IEnumerable<long>
{
public static readonly long[] Value=A022952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022952.Bytes);
public long this[int i]=>Value[i];

public static A022952Inst Instance=new A022952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022951
{
public static readonly long[] Value={ 2L,3L,8L,14L,21L,30L,40L,51L,63L,76L,91L,107L,124L,142L,161L,181L,203L,226L,250L,275L,301L,328L,356L,385L,416L,448L,481L,515L,550L,586L,623L,661L,700L,741L,783L,826L,870L,915L,961L,1008L,1056L,1105L,1155L,1207L,1260L,1314L,1369L,1425L,1482L,1540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022951Inst : IEnumerable<long>
{
public static readonly long[] Value=A022951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022951.Bytes);
public long this[int i]=>Value[i];

public static A022951Inst Instance=new A022951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022950
{
public static readonly long[] Value={ 1L,7L,11L,16L,22L,30L,39L,49L,61L,74L,88L,103L,120L,138L,157L,177L,198L,221L,245L,270L,296L,323L,351L,380L,411L,443L,476L,510L,545L,581L,618L,656L,696L,737L,779L,822L,866L,911L,957L,1004L,1052L,1102L,1153L,1205L,1258L,1312L,1367L,1423L,1480L,1538L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022950Inst : IEnumerable<long>
{
public static readonly long[] Value=A022950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022950.Bytes);
public long this[int i]=>Value[i];

public static A022950Inst Instance=new A022950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022949
{
public static readonly long[] Value={ 1L,6L,10L,15L,22L,30L,39L,50L,62L,75L,89L,105L,122L,140L,159L,179L,200L,223L,247L,272L,298L,325L,353L,382L,413L,445L,478L,512L,547L,583L,620L,658L,698L,739L,781L,824L,868L,913L,959L,1006L,1054L,1103L,1154L,1206L,1259L,1313L,1368L,1424L,1481L,1539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022949Inst : IEnumerable<long>
{
public static readonly long[] Value=A022949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022949.Bytes);
public long this[int i]=>Value[i];

public static A022949Inst Instance=new A022949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022948
{
public static readonly long[] Value={ 1L,4L,9L,15L,22L,30L,40L,51L,63L,76L,90L,106L,123L,141L,160L,180L,201L,224L,248L,273L,299L,326L,354L,383L,414L,446L,479L,513L,548L,584L,621L,659L,698L,739L,781L,824L,868L,913L,959L,1006L,1054L,1103L,1153L,1205L,1258L,1312L,1367L,1423L,1480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022948Inst : IEnumerable<long>
{
public static readonly long[] Value=A022948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022948.Bytes);
public long this[int i]=>Value[i];

public static A022948Inst Instance=new A022948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022947
{
public static readonly long[] Value={ 1L,3L,8L,14L,21L,30L,40L,51L,63L,76L,91L,107L,124L,142L,161L,181L,203L,226L,250L,275L,301L,328L,356L,385L,416L,448L,481L,515L,550L,586L,623L,661L,700L,741L,783L,826L,870L,915L,961L,1008L,1056L,1105L,1155L,1207L,1260L,1314L,1369L,1425L,1482L,1540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022947Inst : IEnumerable<long>
{
public static readonly long[] Value=A022947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022947.Bytes);
public long this[int i]=>Value[i];

public static A022947Inst Instance=new A022947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022946
{
public static readonly long[] Value={ 1L,2L,7L,13L,21L,30L,40L,51L,63L,77L,92L,108L,125L,143L,162L,182L,204L,227L,251L,276L,302L,329L,357L,386L,417L,449L,482L,516L,551L,587L,624L,662L,701L,742L,784L,827L,871L,916L,962L,1009L,1057L,1106L,1156L,1208L,1261L,1315L,1370L,1426L,1483L,1541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022946Inst : IEnumerable<long>
{
public static readonly long[] Value=A022946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022946.Bytes);
public long this[int i]=>Value[i];

public static A022946Inst Instance=new A022946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022945
{
public static readonly long[] Value={ 1L,4L,9L,15L,22L,30L,40L,51L,63L,76L,90L,106L,123L,141L,160L,180L,201L,224L,248L,273L,299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022945Inst : IEnumerable<long>
{
public static readonly long[] Value=A022945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022945.Bytes);
public long this[int i]=>Value[i];

public static A022945Inst Instance=new A022945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022944
{
public static readonly long[] Value={ 2L,4L,5L,10L,12L,18L,21L,29L,34L,43L,49L,59L,66L,78L,86L,100L,109L,124L,134L,150L,161L,178L,191L,209L,223L,242L,258L,278L,295L,316L,334L,356L,375L,398L,419L,443L,465L,490L,513L,540L,564L,592L,617L,646L,672L,702L,729L,760L,789L,821L,851L,884L,915L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022944Inst : IEnumerable<long>
{
public static readonly long[] Value=A022944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022944.Bytes);
public long this[int i]=>Value[i];

public static A022944Inst Instance=new A022944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022943
{
public static readonly long[] Value={ 2L,3L,6L,8L,13L,17L,23L,28L,35L,42L,50L,58L,68L,77L,88L,98L,110L,122L,135L,148L,162L,177L,192L,208L,224L,241L,258L,277L,295L,315L,334L,355L,375L,398L,419L,443L,465L,490L,513L,539L,564L,591L,617L,645L,672L,701L,729L,760L,789L,821L,851L,884L,915L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022943Inst : IEnumerable<long>
{
public static readonly long[] Value=A022943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022943.Bytes);
public long this[int i]=>Value[i];

public static A022943Inst Instance=new A022943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022942
{
public static readonly long[] Value={ 1L,2L,5L,8L,12L,17L,22L,28L,35L,42L,50L,58L,68L,77L,88L,98L,111L,122L,136L,148L,163L,177L,193L,208L,225L,241L,259L,277L,296L,315L,335L,355L,376L,398L,420L,443L,466L,490L,514L,539L,565L,591L,618L,645L,673L,701L,730L,760L,790L,821L,852L,884L,916L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022942Inst : IEnumerable<long>
{
public static readonly long[] Value=A022942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022942.Bytes);
public long this[int i]=>Value[i];

public static A022942Inst Instance=new A022942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022941
{
public static readonly long[] Value={ 1L,2L,5L,9L,15L,22L,30L,40L,51L,63L,76L,90L,106L,123L,141L,160L,180L,201L,224L,248L,273L,299L,326L,354L,383L,414L,446L,479L,513L,548L,584L,621L,659L,698L,739L,781L,824L,868L,913L,959L,1006L,1054L,1103L,1153L,1205L,1258L,1312L,1367L,1423L,1480L,1538L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022941Inst : IEnumerable<long>
{
public static readonly long[] Value=A022941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022941.Bytes);
public long this[int i]=>Value[i];

public static A022941Inst Instance=new A022941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022924
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022924Inst : IEnumerable<long>
{
public static readonly long[] Value=A022924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022924.Bytes);
public long this[int i]=>Value[i];

public static A022924Inst Instance=new A022924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022923
{
public static readonly long[] Value={ 2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022923Inst : IEnumerable<long>
{
public static readonly long[] Value=A022923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022923.Bytes);
public long this[int i]=>Value[i];

public static A022923Inst Instance=new A022923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022922
{
public static readonly long[] Value={ 2L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022922Inst : IEnumerable<long>
{
public static readonly long[] Value=A022922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022922.Bytes);
public long this[int i]=>Value[i];

public static A022922Inst Instance=new A022922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022921
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,2L,2L,1L,2L,1L,2L,2L,1L,2L,1L,2L,1L,2L,2L,1L,2L,1L,2L,2L,1L,2L,1L,2L,1L,2L,2L,1L,2L,1L,2L,2L,1L,2L,1L,2L,1L,2L,2L,1L,2L,1L,2L,2L,1L,2L,1L,2L,2L,1L,2L,1L,2L,1L,2L,2L,1L,2L,1L,2L,2L,1L,2L,1L,2L,1L,2L,2L,1L,2L,1L,2L,2L,1L,2L,1L,2L,1L,2L,2L,1L,2L,1L,2L,2L,1L,2L,1L,2L,1L,2L,2L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022921Inst : IEnumerable<long>
{
public static readonly long[] Value=A022921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022921.Bytes);
public long this[int i]=>Value[i];

public static A022921Inst Instance=new A022921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022920
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,7L,0L,12L,0L,61L,0L,131L,0L,472L,0L,2039L,0L,5924L,0L,21095L,0L,76058L,0L,274023L,0L,1032989L,0L,3694643L,0L,12987172L,0L,48417270L,0L,174274092L,0L,642785629L,0L,2402825962L,0L,8918414212L,0L,32868915523L,0L,123145191037L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022920Inst : IEnumerable<long>
{
public static readonly long[] Value=A022920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022920.Bytes);
public long this[int i]=>Value[i];

public static A022920Inst Instance=new A022920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022919
{
public static readonly BigInteger[] Value={ 1L,1L,4L,504L,5765760L,11779303536000L,BigInteger.Parse("7077067947620326656000"),BigInteger.Parse("1858415281524390197256677213184000"),BigInteger.Parse("296452547038365950028519606090501848174100480000"),BigInteger.Parse("38078735219928394229608103398446248260205826730163060269056000000") };
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
public class A022919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022919Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022919.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022919.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022919Inst Instance=new A022919Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022918
{
public static readonly BigInteger[] Value={ 1L,5L,10010L,1455680976750L,BigInteger.Parse("4492014649431378228480321000"),BigInteger.Parse("128588605335042465692190540763466217456052544386524000") };
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
public class A022918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022918Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022918.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022918.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022918Inst Instance=new A022918Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022917
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,60L,180L,630L,2520L,7560L,25200L,92400L,369600L,1201200L,4204200L,15765750L,63063000L,214414200L,771891120L,2933186256L,11732745024L,41064607584L,150570227808L,577185873264L,2308743493056L,8245512475200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022917Inst : IEnumerable<long>
{
public static readonly long[] Value=A022917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022917.Bytes);
public long this[int i]=>Value[i];

public static A022917Inst Instance=new A022917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022916
{
public static readonly long[] Value={ 1L,1L,2L,6L,12L,30L,90L,210L,560L,1680L,4200L,11550L,34650L,90090L,252252L,756756L,2018016L,5717712L,17153136L,46558512L,133024320L,399072960L,1097450640L,3155170590L,9465511770L,26293088250L,75957810500L,227873431500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022916Inst : IEnumerable<long>
{
public static readonly long[] Value=A022916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022916.Bytes);
public long this[int i]=>Value[i];

public static A022916Inst Instance=new A022916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022915
{
public static readonly BigInteger[] Value={ 1L,1L,3L,60L,12600L,37837800L,2053230379200L,2431106898187968000L,BigInteger.Parse("73566121315513295589120000"),BigInteger.Parse("65191584694745586153436251091200000"),BigInteger.Parse("1906765806522767212441719098019963758016000000"),BigInteger.Parse("2048024348726152339387799085049745725891853852479488000000") };
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
public class A022915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022915Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022915.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022915.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022915Inst Instance=new A022915Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022914
{
public static readonly BigInteger[] Value={ 1L,2L,12L,1120L,50450400L,1387660381886338560L,BigInteger.Parse("58833957894412548628347941194431580569600"),BigInteger.Parse("54468560860672704568758301042326371229883670125439070950586847311164532855256159027200000") };
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
public class A022914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022914Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022914.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022914.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022914Inst Instance=new A022914Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022913
{
public static readonly long[] Value={ 1L,2L,5L,14L,31L,64L,102L,134L,173L,207L,246L,282L,321L,360L,397L,436L,474L,509L,544L,580L,616L,649L,682L,713L,742L,768L,792L,813L,830L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022913Inst : IEnumerable<long>
{
public static readonly long[] Value=A022913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022913.Bytes);
public long this[int i]=>Value[i];

public static A022913Inst Instance=new A022913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022912
{
public static readonly long[] Value={ 2L,2L,2L,3L,2L,2L,3L,2L,2L,2L,3L,2L,4L,2L,3L,2L,2L,2L,3L,4L,2L,2L,3L,2L,2L,2L,4L,3L,2L,5L,2L,2L,3L,2L,2L,4L,2L,3L,2L,2L,2L,3L,5L,2L,4L,2L,2L,3L,2L,2L,2L,2L,3L,2L,4L,2L,2L,5L,3L,2L,2L,2L,6L,2L,3L,2L,4L,2L,2L,2L,3L,2L,2L,2L,5L,2L,3L,4L,2L,2L,2L,3L,2L,2L,2L,2L,6L,3L,4L,5L,3L,3L,4L,3L,3L,6L,5L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022912Inst : IEnumerable<long>
{
public static readonly long[] Value=A022912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022912.Bytes);
public long this[int i]=>Value[i];

public static A022912Inst Instance=new A022912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022911
{
public static readonly long[] Value={ 4L,5L,6L,6L,7L,8L,7L,9L,10L,11L,8L,12L,8L,13L,9L,14L,15L,16L,10L,9L,17L,18L,11L,19L,20L,21L,10L,12L,22L,10L,23L,24L,13L,25L,26L,11L,27L,14L,28L,29L,30L,15L,11L,31L,12L,32L,33L,16L,34L,35L,36L,37L,17L,38L,13L,39L,40L,12L,18L,41L,42L,43L,12L,44L,19L,45L,14L,46L,47L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022911Inst : IEnumerable<long>
{
public static readonly long[] Value=A022911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022911.Bytes);
public long this[int i]=>Value[i];

public static A022911Inst Instance=new A022911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022910
{
public static readonly long[] Value={ 0L,2L,1L,1L,2L,3L,4L,4L,3L,4L,5L,6L,7L,7L,6L,7L,8L,9L,10L,9L,9L,10L,11L,12L,12L,12L,11L,12L,14L,15L,15L,14L,12L,13L,15L,18L,16L,14L,14L,15L,16L,18L,17L,16L,15L,17L,19L,20L,20L,19L,17L,18L,20L,23L,21L,18L,18L,20L,21L,23L,22L,20L,18L,21L,24L,25L,24L,22L,20L,21L,24L,28L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022910Inst : IEnumerable<long>
{
public static readonly long[] Value=A022910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022910.Bytes);
public long this[int i]=>Value[i];

public static A022910Inst Instance=new A022910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022909
{
public static readonly long[] Value={ 0L,2L,1L,0L,0L,0L,1L,2L,3L,1L,0L,0L,1L,2L,3L,3L,2L,0L,3L,5L,5L,4L,4L,3L,4L,6L,7L,5L,4L,4L,5L,6L,7L,6L,5L,4L,6L,7L,8L,7L,6L,5L,7L,8L,9L,7L,6L,6L,7L,8L,9L,9L,8L,6L,9L,10L,9L,8L,8L,8L,9L,11L,10L,9L,8L,8L,9L,10L,11L,10L,9L,8L,10L,11L,11L,10L,10L,9L,11L,12L,12L,10L,9L,9L,10L,11L,12L,12L,11L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022909Inst : IEnumerable<long>
{
public static readonly long[] Value=A022909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022909.Bytes);
public long this[int i]=>Value[i];

public static A022909Inst Instance=new A022909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022908
{
public static readonly long[] Value={ 0L,2L,5L,11L,20L,35L,56L,86L,125L,179L,248L,338L,449L,590L,761L,971L,1220L,1523L,1880L,2306L,2801L,3386L,4061L,4847L,5744L,6782L,7961L,9311L,10832L,12563L,14504L,16694L,19133L,21875L,24920L,28322L,32081L,36266L,40877L,45983L,51584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022908Inst : IEnumerable<long>
{
public static readonly long[] Value=A022908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022908.Bytes);
public long this[int i]=>Value[i];

public static A022908Inst Instance=new A022908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022907
{
public static readonly long[] Value={ 0L,2L,5L,8L,14L,20L,29L,38L,53L,68L,89L,110L,140L,170L,209L,248L,302L,356L,425L,494L,584L,674L,785L,896L,1037L,1178L,1349L,1520L,1730L,1940L,2189L,2438L,2741L,3044L,3401L,3758L,4184L,4610L,5105L,5600L,6185L,6770L,7445L,8120L,8906L,9692L,10589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022907Inst : IEnumerable<long>
{
public static readonly long[] Value=A022907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022907.Bytes);
public long this[int i]=>Value[i];

public static A022907Inst Instance=new A022907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022906
{
public static readonly long[] Value={ 1L,0L,0L,1L,2L,3L,3L,2L,0L,3L,5L,6L,6L,5L,3L,4L,6L,9L,7L,4L,4L,6L,7L,9L,8L,6L,4L,7L,10L,11L,10L,8L,5L,7L,10L,14L,10L,7L,6L,8L,10L,13L,10L,8L,6L,10L,13L,14L,13L,11L,8L,9L,12L,17L,12L,8L,9L,12L,13L,15L,13L,9L,8L,12L,16L,17L,15L,12L,9L,11L,15L,20L,14L,10L,10L,13L,14L,18L,14L,11L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022906Inst : IEnumerable<long>
{
public static readonly long[] Value=A022906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022906.Bytes);
public long this[int i]=>Value[i];

public static A022906Inst Instance=new A022906Inst();

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