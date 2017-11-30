using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A022057
{
public static readonly long[] Value={ 1L,1300L,239252L,14797120L,410468500L,6030043240L,54177864000L,343594659200L,1706685733012L,7010460268500L,24832297608040L,77924078814400L,221394909419840L,578472382307304L,1407681394953600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022057Inst : IEnumerable<long>
{
public static readonly long[] Value=A022057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022057.Bytes);
public long this[int i]=>Value[i];

public static A022057Inst Instance=new A022057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022056
{
public static readonly long[] Value={ 1L,1200L,202450L,11389600L,285385200L,3779134240L,30885301600L,181284196800L,842726826450L,3262594952400L,10968671291040L,32802221530400L,89267475949600L,223991253535200L,525491835433600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022056Inst : IEnumerable<long>
{
public static readonly long[] Value=A022056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022056.Bytes);
public long this[int i]=>Value[i];

public static A022056Inst Instance=new A022056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022055
{
public static readonly long[] Value={ 1L,1104L,170064L,8662720L,195082320L,2319457632L,17231109824L,93703589760L,407488018512L,1487286966928L,4744779429216L,13523760003648L,35250721087168L,84944161233120L,192127452262272L,409984511707776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022055Inst : IEnumerable<long>
{
public static readonly long[] Value=A022055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022055.Bytes);
public long this[int i]=>Value[i];

public static A022055Inst Instance=new A022055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022054
{
public static readonly long[] Value={ 1L,1012L,141726L,6503112L,130905236L,1392036360L,9401213016L,47412641232L,192747766686L,663612939132L,2007831887432L,5456890474248L,13617909938952L,31527898462552L,68719323996224L,141662701280848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022054Inst : IEnumerable<long>
{
public static readonly long[] Value=A022054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022054.Bytes);
public long this[int i]=>Value[i];

public static A022054Inst Instance=new A022054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022053
{
public static readonly long[] Value={ 1L,924L,117084L,4812192L,86075484L,815677016L,5012882336L,23460347328L,89096422492L,289559673084L,830202403800L,2153312518240L,5140361517984L,11444537517336L,24015334687168L,47873378766400L,91281903219804L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022053Inst : IEnumerable<long>
{
public static readonly long[] Value=A022053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022053.Bytes);
public long this[int i]=>Value[i];

public static A022053Inst Instance=new A022053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022052
{
public static readonly long[] Value={ 1L,840L,95802L,3504816L,55350120L,465944304L,2610853840L,11337146784L,40208417466L,123411903160L,335056780464L,830096613360L,1893781702512L,4058779021584L,8190877926720L,15805879161632L,29122237029480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022052Inst : IEnumerable<long>
{
public static readonly long[] Value=A022052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022052.Bytes);
public long this[int i]=>Value[i];

public static A022052Inst Instance=new A022052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022051
{
public static readonly long[] Value={ 1L,760L,77560L,2508000L,34729720L,259114704L,1327461600L,5341699520L,17701924600L,51294999960L,131880275664L,312126610080L,680432137440L,1404010658960L,2724593155520L,5089580732736L,9062110326520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022051Inst : IEnumerable<long>
{
public static readonly long[] Value=A022051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022051.Bytes);
public long this[int i]=>Value[i];

public static A022051Inst Instance=new A022051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022050
{
public static readonly long[] Value={ 1L,684L,62054L,1759704L,21210156L,140116184L,658369608L,2449182384L,7597766246L,20748447108L,50601708504L,114223115480L,238352317656L,472600643976L,883678139136L,1594639240368L,2749536787500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022050Inst : IEnumerable<long>
{
public static readonly long[] Value=A022050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022050.Bytes);
public long this[int i]=>Value[i];

public static A022050Inst Instance=new A022050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022049
{
public static readonly long[] Value={ 1L,612L,48996L,1207680L,12573540L,73617480L,318102912L,1090632960L,3176573796L,8148505828L,18918517320L,40578145920L,81375600000L,154398101832L,279331331328L,484986858240L,812932819812L,1320330798792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022049Inst : IEnumerable<long>
{
public static readonly long[] Value=A022049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022049.Bytes);
public long this[int i]=>Value[i];

public static A022049Inst Instance=new A022049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022048
{
public static readonly long[] Value={ 1L,544L,38114L,808384L,7213984L,37569728L,149405248L,470966912L,1291650786L,3101265120L,6883061184L,13967503552L,27036220096L,48877735232L,85898222336L,142979339392L,233808578464L,365627715968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022048Inst : IEnumerable<long>
{
public static readonly long[] Value=A022048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022048.Bytes);
public long this[int i]=>Value[i];

public static A022048Inst Instance=new A022048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022047
{
public static readonly long[] Value={ 1L,480L,29152L,525952L,3994080L,18626112L,67978880L,197120256L,509145568L,1143441760L,2428524096L,4658843520L,8705492608L,15000919872L,25593401600L,40864033536L,65187410400L,98098623936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022047Inst : IEnumerable<long>
{
public static readonly long[] Value=A022047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022047.Bytes);
public long this[int i]=>Value[i];

public static A022047Inst Instance=new A022047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022046
{
public static readonly long[] Value={ 1L,420L,21870L,331240L,2128260L,8972712L,29822520L,80027280L,193511790L,409172940L,825736296L,1509537960L,2698852520L,4472616120L,7347537600L,11335886864L,17520853380L,25553816400L,37658603350L,52706867640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022046Inst : IEnumerable<long>
{
public static readonly long[] Value=A022046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022046.Bytes);
public long this[int i]=>Value[i];

public static A022046Inst Instance=new A022046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022045
{
public static readonly long[] Value={ 1L,364L,16044L,200928L,1089452L,4196920L,12547808L,31553344L,70439852L,142487436L,268594872L,476105504L,800698080L,1296257144L,2022013760L,3056208064L,4507001772L,6481076056L,9123064524L,12637846368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022045Inst : IEnumerable<long>
{
public static readonly long[] Value=A022045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022045.Bytes);
public long this[int i]=>Value[i];

public static A022045Inst Instance=new A022045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022012
{
public static readonly long[] Value={ 17L,1277L,113147L,2580647L,20737877L,58208387L,73373537L,76170527L,100658627L,134764997L,137943347L,165531257L,171958667L,224008217L,252277007L,294536147L,309740987L,311725847L,364154027L,408936947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022012Inst : IEnumerable<long>
{
public static readonly long[] Value=A022012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022012.Bytes);
public long this[int i]=>Value[i];

public static A022012Inst Instance=new A022012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022011
{
public static readonly long[] Value={ 11L,15760091L,25658441L,93625991L,182403491L,226449521L,661972301L,910935911L,1042090781L,1071322781L,1170221861L,1394025161L,1459270271L,1712750771L,1742638811L,1935587651L,2048038451L,2397437501L,2799645461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022011Inst : IEnumerable<long>
{
public static readonly long[] Value=A022011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022011.Bytes);
public long this[int i]=>Value[i];

public static A022011Inst Instance=new A022011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022010
{
public static readonly long[] Value={ 5639L,88799L,284729L,626609L,855719L,1146779L,6560999L,7540439L,8573429L,17843459L,19089599L,24001709L,42981929L,43534019L,69156539L,74266259L,79208399L,80427029L,84104549L,87988709L,124066079L,128469149L,144214319L,157131419L,208729049L,218033729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022010Inst : IEnumerable<long>
{
public static readonly long[] Value=A022010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022010.Bytes);
public long this[int i]=>Value[i];

public static A022010Inst Instance=new A022010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022009
{
public static readonly long[] Value={ 11L,165701L,1068701L,11900501L,15760091L,18504371L,21036131L,25658441L,39431921L,45002591L,67816361L,86818211L,93625991L,124716071L,136261241L,140117051L,154635191L,162189101L,182403491L,186484211L,187029371L,190514321L,198453371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022009Inst : IEnumerable<long>
{
public static readonly long[] Value=A022009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022009.Bytes);
public long this[int i]=>Value[i];

public static A022009Inst Instance=new A022009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022008
{
public static readonly long[] Value={ 7L,97L,16057L,19417L,43777L,1091257L,1615837L,1954357L,2822707L,2839927L,3243337L,3400207L,6005887L,6503587L,7187767L,7641367L,8061997L,8741137L,10526557L,11086837L,11664547L,14520547L,14812867L,14834707L,14856757L,16025827L,16094707L,18916477L,19197247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022008Inst : IEnumerable<long>
{
public static readonly long[] Value=A022008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022008.Bytes);
public long this[int i]=>Value[i];

public static A022008Inst Instance=new A022008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022007
{
public static readonly long[] Value={ 7L,97L,1867L,3457L,5647L,15727L,16057L,19417L,43777L,79687L,88807L,101107L,257857L,266677L,276037L,284737L,340927L,354247L,375247L,402757L,419047L,427237L,463447L,470077L,626617L,666427L,736357L,823717L,855727L,959467L,978067L,1022377L,1043587L,1068247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022007Inst : IEnumerable<long>
{
public static readonly long[] Value=A022007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022007.Bytes);
public long this[int i]=>Value[i];

public static A022007Inst Instance=new A022007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022006
{
public static readonly long[] Value={ 5L,11L,101L,1481L,16061L,19421L,21011L,22271L,43781L,55331L,144161L,165701L,166841L,195731L,201821L,225341L,247601L,268811L,326141L,347981L,361211L,397751L,465161L,518801L,536441L,633461L,633791L,661091L,768191L,795791L,829721L,857951L,876011L,958541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022006Inst : IEnumerable<long>
{
public static readonly long[] Value=A022006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022006.Bytes);
public long this[int i]=>Value[i];

public static A022006Inst Instance=new A022006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022005
{
public static readonly long[] Value={ 7L,13L,37L,67L,97L,103L,193L,223L,277L,307L,457L,613L,823L,853L,877L,1087L,1297L,1423L,1447L,1483L,1663L,1693L,1783L,1867L,1873L,1993L,2083L,2137L,2377L,2683L,2707L,2797L,3163L,3253L,3457L,3463L,3847L,4153L,4513L,4783L,5227L,5413L,5437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022005Inst : IEnumerable<long>
{
public static readonly long[] Value=A022005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022005.Bytes);
public long this[int i]=>Value[i];

public static A022005Inst Instance=new A022005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022004
{
public static readonly long[] Value={ 5L,11L,17L,41L,101L,107L,191L,227L,311L,347L,461L,641L,821L,857L,881L,1091L,1277L,1301L,1427L,1481L,1487L,1607L,1871L,1997L,2081L,2237L,2267L,2657L,2687L,3251L,3461L,3527L,3671L,3917L,4001L,4127L,4517L,4637L,4787L,4931L,4967L,5231L,5477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022004Inst : IEnumerable<long>
{
public static readonly long[] Value=A022004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022004.Bytes);
public long this[int i]=>Value[i];

public static A022004Inst Instance=new A022004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022003
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022003Inst : IEnumerable<long>
{
public static readonly long[] Value=A022003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022003.Bytes);
public long this[int i]=>Value[i];

public static A022003Inst Instance=new A022003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022002
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,2L,0L,0L,4L,0L,0L,8L,0L,1L,6L,0L,3L,2L,0L,6L,4L,1L,2L,8L,2L,5L,6L,5L,1L,3L,0L,2L,6L,0L,5L,2L,1L,0L,4L,2L,0L,8L,4L,1L,6L,8L,3L,3L,6L,6L,7L,3L,3L,4L,6L,6L,9L,3L,3L,8L,6L,7L,7L,3L,5L,4L,7L,0L,9L,4L,1L,8L,8L,3L,7L,6L,7L,5L,3L,5L,0L,7L,0L,1L,4L,0L,2L,8L,0L,5L,6L,1L,1L,2L,2L,2L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022002Inst : IEnumerable<long>
{
public static readonly long[] Value=A022002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022002.Bytes);
public long this[int i]=>Value[i];

public static A022002Inst Instance=new A022002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022001
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,3L,0L,0L,9L,0L,2L,7L,0L,8L,1L,2L,4L,3L,7L,3L,1L,1L,9L,3L,5L,8L,0L,7L,4L,2L,2L,2L,6L,6L,8L,0L,0L,4L,0L,1L,2L,0L,3L,6L,1L,0L,8L,3L,2L,4L,9L,7L,4L,9L,2L,4L,7L,7L,4L,3L,2L,2L,9L,6L,8L,9L,0L,6L,7L,2L,0L,1L,6L,0L,4L,8L,1L,4L,4L,4L,3L,3L,2L,9L,9L,8L,9L,9L,6L,9L,9L,0L,9L,7L,2L,9L,1L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022001Inst : IEnumerable<long>
{
public static readonly long[] Value=A022001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022001.Bytes);
public long this[int i]=>Value[i];

public static A022001Inst Instance=new A022001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022000
{
public static readonly long[] Value={ 1L,28L,533L,8648L,128889L,1824276L,24950461L,333078016L,4367420897L,56484732044L,722650676709L,9164986526904L,115404823162825L,1444532800672132L,17990818115880077L,223110488408176112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022000Inst : IEnumerable<long>
{
public static readonly long[] Value=A022000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022000.Bytes);
public long this[int i]=>Value[i];

public static A022000Inst Instance=new A022000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021999
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,5L,0L,2L,5L,1L,2L,5L,6L,2L,8L,1L,4L,0L,7L,0L,3L,5L,1L,7L,5L,8L,7L,9L,3L,9L,6L,9L,8L,4L,9L,2L,4L,6L,2L,3L,1L,1L,5L,5L,7L,7L,8L,8L,9L,4L,4L,7L,2L,3L,6L,1L,8L,0L,9L,0L,4L,5L,2L,2L,6L,1L,3L,0L,6L,5L,3L,2L,6L,6L,3L,3L,1L,6L,5L,8L,2L,9L,1L,4L,5L,7L,2L,8L,6L,4L,3L,2L,1L,6L,0L,8L,0L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021999Inst : IEnumerable<long>
{
public static readonly long[] Value=A021999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021999.Bytes);
public long this[int i]=>Value[i];

public static A021999Inst Instance=new A021999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021998
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,6L,0L,3L,6L,2L,1L,7L,3L,0L,3L,8L,2L,2L,9L,3L,7L,6L,2L,5L,7L,5L,4L,5L,2L,7L,1L,6L,2L,9L,7L,7L,8L,6L,7L,2L,0L,3L,2L,1L,9L,3L,1L,5L,8L,9L,5L,3L,7L,2L,2L,3L,3L,4L,0L,0L,4L,0L,2L,4L,1L,4L,4L,8L,6L,9L,2L,1L,5L,2L,9L,1L,7L,5L,0L,5L,0L,3L,0L,1L,8L,1L,0L,8L,6L,5L,1L,9L,1L,1L,4L,6L,8L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021998Inst : IEnumerable<long>
{
public static readonly long[] Value=A021998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021998.Bytes);
public long this[int i]=>Value[i];

public static A021998Inst Instance=new A021998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021997
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,7L,0L,4L,9L,3L,4L,5L,4L,1L,7L,9L,2L,5L,4L,7L,8L,3L,4L,8L,4L,3L,9L,0L,7L,3L,5L,1L,4L,6L,0L,2L,2L,1L,5L,5L,0L,8L,5L,5L,9L,9L,1L,9L,4L,3L,6L,0L,5L,2L,3L,6L,6L,5L,6L,5L,9L,6L,1L,7L,3L,2L,1L,2L,4L,8L,7L,4L,1L,1L,8L,8L,3L,1L,8L,2L,2L,7L,5L,9L,3L,1L,5L,2L,0L,6L,4L,4L,5L,1L,1L,5L,8L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021997Inst : IEnumerable<long>
{
public static readonly long[] Value=A021997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021997.Bytes);
public long this[int i]=>Value[i];

public static A021997Inst Instance=new A021997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021980
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,4L,5L,9L,0L,1L,6L,3L,9L,3L,4L,4L,2L,6L,2L,2L,9L,5L,0L,8L,1L,9L,6L,7L,2L,1L,3L,1L,1L,4L,7L,5L,4L,0L,9L,8L,3L,6L,0L,6L,5L,5L,7L,3L,7L,7L,0L,4L,9L,1L,8L,0L,3L,2L,7L,8L,6L,8L,8L,5L,2L,4L,5L,9L,0L,1L,6L,3L,9L,3L,4L,4L,2L,6L,2L,2L,9L,5L,0L,8L,1L,9L,6L,7L,2L,1L,3L,1L,1L,4L,7L,5L,4L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021980Inst : IEnumerable<long>
{
public static readonly long[] Value=A021980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021980.Bytes);
public long this[int i]=>Value[i];

public static A021980Inst Instance=new A021980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021979
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021979Inst : IEnumerable<long>
{
public static readonly long[] Value=A021979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021979.Bytes);
public long this[int i]=>Value[i];

public static A021979Inst Instance=new A021979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021978
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,6L,6L,9L,4L,0L,4L,5L,1L,7L,4L,5L,3L,7L,9L,8L,7L,6L,7L,9L,6L,7L,1L,4L,5L,7L,9L,0L,5L,5L,4L,4L,1L,4L,7L,8L,4L,3L,9L,4L,2L,5L,0L,5L,1L,3L,3L,4L,7L,0L,2L,2L,5L,8L,7L,2L,6L,8L,9L,9L,3L,8L,3L,9L,8L,3L,5L,7L,2L,8L,9L,5L,2L,7L,7L,2L,0L,7L,3L,9L,2L,1L,9L,7L,1L,2L,5L,2L,5L,6L,6L,7L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021978Inst : IEnumerable<long>
{
public static readonly long[] Value=A021978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021978.Bytes);
public long this[int i]=>Value[i];

public static A021978Inst Instance=new A021978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021977
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,7L,7L,4L,9L,2L,2L,9L,1L,8L,8L,0L,7L,8L,1L,0L,8L,9L,4L,1L,4L,1L,8L,2L,9L,3L,9L,3L,6L,2L,7L,9L,5L,4L,7L,7L,9L,0L,3L,3L,9L,1L,5L,7L,2L,4L,5L,6L,3L,2L,0L,6L,5L,7L,7L,5L,9L,5L,0L,6L,6L,8L,0L,3L,6L,9L,9L,8L,9L,7L,2L,2L,5L,0L,7L,7L,0L,8L,1L,1L,9L,2L,1L,8L,9L,1L,0L,5L,8L,5L,8L,1L,7L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021977Inst : IEnumerable<long>
{
public static readonly long[] Value=A021977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021977.Bytes);
public long this[int i]=>Value[i];

public static A021977Inst Instance=new A021977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021976
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,8L,8L,0L,6L,5L,8L,4L,3L,6L,2L,1L,3L,9L,9L,1L,7L,6L,9L,5L,4L,7L,3L,2L,5L,1L,0L,2L,8L,8L,0L,6L,5L,8L,4L,3L,6L,2L,1L,3L,9L,9L,1L,7L,6L,9L,5L,4L,7L,3L,2L,5L,1L,0L,2L,8L,8L,0L,6L,5L,8L,4L,3L,6L,2L,1L,3L,9L,9L,1L,7L,6L,9L,5L,4L,7L,3L,2L,5L,1L,0L,2L,8L,8L,0L,6L,5L,8L,4L,3L,6L,2L,1L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021976Inst : IEnumerable<long>
{
public static readonly long[] Value=A021976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021976.Bytes);
public long this[int i]=>Value[i];

public static A021976Inst Instance=new A021976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021975
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,9L,8L,6L,6L,1L,1L,7L,4L,0L,4L,7L,3L,7L,3L,8L,4L,1L,4L,0L,0L,6L,1L,7L,9L,1L,9L,6L,7L,0L,4L,4L,2L,8L,4L,2L,4L,3L,0L,4L,8L,4L,0L,3L,7L,0L,7L,5L,1L,8L,0L,2L,2L,6L,5L,7L,0L,5L,4L,5L,8L,2L,9L,0L,4L,2L,2L,2L,4L,5L,1L,0L,8L,1L,3L,5L,9L,4L,2L,3L,2L,7L,4L,9L,7L,4L,2L,5L,3L,3L,4L,7L,0L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021975Inst : IEnumerable<long>
{
public static readonly long[] Value=A021975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021975.Bytes);
public long this[int i]=>Value[i];

public static A021975Inst Instance=new A021975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021974
{
public static readonly long[] Value={ 1L,26L,459L,6916L,96005L,1270542L,16318303L,205487672L,2552951769L,31419668098L,384095637107L,4672689817068L,56644179720493L,684877363365494L,8264853578776071L,99595171342479904L,1198894417410885377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021974Inst : IEnumerable<long>
{
public static readonly long[] Value=A021974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021974.Bytes);
public long this[int i]=>Value[i];

public static A021974Inst Instance=new A021974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021973
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,1L,9L,9L,1L,7L,4L,4L,0L,6L,6L,0L,4L,7L,4L,7L,1L,6L,2L,0L,2L,2L,7L,0L,3L,8L,1L,8L,3L,6L,9L,4L,5L,3L,0L,4L,4L,3L,7L,5L,6L,4L,4L,9L,9L,4L,8L,4L,0L,0L,4L,1L,2L,7L,9L,6L,6L,9L,7L,6L,2L,6L,4L,1L,8L,9L,8L,8L,6L,4L,8L,0L,9L,0L,8L,1L,5L,2L,7L,3L,4L,7L,7L,8L,1L,2L,1L,7L,7L,5L,0L,2L,5L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021973Inst : IEnumerable<long>
{
public static readonly long[] Value=A021973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021973.Bytes);
public long this[int i]=>Value[i];

public static A021973Inst Instance=new A021973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021972
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,3L,0L,5L,7L,8L,5L,1L,2L,3L,9L,6L,6L,9L,4L,2L,1L,4L,8L,7L,6L,0L,3L,3L,0L,5L,7L,8L,5L,1L,2L,3L,9L,6L,6L,9L,4L,2L,1L,4L,8L,7L,6L,0L,3L,3L,0L,5L,7L,8L,5L,1L,2L,3L,9L,6L,6L,9L,4L,2L,1L,4L,8L,7L,6L,0L,3L,3L,0L,5L,7L,8L,5L,1L,2L,3L,9L,6L,6L,9L,4L,2L,1L,4L,8L,7L,6L,0L,3L,3L,0L,5L,7L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021972Inst : IEnumerable<long>
{
public static readonly long[] Value=A021972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021972.Bytes);
public long this[int i]=>Value[i];

public static A021972Inst Instance=new A021972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021971
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,4L,1L,2L,6L,1L,6L,3L,3L,9L,1L,9L,3L,3L,8L,1L,5L,9L,2L,5L,5L,4L,2L,9L,1L,6L,2L,3L,5L,7L,8L,0L,7L,6L,5L,2L,5L,3L,3L,6L,0L,9L,1L,0L,0L,3L,1L,0L,2L,3L,7L,8L,4L,9L,0L,1L,7L,5L,8L,0L,1L,4L,4L,7L,7L,7L,6L,6L,2L,8L,7L,4L,8L,7L,0L,7L,3L,4L,2L,2L,9L,5L,7L,6L,0L,0L,8L,2L,7L,3L,0L,0L,9L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021971Inst : IEnumerable<long>
{
public static readonly long[] Value=A021971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021971.Bytes);
public long this[int i]=>Value[i];

public static A021971Inst Instance=new A021971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021970
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,5L,1L,9L,6L,6L,8L,7L,3L,7L,0L,6L,0L,0L,4L,1L,4L,0L,7L,8L,6L,7L,4L,9L,4L,8L,2L,4L,0L,1L,6L,5L,6L,3L,1L,4L,6L,9L,9L,7L,9L,2L,9L,6L,0L,6L,6L,2L,5L,2L,5L,8L,7L,9L,9L,1L,7L,1L,8L,4L,2L,6L,5L,0L,1L,0L,3L,5L,1L,9L,6L,6L,8L,7L,3L,7L,0L,6L,0L,0L,4L,1L,4L,0L,7L,8L,6L,7L,4L,9L,4L,8L,2L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021970Inst : IEnumerable<long>
{
public static readonly long[] Value=A021970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021970.Bytes);
public long this[int i]=>Value[i];

public static A021970Inst Instance=new A021970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021969
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,6L,2L,6L,9L,4L,3L,0L,0L,5L,1L,8L,1L,3L,4L,7L,1L,5L,0L,2L,5L,9L,0L,6L,7L,3L,5L,7L,5L,1L,2L,9L,5L,3L,3L,6L,7L,8L,7L,5L,6L,4L,7L,6L,6L,8L,3L,9L,3L,7L,8L,2L,3L,8L,3L,4L,1L,9L,6L,8L,9L,1L,1L,9L,1L,7L,0L,9L,8L,4L,4L,5L,5L,9L,5L,8L,5L,4L,9L,2L,2L,2L,7L,9L,7L,9L,2L,7L,4L,6L,1L,1L,3L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021969Inst : IEnumerable<long>
{
public static readonly long[] Value=A021969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021969.Bytes);
public long this[int i]=>Value[i];

public static A021969Inst Instance=new A021969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021968
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,7L,3L,4L,4L,3L,9L,8L,3L,4L,0L,2L,4L,8L,9L,6L,2L,6L,5L,5L,6L,0L,1L,6L,5L,9L,7L,5L,1L,0L,3L,7L,3L,4L,4L,3L,9L,8L,3L,4L,0L,2L,4L,8L,9L,6L,2L,6L,5L,5L,6L,0L,1L,6L,5L,9L,7L,5L,1L,0L,3L,7L,3L,4L,4L,3L,9L,8L,3L,4L,0L,2L,4L,8L,9L,6L,2L,6L,5L,5L,6L,0L,1L,6L,5L,9L,7L,5L,1L,0L,3L,7L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021968Inst : IEnumerable<long>
{
public static readonly long[] Value=A021968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021968.Bytes);
public long this[int i]=>Value[i];

public static A021968Inst Instance=new A021968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021967
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,8L,4L,2L,1L,5L,9L,9L,1L,6L,9L,2L,6L,2L,7L,2L,0L,6L,6L,4L,5L,8L,9L,8L,2L,3L,4L,6L,8L,3L,2L,8L,1L,4L,1L,2L,2L,5L,3L,3L,7L,4L,8L,7L,0L,1L,9L,7L,3L,0L,0L,1L,0L,3L,8L,4L,2L,1L,5L,9L,9L,1L,6L,9L,2L,6L,2L,7L,2L,0L,6L,6L,4L,5L,8L,9L,8L,2L,3L,4L,6L,8L,3L,2L,8L,1L,4L,1L,2L,2L,5L,3L,3L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021967Inst : IEnumerable<long>
{
public static readonly long[] Value=A021967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021967.Bytes);
public long this[int i]=>Value[i];

public static A021967Inst Instance=new A021967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021966
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021966Inst : IEnumerable<long>
{
public static readonly long[] Value=A021966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021966.Bytes);
public long this[int i]=>Value[i];

public static A021966Inst Instance=new A021966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021965
{
public static readonly long[] Value={ 0L,0L,1L,0L,4L,0L,5L,8L,2L,7L,2L,6L,3L,2L,6L,7L,4L,2L,9L,7L,6L,0L,6L,6L,5L,9L,7L,2L,9L,4L,4L,8L,4L,9L,1L,1L,5L,5L,0L,4L,6L,8L,2L,6L,2L,2L,2L,6L,8L,4L,7L,0L,3L,4L,3L,3L,9L,2L,2L,9L,9L,6L,8L,7L,8L,2L,5L,1L,8L,2L,1L,0L,1L,9L,7L,7L,1L,0L,7L,1L,8L,0L,0L,2L,0L,8L,1L,1L,6L,5L,4L,5L,2L,6L,5L,3L,4L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021965Inst : IEnumerable<long>
{
public static readonly long[] Value=A021965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021965.Bytes);
public long this[int i]=>Value[i];

public static A021965Inst Instance=new A021965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021948
{
public static readonly long[] Value={ 0L,0L,1L,0L,5L,9L,3L,2L,2L,0L,3L,3L,8L,9L,8L,3L,0L,5L,0L,8L,4L,7L,4L,5L,7L,6L,2L,7L,1L,1L,8L,6L,4L,4L,0L,6L,7L,7L,9L,6L,6L,1L,0L,1L,6L,9L,4L,9L,1L,5L,2L,5L,4L,2L,3L,7L,2L,8L,8L,1L,3L,5L,5L,9L,3L,2L,2L,0L,3L,3L,8L,9L,8L,3L,0L,5L,0L,8L,4L,7L,4L,5L,7L,6L,2L,7L,1L,1L,8L,6L,4L,4L,0L,6L,7L,7L,9L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021948Inst : IEnumerable<long>
{
public static readonly long[] Value=A021948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021948.Bytes);
public long this[int i]=>Value[i];

public static A021948Inst Instance=new A021948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021947
{
public static readonly long[] Value={ 0L,0L,1L,0L,6L,0L,4L,4L,5L,3L,8L,7L,0L,6L,2L,5L,6L,6L,2L,7L,7L,8L,3L,6L,6L,9L,1L,4L,1L,0L,3L,9L,2L,3L,6L,4L,7L,9L,3L,2L,1L,3L,1L,4L,9L,5L,2L,2L,7L,9L,9L,5L,7L,5L,8L,2L,1L,8L,4L,5L,1L,7L,4L,9L,7L,3L,4L,8L,8L,8L,6L,5L,3L,2L,3L,4L,3L,5L,8L,4L,3L,0L,5L,4L,0L,8L,2L,7L,1L,4L,7L,4L,0L,1L,9L,0L,8L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021947Inst : IEnumerable<long>
{
public static readonly long[] Value=A021947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021947.Bytes);
public long this[int i]=>Value[i];

public static A021947Inst Instance=new A021947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021946
{
public static readonly long[] Value={ 0L,0L,1L,0L,6L,1L,5L,7L,1L,1L,2L,5L,2L,6L,5L,3L,9L,2L,7L,8L,1L,3L,1L,6L,3L,4L,8L,1L,9L,5L,3L,2L,9L,0L,8L,7L,0L,4L,8L,8L,3L,2L,2L,7L,1L,7L,6L,2L,2L,0L,8L,0L,6L,7L,9L,4L,0L,5L,5L,2L,0L,1L,6L,9L,8L,5L,1L,3L,8L,0L,0L,4L,2L,4L,6L,2L,8L,4L,5L,0L,1L,0L,6L,1L,5L,7L,1L,1L,2L,5L,2L,6L,5L,3L,9L,2L,7L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021946Inst : IEnumerable<long>
{
public static readonly long[] Value=A021946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021946.Bytes);
public long this[int i]=>Value[i];

public static A021946Inst Instance=new A021946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021945
{
public static readonly long[] Value={ 0L,0L,1L,0L,6L,2L,6L,9L,9L,2L,5L,6L,1L,1L,0L,5L,2L,0L,7L,2L,2L,6L,3L,5L,4L,9L,4L,1L,5L,5L,1L,5L,4L,0L,9L,1L,3L,9L,2L,1L,3L,6L,0L,2L,5L,5L,0L,4L,7L,8L,2L,1L,4L,6L,6L,5L,2L,4L,9L,7L,3L,4L,3L,2L,5L,1L,8L,5L,9L,7L,2L,3L,6L,9L,8L,1L,9L,3L,4L,1L,1L,2L,6L,4L,6L,1L,2L,1L,1L,4L,7L,7L,1L,5L,1L,9L,6L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021945Inst : IEnumerable<long>
{
public static readonly long[] Value=A021945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021945.Bytes);
public long this[int i]=>Value[i];

public static A021945Inst Instance=new A021945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021944
{
public static readonly long[] Value={ 1L,25L,425L,6185L,83241L,1072425L,13462825L,166325545L,2034167081L,24716438825L,299050134825L,3608230161705L,43455812660521L,522726247165225L,6282767285808425L,75473627419962665L,906326894688267561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021944Inst : IEnumerable<long>
{
public static readonly long[] Value=A021944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021944.Bytes);
public long this[int i]=>Value[i];

public static A021944Inst Instance=new A021944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021943
{
public static readonly long[] Value={ 0L,0L,1L,0L,6L,4L,9L,6L,2L,7L,2L,6L,3L,0L,4L,5L,7L,9L,3L,3L,9L,7L,2L,3L,1L,0L,9L,6L,9L,1L,1L,6L,0L,8L,0L,9L,3L,7L,1L,6L,7L,1L,9L,9L,1L,4L,8L,0L,2L,9L,8L,1L,8L,9L,5L,6L,3L,3L,6L,5L,2L,8L,2L,2L,1L,5L,1L,2L,2L,4L,7L,0L,7L,1L,3L,5L,2L,5L,0L,2L,6L,6L,2L,4L,0L,6L,8L,1L,5L,7L,6L,1L,4L,4L,8L,3L,4L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021943Inst : IEnumerable<long>
{
public static readonly long[] Value=A021943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021943.Bytes);
public long this[int i]=>Value[i];

public static A021943Inst Instance=new A021943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021942
{
public static readonly long[] Value={ 0L,0L,1L,0L,6L,6L,0L,9L,8L,0L,8L,1L,0L,2L,3L,4L,5L,4L,1L,5L,7L,7L,8L,2L,5L,1L,5L,9L,9L,1L,4L,7L,1L,2L,1L,5L,3L,5L,1L,8L,1L,2L,3L,6L,6L,7L,3L,7L,7L,3L,9L,8L,7L,2L,0L,6L,8L,2L,3L,0L,2L,7L,7L,1L,8L,5L,5L,0L,1L,0L,6L,6L,0L,9L,8L,0L,8L,1L,0L,2L,3L,4L,5L,4L,1L,5L,7L,7L,8L,2L,5L,1L,5L,9L,9L,1L,4L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021942Inst : IEnumerable<long>
{
public static readonly long[] Value=A021942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021942.Bytes);
public long this[int i]=>Value[i];

public static A021942Inst Instance=new A021942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021941
{
public static readonly long[] Value={ 0L,0L,1L,0L,6L,7L,2L,3L,5L,8L,5L,9L,1L,2L,4L,8L,6L,6L,5L,9L,5L,5L,1L,7L,6L,0L,9L,3L,9L,1L,6L,7L,5L,5L,6L,0L,2L,9L,8L,8L,2L,6L,0L,4L,0L,5L,5L,4L,9L,6L,2L,6L,4L,6L,7L,4L,4L,9L,3L,0L,6L,2L,9L,6L,6L,9L,1L,5L,6L,8L,8L,3L,6L,7L,1L,2L,9L,1L,3L,5L,5L,3L,8L,9L,5L,4L,1L,0L,8L,8L,5L,8L,0L,5L,7L,6L,3L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021941Inst : IEnumerable<long>
{
public static readonly long[] Value=A021941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021941.Bytes);
public long this[int i]=>Value[i];

public static A021941Inst Instance=new A021941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021940
{
public static readonly long[] Value={ 0L,0L,1L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021940Inst : IEnumerable<long>
{
public static readonly long[] Value=A021940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021940.Bytes);
public long this[int i]=>Value[i];

public static A021940Inst Instance=new A021940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021939
{
public static readonly long[] Value={ 0L,0L,1L,0L,6L,9L,5L,1L,8L,7L,1L,6L,5L,7L,7L,5L,4L,0L,1L,0L,6L,9L,5L,1L,8L,7L,1L,6L,5L,7L,7L,5L,4L,0L,1L,0L,6L,9L,5L,1L,8L,7L,1L,6L,5L,7L,7L,5L,4L,0L,1L,0L,6L,9L,5L,1L,8L,7L,1L,6L,5L,7L,7L,5L,4L,0L,1L,0L,6L,9L,5L,1L,8L,7L,1L,6L,5L,7L,7L,5L,4L,0L,1L,0L,6L,9L,5L,1L,8L,7L,1L,6L,5L,7L,7L,5L,4L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021939Inst : IEnumerable<long>
{
public static readonly long[] Value=A021939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021939.Bytes);
public long this[int i]=>Value[i];

public static A021939Inst Instance=new A021939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021938
{
public static readonly long[] Value={ 0L,0L,1L,0L,7L,0L,6L,6L,3L,8L,1L,1L,5L,6L,3L,1L,6L,9L,1L,6L,4L,8L,8L,2L,2L,2L,6L,9L,8L,0L,7L,2L,8L,0L,5L,1L,3L,9L,1L,8L,6L,2L,9L,5L,5L,0L,3L,2L,1L,1L,9L,9L,1L,4L,3L,4L,6L,8L,9L,5L,0L,7L,4L,9L,4L,6L,4L,6L,6L,8L,0L,9L,4L,2L,1L,8L,4L,1L,5L,4L,1L,7L,5L,5L,8L,8L,8L,6L,5L,0L,9L,6L,3L,5L,9L,7L,4L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021938Inst : IEnumerable<long>
{
public static readonly long[] Value=A021938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021938.Bytes);
public long this[int i]=>Value[i];

public static A021938Inst Instance=new A021938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021937
{
public static readonly long[] Value={ 0L,0L,1L,0L,7L,1L,8L,1L,1L,3L,6L,1L,2L,0L,0L,4L,2L,8L,7L,2L,4L,5L,4L,4L,4L,8L,0L,1L,7L,1L,4L,8L,9L,8L,1L,7L,7L,9L,2L,0L,6L,8L,5L,9L,5L,9L,2L,7L,1L,1L,6L,8L,2L,7L,4L,3L,8L,3L,7L,0L,8L,4L,6L,7L,3L,0L,9L,7L,5L,3L,4L,8L,3L,3L,8L,6L,9L,2L,3L,9L,0L,1L,3L,9L,3L,3L,5L,4L,7L,6L,9L,5L,6L,0L,5L,5L,7L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021937Inst : IEnumerable<long>
{
public static readonly long[] Value=A021937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021937.Bytes);
public long this[int i]=>Value[i];

public static A021937Inst Instance=new A021937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021936
{
public static readonly long[] Value={ 0L,0L,1L,0L,7L,2L,9L,6L,1L,3L,7L,3L,3L,9L,0L,5L,5L,7L,9L,3L,9L,9L,1L,4L,1L,6L,3L,0L,9L,0L,1L,2L,8L,7L,5L,5L,3L,6L,4L,8L,0L,6L,8L,6L,6L,9L,5L,2L,7L,8L,9L,6L,9L,9L,5L,7L,0L,8L,1L,5L,4L,5L,0L,6L,4L,3L,7L,7L,6L,8L,2L,4L,0L,3L,4L,3L,3L,4L,7L,6L,3L,9L,4L,8L,4L,9L,7L,8L,5L,4L,0L,7L,7L,2L,5L,3L,2L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021936Inst : IEnumerable<long>
{
public static readonly long[] Value=A021936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021936.Bytes);
public long this[int i]=>Value[i];

public static A021936Inst Instance=new A021936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021935
{
public static readonly long[] Value={ 0L,0L,1L,0L,7L,4L,1L,1L,3L,8L,5L,6L,0L,6L,8L,7L,4L,3L,2L,8L,6L,7L,8L,8L,3L,9L,9L,5L,7L,0L,3L,5L,4L,4L,5L,7L,5L,7L,2L,5L,0L,2L,6L,8L,5L,2L,8L,4L,6L,4L,0L,1L,7L,1L,8L,5L,8L,2L,1L,6L,9L,7L,0L,9L,9L,8L,9L,2L,5L,8L,8L,6L,1L,4L,3L,9L,3L,1L,2L,5L,6L,7L,1L,3L,2L,1L,1L,6L,0L,0L,4L,2L,9L,6L,4L,5L,5L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021935Inst : IEnumerable<long>
{
public static readonly long[] Value=A021935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021935.Bytes);
public long this[int i]=>Value[i];

public static A021935Inst Instance=new A021935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021934
{
public static readonly long[] Value={ 0L,0L,1L,0L,7L,5L,2L,6L,8L,8L,1L,7L,2L,0L,4L,3L,0L,1L,0L,7L,5L,2L,6L,8L,8L,1L,7L,2L,0L,4L,3L,0L,1L,0L,7L,5L,2L,6L,8L,8L,1L,7L,2L,0L,4L,3L,0L,1L,0L,7L,5L,2L,6L,8L,8L,1L,7L,2L,0L,4L,3L,0L,1L,0L,7L,5L,2L,6L,8L,8L,1L,7L,2L,0L,4L,3L,0L,1L,0L,7L,5L,2L,6L,8L,8L,1L,7L,2L,0L,4L,3L,0L,1L,0L,7L,5L,2L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021934Inst : IEnumerable<long>
{
public static readonly long[] Value=A021934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021934.Bytes);
public long this[int i]=>Value[i];

public static A021934Inst Instance=new A021934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021933
{
public static readonly long[] Value={ 0L,0L,1L,0L,7L,6L,4L,2L,6L,2L,6L,4L,8L,0L,0L,8L,6L,1L,1L,4L,1L,0L,1L,1L,8L,4L,0L,6L,8L,8L,9L,1L,2L,8L,0L,9L,4L,7L,2L,5L,5L,1L,1L,3L,0L,2L,4L,7L,5L,7L,8L,0L,4L,0L,9L,0L,4L,1L,9L,8L,0L,6L,2L,4L,3L,2L,7L,2L,3L,3L,5L,8L,4L,4L,9L,9L,4L,6L,1L,7L,8L,6L,8L,6L,7L,5L,9L,9L,5L,6L,9L,4L,2L,9L,4L,9L,4L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021933Inst : IEnumerable<long>
{
public static readonly long[] Value=A021933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021933.Bytes);
public long this[int i]=>Value[i];

public static A021933Inst Instance=new A021933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021916
{
public static readonly long[] Value={ 0L,0L,1L,0L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021916Inst : IEnumerable<long>
{
public static readonly long[] Value=A021916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021916.Bytes);
public long this[int i]=>Value[i];

public static A021916Inst Instance=new A021916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021915
{
public static readonly long[] Value={ 0L,0L,1L,0L,9L,7L,6L,9L,4L,8L,4L,0L,8L,3L,4L,2L,4L,8L,0L,7L,9L,0L,3L,4L,0L,2L,8L,5L,4L,0L,0L,6L,5L,8L,6L,1L,6L,9L,0L,4L,5L,0L,0L,5L,4L,8L,8L,4L,7L,4L,2L,0L,4L,1L,7L,1L,2L,4L,0L,3L,9L,5L,1L,7L,0L,1L,4L,2L,7L,0L,0L,3L,2L,9L,3L,0L,8L,4L,5L,2L,2L,5L,0L,2L,7L,4L,4L,2L,3L,7L,1L,0L,2L,0L,8L,5L,6L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021915Inst : IEnumerable<long>
{
public static readonly long[] Value=A021915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021915.Bytes);
public long this[int i]=>Value[i];

public static A021915Inst Instance=new A021915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021914
{
public static readonly long[] Value={ 1L,23L,355L,4635L,55371L,627243L,6866155L,73433195L,772592491L,8032358763L,82776456555L,847393109355L,8630981813611L,87566313375083L,885715453576555L,8937574526027115L,90019110908986731L,905338057186084203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021914Inst : IEnumerable<long>
{
public static readonly long[] Value=A021914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021914.Bytes);
public long this[int i]=>Value[i];

public static A021914Inst Instance=new A021914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021913
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021913Inst : IEnumerable<long>
{
public static readonly long[] Value=A021913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021913.Bytes);
public long this[int i]=>Value[i];

public static A021913Inst Instance=new A021913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021912
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,1L,3L,2L,1L,5L,8L,5L,9L,0L,3L,0L,8L,3L,7L,0L,0L,4L,4L,0L,5L,2L,8L,6L,3L,4L,3L,6L,1L,2L,3L,3L,4L,8L,0L,1L,7L,6L,2L,1L,1L,4L,5L,3L,7L,4L,4L,4L,9L,3L,3L,9L,2L,0L,7L,0L,4L,8L,4L,5L,8L,1L,4L,9L,7L,7L,9L,7L,3L,5L,6L,8L,2L,8L,1L,9L,3L,8L,3L,2L,5L,9L,9L,1L,1L,8L,9L,4L,2L,7L,3L,1L,2L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021912Inst : IEnumerable<long>
{
public static readonly long[] Value=A021912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021912.Bytes);
public long this[int i]=>Value[i];

public static A021912Inst Instance=new A021912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021911
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,2L,5L,3L,5L,8L,3L,2L,4L,1L,4L,5L,5L,3L,4L,7L,2L,9L,8L,7L,8L,7L,2L,1L,0L,5L,8L,4L,3L,4L,3L,9L,9L,1L,1L,7L,9L,7L,1L,3L,3L,4L,0L,6L,8L,3L,5L,7L,2L,2L,1L,6L,0L,9L,7L,0L,2L,3L,1L,5L,3L,2L,5L,2L,4L,8L,0L,7L,0L,5L,6L,2L,2L,9L,3L,2L,7L,4L,5L,3L,1L,4L,2L,2L,2L,7L,1L,2L,2L,3L,8L,1L,4L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021911Inst : IEnumerable<long>
{
public static readonly long[] Value=A021911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021911.Bytes);
public long this[int i]=>Value[i];

public static A021911Inst Instance=new A021911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021910
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,3L,7L,5L,2L,7L,5L,9L,3L,8L,1L,8L,9L,8L,4L,5L,4L,7L,4L,6L,1L,3L,6L,8L,6L,5L,3L,4L,2L,1L,6L,3L,3L,5L,5L,4L,0L,8L,3L,8L,8L,5L,2L,0L,9L,7L,1L,3L,0L,2L,4L,2L,8L,2L,5L,6L,0L,7L,0L,6L,4L,0L,1L,7L,6L,6L,0L,0L,4L,4L,1L,5L,0L,1L,1L,0L,3L,7L,5L,2L,7L,5L,9L,3L,8L,1L,8L,9L,8L,4L,5L,4L,7L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021910Inst : IEnumerable<long>
{
public static readonly long[] Value=A021910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021910.Bytes);
public long this[int i]=>Value[i];

public static A021910Inst Instance=new A021910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021909
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,4L,9L,7L,2L,3L,7L,5L,6L,9L,0L,6L,0L,7L,7L,3L,4L,8L,0L,6L,6L,2L,9L,8L,3L,4L,2L,5L,4L,1L,4L,3L,6L,4L,6L,4L,0L,8L,8L,3L,9L,7L,7L,9L,0L,0L,5L,5L,2L,4L,8L,6L,1L,8L,7L,8L,4L,5L,3L,0L,3L,8L,6L,7L,4L,0L,3L,3L,1L,4L,9L,1L,7L,1L,2L,7L,0L,7L,1L,8L,2L,3L,2L,0L,4L,4L,1L,9L,8L,8L,9L,5L,0L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021909Inst : IEnumerable<long>
{
public static readonly long[] Value=A021909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021909.Bytes);
public long this[int i]=>Value[i];

public static A021909Inst Instance=new A021909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021908
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,6L,1L,9L,4L,6L,9L,0L,2L,6L,5L,4L,8L,6L,7L,2L,5L,6L,6L,3L,7L,1L,6L,8L,1L,4L,1L,5L,9L,2L,9L,2L,0L,3L,5L,3L,9L,8L,2L,3L,0L,0L,8L,8L,4L,9L,5L,5L,7L,5L,2L,2L,1L,2L,3L,8L,9L,3L,8L,0L,5L,3L,0L,9L,7L,3L,4L,5L,1L,3L,2L,7L,4L,3L,3L,6L,2L,8L,3L,1L,8L,5L,8L,4L,0L,7L,0L,7L,9L,6L,4L,6L,0L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021908Inst : IEnumerable<long>
{
public static readonly long[] Value=A021908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021908.Bytes);
public long this[int i]=>Value[i];

public static A021908Inst Instance=new A021908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021907
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,7L,4L,1L,9L,7L,1L,2L,0L,7L,0L,8L,7L,4L,8L,6L,1L,5L,7L,2L,5L,3L,5L,9L,9L,1L,1L,4L,0L,6L,4L,2L,3L,0L,3L,4L,3L,3L,0L,0L,1L,1L,0L,7L,4L,1L,9L,7L,1L,2L,0L,7L,0L,8L,7L,4L,8L,6L,1L,5L,7L,2L,5L,3L,5L,9L,9L,1L,1L,4L,0L,6L,4L,2L,3L,0L,3L,4L,3L,3L,0L,0L,1L,1L,0L,7L,4L,1L,9L,7L,1L,2L,0L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021907Inst : IEnumerable<long>
{
public static readonly long[] Value=A021907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021907.Bytes);
public long this[int i]=>Value[i];

public static A021907Inst Instance=new A021907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021906
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,8L,6L,4L,7L,4L,5L,0L,1L,1L,0L,8L,6L,4L,7L,4L,5L,0L,1L,1L,0L,8L,6L,4L,7L,4L,5L,0L,1L,1L,0L,8L,6L,4L,7L,4L,5L,0L,1L,1L,0L,8L,6L,4L,7L,4L,5L,0L,1L,1L,0L,8L,6L,4L,7L,4L,5L,0L,1L,1L,0L,8L,6L,4L,7L,4L,5L,0L,1L,1L,0L,8L,6L,4L,7L,4L,5L,0L,1L,1L,0L,8L,6L,4L,7L,4L,5L,0L,1L,1L,0L,8L,6L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021906Inst : IEnumerable<long>
{
public static readonly long[] Value=A021906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021906.Bytes);
public long this[int i]=>Value[i];

public static A021906Inst Instance=new A021906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021905
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,9L,8L,7L,7L,9L,1L,3L,4L,2L,9L,5L,2L,2L,7L,5L,2L,4L,9L,7L,2L,2L,5L,3L,0L,5L,2L,1L,6L,4L,2L,6L,1L,9L,3L,1L,1L,8L,7L,5L,6L,9L,3L,6L,7L,3L,6L,9L,5L,8L,9L,3L,4L,5L,1L,7L,2L,0L,3L,1L,0L,7L,6L,5L,8L,1L,5L,7L,6L,0L,2L,6L,6L,3L,7L,0L,6L,9L,9L,2L,2L,3L,0L,8L,5L,4L,6L,0L,5L,9L,9L,3L,3L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021905Inst : IEnumerable<long>
{
public static readonly long[] Value=A021905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021905.Bytes);
public long this[int i]=>Value[i];

public static A021905Inst Instance=new A021905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021904
{
public static readonly long[] Value={ 1L,22L,323L,3992L,44949L,478074L,4896391L,48839164L,477813017L,4606751006L,43913627979L,414851195616L,3890711480605L,36272898564418L,336508406905487L,3108995652410948L,28624326520414113L,262765886779943910L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021904Inst : IEnumerable<long>
{
public static readonly long[] Value=A021904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021904.Bytes);
public long this[int i]=>Value[i];

public static A021904Inst Instance=new A021904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021903
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,3L,4L,7L,0L,5L,2L,2L,8L,0L,3L,1L,1L,4L,5L,7L,1L,7L,4L,6L,3L,8L,4L,8L,7L,2L,0L,8L,0L,0L,8L,8L,9L,8L,7L,7L,6L,4L,1L,8L,2L,4L,2L,4L,9L,1L,6L,5L,7L,3L,9L,7L,1L,0L,7L,8L,9L,7L,6L,6L,4L,0L,7L,1L,1L,9L,0L,2L,1L,1L,3L,4L,5L,9L,3L,9L,9L,3L,3L,2L,5L,9L,1L,7L,6L,8L,6L,3L,1L,8L,1L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021903Inst : IEnumerable<long>
{
public static readonly long[] Value=A021903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021903.Bytes);
public long this[int i]=>Value[i];

public static A021903Inst Instance=new A021903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021902
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,3L,5L,8L,5L,7L,4L,6L,1L,0L,2L,4L,4L,9L,8L,8L,8L,6L,4L,1L,4L,2L,5L,3L,8L,9L,7L,5L,5L,0L,1L,1L,1L,3L,5L,8L,5L,7L,4L,6L,1L,0L,2L,4L,4L,9L,8L,8L,8L,6L,4L,1L,4L,2L,5L,3L,8L,9L,7L,5L,5L,0L,1L,1L,1L,3L,5L,8L,5L,7L,4L,6L,1L,0L,2L,4L,4L,9L,8L,8L,8L,6L,4L,1L,4L,2L,5L,3L,8L,9L,7L,5L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021902Inst : IEnumerable<long>
{
public static readonly long[] Value=A021902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021902.Bytes);
public long this[int i]=>Value[i];

public static A021902Inst Instance=new A021902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021901
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,4L,8L,2L,7L,2L,0L,1L,7L,8L,3L,7L,2L,3L,5L,2L,2L,8L,5L,3L,9L,5L,7L,6L,3L,6L,5L,6L,6L,3L,3L,2L,2L,1L,8L,5L,0L,6L,1L,3L,1L,5L,4L,9L,6L,0L,9L,8L,1L,0L,4L,7L,9L,3L,7L,5L,6L,9L,6L,7L,6L,7L,0L,0L,1L,1L,1L,4L,8L,2L,7L,2L,0L,1L,7L,8L,3L,7L,2L,3L,5L,2L,2L,8L,5L,3L,9L,5L,7L,6L,3L,6L,5L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021901Inst : IEnumerable<long>
{
public static readonly long[] Value=A021901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021901.Bytes);
public long this[int i]=>Value[i];

public static A021901Inst Instance=new A021901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021868
{
public static readonly long[] Value={ 0L,0L,1L,1L,5L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021868Inst : IEnumerable<long>
{
public static readonly long[] Value=A021868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021868.Bytes);
public long this[int i]=>Value[i];

public static A021868Inst Instance=new A021868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021867
{
public static readonly long[] Value={ 0L,0L,1L,1L,5L,8L,7L,4L,8L,5L,5L,1L,5L,6L,4L,3L,1L,0L,5L,4L,4L,6L,1L,1L,8L,1L,9L,2L,3L,5L,2L,2L,5L,9L,5L,5L,9L,6L,7L,5L,5L,5L,0L,4L,0L,5L,5L,6L,1L,9L,9L,3L,0L,4L,7L,5L,0L,8L,6L,9L,0L,6L,1L,4L,1L,3L,6L,7L,3L,2L,3L,2L,9L,0L,8L,4L,5L,8L,8L,6L,4L,4L,2L,6L,4L,1L,9L,4L,6L,6L,9L,7L,5L,6L,6L,6L,2L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021867Inst : IEnumerable<long>
{
public static readonly long[] Value=A021867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021867.Bytes);
public long this[int i]=>Value[i];

public static A021867Inst Instance=new A021867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021866
{
public static readonly long[] Value={ 0L,0L,1L,1L,6L,0L,0L,9L,2L,8L,0L,7L,4L,2L,4L,5L,9L,3L,9L,6L,7L,5L,1L,7L,4L,0L,1L,3L,9L,2L,1L,1L,1L,3L,6L,8L,9L,0L,9L,5L,1L,2L,7L,6L,1L,0L,2L,0L,8L,8L,1L,6L,7L,0L,5L,3L,3L,6L,4L,2L,6L,9L,1L,4L,1L,5L,3L,1L,3L,2L,2L,5L,0L,5L,8L,0L,0L,4L,6L,4L,0L,3L,7L,1L,2L,2L,9L,6L,9L,8L,3L,7L,5L,8L,7L,0L,0L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021866Inst : IEnumerable<long>
{
public static readonly long[] Value=A021866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021866.Bytes);
public long this[int i]=>Value[i];

public static A021866Inst Instance=new A021866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021865
{
public static readonly long[] Value={ 0L,0L,1L,1L,6L,1L,4L,4L,0L,1L,8L,5L,8L,3L,0L,4L,2L,9L,7L,3L,2L,8L,6L,8L,7L,5L,7L,2L,5L,9L,0L,0L,1L,1L,6L,1L,4L,4L,0L,1L,8L,5L,8L,3L,0L,4L,2L,9L,7L,3L,2L,8L,6L,8L,7L,5L,7L,2L,5L,9L,0L,0L,1L,1L,6L,1L,4L,4L,0L,1L,8L,5L,8L,3L,0L,4L,2L,9L,7L,3L,2L,8L,6L,8L,7L,5L,7L,2L,5L,9L,0L,0L,1L,1L,6L,1L,4L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021865Inst : IEnumerable<long>
{
public static readonly long[] Value=A021865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021865.Bytes);
public long this[int i]=>Value[i];

public static A021865Inst Instance=new A021865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021864
{
public static readonly long[] Value={ 1L,21L,294L,3466L,37275L,379407L,3727648L,35761572L,337430709L,3146261833L,29083452762L,267126341118L,2441786303503L,22239710844099L,202003194298836L,1830950757258904L,16569016601938857L,149754390830203005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021864Inst : IEnumerable<long>
{
public static readonly long[] Value=A021864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021864.Bytes);
public long this[int i]=>Value[i];

public static A021864Inst Instance=new A021864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021863
{
public static readonly long[] Value={ 0L,0L,1L,1L,6L,4L,1L,4L,4L,3L,5L,3L,8L,9L,9L,8L,8L,3L,5L,8L,5L,5L,6L,4L,6L,1L,0L,0L,1L,1L,6L,4L,1L,4L,4L,3L,5L,3L,8L,9L,9L,8L,8L,3L,5L,8L,5L,5L,6L,4L,6L,1L,0L,0L,1L,1L,6L,4L,1L,4L,4L,3L,5L,3L,8L,9L,9L,8L,8L,3L,5L,8L,5L,5L,6L,4L,6L,1L,0L,0L,1L,1L,6L,4L,1L,4L,4L,3L,5L,3L,8L,9L,9L,8L,8L,3L,5L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021863Inst : IEnumerable<long>
{
public static readonly long[] Value=A021863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021863.Bytes);
public long this[int i]=>Value[i];

public static A021863Inst Instance=new A021863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021862
{
public static readonly long[] Value={ 0L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021862Inst : IEnumerable<long>
{
public static readonly long[] Value=A021862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021862.Bytes);
public long this[int i]=>Value[i];

public static A021862Inst Instance=new A021862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021861
{
public static readonly long[] Value={ 0L,0L,1L,1L,6L,6L,8L,6L,1L,1L,4L,3L,5L,2L,3L,9L,2L,0L,6L,5L,3L,4L,4L,2L,2L,4L,0L,3L,7L,3L,3L,9L,5L,5L,6L,5L,9L,2L,7L,6L,5L,4L,6L,0L,9L,1L,0L,1L,5L,1L,6L,9L,1L,9L,4L,8L,6L,5L,8L,1L,0L,9L,6L,8L,4L,9L,4L,7L,4L,9L,1L,2L,4L,8L,5L,4L,1L,4L,2L,3L,5L,7L,0L,5L,9L,5L,0L,9L,9L,1L,8L,3L,1L,9L,7L,1L,9L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021861Inst : IEnumerable<long>
{
public static readonly long[] Value=A021861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021861.Bytes);
public long this[int i]=>Value[i];

public static A021861Inst Instance=new A021861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021860
{
public static readonly long[] Value={ 0L,0L,1L,1L,6L,8L,2L,2L,4L,2L,9L,9L,0L,6L,5L,4L,2L,0L,5L,6L,0L,7L,4L,7L,6L,6L,3L,5L,5L,1L,4L,0L,1L,8L,6L,9L,1L,5L,8L,8L,7L,8L,5L,0L,4L,6L,7L,2L,8L,9L,7L,1L,9L,6L,2L,6L,1L,6L,8L,2L,2L,4L,2L,9L,9L,0L,6L,5L,4L,2L,0L,5L,6L,0L,7L,4L,7L,6L,6L,3L,5L,5L,1L,4L,0L,1L,8L,6L,9L,1L,5L,8L,8L,7L,8L,5L,0L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021860Inst : IEnumerable<long>
{
public static readonly long[] Value=A021860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021860.Bytes);
public long this[int i]=>Value[i];

public static A021860Inst Instance=new A021860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021859
{
public static readonly long[] Value={ 0L,0L,1L,1L,6L,9L,5L,9L,0L,6L,4L,3L,2L,7L,4L,8L,5L,3L,8L,0L,1L,1L,6L,9L,5L,9L,0L,6L,4L,3L,2L,7L,4L,8L,5L,3L,8L,0L,1L,1L,6L,9L,5L,9L,0L,6L,4L,3L,2L,7L,4L,8L,5L,3L,8L,0L,1L,1L,6L,9L,5L,9L,0L,6L,4L,3L,2L,7L,4L,8L,5L,3L,8L,0L,1L,1L,6L,9L,5L,9L,0L,6L,4L,3L,2L,7L,4L,8L,5L,3L,8L,0L,1L,1L,6L,9L,5L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021859Inst : IEnumerable<long>
{
public static readonly long[] Value=A021859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021859.Bytes);
public long this[int i]=>Value[i];

public static A021859Inst Instance=new A021859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021858
{
public static readonly long[] Value={ 0L,0L,1L,1L,7L,0L,9L,6L,0L,1L,8L,7L,3L,5L,3L,6L,2L,9L,9L,7L,6L,5L,8L,0L,7L,9L,6L,2L,5L,2L,9L,2L,7L,4L,0L,0L,4L,6L,8L,3L,8L,4L,0L,7L,4L,9L,4L,1L,4L,5L,1L,9L,9L,0L,6L,3L,2L,3L,1L,8L,5L,0L,1L,1L,7L,0L,9L,6L,0L,1L,8L,7L,3L,5L,3L,6L,2L,9L,9L,7L,6L,5L,8L,0L,7L,9L,6L,2L,5L,2L,9L,2L,7L,4L,0L,0L,4L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021858Inst : IEnumerable<long>
{
public static readonly long[] Value=A021858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021858.Bytes);
public long this[int i]=>Value[i];

public static A021858Inst Instance=new A021858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021857
{
public static readonly long[] Value={ 0L,0L,1L,1L,7L,2L,3L,3L,2L,9L,4L,2L,5L,5L,5L,6L,8L,5L,8L,1L,4L,7L,7L,1L,3L,9L,5L,0L,7L,6L,2L,0L,1L,6L,4L,1L,2L,6L,6L,1L,1L,9L,5L,7L,7L,9L,6L,0L,1L,4L,0L,6L,7L,9L,9L,5L,3L,1L,0L,6L,6L,8L,2L,2L,9L,7L,7L,7L,2L,5L,6L,7L,4L,0L,9L,1L,4L,4L,1L,9L,6L,9L,5L,1L,9L,3L,4L,3L,4L,9L,3L,5L,5L,2L,1L,6L,8L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021857Inst : IEnumerable<long>
{
public static readonly long[] Value=A021857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021857.Bytes);
public long this[int i]=>Value[i];

public static A021857Inst Instance=new A021857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021856
{
public static readonly long[] Value={ 0L,0L,1L,1L,7L,3L,7L,0L,8L,9L,2L,0L,1L,8L,7L,7L,9L,3L,4L,2L,7L,2L,3L,0L,0L,4L,6L,9L,4L,8L,3L,5L,6L,8L,0L,7L,5L,1L,1L,7L,3L,7L,0L,8L,9L,2L,0L,1L,8L,7L,7L,9L,3L,4L,2L,7L,2L,3L,0L,0L,4L,6L,9L,4L,8L,3L,5L,6L,8L,0L,7L,5L,1L,1L,7L,3L,7L,0L,8L,9L,2L,0L,1L,8L,7L,7L,9L,3L,4L,2L,7L,2L,3L,0L,0L,4L,6L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021856Inst : IEnumerable<long>
{
public static readonly long[] Value=A021856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021856.Bytes);
public long this[int i]=>Value[i];

public static A021856Inst Instance=new A021856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021855
{
public static readonly long[] Value={ 0L,0L,1L,1L,7L,5L,0L,8L,8L,1L,3L,1L,6L,0L,9L,8L,7L,0L,7L,4L,0L,3L,0L,5L,5L,2L,2L,9L,1L,4L,2L,1L,8L,5L,6L,6L,3L,9L,2L,4L,7L,9L,4L,3L,5L,9L,5L,7L,6L,9L,6L,8L,2L,7L,2L,6L,2L,0L,4L,4L,6L,5L,3L,3L,4L,9L,0L,0L,1L,1L,7L,5L,0L,8L,8L,1L,3L,1L,6L,0L,9L,8L,7L,0L,7L,4L,0L,3L,0L,5L,5L,2L,2L,9L,1L,4L,2L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021855Inst : IEnumerable<long>
{
public static readonly long[] Value=A021855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021855.Bytes);
public long this[int i]=>Value[i];

public static A021855Inst Instance=new A021855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021854
{
public static readonly long[] Value={ 1L,20L,265L,2940L,29601L,280740L,2558905L,22683980L,197048401L,1685772660L,14253277545L,119401486620L,992861126401L,8206523123780L,67497981692185L,552905862106860L,4513706683463601L,36742894880462100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021854Inst : IEnumerable<long>
{
public static readonly long[] Value=A021854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021854.Bytes);
public long this[int i]=>Value[i];

public static A021854Inst Instance=new A021854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021853
{
public static readonly long[] Value={ 0L,0L,1L,1L,7L,7L,8L,5L,6L,3L,0L,1L,5L,3L,1L,2L,1L,3L,1L,9L,1L,9L,9L,0L,5L,7L,7L,1L,4L,9L,5L,8L,7L,7L,5L,0L,2L,9L,4L,4L,6L,4L,0L,7L,5L,3L,8L,2L,8L,0L,3L,2L,9L,7L,9L,9L,7L,6L,4L,4L,2L,8L,7L,3L,9L,6L,9L,3L,7L,5L,7L,3L,6L,1L,6L,0L,1L,8L,8L,4L,5L,7L,0L,0L,8L,2L,4L,4L,9L,9L,4L,1L,1L,0L,7L,1L,8L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021853Inst : IEnumerable<long>
{
public static readonly long[] Value=A021853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021853.Bytes);
public long this[int i]=>Value[i];

public static A021853Inst Instance=new A021853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021836
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,1L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021836Inst : IEnumerable<long>
{
public static readonly long[] Value=A021836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021836.Bytes);
public long this[int i]=>Value[i];

public static A021836Inst Instance=new A021836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021835
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,3L,3L,6L,9L,4L,3L,4L,4L,1L,6L,3L,6L,5L,8L,2L,4L,3L,0L,8L,0L,6L,2L,5L,7L,5L,2L,1L,0L,5L,8L,9L,6L,5L,1L,0L,2L,2L,8L,6L,4L,0L,1L,9L,2L,5L,3L,9L,1L,0L,9L,5L,0L,6L,6L,1L,8L,5L,3L,1L,8L,8L,9L,2L,9L,0L,0L,1L,2L,0L,3L,3L,6L,9L,4L,3L,4L,4L,1L,6L,3L,6L,5L,8L,2L,4L,3L,0L,8L,0L,6L,2L,5L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021835Inst : IEnumerable<long>
{
public static readonly long[] Value=A021835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021835.Bytes);
public long this[int i]=>Value[i];

public static A021835Inst Instance=new A021835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021834
{
public static readonly long[] Value={ 1L,22L,329L,4226L,50469L,580422L,6541681L,72922570L,808020125L,8923802030L,98376704361L,1083438632562L,11925616635349L,131228622530326L,1443796242996449L,15883448475593882L,174728077773953421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021834Inst : IEnumerable<long>
{
public static readonly long[] Value=A021834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021834.Bytes);
public long this[int i]=>Value[i];

public static A021834Inst Instance=new A021834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021833
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,6L,2L,7L,2L,6L,1L,7L,6L,1L,1L,5L,8L,0L,2L,1L,7L,1L,2L,9L,0L,7L,1L,1L,7L,0L,0L,8L,4L,4L,3L,9L,0L,8L,3L,2L,3L,2L,8L,1L,0L,6L,1L,5L,1L,9L,9L,0L,3L,4L,9L,8L,1L,9L,0L,5L,9L,1L,0L,7L,3L,5L,8L,2L,6L,2L,9L,6L,7L,4L,3L,0L,6L,3L,9L,3L,2L,4L,4L,8L,7L,3L,3L,4L,1L,3L,7L,5L,1L,5L,0L,7L,8L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021833Inst : IEnumerable<long>
{
public static readonly long[] Value=A021833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021833.Bytes);
public long this[int i]=>Value[i];

public static A021833Inst Instance=new A021833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021832
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,7L,7L,2L,9L,4L,6L,8L,5L,9L,9L,0L,3L,3L,8L,1L,6L,4L,2L,5L,1L,2L,0L,7L,7L,2L,9L,4L,6L,8L,5L,9L,9L,0L,3L,3L,8L,1L,6L,4L,2L,5L,1L,2L,0L,7L,7L,2L,9L,4L,6L,8L,5L,9L,9L,0L,3L,3L,8L,1L,6L,4L,2L,5L,1L,2L,0L,7L,7L,2L,9L,4L,6L,8L,5L,9L,9L,0L,3L,3L,8L,1L,6L,4L,2L,5L,1L,2L,0L,7L,7L,2L,9L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021832Inst : IEnumerable<long>
{
public static readonly long[] Value=A021832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021832.Bytes);
public long this[int i]=>Value[i];

public static A021832Inst Instance=new A021832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021831
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,9L,1L,8L,9L,8L,4L,2L,8L,0L,5L,3L,2L,0L,4L,3L,5L,3L,0L,8L,3L,4L,3L,4L,0L,9L,9L,1L,5L,3L,5L,6L,7L,1L,1L,0L,0L,3L,6L,2L,7L,5L,6L,9L,5L,2L,8L,4L,1L,5L,9L,6L,1L,3L,0L,5L,9L,2L,5L,0L,3L,0L,2L,2L,9L,7L,4L,6L,0L,7L,0L,1L,3L,3L,0L,1L,0L,8L,8L,2L,7L,0L,8L,5L,8L,5L,2L,4L,7L,8L,8L,3L,9L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021831Inst : IEnumerable<long>
{
public static readonly long[] Value=A021831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021831.Bytes);
public long this[int i]=>Value[i];

public static A021831Inst Instance=new A021831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021830
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,0L,6L,5L,3L,7L,5L,3L,0L,2L,6L,6L,3L,4L,3L,8L,2L,5L,6L,6L,5L,8L,5L,9L,5L,6L,4L,1L,6L,4L,6L,4L,8L,9L,1L,0L,4L,1L,1L,6L,2L,2L,2L,7L,6L,0L,2L,9L,0L,5L,5L,6L,9L,0L,0L,7L,2L,6L,3L,9L,2L,2L,5L,1L,8L,1L,5L,9L,8L,0L,6L,2L,9L,5L,3L,9L,9L,5L,1L,5L,7L,3L,8L,4L,9L,8L,7L,8L,9L,3L,4L,6L,2L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021830Inst : IEnumerable<long>
{
public static readonly long[] Value=A021830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021830.Bytes);
public long this[int i]=>Value[i];

public static A021830Inst Instance=new A021830Inst();

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