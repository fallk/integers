using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A161005
{
public static readonly long[] Value={ 504L,2394L,5544L,10584L,12600L,21600L,26880L,35712L,129948L,134087L,140760L,155834L,176363L,222750L,245520L,263970L,283974L,321906L,348128L,357184L,382092L,405876L,589160L,675958L,755008L,829994L,892800L,955206L,1017792L,1048320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161005Inst : IEnumerable<long>
{
public static readonly long[] Value=A161005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161005.Bytes);
public long this[int i]=>Value[i];

public static A161005Inst Instance=new A161005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161006
{
public static readonly long[] Value={ 1L,1L,3L,6L,18L,49L,155L,486L,1614L,5414L,18630L,64828L,228740L,814485L,2926323L,10588486L,38561814L,141214570L,519711666L,1921126036L,7129756188L,26555090618L,99228108222L,371886366620L,1397548389644L,5265130603468L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161006Inst : IEnumerable<long>
{
public static readonly long[] Value=A161006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161006.Bytes);
public long this[int i]=>Value[i];

public static A161006Inst Instance=new A161006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161007
{
public static readonly long[] Value={ 0L,1L,2L,20L,72L,464L,2080L,11584L,56448L,298240L,1499648L,7771136L,39536640L,203411456L,1039409152L,5333401600L,27297349632L,139929124864L,716615843840L,3672097685504L,18810048872448L,96373660712960L,493708103385088L,2529394778177536L,12958119210516480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161007Inst : IEnumerable<long>
{
public static readonly long[] Value=A161007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161007.Bytes);
public long this[int i]=>Value[i];

public static A161007Inst Instance=new A161007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161008
{
public static readonly long[] Value={ 5939831L,5939833L,5939839L,5939849L,5939863L,5939881L,5939903L,5939929L,5939959L,5939993L,5940169L,5940223L,5940343L,5940479L,5940553L,5940799L,5940889L,5940983L,5941081L,5941289L,5941399L,5942009L,5942569L,5942719L,5942873L,5943031L,5943193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161008Inst : IEnumerable<long>
{
public static readonly long[] Value=A161008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161008.Bytes);
public long this[int i]=>Value[i];

public static A161008Inst Instance=new A161008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161009
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,1L,7L,7L,3L,1L,18L,20L,12L,4L,1L,48L,59L,40L,18L,5L,1L,132L,174L,132L,68L,25L,6L,1L,372L,517L,426L,247L,105L,33L,7L,1L,1069L,1548L,1362L,864L,415L,152L,42L,8L,1L,3121L,4670L,4332L,2956L,1561L,648L,210L,52L,9L,1L,9232L,14188L,13746L,9960L,5685L,2604L,959L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161009Inst : IEnumerable<long>
{
public static readonly long[] Value=A161009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161009.Bytes);
public long this[int i]=>Value[i];

public static A161009Inst Instance=new A161009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161010
{
public static readonly long[] Value={ 1L,8191L,797161L,33550336L,305175781L,6529545751L,16148168401L,137422176256L,423644039001L,2499694822171L,3452271214393L,26745019396096L,25239592216021L,132269647372591L,243274230757741L,562881233944576L,619036127056621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161010Inst : IEnumerable<long>
{
public static readonly long[] Value=A161010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161010.Bytes);
public long this[int i]=>Value[i];

public static A161010Inst Instance=new A161010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161011
{
public static readonly long[] Value={ 5L,4L,6L,3L,0L,2L,4L,8L,9L,8L,4L,3L,7L,9L,0L,5L,1L,3L,2L,5L,5L,1L,7L,9L,4L,6L,5L,7L,8L,0L,2L,8L,5L,3L,8L,3L,2L,9L,7L,5L,5L,1L,7L,2L,0L,1L,7L,9L,7L,9L,1L,2L,4L,6L,1L,6L,4L,0L,9L,1L,3L,8L,5L,9L,3L,2L,9L,0L,7L,5L,1L,0L,5L,1L,8L,0L,2L,5L,8L,1L,5L,7L,1L,5L,1L,8L,0L,6L,4L,8L,2L,7L,0L,6L,5L,6L,2L,1L,8L,5L,8L,9L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161011Inst : IEnumerable<long>
{
public static readonly long[] Value=A161011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161011.Bytes);
public long this[int i]=>Value[i];

public static A161011Inst Instance=new A161011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161012
{
public static readonly long[] Value={ 3L,4L,6L,2L,5L,3L,5L,4L,9L,5L,1L,0L,5L,7L,5L,4L,9L,1L,0L,3L,8L,5L,4L,3L,5L,6L,5L,6L,0L,9L,7L,4L,0L,7L,7L,4L,5L,9L,5L,7L,0L,3L,9L,1L,6L,1L,8L,9L,8L,0L,0L,2L,1L,7L,9L,7L,6L,4L,4L,4L,0L,6L,4L,8L,9L,8L,5L,9L,7L,6L,5L,7L,4L,9L,1L,5L,4L,7L,5L,5L,2L,8L,1L,5L,9L,6L,5L,7L,8L,7L,0L,0L,9L,3L,9L,7L,2L,6L,6L,9L,0L,5L,0L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161012Inst : IEnumerable<long>
{
public static readonly long[] Value=A161012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161012.Bytes);
public long this[int i]=>Value[i];

public static A161012Inst Instance=new A161012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161013
{
public static readonly long[] Value={ 2L,5L,5L,3L,4L,1L,9L,2L,1L,2L,2L,1L,0L,3L,6L,2L,6L,6L,5L,0L,4L,4L,8L,2L,2L,3L,6L,4L,9L,0L,4L,7L,3L,6L,7L,8L,2L,0L,4L,2L,0L,1L,6L,3L,8L,8L,0L,0L,8L,2L,2L,6L,2L,1L,7L,4L,0L,4L,7L,5L,6L,5L,0L,2L,5L,8L,8L,8L,3L,1L,9L,8L,1L,3L,4L,6L,5L,4L,2L,5L,7L,9L,4L,9L,3L,1L,6L,5L,0L,2L,6L,3L,1L,0L,5L,5L,0L,4L,5L,3L,9L,6L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161013Inst : IEnumerable<long>
{
public static readonly long[] Value=A161013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161013.Bytes);
public long this[int i]=>Value[i];

public static A161013Inst Instance=new A161013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161014
{
public static readonly long[] Value={ 2L,0L,2L,7L,1L,0L,0L,3L,5L,5L,0L,8L,6L,7L,2L,4L,8L,3L,3L,2L,1L,3L,5L,8L,2L,7L,1L,6L,4L,7L,5L,3L,4L,4L,8L,2L,6L,2L,6L,8L,7L,5L,6L,6L,9L,6L,5L,1L,6L,3L,1L,3L,3L,0L,0L,4L,7L,8L,1L,9L,9L,6L,6L,8L,9L,0L,3L,8L,2L,1L,8L,5L,0L,0L,1L,9L,9L,9L,7L,0L,0L,0L,9L,1L,1L,7L,3L,9L,0L,0L,8L,9L,2L,6L,2L,1L,4L,4L,2L,7L,2L,3L,0L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161014Inst : IEnumerable<long>
{
public static readonly long[] Value=A161014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161014.Bytes);
public long this[int i]=>Value[i];

public static A161014Inst Instance=new A161014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161015
{
public static readonly long[] Value={ 1L,6L,8L,2L,2L,7L,2L,1L,8L,3L,0L,2L,2L,4L,2L,4L,6L,1L,2L,5L,7L,2L,1L,6L,0L,8L,0L,5L,6L,9L,9L,1L,6L,1L,0L,0L,9L,6L,9L,3L,9L,3L,6L,5L,1L,6L,8L,5L,0L,5L,6L,6L,8L,5L,7L,2L,4L,0L,3L,2L,7L,3L,9L,2L,4L,8L,2L,4L,7L,4L,3L,8L,7L,0L,8L,5L,3L,1L,6L,1L,6L,3L,2L,7L,9L,4L,4L,9L,8L,1L,3L,5L,1L,8L,3L,5L,7L,3L,0L,3L,9L,2L,8L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161015Inst : IEnumerable<long>
{
public static readonly long[] Value=A161015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161015.Bytes);
public long this[int i]=>Value[i];

public static A161015Inst Instance=new A161015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161016
{
public static readonly long[] Value={ 1L,4L,3L,8L,3L,6L,9L,5L,9L,4L,3L,6L,1L,9L,0L,9L,3L,5L,2L,8L,0L,0L,3L,0L,5L,9L,9L,1L,3L,5L,6L,2L,3L,3L,4L,4L,9L,8L,7L,5L,6L,8L,1L,6L,9L,6L,7L,3L,8L,8L,8L,5L,3L,9L,3L,3L,0L,8L,7L,1L,0L,0L,1L,6L,5L,3L,1L,8L,6L,4L,4L,4L,9L,9L,4L,6L,1L,4L,5L,3L,6L,3L,4L,8L,4L,9L,8L,7L,3L,6L,8L,3L,9L,2L,6L,8L,2L,6L,8L,4L,3L,9L,5L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161016Inst : IEnumerable<long>
{
public static readonly long[] Value=A161016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161016.Bytes);
public long this[int i]=>Value[i];

public static A161016Inst Instance=new A161016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161017
{
public static readonly long[] Value={ 1L,2L,5L,6L,5L,5L,1L,3L,6L,5L,7L,5L,1L,3L,0L,9L,6L,7L,7L,9L,2L,6L,7L,8L,2L,1L,8L,6L,2L,9L,7L,7L,4L,0L,0L,0L,7L,5L,8L,6L,6L,5L,7L,6L,3L,8L,9L,2L,2L,2L,5L,5L,4L,2L,6L,6L,8L,8L,6L,6L,6L,1L,3L,9L,2L,7L,2L,5L,5L,7L,0L,3L,4L,8L,0L,9L,2L,8L,8L,7L,1L,4L,7L,5L,8L,4L,1L,6L,6L,4L,9L,0L,8L,1L,9L,4L,9L,4L,5L,2L,1L,4L,4L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161017Inst : IEnumerable<long>
{
public static readonly long[] Value=A161017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161017.Bytes);
public long this[int i]=>Value[i];

public static A161017Inst Instance=new A161017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161018
{
public static readonly long[] Value={ 1L,1L,1L,5L,7L,0L,6L,2L,7L,8L,3L,3L,8L,0L,0L,5L,8L,3L,7L,2L,6L,5L,0L,4L,8L,0L,0L,2L,4L,9L,8L,2L,9L,4L,6L,4L,5L,0L,2L,5L,4L,9L,2L,3L,4L,1L,2L,7L,7L,4L,0L,0L,7L,3L,1L,1L,1L,7L,6L,8L,4L,7L,2L,5L,0L,7L,6L,3L,7L,2L,3L,9L,4L,8L,2L,2L,3L,5L,8L,5L,2L,3L,5L,7L,9L,4L,1L,4L,5L,7L,4L,1L,1L,0L,6L,6L,1L,3L,2L,8L,4L,0L,7L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161018Inst : IEnumerable<long>
{
public static readonly long[] Value=A161018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161018.Bytes);
public long this[int i]=>Value[i];

public static A161018Inst Instance=new A161018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161019
{
public static readonly long[] Value={ 1L,0L,0L,3L,3L,4L,6L,7L,2L,0L,8L,5L,4L,5L,0L,5L,4L,5L,0L,5L,8L,0L,8L,0L,0L,4L,5L,7L,8L,1L,1L,1L,1L,5L,3L,6L,8L,1L,9L,0L,0L,4L,8L,0L,4L,5L,7L,6L,4L,4L,2L,0L,4L,0L,0L,2L,2L,2L,0L,8L,0L,6L,5L,7L,9L,8L,0L,3L,2L,1L,1L,2L,8L,8L,5L,6L,7L,3L,8L,7L,0L,3L,4L,7L,9L,3L,0L,4L,8L,0L,3L,4L,8L,7L,3L,0L,9L,1L,4L,6L,0L,5L,8L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161019Inst : IEnumerable<long>
{
public static readonly long[] Value=A161019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161019.Bytes);
public long this[int i]=>Value[i];

public static A161019Inst Instance=new A161019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161020
{
public static readonly long[] Value={ 370L,407L,481L,518L,592L,629L,370370L,407407L,481481L,518518L,592592L,629629L,370370370L,407407407L,456790123L,469135802L,481481481L,493827160L,506172839L,518518518L,530864197L,543209876L,592592592L,629629629L,370370370370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161020Inst : IEnumerable<long>
{
public static readonly long[] Value=A161020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161020.Bytes);
public long this[int i]=>Value[i];

public static A161020Inst Instance=new A161020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161021
{
public static readonly long[] Value={ 703L,2110L,1055L,3166L,1583L,4750L,2375L,7126L,3563L,10690L,5345L,16036L,8018L,4009L,12028L,6014L,3007L,9022L,4511L,13534L,6767L,20302L,10151L,30454L,15227L,45682L,22841L,68524L,34262L,17131L,51394L,25697L,77092L,38546L,19273L,57820L,28910L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161021Inst : IEnumerable<long>
{
public static readonly long[] Value=A161021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161021.Bytes);
public long this[int i]=>Value[i];

public static A161021Inst Instance=new A161021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161022
{
public static readonly long[] Value={ 10087L,30262L,15131L,45394L,22697L,68092L,34046L,17023L,51070L,25535L,76606L,38303L,114910L,57455L,172366L,86183L,258550L,129275L,387826L,193913L,581740L,290870L,145435L,436306L,218153L,654460L,327230L,163615L,490846L,245423L,736270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161022Inst : IEnumerable<long>
{
public static readonly long[] Value=A161022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161022.Bytes);
public long this[int i]=>Value[i];

public static A161022Inst Instance=new A161022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161023
{
public static readonly long[] Value={ 35655L,106966L,53483L,160450L,80225L,240676L,120338L,60169L,180508L,90254L,45127L,135382L,67691L,203074L,101537L,304612L,152306L,76153L,228460L,114230L,57115L,171346L,85673L,257020L,128510L,64255L,192766L,96383L,289150L,144575L,433726L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161023Inst : IEnumerable<long>
{
public static readonly long[] Value=A161023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161023.Bytes);
public long this[int i]=>Value[i];

public static A161023Inst Instance=new A161023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161024
{
public static readonly long[] Value={ 8191L,33542145L,2176512520L,68694312960L,499938962796L,8912818769400L,18895663909200L,140685952942080L,385562663380440L,2047250052649620L,2570686683371352L,18253452839731200L,15902884603186140L,77377743708174000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161024Inst : IEnumerable<long>
{
public static readonly long[] Value=A161024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161024.Bytes);
public long this[int i]=>Value[i];

public static A161024Inst Instance=new A161024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161025
{
public static readonly long[] Value={ 1L,16383L,2391484L,134209536L,1525878906L,39179682372L,113037178808L,1099444518912L,3812797945332L,24998474116998L,37974983358324L,320959957991424L,328114698808274L,1851888100411464L,3649114989636504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161025Inst : IEnumerable<long>
{
public static readonly long[] Value=A161025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161025.Bytes);
public long this[int i]=>Value[i];

public static A161025Inst Instance=new A161025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161026
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,4L,2L,5L,5L,8L,6L,12L,10L,15L,16L,22L,20L,30L,30L,38L,40L,51L,51L,67L,69L,84L,88L,108L,111L,136L,141L,168L,176L,209L,218L,256L,267L,310L,328L,376L,396L,454L,477L,541L,575L,644L,681L,767L,809L,902L,959L,1061L,1121L,1246L,1316L,1448L,1537L,1687L,1781L,1956L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161026Inst : IEnumerable<long>
{
public static readonly long[] Value=A161026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161026.Bytes);
public long this[int i]=>Value[i];

public static A161026Inst Instance=new A161026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161027
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,1L,2L,3L,3L,3L,6L,5L,6L,10L,8L,9L,14L,13L,16L,20L,19L,23L,30L,30L,33L,41L,43L,48L,59L,58L,67L,78L,81L,92L,105L,109L,123L,140L,148L,160L,182L,193L,214L,238L,249L,275L,305L,322L,353L,386L,413L,447L,490L,520L,561L,611L,650L,701L,762L,804L,868L,938L,997L,1067L,1147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161027Inst : IEnumerable<long>
{
public static readonly long[] Value=A161027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161027.Bytes);
public long this[int i]=>Value[i];

public static A161027Inst Instance=new A161027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161028
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,1L,2L,1L,2L,1L,4L,2L,4L,4L,6L,5L,8L,7L,11L,9L,12L,11L,16L,16L,19L,19L,24L,24L,31L,29L,38L,37L,44L,47L,54L,57L,65L,68L,81L,80L,93L,95L,111L,116L,128L,136L,153L,158L,179L,184L,211L,216L,240L,253L,281L,294L,322L,337L,377L,388L,429L,445L,494L,515L,559L,587L,641L,669L,730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161028Inst : IEnumerable<long>
{
public static readonly long[] Value=A161028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161028.Bytes);
public long this[int i]=>Value[i];

public static A161028Inst Instance=new A161028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161029
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,3L,3L,3L,5L,4L,6L,7L,7L,8L,10L,11L,11L,13L,13L,14L,19L,18L,20L,23L,24L,29L,31L,33L,35L,40L,47L,47L,53L,56L,60L,72L,74L,79L,88L,92L,104L,109L,117L,124L,135L,149L,156L,167L,180L,188L,210L,220L,234L,252L,269L,290L,308L,325L,346L,369L,401L,420L,450L,476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161029Inst : IEnumerable<long>
{
public static readonly long[] Value=A161029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161029.Bytes);
public long this[int i]=>Value[i];

public static A161029Inst Instance=new A161029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161030
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,4L,2L,4L,4L,5L,4L,8L,6L,8L,9L,10L,9L,15L,11L,14L,15L,16L,16L,22L,19L,23L,25L,28L,28L,36L,33L,39L,42L,46L,47L,58L,55L,63L,68L,73L,76L,89L,89L,100L,106L,113L,118L,134L,134L,149L,157L,168L,174L,194L,196L,215L,226L,242L,251L,278L,282L,307L,323L,344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161030Inst : IEnumerable<long>
{
public static readonly long[] Value=A161030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161030.Bytes);
public long this[int i]=>Value[i];

public static A161030Inst Instance=new A161030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161031
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,3L,3L,3L,5L,4L,5L,6L,7L,7L,9L,9L,10L,11L,12L,14L,14L,15L,16L,17L,19L,19L,22L,23L,25L,28L,29L,32L,35L,38L,41L,44L,47L,51L,55L,59L,65L,68L,73L,79L,84L,90L,96L,104L,112L,118L,126L,133L,142L,151L,161L,170L,182L,190L,202L,212L,224L,237L,251L,264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161031Inst : IEnumerable<long>
{
public static readonly long[] Value=A161031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161031.Bytes);
public long this[int i]=>Value[i];

public static A161031Inst Instance=new A161031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161032
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,4L,2L,4L,4L,5L,4L,7L,5L,8L,8L,9L,9L,12L,10L,13L,13L,16L,14L,18L,16L,19L,20L,21L,20L,26L,24L,29L,29L,32L,33L,39L,39L,44L,45L,51L,51L,60L,59L,65L,69L,77L,78L,87L,88L,97L,102L,111L,113L,127L,130L,140L,148L,157L,162L,177L,182L,199L,204L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161032Inst : IEnumerable<long>
{
public static readonly long[] Value=A161032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161032.Bytes);
public long this[int i]=>Value[i];

public static A161032Inst Instance=new A161032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161033
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,3L,3L,3L,5L,4L,5L,6L,6L,6L,9L,8L,9L,11L,11L,11L,14L,13L,14L,18L,16L,17L,20L,19L,21L,23L,22L,23L,28L,28L,29L,33L,33L,36L,42L,41L,44L,50L,51L,56L,60L,62L,66L,73L,76L,79L,89L,90L,96L,106L,107L,115L,124L,128L,138L,147L,153L,161L,173L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161033Inst : IEnumerable<long>
{
public static readonly long[] Value=A161033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161033.Bytes);
public long this[int i]=>Value[i];

public static A161033Inst Instance=new A161033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161034
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,4L,2L,4L,4L,5L,4L,7L,5L,7L,7L,9L,8L,11L,10L,12L,12L,14L,13L,16L,15L,19L,17L,20L,19L,22L,22L,24L,23L,26L,25L,31L,29L,33L,33L,37L,39L,43L,43L,48L,49L,57L,56L,63L,63L,70L,74L,79L,81L,88L,90L,103L,102L,111L,114L,123L,130L,138L,142L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161034Inst : IEnumerable<long>
{
public static readonly long[] Value=A161034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161034.Bytes);
public long this[int i]=>Value[i];

public static A161034Inst Instance=new A161034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161035
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,3L,3L,3L,5L,4L,5L,6L,6L,6L,8L,7L,9L,10L,10L,11L,13L,12L,14L,15L,15L,16L,18L,19L,19L,21L,21L,22L,25L,24L,25L,27L,27L,29L,32L,32L,34L,37L,39L,41L,45L,46L,49L,54L,56L,60L,64L,67L,71L,77L,80L,84L,90L,94L,99L,106L,112L,116L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161035Inst : IEnumerable<long>
{
public static readonly long[] Value=A161035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161035.Bytes);
public long this[int i]=>Value[i];

public static A161035Inst Instance=new A161035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161036
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,4L,2L,4L,4L,5L,4L,7L,5L,7L,7L,8L,7L,11L,9L,11L,12L,13L,12L,16L,14L,16L,17L,18L,17L,23L,19L,22L,23L,24L,24L,28L,25L,28L,29L,31L,29L,36L,33L,37L,40L,41L,42L,49L,47L,53L,55L,59L,60L,69L,68L,74L,78L,83L,85L,95L,94L,102L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161036Inst : IEnumerable<long>
{
public static readonly long[] Value=A161036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161036.Bytes);
public long this[int i]=>Value[i];

public static A161036Inst Instance=new A161036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161037
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,3L,3L,3L,5L,4L,5L,6L,6L,6L,8L,7L,8L,9L,10L,10L,12L,12L,13L,14L,15L,15L,17L,17L,18L,19L,20L,22L,22L,23L,24L,25L,27L,27L,28L,29L,30L,32L,32L,33L,36L,37L,40L,41L,43L,46L,49L,52L,54L,57L,61L,64L,69L,72L,75L,81L,84L,90L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161037Inst : IEnumerable<long>
{
public static readonly long[] Value=A161037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161037.Bytes);
public long this[int i]=>Value[i];

public static A161037Inst Instance=new A161037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161038
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,4L,2L,4L,4L,5L,4L,7L,5L,7L,7L,8L,7L,10L,8L,11L,11L,12L,12L,15L,13L,16L,16L,17L,17L,20L,18L,21L,21L,24L,22L,26L,24L,27L,28L,29L,28L,32L,30L,34L,33L,35L,34L,40L,39L,42L,43L,46L,47L,54L,52L,57L,59L,64L,66L,72L,72L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161038Inst : IEnumerable<long>
{
public static readonly long[] Value=A161038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161038.Bytes);
public long this[int i]=>Value[i];

public static A161038Inst Instance=new A161038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161039
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,1L,1L,2L,1L,1L,3L,2L,2L,5L,3L,3L,6L,5L,6L,8L,6L,7L,11L,10L,9L,14L,13L,13L,19L,16L,18L,25L,22L,25L,32L,29L,31L,42L,41L,41L,53L,51L,54L,69L,64L,69L,88L,83L,89L,109L,105L,112L,136L,134L,141L,170L,166L,177L,215L,207L,219L,262L,260L,276L,320L,320L,341L,397L,397L,417L,485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161039Inst : IEnumerable<long>
{
public static readonly long[] Value=A161039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161039.Bytes);
public long this[int i]=>Value[i];

public static A161039Inst Instance=new A161039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161040
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,2L,3L,3L,4L,4L,4L,4L,6L,7L,6L,7L,8L,8L,10L,9L,11L,11L,12L,15L,15L,15L,15L,18L,22L,21L,24L,24L,27L,30L,31L,34L,37L,40L,43L,45L,50L,53L,58L,62L,66L,70L,73L,79L,91L,92L,97L,105L,112L,120L,126L,135L,143L,153L,166L,172L,187L,194L,207L,224L,235L,249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161040Inst : IEnumerable<long>
{
public static readonly long[] Value=A161040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161040.Bytes);
public long this[int i]=>Value[i];

public static A161040Inst Instance=new A161040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161041
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,2L,3L,2L,3L,4L,4L,4L,5L,4L,5L,8L,6L,7L,8L,7L,11L,10L,9L,10L,11L,14L,13L,15L,14L,14L,20L,17L,18L,21L,21L,26L,26L,25L,28L,31L,35L,36L,37L,38L,41L,50L,48L,51L,58L,56L,66L,68L,68L,74L,80L,89L,90L,98L,98L,104L,120L,117L,127L,136L,137L,154L,160L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161041Inst : IEnumerable<long>
{
public static readonly long[] Value=A161041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161041.Bytes);
public long this[int i]=>Value[i];

public static A161041Inst Instance=new A161041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161042
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,3L,2L,2L,4L,3L,3L,6L,4L,4L,6L,5L,6L,8L,7L,7L,9L,9L,9L,12L,10L,10L,13L,12L,12L,16L,15L,15L,18L,16L,17L,21L,20L,22L,24L,23L,24L,30L,28L,30L,37L,33L,35L,42L,40L,41L,49L,50L,50L,60L,58L,60L,67L,68L,73L,81L,81L,84L,95L,93L,99L,114L,110L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161042Inst : IEnumerable<long>
{
public static readonly long[] Value=A161042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161042.Bytes);
public long this[int i]=>Value[i];

public static A161042Inst Instance=new A161042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161043
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,5L,5L,5L,5L,6L,7L,6L,8L,8L,8L,10L,9L,10L,11L,12L,12L,12L,13L,13L,14L,15L,17L,17L,17L,18L,19L,19L,20L,24L,23L,24L,25L,26L,27L,29L,34L,33L,36L,37L,38L,40L,42L,48L,47L,51L,54L,56L,58L,61L,70L,69L,72L,77L,80L,84L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161043Inst : IEnumerable<long>
{
public static readonly long[] Value=A161043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161043.Bytes);
public long this[int i]=>Value[i];

public static A161043Inst Instance=new A161043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161044
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,3L,2L,3L,4L,3L,4L,5L,5L,5L,6L,5L,6L,8L,6L,7L,9L,8L,10L,10L,9L,11L,12L,12L,13L,13L,13L,14L,16L,14L,15L,18L,18L,19L,19L,19L,20L,22L,23L,22L,26L,25L,26L,29L,27L,30L,33L,33L,37L,38L,38L,41L,44L,45L,46L,50L,52L,55L,60L,59L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161044Inst : IEnumerable<long>
{
public static readonly long[] Value=A161044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161044.Bytes);
public long this[int i]=>Value[i];

public static A161044Inst Instance=new A161044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161045
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,3L,2L,2L,4L,3L,3L,5L,4L,4L,7L,5L,5L,7L,6L,7L,8L,7L,7L,10L,10L,9L,11L,10L,11L,14L,12L,12L,15L,14L,15L,16L,15L,15L,18L,19L,17L,21L,19L,20L,24L,21L,23L,24L,24L,26L,29L,27L,27L,32L,31L,32L,36L,34L,36L,44L,41L,42L,47L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161045Inst : IEnumerable<long>
{
public static readonly long[] Value=A161045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161045.Bytes);
public long this[int i]=>Value[i];

public static A161045Inst Instance=new A161045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161046
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,6L,6L,6L,6L,7L,8L,7L,8L,8L,8L,11L,10L,10L,11L,11L,13L,13L,13L,13L,14L,17L,15L,16L,16L,16L,19L,18L,19L,19L,19L,23L,22L,22L,23L,24L,26L,25L,26L,27L,27L,32L,31L,30L,32L,33L,37L,37L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161046Inst : IEnumerable<long>
{
public static readonly long[] Value=A161046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161046.Bytes);
public long this[int i]=>Value[i];

public static A161046Inst Instance=new A161046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161047
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,3L,2L,3L,4L,3L,4L,5L,4L,5L,6L,6L,6L,7L,6L,7L,9L,7L,8L,9L,8L,10L,11L,10L,11L,12L,12L,13L,14L,13L,14L,16L,15L,17L,17L,16L,18L,19L,18L,19L,21L,20L,21L,22L,23L,23L,25L,26L,25L,27L,26L,28L,30L,29L,31L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161047Inst : IEnumerable<long>
{
public static readonly long[] Value=A161047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161047.Bytes);
public long this[int i]=>Value[i];

public static A161047Inst Instance=new A161047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161048
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,3L,2L,2L,4L,3L,3L,5L,4L,4L,6L,5L,5L,8L,6L,6L,8L,7L,8L,9L,8L,8L,10L,10L,9L,12L,11L,11L,14L,12L,13L,15L,14L,15L,16L,16L,16L,19L,18L,17L,20L,19L,19L,22L,21L,21L,23L,22L,23L,26L,25L,26L,28L,27L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161048Inst : IEnumerable<long>
{
public static readonly long[] Value=A161048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161048.Bytes);
public long this[int i]=>Value[i];

public static A161048Inst Instance=new A161048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161049
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,7L,7L,7L,7L,8L,9L,8L,9L,9L,9L,11L,10L,10L,12L,12L,13L,13L,13L,14L,15L,16L,15L,16L,17L,17L,19L,19L,18L,20L,20L,21L,21L,21L,23L,23L,24L,23L,24L,25L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161049Inst : IEnumerable<long>
{
public static readonly long[] Value=A161049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161049.Bytes);
public long this[int i]=>Value[i];

public static A161049Inst Instance=new A161049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161050
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,3L,2L,3L,4L,3L,4L,5L,4L,5L,6L,5L,6L,7L,7L,7L,8L,7L,8L,10L,8L,9L,10L,9L,11L,11L,10L,11L,13L,13L,13L,14L,13L,15L,17L,15L,16L,17L,17L,19L,19L,18L,20L,21L,21L,21L,22L,21L,23L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161050Inst : IEnumerable<long>
{
public static readonly long[] Value=A161050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161050.Bytes);
public long this[int i]=>Value[i];

public static A161050Inst Instance=new A161050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161051
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,3L,2L,5L,3L,6L,5L,9L,6L,11L,9L,16L,11L,19L,16L,25L,19L,30L,25L,39L,30L,45L,39L,56L,45L,65L,56L,81L,65L,92L,81L,111L,92L,127L,111L,152L,127L,171L,152L,201L,171L,226L,201L,265L,226L,295L,265L,340L,295L,379L,340L,435L,379L,480L,435L,545L,480L,601L,545L,682L,601L,747L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161051Inst : IEnumerable<long>
{
public static readonly long[] Value=A161051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161051.Bytes);
public long this[int i]=>Value[i];

public static A161051Inst Instance=new A161051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161052
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,1L,2L,2L,3L,3L,5L,4L,5L,6L,8L,7L,9L,9L,12L,11L,14L,14L,19L,17L,21L,22L,27L,26L,32L,31L,39L,37L,44L,45L,54L,52L,61L,61L,73L,70L,81L,82L,96L,93L,107L,107L,126L,121L,138L,140L,161L,157L,179L,178L,205L,200L,226L,227L,259L,253L,284L,285L,324L,316L,353L,355L,399L,392L,437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161052Inst : IEnumerable<long>
{
public static readonly long[] Value=A161052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161052.Bytes);
public long this[int i]=>Value[i];

public static A161052Inst Instance=new A161052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161053
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,1L,2L,1L,2L,1L,3L,2L,4L,3L,6L,4L,6L,5L,9L,7L,9L,8L,13L,10L,13L,11L,18L,14L,19L,16L,26L,20L,27L,23L,35L,29L,38L,33L,48L,39L,51L,44L,62L,53L,68L,60L,82L,69L,87L,77L,103L,90L,111L,100L,131L,113L,138L,124L,161L,142L,172L,156L,201L,175L,211L,191L,244L,217L,260L,237L,299L,264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161053Inst : IEnumerable<long>
{
public static readonly long[] Value=A161053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161053.Bytes);
public long this[int i]=>Value[i];

public static A161053Inst Instance=new A161053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161054
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,3L,3L,4L,4L,6L,5L,6L,6L,8L,8L,9L,9L,11L,11L,13L,12L,15L,14L,17L,16L,20L,19L,23L,22L,28L,26L,31L,30L,36L,36L,42L,41L,49L,47L,55L,53L,62L,61L,70L,69L,80L,78L,89L,87L,100L,98L,110L,109L,124L,122L,136L,134L,151L,149L,165L,163L,183L,180L,199L,196L,219L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161054Inst : IEnumerable<long>
{
public static readonly long[] Value=A161054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161054.Bytes);
public long this[int i]=>Value[i];

public static A161054Inst Instance=new A161054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161055
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,3L,2L,4L,3L,5L,4L,7L,5L,7L,6L,9L,7L,10L,9L,12L,10L,13L,12L,16L,13L,17L,15L,20L,16L,22L,19L,26L,21L,29L,25L,35L,28L,38L,33L,44L,37L,50L,44L,58L,49L,63L,56L,72L,62L,80L,71L,90L,78L,98L,88L,110L,97L,121L,109L,135L,119L,145L,132L,161L,144L,175L,160L,193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161055Inst : IEnumerable<long>
{
public static readonly long[] Value=A161055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161055.Bytes);
public long this[int i]=>Value[i];

public static A161055Inst Instance=new A161055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161056
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,2L,3L,3L,4L,4L,5L,5L,7L,6L,7L,7L,9L,8L,9L,10L,12L,11L,12L,13L,15L,14L,16L,16L,19L,17L,20L,19L,23L,21L,25L,24L,29L,27L,32L,31L,38L,35L,41L,40L,47L,45L,52L,52L,61L,58L,66L,65L,74L,72L,82L,81L,93L,89L,100L,98L,110L,108L,121L,120L,135L,131L,145L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161056Inst : IEnumerable<long>
{
public static readonly long[] Value=A161056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161056.Bytes);
public long this[int i]=>Value[i];

public static A161056Inst Instance=new A161056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161057
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,3L,2L,4L,3L,5L,4L,6L,5L,8L,6L,8L,7L,10L,8L,10L,9L,13L,11L,13L,12L,16L,14L,16L,15L,20L,17L,20L,18L,24L,20L,24L,21L,29L,24L,30L,26L,36L,30L,38L,33L,46L,38L,48L,42L,56L,48L,60L,53L,71L,61L,75L,67L,85L,75L,91L,82L,105L,92L,111L,100L,123L,110L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161057Inst : IEnumerable<long>
{
public static readonly long[] Value=A161057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161057.Bytes);
public long this[int i]=>Value[i];

public static A161057Inst Instance=new A161057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161058
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,8L,7L,8L,8L,10L,9L,10L,10L,12L,12L,13L,13L,15L,15L,16L,16L,18L,18L,20L,19L,22L,21L,24L,22L,26L,24L,28L,26L,31L,29L,34L,32L,38L,36L,42L,40L,48L,45L,52L,50L,58L,56L,64L,62L,72L,70L,79L,77L,87L,85L,95L,93L,105L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161058Inst : IEnumerable<long>
{
public static readonly long[] Value=A161058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161058.Bytes);
public long this[int i]=>Value[i];

public static A161058Inst Instance=new A161058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161059
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,3L,2L,4L,3L,5L,4L,6L,5L,7L,6L,9L,7L,9L,8L,11L,9L,11L,10L,13L,11L,14L,13L,16L,14L,17L,16L,19L,17L,20L,19L,23L,20L,24L,22L,27L,23L,28L,25L,31L,26L,33L,29L,37L,31L,40L,35L,45L,38L,49L,43L,56L,47L,60L,53L,67L,58L,73L,65L,82L,71L,89L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161059Inst : IEnumerable<long>
{
public static readonly long[] Value=A161059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161059.Bytes);
public long this[int i]=>Value[i];

public static A161059Inst Instance=new A161059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161060
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,9L,8L,9L,9L,11L,10L,11L,11L,13L,12L,13L,14L,16L,15L,16L,17L,19L,18L,19L,20L,22L,21L,23L,23L,26L,24L,27L,26L,30L,27L,31L,29L,34L,31L,36L,34L,40L,37L,43L,41L,48L,45L,52L,50L,59L,55L,63L,61L,70L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161060Inst : IEnumerable<long>
{
public static readonly long[] Value=A161060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161060.Bytes);
public long this[int i]=>Value[i];

public static A161060Inst Instance=new A161060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161061
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,3L,2L,4L,3L,5L,4L,6L,5L,7L,6L,8L,7L,10L,8L,10L,9L,12L,10L,12L,11L,14L,12L,14L,13L,17L,15L,17L,16L,20L,18L,20L,19L,23L,21L,23L,22L,27L,24L,27L,25L,31L,27L,31L,28L,35L,30L,35L,31L,40L,34L,41L,36L,47L,40L,49L,43L,56L,48L,59L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161061Inst : IEnumerable<long>
{
public static readonly long[] Value=A161061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161061.Bytes);
public long this[int i]=>Value[i];

public static A161061Inst Instance=new A161061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161062
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,8L,10L,9L,10L,10L,12L,11L,12L,12L,14L,13L,14L,14L,16L,16L,17L,17L,19L,19L,20L,20L,22L,22L,23L,23L,25L,25L,27L,26L,29L,28L,31L,29L,33L,31L,35L,32L,37L,34L,39L,36L,42L,39L,45L,42L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161062Inst : IEnumerable<long>
{
public static readonly long[] Value=A161062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161062.Bytes);
public long this[int i]=>Value[i];

public static A161062Inst Instance=new A161062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161063
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,3L,2L,4L,3L,5L,4L,6L,5L,7L,6L,8L,7L,9L,8L,11L,9L,11L,10L,13L,11L,13L,12L,15L,13L,15L,14L,17L,15L,18L,17L,20L,18L,21L,20L,23L,21L,24L,23L,26L,24L,27L,26L,30L,27L,31L,29L,34L,30L,35L,32L,38L,33L,39L,35L,42L,36L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161063Inst : IEnumerable<long>
{
public static readonly long[] Value=A161063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161063.Bytes);
public long this[int i]=>Value[i];

public static A161063Inst Instance=new A161063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161064
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,2L,3L,2L,3L,4L,3L,5L,5L,5L,6L,7L,6L,8L,9L,8L,11L,11L,11L,13L,14L,14L,16L,19L,17L,21L,22L,22L,25L,27L,27L,30L,33L,32L,36L,39L,38L,44L,46L,46L,51L,54L,54L,59L,64L,62L,70L,73L,73L,80L,84L,85L,92L,98L,97L,107L,111L,112L,122L,127L,128L,139L,144L,146L,157L,164L,165L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161064Inst : IEnumerable<long>
{
public static readonly long[] Value=A161064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161064.Bytes);
public long this[int i]=>Value[i];

public static A161064Inst Instance=new A161064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161065
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,1L,1L,2L,1L,1L,3L,2L,2L,4L,3L,3L,5L,4L,4L,7L,5L,5L,8L,7L,7L,9L,9L,8L,11L,10L,10L,14L,12L,13L,16L,15L,15L,19L,19L,18L,23L,22L,22L,27L,26L,27L,31L,32L,32L,36L,36L,37L,43L,41L,43L,49L,48L,49L,57L,56L,56L,65L,64L,65L,73L,72L,74L,82L,82L,83L,92L,92L,93L,105L,102L,105L,117L,115L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161065Inst : IEnumerable<long>
{
public static readonly long[] Value=A161065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161065.Bytes);
public long this[int i]=>Value[i];

public static A161065Inst Instance=new A161065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161066
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,7L,6L,7L,7L,8L,9L,9L,10L,10L,10L,10L,12L,13L,12L,14L,14L,14L,15L,17L,18L,18L,20L,20L,21L,22L,24L,26L,26L,28L,29L,30L,31L,35L,36L,36L,39L,41L,42L,44L,47L,49L,50L,53L,54L,57L,58L,61L,66L,66L,69L,72L,75L,77L,82L,85L,86L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161066Inst : IEnumerable<long>
{
public static readonly long[] Value=A161066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161066.Bytes);
public long this[int i]=>Value[i];

public static A161066Inst Instance=new A161066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161067
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,2L,3L,2L,3L,4L,3L,4L,5L,4L,5L,6L,5L,6L,7L,6L,8L,8L,7L,8L,9L,9L,10L,12L,10L,11L,12L,11L,13L,14L,14L,15L,15L,14L,16L,17L,17L,20L,20L,19L,21L,22L,22L,25L,27L,26L,28L,29L,29L,32L,34L,35L,37L,38L,38L,41L,44L,44L,48L,49L,49L,53L,55L,56L,60L,63L,63L,66L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161067Inst : IEnumerable<long>
{
public static readonly long[] Value=A161067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161067.Bytes);
public long this[int i]=>Value[i];

public static A161067Inst Instance=new A161067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161068
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,3L,2L,2L,4L,3L,3L,5L,4L,4L,6L,5L,5L,7L,6L,6L,8L,7L,7L,10L,8L,8L,10L,9L,9L,12L,12L,11L,13L,12L,12L,14L,14L,15L,16L,15L,15L,18L,16L,17L,21L,18L,18L,22L,21L,20L,25L,25L,23L,27L,27L,27L,30L,31L,32L,34L,34L,35L,39L,38L,40L,45L,43L,44L,49L,49L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161068Inst : IEnumerable<long>
{
public static readonly long[] Value=A161068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161068.Bytes);
public long this[int i]=>Value[i];

public static A161068Inst Instance=new A161068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161069
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,8L,8L,8L,9L,10L,9L,10L,10L,10L,11L,11L,13L,13L,13L,13L,14L,14L,14L,17L,16L,16L,17L,17L,17L,18L,21L,19L,20L,21L,20L,21L,22L,25L,24L,25L,26L,26L,27L,28L,32L,31L,32L,34L,34L,35L,37L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161069Inst : IEnumerable<long>
{
public static readonly long[] Value=A161069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161069.Bytes);
public long this[int i]=>Value[i];

public static A161069Inst Instance=new A161069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161070
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,3L,2L,3L,4L,3L,4L,5L,4L,5L,6L,5L,6L,7L,6L,7L,8L,7L,8L,9L,8L,9L,10L,9L,11L,11L,10L,11L,12L,11L,12L,14L,13L,14L,15L,14L,15L,16L,16L,17L,18L,17L,18L,19L,18L,20L,21L,20L,22L,22L,21L,23L,24L,23L,25L,26L,25L,27L,28L,28L,30L,31L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161070Inst : IEnumerable<long>
{
public static readonly long[] Value=A161070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161070.Bytes);
public long this[int i]=>Value[i];

public static A161070Inst Instance=new A161070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161071
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,3L,2L,2L,4L,3L,3L,5L,4L,4L,6L,5L,5L,7L,6L,6L,8L,7L,7L,9L,8L,8L,10L,9L,9L,11L,10L,10L,13L,11L,11L,13L,12L,12L,14L,14L,13L,16L,15L,15L,17L,16L,17L,18L,18L,18L,20L,19L,19L,22L,20L,21L,23L,22L,22L,25L,24L,23L,27L,25L,25L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161071Inst : IEnumerable<long>
{
public static readonly long[] Value=A161071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161071.Bytes);
public long this[int i]=>Value[i];

public static A161071Inst Instance=new A161071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161072
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,8L,8L,8L,9L,9L,9L,10L,10L,10L,11L,11L,11L,12L,13L,12L,13L,13L,13L,14L,14L,15L,15L,15L,16L,17L,17L,17L,19L,18L,18L,20L,20L,20L,21L,22L,21L,22L,23L,23L,24L,24L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161072Inst : IEnumerable<long>
{
public static readonly long[] Value=A161072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161072.Bytes);
public long this[int i]=>Value[i];

public static A161072Inst Instance=new A161072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161073
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,3L,2L,3L,4L,3L,4L,5L,4L,5L,6L,5L,6L,7L,6L,7L,8L,7L,8L,9L,8L,9L,10L,9L,10L,11L,10L,11L,12L,11L,12L,13L,12L,14L,14L,13L,14L,15L,14L,15L,17L,15L,16L,17L,17L,18L,19L,19L,19L,20L,19L,21L,22L,21L,23L,23L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161073Inst : IEnumerable<long>
{
public static readonly long[] Value=A161073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161073.Bytes);
public long this[int i]=>Value[i];

public static A161073Inst Instance=new A161073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161074
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,3L,2L,2L,4L,3L,3L,5L,4L,4L,6L,5L,5L,7L,6L,6L,8L,7L,7L,9L,8L,8L,10L,9L,9L,11L,10L,10L,12L,11L,11L,13L,12L,12L,14L,13L,13L,16L,14L,14L,16L,15L,15L,17L,17L,16L,18L,17L,17L,20L,19L,20L,21L,20L,20L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161074Inst : IEnumerable<long>
{
public static readonly long[] Value=A161074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161074.Bytes);
public long this[int i]=>Value[i];

public static A161074Inst Instance=new A161074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161075
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,8L,8L,8L,9L,9L,9L,10L,10L,10L,11L,11L,11L,12L,12L,12L,13L,13L,13L,14L,14L,14L,15L,16L,15L,16L,16L,16L,17L,17L,18L,18L,18L,18L,19L,19L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161075Inst : IEnumerable<long>
{
public static readonly long[] Value=A161075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161075.Bytes);
public long this[int i]=>Value[i];

public static A161075Inst Instance=new A161075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161076
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,3L,2L,3L,4L,3L,4L,5L,4L,5L,6L,5L,6L,7L,6L,7L,8L,7L,8L,9L,8L,9L,10L,9L,10L,11L,10L,11L,12L,11L,12L,13L,12L,13L,14L,13L,14L,15L,14L,15L,16L,15L,17L,17L,16L,17L,18L,17L,18L,20L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161076Inst : IEnumerable<long>
{
public static readonly long[] Value=A161076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161076.Bytes);
public long this[int i]=>Value[i];

public static A161076Inst Instance=new A161076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161077
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,4L,2L,5L,5L,8L,6L,12L,10L,16L,16L,22L,21L,31L,30L,40L,42L,53L,55L,71L,73L,90L,96L,116L,123L,149L,157L,186L,200L,234L,250L,292L,312L,360L,388L,443L,476L,543L,584L,660L,712L,800L,862L,967L,1041L,1160L,1252L,1390L,1497L,1659L,1786L,1970L,2124L,2336L,2513L,2760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161077Inst : IEnumerable<long>
{
public static readonly long[] Value=A161077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161077.Bytes);
public long this[int i]=>Value[i];

public static A161077Inst Instance=new A161077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161078
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,1L,2L,3L,3L,3L,6L,5L,6L,10L,8L,9L,14L,13L,16L,21L,19L,23L,30L,31L,34L,42L,44L,49L,60L,61L,68L,83L,85L,96L,111L,115L,129L,149L,158L,173L,196L,210L,229L,260L,275L,301L,339L,359L,392L,436L,462L,505L,559L,594L,645L,708L,755L,817L,895L,952L,1026L,1123L,1194L,1287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161078Inst : IEnumerable<long>
{
public static readonly long[] Value=A161078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161078.Bytes);
public long this[int i]=>Value[i];

public static A161078Inst Instance=new A161078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161079
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,1L,2L,1L,2L,1L,4L,2L,4L,4L,6L,5L,8L,7L,11L,9L,12L,11L,16L,16L,19L,19L,25L,24L,31L,29L,38L,38L,45L,49L,55L,57L,66L,69L,83L,82L,97L,100L,114L,120L,133L,143L,159L,168L,188L,195L,220L,231L,256L,272L,299L,316L,346L,367L,407L,426L,467L,495L,539L,572L,616L,658L,713L,753L,819L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161079Inst : IEnumerable<long>
{
public static readonly long[] Value=A161079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161079.Bytes);
public long this[int i]=>Value[i];

public static A161079Inst Instance=new A161079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161080
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,3L,3L,3L,5L,4L,6L,7L,7L,8L,10L,11L,11L,13L,13L,14L,19L,18L,20L,23L,24L,30L,31L,33L,35L,40L,47L,48L,55L,57L,61L,73L,74L,81L,88L,95L,106L,112L,120L,128L,139L,154L,162L,174L,185L,198L,220L,230L,246L,265L,280L,308L,325L,346L,367L,393L,428L,450L,483L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161080Inst : IEnumerable<long>
{
public static readonly long[] Value=A161080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161080.Bytes);
public long this[int i]=>Value[i];

public static A161080Inst Instance=new A161080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161081
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,4L,2L,4L,4L,5L,4L,8L,6L,8L,9L,10L,9L,15L,11L,14L,15L,16L,16L,22L,19L,23L,25L,28L,28L,37L,33L,39L,42L,46L,47L,58L,57L,64L,69L,74L,77L,90L,90L,102L,107L,115L,119L,137L,137L,152L,163L,171L,179L,200L,204L,221L,236L,252L,261L,289L,296L,320L,339L,360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161081Inst : IEnumerable<long>
{
public static readonly long[] Value=A161081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161081.Bytes);
public long this[int i]=>Value[i];

public static A161081Inst Instance=new A161081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161082
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,3L,3L,3L,5L,4L,5L,6L,7L,7L,9L,9L,10L,11L,12L,14L,14L,15L,16L,17L,19L,19L,22L,23L,25L,28L,29L,32L,35L,39L,41L,44L,47L,51L,55L,59L,66L,69L,74L,80L,85L,91L,97L,107L,112L,120L,127L,135L,143L,153L,166L,173L,184L,195L,206L,217L,230L,248L,258L,274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161082Inst : IEnumerable<long>
{
public static readonly long[] Value=A161082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161082.Bytes);
public long this[int i]=>Value[i];

public static A161082Inst Instance=new A161082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161083
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,4L,2L,4L,4L,5L,4L,7L,5L,8L,8L,9L,9L,12L,10L,13L,13L,16L,14L,18L,16L,19L,20L,21L,20L,26L,24L,29L,29L,32L,33L,39L,39L,45L,45L,51L,51L,60L,59L,65L,70L,77L,79L,88L,89L,98L,103L,113L,115L,128L,131L,142L,149L,159L,164L,180L,185L,201L,207L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161083Inst : IEnumerable<long>
{
public static readonly long[] Value=A161083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161083.Bytes);
public long this[int i]=>Value[i];

public static A161083Inst Instance=new A161083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161084
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,3L,3L,3L,5L,4L,5L,6L,6L,6L,9L,8L,9L,11L,11L,11L,14L,13L,14L,18L,16L,17L,20L,19L,21L,23L,22L,23L,28L,28L,29L,33L,33L,36L,42L,41L,44L,51L,51L,56L,60L,62L,66L,73L,77L,79L,89L,91L,97L,107L,108L,117L,125L,130L,139L,149L,154L,163L,175L,182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161084Inst : IEnumerable<long>
{
public static readonly long[] Value=A161084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161084.Bytes);
public long this[int i]=>Value[i];

public static A161084Inst Instance=new A161084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161085
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,4L,2L,4L,4L,5L,4L,7L,5L,7L,7L,9L,8L,11L,10L,12L,12L,14L,13L,16L,15L,19L,17L,20L,19L,22L,22L,24L,23L,26L,25L,31L,29L,33L,33L,37L,39L,43L,43L,48L,49L,58L,56L,63L,63L,70L,74L,79L,82L,88L,90L,103L,103L,112L,115L,125L,131L,139L,144L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161085Inst : IEnumerable<long>
{
public static readonly long[] Value=A161085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161085.Bytes);
public long this[int i]=>Value[i];

public static A161085Inst Instance=new A161085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161086
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,3L,3L,3L,5L,4L,5L,6L,6L,6L,8L,7L,9L,10L,10L,11L,13L,12L,14L,15L,15L,16L,18L,19L,19L,21L,21L,22L,25L,24L,25L,27L,27L,29L,32L,32L,34L,37L,39L,41L,45L,46L,49L,54L,56L,61L,64L,67L,71L,77L,80L,84L,91L,94L,99L,106L,112L,117L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161086Inst : IEnumerable<long>
{
public static readonly long[] Value=A161086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161086.Bytes);
public long this[int i]=>Value[i];

public static A161086Inst Instance=new A161086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161087
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,4L,2L,4L,4L,5L,4L,7L,5L,7L,7L,8L,7L,11L,9L,11L,12L,13L,12L,16L,14L,16L,17L,18L,17L,23L,19L,22L,23L,24L,24L,28L,25L,28L,29L,31L,29L,36L,33L,37L,40L,41L,42L,49L,47L,53L,55L,59L,60L,70L,68L,74L,78L,83L,85L,95L,95L,102L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161087Inst : IEnumerable<long>
{
public static readonly long[] Value=A161087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161087.Bytes);
public long this[int i]=>Value[i];

public static A161087Inst Instance=new A161087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161088
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,3L,3L,3L,5L,4L,5L,6L,6L,6L,8L,7L,8L,9L,10L,10L,12L,12L,13L,14L,15L,15L,17L,17L,18L,19L,20L,22L,22L,23L,24L,25L,27L,27L,28L,29L,30L,32L,32L,33L,36L,37L,40L,41L,43L,46L,49L,52L,54L,57L,61L,64L,69L,73L,75L,81L,84L,90L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161088Inst : IEnumerable<long>
{
public static readonly long[] Value=A161088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161088.Bytes);
public long this[int i]=>Value[i];

public static A161088Inst Instance=new A161088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161089
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,4L,2L,4L,4L,5L,4L,7L,5L,7L,7L,8L,7L,10L,8L,11L,11L,12L,12L,15L,13L,16L,16L,17L,17L,20L,18L,21L,21L,24L,22L,26L,24L,27L,28L,29L,28L,32L,30L,34L,33L,35L,34L,40L,39L,42L,43L,46L,47L,54L,52L,57L,59L,64L,66L,72L,72L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161089Inst : IEnumerable<long>
{
public static readonly long[] Value=A161089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161089.Bytes);
public long this[int i]=>Value[i];

public static A161089Inst Instance=new A161089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161090
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,2L,1L,2L,2L,3L,2L,3L,3L,4L,3L,5L,4L,6L,5L,6L,6L,7L,6L,8L,8L,9L,9L,11L,10L,13L,11L,14L,14L,16L,15L,18L,18L,20L,19L,22L,22L,25L,24L,27L,28L,32L,29L,36L,34L,39L,38L,42L,42L,47L,45L,51L,51L,56L,55L,62L,61L,68L,66L,75L,73L,82L,79L,88L,88L,96L,93L,104L,105L,112L,113L,122L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161090Inst : IEnumerable<long>
{
public static readonly long[] Value=A161090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161090.Bytes);
public long this[int i]=>Value[i];

public static A161090Inst Instance=new A161090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161091
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,3L,2L,2L,3L,4L,3L,3L,4L,5L,4L,4L,6L,6L,5L,6L,7L,8L,7L,7L,8L,10L,8L,8L,11L,11L,10L,11L,13L,13L,13L,13L,15L,18L,15L,16L,20L,21L,19L,21L,23L,24L,24L,24L,27L,30L,28L,28L,33L,36L,33L,35L,39L,42L,41L,42L,45L,49L,47L,48L,55L,56L,54L,58L,63L,67L,65L,66L,72L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161091Inst : IEnumerable<long>
{
public static readonly long[] Value=A161091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161091.Bytes);
public long this[int i]=>Value[i];

public static A161091Inst Instance=new A161091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161092
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,2L,2L,2L,4L,3L,3L,3L,5L,4L,4L,4L,6L,5L,5L,5L,8L,6L,6L,6L,9L,8L,8L,8L,10L,10L,9L,9L,11L,11L,11L,11L,14L,12L,13L,12L,16L,14L,15L,15L,19L,18L,17L,18L,22L,21L,20L,21L,26L,26L,26L,25L,30L,29L,30L,29L,34L,34L,35L,35L,40L,39L,39L,40L,46L,46L,47L,48L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161092Inst : IEnumerable<long>
{
public static readonly long[] Value=A161092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161092.Bytes);
public long this[int i]=>Value[i];

public static A161092Inst Instance=new A161092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161093
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L,6L,6L,6L,6L,7L,8L,7L,7L,8L,8L,9L,9L,10L,10L,11L,10L,11L,11L,11L,12L,13L,13L,13L,14L,14L,15L,14L,14L,16L,17L,17L,17L,19L,19L,20L,19L,20L,22L,23L,23L,25L,26L,26L,27L,27L,29L,31L,32L,33L,34L,36L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161093Inst : IEnumerable<long>
{
public static readonly long[] Value=A161093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161093.Bytes);
public long this[int i]=>Value[i];

public static A161093Inst Instance=new A161093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161094
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,2L,3L,2L,3L,3L,4L,3L,4L,4L,5L,4L,5L,5L,6L,5L,6L,6L,7L,6L,7L,7L,8L,7L,9L,8L,9L,8L,9L,9L,11L,10L,11L,12L,12L,11L,12L,12L,13L,13L,14L,14L,16L,14L,15L,15L,16L,15L,18L,17L,18L,18L,19L,18L,20L,19L,21L,22L,23L,22L,25L,24L,25L,25L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161094Inst : IEnumerable<long>
{
public static readonly long[] Value=A161094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161094.Bytes);
public long this[int i]=>Value[i];

public static A161094Inst Instance=new A161094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161095
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,3L,2L,2L,3L,4L,3L,3L,4L,5L,4L,4L,5L,6L,5L,5L,6L,7L,6L,6L,7L,8L,7L,7L,8L,9L,8L,8L,10L,10L,9L,9L,10L,11L,10L,11L,12L,14L,12L,12L,13L,14L,13L,13L,15L,16L,16L,15L,16L,17L,16L,16L,17L,19L,18L,19L,20L,20L,19L,19L,21L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161095Inst : IEnumerable<long>
{
public static readonly long[] Value=A161095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161095.Bytes);
public long this[int i]=>Value[i];

public static A161095Inst Instance=new A161095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161096
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,3L,2L,2L,2L,4L,3L,3L,3L,5L,4L,4L,4L,6L,5L,5L,5L,7L,6L,6L,6L,8L,7L,7L,7L,9L,8L,8L,8L,10L,9L,9L,9L,12L,10L,10L,10L,12L,11L,11L,11L,14L,14L,13L,13L,15L,14L,14L,14L,16L,16L,17L,16L,18L,17L,17L,17L,19L,18L,19L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161096Inst : IEnumerable<long>
{
public static readonly long[] Value=A161096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161096.Bytes);
public long this[int i]=>Value[i];

public static A161096Inst Instance=new A161096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161097
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L,6L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,10L,11L,12L,11L,11L,12L,12L,12L,12L,13L,13L,15L,14L,15L,15L,15L,15L,16L,16L,16L,18L,18L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161097Inst : IEnumerable<long>
{
public static readonly long[] Value=A161097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161097.Bytes);
public long this[int i]=>Value[i];

public static A161097Inst Instance=new A161097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161098
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,2L,3L,2L,3L,3L,4L,3L,4L,4L,5L,4L,5L,5L,6L,5L,6L,6L,7L,6L,7L,7L,8L,7L,8L,8L,9L,8L,9L,9L,10L,9L,10L,10L,11L,10L,11L,11L,12L,11L,13L,12L,13L,12L,13L,13L,14L,13L,14L,15L,16L,15L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161098Inst : IEnumerable<long>
{
public static readonly long[] Value=A161098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161098.Bytes);
public long this[int i]=>Value[i];

public static A161098Inst Instance=new A161098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161099
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,3L,2L,2L,3L,4L,3L,3L,4L,5L,4L,4L,5L,6L,5L,5L,6L,7L,6L,6L,7L,8L,7L,7L,8L,9L,8L,8L,9L,10L,9L,9L,10L,11L,10L,10L,11L,12L,11L,11L,12L,13L,12L,12L,14L,14L,13L,13L,14L,15L,14L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161099Inst : IEnumerable<long>
{
public static readonly long[] Value=A161099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161099.Bytes);
public long this[int i]=>Value[i];

public static A161099Inst Instance=new A161099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161100
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,3L,2L,2L,2L,4L,3L,3L,3L,5L,4L,4L,4L,6L,5L,5L,5L,7L,6L,6L,6L,8L,7L,7L,7L,9L,8L,8L,8L,10L,9L,9L,9L,11L,10L,10L,10L,12L,11L,11L,11L,13L,12L,12L,12L,14L,13L,13L,13L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161100Inst : IEnumerable<long>
{
public static readonly long[] Value=A161100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161100.Bytes);
public long this[int i]=>Value[i];

public static A161100Inst Instance=new A161100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161101
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L,6L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,11L,12L,12L,12L,12L,13L,13L,13L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161101Inst : IEnumerable<long>
{
public static readonly long[] Value=A161101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161101.Bytes);
public long this[int i]=>Value[i];

public static A161101Inst Instance=new A161101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161102
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,2L,3L,2L,3L,3L,4L,3L,4L,4L,5L,4L,5L,5L,6L,5L,6L,6L,7L,6L,7L,7L,8L,7L,8L,8L,9L,8L,9L,9L,10L,9L,10L,10L,11L,10L,11L,11L,12L,11L,12L,12L,13L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161102Inst : IEnumerable<long>
{
public static readonly long[] Value=A161102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161102.Bytes);
public long this[int i]=>Value[i];

public static A161102Inst Instance=new A161102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161103
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,2L,3L,2L,3L,5L,3L,5L,6L,5L,6L,9L,6L,10L,11L,10L,12L,16L,12L,17L,19L,17L,21L,27L,21L,30L,32L,30L,35L,42L,35L,46L,50L,47L,55L,66L,56L,72L,77L,73L,84L,97L,86L,107L,114L,110L,125L,143L,128L,156L,165L,160L,181L,204L,186L,224L,236L,230L,259L,285L,266L,312L,329L,322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161103Inst : IEnumerable<long>
{
public static readonly long[] Value=A161103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161103.Bytes);
public long this[int i]=>Value[i];

public static A161103Inst Instance=new A161103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A161104
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,1L,1L,2L,1L,1L,3L,2L,2L,4L,3L,3L,6L,4L,4L,7L,6L,6L,9L,7L,7L,11L,9L,9L,15L,11L,11L,18L,15L,15L,22L,18L,18L,27L,23L,22L,33L,28L,28L,41L,34L,34L,49L,42L,42L,56L,51L,51L,68L,60L,59L,79L,72L,71L,94L,83L,84L,111L,100L,100L,127L,117L,118L,147L,136L,135L,171L,158L,158L,199L,183L,183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A161104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A161104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A161104Inst : IEnumerable<long>
{
public static readonly long[] Value=A161104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A161104.Bytes);
public long this[int i]=>Value[i];

public static A161104Inst Instance=new A161104Inst();

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