using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A200057
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,4L,1L,6L,10L,4L,1L,8L,22L,26L,6L,1L,10L,36L,78L,68L,10L,1L,12L,56L,172L,288L,178L,14L,1L,14L,78L,324L,840L,1098L,472L,22L,1L,16L,106L,546L,1948L,4172L,4224L,1276L,34L,1L,18L,136L,850L,3914L,11962L,20978L,16432L,3462L,52L,1L,20L,172L,1252L,7074L,28554L,74338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200057Inst : IEnumerable<long>
{
public static readonly long[] Value=A200057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200057.Bytes);
public long this[int i]=>Value[i];

public static A200057Inst Instance=new A200057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200058
{
public static readonly long[] Value={ 4L,26L,78L,172L,324L,546L,850L,1252L,1764L,2398L,3170L,4092L,5176L,6438L,7890L,9544L,11416L,13518L,15862L,18464L,21336L,24490L,27942L,31704L,35788L,40210L,44982L,50116L,55628L,61530L,67834L,74556L,81708L,89302L,97354L,105876L,114880L,124382L,134394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200058Inst : IEnumerable<long>
{
public static readonly long[] Value=A200058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200058.Bytes);
public long this[int i]=>Value[i];

public static A200058Inst Instance=new A200058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200059
{
public static readonly long[] Value={ 6L,68L,288L,840L,1948L,3914L,7074L,11862L,18732L,28244L,40970L,57598L,78816L,105444L,138284L,178282L,226362L,283598L,351026L,429852L,521230L,626492L,746910L,883944L,1038982L,1213616L,1409348L,1627896L,1870884L,2140158L,2437454L,2764750L,3123900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200059Inst : IEnumerable<long>
{
public static readonly long[] Value=A200059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200059.Bytes);
public long this[int i]=>Value[i];

public static A200059Inst Instance=new A200059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200060
{
public static readonly long[] Value={ 10L,178L,1098L,4172L,11962L,28554L,59910L,114232L,202314L,337902L,538054L,823496L,1218978L,1753638L,2461350L,3381092L,4557298L,6040218L,7886274L,10158420L,12926498L,16267598L,20266414L,25015604L,30616142L,37177686L,44818926L,53667948L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200060Inst : IEnumerable<long>
{
public static readonly long[] Value=A200060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200060.Bytes);
public long this[int i]=>Value[i];

public static A200060Inst Instance=new A200060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200061
{
public static readonly long[] Value={ 14L,472L,4224L,20978L,74338L,211242L,514168L,1115572L,2215290L,4099888L,7165376L,11941380L,19119208L,29580842L,44432366L,65037696L,93057524L,130487666L,179703518L,243503094L,325156994L,428455996L,557766736L,718083722L,915090720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200061Inst : IEnumerable<long>
{
public static readonly long[] Value=A200061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200061.Bytes);
public long this[int i]=>Value[i];

public static A200061Inst Instance=new A200061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200062
{
public static readonly long[] Value={ 0L,1L,1L,4L,1L,15L,1L,41L,23L,133L,1L,650L,1L,1725L,961L,6930L,1L,30323L,1L,99716L,40431L,352729L,1L,1709125L,35467L,5200315L,2008233L,20960538L,1L,93058849L,1L,312220259L,105533203L,1166803129L,20194059L,5478229800L,1L,17672631921L,5731781295L,71539226243L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200062Inst : IEnumerable<long>
{
public static readonly long[] Value=A200062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200062.Bytes);
public long this[int i]=>Value[i];

public static A200062Inst Instance=new A200062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200063
{
public static readonly long[] Value={ 1L,2L,8L,32L,46L,392L,12230L,155942L,659488L,1025582L,1047128L,3437088L,1449322158L,1452777560L,1691887144L,4558298126L,4840156480L,39554086678L,353617531486L,608231808384L,619986226720L,969355365422L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200063Inst : IEnumerable<long>
{
public static readonly long[] Value=A200063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200063.Bytes);
public long this[int i]=>Value[i];

public static A200063Inst Instance=new A200063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200064
{
public static readonly long[] Value={ 1L,3L,1L,8L,2L,3L,4L,4L,1L,5L,7L,8L,6L,5L,8L,8L,4L,7L,2L,4L,0L,2L,3L,4L,0L,8L,1L,6L,6L,4L,5L,1L,1L,3L,1L,2L,1L,8L,7L,1L,3L,6L,2L,0L,4L,8L,6L,2L,7L,6L,7L,7L,4L,8L,8L,6L,2L,2L,8L,6L,6L,2L,6L,7L,6L,4L,7L,0L,4L,7L,5L,7L,6L,0L,4L,2L,4L,0L,1L,1L,7L,9L,4L,0L,5L,3L,0L,8L,2L,0L,1L,4L,0L,6L,3L,1L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200064Inst : IEnumerable<long>
{
public static readonly long[] Value=A200064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200064.Bytes);
public long this[int i]=>Value[i];

public static A200064Inst Instance=new A200064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200065
{
public static readonly long[] Value={ 0L,0L,13L,0L,0L,0L,17L,0L,19L,0L,1111111111111111111L,0L,113L,0L,0L,0L,1117L,0L,11119L,0L,111121L,0L,1123L,0L,0L,0L,127L,0L,1129L,0L,131L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200065Inst : IEnumerable<long>
{
public static readonly long[] Value=A200065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200065.Bytes);
public long this[int i]=>Value[i];

public static A200065Inst Instance=new A200065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200066
{
public static readonly long[] Value={ 3L,4L,5L,5L,6L,7L,8L,9L,10L,11L,11L,13L,17L,19L,19L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200066Inst : IEnumerable<long>
{
public static readonly long[] Value=A200066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200066.Bytes);
public long this[int i]=>Value[i];

public static A200066Inst Instance=new A200066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200067
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,6L,12L,20L,30L,45L,63L,84L,112L,144L,180L,225L,275L,330L,396L,468L,546L,637L,735L,840L,960L,1088L,1224L,1377L,1539L,1710L,1900L,2100L,2310L,2541L,2783L,3036L,3312L,3600L,3900L,4225L,4563L,4914L,5292L,5684L,6090L,6525L,6975L,7440L,7936L,8448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200067Inst : IEnumerable<long>
{
public static readonly long[] Value=A200067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200067.Bytes);
public long this[int i]=>Value[i];

public static A200067Inst Instance=new A200067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200068
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,5L,1L,1L,1L,7L,3L,1L,3L,0L,0L,2L,11L,4L,2L,4L,3L,1L,3L,0L,1L,1L,1L,0L,1L,15L,8L,3L,8L,3L,3L,7L,1L,2L,3L,1L,3L,2L,0L,1L,2L,0L,0L,1L,0L,1L,22L,11L,7L,12L,4L,5L,13L,5L,4L,7L,4L,4L,5L,0L,3L,6L,2L,1L,2L,1L,2L,3L,0L,0L,2L,1L,0L,0L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200068Inst : IEnumerable<long>
{
public static readonly long[] Value=A200068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200068.Bytes);
public long this[int i]=>Value[i];

public static A200068Inst Instance=new A200068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200069
{
public static readonly long[] Value={ 1L,4L,29L,168L,1049L,6380L,39157L,239568L,1467313L,8983636L,55009613L,336825720L,2062427849L,12628445756L,77325345061L,473471175072L,2899114186081L,17751582020260L,108694812500093L,665549816263752L,4075231827556217L,24953074921653644L,152790313444845397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200069Inst : IEnumerable<long>
{
public static readonly long[] Value=A200069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200069.Bytes);
public long this[int i]=>Value[i];

public static A200069Inst Instance=new A200069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200070
{
public static readonly long[] Value={ 110L,182L,220L,364L,374L,440L,494L,550L,728L,748L,782L,880L,988L,1100L,1210L,1274L,1334L,1456L,1496L,1564L,1760L,1976L,2200L,2294L,2366L,2420L,2548L,2668L,2750L,2912L,2992L,3128L,3182L,3520L,3854L,3952L,4114L,4400L,4588L,4732L,4840L,4982L,5096L,5336L,5500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200070Inst : IEnumerable<long>
{
public static readonly long[] Value=A200070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200070.Bytes);
public long this[int i]=>Value[i];

public static A200070Inst Instance=new A200070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200071
{
public static readonly long[] Value={ 447L,2042L,4942L,8673L,17232L,18321L,38232L,52953L,54468L,54974L,55174L,57229L,66567L,71132L,83071L,101499L,113667L,121206L,133047L,173932L,297907L,325286L,430353L,447131L,656079L,702969L,842151L,937313L,1061846L,1173886L,1613346L,1721094L,1754679L,1759310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200071Inst : IEnumerable<long>
{
public static readonly long[] Value=A200071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200071.Bytes);
public long this[int i]=>Value[i];

public static A200071Inst Instance=new A200071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200072
{
public static readonly long[] Value={ 1123L,1143L,6235L,8457L,11565L,21917L,22857L,33285L,41319L,58195L,119571L,124723L,128363L,173922L,178703L,188115L,243939L,280158L,308859L,309709L,409485L,430581L,565571L,703845L,961237L,1153362L,1170291L,1327998L,1409794L,1536651L,1586195L,1649395L,1665868L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200072Inst : IEnumerable<long>
{
public static readonly long[] Value=A200072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200072.Bytes);
public long this[int i]=>Value[i];

public static A200072Inst Instance=new A200072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200073
{
public static readonly long[] Value={ 1L,4L,3L,11L,15L,5L,29L,56L,35L,7L,76L,189L,171L,66L,9L,199L,605L,715L,407L,110L,11L,521L,1872L,2730L,2054L,832L,169L,13L,1364L,5655L,9810L,9180L,4965L,1533L,245L,15L,3571L,16779L,33745L,37774L,25585L,10642L,2618L,340L,17L,9349L,49096L,112309L,146357L,119168L,62453L,20862L,4218L,456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200073Inst : IEnumerable<long>
{
public static readonly long[] Value=A200073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200073.Bytes);
public long this[int i]=>Value[i];

public static A200073Inst Instance=new A200073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200074
{
public static readonly long[] Value={ 1L,1L,3L,9L,30L,108L,406L,1577L,6280L,25499L,105169L,439388L,1855636L,7908909L,33975250L,146954693L,639460707L,2797384235L,12295494109L,54272825103L,240480529815L,1069257987503L,4769306203838L,21334400243252L,95687482105807L,430217846136134L,1938651904470374L,8754225470415889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200074Inst : IEnumerable<long>
{
public static readonly long[] Value=A200074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200074.Bytes);
public long this[int i]=>Value[i];

public static A200074Inst Instance=new A200074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200075
{
public static readonly long[] Value={ 1L,1L,3L,11L,45L,198L,914L,4367L,21414L,107155L,544987L,2808978L,14640073L,77025373L,408544815L,2182206259L,11727989593L,63373962690L,344109933186L,1876562458845L,10273572074493L,56443282489240L,311097732946200L,1719707775782826L,9531914043637385L,52963938340248863L,294966593345731623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200075Inst : IEnumerable<long>
{
public static readonly long[] Value=A200075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200075.Bytes);
public long this[int i]=>Value[i];

public static A200075Inst Instance=new A200075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200076
{
public static readonly long[] Value={ 1L,3L,3L,3L,7L,9L,9L,15L,7L,3L,11L,29L,43L,73L,25L,5L,27L,53L,97L,123L,29L,41L,93L,85L,35L,35L,17L,9L,55L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200076Inst : IEnumerable<long>
{
public static readonly long[] Value=A200076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200076.Bytes);
public long this[int i]=>Value[i];

public static A200076Inst Instance=new A200076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200077
{
public static readonly long[] Value={ 1L,4L,6L,8L,14L,18L,24L,56L,26L,26L,54L,226L,260L,482L,196L,54L,128L,728L,1226L,4106L,1168L,272L,892L,4798L,1390L,1298L,962L,216L,470L,2104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200077Inst : IEnumerable<long>
{
public static readonly long[] Value=A200077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200077.Bytes);
public long this[int i]=>Value[i];

public static A200077Inst Instance=new A200077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200078
{
public static readonly long[] Value={ 1L,5L,9L,17L,27L,37L,85L,169L,151L,219L,533L,1553L,2333L,4197L,2607L,2419L,6343L,25235L,55337L,113875L,35671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200078Inst : IEnumerable<long>
{
public static readonly long[] Value=A200078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200078.Bytes);
public long this[int i]=>Value[i];

public static A200078Inst Instance=new A200078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200079
{
public static readonly long[] Value={ 1L,6L,12L,26L,58L,108L,202L,394L,468L,848L,2560L,7740L,11372L,28356L,20660L,20032L,68026L,312678L,662542L,1536878L,812306L,461910L,1466416L,10325202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200079Inst : IEnumerable<long>
{
public static readonly long[] Value=A200079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200079.Bytes);
public long this[int i]=>Value[i];

public static A200079Inst Instance=new A200079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200080
{
public static readonly long[] Value={ 1L,7L,17L,43L,111L,245L,429L,855L,1863L,3573L,10241L,30645L,50043L,160499L,149009L,149121L,755895L,3366835L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200080Inst : IEnumerable<long>
{
public static readonly long[] Value=A200080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200080.Bytes);
public long this[int i]=>Value[i];

public static A200080Inst Instance=new A200080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200081
{
public static readonly long[] Value={ 1L,8L,22L,64L,182L,454L,1046L,2546L,5056L,11638L,33262L,101112L,191802L,688304L,769106L,1102184L,5220960L,23546744L,49886556L,135889790L,142614238L,121124812L,570957758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200081Inst : IEnumerable<long>
{
public static readonly long[] Value=A200081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200081.Bytes);
public long this[int i]=>Value[i];

public static A200081Inst Instance=new A200081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200082
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,1L,4L,3L,2L,1L,5L,6L,3L,2L,1L,6L,9L,8L,7L,2L,1L,7L,12L,17L,14L,9L,2L,1L,8L,17L,26L,27L,18L,9L,2L,1L,9L,22L,43L,58L,37L,24L,15L,2L,1L,10L,27L,64L,111L,108L,85L,56L,7L,2L,1L,11L,34L,89L,182L,245L,202L,169L,26L,3L,2L,1L,12L,41L,122L,279L,454L,429L,394L,151L,26L,11L,2L,1L,13L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200082Inst : IEnumerable<long>
{
public static readonly long[] Value=A200082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200082.Bytes);
public long this[int i]=>Value[i];

public static A200082Inst Instance=new A200082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200083
{
public static readonly long[] Value={ 2L,3L,8L,17L,26L,43L,64L,89L,122L,163L,208L,269L,334L,407L,496L,597L,702L,831L,968L,1117L,1286L,1471L,1664L,1889L,2122L,2371L,2648L,2945L,3250L,3595L,3952L,4329L,4738L,5171L,5616L,6109L,6614L,7143L,7712L,8309L,8918L,9583L,10264L,10973L,11726L,12511L,13312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200083Inst : IEnumerable<long>
{
public static readonly long[] Value=A200083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200083.Bytes);
public long this[int i]=>Value[i];

public static A200083Inst Instance=new A200083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200084
{
public static readonly long[] Value={ 2L,7L,14L,27L,58L,111L,182L,279L,404L,617L,872L,1199L,1580L,2045L,2678L,3437L,4300L,5305L,6430L,7903L,9530L,11389L,13420L,15707L,18460L,21537L,24870L,28553L,32518L,37265L,42342L,47905L,53828L,60267L,67620L,75589L,84034L,93127L,102734L,113729L,125300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200084Inst : IEnumerable<long>
{
public static readonly long[] Value=A200084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200084.Bytes);
public long this[int i]=>Value[i];

public static A200084Inst Instance=new A200084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200085
{
public static readonly long[] Value={ 2L,9L,18L,37L,108L,245L,454L,759L,1172L,2001L,3144L,4663L,6568L,8945L,12690L,17353L,23022L,29787L,37710L,48921L,62130L,77465L,95100L,115177L,141596L,171767L,205850L,244065L,286652L,340277L,400038L,466375L,539488L,619685L,717388L,824733L,942014L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200085Inst : IEnumerable<long>
{
public static readonly long[] Value=A200085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200085.Bytes);
public long this[int i]=>Value[i];

public static A200085Inst Instance=new A200085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200086
{
public static readonly long[] Value={ 2L,9L,24L,85L,202L,429L,1046L,2145L,4022L,6955L,11438L,17927L,26868L,41817L,62238L,89715L,125864L,172459L,231700L,305753L,409430L,537577L,695264L,886875L,1116878L,1391945L,1717032L,2134089L,2625830L,3201035L,3869292L,4642295L,5530982L,6546651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200086Inst : IEnumerable<long>
{
public static readonly long[] Value=A200086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200086.Bytes);
public long this[int i]=>Value[i];

public static A200086Inst Instance=new A200086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200087
{
public static readonly long[] Value={ 1L,2L,53L,5L,71L,26L,9L,8L,19L,72L,149L,27L,91L,18L,21L,17L,43L,20L,29L,50L,35L,150L,45L,28L,99L,92L,773L,34L,171L,42L,33L,32L,123L,44L,49L,41L,75227L,58L,137L,51L,295L,48L,789L,68L,47L,46L,65L,57L,891L,100L,269L,90L,111L,428L,921L,64L,131L,172L,105L,203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200087Inst : IEnumerable<long>
{
public static readonly long[] Value=A200087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200087.Bytes);
public long this[int i]=>Value[i];

public static A200087Inst Instance=new A200087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200088
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,13L,16L,19L,21L,22L,25L,28L,30L,31L,34L,37L,43L,46L,49L,51L,52L,55L,58L,60L,61L,64L,67L,73L,76L,79L,85L,88L,94L,97L,100L,101L,102L,103L,106L,109L,111L,112L,115L,118L,120L,121L,124L,127L,133L,136L,139L,141L,142L,145L,148L,150L,151L,154L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200088Inst : IEnumerable<long>
{
public static readonly long[] Value=A200088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200088.Bytes);
public long this[int i]=>Value[i];

public static A200088Inst Instance=new A200088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200089
{
public static readonly long[] Value={ 1L,4L,3L,8L,6L,9L,2L,9L,4L,3L,2L,8L,8L,2L,2L,6L,4L,4L,3L,9L,2L,8L,2L,5L,3L,6L,9L,6L,2L,0L,3L,7L,4L,9L,1L,4L,2L,8L,5L,1L,7L,2L,3L,1L,9L,3L,7L,9L,6L,1L,0L,8L,4L,4L,0L,4L,3L,6L,3L,4L,1L,6L,9L,7L,3L,2L,3L,4L,4L,5L,6L,2L,6L,6L,2L,8L,4L,1L,1L,4L,1L,2L,4L,8L,2L,0L,5L,7L,1L,7L,3L,8L,1L,6L,7L,0L,8L,8L,3L,1L,3L,8L,5L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200089Inst : IEnumerable<long>
{
public static readonly long[] Value=A200089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200089.Bytes);
public long this[int i]=>Value[i];

public static A200089Inst Instance=new A200089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200090
{
public static readonly long[] Value={ 15015L,45045L,51051L,62985L,72930L,74613L,75075L,105105L,106590L,135135L,145860L,153153L,156009L,165165L,187473L,188955L,190190L,195195L,213180L,218790L,222870L,223839L,225225L,279565L,291720L,314925L,315315L,319770L,335478L,357357L,364650L,375375L,380380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200090Inst : IEnumerable<long>
{
public static readonly long[] Value=A200090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200090.Bytes);
public long this[int i]=>Value[i];

public static A200090Inst Instance=new A200090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200091
{
public static readonly long[] Value={ 1L,1L,1L,6L,1L,20L,1L,50L,90L,1L,112L,630L,1L,238L,2940L,2520L,1L,492L,11508L,30240L,1L,1002L,40950L,226800L,113400L,1L,2024L,137610L,1367520L,2079000L,1L,4070L,445896L,7271880L,22869000L,7484400L,1L,8164L,1410552L,35692800L,196396200L,194594400L,1L,16354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200091Inst : IEnumerable<long>
{
public static readonly long[] Value=A200091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200091.Bytes);
public long this[int i]=>Value[i];

public static A200091Inst Instance=new A200091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200092
{
public static readonly long[] Value={ 1L,1L,1L,1L,20L,1L,70L,1L,182L,1L,420L,1680L,1L,912L,12600L,1L,1914L,62370L,1L,3938L,256410L,369600L,1L,8008L,949806L,4804800L,1L,16172L,3297294L,38678640L,1L,32526L,10966956L,248047800L,168168000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200092Inst : IEnumerable<long>
{
public static readonly long[] Value=A200092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200092.Bytes);
public long this[int i]=>Value[i];

public static A200092Inst Instance=new A200092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200093
{
public static readonly long[] Value={ 8L,0L,2L,9L,9L,2L,1L,5L,4L,2L,9L,7L,8L,8L,4L,2L,5L,0L,7L,2L,0L,3L,3L,5L,4L,5L,3L,4L,7L,4L,8L,7L,1L,2L,7L,4L,2L,9L,2L,1L,4L,1L,3L,5L,7L,7L,0L,0L,7L,2L,7L,7L,8L,3L,0L,6L,5L,8L,5L,4L,6L,2L,3L,2L,9L,7L,3L,5L,2L,1L,2L,9L,9L,1L,4L,3L,9L,4L,2L,5L,5L,9L,3L,6L,6L,4L,9L,4L,1L,0L,6L,9L,9L,2L,0L,4L,1L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200093Inst : IEnumerable<long>
{
public static readonly long[] Value=A200093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200093.Bytes);
public long this[int i]=>Value[i];

public static A200093Inst Instance=new A200093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200094
{
public static readonly long[] Value={ 1L,4L,9L,2L,6L,6L,5L,9L,2L,3L,5L,2L,5L,1L,3L,2L,2L,0L,6L,9L,6L,9L,2L,4L,3L,0L,5L,9L,8L,3L,4L,9L,3L,6L,8L,6L,1L,2L,4L,0L,4L,8L,8L,9L,5L,6L,1L,6L,3L,5L,6L,4L,3L,2L,6L,8L,3L,4L,4L,8L,4L,7L,9L,6L,0L,6L,9L,1L,2L,4L,2L,5L,9L,1L,7L,2L,9L,7L,0L,3L,5L,3L,3L,6L,8L,4L,1L,3L,1L,4L,1L,0L,3L,0L,8L,7L,9L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200094Inst : IEnumerable<long>
{
public static readonly long[] Value=A200094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200094.Bytes);
public long this[int i]=>Value[i];

public static A200094Inst Instance=new A200094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200095
{
public static readonly long[] Value={ 6L,7L,7L,1L,1L,9L,4L,1L,1L,6L,9L,7L,9L,4L,3L,1L,3L,0L,1L,8L,4L,1L,7L,9L,5L,2L,0L,0L,9L,8L,9L,1L,7L,0L,2L,1L,5L,5L,6L,6L,4L,5L,5L,5L,2L,5L,3L,3L,6L,9L,3L,2L,4L,4L,3L,7L,6L,9L,1L,1L,5L,4L,0L,1L,8L,3L,5L,0L,3L,8L,3L,8L,7L,6L,2L,7L,8L,4L,0L,3L,8L,9L,9L,8L,9L,8L,2L,7L,3L,9L,2L,3L,4L,8L,4L,8L,2L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200095Inst : IEnumerable<long>
{
public static readonly long[] Value=A200095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200095.Bytes);
public long this[int i]=>Value[i];

public static A200095Inst Instance=new A200095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200096
{
public static readonly long[] Value={ 1L,6L,5L,4L,6L,9L,9L,7L,8L,2L,2L,9L,3L,9L,0L,1L,0L,7L,1L,1L,3L,1L,6L,8L,6L,6L,8L,1L,8L,3L,0L,8L,0L,0L,6L,3L,5L,4L,6L,5L,9L,6L,8L,5L,5L,6L,7L,0L,3L,5L,0L,6L,3L,0L,7L,5L,3L,8L,7L,7L,2L,4L,0L,1L,0L,7L,0L,3L,8L,7L,2L,6L,4L,8L,7L,7L,0L,4L,0L,0L,3L,7L,8L,7L,1L,8L,7L,6L,8L,5L,2L,5L,7L,6L,2L,3L,7L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200096Inst : IEnumerable<long>
{
public static readonly long[] Value=A200096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200096.Bytes);
public long this[int i]=>Value[i];

public static A200096Inst Instance=new A200096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200097
{
public static readonly long[] Value={ 5L,7L,6L,8L,9L,1L,1L,7L,6L,9L,6L,2L,1L,8L,6L,4L,3L,5L,7L,5L,2L,4L,3L,6L,5L,9L,7L,7L,1L,8L,2L,6L,1L,6L,8L,8L,1L,3L,0L,0L,1L,4L,9L,2L,6L,4L,9L,3L,8L,9L,4L,3L,7L,3L,7L,0L,9L,4L,4L,4L,3L,6L,3L,0L,1L,9L,9L,8L,0L,5L,6L,2L,7L,8L,9L,7L,6L,0L,4L,1L,7L,0L,4L,0L,7L,2L,5L,0L,1L,3L,7L,5L,2L,3L,3L,7L,1L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200097Inst : IEnumerable<long>
{
public static readonly long[] Value=A200097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200097.Bytes);
public long this[int i]=>Value[i];

public static A200097Inst Instance=new A200097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200098
{
public static readonly long[] Value={ 1L,7L,9L,6L,4L,6L,7L,4L,1L,8L,6L,3L,5L,0L,0L,8L,4L,2L,7L,0L,7L,8L,8L,5L,2L,3L,6L,6L,1L,4L,9L,4L,9L,0L,9L,3L,7L,7L,3L,8L,6L,0L,8L,3L,6L,2L,1L,3L,7L,1L,9L,9L,8L,4L,1L,8L,1L,9L,2L,1L,5L,3L,1L,6L,9L,4L,3L,4L,1L,7L,4L,7L,5L,9L,0L,5L,3L,9L,8L,9L,7L,9L,9L,3L,1L,0L,0L,7L,7L,3L,9L,4L,9L,0L,9L,4L,3L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200098Inst : IEnumerable<long>
{
public static readonly long[] Value=A200098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200098.Bytes);
public long this[int i]=>Value[i];

public static A200098Inst Instance=new A200098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200099
{
public static readonly long[] Value={ 1L,0L,5L,3L,3L,5L,2L,9L,8L,3L,6L,0L,0L,1L,5L,3L,7L,3L,3L,2L,8L,1L,1L,1L,0L,1L,5L,7L,9L,9L,9L,4L,6L,8L,4L,6L,4L,9L,7L,0L,2L,8L,5L,2L,7L,9L,2L,2L,5L,9L,2L,3L,5L,3L,4L,2L,2L,3L,2L,3L,5L,1L,9L,8L,5L,0L,7L,9L,9L,4L,3L,8L,1L,7L,4L,0L,4L,9L,1L,8L,0L,3L,9L,2L,4L,8L,9L,8L,6L,2L,2L,7L,8L,6L,5L,8L,5L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200099Inst : IEnumerable<long>
{
public static readonly long[] Value=A200099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200099.Bytes);
public long this[int i]=>Value[i];

public static A200099Inst Instance=new A200099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200100
{
public static readonly long[] Value={ 1L,3L,5L,4L,5L,7L,5L,5L,5L,8L,2L,1L,5L,8L,5L,7L,8L,4L,4L,9L,0L,8L,9L,0L,7L,7L,0L,1L,6L,4L,6L,4L,6L,3L,7L,1L,8L,8L,1L,7L,4L,5L,1L,3L,4L,2L,1L,0L,6L,2L,6L,4L,5L,6L,2L,3L,4L,1L,1L,1L,6L,9L,6L,7L,0L,1L,4L,2L,1L,3L,1L,9L,1L,6L,3L,0L,2L,2L,8L,8L,3L,3L,1L,9L,0L,4L,0L,2L,9L,8L,1L,8L,3L,5L,3L,7L,7L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200100Inst : IEnumerable<long>
{
public static readonly long[] Value=A200100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200100.Bytes);
public long this[int i]=>Value[i];

public static A200100Inst Instance=new A200100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200101
{
public static readonly long[] Value={ 9L,1L,7L,7L,0L,1L,3L,1L,5L,8L,3L,1L,6L,0L,0L,4L,7L,5L,1L,7L,0L,5L,2L,4L,3L,9L,0L,9L,5L,3L,9L,2L,1L,4L,8L,7L,7L,1L,8L,1L,9L,6L,1L,1L,6L,8L,5L,9L,0L,0L,5L,7L,1L,1L,5L,1L,0L,0L,4L,8L,9L,0L,0L,2L,2L,4L,8L,9L,4L,4L,8L,7L,9L,0L,0L,7L,1L,1L,5L,4L,2L,2L,3L,0L,2L,3L,3L,9L,9L,7L,4L,4L,0L,5L,8L,6L,8L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200101Inst : IEnumerable<long>
{
public static readonly long[] Value=A200101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200101.Bytes);
public long this[int i]=>Value[i];

public static A200101Inst Instance=new A200101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200102
{
public static readonly long[] Value={ 1L,5L,0L,4L,0L,7L,4L,3L,6L,5L,6L,0L,3L,9L,0L,8L,4L,5L,6L,2L,5L,7L,7L,0L,9L,6L,8L,1L,3L,1L,2L,5L,9L,7L,2L,7L,8L,5L,5L,0L,0L,6L,5L,6L,0L,9L,3L,9L,5L,9L,0L,8L,3L,2L,2L,3L,4L,0L,3L,8L,1L,1L,2L,3L,9L,7L,6L,0L,1L,6L,5L,6L,2L,7L,5L,7L,6L,0L,1L,4L,0L,7L,0L,4L,0L,8L,6L,7L,1L,7L,2L,8L,3L,5L,5L,4L,8L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200102Inst : IEnumerable<long>
{
public static readonly long[] Value=A200102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200102.Bytes);
public long this[int i]=>Value[i];

public static A200102Inst Instance=new A200102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200103
{
public static readonly long[] Value={ 7L,9L,9L,2L,0L,0L,8L,1L,6L,8L,9L,5L,0L,9L,7L,0L,0L,5L,9L,4L,4L,4L,6L,0L,0L,6L,9L,2L,3L,2L,1L,1L,0L,1L,0L,4L,1L,2L,5L,1L,2L,1L,2L,6L,7L,1L,1L,1L,6L,1L,4L,3L,6L,3L,7L,8L,0L,2L,0L,8L,4L,8L,6L,9L,4L,0L,5L,8L,0L,2L,7L,0L,8L,4L,8L,0L,7L,3L,4L,1L,6L,4L,1L,1L,8L,9L,1L,8L,7L,8L,2L,4L,3L,0L,4L,5L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200103Inst : IEnumerable<long>
{
public static readonly long[] Value=A200103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200103.Bytes);
public long this[int i]=>Value[i];

public static A200103Inst Instance=new A200103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200104
{
public static readonly long[] Value={ 1L,6L,4L,3L,5L,5L,6L,5L,6L,7L,5L,2L,0L,1L,7L,1L,6L,5L,6L,9L,0L,6L,5L,2L,4L,7L,6L,1L,6L,3L,4L,8L,8L,8L,1L,6L,9L,4L,6L,0L,7L,4L,9L,2L,9L,7L,7L,5L,1L,3L,9L,1L,4L,8L,5L,7L,2L,0L,1L,3L,8L,1L,5L,2L,2L,6L,2L,9L,4L,3L,3L,5L,9L,0L,4L,2L,1L,6L,1L,2L,9L,4L,5L,5L,9L,5L,8L,9L,8L,4L,0L,0L,3L,6L,4L,1L,3L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200104Inst : IEnumerable<long>
{
public static readonly long[] Value=A200104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200104.Bytes);
public long this[int i]=>Value[i];

public static A200104Inst Instance=new A200104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200105
{
public static readonly long[] Value={ 6L,9L,8L,9L,3L,3L,6L,0L,4L,7L,3L,2L,9L,0L,3L,3L,0L,9L,3L,3L,7L,9L,8L,9L,5L,4L,4L,7L,3L,3L,5L,6L,7L,9L,5L,6L,2L,3L,3L,5L,7L,2L,4L,8L,5L,1L,5L,7L,6L,1L,0L,5L,7L,8L,0L,2L,5L,6L,9L,3L,4L,7L,2L,6L,5L,4L,9L,7L,8L,8L,3L,8L,4L,7L,5L,3L,2L,4L,6L,6L,6L,4L,5L,4L,3L,4L,0L,8L,3L,2L,6L,4L,0L,4L,9L,2L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200105Inst : IEnumerable<long>
{
public static readonly long[] Value=A200105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200105.Bytes);
public long this[int i]=>Value[i];

public static A200105Inst Instance=new A200105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200106
{
public static readonly long[] Value={ 1L,7L,6L,9L,5L,6L,8L,8L,7L,4L,3L,7L,2L,7L,0L,1L,7L,4L,9L,1L,1L,5L,0L,7L,8L,4L,6L,2L,0L,0L,1L,6L,2L,7L,7L,5L,4L,7L,6L,5L,5L,5L,3L,4L,1L,0L,5L,3L,8L,0L,6L,4L,0L,4L,0L,5L,3L,9L,9L,1L,8L,7L,9L,8L,4L,0L,5L,9L,5L,2L,4L,5L,4L,0L,9L,7L,9L,4L,2L,2L,5L,4L,4L,0L,2L,3L,5L,1L,2L,0L,1L,4L,4L,1L,5L,7L,7L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200106Inst : IEnumerable<long>
{
public static readonly long[] Value=A200106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200106.Bytes);
public long this[int i]=>Value[i];

public static A200106Inst Instance=new A200106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200107
{
public static readonly long[] Value={ 4L,6L,9L,0L,3L,2L,3L,7L,1L,1L,1L,9L,8L,0L,9L,3L,0L,5L,7L,3L,3L,5L,4L,9L,3L,0L,5L,8L,0L,2L,5L,1L,0L,5L,0L,0L,5L,5L,0L,0L,5L,6L,3L,6L,9L,5L,9L,3L,8L,3L,0L,6L,6L,8L,7L,3L,2L,8L,8L,7L,0L,4L,1L,8L,4L,8L,2L,6L,3L,8L,4L,1L,7L,4L,6L,1L,1L,2L,1L,2L,9L,0L,7L,6L,5L,5L,5L,2L,5L,1L,2L,6L,4L,8L,8L,2L,9L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200107Inst : IEnumerable<long>
{
public static readonly long[] Value=A200107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200107.Bytes);
public long this[int i]=>Value[i];

public static A200107Inst Instance=new A200107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200108
{
public static readonly long[] Value={ 8L,4L,0L,2L,6L,3L,5L,1L,7L,7L,1L,5L,7L,6L,7L,8L,9L,9L,3L,4L,7L,9L,7L,3L,4L,9L,9L,6L,4L,8L,3L,5L,5L,7L,9L,7L,3L,6L,5L,0L,2L,5L,3L,9L,0L,5L,3L,5L,1L,5L,2L,6L,6L,1L,1L,7L,3L,5L,4L,3L,6L,3L,9L,2L,5L,1L,7L,4L,5L,5L,5L,6L,5L,3L,6L,2L,5L,0L,2L,1L,5L,6L,7L,8L,0L,3L,5L,1L,8L,3L,7L,2L,4L,6L,3L,0L,2L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200108Inst : IEnumerable<long>
{
public static readonly long[] Value=A200108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200108.Bytes);
public long this[int i]=>Value[i];

public static A200108Inst Instance=new A200108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200109
{
public static readonly long[] Value={ 3L,5L,2L,3L,6L,5L,0L,0L,5L,7L,7L,7L,3L,2L,6L,4L,5L,3L,1L,0L,2L,8L,6L,6L,1L,9L,5L,3L,5L,9L,9L,9L,6L,8L,1L,0L,8L,6L,8L,5L,9L,0L,3L,3L,1L,2L,4L,3L,7L,1L,6L,9L,7L,9L,3L,6L,0L,2L,5L,2L,5L,0L,3L,8L,5L,6L,6L,5L,7L,4L,5L,4L,2L,5L,4L,0L,3L,3L,6L,7L,0L,3L,7L,7L,7L,9L,1L,1L,0L,6L,1L,4L,3L,6L,9L,5L,9L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200109Inst : IEnumerable<long>
{
public static readonly long[] Value=A200109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200109.Bytes);
public long this[int i]=>Value[i];

public static A200109Inst Instance=new A200109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200110
{
public static readonly long[] Value={ 1L,0L,5L,6L,6L,9L,8L,3L,7L,6L,9L,4L,2L,8L,7L,8L,1L,2L,2L,1L,9L,2L,4L,0L,8L,3L,0L,3L,1L,1L,7L,5L,2L,5L,0L,9L,3L,5L,5L,7L,1L,3L,6L,8L,6L,5L,0L,9L,1L,9L,3L,5L,0L,7L,4L,4L,3L,8L,6L,6L,4L,9L,4L,2L,8L,0L,6L,9L,8L,4L,2L,7L,3L,3L,0L,3L,3L,7L,1L,5L,8L,8L,7L,0L,0L,9L,2L,6L,3L,1L,0L,0L,5L,0L,4L,1L,4L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200110Inst : IEnumerable<long>
{
public static readonly long[] Value=A200110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200110.Bytes);
public long this[int i]=>Value[i];

public static A200110Inst Instance=new A200110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200111
{
public static readonly long[] Value={ 2L,7L,4L,1L,8L,5L,9L,2L,8L,0L,5L,9L,8L,3L,1L,5L,7L,9L,0L,1L,2L,9L,3L,8L,5L,7L,6L,1L,6L,5L,9L,2L,6L,1L,0L,6L,7L,1L,9L,3L,4L,6L,4L,4L,2L,6L,5L,9L,6L,6L,3L,7L,1L,8L,4L,8L,3L,7L,3L,1L,3L,2L,8L,7L,6L,3L,4L,5L,8L,4L,4L,1L,6L,6L,5L,1L,5L,9L,0L,3L,6L,8L,1L,0L,1L,8L,6L,6L,3L,2L,2L,3L,7L,2L,6L,9L,8L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200111Inst : IEnumerable<long>
{
public static readonly long[] Value=A200111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200111.Bytes);
public long this[int i]=>Value[i];

public static A200111Inst Instance=new A200111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200112
{
public static readonly long[] Value={ 1L,2L,5L,7L,4L,1L,1L,4L,2L,9L,4L,9L,4L,7L,5L,9L,2L,5L,6L,0L,2L,2L,3L,7L,3L,0L,9L,8L,1L,4L,8L,0L,3L,8L,9L,5L,2L,5L,2L,1L,6L,0L,2L,4L,9L,3L,6L,7L,8L,6L,4L,7L,2L,8L,0L,1L,2L,9L,2L,2L,8L,1L,6L,3L,4L,8L,6L,2L,7L,9L,2L,8L,1L,1L,1L,6L,5L,0L,3L,7L,3L,9L,5L,0L,0L,0L,0L,0L,8L,8L,4L,9L,9L,4L,8L,5L,4L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200112Inst : IEnumerable<long>
{
public static readonly long[] Value=A200112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200112.Bytes);
public long this[int i]=>Value[i];

public static A200112Inst Instance=new A200112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200113
{
public static readonly long[] Value={ 4L,1L,9L,5L,2L,9L,9L,2L,3L,6L,1L,3L,8L,0L,8L,9L,2L,4L,2L,5L,2L,7L,8L,6L,7L,3L,1L,3L,4L,4L,1L,3L,4L,9L,6L,9L,9L,5L,5L,6L,6L,2L,8L,1L,4L,2L,3L,8L,7L,4L,0L,0L,7L,5L,0L,7L,4L,1L,1L,5L,0L,0L,5L,6L,4L,7L,5L,0L,2L,4L,3L,0L,7L,4L,1L,5L,4L,5L,1L,8L,7L,5L,7L,3L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200113Inst : IEnumerable<long>
{
public static readonly long[] Value=A200113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200113.Bytes);
public long this[int i]=>Value[i];

public static A200113Inst Instance=new A200113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200114
{
public static readonly long[] Value={ 2L,2L,1L,2L,3L,4L,7L,1L,6L,8L,5L,6L,5L,5L,0L,8L,4L,5L,9L,2L,8L,7L,5L,1L,6L,1L,4L,5L,6L,5L,1L,7L,9L,1L,5L,6L,6L,1L,6L,0L,0L,1L,8L,4L,8L,1L,0L,3L,7L,5L,1L,2L,2L,6L,1L,0L,9L,7L,5L,6L,4L,8L,7L,2L,2L,1L,3L,6L,8L,0L,3L,2L,0L,7L,6L,1L,3L,9L,5L,9L,6L,8L,0L,3L,8L,5L,5L,3L,6L,8L,5L,1L,5L,0L,2L,9L,7L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200114Inst : IEnumerable<long>
{
public static readonly long[] Value=A200114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200114.Bytes);
public long this[int i]=>Value[i];

public static A200114Inst Instance=new A200114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200115
{
public static readonly long[] Value={ 1L,4L,3L,1L,7L,7L,8L,7L,3L,2L,6L,8L,7L,2L,3L,1L,1L,3L,1L,8L,2L,0L,5L,9L,1L,7L,9L,9L,7L,0L,0L,5L,5L,8L,8L,4L,3L,9L,2L,4L,1L,9L,0L,4L,9L,6L,6L,1L,7L,0L,4L,2L,0L,0L,6L,6L,7L,9L,9L,9L,3L,2L,1L,8L,9L,6L,2L,3L,2L,9L,2L,4L,0L,8L,7L,8L,6L,0L,2L,1L,8L,6L,9L,6L,7L,5L,3L,0L,7L,9L,3L,7L,2L,9L,1L,1L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200115Inst : IEnumerable<long>
{
public static readonly long[] Value=A200115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200115.Bytes);
public long this[int i]=>Value[i];

public static A200115Inst Instance=new A200115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200116
{
public static readonly long[] Value={ 6L,8L,0L,3L,2L,6L,4L,1L,4L,1L,3L,8L,6L,7L,9L,2L,9L,6L,2L,3L,9L,6L,3L,1L,6L,2L,0L,7L,3L,6L,4L,1L,9L,1L,7L,6L,8L,6L,5L,5L,3L,0L,2L,5L,8L,0L,2L,1L,0L,8L,1L,4L,5L,3L,5L,6L,0L,8L,0L,7L,7L,9L,5L,9L,8L,9L,2L,6L,3L,3L,9L,2L,2L,7L,0L,8L,1L,5L,4L,8L,2L,0L,3L,7L,7L,9L,1L,0L,0L,2L,2L,0L,1L,2L,5L,7L,6L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200116Inst : IEnumerable<long>
{
public static readonly long[] Value=A200116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200116.Bytes);
public long this[int i]=>Value[i];

public static A200116Inst Instance=new A200116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200117
{
public static readonly long[] Value={ 9L,8L,4L,7L,1L,2L,6L,9L,9L,3L,6L,3L,0L,6L,7L,3L,5L,2L,4L,9L,9L,1L,3L,8L,0L,0L,9L,0L,7L,4L,8L,4L,5L,5L,2L,4L,3L,2L,3L,5L,0L,7L,8L,9L,3L,1L,1L,5L,1L,0L,5L,9L,5L,6L,0L,4L,9L,2L,5L,3L,6L,5L,5L,6L,9L,1L,3L,4L,7L,6L,9L,8L,2L,7L,3L,6L,3L,5L,2L,6L,1L,9L,1L,6L,0L,4L,3L,4L,8L,3L,7L,0L,8L,5L,6L,3L,0L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200117Inst : IEnumerable<long>
{
public static readonly long[] Value=A200117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200117.Bytes);
public long this[int i]=>Value[i];

public static A200117Inst Instance=new A200117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200118
{
public static readonly long[] Value={ 4L,6L,6L,8L,2L,3L,6L,0L,7L,5L,7L,0L,9L,8L,6L,7L,9L,9L,5L,8L,4L,1L,3L,4L,1L,5L,4L,4L,3L,1L,5L,8L,4L,0L,4L,7L,4L,2L,6L,6L,6L,6L,7L,3L,0L,0L,8L,1L,8L,1L,8L,7L,7L,3L,4L,2L,9L,0L,2L,0L,5L,1L,2L,5L,7L,8L,4L,0L,2L,8L,8L,6L,8L,6L,8L,7L,4L,3L,9L,5L,5L,4L,5L,2L,5L,8L,6L,5L,8L,6L,8L,7L,7L,2L,6L,3L,1L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200118Inst : IEnumerable<long>
{
public static readonly long[] Value=A200118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200118.Bytes);
public long this[int i]=>Value[i];

public static A200118Inst Instance=new A200118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200119
{
public static readonly long[] Value={ 1L,3L,0L,7L,1L,9L,0L,9L,9L,2L,0L,7L,3L,8L,1L,3L,0L,6L,6L,4L,0L,4L,6L,3L,4L,1L,8L,6L,6L,5L,4L,5L,6L,0L,4L,5L,6L,2L,8L,2L,6L,0L,4L,5L,6L,8L,3L,5L,4L,3L,0L,5L,8L,9L,0L,4L,7L,6L,7L,6L,9L,5L,2L,8L,0L,0L,3L,8L,9L,7L,8L,8L,2L,5L,4L,6L,1L,4L,1L,9L,7L,9L,5L,3L,1L,9L,0L,8L,2L,0L,8L,7L,8L,9L,7L,6L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200119Inst : IEnumerable<long>
{
public static readonly long[] Value=A200119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200119.Bytes);
public long this[int i]=>Value[i];

public static A200119Inst Instance=new A200119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200120
{
public static readonly long[] Value={ 8L,1L,5L,2L,3L,3L,2L,2L,3L,4L,1L,0L,5L,1L,4L,1L,3L,1L,2L,0L,5L,9L,2L,1L,2L,0L,0L,0L,2L,2L,2L,2L,0L,9L,7L,0L,3L,0L,0L,7L,3L,1L,1L,5L,4L,3L,9L,1L,2L,1L,5L,4L,0L,2L,0L,2L,5L,7L,2L,7L,1L,6L,8L,7L,7L,0L,1L,3L,5L,7L,9L,2L,2L,8L,9L,8L,8L,1L,8L,1L,7L,6L,1L,0L,0L,3L,9L,4L,0L,2L,9L,3L,5L,5L,6L,3L,0L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200120Inst : IEnumerable<long>
{
public static readonly long[] Value=A200120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200120.Bytes);
public long this[int i]=>Value[i];

public static A200120Inst Instance=new A200120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200121
{
public static readonly long[] Value={ 1L,0L,7L,4L,3L,0L,9L,2L,0L,6L,5L,0L,6L,0L,4L,6L,8L,9L,0L,1L,0L,8L,3L,5L,7L,7L,7L,8L,9L,2L,8L,6L,3L,0L,6L,3L,4L,2L,8L,6L,1L,7L,0L,7L,8L,6L,8L,2L,3L,6L,6L,6L,0L,5L,3L,6L,8L,9L,9L,5L,0L,4L,9L,9L,8L,3L,8L,8L,0L,3L,8L,0L,7L,6L,1L,3L,0L,6L,5L,9L,0L,0L,0L,8L,8L,4L,2L,5L,8L,8L,9L,8L,3L,5L,2L,6L,5L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200121Inst : IEnumerable<long>
{
public static readonly long[] Value=A200121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200121.Bytes);
public long this[int i]=>Value[i];

public static A200121Inst Instance=new A200121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200122
{
public static readonly long[] Value={ 7L,0L,4L,1L,5L,9L,4L,5L,7L,0L,3L,7L,1L,2L,2L,5L,5L,2L,6L,8L,1L,0L,5L,8L,3L,3L,3L,4L,9L,9L,4L,8L,3L,4L,8L,2L,1L,0L,8L,4L,3L,1L,6L,2L,4L,3L,5L,8L,1L,8L,1L,8L,9L,5L,8L,7L,2L,3L,4L,8L,6L,8L,3L,2L,0L,2L,1L,0L,3L,1L,9L,1L,2L,5L,1L,0L,3L,4L,6L,4L,2L,0L,1L,2L,0L,4L,1L,8L,7L,0L,2L,4L,7L,1L,3L,4L,6L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200122Inst : IEnumerable<long>
{
public static readonly long[] Value=A200122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200122.Bytes);
public long this[int i]=>Value[i];

public static A200122Inst Instance=new A200122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200123
{
public static readonly long[] Value={ 1L,2L,1L,0L,3L,0L,1L,1L,0L,2L,1L,5L,6L,0L,5L,7L,8L,5L,9L,1L,9L,2L,8L,4L,4L,2L,4L,6L,7L,5L,9L,4L,3L,4L,7L,8L,0L,3L,8L,1L,4L,9L,4L,7L,5L,5L,4L,4L,3L,5L,2L,6L,5L,4L,1L,2L,5L,5L,9L,4L,7L,5L,6L,4L,0L,2L,5L,1L,2L,6L,1L,3L,0L,6L,7L,4L,9L,2L,0L,3L,2L,8L,7L,4L,6L,6L,2L,1L,4L,2L,7L,4L,1L,2L,6L,4L,8L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200123Inst : IEnumerable<long>
{
public static readonly long[] Value=A200123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200123.Bytes);
public long this[int i]=>Value[i];

public static A200123Inst Instance=new A200123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200124
{
public static readonly long[] Value={ 6L,0L,9L,4L,1L,6L,8L,3L,3L,2L,6L,3L,2L,7L,5L,2L,9L,9L,9L,3L,0L,7L,5L,3L,5L,9L,9L,3L,1L,6L,0L,5L,4L,8L,2L,2L,7L,8L,5L,2L,3L,3L,0L,3L,0L,5L,9L,3L,5L,8L,3L,5L,5L,5L,9L,6L,0L,5L,1L,3L,3L,4L,7L,1L,7L,8L,1L,7L,1L,9L,6L,0L,4L,8L,7L,5L,2L,6L,3L,9L,0L,1L,3L,4L,2L,5L,3L,7L,1L,3L,4L,8L,5L,4L,4L,5L,6L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200124Inst : IEnumerable<long>
{
public static readonly long[] Value=A200124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200124.Bytes);
public long this[int i]=>Value[i];

public static A200124Inst Instance=new A200124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200125
{
public static readonly long[] Value={ 1L,3L,4L,2L,0L,4L,0L,5L,3L,4L,2L,4L,0L,7L,5L,7L,7L,6L,6L,1L,1L,9L,8L,0L,1L,0L,5L,0L,8L,1L,8L,2L,3L,8L,9L,7L,1L,5L,9L,4L,9L,8L,2L,7L,1L,6L,0L,4L,4L,0L,1L,0L,4L,7L,2L,7L,2L,0L,7L,8L,0L,9L,4L,5L,4L,1L,7L,3L,8L,6L,6L,9L,8L,0L,8L,6L,7L,8L,7L,4L,1L,4L,5L,7L,1L,3L,9L,4L,4L,1L,3L,4L,0L,8L,7L,5L,0L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200125Inst : IEnumerable<long>
{
public static readonly long[] Value=A200125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200125.Bytes);
public long this[int i]=>Value[i];

public static A200125Inst Instance=new A200125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200126
{
public static readonly long[] Value={ 5L,3L,0L,6L,3L,3L,0L,4L,7L,4L,9L,6L,8L,4L,8L,8L,8L,0L,1L,6L,6L,8L,0L,4L,1L,7L,5L,6L,7L,1L,0L,6L,4L,1L,0L,0L,2L,8L,1L,6L,1L,9L,5L,6L,3L,6L,8L,5L,3L,5L,6L,4L,4L,6L,1L,4L,8L,4L,3L,4L,2L,1L,2L,0L,9L,6L,5L,7L,3L,0L,5L,4L,4L,1L,6L,7L,8L,8L,8L,3L,6L,3L,9L,5L,4L,1L,6L,4L,1L,4L,1L,5L,8L,8L,6L,7L,2L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200126Inst : IEnumerable<long>
{
public static readonly long[] Value=A200126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200126.Bytes);
public long this[int i]=>Value[i];

public static A200126Inst Instance=new A200126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200127
{
public static readonly long[] Value={ 1L,4L,6L,5L,2L,3L,5L,3L,8L,6L,1L,4L,2L,6L,3L,1L,8L,5L,6L,9L,4L,5L,9L,2L,6L,8L,3L,0L,5L,7L,2L,6L,9L,4L,9L,2L,6L,9L,0L,0L,7L,8L,8L,8L,6L,2L,5L,1L,9L,6L,6L,4L,6L,8L,7L,8L,7L,8L,3L,9L,7L,1L,6L,8L,3L,1L,4L,1L,7L,3L,5L,2L,9L,3L,5L,6L,5L,7L,7L,2L,4L,5L,6L,1L,7L,8L,8L,7L,7L,2L,4L,7L,3L,1L,0L,3L,9L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200127Inst : IEnumerable<long>
{
public static readonly long[] Value=A200127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200127.Bytes);
public long this[int i]=>Value[i];

public static A200127Inst Instance=new A200127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200128
{
public static readonly long[] Value={ 9L,1L,1L,2L,5L,1L,3L,6L,5L,7L,7L,2L,4L,8L,2L,4L,1L,2L,5L,4L,9L,4L,7L,3L,1L,8L,2L,8L,0L,2L,9L,3L,7L,5L,4L,5L,8L,5L,3L,9L,1L,6L,1L,5L,9L,8L,2L,1L,2L,5L,4L,4L,8L,1L,0L,6L,1L,2L,1L,6L,3L,7L,4L,6L,8L,9L,5L,1L,8L,0L,7L,4L,2L,6L,6L,7L,5L,7L,8L,7L,6L,4L,4L,3L,4L,7L,9L,9L,8L,2L,9L,9L,5L,5L,9L,6L,9L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200128Inst : IEnumerable<long>
{
public static readonly long[] Value=A200128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200128.Bytes);
public long this[int i]=>Value[i];

public static A200128Inst Instance=new A200128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200129
{
public static readonly long[] Value={ 1L,1L,3L,7L,4L,0L,1L,1L,9L,9L,5L,2L,6L,8L,6L,8L,5L,2L,6L,5L,0L,2L,7L,8L,8L,0L,3L,0L,8L,4L,2L,5L,4L,4L,8L,8L,0L,5L,3L,0L,2L,1L,1L,9L,6L,5L,1L,5L,2L,5L,1L,3L,6L,5L,2L,7L,2L,9L,1L,7L,5L,8L,7L,9L,5L,2L,0L,9L,9L,5L,9L,6L,1L,9L,0L,2L,0L,3L,1L,5L,1L,9L,0L,1L,7L,9L,8L,3L,6L,9L,7L,0L,1L,2L,9L,6L,8L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200129Inst : IEnumerable<long>
{
public static readonly long[] Value=A200129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200129.Bytes);
public long this[int i]=>Value[i];

public static A200129Inst Instance=new A200129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200130
{
public static readonly long[] Value={ 7L,1L,9L,0L,0L,5L,0L,6L,4L,5L,5L,8L,8L,4L,2L,9L,2L,7L,8L,5L,9L,2L,7L,1L,7L,8L,0L,8L,4L,8L,1L,7L,9L,3L,8L,2L,5L,0L,1L,8L,8L,0L,5L,3L,7L,6L,4L,8L,4L,5L,9L,1L,3L,3L,2L,1L,2L,0L,0L,9L,5L,6L,6L,5L,6L,9L,8L,1L,1L,8L,6L,6L,8L,2L,2L,3L,9L,7L,3L,4L,6L,3L,5L,2L,1L,2L,0L,8L,0L,3L,0L,7L,4L,9L,1L,1L,9L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200130Inst : IEnumerable<long>
{
public static readonly long[] Value=A200130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200130.Bytes);
public long this[int i]=>Value[i];

public static A200130Inst Instance=new A200130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200131
{
public static readonly long[] Value={ 1L,3L,6L,8L,1L,4L,9L,1L,1L,2L,0L,4L,2L,0L,6L,7L,6L,6L,7L,9L,9L,7L,6L,9L,9L,1L,0L,8L,8L,9L,0L,6L,9L,2L,6L,6L,7L,5L,9L,0L,3L,6L,3L,8L,6L,9L,7L,9L,8L,2L,3L,5L,6L,8L,8L,7L,6L,8L,3L,8L,1L,0L,1L,7L,8L,4L,0L,2L,0L,0L,9L,5L,7L,2L,9L,5L,6L,3L,9L,7L,4L,8L,1L,6L,1L,3L,1L,7L,9L,1L,3L,4L,2L,8L,1L,1L,0L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200131Inst : IEnumerable<long>
{
public static readonly long[] Value=A200131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200131.Bytes);
public long this[int i]=>Value[i];

public static A200131Inst Instance=new A200131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200132
{
public static readonly long[] Value={ 4L,1L,3L,7L,5L,1L,7L,5L,9L,1L,4L,4L,7L,7L,3L,9L,3L,7L,6L,8L,4L,4L,0L,0L,2L,7L,9L,8L,9L,8L,9L,2L,7L,5L,6L,4L,5L,9L,9L,2L,2L,5L,1L,3L,8L,5L,5L,5L,7L,8L,6L,6L,1L,8L,6L,3L,7L,5L,1L,5L,2L,8L,7L,7L,7L,8L,7L,6L,3L,1L,5L,3L,2L,0L,3L,3L,8L,4L,9L,9L,6L,1L,7L,4L,1L,5L,9L,0L,0L,6L,9L,1L,1L,8L,7L,6L,2L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200132Inst : IEnumerable<long>
{
public static readonly long[] Value=A200132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200132.Bytes);
public long this[int i]=>Value[i];

public static A200132Inst Instance=new A200132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200133
{
public static readonly long[] Value={ 6L,8L,4L,8L,5L,3L,0L,7L,8L,6L,2L,3L,2L,0L,1L,1L,5L,9L,5L,6L,3L,6L,9L,4L,4L,6L,8L,6L,4L,9L,5L,4L,2L,8L,8L,8L,4L,5L,1L,8L,4L,2L,6L,1L,0L,3L,1L,8L,2L,0L,2L,6L,7L,1L,9L,2L,8L,2L,6L,1L,9L,9L,7L,6L,4L,6L,0L,2L,2L,5L,8L,4L,0L,3L,1L,2L,9L,4L,4L,3L,2L,7L,9L,2L,2L,5L,9L,2L,5L,2L,4L,0L,4L,6L,8L,1L,0L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200133Inst : IEnumerable<long>
{
public static readonly long[] Value=A200133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200133.Bytes);
public long this[int i]=>Value[i];

public static A200133Inst Instance=new A200133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200134
{
public static readonly long[] Value={ 1L,0L,8L,5L,8L,6L,0L,8L,7L,9L,7L,8L,6L,4L,7L,2L,1L,6L,9L,6L,2L,6L,8L,8L,6L,7L,6L,2L,8L,1L,7L,1L,8L,0L,6L,9L,3L,1L,7L,0L,0L,7L,5L,0L,3L,9L,3L,3L,3L,1L,3L,6L,4L,5L,0L,6L,8L,0L,3L,3L,4L,9L,6L,7L,2L,1L,1L,1L,4L,0L,3L,8L,9L,5L,4L,3L,6L,4L,4L,3L,1L,8L,4L,4L,0L,5L,1L,9L,6L,3L,1L,6L,0L,9L,9L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200134Inst : IEnumerable<long>
{
public static readonly long[] Value=A200134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200134.Bytes);
public long this[int i]=>Value[i];

public static A200134Inst Instance=new A200134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200135
{
public static readonly long[] Value={ 5L,2L,8L,9L,0L,3L,9L,8L,9L,6L,5L,9L,2L,1L,8L,8L,2L,9L,5L,5L,4L,7L,2L,0L,7L,9L,6L,2L,4L,4L,9L,9L,5L,2L,1L,0L,4L,8L,2L,5L,5L,8L,8L,2L,7L,4L,2L,0L,6L,6L,4L,2L,8L,1L,0L,1L,7L,5L,8L,5L,8L,6L,6L,4L,1L,9L,1L,6L,2L,4L,7L,5L,4L,0L,9L,1L,6L,1L,9L,6L,5L,2L,5L,4L,6L,5L,7L,7L,8L,2L,4L,3L,1L,9L,5L,7L,0L,3L,6L,2L,4L,1L,2L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200135Inst : IEnumerable<long>
{
public static readonly long[] Value=A200135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200135.Bytes);
public long this[int i]=>Value[i];

public static A200135Inst Instance=new A200135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200136
{
public static readonly long[] Value={ 2L,5L,6L,1L,3L,8L,4L,5L,4L,4L,5L,8L,5L,1L,1L,6L,1L,4L,5L,7L,3L,0L,6L,7L,5L,4L,8L,2L,0L,4L,7L,5L,2L,8L,4L,5L,5L,8L,2L,6L,3L,6L,1L,0L,9L,6L,5L,1L,0L,8L,1L,0L,1L,5L,7L,2L,3L,3L,9L,5L,3L,6L,7L,5L,2L,1L,2L,6L,1L,1L,0L,4L,2L,9L,3L,0L,5L,4L,1L,3L,8L,3L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200136Inst : IEnumerable<long>
{
public static readonly long[] Value=A200136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200136.Bytes);
public long this[int i]=>Value[i];

public static A200136Inst Instance=new A200136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200137
{
public static readonly long[] Value={ 1L,5L,4L,0L,6L,1L,9L,2L,1L,3L,8L,9L,3L,1L,9L,0L,4L,1L,4L,7L,6L,0L,6L,6L,3L,9L,4L,8L,8L,0L,6L,2L,3L,1L,9L,4L,1L,5L,1L,0L,5L,3L,4L,2L,5L,4L,6L,8L,9L,6L,0L,7L,2L,0L,8L,2L,6L,6L,6L,8L,5L,2L,6L,3L,2L,6L,1L,1L,6L,8L,8L,4L,1L,2L,4L,1L,1L,0L,2L,4L,6L,6L,0L,7L,3L,3L,4L,2L,4L,6L,7L,7L,1L,9L,7L,7L,8L,8L,2L,0L,1L,0L,0L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200137Inst : IEnumerable<long>
{
public static readonly long[] Value=A200137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200137.Bytes);
public long this[int i]=>Value[i];

public static A200137Inst Instance=new A200137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200138
{
public static readonly long[] Value={ 9L,6L,5L,0L,0L,8L,5L,6L,6L,7L,0L,6L,1L,3L,8L,4L,5L,9L,3L,9L,1L,2L,9L,7L,6L,3L,3L,1L,5L,6L,8L,3L,5L,4L,1L,9L,6L,3L,4L,1L,6L,0L,4L,8L,9L,6L,9L,5L,2L,2L,2L,8L,2L,9L,1L,0L,9L,8L,1L,0L,7L,9L,4L,2L,4L,4L,9L,6L,1L,2L,0L,7L,3L,8L,5L,6L,8L,4L,0L,0L,4L,3L,0L,6L,3L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200138Inst : IEnumerable<long>
{
public static readonly long[] Value=A200138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200138.Bytes);
public long this[int i]=>Value[i];

public static A200138Inst Instance=new A200138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200139
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,4L,8L,5L,1L,8L,20L,18L,7L,1L,16L,48L,56L,32L,9L,1L,32L,112L,160L,120L,50L,11L,1L,64L,256L,432L,400L,220L,72L,13L,1L,128L,576L,1120L,1232L,840L,364L,98L,15L,1L,256L,1280L,2816L,3584L,2912L,1568L,560L,128L,17L,1L,512L,2816L,6912L,9984L,9408L,6048L,2688L,816L,162L,19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200139Inst : IEnumerable<long>
{
public static readonly long[] Value=A200139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200139.Bytes);
public long this[int i]=>Value[i];

public static A200139Inst Instance=new A200139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200140
{
public static readonly BigInteger[] Value={ 1L,7L,-54L,827L,-14012L,259898L,-5116318L,105172355L,-2234053248L,48692954312L,-1083547583038L,24527041757402L,-563187320485774L,13089954727844002L,-307442412559624318L,7286803572075349907L,BigInteger.Parse("-174090195438541310248"),BigInteger.Parse("4188665368980014572652"),BigInteger.Parse("-101416065009218889929998"),BigInteger.Parse("2469364164437930871076352") };
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
public class A200140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200140Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200140.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A200140.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200140Inst Instance=new A200140Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200141
{
public static readonly long[] Value={ 1L,1L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200141Inst : IEnumerable<long>
{
public static readonly long[] Value=A200141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200141.Bytes);
public long this[int i]=>Value[i];

public static A200141Inst Instance=new A200141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200142
{
public static readonly BigInteger[] Value={ 3L,30L,315L,3780L,51975L,810810L,14189175L,275675400L,5892561675L,137493105750L,3478575575475L,94870242967500L,2774954606799375L,86663966950811250L,2878481759437659375L,BigInteger.Parse("101322557932205610000"),BigInteger.Parse("3767932623103896121875"),BigInteger.Parse("147614301587482048068750") };
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
public class A200142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200142Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200142.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A200142.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200142Inst Instance=new A200142Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200143
{
public static readonly long[] Value={ 5L,7L,11L,13L,23L,47L,61L,83L,131L,191L,211L,223L,241L,317L,331L,397L,467L,479L,491L,503L,509L,563L,577L,613L,727L,743L,757L,829L,887L,907L,941L,947L,997L,1009L,1021L,1039L,1069L,1087L,1097L,1109L,1223L,1229L,1237L,1381L,1399L,1423L,1447L,1523L,1543L,1549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200143Inst : IEnumerable<long>
{
public static readonly long[] Value=A200143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200143.Bytes);
public long this[int i]=>Value[i];

public static A200143Inst Instance=new A200143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200144
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,7L,14L,17L,27L,34L,55L,64L,100L,121L,167L,213L,296L,354L,489L,594L,776L,964L,1254L,1511L,1951L,2378L,2986L,3643L,4564L,5483L,6841L,8245L,10099L,12190L,14862L,17783L,21636L,25849L,31184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200144Inst : IEnumerable<long>
{
public static readonly long[] Value=A200144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200144.Bytes);
public long this[int i]=>Value[i];

public static A200144Inst Instance=new A200144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200145
{
public static readonly long[] Value={ 2145L,2730L,4641L,4845L,5005L,5610L,7410L,8778L,9177L,11305L,11730L,13485L,13585L,17017L,20010L,20930L,21489L,21505L,23529L,26445L,29946L,31465L,31857L,32538L,33649L,34410L,35409L,35581L,36685L,38570L,38874L,41106L,42441L,43401L,45066L,46189L,46345L,47730L,49569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200145Inst : IEnumerable<long>
{
public static readonly long[] Value=A200145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200145.Bytes);
public long this[int i]=>Value[i];

public static A200145Inst Instance=new A200145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200146
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,3L,1L,1L,1L,1L,1L,2L,3L,4L,5L,1L,1L,1L,1L,1L,1L,1L,0L,3L,0L,5L,0L,7L,1L,4L,0L,7L,7L,0L,4L,1L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,8L,3L,4L,5L,0L,7L,8L,9L,4L,11L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200146Inst : IEnumerable<long>
{
public static readonly long[] Value=A200146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200146.Bytes);
public long this[int i]=>Value[i];

public static A200146Inst Instance=new A200146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200147
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,8L,2L,16L,6L,32L,2L,64L,2L,144L,14L,256L,2L,512L,2L,1024L,6L,2048L,2L,4096L,50L,8192L,6L,16384L,2L,34816L,2L,66176L,6L,147456L,130L,262168L,2L,524288L,38L,1048576L,2L,2127872L,2L,4194304L,134L,8388608L,2L,17825792L,4098L,33554432L,6L,67108864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200147Inst : IEnumerable<long>
{
public static readonly long[] Value=A200147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200147.Bytes);
public long this[int i]=>Value[i];

public static A200147Inst Instance=new A200147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200148
{
public static readonly long[] Value={ 1L,3L,5L,9L,15L,39L,45L,129L,149L,243L,369L,1365L,2061L,5901L,5951L,7785L,10519L,42519L,59473L,213561L,157559L,278835L,503513L,1553481L,1051639L,2491707L,2981747L,6622209L,10056593L,34139241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200148Inst : IEnumerable<long>
{
public static readonly long[] Value=A200148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200148.Bytes);
public long this[int i]=>Value[i];

public static A200148Inst Instance=new A200148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200149
{
public static readonly long[] Value={ 1L,4L,8L,22L,40L,112L,182L,688L,844L,2090L,2478L,21056L,20762L,112864L,113870L,204796L,141246L,2255872L,1610768L,18946704L,15066098L,20640826L,12378248L,332333696L,279217826L,531539936L,618937930L,1715570198L,330283576L,20131457680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200149Inst : IEnumerable<long>
{
public static readonly long[] Value=A200149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200149.Bytes);
public long this[int i]=>Value[i];

public static A200149Inst Instance=new A200149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200150
{
public static readonly long[] Value={ 1L,5L,13L,41L,103L,275L,685L,2525L,5221L,13897L,32717L,176145L,321963L,1390895L,2223445L,3845743L,10539177L,76756525L,147653093L,808935605L,934179307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200150Inst : IEnumerable<long>
{
public static readonly long[] Value=A200150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200150.Bytes);
public long this[int i]=>Value[i];

public static A200150Inst Instance=new A200150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200151
{
public static readonly long[] Value={ 1L,6L,18L,66L,202L,730L,2036L,7488L,19262L,62772L,190408L,1077600L,2185196L,12081408L,21927244L,52980770L,148851716L,1353060240L,2585159746L,16942421808L,28793485330L,51092435876L,106822624510L,1565885020128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200151Inst : IEnumerable<long>
{
public static readonly long[] Value=A200151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200151.Bytes);
public long this[int i]=>Value[i];

public static A200151Inst Instance=new A200151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200152
{
public static readonly long[] Value={ 1L,7L,25L,107L,381L,1589L,5153L,18809L,68813L,256859L,883247L,4997167L,12448095L,76804553L,181129817L,522024177L,1884097881L,16163873397L,38888615377L,239811969005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200152Inst : IEnumerable<long>
{
public static readonly long[] Value=A200152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200152.Bytes);
public long this[int i]=>Value[i];

public static A200152Inst Instance=new A200152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200153
{
public static readonly long[] Value={ 1L,8L,32L,158L,636L,3000L,11370L,52166L,194818L,841122L,3338446L,18901856L,57842348L,378064896L,1073497924L,3840517750L,15453709184L,133757694784L,361144763380L,2500726090816L,6776168788838L,17399866594576L,65044240487692L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200153Inst : IEnumerable<long>
{
public static readonly long[] Value=A200153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200153.Bytes);
public long this[int i]=>Value[i];

public static A200153Inst Instance=new A200153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200154
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,1L,4L,5L,4L,1L,5L,8L,9L,2L,1L,6L,13L,22L,15L,8L,1L,7L,18L,41L,40L,39L,2L,1L,8L,25L,66L,103L,112L,45L,16L,1L,9L,32L,107L,202L,275L,182L,129L,6L,1L,10L,41L,158L,381L,730L,685L,688L,149L,32L,1L,11L,50L,219L,636L,1589L,2036L,2525L,844L,243L,2L,1L,12L,61L,304L,1033L,3000L,5153L,7488L,5221L,2090L,369L,64L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200154Inst : IEnumerable<long>
{
public static readonly long[] Value=A200154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200154.Bytes);
public long this[int i]=>Value[i];

public static A200154Inst Instance=new A200154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200155
{
public static readonly long[] Value={ 4L,9L,22L,41L,66L,107L,158L,219L,304L,403L,516L,661L,824L,1005L,1226L,1469L,1734L,2047L,2386L,2751L,3172L,3623L,4104L,4649L,5228L,5841L,6526L,7249L,8010L,8851L,9734L,10659L,11672L,12731L,13836L,15037L,16288L,17589L,18994L,20453L,21966L,23591L,25274L,27015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200155Inst : IEnumerable<long>
{
public static readonly long[] Value=A200155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200155.Bytes);
public long this[int i]=>Value[i];

public static A200155Inst Instance=new A200155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200156
{
public static readonly long[] Value={ 2L,15L,40L,103L,202L,381L,636L,1033L,1550L,2287L,3212L,4451L,5946L,7869L,10140L,12969L,16238L,20211L,24744L,30147L,36222L,43349L,51296L,60493L,70646L,82267L,95016L,109467L,125206L,142897L,162076L,183477L,206546L,232123L,259596L,289879L,322262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200156Inst : IEnumerable<long>
{
public static readonly long[] Value=A200156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200156.Bytes);
public long this[int i]=>Value[i];

public static A200156Inst Instance=new A200156Inst();

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